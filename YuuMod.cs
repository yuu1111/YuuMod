using Terraria.ModLoader;

namespace YuuMod
{
	class YuuMod : Mod
	{
		public YuuMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}

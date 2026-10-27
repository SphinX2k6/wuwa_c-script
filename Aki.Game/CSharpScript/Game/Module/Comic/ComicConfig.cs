using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02005B88 RID: 23432
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ComicConfig : ConfigBase
	{
		// Token: 0x0603B491 RID: 242833 RVA: 0x00E21660 File Offset: 0x00E1F860
		public ComicDisplayConfig? GetComicDisplayConfig(int id)
		{
			return ConfigComicDisplayConfigById.GetConfig(id, true);
		}

		// Token: 0x0603B492 RID: 242834 RVA: 0x00E21669 File Offset: 0x00E1F869
		public ComicPrefabConfig? GetComicPrefabConfig(int id)
		{
			return ConfigComicPrefabConfigById.GetConfig(id, true);
		}

		// Token: 0x17008CD1 RID: 36049
		// (get) Token: 0x0603B493 RID: 242835 RVA: 0x00E21672 File Offset: 0x00E1F872
		public static ComicConfig Instance
		{
			get
			{
				return ComicConfig._Instance;
			}
		}

		// Token: 0x0603B494 RID: 242836 RVA: 0x00E21679 File Offset: 0x00E1F879
		public static ComicConfig GetOrCreateInstance()
		{
			if (ComicConfig._Instance == null)
			{
				ComicConfig.CreateInstance();
			}
			return ComicConfig._Instance;
		}

		// Token: 0x0603B495 RID: 242837 RVA: 0x00E2168D File Offset: 0x00E1F88D
		public static bool CreateInstance()
		{
			if (ComicConfig._Instance != null)
			{
				return true;
			}
			ComicConfig._Instance = new ComicConfig();
			return true;
		}

		// Token: 0x0603B496 RID: 242838 RVA: 0x00E216A3 File Offset: 0x00E1F8A3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B497 RID: 242839 RVA: 0x00E216A5 File Offset: 0x00E1F8A5
		public static void ResetStaticDefaultValue()
		{
			ComicConfig._Instance = null;
		}

		// Token: 0x0603B498 RID: 242840 RVA: 0x00E216AD File Offset: 0x00E1F8AD
		static ComicConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComicConfig.CreateStaticDefaultValue), new Action(ComicConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401EE77 RID: 126583
		[Nullable(2)]
		private static ComicConfig _Instance;
	}
}

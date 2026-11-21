using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02004B68 RID: 19304
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ComicConfig : ConfigBase
	{
		// Token: 0x060303DE RID: 197598 RVA: 0x00D71BCC File Offset: 0x00D6FDCC
		public ComicDisplayConfig? GetComicDisplayConfig(int id)
		{
			return ConfigComicDisplayConfigById.GetConfig(id, true);
		}

		// Token: 0x060303DF RID: 197599 RVA: 0x00D71BD5 File Offset: 0x00D6FDD5
		public ComicPrefabConfig? GetComicPrefabConfig(int id)
		{
			return ConfigComicPrefabConfigById.GetConfig(id, true);
		}

		// Token: 0x170060A3 RID: 24739
		// (get) Token: 0x060303E0 RID: 197600 RVA: 0x00D71BDE File Offset: 0x00D6FDDE
		public static ComicConfig Instance
		{
			get
			{
				return ComicConfig._Instance;
			}
		}

		// Token: 0x060303E1 RID: 197601 RVA: 0x00D71BE5 File Offset: 0x00D6FDE5
		public static ComicConfig GetOrCreateInstance()
		{
			if (ComicConfig._Instance == null)
			{
				ComicConfig.CreateInstance();
			}
			return ComicConfig._Instance;
		}

		// Token: 0x060303E2 RID: 197602 RVA: 0x00D71BF9 File Offset: 0x00D6FDF9
		public static bool CreateInstance()
		{
			if (ComicConfig._Instance != null)
			{
				return true;
			}
			ComicConfig._Instance = new ComicConfig();
			return true;
		}

		// Token: 0x060303E3 RID: 197603 RVA: 0x00D71C0F File Offset: 0x00D6FE0F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060303E4 RID: 197604 RVA: 0x00D71C11 File Offset: 0x00D6FE11
		public static void ResetStaticDefaultValue()
		{
			ComicConfig._Instance = null;
		}

		// Token: 0x060303E5 RID: 197605 RVA: 0x00D71C19 File Offset: 0x00D6FE19
		static ComicConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComicConfig.CreateStaticDefaultValue), new Action(ComicConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04019928 RID: 104744
		[Nullable(2)]
		private static ComicConfig _Instance;
	}
}

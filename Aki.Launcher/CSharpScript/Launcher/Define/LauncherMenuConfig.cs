using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000241 RID: 577
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherMenuConfig
	{
		// Token: 0x06000E8B RID: 3723 RVA: 0x00056473 File Offset: 0x00054673
		private LauncherMenuConfig(int functionId, int optionsDefault)
		{
			this.FunctionId = functionId;
			this.OptionsDefault = optionsDefault;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00056489 File Offset: 0x00054689
		public static string GetTableName()
		{
			return "MenuConfig";
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00056490 File Offset: 0x00054690
		public static string GetLanguageTableName()
		{
			return "LanguageDefine";
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00056497 File Offset: 0x00054697
		public static string GetTableFile()
		{
			return "s.设置系统.xlsx";
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x000564A0 File Offset: 0x000546A0
		public static LauncherMenuConfig Parse(UKuroSqliteResultSet rs)
		{
			int functionId = 0;
			if (!rs.GetInt("FunctionId", ref functionId))
			{
				return null;
			}
			int optionsDefault = 0;
			if (!rs.GetInt("OptionsDefault", ref optionsDefault))
			{
				return null;
			}
			return new LauncherMenuConfig(functionId, optionsDefault);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000564DC File Offset: 0x000546DC
		public static LaunchLanguageDefineConfig ParseLanguageDefine(UKuroSqliteResultSet rs)
		{
			int languageType = 0;
			if (!rs.GetInt("LanguageType", ref languageType))
			{
				return null;
			}
			bool isShow = false;
			if (!rs.GetBool("IsShow", ref isShow))
			{
				return null;
			}
			return new LaunchLanguageDefineConfig(languageType, isShow);
		}

		// Token: 0x04000964 RID: 2404
		private const string TableName = "MenuConfig";

		// Token: 0x04000965 RID: 2405
		private const string LanguageTableName = "LanguageDefine";

		// Token: 0x04000966 RID: 2406
		private const string TableFile = "s.设置系统.xlsx";

		// Token: 0x04000967 RID: 2407
		public readonly int FunctionId;

		// Token: 0x04000968 RID: 2408
		public readonly int OptionsDefault;
	}
}

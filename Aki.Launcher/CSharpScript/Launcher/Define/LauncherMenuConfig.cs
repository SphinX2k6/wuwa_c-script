using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000246 RID: 582
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherMenuConfig
	{
		// Token: 0x06000ECC RID: 3788 RVA: 0x00058FB7 File Offset: 0x000571B7
		private LauncherMenuConfig(int functionId, int optionsDefault)
		{
			this.FunctionId = functionId;
			this.OptionsDefault = optionsDefault;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00058FCD File Offset: 0x000571CD
		public static string GetTableName()
		{
			return "MenuConfig";
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00058FD4 File Offset: 0x000571D4
		public static string GetLanguageTableName()
		{
			return "LanguageDefine";
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00058FDB File Offset: 0x000571DB
		public static string GetTableFile()
		{
			return "s.设置系统.xlsx";
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00058FE4 File Offset: 0x000571E4
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

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00059020 File Offset: 0x00057220
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

		// Token: 0x040009AC RID: 2476
		private const string TableName = "MenuConfig";

		// Token: 0x040009AD RID: 2477
		private const string LanguageTableName = "LanguageDefine";

		// Token: 0x040009AE RID: 2478
		private const string TableFile = "s.设置系统.xlsx";

		// Token: 0x040009AF RID: 2479
		public readonly int FunctionId;

		// Token: 0x040009B0 RID: 2480
		public readonly int OptionsDefault;
	}
}

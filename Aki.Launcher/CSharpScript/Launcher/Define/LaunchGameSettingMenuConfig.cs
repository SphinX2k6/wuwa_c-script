using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000248 RID: 584
	[NullableContext(1)]
	[Nullable(0)]
	public class LaunchGameSettingMenuConfig
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x000590AA File Offset: 0x000572AA
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x000590B2 File Offset: 0x000572B2
		public int FunctionId { get; private set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x000590BB File Offset: 0x000572BB
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x000590C3 File Offset: 0x000572C3
		public int OptionsDefault { get; private set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x000590CC File Offset: 0x000572CC
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x000590D4 File Offset: 0x000572D4
		public float SliderDefault { get; private set; }

		// Token: 0x06000EDD RID: 3805 RVA: 0x000590DD File Offset: 0x000572DD
		private LaunchGameSettingMenuConfig(int functionId, int optionsDefault, float sliderDefault)
		{
			this.FunctionId = functionId;
			this.OptionsDefault = optionsDefault;
			this.SliderDefault = sliderDefault;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000590FA File Offset: 0x000572FA
		public static string GetTableName()
		{
			return "MenuConfig";
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00059101 File Offset: 0x00057301
		public static string GetLanguageTableName()
		{
			return "LanguageDefine";
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00059108 File Offset: 0x00057308
		public static string GetTableFile()
		{
			return "s.设置系统.xlsx";
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00059110 File Offset: 0x00057310
		public static LaunchGameSettingMenuConfig Parse(UKuroSqliteResultSet rs)
		{
			int functionId = 0;
			if (!rs.GetInt("FunctionId", ref functionId))
			{
				LauncherLog.Instance.Warn("[GameSettings]解析MenuConfig失败-找不到FunctionId", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			int optionsDefault = 0;
			if (!rs.GetInt("OptionsDefault", ref optionsDefault))
			{
				LauncherLog.Instance.Warn("[GameSettings]解析MenuConfig失败-找不到OptionsDefault", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			float sliderDefault = 0f;
			if (!rs.GetFloat("SliderDefault", ref sliderDefault))
			{
				LauncherLog.Instance.Warn("[GameSettings]解析MenuConfig失败-找不到SliderDefault", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return new LaunchGameSettingMenuConfig(functionId, optionsDefault, sliderDefault);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000591AA File Offset: 0x000573AA
		public float GetDefaultValue()
		{
			if (this.SliderDefault == 0f)
			{
				return (float)this.OptionsDefault;
			}
			return this.SliderDefault;
		}

		// Token: 0x040009B3 RID: 2483
		private const string TableName = "MenuConfig";

		// Token: 0x040009B4 RID: 2484
		private const string LanguageTableName = "LanguageDefine";

		// Token: 0x040009B5 RID: 2485
		private const string TableFile = "s.设置系统.xlsx";
	}
}

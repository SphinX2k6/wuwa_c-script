using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000243 RID: 579
	[NullableContext(1)]
	[Nullable(0)]
	public class LaunchGameSettingMenuConfig
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00056566 File Offset: 0x00054766
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x0005656E File Offset: 0x0005476E
		public int FunctionId { get; private set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00056577 File Offset: 0x00054777
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x0005657F File Offset: 0x0005477F
		public int OptionsDefault { get; private set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00056588 File Offset: 0x00054788
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00056590 File Offset: 0x00054790
		public float SliderDefault { get; private set; }

		// Token: 0x06000E9C RID: 3740 RVA: 0x00056599 File Offset: 0x00054799
		private LaunchGameSettingMenuConfig(int functionId, int optionsDefault, float sliderDefault)
		{
			this.FunctionId = functionId;
			this.OptionsDefault = optionsDefault;
			this.SliderDefault = sliderDefault;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000565B6 File Offset: 0x000547B6
		public static string GetTableName()
		{
			return "MenuConfig";
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000565BD File Offset: 0x000547BD
		public static string GetLanguageTableName()
		{
			return "LanguageDefine";
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000565C4 File Offset: 0x000547C4
		public static string GetTableFile()
		{
			return "s.设置系统.xlsx";
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x000565CC File Offset: 0x000547CC
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

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00056666 File Offset: 0x00054866
		public float GetDefaultValue()
		{
			if (this.SliderDefault == 0f)
			{
				return (float)this.OptionsDefault;
			}
			return this.SliderDefault;
		}

		// Token: 0x0400096B RID: 2411
		private const string TableName = "MenuConfig";

		// Token: 0x0400096C RID: 2412
		private const string LanguageTableName = "LanguageDefine";

		// Token: 0x0400096D RID: 2413
		private const string TableFile = "s.设置系统.xlsx";
	}
}

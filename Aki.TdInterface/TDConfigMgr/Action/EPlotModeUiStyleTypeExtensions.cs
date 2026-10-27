using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D9 RID: 9177
	public static class EPlotModeUiStyleTypeExtensions
	{
		// Token: 0x0600C7CF RID: 51151 RVA: 0x001D3FF0 File Offset: 0x001D21F0
		public static string ToEnumString(this EPlotModeUiStyleType value)
		{
			string result;
			if (value == EPlotModeUiStyleType.LevelD)
			{
				result = "LevelD";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C7D0 RID: 51152 RVA: 0x001D4018 File Offset: 0x001D2218
		public static EPlotModeUiStyleType FromString(string name)
		{
			EPlotModeUiStyleType result;
			if (!EPlotModeUiStyleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlotModeUiStyleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7D1 RID: 51153 RVA: 0x001D4041 File Offset: 0x001D2241
		public static bool TryFromString(string name, out EPlotModeUiStyleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlotModeUiStyleType.LevelD;
				return false;
			}
			if (name == "LevelD")
			{
				value = EPlotModeUiStyleType.LevelD;
				return true;
			}
			value = EPlotModeUiStyleType.LevelD;
			return false;
		}

		// Token: 0x0600C7D2 RID: 51154 RVA: 0x001D4066 File Offset: 0x001D2266
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelD"
			};
		}

		// Token: 0x0600C7D3 RID: 51155 RVA: 0x001D4076 File Offset: 0x001D2276
		public static EPlotModeUiStyleType[] GetValues()
		{
			return new EPlotModeUiStyleType[1];
		}

		// Token: 0x0600C7D4 RID: 51156 RVA: 0x001D407E File Offset: 0x001D227E
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelD"
			};
		}
	}
}

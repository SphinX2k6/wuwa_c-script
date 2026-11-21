using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002670 RID: 9840
	public static class EPlotModeUiStyleTypeExtensions
	{
		// Token: 0x0600D452 RID: 54354 RVA: 0x001ED79C File Offset: 0x001EB99C
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

		// Token: 0x0600D453 RID: 54355 RVA: 0x001ED7C4 File Offset: 0x001EB9C4
		public static EPlotModeUiStyleType FromString(string name)
		{
			EPlotModeUiStyleType result;
			if (!EPlotModeUiStyleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlotModeUiStyleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D454 RID: 54356 RVA: 0x001ED7ED File Offset: 0x001EB9ED
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

		// Token: 0x0600D455 RID: 54357 RVA: 0x001ED812 File Offset: 0x001EBA12
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelD"
			};
		}

		// Token: 0x0600D456 RID: 54358 RVA: 0x001ED822 File Offset: 0x001EBA22
		public static EPlotModeUiStyleType[] GetValues()
		{
			return new EPlotModeUiStyleType[1];
		}

		// Token: 0x0600D457 RID: 54359 RVA: 0x001ED82A File Offset: 0x001EBA2A
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelD"
			};
		}
	}
}

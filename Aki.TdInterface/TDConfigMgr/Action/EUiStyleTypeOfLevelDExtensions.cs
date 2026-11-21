using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002736 RID: 10038
	public static class EUiStyleTypeOfLevelDExtensions
	{
		// Token: 0x0600D7CD RID: 55245 RVA: 0x001F87D0 File Offset: 0x001F69D0
		public static string ToEnumString(this EUiStyleTypeOfLevelD value)
		{
			string result;
			if (value != EUiStyleTypeOfLevelD.GiantSubtitle)
			{
				if (value != EUiStyleTypeOfLevelD.PlayPiano)
				{
					result = value.ToString();
				}
				else
				{
					result = "PlayPiano";
				}
			}
			else
			{
				result = "GiantSubtitle";
			}
			return result;
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x001F8808 File Offset: 0x001F6A08
		public static EUiStyleTypeOfLevelD FromString(string name)
		{
			EUiStyleTypeOfLevelD result;
			if (!EUiStyleTypeOfLevelDExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUiStyleTypeOfLevelD 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7CF RID: 55247 RVA: 0x001F8831 File Offset: 0x001F6A31
		public static bool TryFromString(string name, out EUiStyleTypeOfLevelD value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EUiStyleTypeOfLevelD.GiantSubtitle;
				return false;
			}
			if (name == "GiantSubtitle")
			{
				value = EUiStyleTypeOfLevelD.GiantSubtitle;
				return true;
			}
			if (!(name == "PlayPiano"))
			{
				value = EUiStyleTypeOfLevelD.GiantSubtitle;
				return false;
			}
			value = EUiStyleTypeOfLevelD.PlayPiano;
			return true;
		}

		// Token: 0x0600D7D0 RID: 55248 RVA: 0x001F886A File Offset: 0x001F6A6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GiantSubtitle",
				"PlayPiano"
			};
		}

		// Token: 0x0600D7D1 RID: 55249 RVA: 0x001F8882 File Offset: 0x001F6A82
		public static EUiStyleTypeOfLevelD[] GetValues()
		{
			return new EUiStyleTypeOfLevelD[]
			{
				EUiStyleTypeOfLevelD.GiantSubtitle,
				EUiStyleTypeOfLevelD.PlayPiano
			};
		}

		// Token: 0x0600D7D2 RID: 55250 RVA: 0x001F888E File Offset: 0x001F6A8E
		public static string[] GetNames()
		{
			return new string[]
			{
				"GiantSubtitle",
				"PlayPiano"
			};
		}
	}
}

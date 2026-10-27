using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002493 RID: 9363
	public static class EUiStyleTypeOfLevelDExtensions
	{
		// Token: 0x0600CB14 RID: 51988 RVA: 0x001DE608 File Offset: 0x001DC808
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

		// Token: 0x0600CB15 RID: 51989 RVA: 0x001DE640 File Offset: 0x001DC840
		public static EUiStyleTypeOfLevelD FromString(string name)
		{
			EUiStyleTypeOfLevelD result;
			if (!EUiStyleTypeOfLevelDExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUiStyleTypeOfLevelD 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB16 RID: 51990 RVA: 0x001DE669 File Offset: 0x001DC869
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

		// Token: 0x0600CB17 RID: 51991 RVA: 0x001DE6A2 File Offset: 0x001DC8A2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GiantSubtitle",
				"PlayPiano"
			};
		}

		// Token: 0x0600CB18 RID: 51992 RVA: 0x001DE6BA File Offset: 0x001DC8BA
		public static EUiStyleTypeOfLevelD[] GetValues()
		{
			return new EUiStyleTypeOfLevelD[]
			{
				EUiStyleTypeOfLevelD.GiantSubtitle,
				EUiStyleTypeOfLevelD.PlayPiano
			};
		}

		// Token: 0x0600CB19 RID: 51993 RVA: 0x001DE6C6 File Offset: 0x001DC8C6
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

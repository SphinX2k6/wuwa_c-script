using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002566 RID: 9574
	public static class EDarkTideMapMarkStateTypeExtensions
	{
		// Token: 0x0600CFA5 RID: 53157 RVA: 0x001E188C File Offset: 0x001DFA8C
		public static string ToEnumString(this EDarkTideMapMarkStateType value)
		{
			string result;
			switch (value)
			{
			case EDarkTideMapMarkStateType.Hide:
				result = "Hide";
				break;
			case EDarkTideMapMarkStateType.Show:
				result = "Show";
				break;
			case EDarkTideMapMarkStateType.Complete:
				result = "Complete";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CFA6 RID: 53158 RVA: 0x001E18D4 File Offset: 0x001DFAD4
		public static EDarkTideMapMarkStateType FromString(string name)
		{
			EDarkTideMapMarkStateType result;
			if (!EDarkTideMapMarkStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDarkTideMapMarkStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFA7 RID: 53159 RVA: 0x001E1900 File Offset: 0x001DFB00
		public static bool TryFromString(string name, out EDarkTideMapMarkStateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDarkTideMapMarkStateType.Hide;
				return false;
			}
			if (name == "Hide")
			{
				value = EDarkTideMapMarkStateType.Hide;
				return true;
			}
			if (name == "Show")
			{
				value = EDarkTideMapMarkStateType.Show;
				return true;
			}
			if (!(name == "Complete"))
			{
				value = EDarkTideMapMarkStateType.Hide;
				return false;
			}
			value = EDarkTideMapMarkStateType.Complete;
			return true;
		}

		// Token: 0x0600CFA8 RID: 53160 RVA: 0x001E1956 File Offset: 0x001DFB56
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Hide",
				"Show",
				"Complete"
			};
		}

		// Token: 0x0600CFA9 RID: 53161 RVA: 0x001E1976 File Offset: 0x001DFB76
		public static EDarkTideMapMarkStateType[] GetValues()
		{
			return new EDarkTideMapMarkStateType[]
			{
				EDarkTideMapMarkStateType.Hide,
				EDarkTideMapMarkStateType.Show,
				EDarkTideMapMarkStateType.Complete
			};
		}

		// Token: 0x0600CFAA RID: 53162 RVA: 0x001E1986 File Offset: 0x001DFB86
		public static string[] GetNames()
		{
			return new string[]
			{
				"Hide",
				"Show",
				"Complete"
			};
		}
	}
}

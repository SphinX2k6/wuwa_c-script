using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025E8 RID: 9704
	public static class ELiveDanmakuClearTypeExtensions
	{
		// Token: 0x0600D1EE RID: 53742 RVA: 0x001E85C4 File Offset: 0x001E67C4
		public static string ToEnumString(this ELiveDanmakuClearType value)
		{
			string result;
			if (value != ELiveDanmakuClearType.FinishCurrent)
			{
				if (value != ELiveDanmakuClearType.ClearScreen)
				{
					result = value.ToString();
				}
				else
				{
					result = "ClearScreen";
				}
			}
			else
			{
				result = "FinishCurrent";
			}
			return result;
		}

		// Token: 0x0600D1EF RID: 53743 RVA: 0x001E85FC File Offset: 0x001E67FC
		public static ELiveDanmakuClearType FromString(string name)
		{
			ELiveDanmakuClearType result;
			if (!ELiveDanmakuClearTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveDanmakuClearType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D1F0 RID: 53744 RVA: 0x001E8625 File Offset: 0x001E6825
		public static bool TryFromString(string name, out ELiveDanmakuClearType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveDanmakuClearType.FinishCurrent;
				return false;
			}
			if (name == "FinishCurrent")
			{
				value = ELiveDanmakuClearType.FinishCurrent;
				return true;
			}
			if (!(name == "ClearScreen"))
			{
				value = ELiveDanmakuClearType.FinishCurrent;
				return false;
			}
			value = ELiveDanmakuClearType.ClearScreen;
			return true;
		}

		// Token: 0x0600D1F1 RID: 53745 RVA: 0x001E865E File Offset: 0x001E685E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FinishCurrent",
				"ClearScreen"
			};
		}

		// Token: 0x0600D1F2 RID: 53746 RVA: 0x001E8676 File Offset: 0x001E6876
		public static ELiveDanmakuClearType[] GetValues()
		{
			return new ELiveDanmakuClearType[]
			{
				ELiveDanmakuClearType.FinishCurrent,
				ELiveDanmakuClearType.ClearScreen
			};
		}

		// Token: 0x0600D1F3 RID: 53747 RVA: 0x001E8682 File Offset: 0x001E6882
		public static string[] GetNames()
		{
			return new string[]
			{
				"FinishCurrent",
				"ClearScreen"
			};
		}
	}
}

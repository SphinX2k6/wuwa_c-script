using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001228 RID: 4648
	public static class EBindingProgressTypeExtensions
	{
		// Token: 0x0600695B RID: 26971 RVA: 0x000FB030 File Offset: 0x000F9230
		public static string ToEnumString(this EBindingProgressType value)
		{
			string result;
			if (value == EBindingProgressType.PlayerHavingItemCount)
			{
				result = "PlayerHavingItemCount";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x000FB058 File Offset: 0x000F9258
		public static EBindingProgressType FromString(string name)
		{
			EBindingProgressType result;
			if (!EBindingProgressTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBindingProgressType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600695D RID: 26973 RVA: 0x000FB081 File Offset: 0x000F9281
		public static bool TryFromString(string name, out EBindingProgressType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBindingProgressType.PlayerHavingItemCount;
				return false;
			}
			if (name == "PlayerHavingItemCount")
			{
				value = EBindingProgressType.PlayerHavingItemCount;
				return true;
			}
			value = EBindingProgressType.PlayerHavingItemCount;
			return false;
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x000FB0A6 File Offset: 0x000F92A6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayerHavingItemCount"
			};
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x000FB0B6 File Offset: 0x000F92B6
		public static EBindingProgressType[] GetValues()
		{
			return new EBindingProgressType[1];
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x000FB0BE File Offset: 0x000F92BE
		public static string[] GetNames()
		{
			return new string[]
			{
				"PlayerHavingItemCount"
			};
		}
	}
}

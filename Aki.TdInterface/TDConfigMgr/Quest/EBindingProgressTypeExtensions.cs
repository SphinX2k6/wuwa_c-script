using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001364 RID: 4964
	public static class EBindingProgressTypeExtensions
	{
		// Token: 0x06006F9C RID: 28572 RVA: 0x0010893C File Offset: 0x00106B3C
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

		// Token: 0x06006F9D RID: 28573 RVA: 0x00108964 File Offset: 0x00106B64
		public static EBindingProgressType FromString(string name)
		{
			EBindingProgressType result;
			if (!EBindingProgressTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBindingProgressType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x0010898D File Offset: 0x00106B8D
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

		// Token: 0x06006F9F RID: 28575 RVA: 0x001089B2 File Offset: 0x00106BB2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayerHavingItemCount"
			};
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x001089C2 File Offset: 0x00106BC2
		public static EBindingProgressType[] GetValues()
		{
			return new EBindingProgressType[1];
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x001089CA File Offset: 0x00106BCA
		public static string[] GetNames()
		{
			return new string[]
			{
				"PlayerHavingItemCount"
			};
		}
	}
}

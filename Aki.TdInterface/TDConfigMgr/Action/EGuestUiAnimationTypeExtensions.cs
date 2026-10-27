using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234F RID: 9039
	public static class EGuestUiAnimationTypeExtensions
	{
		// Token: 0x0600C562 RID: 50530 RVA: 0x001CCF3C File Offset: 0x001CB13C
		public static string ToEnumString(this EGuestUiAnimationType value)
		{
			string result;
			if (value == EGuestUiAnimationType.GuestCartethyia)
			{
				result = "GuestCartethyia";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C563 RID: 50531 RVA: 0x001CCF64 File Offset: 0x001CB164
		public static EGuestUiAnimationType FromString(string name)
		{
			EGuestUiAnimationType result;
			if (!EGuestUiAnimationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGuestUiAnimationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C564 RID: 50532 RVA: 0x001CCF8D File Offset: 0x001CB18D
		public static bool TryFromString(string name, out EGuestUiAnimationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGuestUiAnimationType.GuestCartethyia;
				return false;
			}
			if (name == "GuestCartethyia")
			{
				value = EGuestUiAnimationType.GuestCartethyia;
				return true;
			}
			value = EGuestUiAnimationType.GuestCartethyia;
			return false;
		}

		// Token: 0x0600C565 RID: 50533 RVA: 0x001CCFB2 File Offset: 0x001CB1B2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GuestCartethyia"
			};
		}

		// Token: 0x0600C566 RID: 50534 RVA: 0x001CCFC2 File Offset: 0x001CB1C2
		public static EGuestUiAnimationType[] GetValues()
		{
			return new EGuestUiAnimationType[1];
		}

		// Token: 0x0600C567 RID: 50535 RVA: 0x001CCFCA File Offset: 0x001CB1CA
		public static string[] GetNames()
		{
			return new string[]
			{
				"GuestCartethyia"
			};
		}
	}
}

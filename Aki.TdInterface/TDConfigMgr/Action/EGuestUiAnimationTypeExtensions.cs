using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C2 RID: 9666
	public static class EGuestUiAnimationTypeExtensions
	{
		// Token: 0x0600D143 RID: 53571 RVA: 0x001E5108 File Offset: 0x001E3308
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

		// Token: 0x0600D144 RID: 53572 RVA: 0x001E5130 File Offset: 0x001E3330
		public static EGuestUiAnimationType FromString(string name)
		{
			EGuestUiAnimationType result;
			if (!EGuestUiAnimationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGuestUiAnimationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D145 RID: 53573 RVA: 0x001E5159 File Offset: 0x001E3359
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

		// Token: 0x0600D146 RID: 53574 RVA: 0x001E517E File Offset: 0x001E337E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GuestCartethyia"
			};
		}

		// Token: 0x0600D147 RID: 53575 RVA: 0x001E518E File Offset: 0x001E338E
		public static EGuestUiAnimationType[] GetValues()
		{
			return new EGuestUiAnimationType[1];
		}

		// Token: 0x0600D148 RID: 53576 RVA: 0x001E5196 File Offset: 0x001E3396
		public static string[] GetNames()
		{
			return new string[]
			{
				"GuestCartethyia"
			};
		}
	}
}

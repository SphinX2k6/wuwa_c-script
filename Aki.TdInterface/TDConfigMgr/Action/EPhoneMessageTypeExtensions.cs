using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C3 RID: 9155
	public static class EPhoneMessageTypeExtensions
	{
		// Token: 0x0600C76C RID: 51052 RVA: 0x001D315C File Offset: 0x001D135C
		public static string ToEnumString(this EPhoneMessageType value)
		{
			string result;
			switch (value)
			{
			case EPhoneMessageType.Voice:
				result = "Voice";
				break;
			case EPhoneMessageType.Emoji:
				result = "Emoji";
				break;
			case EPhoneMessageType.Attachment:
				result = "Attachment";
				break;
			case EPhoneMessageType.SystemTip:
				result = "SystemTip";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C76D RID: 51053 RVA: 0x001D31B0 File Offset: 0x001D13B0
		public static EPhoneMessageType FromString(string name)
		{
			EPhoneMessageType result;
			if (!EPhoneMessageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneMessageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C76E RID: 51054 RVA: 0x001D31DC File Offset: 0x001D13DC
		public static bool TryFromString(string name, out EPhoneMessageType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPhoneMessageType.Voice;
				return false;
			}
			if (name == "Voice")
			{
				value = EPhoneMessageType.Voice;
				return true;
			}
			if (name == "Emoji")
			{
				value = EPhoneMessageType.Emoji;
				return true;
			}
			if (name == "Attachment")
			{
				value = EPhoneMessageType.Attachment;
				return true;
			}
			if (!(name == "SystemTip"))
			{
				value = EPhoneMessageType.Voice;
				return false;
			}
			value = EPhoneMessageType.SystemTip;
			return true;
		}

		// Token: 0x0600C76F RID: 51055 RVA: 0x001D3244 File Offset: 0x001D1444
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Voice",
				"Emoji",
				"Attachment",
				"SystemTip"
			};
		}

		// Token: 0x0600C770 RID: 51056 RVA: 0x001D326C File Offset: 0x001D146C
		public static EPhoneMessageType[] GetValues()
		{
			return new EPhoneMessageType[]
			{
				EPhoneMessageType.Voice,
				EPhoneMessageType.Emoji,
				EPhoneMessageType.Attachment,
				EPhoneMessageType.SystemTip
			};
		}

		// Token: 0x0600C771 RID: 51057 RVA: 0x001D327F File Offset: 0x001D147F
		public static string[] GetNames()
		{
			return new string[]
			{
				"Voice",
				"Emoji",
				"Attachment",
				"SystemTip"
			};
		}
	}
}

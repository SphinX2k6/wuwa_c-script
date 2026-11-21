using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002658 RID: 9816
	public static class EPhoneMessageTypeExtensions
	{
		// Token: 0x0600D3E6 RID: 54246 RVA: 0x001EC7F4 File Offset: 0x001EA9F4
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

		// Token: 0x0600D3E7 RID: 54247 RVA: 0x001EC848 File Offset: 0x001EAA48
		public static EPhoneMessageType FromString(string name)
		{
			EPhoneMessageType result;
			if (!EPhoneMessageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneMessageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3E8 RID: 54248 RVA: 0x001EC874 File Offset: 0x001EAA74
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

		// Token: 0x0600D3E9 RID: 54249 RVA: 0x001EC8DC File Offset: 0x001EAADC
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

		// Token: 0x0600D3EA RID: 54250 RVA: 0x001EC904 File Offset: 0x001EAB04
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

		// Token: 0x0600D3EB RID: 54251 RVA: 0x001EC917 File Offset: 0x001EAB17
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

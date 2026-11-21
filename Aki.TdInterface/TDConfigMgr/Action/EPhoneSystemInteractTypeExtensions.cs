using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200265C RID: 9820
	public static class EPhoneSystemInteractTypeExtensions
	{
		// Token: 0x0600D3F8 RID: 54264 RVA: 0x001ECA90 File Offset: 0x001EAC90
		public static string ToEnumString(this EPhoneSystemInteractType value)
		{
			string result;
			switch (value)
			{
			case EPhoneSystemInteractType.SendPhoneMessage:
				result = "SendPhoneMessage";
				break;
			case EPhoneSystemInteractType.DeletePhoneMessage:
				result = "DeletePhoneMessage";
				break;
			case EPhoneSystemInteractType.OpenPhoneMessageBoard:
				result = "OpenPhoneMessageBoard";
				break;
			case EPhoneSystemInteractType.FlowOpenPhoneMessage:
				result = "FlowOpenPhoneMessage";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D3F9 RID: 54265 RVA: 0x001ECAE4 File Offset: 0x001EACE4
		public static EPhoneSystemInteractType FromString(string name)
		{
			EPhoneSystemInteractType result;
			if (!EPhoneSystemInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneSystemInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3FA RID: 54266 RVA: 0x001ECB10 File Offset: 0x001EAD10
		public static bool TryFromString(string name, out EPhoneSystemInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPhoneSystemInteractType.SendPhoneMessage;
				return false;
			}
			if (name == "SendPhoneMessage")
			{
				value = EPhoneSystemInteractType.SendPhoneMessage;
				return true;
			}
			if (name == "DeletePhoneMessage")
			{
				value = EPhoneSystemInteractType.DeletePhoneMessage;
				return true;
			}
			if (name == "OpenPhoneMessageBoard")
			{
				value = EPhoneSystemInteractType.OpenPhoneMessageBoard;
				return true;
			}
			if (!(name == "FlowOpenPhoneMessage"))
			{
				value = EPhoneSystemInteractType.SendPhoneMessage;
				return false;
			}
			value = EPhoneSystemInteractType.FlowOpenPhoneMessage;
			return true;
		}

		// Token: 0x0600D3FB RID: 54267 RVA: 0x001ECB78 File Offset: 0x001EAD78
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SendPhoneMessage",
				"DeletePhoneMessage",
				"OpenPhoneMessageBoard",
				"FlowOpenPhoneMessage"
			};
		}

		// Token: 0x0600D3FC RID: 54268 RVA: 0x001ECBA0 File Offset: 0x001EADA0
		public static EPhoneSystemInteractType[] GetValues()
		{
			return new EPhoneSystemInteractType[]
			{
				EPhoneSystemInteractType.SendPhoneMessage,
				EPhoneSystemInteractType.DeletePhoneMessage,
				EPhoneSystemInteractType.OpenPhoneMessageBoard,
				EPhoneSystemInteractType.FlowOpenPhoneMessage
			};
		}

		// Token: 0x0600D3FD RID: 54269 RVA: 0x001ECBB3 File Offset: 0x001EADB3
		public static string[] GetNames()
		{
			return new string[]
			{
				"SendPhoneMessage",
				"DeletePhoneMessage",
				"OpenPhoneMessageBoard",
				"FlowOpenPhoneMessage"
			};
		}
	}
}

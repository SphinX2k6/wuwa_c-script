using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C7 RID: 9159
	public static class EPhoneSystemInteractTypeExtensions
	{
		// Token: 0x0600C77E RID: 51070 RVA: 0x001D33F8 File Offset: 0x001D15F8
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

		// Token: 0x0600C77F RID: 51071 RVA: 0x001D344C File Offset: 0x001D164C
		public static EPhoneSystemInteractType FromString(string name)
		{
			EPhoneSystemInteractType result;
			if (!EPhoneSystemInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneSystemInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C780 RID: 51072 RVA: 0x001D3478 File Offset: 0x001D1678
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

		// Token: 0x0600C781 RID: 51073 RVA: 0x001D34E0 File Offset: 0x001D16E0
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

		// Token: 0x0600C782 RID: 51074 RVA: 0x001D3508 File Offset: 0x001D1708
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

		// Token: 0x0600C783 RID: 51075 RVA: 0x001D351B File Offset: 0x001D171B
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

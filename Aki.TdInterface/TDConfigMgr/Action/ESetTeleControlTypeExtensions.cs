using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200240F RID: 9231
	public static class ESetTeleControlTypeExtensions
	{
		// Token: 0x0600C8C2 RID: 51394 RVA: 0x001D5F88 File Offset: 0x001D4188
		public static string ToEnumString(this ESetTeleControlType value)
		{
			string result;
			if (value != ESetTeleControlType.OpenGravity)
			{
				if (value != ESetTeleControlType.SetResetPosition)
				{
					result = value.ToString();
				}
				else
				{
					result = "SetResetPosition";
				}
			}
			else
			{
				result = "OpenGravity";
			}
			return result;
		}

		// Token: 0x0600C8C3 RID: 51395 RVA: 0x001D5FC0 File Offset: 0x001D41C0
		public static ESetTeleControlType FromString(string name)
		{
			ESetTeleControlType result;
			if (!ESetTeleControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetTeleControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8C4 RID: 51396 RVA: 0x001D5FE9 File Offset: 0x001D41E9
		public static bool TryFromString(string name, out ESetTeleControlType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetTeleControlType.OpenGravity;
				return false;
			}
			if (name == "OpenGravity")
			{
				value = ESetTeleControlType.OpenGravity;
				return true;
			}
			if (!(name == "SetResetPosition"))
			{
				value = ESetTeleControlType.OpenGravity;
				return false;
			}
			value = ESetTeleControlType.SetResetPosition;
			return true;
		}

		// Token: 0x0600C8C5 RID: 51397 RVA: 0x001D6022 File Offset: 0x001D4222
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OpenGravity",
				"SetResetPosition"
			};
		}

		// Token: 0x0600C8C6 RID: 51398 RVA: 0x001D603A File Offset: 0x001D423A
		public static ESetTeleControlType[] GetValues()
		{
			return new ESetTeleControlType[]
			{
				ESetTeleControlType.OpenGravity,
				ESetTeleControlType.SetResetPosition
			};
		}

		// Token: 0x0600C8C7 RID: 51399 RVA: 0x001D6046 File Offset: 0x001D4246
		public static string[] GetNames()
		{
			return new string[]
			{
				"OpenGravity",
				"SetResetPosition"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026AE RID: 9902
	public static class ESetTeleControlTypeExtensions
	{
		// Token: 0x0600D569 RID: 54633 RVA: 0x001EFB84 File Offset: 0x001EDD84
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

		// Token: 0x0600D56A RID: 54634 RVA: 0x001EFBBC File Offset: 0x001EDDBC
		public static ESetTeleControlType FromString(string name)
		{
			ESetTeleControlType result;
			if (!ESetTeleControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetTeleControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D56B RID: 54635 RVA: 0x001EFBE5 File Offset: 0x001EDDE5
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

		// Token: 0x0600D56C RID: 54636 RVA: 0x001EFC1E File Offset: 0x001EDE1E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OpenGravity",
				"SetResetPosition"
			};
		}

		// Token: 0x0600D56D RID: 54637 RVA: 0x001EFC36 File Offset: 0x001EDE36
		public static ESetTeleControlType[] GetValues()
		{
			return new ESetTeleControlType[]
			{
				ESetTeleControlType.OpenGravity,
				ESetTeleControlType.SetResetPosition
			};
		}

		// Token: 0x0600D56E RID: 54638 RVA: 0x001EFC42 File Offset: 0x001EDE42
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

using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001234 RID: 4660
	public static class ECommonEventTypeExtensions
	{
		// Token: 0x06006991 RID: 27025 RVA: 0x000FCBEC File Offset: 0x000FADEC
		public static string ToEnumString(this ECommonEventType value)
		{
			string result;
			if (value != ECommonEventType.VarValueChange)
			{
				if (value != ECommonEventType.EntityStateChange)
				{
					result = value.ToString();
				}
				else
				{
					result = "EntityStateChange";
				}
			}
			else
			{
				result = "VarValueChange";
			}
			return result;
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x000FCC24 File Offset: 0x000FAE24
		public static ECommonEventType FromString(string name)
		{
			ECommonEventType result;
			if (!ECommonEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECommonEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x000FCC4D File Offset: 0x000FAE4D
		public static bool TryFromString(string name, out ECommonEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECommonEventType.VarValueChange;
				return false;
			}
			if (name == "VarValueChange")
			{
				value = ECommonEventType.VarValueChange;
				return true;
			}
			if (!(name == "EntityStateChange"))
			{
				value = ECommonEventType.VarValueChange;
				return false;
			}
			value = ECommonEventType.EntityStateChange;
			return true;
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x000FCC86 File Offset: 0x000FAE86
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"VarValueChange",
				"EntityStateChange"
			};
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x000FCC9E File Offset: 0x000FAE9E
		public static ECommonEventType[] GetValues()
		{
			return new ECommonEventType[]
			{
				ECommonEventType.VarValueChange,
				ECommonEventType.EntityStateChange
			};
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x000FCCAA File Offset: 0x000FAEAA
		public static string[] GetNames()
		{
			return new string[]
			{
				"VarValueChange",
				"EntityStateChange"
			};
		}
	}
}

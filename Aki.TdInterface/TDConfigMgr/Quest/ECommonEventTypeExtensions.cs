using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001370 RID: 4976
	public static class ECommonEventTypeExtensions
	{
		// Token: 0x06006FD2 RID: 28626 RVA: 0x0010A4F8 File Offset: 0x001086F8
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

		// Token: 0x06006FD3 RID: 28627 RVA: 0x0010A530 File Offset: 0x00108730
		public static ECommonEventType FromString(string name)
		{
			ECommonEventType result;
			if (!ECommonEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECommonEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x0010A559 File Offset: 0x00108759
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

		// Token: 0x06006FD5 RID: 28629 RVA: 0x0010A592 File Offset: 0x00108792
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"VarValueChange",
				"EntityStateChange"
			};
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x0010A5AA File Offset: 0x001087AA
		public static ECommonEventType[] GetValues()
		{
			return new ECommonEventType[]
			{
				ECommonEventType.VarValueChange,
				ECommonEventType.EntityStateChange
			};
		}

		// Token: 0x06006FD7 RID: 28631 RVA: 0x0010A5B6 File Offset: 0x001087B6
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

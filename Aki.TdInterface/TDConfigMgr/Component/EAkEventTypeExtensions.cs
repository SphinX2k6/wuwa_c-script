using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000999 RID: 2457
	public static class EAkEventTypeExtensions
	{
		// Token: 0x06003743 RID: 14147 RVA: 0x0008C3B8 File Offset: 0x0008A5B8
		public static string ToEnumString(this EAkEventType value)
		{
			string result;
			switch (value)
			{
			case EAkEventType.Point:
				result = "Point";
				break;
			case EAkEventType.Box:
				result = "Box";
				break;
			case EAkEventType.Default:
				result = "Default";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x0008C400 File Offset: 0x0008A600
		public static EAkEventType FromString(string name)
		{
			EAkEventType result;
			if (!EAkEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAkEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x0008C42C File Offset: 0x0008A62C
		public static bool TryFromString(string name, out EAkEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAkEventType.Point;
				return false;
			}
			if (name == "Point")
			{
				value = EAkEventType.Point;
				return true;
			}
			if (name == "Box")
			{
				value = EAkEventType.Box;
				return true;
			}
			if (!(name == "Default"))
			{
				value = EAkEventType.Point;
				return false;
			}
			value = EAkEventType.Default;
			return true;
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x0008C482 File Offset: 0x0008A682
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Point",
				"Box",
				"Default"
			};
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0008C4A2 File Offset: 0x0008A6A2
		public static EAkEventType[] GetValues()
		{
			return new EAkEventType[]
			{
				EAkEventType.Point,
				EAkEventType.Box,
				EAkEventType.Default
			};
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x0008C4B2 File Offset: 0x0008A6B2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Point",
				"Box",
				"Default"
			};
		}
	}
}

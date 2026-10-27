using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F0 RID: 2288
	public static class EAkEventTypeExtensions
	{
		// Token: 0x060033E9 RID: 13289 RVA: 0x00084B8C File Offset: 0x00082D8C
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

		// Token: 0x060033EA RID: 13290 RVA: 0x00084BD4 File Offset: 0x00082DD4
		public static EAkEventType FromString(string name)
		{
			EAkEventType result;
			if (!EAkEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAkEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00084C00 File Offset: 0x00082E00
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

		// Token: 0x060033EC RID: 13292 RVA: 0x00084C56 File Offset: 0x00082E56
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Point",
				"Box",
				"Default"
			};
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x00084C76 File Offset: 0x00082E76
		public static EAkEventType[] GetValues()
		{
			return new EAkEventType[]
			{
				EAkEventType.Point,
				EAkEventType.Box,
				EAkEventType.Default
			};
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00084C86 File Offset: 0x00082E86
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

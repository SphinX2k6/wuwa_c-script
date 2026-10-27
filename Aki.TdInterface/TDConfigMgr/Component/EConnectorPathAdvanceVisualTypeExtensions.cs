using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000912 RID: 2322
	public static class EConnectorPathAdvanceVisualTypeExtensions
	{
		// Token: 0x06003482 RID: 13442 RVA: 0x00089918 File Offset: 0x00087B18
		public static string ToEnumString(this EConnectorPathAdvanceVisualType value)
		{
			string result;
			if (value == EConnectorPathAdvanceVisualType.VasePlant)
			{
				result = "VasePlant";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00089940 File Offset: 0x00087B40
		public static EConnectorPathAdvanceVisualType FromString(string name)
		{
			EConnectorPathAdvanceVisualType result;
			if (!EConnectorPathAdvanceVisualTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EConnectorPathAdvanceVisualType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00089969 File Offset: 0x00087B69
		public static bool TryFromString(string name, out EConnectorPathAdvanceVisualType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EConnectorPathAdvanceVisualType.VasePlant;
				return false;
			}
			if (name == "VasePlant")
			{
				value = EConnectorPathAdvanceVisualType.VasePlant;
				return true;
			}
			value = EConnectorPathAdvanceVisualType.VasePlant;
			return false;
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x0008998E File Offset: 0x00087B8E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"VasePlant"
			};
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x0008999E File Offset: 0x00087B9E
		public static EConnectorPathAdvanceVisualType[] GetValues()
		{
			return new EConnectorPathAdvanceVisualType[1];
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x000899A6 File Offset: 0x00087BA6
		public static string[] GetNames()
		{
			return new string[]
			{
				"VasePlant"
			};
		}
	}
}

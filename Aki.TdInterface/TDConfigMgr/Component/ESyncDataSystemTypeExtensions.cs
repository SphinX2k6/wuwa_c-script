using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AED RID: 2797
	public static class ESyncDataSystemTypeExtensions
	{
		// Token: 0x06003D3D RID: 15677 RVA: 0x0009CD40 File Offset: 0x0009AF40
		public static string ToEnumString(this ESyncDataSystemType value)
		{
			string result;
			if (value == ESyncDataSystemType.MotorRacing)
			{
				result = "MotorRacing";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x0009CD68 File Offset: 0x0009AF68
		public static ESyncDataSystemType FromString(string name)
		{
			ESyncDataSystemType result;
			if (!ESyncDataSystemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESyncDataSystemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x0009CD91 File Offset: 0x0009AF91
		public static bool TryFromString(string name, out ESyncDataSystemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESyncDataSystemType.MotorRacing;
				return false;
			}
			if (name == "MotorRacing")
			{
				value = ESyncDataSystemType.MotorRacing;
				return true;
			}
			value = ESyncDataSystemType.MotorRacing;
			return false;
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x0009CDB6 File Offset: 0x0009AFB6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MotorRacing"
			};
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x0009CDC6 File Offset: 0x0009AFC6
		public static ESyncDataSystemType[] GetValues()
		{
			return new ESyncDataSystemType[1];
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x0009CDCE File Offset: 0x0009AFCE
		public static string[] GetNames()
		{
			return new string[]
			{
				"MotorRacing"
			};
		}
	}
}

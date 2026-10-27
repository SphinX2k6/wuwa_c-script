using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A28 RID: 2600
	public static class ESyncDataSystemTypeExtensions
	{
		// Token: 0x06003965 RID: 14693 RVA: 0x0009440C File Offset: 0x0009260C
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

		// Token: 0x06003966 RID: 14694 RVA: 0x00094434 File Offset: 0x00092634
		public static ESyncDataSystemType FromString(string name)
		{
			ESyncDataSystemType result;
			if (!ESyncDataSystemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESyncDataSystemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x0009445D File Offset: 0x0009265D
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

		// Token: 0x06003968 RID: 14696 RVA: 0x00094482 File Offset: 0x00092682
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MotorRacing"
			};
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x00094492 File Offset: 0x00092692
		public static ESyncDataSystemType[] GetValues()
		{
			return new ESyncDataSystemType[1];
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x0009449A File Offset: 0x0009269A
		public static string[] GetNames()
		{
			return new string[]
			{
				"MotorRacing"
			};
		}
	}
}

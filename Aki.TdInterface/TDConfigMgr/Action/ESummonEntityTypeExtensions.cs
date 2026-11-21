using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026DE RID: 9950
	public static class ESummonEntityTypeExtensions
	{
		// Token: 0x0600D641 RID: 54849 RVA: 0x001F2210 File Offset: 0x001F0410
		public static string ToEnumString(this ESummonEntityType value)
		{
			string result;
			if (value == ESummonEntityType.Vehicle)
			{
				result = "Vehicle";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D642 RID: 54850 RVA: 0x001F2238 File Offset: 0x001F0438
		public static ESummonEntityType FromString(string name)
		{
			ESummonEntityType result;
			if (!ESummonEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESummonEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D643 RID: 54851 RVA: 0x001F2261 File Offset: 0x001F0461
		public static bool TryFromString(string name, out ESummonEntityType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESummonEntityType.Vehicle;
				return false;
			}
			if (name == "Vehicle")
			{
				value = ESummonEntityType.Vehicle;
				return true;
			}
			value = ESummonEntityType.Vehicle;
			return false;
		}

		// Token: 0x0600D644 RID: 54852 RVA: 0x001F2286 File Offset: 0x001F0486
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Vehicle"
			};
		}

		// Token: 0x0600D645 RID: 54853 RVA: 0x001F2296 File Offset: 0x001F0496
		public static ESummonEntityType[] GetValues()
		{
			return new ESummonEntityType[1];
		}

		// Token: 0x0600D646 RID: 54854 RVA: 0x001F229E File Offset: 0x001F049E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Vehicle"
			};
		}
	}
}

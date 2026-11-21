using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E0 RID: 9952
	public static class ESunSpiritGearRoundTripTypeExtensions
	{
		// Token: 0x0600D64A RID: 54858 RVA: 0x001F22EC File Offset: 0x001F04EC
		public static string ToEnumString(this ESunSpiritGearRoundTripType value)
		{
			string result;
			if (value != ESunSpiritGearRoundTripType.FlyToGear)
			{
				if (value != ESunSpiritGearRoundTripType.BackFromGear)
				{
					result = value.ToString();
				}
				else
				{
					result = "BackFromGear";
				}
			}
			else
			{
				result = "FlyToGear";
			}
			return result;
		}

		// Token: 0x0600D64B RID: 54859 RVA: 0x001F2324 File Offset: 0x001F0524
		public static ESunSpiritGearRoundTripType FromString(string name)
		{
			ESunSpiritGearRoundTripType result;
			if (!ESunSpiritGearRoundTripTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESunSpiritGearRoundTripType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D64C RID: 54860 RVA: 0x001F234D File Offset: 0x001F054D
		public static bool TryFromString(string name, out ESunSpiritGearRoundTripType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESunSpiritGearRoundTripType.FlyToGear;
				return false;
			}
			if (name == "FlyToGear")
			{
				value = ESunSpiritGearRoundTripType.FlyToGear;
				return true;
			}
			if (!(name == "BackFromGear"))
			{
				value = ESunSpiritGearRoundTripType.FlyToGear;
				return false;
			}
			value = ESunSpiritGearRoundTripType.BackFromGear;
			return true;
		}

		// Token: 0x0600D64D RID: 54861 RVA: 0x001F2386 File Offset: 0x001F0586
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FlyToGear",
				"BackFromGear"
			};
		}

		// Token: 0x0600D64E RID: 54862 RVA: 0x001F239E File Offset: 0x001F059E
		public static ESunSpiritGearRoundTripType[] GetValues()
		{
			return new ESunSpiritGearRoundTripType[]
			{
				ESunSpiritGearRoundTripType.FlyToGear,
				ESunSpiritGearRoundTripType.BackFromGear
			};
		}

		// Token: 0x0600D64F RID: 54863 RVA: 0x001F23AA File Offset: 0x001F05AA
		public static string[] GetNames()
		{
			return new string[]
			{
				"FlyToGear",
				"BackFromGear"
			};
		}
	}
}

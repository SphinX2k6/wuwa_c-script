using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243F RID: 9279
	public static class ESunSpiritGearRoundTripTypeExtensions
	{
		// Token: 0x0600C99A RID: 51610 RVA: 0x001D8424 File Offset: 0x001D6624
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

		// Token: 0x0600C99B RID: 51611 RVA: 0x001D845C File Offset: 0x001D665C
		public static ESunSpiritGearRoundTripType FromString(string name)
		{
			ESunSpiritGearRoundTripType result;
			if (!ESunSpiritGearRoundTripTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESunSpiritGearRoundTripType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C99C RID: 51612 RVA: 0x001D8485 File Offset: 0x001D6685
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

		// Token: 0x0600C99D RID: 51613 RVA: 0x001D84BE File Offset: 0x001D66BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FlyToGear",
				"BackFromGear"
			};
		}

		// Token: 0x0600C99E RID: 51614 RVA: 0x001D84D6 File Offset: 0x001D66D6
		public static ESunSpiritGearRoundTripType[] GetValues()
		{
			return new ESunSpiritGearRoundTripType[]
			{
				ESunSpiritGearRoundTripType.FlyToGear,
				ESunSpiritGearRoundTripType.BackFromGear
			};
		}

		// Token: 0x0600C99F RID: 51615 RVA: 0x001D84E2 File Offset: 0x001D66E2
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

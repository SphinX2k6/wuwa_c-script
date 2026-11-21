using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200257E RID: 9598
	public static class EDynamicSettlementTypeExtensions
	{
		// Token: 0x0600D011 RID: 53265 RVA: 0x001E2534 File Offset: 0x001E0734
		public static string ToEnumString(this EDynamicSettlementType value)
		{
			string result;
			if (value != EDynamicSettlementType.Battle)
			{
				if (value != EDynamicSettlementType.SoaringChallenge)
				{
					result = value.ToString();
				}
				else
				{
					result = "SoaringChallenge";
				}
			}
			else
			{
				result = "Battle";
			}
			return result;
		}

		// Token: 0x0600D012 RID: 53266 RVA: 0x001E256C File Offset: 0x001E076C
		public static EDynamicSettlementType FromString(string name)
		{
			EDynamicSettlementType result;
			if (!EDynamicSettlementTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDynamicSettlementType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D013 RID: 53267 RVA: 0x001E2595 File Offset: 0x001E0795
		public static bool TryFromString(string name, out EDynamicSettlementType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDynamicSettlementType.Battle;
				return false;
			}
			if (name == "Battle")
			{
				value = EDynamicSettlementType.Battle;
				return true;
			}
			if (!(name == "SoaringChallenge"))
			{
				value = EDynamicSettlementType.Battle;
				return false;
			}
			value = EDynamicSettlementType.SoaringChallenge;
			return true;
		}

		// Token: 0x0600D014 RID: 53268 RVA: 0x001E25CE File Offset: 0x001E07CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Battle",
				"SoaringChallenge"
			};
		}

		// Token: 0x0600D015 RID: 53269 RVA: 0x001E25E6 File Offset: 0x001E07E6
		public static EDynamicSettlementType[] GetValues()
		{
			return new EDynamicSettlementType[]
			{
				EDynamicSettlementType.Battle,
				EDynamicSettlementType.SoaringChallenge
			};
		}

		// Token: 0x0600D016 RID: 53270 RVA: 0x001E25F2 File Offset: 0x001E07F2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Battle",
				"SoaringChallenge"
			};
		}
	}
}

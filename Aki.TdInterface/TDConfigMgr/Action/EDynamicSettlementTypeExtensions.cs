using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200230F RID: 8975
	public static class EDynamicSettlementTypeExtensions
	{
		// Token: 0x0600C442 RID: 50242 RVA: 0x001CA66C File Offset: 0x001C886C
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

		// Token: 0x0600C443 RID: 50243 RVA: 0x001CA6A4 File Offset: 0x001C88A4
		public static EDynamicSettlementType FromString(string name)
		{
			EDynamicSettlementType result;
			if (!EDynamicSettlementTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDynamicSettlementType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C444 RID: 50244 RVA: 0x001CA6CD File Offset: 0x001C88CD
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

		// Token: 0x0600C445 RID: 50245 RVA: 0x001CA706 File Offset: 0x001C8906
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Battle",
				"SoaringChallenge"
			};
		}

		// Token: 0x0600C446 RID: 50246 RVA: 0x001CA71E File Offset: 0x001C891E
		public static EDynamicSettlementType[] GetValues()
		{
			return new EDynamicSettlementType[]
			{
				EDynamicSettlementType.Battle,
				EDynamicSettlementType.SoaringChallenge
			};
		}

		// Token: 0x0600C447 RID: 50247 RVA: 0x001CA72A File Offset: 0x001C892A
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

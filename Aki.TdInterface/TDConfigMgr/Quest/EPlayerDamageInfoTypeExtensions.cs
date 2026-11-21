using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A4 RID: 5028
	public static class EPlayerDamageInfoTypeExtensions
	{
		// Token: 0x060070BC RID: 28860 RVA: 0x0010CC54 File Offset: 0x0010AE54
		public static string ToEnumString(this EPlayerDamageInfoType value)
		{
			string result;
			if (value != EPlayerDamageInfoType.DamagePoint)
			{
				if (value != EPlayerDamageInfoType.DamagePercentage)
				{
					result = value.ToString();
				}
				else
				{
					result = "DamagePercentage";
				}
			}
			else
			{
				result = "DamagePoint";
			}
			return result;
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x0010CC8C File Offset: 0x0010AE8C
		public static EPlayerDamageInfoType FromString(string name)
		{
			EPlayerDamageInfoType result;
			if (!EPlayerDamageInfoTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerDamageInfoType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070BE RID: 28862 RVA: 0x0010CCB5 File Offset: 0x0010AEB5
		public static bool TryFromString(string name, out EPlayerDamageInfoType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerDamageInfoType.DamagePoint;
				return false;
			}
			if (name == "DamagePoint")
			{
				value = EPlayerDamageInfoType.DamagePoint;
				return true;
			}
			if (!(name == "DamagePercentage"))
			{
				value = EPlayerDamageInfoType.DamagePoint;
				return false;
			}
			value = EPlayerDamageInfoType.DamagePercentage;
			return true;
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x0010CCEE File Offset: 0x0010AEEE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DamagePoint",
				"DamagePercentage"
			};
		}

		// Token: 0x060070C0 RID: 28864 RVA: 0x0010CD06 File Offset: 0x0010AF06
		public static EPlayerDamageInfoType[] GetValues()
		{
			return new EPlayerDamageInfoType[]
			{
				EPlayerDamageInfoType.DamagePoint,
				EPlayerDamageInfoType.DamagePercentage
			};
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x0010CD12 File Offset: 0x0010AF12
		public static string[] GetNames()
		{
			return new string[]
			{
				"DamagePoint",
				"DamagePercentage"
			};
		}
	}
}

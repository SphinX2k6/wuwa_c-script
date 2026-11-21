using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD7 RID: 2775
	public static class ESpawnMonsterConstraintExtensions
	{
		// Token: 0x06003CDA RID: 15578 RVA: 0x0009BE1C File Offset: 0x0009A01C
		public static string ToEnumString(this ESpawnMonsterConstraint value)
		{
			string result;
			if (value == ESpawnMonsterConstraint.CharacterForwardAnnularSector)
			{
				result = "CharacterForwardAnnularSector";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x0009BE44 File Offset: 0x0009A044
		public static ESpawnMonsterConstraint FromString(string name)
		{
			ESpawnMonsterConstraint result;
			if (!ESpawnMonsterConstraintExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpawnMonsterConstraint 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x0009BE6D File Offset: 0x0009A06D
		public static bool TryFromString(string name, out ESpawnMonsterConstraint value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpawnMonsterConstraint.CharacterForwardAnnularSector;
				return false;
			}
			if (name == "CharacterForwardAnnularSector")
			{
				value = ESpawnMonsterConstraint.CharacterForwardAnnularSector;
				return true;
			}
			value = ESpawnMonsterConstraint.CharacterForwardAnnularSector;
			return false;
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x0009BE92 File Offset: 0x0009A092
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CharacterForwardAnnularSector"
			};
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x0009BEA2 File Offset: 0x0009A0A2
		public static ESpawnMonsterConstraint[] GetValues()
		{
			return new ESpawnMonsterConstraint[1];
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x0009BEAA File Offset: 0x0009A0AA
		public static string[] GetNames()
		{
			return new string[]
			{
				"CharacterForwardAnnularSector"
			};
		}
	}
}

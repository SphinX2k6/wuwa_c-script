using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A12 RID: 2578
	public static class ESpawnMonsterConstraintExtensions
	{
		// Token: 0x06003902 RID: 14594 RVA: 0x0009352C File Offset: 0x0009172C
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

		// Token: 0x06003903 RID: 14595 RVA: 0x00093554 File Offset: 0x00091754
		public static ESpawnMonsterConstraint FromString(string name)
		{
			ESpawnMonsterConstraint result;
			if (!ESpawnMonsterConstraintExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpawnMonsterConstraint 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x0009357D File Offset: 0x0009177D
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

		// Token: 0x06003905 RID: 14597 RVA: 0x000935A2 File Offset: 0x000917A2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CharacterForwardAnnularSector"
			};
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x000935B2 File Offset: 0x000917B2
		public static ESpawnMonsterConstraint[] GetValues()
		{
			return new ESpawnMonsterConstraint[1];
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x000935BA File Offset: 0x000917BA
		public static string[] GetNames()
		{
			return new string[]
			{
				"CharacterForwardAnnularSector"
			};
		}
	}
}

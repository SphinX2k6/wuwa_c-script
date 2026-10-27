using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A14 RID: 2580
	public static class ESpawnMonsterPreConditionExtensions
	{
		// Token: 0x0600390B RID: 14603 RVA: 0x00093608 File Offset: 0x00091808
		public static string ToEnumString(this ESpawnMonsterPreCondition value)
		{
			string result;
			if (value == ESpawnMonsterPreCondition.DependOnPreceding)
			{
				result = "DependOnPreceding";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x00093630 File Offset: 0x00091830
		public static ESpawnMonsterPreCondition FromString(string name)
		{
			ESpawnMonsterPreCondition result;
			if (!ESpawnMonsterPreConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpawnMonsterPreCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x00093659 File Offset: 0x00091859
		public static bool TryFromString(string name, out ESpawnMonsterPreCondition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpawnMonsterPreCondition.DependOnPreceding;
				return false;
			}
			if (name == "DependOnPreceding")
			{
				value = ESpawnMonsterPreCondition.DependOnPreceding;
				return true;
			}
			value = ESpawnMonsterPreCondition.DependOnPreceding;
			return false;
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x0009367E File Offset: 0x0009187E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DependOnPreceding"
			};
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x0009368E File Offset: 0x0009188E
		public static ESpawnMonsterPreCondition[] GetValues()
		{
			return new ESpawnMonsterPreCondition[1];
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00093696 File Offset: 0x00091896
		public static string[] GetNames()
		{
			return new string[]
			{
				"DependOnPreceding"
			};
		}
	}
}

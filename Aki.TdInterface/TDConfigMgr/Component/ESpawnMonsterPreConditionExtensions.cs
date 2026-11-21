using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD9 RID: 2777
	public static class ESpawnMonsterPreConditionExtensions
	{
		// Token: 0x06003CE3 RID: 15587 RVA: 0x0009BEF8 File Offset: 0x0009A0F8
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

		// Token: 0x06003CE4 RID: 15588 RVA: 0x0009BF20 File Offset: 0x0009A120
		public static ESpawnMonsterPreCondition FromString(string name)
		{
			ESpawnMonsterPreCondition result;
			if (!ESpawnMonsterPreConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpawnMonsterPreCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x0009BF49 File Offset: 0x0009A149
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

		// Token: 0x06003CE6 RID: 15590 RVA: 0x0009BF6E File Offset: 0x0009A16E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DependOnPreceding"
			};
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x0009BF7E File Offset: 0x0009A17E
		public static ESpawnMonsterPreCondition[] GetValues()
		{
			return new ESpawnMonsterPreCondition[1];
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x0009BF86 File Offset: 0x0009A186
		public static string[] GetNames()
		{
			return new string[]
			{
				"DependOnPreceding"
			};
		}
	}
}

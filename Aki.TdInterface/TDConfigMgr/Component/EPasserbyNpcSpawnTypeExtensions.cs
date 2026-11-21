using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A81 RID: 2689
	public static class EPasserbyNpcSpawnTypeExtensions
	{
		// Token: 0x06003B57 RID: 15191 RVA: 0x00098F0C File Offset: 0x0009710C
		public static string ToEnumString(this EPasserbyNpcSpawnType value)
		{
			string result;
			if (value != EPasserbyNpcSpawnType.FixInterval)
			{
				if (value != EPasserbyNpcSpawnType.OnceOnConditionMet)
				{
					result = value.ToString();
				}
				else
				{
					result = "OnceOnConditionMet";
				}
			}
			else
			{
				result = "FixInterval";
			}
			return result;
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x00098F44 File Offset: 0x00097144
		public static EPasserbyNpcSpawnType FromString(string name)
		{
			EPasserbyNpcSpawnType result;
			if (!EPasserbyNpcSpawnTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcSpawnType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x00098F6D File Offset: 0x0009716D
		public static bool TryFromString(string name, out EPasserbyNpcSpawnType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcSpawnType.FixInterval;
				return false;
			}
			if (name == "FixInterval")
			{
				value = EPasserbyNpcSpawnType.FixInterval;
				return true;
			}
			if (!(name == "OnceOnConditionMet"))
			{
				value = EPasserbyNpcSpawnType.FixInterval;
				return false;
			}
			value = EPasserbyNpcSpawnType.OnceOnConditionMet;
			return true;
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x00098FA6 File Offset: 0x000971A6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FixInterval",
				"OnceOnConditionMet"
			};
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x00098FBE File Offset: 0x000971BE
		public static EPasserbyNpcSpawnType[] GetValues()
		{
			return new EPasserbyNpcSpawnType[]
			{
				EPasserbyNpcSpawnType.FixInterval,
				EPasserbyNpcSpawnType.OnceOnConditionMet
			};
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x00098FCA File Offset: 0x000971CA
		public static string[] GetNames()
		{
			return new string[]
			{
				"FixInterval",
				"OnceOnConditionMet"
			};
		}
	}
}

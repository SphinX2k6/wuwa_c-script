using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D4 RID: 5076
	public static class ESpecificDeadMonsterTypeExtensions
	{
		// Token: 0x06007194 RID: 29076 RVA: 0x0010F3D0 File Offset: 0x0010D5D0
		public static string ToEnumString(this ESpecificDeadMonsterType value)
		{
			string result;
			if (value == ESpecificDeadMonsterType.LastDead)
			{
				result = "LastDead";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06007195 RID: 29077 RVA: 0x0010F3F8 File Offset: 0x0010D5F8
		public static ESpecificDeadMonsterType FromString(string name)
		{
			ESpecificDeadMonsterType result;
			if (!ESpecificDeadMonsterTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecificDeadMonsterType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x0010F421 File Offset: 0x0010D621
		public static bool TryFromString(string name, out ESpecificDeadMonsterType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecificDeadMonsterType.LastDead;
				return false;
			}
			if (name == "LastDead")
			{
				value = ESpecificDeadMonsterType.LastDead;
				return true;
			}
			value = ESpecificDeadMonsterType.LastDead;
			return false;
		}

		// Token: 0x06007197 RID: 29079 RVA: 0x0010F446 File Offset: 0x0010D646
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LastDead"
			};
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x0010F456 File Offset: 0x0010D656
		public static ESpecificDeadMonsterType[] GetValues()
		{
			return new ESpecificDeadMonsterType[1];
		}

		// Token: 0x06007199 RID: 29081 RVA: 0x0010F45E File Offset: 0x0010D65E
		public static string[] GetNames()
		{
			return new string[]
			{
				"LastDead"
			};
		}
	}
}

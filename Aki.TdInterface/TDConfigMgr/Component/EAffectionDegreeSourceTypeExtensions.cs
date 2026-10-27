using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008EC RID: 2284
	public static class EAffectionDegreeSourceTypeExtensions
	{
		// Token: 0x060033D7 RID: 13271 RVA: 0x0008499C File Offset: 0x00082B9C
		public static string ToEnumString(this EAffectionDegreeSourceType value)
		{
			string result;
			if (value == EAffectionDegreeSourceType.CyberpunkCollaboration)
			{
				result = "CyberpunkCollaboration";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x000849C4 File Offset: 0x00082BC4
		public static EAffectionDegreeSourceType FromString(string name)
		{
			EAffectionDegreeSourceType result;
			if (!EAffectionDegreeSourceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAffectionDegreeSourceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x000849ED File Offset: 0x00082BED
		public static bool TryFromString(string name, out EAffectionDegreeSourceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAffectionDegreeSourceType.CyberpunkCollaboration;
				return false;
			}
			if (name == "CyberpunkCollaboration")
			{
				value = EAffectionDegreeSourceType.CyberpunkCollaboration;
				return true;
			}
			value = EAffectionDegreeSourceType.CyberpunkCollaboration;
			return false;
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00084A12 File Offset: 0x00082C12
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CyberpunkCollaboration"
			};
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x00084A22 File Offset: 0x00082C22
		public static EAffectionDegreeSourceType[] GetValues()
		{
			return new EAffectionDegreeSourceType[1];
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x00084A2A File Offset: 0x00082C2A
		public static string[] GetNames()
		{
			return new string[]
			{
				"CyberpunkCollaboration"
			};
		}
	}
}

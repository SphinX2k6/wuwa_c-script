using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000991 RID: 2449
	public static class EAffectionDegreeSourceTypeExtensions
	{
		// Token: 0x0600371F RID: 14111 RVA: 0x0008BFD8 File Offset: 0x0008A1D8
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

		// Token: 0x06003720 RID: 14112 RVA: 0x0008C000 File Offset: 0x0008A200
		public static EAffectionDegreeSourceType FromString(string name)
		{
			EAffectionDegreeSourceType result;
			if (!EAffectionDegreeSourceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAffectionDegreeSourceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x0008C029 File Offset: 0x0008A229
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

		// Token: 0x06003722 RID: 14114 RVA: 0x0008C04E File Offset: 0x0008A24E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CyberpunkCollaboration"
			};
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0008C05E File Offset: 0x0008A25E
		public static EAffectionDegreeSourceType[] GetValues()
		{
			return new EAffectionDegreeSourceType[1];
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x0008C066 File Offset: 0x0008A266
		public static string[] GetNames()
		{
			return new string[]
			{
				"CyberpunkCollaboration"
			};
		}
	}
}

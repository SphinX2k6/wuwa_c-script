using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000958 RID: 2392
	public static class EGroupAiEcologyGameplayTypeExtensions
	{
		// Token: 0x060035BD RID: 13757 RVA: 0x0008C0E4 File Offset: 0x0008A2E4
		public static string ToEnumString(this EGroupAiEcologyGameplayType value)
		{
			string result;
			if (value == EGroupAiEcologyGameplayType.FloatParade)
			{
				result = "FloatParade";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x0008C10C File Offset: 0x0008A30C
		public static EGroupAiEcologyGameplayType FromString(string name)
		{
			EGroupAiEcologyGameplayType result;
			if (!EGroupAiEcologyGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupAiEcologyGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x0008C135 File Offset: 0x0008A335
		public static bool TryFromString(string name, out EGroupAiEcologyGameplayType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGroupAiEcologyGameplayType.FloatParade;
				return false;
			}
			if (name == "FloatParade")
			{
				value = EGroupAiEcologyGameplayType.FloatParade;
				return true;
			}
			value = EGroupAiEcologyGameplayType.FloatParade;
			return false;
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x0008C15A File Offset: 0x0008A35A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FloatParade"
			};
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x0008C16A File Offset: 0x0008A36A
		public static EGroupAiEcologyGameplayType[] GetValues()
		{
			return new EGroupAiEcologyGameplayType[1];
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x0008C172 File Offset: 0x0008A372
		public static string[] GetNames()
		{
			return new string[]
			{
				"FloatParade"
			};
		}
	}
}

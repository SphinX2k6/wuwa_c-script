using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F4 RID: 2292
	public static class EAttachRuleTypeExtensions
	{
		// Token: 0x060033FB RID: 13307 RVA: 0x00084DC0 File Offset: 0x00082FC0
		public static string ToEnumString(this EAttachRuleType value)
		{
			string result;
			switch (value)
			{
			case EAttachRuleType.Relatively:
				result = "Relatively";
				break;
			case EAttachRuleType.Absolute:
				result = "Absolute";
				break;
			case EAttachRuleType.AlignTarget:
				result = "AlignTarget";
				break;
			case EAttachRuleType.SpecialRuleSwordRail:
				result = "SpecialRuleSwordRail";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00084E14 File Offset: 0x00083014
		public static EAttachRuleType FromString(string name)
		{
			EAttachRuleType result;
			if (!EAttachRuleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttachRuleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00084E40 File Offset: 0x00083040
		public static bool TryFromString(string name, out EAttachRuleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAttachRuleType.Relatively;
				return false;
			}
			if (name == "Relatively")
			{
				value = EAttachRuleType.Relatively;
				return true;
			}
			if (name == "Absolute")
			{
				value = EAttachRuleType.Absolute;
				return true;
			}
			if (name == "AlignTarget")
			{
				value = EAttachRuleType.AlignTarget;
				return true;
			}
			if (!(name == "SpecialRuleSwordRail"))
			{
				value = EAttachRuleType.Relatively;
				return false;
			}
			value = EAttachRuleType.SpecialRuleSwordRail;
			return true;
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00084EA8 File Offset: 0x000830A8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Relatively",
				"Absolute",
				"AlignTarget",
				"SpecialRuleSwordRail"
			};
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00084ED0 File Offset: 0x000830D0
		public static EAttachRuleType[] GetValues()
		{
			return new EAttachRuleType[]
			{
				EAttachRuleType.Relatively,
				EAttachRuleType.Absolute,
				EAttachRuleType.AlignTarget,
				EAttachRuleType.SpecialRuleSwordRail
			};
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00084EE3 File Offset: 0x000830E3
		public static string[] GetNames()
		{
			return new string[]
			{
				"Relatively",
				"Absolute",
				"AlignTarget",
				"SpecialRuleSwordRail"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099D RID: 2461
	public static class EAttachRuleTypeExtensions
	{
		// Token: 0x06003755 RID: 14165 RVA: 0x0008C5EC File Offset: 0x0008A7EC
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

		// Token: 0x06003756 RID: 14166 RVA: 0x0008C640 File Offset: 0x0008A840
		public static EAttachRuleType FromString(string name)
		{
			EAttachRuleType result;
			if (!EAttachRuleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttachRuleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x0008C66C File Offset: 0x0008A86C
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

		// Token: 0x06003758 RID: 14168 RVA: 0x0008C6D4 File Offset: 0x0008A8D4
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

		// Token: 0x06003759 RID: 14169 RVA: 0x0008C6FC File Offset: 0x0008A8FC
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

		// Token: 0x0600375A RID: 14170 RVA: 0x0008C70F File Offset: 0x0008A90F
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

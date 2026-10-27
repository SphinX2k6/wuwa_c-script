using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200233F RID: 9023
	public static class EFlowTemplateTransitionEffectTypeExtensions
	{
		// Token: 0x0600C51A RID: 50458 RVA: 0x001CC53C File Offset: 0x001CA73C
		public static string ToEnumString(this EFlowTemplateTransitionEffectType value)
		{
			string result;
			if (value == EFlowTemplateTransitionEffectType.Blur)
			{
				result = "Blur";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C51B RID: 50459 RVA: 0x001CC564 File Offset: 0x001CA764
		public static EFlowTemplateTransitionEffectType FromString(string name)
		{
			EFlowTemplateTransitionEffectType result;
			if (!EFlowTemplateTransitionEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFlowTemplateTransitionEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C51C RID: 50460 RVA: 0x001CC58D File Offset: 0x001CA78D
		public static bool TryFromString(string name, out EFlowTemplateTransitionEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFlowTemplateTransitionEffectType.Blur;
				return false;
			}
			if (name == "Blur")
			{
				value = EFlowTemplateTransitionEffectType.Blur;
				return true;
			}
			value = EFlowTemplateTransitionEffectType.Blur;
			return false;
		}

		// Token: 0x0600C51D RID: 50461 RVA: 0x001CC5B2 File Offset: 0x001CA7B2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Blur"
			};
		}

		// Token: 0x0600C51E RID: 50462 RVA: 0x001CC5C2 File Offset: 0x001CA7C2
		public static EFlowTemplateTransitionEffectType[] GetValues()
		{
			return new EFlowTemplateTransitionEffectType[1];
		}

		// Token: 0x0600C51F RID: 50463 RVA: 0x001CC5CA File Offset: 0x001CA7CA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Blur"
			};
		}
	}
}

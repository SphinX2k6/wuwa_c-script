using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B0 RID: 9648
	public static class EFlowTemplateTransitionEffectTypeExtensions
	{
		// Token: 0x0600D0F2 RID: 53490 RVA: 0x001E45F4 File Offset: 0x001E27F4
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

		// Token: 0x0600D0F3 RID: 53491 RVA: 0x001E461C File Offset: 0x001E281C
		public static EFlowTemplateTransitionEffectType FromString(string name)
		{
			EFlowTemplateTransitionEffectType result;
			if (!EFlowTemplateTransitionEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFlowTemplateTransitionEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0F4 RID: 53492 RVA: 0x001E4645 File Offset: 0x001E2845
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

		// Token: 0x0600D0F5 RID: 53493 RVA: 0x001E466A File Offset: 0x001E286A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Blur"
			};
		}

		// Token: 0x0600D0F6 RID: 53494 RVA: 0x001E467A File Offset: 0x001E287A
		public static EFlowTemplateTransitionEffectType[] GetValues()
		{
			return new EFlowTemplateTransitionEffectType[1];
		}

		// Token: 0x0600D0F7 RID: 53495 RVA: 0x001E4682 File Offset: 0x001E2882
		public static string[] GetNames()
		{
			return new string[]
			{
				"Blur"
			};
		}
	}
}

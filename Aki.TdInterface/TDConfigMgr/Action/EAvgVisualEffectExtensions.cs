using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002522 RID: 9506
	public static class EAvgVisualEffectExtensions
	{
		// Token: 0x0600CE73 RID: 52851 RVA: 0x001DEF78 File Offset: 0x001DD178
		public static string ToEnumString(this EAvgVisualEffect value)
		{
			string result;
			switch (value)
			{
			case EAvgVisualEffect.Default:
				result = "Default";
				break;
			case EAvgVisualEffect.Highlight:
				result = "Highlight";
				break;
			case EAvgVisualEffect.Darken:
				result = "Darken";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CE74 RID: 52852 RVA: 0x001DEFC0 File Offset: 0x001DD1C0
		public static EAvgVisualEffect FromString(string name)
		{
			EAvgVisualEffect result;
			if (!EAvgVisualEffectExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgVisualEffect 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE75 RID: 52853 RVA: 0x001DEFEC File Offset: 0x001DD1EC
		public static bool TryFromString(string name, out EAvgVisualEffect value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAvgVisualEffect.Default;
				return false;
			}
			if (name == "Default")
			{
				value = EAvgVisualEffect.Default;
				return true;
			}
			if (name == "Highlight")
			{
				value = EAvgVisualEffect.Highlight;
				return true;
			}
			if (!(name == "Darken"))
			{
				value = EAvgVisualEffect.Default;
				return false;
			}
			value = EAvgVisualEffect.Darken;
			return true;
		}

		// Token: 0x0600CE76 RID: 52854 RVA: 0x001DF042 File Offset: 0x001DD242
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"Highlight",
				"Darken"
			};
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x001DF062 File Offset: 0x001DD262
		public static EAvgVisualEffect[] GetValues()
		{
			return new EAvgVisualEffect[]
			{
				EAvgVisualEffect.Default,
				EAvgVisualEffect.Highlight,
				EAvgVisualEffect.Darken
			};
		}

		// Token: 0x0600CE78 RID: 52856 RVA: 0x001DF072 File Offset: 0x001DD272
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"Highlight",
				"Darken"
			};
		}
	}
}

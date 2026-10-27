using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B3 RID: 8883
	public static class EAvgVisualEffectExtensions
	{
		// Token: 0x0600C2A4 RID: 49828 RVA: 0x001C7170 File Offset: 0x001C5370
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

		// Token: 0x0600C2A5 RID: 49829 RVA: 0x001C71B8 File Offset: 0x001C53B8
		public static EAvgVisualEffect FromString(string name)
		{
			EAvgVisualEffect result;
			if (!EAvgVisualEffectExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgVisualEffect 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2A6 RID: 49830 RVA: 0x001C71E4 File Offset: 0x001C53E4
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

		// Token: 0x0600C2A7 RID: 49831 RVA: 0x001C723A File Offset: 0x001C543A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"Highlight",
				"Darken"
			};
		}

		// Token: 0x0600C2A8 RID: 49832 RVA: 0x001C725A File Offset: 0x001C545A
		public static EAvgVisualEffect[] GetValues()
		{
			return new EAvgVisualEffect[]
			{
				EAvgVisualEffect.Default,
				EAvgVisualEffect.Highlight,
				EAvgVisualEffect.Darken
			};
		}

		// Token: 0x0600C2A9 RID: 49833 RVA: 0x001C726A File Offset: 0x001C546A
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

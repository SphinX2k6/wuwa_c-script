using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025BC RID: 9660
	public static class EGiantSubtitleStyleExtensions
	{
		// Token: 0x0600D128 RID: 53544 RVA: 0x001E4D28 File Offset: 0x001E2F28
		public static string ToEnumString(this EGiantSubtitleStyle value)
		{
			string result;
			switch (value)
			{
			case EGiantSubtitleStyle.Neutral:
				result = "Neutral";
				break;
			case EGiantSubtitleStyle.Happy:
				result = "Happy";
				break;
			case EGiantSubtitleStyle.Sad:
				result = "Sad";
				break;
			case EGiantSubtitleStyle.Angry:
				result = "Angry";
				break;
			case EGiantSubtitleStyle.Curious:
				result = "Curious";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D129 RID: 53545 RVA: 0x001E4D88 File Offset: 0x001E2F88
		public static EGiantSubtitleStyle FromString(string name)
		{
			EGiantSubtitleStyle result;
			if (!EGiantSubtitleStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGiantSubtitleStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D12A RID: 53546 RVA: 0x001E4DB4 File Offset: 0x001E2FB4
		public static bool TryFromString(string name, out EGiantSubtitleStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGiantSubtitleStyle.Neutral;
				return false;
			}
			if (name == "Neutral")
			{
				value = EGiantSubtitleStyle.Neutral;
				return true;
			}
			if (name == "Happy")
			{
				value = EGiantSubtitleStyle.Happy;
				return true;
			}
			if (name == "Sad")
			{
				value = EGiantSubtitleStyle.Sad;
				return true;
			}
			if (name == "Angry")
			{
				value = EGiantSubtitleStyle.Angry;
				return true;
			}
			if (!(name == "Curious"))
			{
				value = EGiantSubtitleStyle.Neutral;
				return false;
			}
			value = EGiantSubtitleStyle.Curious;
			return true;
		}

		// Token: 0x0600D12B RID: 53547 RVA: 0x001E4E2E File Offset: 0x001E302E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Neutral",
				"Happy",
				"Sad",
				"Angry",
				"Curious"
			};
		}

		// Token: 0x0600D12C RID: 53548 RVA: 0x001E4E5E File Offset: 0x001E305E
		public static EGiantSubtitleStyle[] GetValues()
		{
			return new EGiantSubtitleStyle[]
			{
				EGiantSubtitleStyle.Neutral,
				EGiantSubtitleStyle.Happy,
				EGiantSubtitleStyle.Sad,
				EGiantSubtitleStyle.Angry,
				EGiantSubtitleStyle.Curious
			};
		}

		// Token: 0x0600D12D RID: 53549 RVA: 0x001E4E71 File Offset: 0x001E3071
		public static string[] GetNames()
		{
			return new string[]
			{
				"Neutral",
				"Happy",
				"Sad",
				"Angry",
				"Curious"
			};
		}
	}
}

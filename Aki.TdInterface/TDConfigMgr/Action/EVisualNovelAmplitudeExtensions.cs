using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002744 RID: 10052
	public static class EVisualNovelAmplitudeExtensions
	{
		// Token: 0x0600D80C RID: 55308 RVA: 0x001F900C File Offset: 0x001F720C
		public static string ToEnumString(this EVisualNovelAmplitude value)
		{
			string result;
			switch (value)
			{
			case EVisualNovelAmplitude.Small:
				result = "Small";
				break;
			case EVisualNovelAmplitude.Medium:
				result = "Medium";
				break;
			case EVisualNovelAmplitude.Large:
				result = "Large";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D80D RID: 55309 RVA: 0x001F9054 File Offset: 0x001F7254
		public static EVisualNovelAmplitude FromString(string name)
		{
			EVisualNovelAmplitude result;
			if (!EVisualNovelAmplitudeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelAmplitude 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D80E RID: 55310 RVA: 0x001F9080 File Offset: 0x001F7280
		public static bool TryFromString(string name, out EVisualNovelAmplitude value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelAmplitude.Small;
				return false;
			}
			if (name == "Small")
			{
				value = EVisualNovelAmplitude.Small;
				return true;
			}
			if (name == "Medium")
			{
				value = EVisualNovelAmplitude.Medium;
				return true;
			}
			if (!(name == "Large"))
			{
				value = EVisualNovelAmplitude.Small;
				return false;
			}
			value = EVisualNovelAmplitude.Large;
			return true;
		}

		// Token: 0x0600D80F RID: 55311 RVA: 0x001F90D6 File Offset: 0x001F72D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Small",
				"Medium",
				"Large"
			};
		}

		// Token: 0x0600D810 RID: 55312 RVA: 0x001F90F6 File Offset: 0x001F72F6
		public static EVisualNovelAmplitude[] GetValues()
		{
			return new EVisualNovelAmplitude[]
			{
				EVisualNovelAmplitude.Small,
				EVisualNovelAmplitude.Medium,
				EVisualNovelAmplitude.Large
			};
		}

		// Token: 0x0600D811 RID: 55313 RVA: 0x001F9106 File Offset: 0x001F7306
		public static string[] GetNames()
		{
			return new string[]
			{
				"Small",
				"Medium",
				"Large"
			};
		}
	}
}

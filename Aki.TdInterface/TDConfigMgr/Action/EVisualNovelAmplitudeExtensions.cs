using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A1 RID: 9377
	public static class EVisualNovelAmplitudeExtensions
	{
		// Token: 0x0600CB53 RID: 52051 RVA: 0x001DEE44 File Offset: 0x001DD044
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

		// Token: 0x0600CB54 RID: 52052 RVA: 0x001DEE8C File Offset: 0x001DD08C
		public static EVisualNovelAmplitude FromString(string name)
		{
			EVisualNovelAmplitude result;
			if (!EVisualNovelAmplitudeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelAmplitude 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB55 RID: 52053 RVA: 0x001DEEB8 File Offset: 0x001DD0B8
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

		// Token: 0x0600CB56 RID: 52054 RVA: 0x001DEF0E File Offset: 0x001DD10E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Small",
				"Medium",
				"Large"
			};
		}

		// Token: 0x0600CB57 RID: 52055 RVA: 0x001DEF2E File Offset: 0x001DD12E
		public static EVisualNovelAmplitude[] GetValues()
		{
			return new EVisualNovelAmplitude[]
			{
				EVisualNovelAmplitude.Small,
				EVisualNovelAmplitude.Medium,
				EVisualNovelAmplitude.Large
			};
		}

		// Token: 0x0600CB58 RID: 52056 RVA: 0x001DEF3E File Offset: 0x001DD13E
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

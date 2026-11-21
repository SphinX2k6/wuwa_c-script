using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013FE RID: 5118
	public static class EVisionSystemQuestTypeExtensions
	{
		// Token: 0x06007251 RID: 29265 RVA: 0x00111AC4 File Offset: 0x0010FCC4
		public static string ToEnumString(this EVisionSystemQuestType value)
		{
			string result;
			switch (value)
			{
			case EVisionSystemQuestType.HasVisionGetTargetLevel:
				result = "HasVisionGetTargetLevel";
				break;
			case EVisionSystemQuestType.VisionSetActivated:
				result = "VisionSetActivated";
				break;
			case EVisionSystemQuestType.DoVisionIdentify:
				result = "DoVisionIdentify";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x00111B0C File Offset: 0x0010FD0C
		public static EVisionSystemQuestType FromString(string name)
		{
			EVisionSystemQuestType result;
			if (!EVisionSystemQuestTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisionSystemQuestType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00111B38 File Offset: 0x0010FD38
		public static bool TryFromString(string name, out EVisionSystemQuestType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisionSystemQuestType.HasVisionGetTargetLevel;
				return false;
			}
			if (name == "HasVisionGetTargetLevel")
			{
				value = EVisionSystemQuestType.HasVisionGetTargetLevel;
				return true;
			}
			if (name == "VisionSetActivated")
			{
				value = EVisionSystemQuestType.VisionSetActivated;
				return true;
			}
			if (!(name == "DoVisionIdentify"))
			{
				value = EVisionSystemQuestType.HasVisionGetTargetLevel;
				return false;
			}
			value = EVisionSystemQuestType.DoVisionIdentify;
			return true;
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00111B8E File Offset: 0x0010FD8E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HasVisionGetTargetLevel",
				"VisionSetActivated",
				"DoVisionIdentify"
			};
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x00111BAE File Offset: 0x0010FDAE
		public static EVisionSystemQuestType[] GetValues()
		{
			return new EVisionSystemQuestType[]
			{
				EVisionSystemQuestType.HasVisionGetTargetLevel,
				EVisionSystemQuestType.VisionSetActivated,
				EVisionSystemQuestType.DoVisionIdentify
			};
		}

		// Token: 0x06007256 RID: 29270 RVA: 0x00111BBE File Offset: 0x0010FDBE
		public static string[] GetNames()
		{
			return new string[]
			{
				"HasVisionGetTargetLevel",
				"VisionSetActivated",
				"DoVisionIdentify"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B8 RID: 4792
	public static class EVisionSystemQuestTypeExtensions
	{
		// Token: 0x06006BE3 RID: 27619 RVA: 0x00103AFC File Offset: 0x00101CFC
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

		// Token: 0x06006BE4 RID: 27620 RVA: 0x00103B44 File Offset: 0x00101D44
		public static EVisionSystemQuestType FromString(string name)
		{
			EVisionSystemQuestType result;
			if (!EVisionSystemQuestTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisionSystemQuestType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BE5 RID: 27621 RVA: 0x00103B70 File Offset: 0x00101D70
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

		// Token: 0x06006BE6 RID: 27622 RVA: 0x00103BC6 File Offset: 0x00101DC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HasVisionGetTargetLevel",
				"VisionSetActivated",
				"DoVisionIdentify"
			};
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x00103BE6 File Offset: 0x00101DE6
		public static EVisionSystemQuestType[] GetValues()
		{
			return new EVisionSystemQuestType[]
			{
				EVisionSystemQuestType.HasVisionGetTargetLevel,
				EVisionSystemQuestType.VisionSetActivated,
				EVisionSystemQuestType.DoVisionIdentify
			};
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x00103BF6 File Offset: 0x00101DF6
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

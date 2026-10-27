using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001256 RID: 4694
	public static class EMechaTrackScoreDetectionTypeExtensions
	{
		// Token: 0x06006A2A RID: 27178 RVA: 0x000FE824 File Offset: 0x000FCA24
		public static string ToEnumString(this EMechaTrackScoreDetectionType value)
		{
			string result;
			switch (value)
			{
			case EMechaTrackScoreDetectionType.StuntAction:
				result = "StuntAction";
				break;
			case EMechaTrackScoreDetectionType.MechanismState:
				result = "MechanismState";
				break;
			case EMechaTrackScoreDetectionType.TagDetection:
				result = "TagDetection";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x000FE86C File Offset: 0x000FCA6C
		public static EMechaTrackScoreDetectionType FromString(string name)
		{
			EMechaTrackScoreDetectionType result;
			if (!EMechaTrackScoreDetectionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMechaTrackScoreDetectionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x000FE898 File Offset: 0x000FCA98
		public static bool TryFromString(string name, out EMechaTrackScoreDetectionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMechaTrackScoreDetectionType.StuntAction;
				return false;
			}
			if (name == "StuntAction")
			{
				value = EMechaTrackScoreDetectionType.StuntAction;
				return true;
			}
			if (name == "MechanismState")
			{
				value = EMechaTrackScoreDetectionType.MechanismState;
				return true;
			}
			if (!(name == "TagDetection"))
			{
				value = EMechaTrackScoreDetectionType.StuntAction;
				return false;
			}
			value = EMechaTrackScoreDetectionType.TagDetection;
			return true;
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x000FE8EE File Offset: 0x000FCAEE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StuntAction",
				"MechanismState",
				"TagDetection"
			};
		}

		// Token: 0x06006A2E RID: 27182 RVA: 0x000FE90E File Offset: 0x000FCB0E
		public static EMechaTrackScoreDetectionType[] GetValues()
		{
			return new EMechaTrackScoreDetectionType[]
			{
				EMechaTrackScoreDetectionType.StuntAction,
				EMechaTrackScoreDetectionType.MechanismState,
				EMechaTrackScoreDetectionType.TagDetection
			};
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x000FE91E File Offset: 0x000FCB1E
		public static string[] GetNames()
		{
			return new string[]
			{
				"StuntAction",
				"MechanismState",
				"TagDetection"
			};
		}
	}
}

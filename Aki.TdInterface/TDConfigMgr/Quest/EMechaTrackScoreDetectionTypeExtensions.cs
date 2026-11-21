using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001396 RID: 5014
	public static class EMechaTrackScoreDetectionTypeExtensions
	{
		// Token: 0x0600707D RID: 28797 RVA: 0x0010C450 File Offset: 0x0010A650
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

		// Token: 0x0600707E RID: 28798 RVA: 0x0010C498 File Offset: 0x0010A698
		public static EMechaTrackScoreDetectionType FromString(string name)
		{
			EMechaTrackScoreDetectionType result;
			if (!EMechaTrackScoreDetectionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMechaTrackScoreDetectionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x0010C4C4 File Offset: 0x0010A6C4
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

		// Token: 0x06007080 RID: 28800 RVA: 0x0010C51A File Offset: 0x0010A71A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StuntAction",
				"MechanismState",
				"TagDetection"
			};
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x0010C53A File Offset: 0x0010A73A
		public static EMechaTrackScoreDetectionType[] GetValues()
		{
			return new EMechaTrackScoreDetectionType[]
			{
				EMechaTrackScoreDetectionType.StuntAction,
				EMechaTrackScoreDetectionType.MechanismState,
				EMechaTrackScoreDetectionType.TagDetection
			};
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x0010C54A File Offset: 0x0010A74A
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

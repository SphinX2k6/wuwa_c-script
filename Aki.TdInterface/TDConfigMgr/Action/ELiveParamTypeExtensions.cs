using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F6 RID: 9718
	public static class ELiveParamTypeExtensions
	{
		// Token: 0x0600D22D RID: 53805 RVA: 0x001E8E08 File Offset: 0x001E7008
		public static string ToEnumString(this ELiveParamType value)
		{
			string result;
			switch (value)
			{
			case ELiveParamType.Heat:
				result = "Heat";
				break;
			case ELiveParamType.DanmakuInterval:
				result = "DanmakuInterval";
				break;
			case ELiveParamType.DanmakuTrackCount:
				result = "DanmakuTrackCount";
				break;
			case ELiveParamType.ForceDanmaku:
				result = "ForceDanmaku";
				break;
			case ELiveParamType.Like:
				result = "Like";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D22E RID: 53806 RVA: 0x001E8E68 File Offset: 0x001E7068
		public static ELiveParamType FromString(string name)
		{
			ELiveParamType result;
			if (!ELiveParamTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveParamType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D22F RID: 53807 RVA: 0x001E8E94 File Offset: 0x001E7094
		public static bool TryFromString(string name, out ELiveParamType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveParamType.Heat;
				return false;
			}
			if (name == "Heat")
			{
				value = ELiveParamType.Heat;
				return true;
			}
			if (name == "DanmakuInterval")
			{
				value = ELiveParamType.DanmakuInterval;
				return true;
			}
			if (name == "DanmakuTrackCount")
			{
				value = ELiveParamType.DanmakuTrackCount;
				return true;
			}
			if (name == "ForceDanmaku")
			{
				value = ELiveParamType.ForceDanmaku;
				return true;
			}
			if (!(name == "Like"))
			{
				value = ELiveParamType.Heat;
				return false;
			}
			value = ELiveParamType.Like;
			return true;
		}

		// Token: 0x0600D230 RID: 53808 RVA: 0x001E8F0E File Offset: 0x001E710E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Heat",
				"DanmakuInterval",
				"DanmakuTrackCount",
				"ForceDanmaku",
				"Like"
			};
		}

		// Token: 0x0600D231 RID: 53809 RVA: 0x001E8F3E File Offset: 0x001E713E
		public static ELiveParamType[] GetValues()
		{
			return new ELiveParamType[]
			{
				ELiveParamType.Heat,
				ELiveParamType.DanmakuInterval,
				ELiveParamType.DanmakuTrackCount,
				ELiveParamType.ForceDanmaku,
				ELiveParamType.Like
			};
		}

		// Token: 0x0600D232 RID: 53810 RVA: 0x001E8F51 File Offset: 0x001E7151
		public static string[] GetNames()
		{
			return new string[]
			{
				"Heat",
				"DanmakuInterval",
				"DanmakuTrackCount",
				"ForceDanmaku",
				"Like"
			};
		}
	}
}

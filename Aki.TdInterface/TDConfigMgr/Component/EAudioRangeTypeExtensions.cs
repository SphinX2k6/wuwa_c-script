using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008FC RID: 2300
	public static class EAudioRangeTypeExtensions
	{
		// Token: 0x0600341F RID: 13343 RVA: 0x00085328 File Offset: 0x00083528
		public static string ToEnumString(this EAudioRangeType value)
		{
			string result;
			switch (value)
			{
			case EAudioRangeType.SceneActorRefComp:
				result = "SceneActorRefComp";
				break;
			case EAudioRangeType.RangeComp:
				result = "RangeComp";
				break;
			case EAudioRangeType.AOI:
				result = "AOI";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00085370 File Offset: 0x00083570
		public static EAudioRangeType FromString(string name)
		{
			EAudioRangeType result;
			if (!EAudioRangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioRangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x0008539C File Offset: 0x0008359C
		public static bool TryFromString(string name, out EAudioRangeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAudioRangeType.SceneActorRefComp;
				return false;
			}
			if (name == "SceneActorRefComp")
			{
				value = EAudioRangeType.SceneActorRefComp;
				return true;
			}
			if (name == "RangeComp")
			{
				value = EAudioRangeType.RangeComp;
				return true;
			}
			if (!(name == "AOI"))
			{
				value = EAudioRangeType.SceneActorRefComp;
				return false;
			}
			value = EAudioRangeType.AOI;
			return true;
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000853F2 File Offset: 0x000835F2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SceneActorRefComp",
				"RangeComp",
				"AOI"
			};
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00085412 File Offset: 0x00083612
		public static EAudioRangeType[] GetValues()
		{
			return new EAudioRangeType[]
			{
				EAudioRangeType.SceneActorRefComp,
				EAudioRangeType.RangeComp,
				EAudioRangeType.AOI
			};
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00085422 File Offset: 0x00083622
		public static string[] GetNames()
		{
			return new string[]
			{
				"SceneActorRefComp",
				"RangeComp",
				"AOI"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A5 RID: 2469
	public static class EAudioRangeTypeExtensions
	{
		// Token: 0x06003779 RID: 14201 RVA: 0x0008CB98 File Offset: 0x0008AD98
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

		// Token: 0x0600377A RID: 14202 RVA: 0x0008CBE0 File Offset: 0x0008ADE0
		public static EAudioRangeType FromString(string name)
		{
			EAudioRangeType result;
			if (!EAudioRangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioRangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x0008CC0C File Offset: 0x0008AE0C
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

		// Token: 0x0600377C RID: 14204 RVA: 0x0008CC62 File Offset: 0x0008AE62
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SceneActorRefComp",
				"RangeComp",
				"AOI"
			};
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x0008CC82 File Offset: 0x0008AE82
		public static EAudioRangeType[] GetValues()
		{
			return new EAudioRangeType[]
			{
				EAudioRangeType.SceneActorRefComp,
				EAudioRangeType.RangeComp,
				EAudioRangeType.AOI
			};
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0008CC92 File Offset: 0x0008AE92
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

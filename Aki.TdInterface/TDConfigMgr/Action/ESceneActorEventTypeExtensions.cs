using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023FB RID: 9211
	public static class ESceneActorEventTypeExtensions
	{
		// Token: 0x0600C868 RID: 51304 RVA: 0x001D549C File Offset: 0x001D369C
		public static string ToEnumString(this ESceneActorEventType value)
		{
			string result;
			switch (value)
			{
			case ESceneActorEventType.PlayMusicPlants:
				result = "PlayMusicPlants";
				break;
			case ESceneActorEventType.PlayMusicLights:
				result = "PlayMusicLights";
				break;
			case ESceneActorEventType.Projection3dTo2d:
				result = "Projection3dTo2d";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C869 RID: 51305 RVA: 0x001D54E4 File Offset: 0x001D36E4
		public static ESceneActorEventType FromString(string name)
		{
			ESceneActorEventType result;
			if (!ESceneActorEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneActorEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C86A RID: 51306 RVA: 0x001D5510 File Offset: 0x001D3710
		public static bool TryFromString(string name, out ESceneActorEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneActorEventType.PlayMusicPlants;
				return false;
			}
			if (name == "PlayMusicPlants")
			{
				value = ESceneActorEventType.PlayMusicPlants;
				return true;
			}
			if (name == "PlayMusicLights")
			{
				value = ESceneActorEventType.PlayMusicLights;
				return true;
			}
			if (!(name == "Projection3dTo2d"))
			{
				value = ESceneActorEventType.PlayMusicPlants;
				return false;
			}
			value = ESceneActorEventType.Projection3dTo2d;
			return true;
		}

		// Token: 0x0600C86B RID: 51307 RVA: 0x001D5566 File Offset: 0x001D3766
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayMusicPlants",
				"PlayMusicLights",
				"Projection3dTo2d"
			};
		}

		// Token: 0x0600C86C RID: 51308 RVA: 0x001D5586 File Offset: 0x001D3786
		public static ESceneActorEventType[] GetValues()
		{
			return new ESceneActorEventType[]
			{
				ESceneActorEventType.PlayMusicPlants,
				ESceneActorEventType.PlayMusicLights,
				ESceneActorEventType.Projection3dTo2d
			};
		}

		// Token: 0x0600C86D RID: 51309 RVA: 0x001D5596 File Offset: 0x001D3796
		public static string[] GetNames()
		{
			return new string[]
			{
				"PlayMusicPlants",
				"PlayMusicLights",
				"Projection3dTo2d"
			};
		}
	}
}

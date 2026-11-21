using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002692 RID: 9874
	public static class ESceneActorEventTypeExtensions
	{
		// Token: 0x0600D4EB RID: 54507 RVA: 0x001EEC48 File Offset: 0x001ECE48
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

		// Token: 0x0600D4EC RID: 54508 RVA: 0x001EEC90 File Offset: 0x001ECE90
		public static ESceneActorEventType FromString(string name)
		{
			ESceneActorEventType result;
			if (!ESceneActorEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneActorEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4ED RID: 54509 RVA: 0x001EECBC File Offset: 0x001ECEBC
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

		// Token: 0x0600D4EE RID: 54510 RVA: 0x001EED12 File Offset: 0x001ECF12
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayMusicPlants",
				"PlayMusicLights",
				"Projection3dTo2d"
			};
		}

		// Token: 0x0600D4EF RID: 54511 RVA: 0x001EED32 File Offset: 0x001ECF32
		public static ESceneActorEventType[] GetValues()
		{
			return new ESceneActorEventType[]
			{
				ESceneActorEventType.PlayMusicPlants,
				ESceneActorEventType.PlayMusicLights,
				ESceneActorEventType.Projection3dTo2d
			};
		}

		// Token: 0x0600D4F0 RID: 54512 RVA: 0x001EED42 File Offset: 0x001ECF42
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

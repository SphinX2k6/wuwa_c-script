using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000980 RID: 2432
	public static class EIntervalSplineSpawnAudioConfigTypeExtensions
	{
		// Token: 0x06003671 RID: 13937 RVA: 0x0008DE38 File Offset: 0x0008C038
		public static string ToEnumString(this EIntervalSplineSpawnAudioConfigType value)
		{
			string result;
			if (value == EIntervalSplineSpawnAudioConfigType.AllActorAddAudio)
			{
				result = "AllActorAddAudio";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x0008DE60 File Offset: 0x0008C060
		public static EIntervalSplineSpawnAudioConfigType FromString(string name)
		{
			EIntervalSplineSpawnAudioConfigType result;
			if (!EIntervalSplineSpawnAudioConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EIntervalSplineSpawnAudioConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x0008DE89 File Offset: 0x0008C089
		public static bool TryFromString(string name, out EIntervalSplineSpawnAudioConfigType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
				return false;
			}
			if (name == "AllActorAddAudio")
			{
				value = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
				return true;
			}
			value = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
			return false;
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0008DEAE File Offset: 0x0008C0AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AllActorAddAudio"
			};
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x0008DEBE File Offset: 0x0008C0BE
		public static EIntervalSplineSpawnAudioConfigType[] GetValues()
		{
			return new EIntervalSplineSpawnAudioConfigType[1];
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x0008DEC6 File Offset: 0x0008C0C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"AllActorAddAudio"
			};
		}
	}
}

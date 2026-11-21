using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A33 RID: 2611
	public static class EIntervalSplineSpawnAudioConfigTypeExtensions
	{
		// Token: 0x060039F8 RID: 14840 RVA: 0x00095DA4 File Offset: 0x00093FA4
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

		// Token: 0x060039F9 RID: 14841 RVA: 0x00095DCC File Offset: 0x00093FCC
		public static EIntervalSplineSpawnAudioConfigType FromString(string name)
		{
			EIntervalSplineSpawnAudioConfigType result;
			if (!EIntervalSplineSpawnAudioConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EIntervalSplineSpawnAudioConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00095DF5 File Offset: 0x00093FF5
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

		// Token: 0x060039FB RID: 14843 RVA: 0x00095E1A File Offset: 0x0009401A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AllActorAddAudio"
			};
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x00095E2A File Offset: 0x0009402A
		public static EIntervalSplineSpawnAudioConfigType[] GetValues()
		{
			return new EIntervalSplineSpawnAudioConfigType[1];
		}

		// Token: 0x060039FD RID: 14845 RVA: 0x00095E32 File Offset: 0x00094032
		public static string[] GetNames()
		{
			return new string[]
			{
				"AllActorAddAudio"
			};
		}
	}
}

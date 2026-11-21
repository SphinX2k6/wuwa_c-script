using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002516 RID: 9494
	public static class EAudioTypeExtensions
	{
		// Token: 0x0600CE3D RID: 52797 RVA: 0x001DE61C File Offset: 0x001DC81C
		public static string ToEnumString(this EAudioType value)
		{
			string result;
			if (value == EAudioType.RoleSceneVoice)
			{
				result = "RoleSceneVoice";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CE3E RID: 52798 RVA: 0x001DE644 File Offset: 0x001DC844
		public static EAudioType FromString(string name)
		{
			EAudioType result;
			if (!EAudioTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE3F RID: 52799 RVA: 0x001DE66D File Offset: 0x001DC86D
		public static bool TryFromString(string name, out EAudioType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAudioType.RoleSceneVoice;
				return false;
			}
			if (name == "RoleSceneVoice")
			{
				value = EAudioType.RoleSceneVoice;
				return true;
			}
			value = EAudioType.RoleSceneVoice;
			return false;
		}

		// Token: 0x0600CE40 RID: 52800 RVA: 0x001DE692 File Offset: 0x001DC892
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RoleSceneVoice"
			};
		}

		// Token: 0x0600CE41 RID: 52801 RVA: 0x001DE6A2 File Offset: 0x001DC8A2
		public static EAudioType[] GetValues()
		{
			return new EAudioType[1];
		}

		// Token: 0x0600CE42 RID: 52802 RVA: 0x001DE6AA File Offset: 0x001DC8AA
		public static string[] GetNames()
		{
			return new string[]
			{
				"RoleSceneVoice"
			};
		}
	}
}

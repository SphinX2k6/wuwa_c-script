using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A7 RID: 8871
	public static class EAudioTypeExtensions
	{
		// Token: 0x0600C26E RID: 49774 RVA: 0x001C6814 File Offset: 0x001C4A14
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

		// Token: 0x0600C26F RID: 49775 RVA: 0x001C683C File Offset: 0x001C4A3C
		public static EAudioType FromString(string name)
		{
			EAudioType result;
			if (!EAudioTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x001C6865 File Offset: 0x001C4A65
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

		// Token: 0x0600C271 RID: 49777 RVA: 0x001C688A File Offset: 0x001C4A8A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RoleSceneVoice"
			};
		}

		// Token: 0x0600C272 RID: 49778 RVA: 0x001C689A File Offset: 0x001C4A9A
		public static EAudioType[] GetValues()
		{
			return new EAudioType[1];
		}

		// Token: 0x0600C273 RID: 49779 RVA: 0x001C68A2 File Offset: 0x001C4AA2
		public static string[] GetNames()
		{
			return new string[]
			{
				"RoleSceneVoice"
			};
		}
	}
}

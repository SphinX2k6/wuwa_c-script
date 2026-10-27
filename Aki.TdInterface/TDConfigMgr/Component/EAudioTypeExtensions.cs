using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008FE RID: 2302
	public static class EAudioTypeExtensions
	{
		// Token: 0x06003428 RID: 13352 RVA: 0x00085480 File Offset: 0x00083680
		public static string ToEnumString(this EAudioType value)
		{
			string result;
			if (value != EAudioType.AudioAMB)
			{
				if (value != EAudioType.AudioBGM)
				{
					result = value.ToString();
				}
				else
				{
					result = "AudioBGM";
				}
			}
			else
			{
				result = "AudioAMB";
			}
			return result;
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000854B8 File Offset: 0x000836B8
		public static EAudioType FromString(string name)
		{
			EAudioType result;
			if (!EAudioTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000854E1 File Offset: 0x000836E1
		public static bool TryFromString(string name, out EAudioType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAudioType.AudioAMB;
				return false;
			}
			if (name == "AudioAMB")
			{
				value = EAudioType.AudioAMB;
				return true;
			}
			if (!(name == "AudioBGM"))
			{
				value = EAudioType.AudioAMB;
				return false;
			}
			value = EAudioType.AudioBGM;
			return true;
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x0008551A File Offset: 0x0008371A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AudioAMB",
				"AudioBGM"
			};
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00085532 File Offset: 0x00083732
		public static EAudioType[] GetValues()
		{
			return new EAudioType[]
			{
				EAudioType.AudioAMB,
				EAudioType.AudioBGM
			};
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x0008553E File Offset: 0x0008373E
		public static string[] GetNames()
		{
			return new string[]
			{
				"AudioAMB",
				"AudioBGM"
			};
		}
	}
}

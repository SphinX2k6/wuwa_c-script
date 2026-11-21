using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A7 RID: 2471
	public static class EAudioTypeExtensions
	{
		// Token: 0x06003782 RID: 14210 RVA: 0x0008CCF0 File Offset: 0x0008AEF0
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

		// Token: 0x06003783 RID: 14211 RVA: 0x0008CD28 File Offset: 0x0008AF28
		public static EAudioType FromString(string name)
		{
			EAudioType result;
			if (!EAudioTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x0008CD51 File Offset: 0x0008AF51
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

		// Token: 0x06003785 RID: 14213 RVA: 0x0008CD8A File Offset: 0x0008AF8A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AudioAMB",
				"AudioBGM"
			};
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x0008CDA2 File Offset: 0x0008AFA2
		public static EAudioType[] GetValues()
		{
			return new EAudioType[]
			{
				EAudioType.AudioAMB,
				EAudioType.AudioBGM
			};
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x0008CDAE File Offset: 0x0008AFAE
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

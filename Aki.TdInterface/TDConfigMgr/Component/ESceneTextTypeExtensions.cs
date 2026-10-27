using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A06 RID: 2566
	public static class ESceneTextTypeExtensions
	{
		// Token: 0x060038CC RID: 14540 RVA: 0x00092DA8 File Offset: 0x00090FA8
		public static string ToEnumString(this ESceneTextType value)
		{
			string result;
			if (value != ESceneTextType.SubtitleWithVoice)
			{
				if (value != ESceneTextType.SceneGuideUi)
				{
					result = value.ToString();
				}
				else
				{
					result = "SceneGuideUi";
				}
			}
			else
			{
				result = "SubtitleWithVoice";
			}
			return result;
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x00092DE0 File Offset: 0x00090FE0
		public static ESceneTextType FromString(string name)
		{
			ESceneTextType result;
			if (!ESceneTextTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneTextType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x00092E09 File Offset: 0x00091009
		public static bool TryFromString(string name, out ESceneTextType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneTextType.SubtitleWithVoice;
				return false;
			}
			if (name == "SubtitleWithVoice")
			{
				value = ESceneTextType.SubtitleWithVoice;
				return true;
			}
			if (!(name == "SceneGuideUi"))
			{
				value = ESceneTextType.SubtitleWithVoice;
				return false;
			}
			value = ESceneTextType.SceneGuideUi;
			return true;
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x00092E42 File Offset: 0x00091042
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SubtitleWithVoice",
				"SceneGuideUi"
			};
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x00092E5A File Offset: 0x0009105A
		public static ESceneTextType[] GetValues()
		{
			return new ESceneTextType[]
			{
				ESceneTextType.SubtitleWithVoice,
				ESceneTextType.SceneGuideUi
			};
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00092E66 File Offset: 0x00091066
		public static string[] GetNames()
		{
			return new string[]
			{
				"SubtitleWithVoice",
				"SceneGuideUi"
			};
		}
	}
}

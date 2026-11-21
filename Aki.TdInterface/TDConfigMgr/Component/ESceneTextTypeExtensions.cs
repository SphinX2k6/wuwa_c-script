using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ACB RID: 2763
	public static class ESceneTextTypeExtensions
	{
		// Token: 0x06003CA4 RID: 15524 RVA: 0x0009B698 File Offset: 0x00099898
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

		// Token: 0x06003CA5 RID: 15525 RVA: 0x0009B6D0 File Offset: 0x000998D0
		public static ESceneTextType FromString(string name)
		{
			ESceneTextType result;
			if (!ESceneTextTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneTextType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x0009B6F9 File Offset: 0x000998F9
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

		// Token: 0x06003CA7 RID: 15527 RVA: 0x0009B732 File Offset: 0x00099932
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SubtitleWithVoice",
				"SceneGuideUi"
			};
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x0009B74A File Offset: 0x0009994A
		public static ESceneTextType[] GetValues()
		{
			return new ESceneTextType[]
			{
				ESceneTextType.SubtitleWithVoice,
				ESceneTextType.SceneGuideUi
			};
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x0009B756 File Offset: 0x00099956
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

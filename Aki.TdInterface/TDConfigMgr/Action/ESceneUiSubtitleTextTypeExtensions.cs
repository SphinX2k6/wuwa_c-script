using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200269C RID: 9884
	public static class ESceneUiSubtitleTextTypeExtensions
	{
		// Token: 0x0600D518 RID: 54552 RVA: 0x001EF1F0 File Offset: 0x001ED3F0
		public static string ToEnumString(this ESceneUiSubtitleTextType value)
		{
			string result;
			if (value != ESceneUiSubtitleTextType.Flow)
			{
				if (value != ESceneUiSubtitleTextType.TextKey)
				{
					result = value.ToString();
				}
				else
				{
					result = "TextKey";
				}
			}
			else
			{
				result = "Flow";
			}
			return result;
		}

		// Token: 0x0600D519 RID: 54553 RVA: 0x001EF228 File Offset: 0x001ED428
		public static ESceneUiSubtitleTextType FromString(string name)
		{
			ESceneUiSubtitleTextType result;
			if (!ESceneUiSubtitleTextTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneUiSubtitleTextType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D51A RID: 54554 RVA: 0x001EF251 File Offset: 0x001ED451
		public static bool TryFromString(string name, out ESceneUiSubtitleTextType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneUiSubtitleTextType.Flow;
				return false;
			}
			if (name == "Flow")
			{
				value = ESceneUiSubtitleTextType.Flow;
				return true;
			}
			if (!(name == "TextKey"))
			{
				value = ESceneUiSubtitleTextType.Flow;
				return false;
			}
			value = ESceneUiSubtitleTextType.TextKey;
			return true;
		}

		// Token: 0x0600D51B RID: 54555 RVA: 0x001EF28A File Offset: 0x001ED48A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Flow",
				"TextKey"
			};
		}

		// Token: 0x0600D51C RID: 54556 RVA: 0x001EF2A2 File Offset: 0x001ED4A2
		public static ESceneUiSubtitleTextType[] GetValues()
		{
			return new ESceneUiSubtitleTextType[]
			{
				ESceneUiSubtitleTextType.Flow,
				ESceneUiSubtitleTextType.TextKey
			};
		}

		// Token: 0x0600D51D RID: 54557 RVA: 0x001EF2AE File Offset: 0x001ED4AE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Flow",
				"TextKey"
			};
		}
	}
}

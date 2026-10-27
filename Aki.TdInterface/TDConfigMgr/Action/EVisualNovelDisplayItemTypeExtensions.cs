using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A9 RID: 9385
	public static class EVisualNovelDisplayItemTypeExtensions
	{
		// Token: 0x0600CB77 RID: 52087 RVA: 0x001DF31C File Offset: 0x001DD51C
		public static string ToEnumString(this EVisualNovelDisplayItemType value)
		{
			string result;
			switch (value)
			{
			case EVisualNovelDisplayItemType.Image:
				result = "Image";
				break;
			case EVisualNovelDisplayItemType.Prefab:
				result = "Prefab";
				break;
			case EVisualNovelDisplayItemType.Close:
				result = "Close";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CB78 RID: 52088 RVA: 0x001DF364 File Offset: 0x001DD564
		public static EVisualNovelDisplayItemType FromString(string name)
		{
			EVisualNovelDisplayItemType result;
			if (!EVisualNovelDisplayItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelDisplayItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB79 RID: 52089 RVA: 0x001DF390 File Offset: 0x001DD590
		public static bool TryFromString(string name, out EVisualNovelDisplayItemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelDisplayItemType.Image;
				return false;
			}
			if (name == "Image")
			{
				value = EVisualNovelDisplayItemType.Image;
				return true;
			}
			if (name == "Prefab")
			{
				value = EVisualNovelDisplayItemType.Prefab;
				return true;
			}
			if (!(name == "Close"))
			{
				value = EVisualNovelDisplayItemType.Image;
				return false;
			}
			value = EVisualNovelDisplayItemType.Close;
			return true;
		}

		// Token: 0x0600CB7A RID: 52090 RVA: 0x001DF3E6 File Offset: 0x001DD5E6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Image",
				"Prefab",
				"Close"
			};
		}

		// Token: 0x0600CB7B RID: 52091 RVA: 0x001DF406 File Offset: 0x001DD606
		public static EVisualNovelDisplayItemType[] GetValues()
		{
			return new EVisualNovelDisplayItemType[]
			{
				EVisualNovelDisplayItemType.Image,
				EVisualNovelDisplayItemType.Prefab,
				EVisualNovelDisplayItemType.Close
			};
		}

		// Token: 0x0600CB7C RID: 52092 RVA: 0x001DF416 File Offset: 0x001DD616
		public static string[] GetNames()
		{
			return new string[]
			{
				"Image",
				"Prefab",
				"Close"
			};
		}
	}
}

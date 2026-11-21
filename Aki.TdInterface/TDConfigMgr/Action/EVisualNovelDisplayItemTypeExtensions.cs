using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200274C RID: 10060
	public static class EVisualNovelDisplayItemTypeExtensions
	{
		// Token: 0x0600D830 RID: 55344 RVA: 0x001F94E4 File Offset: 0x001F76E4
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

		// Token: 0x0600D831 RID: 55345 RVA: 0x001F952C File Offset: 0x001F772C
		public static EVisualNovelDisplayItemType FromString(string name)
		{
			EVisualNovelDisplayItemType result;
			if (!EVisualNovelDisplayItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelDisplayItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D832 RID: 55346 RVA: 0x001F9558 File Offset: 0x001F7758
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

		// Token: 0x0600D833 RID: 55347 RVA: 0x001F95AE File Offset: 0x001F77AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Image",
				"Prefab",
				"Close"
			};
		}

		// Token: 0x0600D834 RID: 55348 RVA: 0x001F95CE File Offset: 0x001F77CE
		public static EVisualNovelDisplayItemType[] GetValues()
		{
			return new EVisualNovelDisplayItemType[]
			{
				EVisualNovelDisplayItemType.Image,
				EVisualNovelDisplayItemType.Prefab,
				EVisualNovelDisplayItemType.Close
			};
		}

		// Token: 0x0600D835 RID: 55349 RVA: 0x001F95DE File Offset: 0x001F77DE
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

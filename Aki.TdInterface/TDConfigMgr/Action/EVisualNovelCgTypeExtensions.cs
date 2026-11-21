using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200274A RID: 10058
	public static class EVisualNovelCgTypeExtensions
	{
		// Token: 0x0600D827 RID: 55335 RVA: 0x001F938C File Offset: 0x001F758C
		public static string ToEnumString(this EVisualNovelCgType value)
		{
			string result;
			switch (value)
			{
			case EVisualNovelCgType.LoadPrefab:
				result = "LoadPrefab";
				break;
			case EVisualNovelCgType.LoadImage:
				result = "LoadImage";
				break;
			case EVisualNovelCgType.Clean:
				result = "Clean";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D828 RID: 55336 RVA: 0x001F93D4 File Offset: 0x001F75D4
		public static EVisualNovelCgType FromString(string name)
		{
			EVisualNovelCgType result;
			if (!EVisualNovelCgTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelCgType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D829 RID: 55337 RVA: 0x001F9400 File Offset: 0x001F7600
		public static bool TryFromString(string name, out EVisualNovelCgType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelCgType.LoadPrefab;
				return false;
			}
			if (name == "LoadPrefab")
			{
				value = EVisualNovelCgType.LoadPrefab;
				return true;
			}
			if (name == "LoadImage")
			{
				value = EVisualNovelCgType.LoadImage;
				return true;
			}
			if (!(name == "Clean"))
			{
				value = EVisualNovelCgType.LoadPrefab;
				return false;
			}
			value = EVisualNovelCgType.Clean;
			return true;
		}

		// Token: 0x0600D82A RID: 55338 RVA: 0x001F9456 File Offset: 0x001F7656
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LoadPrefab",
				"LoadImage",
				"Clean"
			};
		}

		// Token: 0x0600D82B RID: 55339 RVA: 0x001F9476 File Offset: 0x001F7676
		public static EVisualNovelCgType[] GetValues()
		{
			return new EVisualNovelCgType[]
			{
				EVisualNovelCgType.LoadPrefab,
				EVisualNovelCgType.LoadImage,
				EVisualNovelCgType.Clean
			};
		}

		// Token: 0x0600D82C RID: 55340 RVA: 0x001F9486 File Offset: 0x001F7686
		public static string[] GetNames()
		{
			return new string[]
			{
				"LoadPrefab",
				"LoadImage",
				"Clean"
			};
		}
	}
}

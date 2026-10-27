using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A7 RID: 9383
	public static class EVisualNovelCgTypeExtensions
	{
		// Token: 0x0600CB6E RID: 52078 RVA: 0x001DF1C4 File Offset: 0x001DD3C4
		public static string ToEnumString(this EVisualNovelCgType value)
		{
			string result;
			switch (value)
			{
			case EVisualNovelCgType.LoadSpine:
				result = "LoadSpine";
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

		// Token: 0x0600CB6F RID: 52079 RVA: 0x001DF20C File Offset: 0x001DD40C
		public static EVisualNovelCgType FromString(string name)
		{
			EVisualNovelCgType result;
			if (!EVisualNovelCgTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelCgType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB70 RID: 52080 RVA: 0x001DF238 File Offset: 0x001DD438
		public static bool TryFromString(string name, out EVisualNovelCgType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelCgType.LoadSpine;
				return false;
			}
			if (name == "LoadSpine")
			{
				value = EVisualNovelCgType.LoadSpine;
				return true;
			}
			if (name == "LoadImage")
			{
				value = EVisualNovelCgType.LoadImage;
				return true;
			}
			if (!(name == "Clean"))
			{
				value = EVisualNovelCgType.LoadSpine;
				return false;
			}
			value = EVisualNovelCgType.Clean;
			return true;
		}

		// Token: 0x0600CB71 RID: 52081 RVA: 0x001DF28E File Offset: 0x001DD48E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LoadSpine",
				"LoadImage",
				"Clean"
			};
		}

		// Token: 0x0600CB72 RID: 52082 RVA: 0x001DF2AE File Offset: 0x001DD4AE
		public static EVisualNovelCgType[] GetValues()
		{
			return new EVisualNovelCgType[]
			{
				EVisualNovelCgType.LoadSpine,
				EVisualNovelCgType.LoadImage,
				EVisualNovelCgType.Clean
			};
		}

		// Token: 0x0600CB73 RID: 52083 RVA: 0x001DF2BE File Offset: 0x001DD4BE
		public static string[] GetNames()
		{
			return new string[]
			{
				"LoadSpine",
				"LoadImage",
				"Clean"
			};
		}
	}
}

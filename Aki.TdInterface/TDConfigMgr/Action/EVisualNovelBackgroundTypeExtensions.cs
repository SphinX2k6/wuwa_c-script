using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002746 RID: 10054
	public static class EVisualNovelBackgroundTypeExtensions
	{
		// Token: 0x0600D815 RID: 55317 RVA: 0x001F9164 File Offset: 0x001F7364
		public static string ToEnumString(this EVisualNovelBackgroundType value)
		{
			string result;
			if (value != EVisualNovelBackgroundType.Load)
			{
				if (value != EVisualNovelBackgroundType.Clean)
				{
					result = value.ToString();
				}
				else
				{
					result = "Clean";
				}
			}
			else
			{
				result = "Load";
			}
			return result;
		}

		// Token: 0x0600D816 RID: 55318 RVA: 0x001F919C File Offset: 0x001F739C
		public static EVisualNovelBackgroundType FromString(string name)
		{
			EVisualNovelBackgroundType result;
			if (!EVisualNovelBackgroundTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelBackgroundType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D817 RID: 55319 RVA: 0x001F91C5 File Offset: 0x001F73C5
		public static bool TryFromString(string name, out EVisualNovelBackgroundType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelBackgroundType.Load;
				return false;
			}
			if (name == "Load")
			{
				value = EVisualNovelBackgroundType.Load;
				return true;
			}
			if (!(name == "Clean"))
			{
				value = EVisualNovelBackgroundType.Load;
				return false;
			}
			value = EVisualNovelBackgroundType.Clean;
			return true;
		}

		// Token: 0x0600D818 RID: 55320 RVA: 0x001F91FE File Offset: 0x001F73FE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Load",
				"Clean"
			};
		}

		// Token: 0x0600D819 RID: 55321 RVA: 0x001F9216 File Offset: 0x001F7416
		public static EVisualNovelBackgroundType[] GetValues()
		{
			return new EVisualNovelBackgroundType[]
			{
				EVisualNovelBackgroundType.Load,
				EVisualNovelBackgroundType.Clean
			};
		}

		// Token: 0x0600D81A RID: 55322 RVA: 0x001F9222 File Offset: 0x001F7422
		public static string[] GetNames()
		{
			return new string[]
			{
				"Load",
				"Clean"
			};
		}
	}
}

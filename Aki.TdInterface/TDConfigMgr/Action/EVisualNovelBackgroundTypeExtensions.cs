using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A3 RID: 9379
	public static class EVisualNovelBackgroundTypeExtensions
	{
		// Token: 0x0600CB5C RID: 52060 RVA: 0x001DEF9C File Offset: 0x001DD19C
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

		// Token: 0x0600CB5D RID: 52061 RVA: 0x001DEFD4 File Offset: 0x001DD1D4
		public static EVisualNovelBackgroundType FromString(string name)
		{
			EVisualNovelBackgroundType result;
			if (!EVisualNovelBackgroundTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelBackgroundType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB5E RID: 52062 RVA: 0x001DEFFD File Offset: 0x001DD1FD
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

		// Token: 0x0600CB5F RID: 52063 RVA: 0x001DF036 File Offset: 0x001DD236
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Load",
				"Clean"
			};
		}

		// Token: 0x0600CB60 RID: 52064 RVA: 0x001DF04E File Offset: 0x001DD24E
		public static EVisualNovelBackgroundType[] GetValues()
		{
			return new EVisualNovelBackgroundType[]
			{
				EVisualNovelBackgroundType.Load,
				EVisualNovelBackgroundType.Clean
			};
		}

		// Token: 0x0600CB61 RID: 52065 RVA: 0x001DF05A File Offset: 0x001DD25A
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

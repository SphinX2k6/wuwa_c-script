using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002750 RID: 10064
	public static class EVisualNovelOptionGroupTypeExtensions
	{
		// Token: 0x0600D842 RID: 55362 RVA: 0x001F9750 File Offset: 0x001F7950
		public static string ToEnumString(this EVisualNovelOptionGroupType value)
		{
			string result;
			if (value != EVisualNovelOptionGroupType.Normal)
			{
				if (value != EVisualNovelOptionGroupType.FullScreen)
				{
					result = value.ToString();
				}
				else
				{
					result = "FullScreen";
				}
			}
			else
			{
				result = "Normal";
			}
			return result;
		}

		// Token: 0x0600D843 RID: 55363 RVA: 0x001F9788 File Offset: 0x001F7988
		public static EVisualNovelOptionGroupType FromString(string name)
		{
			EVisualNovelOptionGroupType result;
			if (!EVisualNovelOptionGroupTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelOptionGroupType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D844 RID: 55364 RVA: 0x001F97B1 File Offset: 0x001F79B1
		public static bool TryFromString(string name, out EVisualNovelOptionGroupType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelOptionGroupType.Normal;
				return false;
			}
			if (name == "Normal")
			{
				value = EVisualNovelOptionGroupType.Normal;
				return true;
			}
			if (!(name == "FullScreen"))
			{
				value = EVisualNovelOptionGroupType.Normal;
				return false;
			}
			value = EVisualNovelOptionGroupType.FullScreen;
			return true;
		}

		// Token: 0x0600D845 RID: 55365 RVA: 0x001F97EA File Offset: 0x001F79EA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"FullScreen"
			};
		}

		// Token: 0x0600D846 RID: 55366 RVA: 0x001F9802 File Offset: 0x001F7A02
		public static EVisualNovelOptionGroupType[] GetValues()
		{
			return new EVisualNovelOptionGroupType[]
			{
				EVisualNovelOptionGroupType.Normal,
				EVisualNovelOptionGroupType.FullScreen
			};
		}

		// Token: 0x0600D847 RID: 55367 RVA: 0x001F980E File Offset: 0x001F7A0E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Normal",
				"FullScreen"
			};
		}
	}
}

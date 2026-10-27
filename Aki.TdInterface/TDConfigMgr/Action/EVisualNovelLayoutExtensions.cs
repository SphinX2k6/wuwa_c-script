using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024AB RID: 9387
	public static class EVisualNovelLayoutExtensions
	{
		// Token: 0x0600CB80 RID: 52096 RVA: 0x001DF474 File Offset: 0x001DD674
		public static string ToEnumString(this EVisualNovelLayout value)
		{
			string result;
			if (value != EVisualNovelLayout.Portrait)
			{
				if (value != EVisualNovelLayout.TextBox)
				{
					result = value.ToString();
				}
				else
				{
					result = "TextBox";
				}
			}
			else
			{
				result = "Portrait";
			}
			return result;
		}

		// Token: 0x0600CB81 RID: 52097 RVA: 0x001DF4AC File Offset: 0x001DD6AC
		public static EVisualNovelLayout FromString(string name)
		{
			EVisualNovelLayout result;
			if (!EVisualNovelLayoutExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelLayout 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB82 RID: 52098 RVA: 0x001DF4D5 File Offset: 0x001DD6D5
		public static bool TryFromString(string name, out EVisualNovelLayout value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelLayout.Portrait;
				return false;
			}
			if (name == "Portrait")
			{
				value = EVisualNovelLayout.Portrait;
				return true;
			}
			if (!(name == "TextBox"))
			{
				value = EVisualNovelLayout.Portrait;
				return false;
			}
			value = EVisualNovelLayout.TextBox;
			return true;
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x001DF50E File Offset: 0x001DD70E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Portrait",
				"TextBox"
			};
		}

		// Token: 0x0600CB84 RID: 52100 RVA: 0x001DF526 File Offset: 0x001DD726
		public static EVisualNovelLayout[] GetValues()
		{
			return new EVisualNovelLayout[]
			{
				EVisualNovelLayout.Portrait,
				EVisualNovelLayout.TextBox
			};
		}

		// Token: 0x0600CB85 RID: 52101 RVA: 0x001DF532 File Offset: 0x001DD732
		public static string[] GetNames()
		{
			return new string[]
			{
				"Portrait",
				"TextBox"
			};
		}
	}
}

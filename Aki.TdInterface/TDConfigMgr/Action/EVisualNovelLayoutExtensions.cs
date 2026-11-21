using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200274E RID: 10062
	public static class EVisualNovelLayoutExtensions
	{
		// Token: 0x0600D839 RID: 55353 RVA: 0x001F963C File Offset: 0x001F783C
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

		// Token: 0x0600D83A RID: 55354 RVA: 0x001F9674 File Offset: 0x001F7874
		public static EVisualNovelLayout FromString(string name)
		{
			EVisualNovelLayout result;
			if (!EVisualNovelLayoutExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelLayout 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D83B RID: 55355 RVA: 0x001F969D File Offset: 0x001F789D
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

		// Token: 0x0600D83C RID: 55356 RVA: 0x001F96D6 File Offset: 0x001F78D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Portrait",
				"TextBox"
			};
		}

		// Token: 0x0600D83D RID: 55357 RVA: 0x001F96EE File Offset: 0x001F78EE
		public static EVisualNovelLayout[] GetValues()
		{
			return new EVisualNovelLayout[]
			{
				EVisualNovelLayout.Portrait,
				EVisualNovelLayout.TextBox
			};
		}

		// Token: 0x0600D83E RID: 55358 RVA: 0x001F96FA File Offset: 0x001F78FA
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

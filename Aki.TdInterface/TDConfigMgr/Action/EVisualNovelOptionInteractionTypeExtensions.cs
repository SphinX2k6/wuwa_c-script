using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002752 RID: 10066
	public static class EVisualNovelOptionInteractionTypeExtensions
	{
		// Token: 0x0600D84B RID: 55371 RVA: 0x001F9864 File Offset: 0x001F7A64
		public static string ToEnumString(this EVisualNovelOptionInteractionType value)
		{
			string result;
			if (value == EVisualNovelOptionInteractionType.HideAndAutoSelect)
			{
				result = "HideAndAutoSelect";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D84C RID: 55372 RVA: 0x001F988C File Offset: 0x001F7A8C
		public static EVisualNovelOptionInteractionType FromString(string name)
		{
			EVisualNovelOptionInteractionType result;
			if (!EVisualNovelOptionInteractionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelOptionInteractionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D84D RID: 55373 RVA: 0x001F98B5 File Offset: 0x001F7AB5
		public static bool TryFromString(string name, out EVisualNovelOptionInteractionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelOptionInteractionType.HideAndAutoSelect;
				return false;
			}
			if (name == "HideAndAutoSelect")
			{
				value = EVisualNovelOptionInteractionType.HideAndAutoSelect;
				return true;
			}
			value = EVisualNovelOptionInteractionType.HideAndAutoSelect;
			return false;
		}

		// Token: 0x0600D84E RID: 55374 RVA: 0x001F98DA File Offset: 0x001F7ADA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HideAndAutoSelect"
			};
		}

		// Token: 0x0600D84F RID: 55375 RVA: 0x001F98EA File Offset: 0x001F7AEA
		public static EVisualNovelOptionInteractionType[] GetValues()
		{
			return new EVisualNovelOptionInteractionType[1];
		}

		// Token: 0x0600D850 RID: 55376 RVA: 0x001F98F2 File Offset: 0x001F7AF2
		public static string[] GetNames()
		{
			return new string[]
			{
				"HideAndAutoSelect"
			};
		}
	}
}

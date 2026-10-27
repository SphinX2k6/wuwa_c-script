using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024AF RID: 9391
	public static class EVisualNovelOptionInteractionTypeExtensions
	{
		// Token: 0x0600CB92 RID: 52114 RVA: 0x001DF664 File Offset: 0x001DD864
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

		// Token: 0x0600CB93 RID: 52115 RVA: 0x001DF68C File Offset: 0x001DD88C
		public static EVisualNovelOptionInteractionType FromString(string name)
		{
			EVisualNovelOptionInteractionType result;
			if (!EVisualNovelOptionInteractionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelOptionInteractionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB94 RID: 52116 RVA: 0x001DF6B5 File Offset: 0x001DD8B5
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

		// Token: 0x0600CB95 RID: 52117 RVA: 0x001DF6DA File Offset: 0x001DD8DA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HideAndAutoSelect"
			};
		}

		// Token: 0x0600CB96 RID: 52118 RVA: 0x001DF6EA File Offset: 0x001DD8EA
		public static EVisualNovelOptionInteractionType[] GetValues()
		{
			return new EVisualNovelOptionInteractionType[1];
		}

		// Token: 0x0600CB97 RID: 52119 RVA: 0x001DF6F2 File Offset: 0x001DD8F2
		public static string[] GetNames()
		{
			return new string[]
			{
				"HideAndAutoSelect"
			};
		}
	}
}

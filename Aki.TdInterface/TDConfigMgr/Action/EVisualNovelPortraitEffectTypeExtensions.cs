using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002756 RID: 10070
	public static class EVisualNovelPortraitEffectTypeExtensions
	{
		// Token: 0x0600D85D RID: 55389 RVA: 0x001F9E84 File Offset: 0x001F8084
		public static string ToEnumString(this EVisualNovelPortraitEffectType value)
		{
			string result;
			switch (value)
			{
			case EVisualNovelPortraitEffectType.Jump:
				result = "Jump";
				break;
			case EVisualNovelPortraitEffectType.Shake:
				result = "Shake";
				break;
			case EVisualNovelPortraitEffectType.Sigh:
				result = "Sigh";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D85E RID: 55390 RVA: 0x001F9ECC File Offset: 0x001F80CC
		public static EVisualNovelPortraitEffectType FromString(string name)
		{
			EVisualNovelPortraitEffectType result;
			if (!EVisualNovelPortraitEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelPortraitEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D85F RID: 55391 RVA: 0x001F9EF8 File Offset: 0x001F80F8
		public static bool TryFromString(string name, out EVisualNovelPortraitEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelPortraitEffectType.Jump;
				return false;
			}
			if (name == "Jump")
			{
				value = EVisualNovelPortraitEffectType.Jump;
				return true;
			}
			if (name == "Shake")
			{
				value = EVisualNovelPortraitEffectType.Shake;
				return true;
			}
			if (!(name == "Sigh"))
			{
				value = EVisualNovelPortraitEffectType.Jump;
				return false;
			}
			value = EVisualNovelPortraitEffectType.Sigh;
			return true;
		}

		// Token: 0x0600D860 RID: 55392 RVA: 0x001F9F4E File Offset: 0x001F814E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Jump",
				"Shake",
				"Sigh"
			};
		}

		// Token: 0x0600D861 RID: 55393 RVA: 0x001F9F6E File Offset: 0x001F816E
		public static EVisualNovelPortraitEffectType[] GetValues()
		{
			return new EVisualNovelPortraitEffectType[]
			{
				EVisualNovelPortraitEffectType.Jump,
				EVisualNovelPortraitEffectType.Shake,
				EVisualNovelPortraitEffectType.Sigh
			};
		}

		// Token: 0x0600D862 RID: 55394 RVA: 0x001F9F7E File Offset: 0x001F817E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Jump",
				"Shake",
				"Sigh"
			};
		}
	}
}

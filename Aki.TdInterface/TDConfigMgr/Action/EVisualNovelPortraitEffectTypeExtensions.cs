using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B3 RID: 9395
	public static class EVisualNovelPortraitEffectTypeExtensions
	{
		// Token: 0x0600CBA4 RID: 52132 RVA: 0x001DFCCC File Offset: 0x001DDECC
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

		// Token: 0x0600CBA5 RID: 52133 RVA: 0x001DFD14 File Offset: 0x001DDF14
		public static EVisualNovelPortraitEffectType FromString(string name)
		{
			EVisualNovelPortraitEffectType result;
			if (!EVisualNovelPortraitEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelPortraitEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CBA6 RID: 52134 RVA: 0x001DFD40 File Offset: 0x001DDF40
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

		// Token: 0x0600CBA7 RID: 52135 RVA: 0x001DFD96 File Offset: 0x001DDF96
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Jump",
				"Shake",
				"Sigh"
			};
		}

		// Token: 0x0600CBA8 RID: 52136 RVA: 0x001DFDB6 File Offset: 0x001DDFB6
		public static EVisualNovelPortraitEffectType[] GetValues()
		{
			return new EVisualNovelPortraitEffectType[]
			{
				EVisualNovelPortraitEffectType.Jump,
				EVisualNovelPortraitEffectType.Shake,
				EVisualNovelPortraitEffectType.Sigh
			};
		}

		// Token: 0x0600CBA9 RID: 52137 RVA: 0x001DFDC6 File Offset: 0x001DDFC6
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

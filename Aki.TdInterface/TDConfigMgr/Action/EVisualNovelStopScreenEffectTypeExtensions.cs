using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200275C RID: 10076
	public static class EVisualNovelStopScreenEffectTypeExtensions
	{
		// Token: 0x0600D878 RID: 55416 RVA: 0x001FA248 File Offset: 0x001F8448
		public static string ToEnumString(this EVisualNovelStopScreenEffectType value)
		{
			string result;
			if (value == EVisualNovelStopScreenEffectType.Persistent)
			{
				result = "Persistent";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D879 RID: 55417 RVA: 0x001FA270 File Offset: 0x001F8470
		public static EVisualNovelStopScreenEffectType FromString(string name)
		{
			EVisualNovelStopScreenEffectType result;
			if (!EVisualNovelStopScreenEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelStopScreenEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D87A RID: 55418 RVA: 0x001FA299 File Offset: 0x001F8499
		public static bool TryFromString(string name, out EVisualNovelStopScreenEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelStopScreenEffectType.Persistent;
				return false;
			}
			if (name == "Persistent")
			{
				value = EVisualNovelStopScreenEffectType.Persistent;
				return true;
			}
			value = EVisualNovelStopScreenEffectType.Persistent;
			return false;
		}

		// Token: 0x0600D87B RID: 55419 RVA: 0x001FA2BE File Offset: 0x001F84BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Persistent"
			};
		}

		// Token: 0x0600D87C RID: 55420 RVA: 0x001FA2CE File Offset: 0x001F84CE
		public static EVisualNovelStopScreenEffectType[] GetValues()
		{
			return new EVisualNovelStopScreenEffectType[1];
		}

		// Token: 0x0600D87D RID: 55421 RVA: 0x001FA2D6 File Offset: 0x001F84D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Persistent"
			};
		}
	}
}

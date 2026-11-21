using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200275A RID: 10074
	public static class EVisualNovelScreenEffectTypeExtensions
	{
		// Token: 0x0600D86F RID: 55407 RVA: 0x001FA0F0 File Offset: 0x001F82F0
		public static string ToEnumString(this EVisualNovelScreenEffectType value)
		{
			string result;
			switch (value)
			{
			case EVisualNovelScreenEffectType.OneShot:
				result = "OneShot";
				break;
			case EVisualNovelScreenEffectType.Persistent:
				result = "Persistent";
				break;
			case EVisualNovelScreenEffectType.Custom:
				result = "Custom";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x001FA138 File Offset: 0x001F8338
		public static EVisualNovelScreenEffectType FromString(string name)
		{
			EVisualNovelScreenEffectType result;
			if (!EVisualNovelScreenEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelScreenEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D871 RID: 55409 RVA: 0x001FA164 File Offset: 0x001F8364
		public static bool TryFromString(string name, out EVisualNovelScreenEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelScreenEffectType.OneShot;
				return false;
			}
			if (name == "OneShot")
			{
				value = EVisualNovelScreenEffectType.OneShot;
				return true;
			}
			if (name == "Persistent")
			{
				value = EVisualNovelScreenEffectType.Persistent;
				return true;
			}
			if (!(name == "Custom"))
			{
				value = EVisualNovelScreenEffectType.OneShot;
				return false;
			}
			value = EVisualNovelScreenEffectType.Custom;
			return true;
		}

		// Token: 0x0600D872 RID: 55410 RVA: 0x001FA1BA File Offset: 0x001F83BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OneShot",
				"Persistent",
				"Custom"
			};
		}

		// Token: 0x0600D873 RID: 55411 RVA: 0x001FA1DA File Offset: 0x001F83DA
		public static EVisualNovelScreenEffectType[] GetValues()
		{
			return new EVisualNovelScreenEffectType[]
			{
				EVisualNovelScreenEffectType.OneShot,
				EVisualNovelScreenEffectType.Persistent,
				EVisualNovelScreenEffectType.Custom
			};
		}

		// Token: 0x0600D874 RID: 55412 RVA: 0x001FA1EA File Offset: 0x001F83EA
		public static string[] GetNames()
		{
			return new string[]
			{
				"OneShot",
				"Persistent",
				"Custom"
			};
		}
	}
}

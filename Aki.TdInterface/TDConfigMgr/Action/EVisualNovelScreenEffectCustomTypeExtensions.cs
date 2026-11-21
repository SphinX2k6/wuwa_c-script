using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002758 RID: 10072
	public static class EVisualNovelScreenEffectCustomTypeExtensions
	{
		// Token: 0x0600D866 RID: 55398 RVA: 0x001F9FDC File Offset: 0x001F81DC
		public static string ToEnumString(this EVisualNovelScreenEffectCustomType value)
		{
			string result;
			if (value != EVisualNovelScreenEffectCustomType.BurstEye)
			{
				if (value != EVisualNovelScreenEffectCustomType.Shake)
				{
					result = value.ToString();
				}
				else
				{
					result = "Shake";
				}
			}
			else
			{
				result = "BurstEye";
			}
			return result;
		}

		// Token: 0x0600D867 RID: 55399 RVA: 0x001FA014 File Offset: 0x001F8214
		public static EVisualNovelScreenEffectCustomType FromString(string name)
		{
			EVisualNovelScreenEffectCustomType result;
			if (!EVisualNovelScreenEffectCustomTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelScreenEffectCustomType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D868 RID: 55400 RVA: 0x001FA03D File Offset: 0x001F823D
		public static bool TryFromString(string name, out EVisualNovelScreenEffectCustomType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelScreenEffectCustomType.BurstEye;
				return false;
			}
			if (name == "BurstEye")
			{
				value = EVisualNovelScreenEffectCustomType.BurstEye;
				return true;
			}
			if (!(name == "Shake"))
			{
				value = EVisualNovelScreenEffectCustomType.BurstEye;
				return false;
			}
			value = EVisualNovelScreenEffectCustomType.Shake;
			return true;
		}

		// Token: 0x0600D869 RID: 55401 RVA: 0x001FA076 File Offset: 0x001F8276
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BurstEye",
				"Shake"
			};
		}

		// Token: 0x0600D86A RID: 55402 RVA: 0x001FA08E File Offset: 0x001F828E
		public static EVisualNovelScreenEffectCustomType[] GetValues()
		{
			return new EVisualNovelScreenEffectCustomType[]
			{
				EVisualNovelScreenEffectCustomType.BurstEye,
				EVisualNovelScreenEffectCustomType.Shake
			};
		}

		// Token: 0x0600D86B RID: 55403 RVA: 0x001FA09A File Offset: 0x001F829A
		public static string[] GetNames()
		{
			return new string[]
			{
				"BurstEye",
				"Shake"
			};
		}
	}
}

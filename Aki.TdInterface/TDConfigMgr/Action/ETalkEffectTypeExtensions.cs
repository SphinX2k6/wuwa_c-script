using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002453 RID: 9299
	public static class ETalkEffectTypeExtensions
	{
		// Token: 0x0600C9F4 RID: 51700 RVA: 0x001DB1F8 File Offset: 0x001D93F8
		public static string ToEnumString(this ETalkEffectType value)
		{
			string result;
			if (value == ETalkEffectType.Effect)
			{
				result = "Effect";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C9F5 RID: 51701 RVA: 0x001DB220 File Offset: 0x001D9420
		public static ETalkEffectType FromString(string name)
		{
			ETalkEffectType result;
			if (!ETalkEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9F6 RID: 51702 RVA: 0x001DB249 File Offset: 0x001D9449
		public static bool TryFromString(string name, out ETalkEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETalkEffectType.Effect;
				return false;
			}
			if (name == "Effect")
			{
				value = ETalkEffectType.Effect;
				return true;
			}
			value = ETalkEffectType.Effect;
			return false;
		}

		// Token: 0x0600C9F7 RID: 51703 RVA: 0x001DB26E File Offset: 0x001D946E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Effect"
			};
		}

		// Token: 0x0600C9F8 RID: 51704 RVA: 0x001DB27E File Offset: 0x001D947E
		public static ETalkEffectType[] GetValues()
		{
			return new ETalkEffectType[1];
		}

		// Token: 0x0600C9F9 RID: 51705 RVA: 0x001DB286 File Offset: 0x001D9486
		public static string[] GetNames()
		{
			return new string[]
			{
				"Effect"
			};
		}
	}
}

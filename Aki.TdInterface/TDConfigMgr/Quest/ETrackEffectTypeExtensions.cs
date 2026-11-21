using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013EE RID: 5102
	public static class ETrackEffectTypeExtensions
	{
		// Token: 0x06007209 RID: 29193 RVA: 0x00110E94 File Offset: 0x0010F094
		public static string ToEnumString(this ETrackEffectType value)
		{
			string result;
			if (value == ETrackEffectType.AutoChange)
			{
				result = "AutoChange";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x00110EBC File Offset: 0x0010F0BC
		public static ETrackEffectType FromString(string name)
		{
			ETrackEffectType result;
			if (!ETrackEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x00110EE5 File Offset: 0x0010F0E5
		public static bool TryFromString(string name, out ETrackEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrackEffectType.AutoChange;
				return false;
			}
			if (name == "AutoChange")
			{
				value = ETrackEffectType.AutoChange;
				return true;
			}
			value = ETrackEffectType.AutoChange;
			return false;
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x00110F0A File Offset: 0x0010F10A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AutoChange"
			};
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x00110F1A File Offset: 0x0010F11A
		public static ETrackEffectType[] GetValues()
		{
			return new ETrackEffectType[1];
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x00110F22 File Offset: 0x0010F122
		public static string[] GetNames()
		{
			return new string[]
			{
				"AutoChange"
			};
		}
	}
}

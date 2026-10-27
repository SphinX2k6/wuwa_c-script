using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A8 RID: 4776
	public static class ETrackEffectTypeExtensions
	{
		// Token: 0x06006B9B RID: 27547 RVA: 0x00102ECC File Offset: 0x001010CC
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

		// Token: 0x06006B9C RID: 27548 RVA: 0x00102EF4 File Offset: 0x001010F4
		public static ETrackEffectType FromString(string name)
		{
			ETrackEffectType result;
			if (!ETrackEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x00102F1D File Offset: 0x0010111D
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

		// Token: 0x06006B9E RID: 27550 RVA: 0x00102F42 File Offset: 0x00101142
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AutoChange"
			};
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00102F52 File Offset: 0x00101152
		public static ETrackEffectType[] GetValues()
		{
			return new ETrackEffectType[1];
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x00102F5A File Offset: 0x0010115A
		public static string[] GetNames()
		{
			return new string[]
			{
				"AutoChange"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012BC RID: 4796
	public static class EWordArtEffectiveTargetTypeExtensions
	{
		// Token: 0x06006BF5 RID: 27637 RVA: 0x00103D68 File Offset: 0x00101F68
		public static string ToEnumString(this EWordArtEffectiveTargetType value)
		{
			string result;
			if (value == EWordArtEffectiveTargetType.Number)
			{
				result = "Number";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x00103D90 File Offset: 0x00101F90
		public static EWordArtEffectiveTargetType FromString(string name)
		{
			EWordArtEffectiveTargetType result;
			if (!EWordArtEffectiveTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWordArtEffectiveTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x00103DB9 File Offset: 0x00101FB9
		public static bool TryFromString(string name, out EWordArtEffectiveTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EWordArtEffectiveTargetType.Number;
				return false;
			}
			if (name == "Number")
			{
				value = EWordArtEffectiveTargetType.Number;
				return true;
			}
			value = EWordArtEffectiveTargetType.Number;
			return false;
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x00103DDE File Offset: 0x00101FDE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Number"
			};
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x00103DEE File Offset: 0x00101FEE
		public static EWordArtEffectiveTargetType[] GetValues()
		{
			return new EWordArtEffectiveTargetType[1];
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x00103DF6 File Offset: 0x00101FF6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Number"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002640 RID: 9792
	public static class ENpcGroupSequenceBlendAnimTypeExtensions
	{
		// Token: 0x0600D37A RID: 54138 RVA: 0x001EBA44 File Offset: 0x001E9C44
		public static string ToEnumString(this ENpcGroupSequenceBlendAnimType value)
		{
			string result;
			if (value == ENpcGroupSequenceBlendAnimType.AnimSequence)
			{
				result = "AnimSequence";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D37B RID: 54139 RVA: 0x001EBA6C File Offset: 0x001E9C6C
		public static ENpcGroupSequenceBlendAnimType FromString(string name)
		{
			ENpcGroupSequenceBlendAnimType result;
			if (!ENpcGroupSequenceBlendAnimTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcGroupSequenceBlendAnimType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D37C RID: 54140 RVA: 0x001EBA95 File Offset: 0x001E9C95
		public static bool TryFromString(string name, out ENpcGroupSequenceBlendAnimType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcGroupSequenceBlendAnimType.AnimSequence;
				return false;
			}
			if (name == "AnimSequence")
			{
				value = ENpcGroupSequenceBlendAnimType.AnimSequence;
				return true;
			}
			value = ENpcGroupSequenceBlendAnimType.AnimSequence;
			return false;
		}

		// Token: 0x0600D37D RID: 54141 RVA: 0x001EBABA File Offset: 0x001E9CBA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AnimSequence"
			};
		}

		// Token: 0x0600D37E RID: 54142 RVA: 0x001EBACA File Offset: 0x001E9CCA
		public static ENpcGroupSequenceBlendAnimType[] GetValues()
		{
			return new ENpcGroupSequenceBlendAnimType[1];
		}

		// Token: 0x0600D37F RID: 54143 RVA: 0x001EBAD2 File Offset: 0x001E9CD2
		public static string[] GetNames()
		{
			return new string[]
			{
				"AnimSequence"
			};
		}
	}
}

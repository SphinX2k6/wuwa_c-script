using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A6 RID: 4774
	public static class ETrackEffectExtensions
	{
		// Token: 0x06006B92 RID: 27538 RVA: 0x00102DB8 File Offset: 0x00100FB8
		public static string ToEnumString(this ETrackEffect value)
		{
			string result;
			if (value != ETrackEffect.LongLightBeam)
			{
				if (value != ETrackEffect.ShortLightBeam)
				{
					result = value.ToString();
				}
				else
				{
					result = "ShortLightBeam";
				}
			}
			else
			{
				result = "LongLightBeam";
			}
			return result;
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x00102DF0 File Offset: 0x00100FF0
		public static ETrackEffect FromString(string name)
		{
			ETrackEffect result;
			if (!ETrackEffectExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackEffect 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x00102E19 File Offset: 0x00101019
		public static bool TryFromString(string name, out ETrackEffect value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrackEffect.LongLightBeam;
				return false;
			}
			if (name == "LongLightBeam")
			{
				value = ETrackEffect.LongLightBeam;
				return true;
			}
			if (!(name == "ShortLightBeam"))
			{
				value = ETrackEffect.LongLightBeam;
				return false;
			}
			value = ETrackEffect.ShortLightBeam;
			return true;
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x00102E52 File Offset: 0x00101052
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LongLightBeam",
				"ShortLightBeam"
			};
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x00102E6A File Offset: 0x0010106A
		public static ETrackEffect[] GetValues()
		{
			return new ETrackEffect[]
			{
				ETrackEffect.LongLightBeam,
				ETrackEffect.ShortLightBeam
			};
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x00102E76 File Offset: 0x00101076
		public static string[] GetNames()
		{
			return new string[]
			{
				"LongLightBeam",
				"ShortLightBeam"
			};
		}
	}
}

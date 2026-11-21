using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013EC RID: 5100
	public static class ETrackEffectExtensions
	{
		// Token: 0x06007200 RID: 29184 RVA: 0x00110D80 File Offset: 0x0010EF80
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

		// Token: 0x06007201 RID: 29185 RVA: 0x00110DB8 File Offset: 0x0010EFB8
		public static ETrackEffect FromString(string name)
		{
			ETrackEffect result;
			if (!ETrackEffectExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackEffect 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x00110DE1 File Offset: 0x0010EFE1
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

		// Token: 0x06007203 RID: 29187 RVA: 0x00110E1A File Offset: 0x0010F01A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LongLightBeam",
				"ShortLightBeam"
			};
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x00110E32 File Offset: 0x0010F032
		public static ETrackEffect[] GetValues()
		{
			return new ETrackEffect[]
			{
				ETrackEffect.LongLightBeam,
				ETrackEffect.ShortLightBeam
			};
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x00110E3E File Offset: 0x0010F03E
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

using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001402 RID: 5122
	public static class EWordArtEffectiveTargetTypeExtensions
	{
		// Token: 0x06007263 RID: 29283 RVA: 0x00111D30 File Offset: 0x0010FF30
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

		// Token: 0x06007264 RID: 29284 RVA: 0x00111D58 File Offset: 0x0010FF58
		public static EWordArtEffectiveTargetType FromString(string name)
		{
			EWordArtEffectiveTargetType result;
			if (!EWordArtEffectiveTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWordArtEffectiveTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x00111D81 File Offset: 0x0010FF81
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

		// Token: 0x06007266 RID: 29286 RVA: 0x00111DA6 File Offset: 0x0010FFA6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Number"
			};
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00111DB6 File Offset: 0x0010FFB6
		public static EWordArtEffectiveTargetType[] GetValues()
		{
			return new EWordArtEffectiveTargetType[1];
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x00111DBE File Offset: 0x0010FFBE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Number"
			};
		}
	}
}

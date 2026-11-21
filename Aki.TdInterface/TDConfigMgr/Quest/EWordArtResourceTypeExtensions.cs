using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001404 RID: 5124
	public static class EWordArtResourceTypeExtensions
	{
		// Token: 0x0600726C RID: 29292 RVA: 0x00111E0C File Offset: 0x0011000C
		public static string ToEnumString(this EWordArtResourceType value)
		{
			string result;
			if (value == EWordArtResourceType.Default)
			{
				result = "Default";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x00111E34 File Offset: 0x00110034
		public static EWordArtResourceType FromString(string name)
		{
			EWordArtResourceType result;
			if (!EWordArtResourceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWordArtResourceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600726E RID: 29294 RVA: 0x00111E5D File Offset: 0x0011005D
		public static bool TryFromString(string name, out EWordArtResourceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EWordArtResourceType.Default;
				return false;
			}
			if (name == "Default")
			{
				value = EWordArtResourceType.Default;
				return true;
			}
			value = EWordArtResourceType.Default;
			return false;
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x00111E82 File Offset: 0x00110082
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default"
			};
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x00111E92 File Offset: 0x00110092
		public static EWordArtResourceType[] GetValues()
		{
			return new EWordArtResourceType[1];
		}

		// Token: 0x06007271 RID: 29297 RVA: 0x00111E9A File Offset: 0x0011009A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default"
			};
		}
	}
}

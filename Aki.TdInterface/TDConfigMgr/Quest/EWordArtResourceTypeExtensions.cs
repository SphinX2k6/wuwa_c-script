using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012BE RID: 4798
	public static class EWordArtResourceTypeExtensions
	{
		// Token: 0x06006BFE RID: 27646 RVA: 0x00103E44 File Offset: 0x00102044
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

		// Token: 0x06006BFF RID: 27647 RVA: 0x00103E6C File Offset: 0x0010206C
		public static EWordArtResourceType FromString(string name)
		{
			EWordArtResourceType result;
			if (!EWordArtResourceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWordArtResourceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x00103E95 File Offset: 0x00102095
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

		// Token: 0x06006C01 RID: 27649 RVA: 0x00103EBA File Offset: 0x001020BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default"
			};
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x00103ECA File Offset: 0x001020CA
		public static EWordArtResourceType[] GetValues()
		{
			return new EWordArtResourceType[1];
		}

		// Token: 0x06006C03 RID: 27651 RVA: 0x00103ED2 File Offset: 0x001020D2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default"
			};
		}
	}
}

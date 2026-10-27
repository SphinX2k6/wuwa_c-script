using System;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000278 RID: 632
	public static class EAppTypeExtensions
	{
		// Token: 0x06000F59 RID: 3929 RVA: 0x00059918 File Offset: 0x00057B18
		public static string ToEnumString(this EAppType value)
		{
			string result;
			switch (value)
			{
			case EAppType.DEVELOPMENT:
				result = "Development";
				break;
			case EAppType.PREREKEASE:
				result = "Prerelease";
				break;
			case EAppType.PRODUCT:
				result = "Product";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00059960 File Offset: 0x00057B60
		public static EAppType FromString(string name)
		{
			EAppType result;
			if (!EAppTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAppType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0005998C File Offset: 0x00057B8C
		public static bool TryFromString(string name, out EAppType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAppType.DEVELOPMENT;
				return false;
			}
			if (name == "Development")
			{
				value = EAppType.DEVELOPMENT;
				return true;
			}
			if (name == "Prerelease")
			{
				value = EAppType.PREREKEASE;
				return true;
			}
			if (!(name == "Product"))
			{
				value = EAppType.DEVELOPMENT;
				return false;
			}
			value = EAppType.PRODUCT;
			return true;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000599E2 File Offset: 0x00057BE2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Development",
				"Prerelease",
				"Product"
			};
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00059A02 File Offset: 0x00057C02
		public static EAppType[] GetValues()
		{
			return new EAppType[]
			{
				EAppType.DEVELOPMENT,
				EAppType.PREREKEASE,
				EAppType.PRODUCT
			};
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00059A12 File Offset: 0x00057C12
		public static string[] GetNames()
		{
			return new string[]
			{
				"DEVELOPMENT",
				"PREREKEASE",
				"PRODUCT"
			};
		}
	}
}

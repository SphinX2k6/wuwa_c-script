using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0B RID: 2571
	public static class EGroupAiEcologyGameplayTypeExtensions
	{
		// Token: 0x06003944 RID: 14660 RVA: 0x00094038 File Offset: 0x00092238
		public static string ToEnumString(this EGroupAiEcologyGameplayType value)
		{
			string result;
			if (value == EGroupAiEcologyGameplayType.FloatParade)
			{
				result = "FloatParade";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x00094060 File Offset: 0x00092260
		public static EGroupAiEcologyGameplayType FromString(string name)
		{
			EGroupAiEcologyGameplayType result;
			if (!EGroupAiEcologyGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupAiEcologyGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x00094089 File Offset: 0x00092289
		public static bool TryFromString(string name, out EGroupAiEcologyGameplayType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGroupAiEcologyGameplayType.FloatParade;
				return false;
			}
			if (name == "FloatParade")
			{
				value = EGroupAiEcologyGameplayType.FloatParade;
				return true;
			}
			value = EGroupAiEcologyGameplayType.FloatParade;
			return false;
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x000940AE File Offset: 0x000922AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FloatParade"
			};
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x000940BE File Offset: 0x000922BE
		public static EGroupAiEcologyGameplayType[] GetValues()
		{
			return new EGroupAiEcologyGameplayType[1];
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x000940C6 File Offset: 0x000922C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"FloatParade"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200235B RID: 9051
	public static class EInfrActivityBuildStageTypeExtensions
	{
		// Token: 0x0600C598 RID: 50584 RVA: 0x001CD62C File Offset: 0x001CB82C
		public static string ToEnumString(this EInfrActivityBuildStageType value)
		{
			string result;
			if (value != EInfrActivityBuildStageType.Infrastructure)
			{
				if (value != EInfrActivityBuildStageType.Road)
				{
					result = value.ToString();
				}
				else
				{
					result = "Road";
				}
			}
			else
			{
				result = "Infrastructure";
			}
			return result;
		}

		// Token: 0x0600C599 RID: 50585 RVA: 0x001CD664 File Offset: 0x001CB864
		public static EInfrActivityBuildStageType FromString(string name)
		{
			EInfrActivityBuildStageType result;
			if (!EInfrActivityBuildStageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInfrActivityBuildStageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C59A RID: 50586 RVA: 0x001CD68D File Offset: 0x001CB88D
		public static bool TryFromString(string name, out EInfrActivityBuildStageType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInfrActivityBuildStageType.Infrastructure;
				return false;
			}
			if (name == "Infrastructure")
			{
				value = EInfrActivityBuildStageType.Infrastructure;
				return true;
			}
			if (!(name == "Road"))
			{
				value = EInfrActivityBuildStageType.Infrastructure;
				return false;
			}
			value = EInfrActivityBuildStageType.Road;
			return true;
		}

		// Token: 0x0600C59B RID: 50587 RVA: 0x001CD6C6 File Offset: 0x001CB8C6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Infrastructure",
				"Road"
			};
		}

		// Token: 0x0600C59C RID: 50588 RVA: 0x001CD6DE File Offset: 0x001CB8DE
		public static EInfrActivityBuildStageType[] GetValues()
		{
			return new EInfrActivityBuildStageType[]
			{
				EInfrActivityBuildStageType.Infrastructure,
				EInfrActivityBuildStageType.Road
			};
		}

		// Token: 0x0600C59D RID: 50589 RVA: 0x001CD6EA File Offset: 0x001CB8EA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Infrastructure",
				"Road"
			};
		}
	}
}

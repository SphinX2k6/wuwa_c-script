using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002357 RID: 9047
	public static class EHighlightTypeExtensions
	{
		// Token: 0x0600C586 RID: 50566 RVA: 0x001CD43C File Offset: 0x001CB63C
		public static string ToEnumString(this EHighlightType value)
		{
			string result;
			if (value != EHighlightType.CommonWhite)
			{
				if (value != EHighlightType.CommonYellow)
				{
					result = value.ToString();
				}
				else
				{
					result = "角色.Common.技能通用标识.探索技能高亮黄色";
				}
			}
			else
			{
				result = "角色.Common.技能通用标识.探索技能高亮";
			}
			return result;
		}

		// Token: 0x0600C587 RID: 50567 RVA: 0x001CD474 File Offset: 0x001CB674
		public static EHighlightType FromString(string name)
		{
			EHighlightType result;
			if (!EHighlightTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHighlightType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C588 RID: 50568 RVA: 0x001CD49D File Offset: 0x001CB69D
		public static bool TryFromString(string name, out EHighlightType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHighlightType.CommonWhite;
				return false;
			}
			if (name == "角色.Common.技能通用标识.探索技能高亮")
			{
				value = EHighlightType.CommonWhite;
				return true;
			}
			if (!(name == "角色.Common.技能通用标识.探索技能高亮黄色"))
			{
				value = EHighlightType.CommonWhite;
				return false;
			}
			value = EHighlightType.CommonYellow;
			return true;
		}

		// Token: 0x0600C589 RID: 50569 RVA: 0x001CD4D6 File Offset: 0x001CB6D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"角色.Common.技能通用标识.探索技能高亮",
				"角色.Common.技能通用标识.探索技能高亮黄色"
			};
		}

		// Token: 0x0600C58A RID: 50570 RVA: 0x001CD4EE File Offset: 0x001CB6EE
		public static EHighlightType[] GetValues()
		{
			return new EHighlightType[]
			{
				EHighlightType.CommonWhite,
				EHighlightType.CommonYellow
			};
		}

		// Token: 0x0600C58B RID: 50571 RVA: 0x001CD4FA File Offset: 0x001CB6FA
		public static string[] GetNames()
		{
			return new string[]
			{
				"CommonWhite",
				"CommonYellow"
			};
		}
	}
}

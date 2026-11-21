using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025CC RID: 9676
	public static class EHighlightTypeExtensions
	{
		// Token: 0x0600D170 RID: 53616 RVA: 0x001E571C File Offset: 0x001E391C
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

		// Token: 0x0600D171 RID: 53617 RVA: 0x001E5754 File Offset: 0x001E3954
		public static EHighlightType FromString(string name)
		{
			EHighlightType result;
			if (!EHighlightTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHighlightType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D172 RID: 53618 RVA: 0x001E577D File Offset: 0x001E397D
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

		// Token: 0x0600D173 RID: 53619 RVA: 0x001E57B6 File Offset: 0x001E39B6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"角色.Common.技能通用标识.探索技能高亮",
				"角色.Common.技能通用标识.探索技能高亮黄色"
			};
		}

		// Token: 0x0600D174 RID: 53620 RVA: 0x001E57CE File Offset: 0x001E39CE
		public static EHighlightType[] GetValues()
		{
			return new EHighlightType[]
			{
				EHighlightType.CommonWhite,
				EHighlightType.CommonYellow
			};
		}

		// Token: 0x0600D175 RID: 53621 RVA: 0x001E57DA File Offset: 0x001E39DA
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

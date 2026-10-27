using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002355 RID: 9045
	public static class EHighlightExploreSkillIconTypeExtensions
	{
		// Token: 0x0600C57D RID: 50557 RVA: 0x001CD2E4 File Offset: 0x001CB4E4
		public static string ToEnumString(this EHighlightExploreSkillIconType value)
		{
			string result;
			switch (value)
			{
			case EHighlightExploreSkillIconType.Show:
				result = "Show";
				break;
			case EHighlightExploreSkillIconType.Hide:
				result = "Hide";
				break;
			case EHighlightExploreSkillIconType.ToggleAndHighlightItem:
				result = "ToggleAndHighlightItem";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C57E RID: 50558 RVA: 0x001CD32C File Offset: 0x001CB52C
		public static EHighlightExploreSkillIconType FromString(string name)
		{
			EHighlightExploreSkillIconType result;
			if (!EHighlightExploreSkillIconTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHighlightExploreSkillIconType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C57F RID: 50559 RVA: 0x001CD358 File Offset: 0x001CB558
		public static bool TryFromString(string name, out EHighlightExploreSkillIconType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHighlightExploreSkillIconType.Show;
				return false;
			}
			if (name == "Show")
			{
				value = EHighlightExploreSkillIconType.Show;
				return true;
			}
			if (name == "Hide")
			{
				value = EHighlightExploreSkillIconType.Hide;
				return true;
			}
			if (!(name == "ToggleAndHighlightItem"))
			{
				value = EHighlightExploreSkillIconType.Show;
				return false;
			}
			value = EHighlightExploreSkillIconType.ToggleAndHighlightItem;
			return true;
		}

		// Token: 0x0600C580 RID: 50560 RVA: 0x001CD3AE File Offset: 0x001CB5AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Show",
				"Hide",
				"ToggleAndHighlightItem"
			};
		}

		// Token: 0x0600C581 RID: 50561 RVA: 0x001CD3CE File Offset: 0x001CB5CE
		public static EHighlightExploreSkillIconType[] GetValues()
		{
			return new EHighlightExploreSkillIconType[]
			{
				EHighlightExploreSkillIconType.Show,
				EHighlightExploreSkillIconType.Hide,
				EHighlightExploreSkillIconType.ToggleAndHighlightItem
			};
		}

		// Token: 0x0600C582 RID: 50562 RVA: 0x001CD3DE File Offset: 0x001CB5DE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Show",
				"Hide",
				"ToggleAndHighlightItem"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025CA RID: 9674
	public static class EHighlightExploreSkillIconTypeExtensions
	{
		// Token: 0x0600D167 RID: 53607 RVA: 0x001E55C4 File Offset: 0x001E37C4
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

		// Token: 0x0600D168 RID: 53608 RVA: 0x001E560C File Offset: 0x001E380C
		public static EHighlightExploreSkillIconType FromString(string name)
		{
			EHighlightExploreSkillIconType result;
			if (!EHighlightExploreSkillIconTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHighlightExploreSkillIconType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D169 RID: 53609 RVA: 0x001E5638 File Offset: 0x001E3838
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

		// Token: 0x0600D16A RID: 53610 RVA: 0x001E568E File Offset: 0x001E388E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Show",
				"Hide",
				"ToggleAndHighlightItem"
			};
		}

		// Token: 0x0600D16B RID: 53611 RVA: 0x001E56AE File Offset: 0x001E38AE
		public static EHighlightExploreSkillIconType[] GetValues()
		{
			return new EHighlightExploreSkillIconType[]
			{
				EHighlightExploreSkillIconType.Show,
				EHighlightExploreSkillIconType.Hide,
				EHighlightExploreSkillIconType.ToggleAndHighlightItem
			};
		}

		// Token: 0x0600D16C RID: 53612 RVA: 0x001E56BE File Offset: 0x001E38BE
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

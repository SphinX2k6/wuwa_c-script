using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000940 RID: 2368
	public static class EExploreSkillSearchTargetCfgExtensions
	{
		// Token: 0x06003551 RID: 13649 RVA: 0x0008B544 File Offset: 0x00089744
		public static string ToEnumString(this EExploreSkillSearchTargetCfg value)
		{
			string result;
			if (value != EExploreSkillSearchTargetCfg.AngleWeight)
			{
				if (value != EExploreSkillSearchTargetCfg.EnterScreenWeight)
				{
					result = value.ToString();
				}
				else
				{
					result = "EnterScreenWeight";
				}
			}
			else
			{
				result = "AngleWeight";
			}
			return result;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x0008B57C File Offset: 0x0008977C
		public static EExploreSkillSearchTargetCfg FromString(string name)
		{
			EExploreSkillSearchTargetCfg result;
			if (!EExploreSkillSearchTargetCfgExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExploreSkillSearchTargetCfg 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x0008B5A5 File Offset: 0x000897A5
		public static bool TryFromString(string name, out EExploreSkillSearchTargetCfg value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EExploreSkillSearchTargetCfg.AngleWeight;
				return false;
			}
			if (name == "AngleWeight")
			{
				value = EExploreSkillSearchTargetCfg.AngleWeight;
				return true;
			}
			if (!(name == "EnterScreenWeight"))
			{
				value = EExploreSkillSearchTargetCfg.AngleWeight;
				return false;
			}
			value = EExploreSkillSearchTargetCfg.EnterScreenWeight;
			return true;
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x0008B5DE File Offset: 0x000897DE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AngleWeight",
				"EnterScreenWeight"
			};
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x0008B5F6 File Offset: 0x000897F6
		public static EExploreSkillSearchTargetCfg[] GetValues()
		{
			return new EExploreSkillSearchTargetCfg[]
			{
				EExploreSkillSearchTargetCfg.AngleWeight,
				EExploreSkillSearchTargetCfg.EnterScreenWeight
			};
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x0008B602 File Offset: 0x00089802
		public static string[] GetNames()
		{
			return new string[]
			{
				"AngleWeight",
				"EnterScreenWeight"
			};
		}
	}
}

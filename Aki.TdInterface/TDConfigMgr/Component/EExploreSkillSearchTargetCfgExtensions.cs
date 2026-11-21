using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009ED RID: 2541
	public static class EExploreSkillSearchTargetCfgExtensions
	{
		// Token: 0x060038BD RID: 14525 RVA: 0x00093120 File Offset: 0x00091320
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

		// Token: 0x060038BE RID: 14526 RVA: 0x00093158 File Offset: 0x00091358
		public static EExploreSkillSearchTargetCfg FromString(string name)
		{
			EExploreSkillSearchTargetCfg result;
			if (!EExploreSkillSearchTargetCfgExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExploreSkillSearchTargetCfg 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x00093181 File Offset: 0x00091381
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

		// Token: 0x060038C0 RID: 14528 RVA: 0x000931BA File Offset: 0x000913BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AngleWeight",
				"EnterScreenWeight"
			};
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x000931D2 File Offset: 0x000913D2
		public static EExploreSkillSearchTargetCfg[] GetValues()
		{
			return new EExploreSkillSearchTargetCfg[]
			{
				EExploreSkillSearchTargetCfg.AngleWeight,
				EExploreSkillSearchTargetCfg.EnterScreenWeight
			};
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x000931DE File Offset: 0x000913DE
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

using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C4 RID: 9668
	public static class EGuideTriggerTypeExtensions
	{
		// Token: 0x0600D14C RID: 53580 RVA: 0x001E51E4 File Offset: 0x001E33E4
		public static string ToEnumString(this EGuideTriggerType value)
		{
			string result;
			if (value != EGuideTriggerType.BeginnerGuide)
			{
				if (value != EGuideTriggerType.AttackGuide)
				{
					result = value.ToString();
				}
				else
				{
					result = "AttackGuide";
				}
			}
			else
			{
				result = "BeginnerGuide";
			}
			return result;
		}

		// Token: 0x0600D14D RID: 53581 RVA: 0x001E521C File Offset: 0x001E341C
		public static EGuideTriggerType FromString(string name)
		{
			EGuideTriggerType result;
			if (!EGuideTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGuideTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D14E RID: 53582 RVA: 0x001E5245 File Offset: 0x001E3445
		public static bool TryFromString(string name, out EGuideTriggerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGuideTriggerType.BeginnerGuide;
				return false;
			}
			if (name == "BeginnerGuide")
			{
				value = EGuideTriggerType.BeginnerGuide;
				return true;
			}
			if (!(name == "AttackGuide"))
			{
				value = EGuideTriggerType.BeginnerGuide;
				return false;
			}
			value = EGuideTriggerType.AttackGuide;
			return true;
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x001E527E File Offset: 0x001E347E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BeginnerGuide",
				"AttackGuide"
			};
		}

		// Token: 0x0600D150 RID: 53584 RVA: 0x001E5296 File Offset: 0x001E3496
		public static EGuideTriggerType[] GetValues()
		{
			return new EGuideTriggerType[]
			{
				EGuideTriggerType.BeginnerGuide,
				EGuideTriggerType.AttackGuide
			};
		}

		// Token: 0x0600D151 RID: 53585 RVA: 0x001E52A2 File Offset: 0x001E34A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"BeginnerGuide",
				"AttackGuide"
			};
		}
	}
}

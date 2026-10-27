using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002305 RID: 8965
	public static class EDisplayModeInSkillOpExtensions
	{
		// Token: 0x0600C415 RID: 50197 RVA: 0x001CA0F8 File Offset: 0x001C82F8
		public static string ToEnumString(this EDisplayModeInSkillOp value)
		{
			string result;
			switch (value)
			{
			case EDisplayModeInSkillOp.Ashen:
				result = "Ashen";
				break;
			case EDisplayModeInSkillOp.Hide:
				result = "Hide";
				break;
			case EDisplayModeInSkillOp.Disable:
				result = "Disable";
				break;
			case EDisplayModeInSkillOp.Show:
				result = "Show";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C416 RID: 50198 RVA: 0x001CA14C File Offset: 0x001C834C
		public static EDisplayModeInSkillOp FromString(string name)
		{
			EDisplayModeInSkillOp result;
			if (!EDisplayModeInSkillOpExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDisplayModeInSkillOp 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C417 RID: 50199 RVA: 0x001CA178 File Offset: 0x001C8378
		public static bool TryFromString(string name, out EDisplayModeInSkillOp value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDisplayModeInSkillOp.Ashen;
				return false;
			}
			if (name == "Ashen")
			{
				value = EDisplayModeInSkillOp.Ashen;
				return true;
			}
			if (name == "Hide")
			{
				value = EDisplayModeInSkillOp.Hide;
				return true;
			}
			if (name == "Disable")
			{
				value = EDisplayModeInSkillOp.Disable;
				return true;
			}
			if (!(name == "Show"))
			{
				value = EDisplayModeInSkillOp.Ashen;
				return false;
			}
			value = EDisplayModeInSkillOp.Show;
			return true;
		}

		// Token: 0x0600C418 RID: 50200 RVA: 0x001CA1E0 File Offset: 0x001C83E0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Ashen",
				"Hide",
				"Disable",
				"Show"
			};
		}

		// Token: 0x0600C419 RID: 50201 RVA: 0x001CA208 File Offset: 0x001C8408
		public static EDisplayModeInSkillOp[] GetValues()
		{
			return new EDisplayModeInSkillOp[]
			{
				EDisplayModeInSkillOp.Ashen,
				EDisplayModeInSkillOp.Hide,
				EDisplayModeInSkillOp.Disable,
				EDisplayModeInSkillOp.Show
			};
		}

		// Token: 0x0600C41A RID: 50202 RVA: 0x001CA21B File Offset: 0x001C841B
		public static string[] GetNames()
		{
			return new string[]
			{
				"Ashen",
				"Hide",
				"Disable",
				"Show"
			};
		}
	}
}

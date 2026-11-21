using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002574 RID: 9588
	public static class EDisplayModeInSkillOpExtensions
	{
		// Token: 0x0600CFE4 RID: 53220 RVA: 0x001E1FC0 File Offset: 0x001E01C0
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

		// Token: 0x0600CFE5 RID: 53221 RVA: 0x001E2014 File Offset: 0x001E0214
		public static EDisplayModeInSkillOp FromString(string name)
		{
			EDisplayModeInSkillOp result;
			if (!EDisplayModeInSkillOpExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDisplayModeInSkillOp 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFE6 RID: 53222 RVA: 0x001E2040 File Offset: 0x001E0240
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

		// Token: 0x0600CFE7 RID: 53223 RVA: 0x001E20A8 File Offset: 0x001E02A8
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

		// Token: 0x0600CFE8 RID: 53224 RVA: 0x001E20D0 File Offset: 0x001E02D0
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

		// Token: 0x0600CFE9 RID: 53225 RVA: 0x001E20E3 File Offset: 0x001E02E3
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

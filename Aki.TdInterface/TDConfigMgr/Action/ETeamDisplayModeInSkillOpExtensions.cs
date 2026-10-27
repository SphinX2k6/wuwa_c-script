using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002463 RID: 9315
	public static class ETeamDisplayModeInSkillOpExtensions
	{
		// Token: 0x0600CA3C RID: 51772 RVA: 0x001DC2A4 File Offset: 0x001DA4A4
		public static string ToEnumString(this ETeamDisplayModeInSkillOp value)
		{
			string result;
			if (value != ETeamDisplayModeInSkillOp.Normal)
			{
				if (value != ETeamDisplayModeInSkillOp.Lock)
				{
					result = value.ToString();
				}
				else
				{
					result = "Lock";
				}
			}
			else
			{
				result = "Normal";
			}
			return result;
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x001DC2DC File Offset: 0x001DA4DC
		public static ETeamDisplayModeInSkillOp FromString(string name)
		{
			ETeamDisplayModeInSkillOp result;
			if (!ETeamDisplayModeInSkillOpExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeamDisplayModeInSkillOp 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA3E RID: 51774 RVA: 0x001DC305 File Offset: 0x001DA505
		public static bool TryFromString(string name, out ETeamDisplayModeInSkillOp value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETeamDisplayModeInSkillOp.Normal;
				return false;
			}
			if (name == "Normal")
			{
				value = ETeamDisplayModeInSkillOp.Normal;
				return true;
			}
			if (!(name == "Lock"))
			{
				value = ETeamDisplayModeInSkillOp.Normal;
				return false;
			}
			value = ETeamDisplayModeInSkillOp.Lock;
			return true;
		}

		// Token: 0x0600CA3F RID: 51775 RVA: 0x001DC33E File Offset: 0x001DA53E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"Lock"
			};
		}

		// Token: 0x0600CA40 RID: 51776 RVA: 0x001DC356 File Offset: 0x001DA556
		public static ETeamDisplayModeInSkillOp[] GetValues()
		{
			return new ETeamDisplayModeInSkillOp[]
			{
				ETeamDisplayModeInSkillOp.Normal,
				ETeamDisplayModeInSkillOp.Lock
			};
		}

		// Token: 0x0600CA41 RID: 51777 RVA: 0x001DC362 File Offset: 0x001DA562
		public static string[] GetNames()
		{
			return new string[]
			{
				"Normal",
				"Lock"
			};
		}
	}
}

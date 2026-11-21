using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002704 RID: 9988
	public static class ETeamDisplayModeInSkillOpExtensions
	{
		// Token: 0x0600D6EC RID: 55020 RVA: 0x001F6358 File Offset: 0x001F4558
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

		// Token: 0x0600D6ED RID: 55021 RVA: 0x001F6390 File Offset: 0x001F4590
		public static ETeamDisplayModeInSkillOp FromString(string name)
		{
			ETeamDisplayModeInSkillOp result;
			if (!ETeamDisplayModeInSkillOpExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeamDisplayModeInSkillOp 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6EE RID: 55022 RVA: 0x001F63B9 File Offset: 0x001F45B9
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

		// Token: 0x0600D6EF RID: 55023 RVA: 0x001F63F2 File Offset: 0x001F45F2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"Lock"
			};
		}

		// Token: 0x0600D6F0 RID: 55024 RVA: 0x001F640A File Offset: 0x001F460A
		public static ETeamDisplayModeInSkillOp[] GetValues()
		{
			return new ETeamDisplayModeInSkillOp[]
			{
				ETeamDisplayModeInSkillOp.Normal,
				ETeamDisplayModeInSkillOp.Lock
			};
		}

		// Token: 0x0600D6F1 RID: 55025 RVA: 0x001F6416 File Offset: 0x001F4616
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

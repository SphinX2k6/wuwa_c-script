using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E7 RID: 8935
	public static class EClientSetSeasonStateTypeExtensions
	{
		// Token: 0x0600C38E RID: 50062 RVA: 0x001C9188 File Offset: 0x001C7388
		public static string ToEnumString(this EClientSetSeasonStateType value)
		{
			string result;
			if (value != EClientSetSeasonStateType.SwitchSeason)
			{
				if (value != EClientSetSeasonStateType.LoopSeasonChange)
				{
					result = value.ToString();
				}
				else
				{
					result = "LoopSeasonChange";
				}
			}
			else
			{
				result = "SwitchSeason";
			}
			return result;
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x001C91C0 File Offset: 0x001C73C0
		public static EClientSetSeasonStateType FromString(string name)
		{
			EClientSetSeasonStateType result;
			if (!EClientSetSeasonStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientSetSeasonStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C390 RID: 50064 RVA: 0x001C91E9 File Offset: 0x001C73E9
		public static bool TryFromString(string name, out EClientSetSeasonStateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientSetSeasonStateType.SwitchSeason;
				return false;
			}
			if (name == "SwitchSeason")
			{
				value = EClientSetSeasonStateType.SwitchSeason;
				return true;
			}
			if (!(name == "LoopSeasonChange"))
			{
				value = EClientSetSeasonStateType.SwitchSeason;
				return false;
			}
			value = EClientSetSeasonStateType.LoopSeasonChange;
			return true;
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x001C9222 File Offset: 0x001C7422
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SwitchSeason",
				"LoopSeasonChange"
			};
		}

		// Token: 0x0600C392 RID: 50066 RVA: 0x001C923A File Offset: 0x001C743A
		public static EClientSetSeasonStateType[] GetValues()
		{
			return new EClientSetSeasonStateType[]
			{
				EClientSetSeasonStateType.SwitchSeason,
				EClientSetSeasonStateType.LoopSeasonChange
			};
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x001C9246 File Offset: 0x001C7446
		public static string[] GetNames()
		{
			return new string[]
			{
				"SwitchSeason",
				"LoopSeasonChange"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002534 RID: 9524
	public static class EBvbPlayDialogTypeExtensions
	{
		// Token: 0x0600CEC4 RID: 52932 RVA: 0x001DF9B0 File Offset: 0x001DDBB0
		public static string ToEnumString(this EBvbPlayDialogType value)
		{
			string result;
			switch (value)
			{
			case EBvbPlayDialogType.DungeonBegin:
				result = "DungeonBegin";
				break;
			case EBvbPlayDialogType.PlayerBattleWin:
				result = "PlayerBattleWin";
				break;
			case EBvbPlayDialogType.PlayerWin:
				result = "PlayerWin";
				break;
			case EBvbPlayDialogType.PlayerLose:
				result = "PlayerLose";
				break;
			case EBvbPlayDialogType.NewTurnBegin:
				result = "NewTurnBegin";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CEC5 RID: 52933 RVA: 0x001DFA10 File Offset: 0x001DDC10
		public static EBvbPlayDialogType FromString(string name)
		{
			EBvbPlayDialogType result;
			if (!EBvbPlayDialogTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBvbPlayDialogType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CEC6 RID: 52934 RVA: 0x001DFA3C File Offset: 0x001DDC3C
		public static bool TryFromString(string name, out EBvbPlayDialogType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBvbPlayDialogType.DungeonBegin;
				return false;
			}
			if (name == "DungeonBegin")
			{
				value = EBvbPlayDialogType.DungeonBegin;
				return true;
			}
			if (name == "PlayerBattleWin")
			{
				value = EBvbPlayDialogType.PlayerBattleWin;
				return true;
			}
			if (name == "PlayerWin")
			{
				value = EBvbPlayDialogType.PlayerWin;
				return true;
			}
			if (name == "PlayerLose")
			{
				value = EBvbPlayDialogType.PlayerLose;
				return true;
			}
			if (!(name == "NewTurnBegin"))
			{
				value = EBvbPlayDialogType.DungeonBegin;
				return false;
			}
			value = EBvbPlayDialogType.NewTurnBegin;
			return true;
		}

		// Token: 0x0600CEC7 RID: 52935 RVA: 0x001DFAB6 File Offset: 0x001DDCB6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DungeonBegin",
				"PlayerBattleWin",
				"PlayerWin",
				"PlayerLose",
				"NewTurnBegin"
			};
		}

		// Token: 0x0600CEC8 RID: 52936 RVA: 0x001DFAE6 File Offset: 0x001DDCE6
		public static EBvbPlayDialogType[] GetValues()
		{
			return new EBvbPlayDialogType[]
			{
				EBvbPlayDialogType.DungeonBegin,
				EBvbPlayDialogType.PlayerBattleWin,
				EBvbPlayDialogType.PlayerWin,
				EBvbPlayDialogType.PlayerLose,
				EBvbPlayDialogType.NewTurnBegin
			};
		}

		// Token: 0x0600CEC9 RID: 52937 RVA: 0x001DFAF9 File Offset: 0x001DDCF9
		public static string[] GetNames()
		{
			return new string[]
			{
				"DungeonBegin",
				"PlayerBattleWin",
				"PlayerWin",
				"PlayerLose",
				"NewTurnBegin"
			};
		}
	}
}

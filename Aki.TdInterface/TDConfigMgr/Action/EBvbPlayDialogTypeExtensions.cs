using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C5 RID: 8901
	public static class EBvbPlayDialogTypeExtensions
	{
		// Token: 0x0600C2F5 RID: 49909 RVA: 0x001C7BA8 File Offset: 0x001C5DA8
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

		// Token: 0x0600C2F6 RID: 49910 RVA: 0x001C7C08 File Offset: 0x001C5E08
		public static EBvbPlayDialogType FromString(string name)
		{
			EBvbPlayDialogType result;
			if (!EBvbPlayDialogTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBvbPlayDialogType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2F7 RID: 49911 RVA: 0x001C7C34 File Offset: 0x001C5E34
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

		// Token: 0x0600C2F8 RID: 49912 RVA: 0x001C7CAE File Offset: 0x001C5EAE
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

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x001C7CDE File Offset: 0x001C5EDE
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

		// Token: 0x0600C2FA RID: 49914 RVA: 0x001C7CF1 File Offset: 0x001C5EF1
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

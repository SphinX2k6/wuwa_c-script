using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024F6 RID: 9462
	public static class EActionTypeExtensions
	{
		// Token: 0x0600CDAD RID: 52653 RVA: 0x001DCC64 File Offset: 0x001DAE64
		public static string ToEnumString(this EActionType value)
		{
			string result;
			switch (value)
			{
			case EActionType.Entity:
				result = "Entity";
				break;
			case EActionType.Flow:
				result = "Flow";
				break;
			case EActionType.Quest:
				result = "Quest";
				break;
			case EActionType.LevelPlay:
				result = "LevelPlay";
				break;
			case EActionType.Gm:
				result = "Gm";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CDAE RID: 52654 RVA: 0x001DCCC4 File Offset: 0x001DAEC4
		public static EActionType FromString(string name)
		{
			EActionType result;
			if (!EActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CDAF RID: 52655 RVA: 0x001DCCF0 File Offset: 0x001DAEF0
		public static bool TryFromString(string name, out EActionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActionType.Entity;
				return false;
			}
			if (name == "Entity")
			{
				value = EActionType.Entity;
				return true;
			}
			if (name == "Flow")
			{
				value = EActionType.Flow;
				return true;
			}
			if (name == "Quest")
			{
				value = EActionType.Quest;
				return true;
			}
			if (name == "LevelPlay")
			{
				value = EActionType.LevelPlay;
				return true;
			}
			if (!(name == "Gm"))
			{
				value = EActionType.Entity;
				return false;
			}
			value = EActionType.Gm;
			return true;
		}

		// Token: 0x0600CDB0 RID: 52656 RVA: 0x001DCD6A File Offset: 0x001DAF6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Entity",
				"Flow",
				"Quest",
				"LevelPlay",
				"Gm"
			};
		}

		// Token: 0x0600CDB1 RID: 52657 RVA: 0x001DCD9A File Offset: 0x001DAF9A
		public static EActionType[] GetValues()
		{
			return new EActionType[]
			{
				EActionType.Entity,
				EActionType.Flow,
				EActionType.Quest,
				EActionType.LevelPlay,
				EActionType.Gm
			};
		}

		// Token: 0x0600CDB2 RID: 52658 RVA: 0x001DCDAD File Offset: 0x001DAFAD
		public static string[] GetNames()
		{
			return new string[]
			{
				"Entity",
				"Flow",
				"Quest",
				"LevelPlay",
				"Gm"
			};
		}
	}
}

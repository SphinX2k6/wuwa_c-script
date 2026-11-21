using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002650 RID: 9808
	public static class EPerformerAiMoveToTypeExtensions
	{
		// Token: 0x0600D3C2 RID: 54210 RVA: 0x001EC3D0 File Offset: 0x001EA5D0
		public static string ToEnumString(this EPerformerAiMoveToType value)
		{
			string result;
			switch (value)
			{
			case EPerformerAiMoveToType.Position:
				result = "Position";
				break;
			case EPerformerAiMoveToType.Entity:
				result = "Entity";
				break;
			case EPerformerAiMoveToType.Player:
				result = "Player";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D3C3 RID: 54211 RVA: 0x001EC418 File Offset: 0x001EA618
		public static EPerformerAiMoveToType FromString(string name)
		{
			EPerformerAiMoveToType result;
			if (!EPerformerAiMoveToTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPerformerAiMoveToType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x001EC444 File Offset: 0x001EA644
		public static bool TryFromString(string name, out EPerformerAiMoveToType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPerformerAiMoveToType.Position;
				return false;
			}
			if (name == "Position")
			{
				value = EPerformerAiMoveToType.Position;
				return true;
			}
			if (name == "Entity")
			{
				value = EPerformerAiMoveToType.Entity;
				return true;
			}
			if (!(name == "Player"))
			{
				value = EPerformerAiMoveToType.Position;
				return false;
			}
			value = EPerformerAiMoveToType.Player;
			return true;
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x001EC49A File Offset: 0x001EA69A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Position",
				"Entity",
				"Player"
			};
		}

		// Token: 0x0600D3C6 RID: 54214 RVA: 0x001EC4BA File Offset: 0x001EA6BA
		public static EPerformerAiMoveToType[] GetValues()
		{
			return new EPerformerAiMoveToType[]
			{
				EPerformerAiMoveToType.Position,
				EPerformerAiMoveToType.Entity,
				EPerformerAiMoveToType.Player
			};
		}

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x001EC4CA File Offset: 0x001EA6CA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Position",
				"Entity",
				"Player"
			};
		}
	}
}

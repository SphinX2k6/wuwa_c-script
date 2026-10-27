using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023BD RID: 9149
	public static class EPerformerAiMoveToTypeExtensions
	{
		// Token: 0x0600C751 RID: 51025 RVA: 0x001D2E14 File Offset: 0x001D1014
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

		// Token: 0x0600C752 RID: 51026 RVA: 0x001D2E5C File Offset: 0x001D105C
		public static EPerformerAiMoveToType FromString(string name)
		{
			EPerformerAiMoveToType result;
			if (!EPerformerAiMoveToTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPerformerAiMoveToType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C753 RID: 51027 RVA: 0x001D2E88 File Offset: 0x001D1088
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

		// Token: 0x0600C754 RID: 51028 RVA: 0x001D2EDE File Offset: 0x001D10DE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Position",
				"Entity",
				"Player"
			};
		}

		// Token: 0x0600C755 RID: 51029 RVA: 0x001D2EFE File Offset: 0x001D10FE
		public static EPerformerAiMoveToType[] GetValues()
		{
			return new EPerformerAiMoveToType[]
			{
				EPerformerAiMoveToType.Position,
				EPerformerAiMoveToType.Entity,
				EPerformerAiMoveToType.Player
			};
		}

		// Token: 0x0600C756 RID: 51030 RVA: 0x001D2F0E File Offset: 0x001D110E
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

using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002636 RID: 9782
	public static class ENewSplineMoveTargetTypeExtensions
	{
		// Token: 0x0600D34D RID: 54093 RVA: 0x001EB4D0 File Offset: 0x001E96D0
		public static string ToEnumString(this ENewSplineMoveTargetType value)
		{
			string result;
			switch (value)
			{
			case ENewSplineMoveTargetType.Player:
				result = "Player";
				break;
			case ENewSplineMoveTargetType.Npc:
				result = "Npc";
				break;
			case ENewSplineMoveTargetType.SceneItem:
				result = "SceneItem";
				break;
			case ENewSplineMoveTargetType.Vehicle:
				result = "Vehicle";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D34E RID: 54094 RVA: 0x001EB524 File Offset: 0x001E9724
		public static ENewSplineMoveTargetType FromString(string name)
		{
			ENewSplineMoveTargetType result;
			if (!ENewSplineMoveTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENewSplineMoveTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D34F RID: 54095 RVA: 0x001EB550 File Offset: 0x001E9750
		public static bool TryFromString(string name, out ENewSplineMoveTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENewSplineMoveTargetType.Player;
				return false;
			}
			if (name == "Player")
			{
				value = ENewSplineMoveTargetType.Player;
				return true;
			}
			if (name == "Npc")
			{
				value = ENewSplineMoveTargetType.Npc;
				return true;
			}
			if (name == "SceneItem")
			{
				value = ENewSplineMoveTargetType.SceneItem;
				return true;
			}
			if (!(name == "Vehicle"))
			{
				value = ENewSplineMoveTargetType.Player;
				return false;
			}
			value = ENewSplineMoveTargetType.Vehicle;
			return true;
		}

		// Token: 0x0600D350 RID: 54096 RVA: 0x001EB5B8 File Offset: 0x001E97B8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"Npc",
				"SceneItem",
				"Vehicle"
			};
		}

		// Token: 0x0600D351 RID: 54097 RVA: 0x001EB5E0 File Offset: 0x001E97E0
		public static ENewSplineMoveTargetType[] GetValues()
		{
			return new ENewSplineMoveTargetType[]
			{
				ENewSplineMoveTargetType.Player,
				ENewSplineMoveTargetType.Npc,
				ENewSplineMoveTargetType.SceneItem,
				ENewSplineMoveTargetType.Vehicle
			};
		}

		// Token: 0x0600D352 RID: 54098 RVA: 0x001EB5F3 File Offset: 0x001E97F3
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player",
				"Npc",
				"SceneItem",
				"Vehicle"
			};
		}
	}
}

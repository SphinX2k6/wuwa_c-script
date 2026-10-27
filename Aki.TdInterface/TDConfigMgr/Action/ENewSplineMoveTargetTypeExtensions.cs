using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023AB RID: 9131
	public static class ENewSplineMoveTargetTypeExtensions
	{
		// Token: 0x0600C700 RID: 50944 RVA: 0x001D2330 File Offset: 0x001D0530
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

		// Token: 0x0600C701 RID: 50945 RVA: 0x001D2384 File Offset: 0x001D0584
		public static ENewSplineMoveTargetType FromString(string name)
		{
			ENewSplineMoveTargetType result;
			if (!ENewSplineMoveTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENewSplineMoveTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C702 RID: 50946 RVA: 0x001D23B0 File Offset: 0x001D05B0
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

		// Token: 0x0600C703 RID: 50947 RVA: 0x001D2418 File Offset: 0x001D0618
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

		// Token: 0x0600C704 RID: 50948 RVA: 0x001D2440 File Offset: 0x001D0640
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

		// Token: 0x0600C705 RID: 50949 RVA: 0x001D2453 File Offset: 0x001D0653
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

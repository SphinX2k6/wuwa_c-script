using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F8 RID: 2296
	public static class EAttachTypeExtensions
	{
		// Token: 0x0600340D RID: 13325 RVA: 0x0008505C File Offset: 0x0008325C
		public static string ToEnumString(this EAttachType value)
		{
			string result;
			switch (value)
			{
			case EAttachType.Actor:
				result = "Actor";
				break;
			case EAttachType.Entity:
				result = "Entity";
				break;
			case EAttachType.Dynamic:
				result = "Dynamic";
				break;
			case EAttachType.RelativePoint:
				result = "RelativePoint";
				break;
			case EAttachType.Player:
				result = "Player";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x000850BC File Offset: 0x000832BC
		public static EAttachType FromString(string name)
		{
			EAttachType result;
			if (!EAttachTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttachType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x000850E8 File Offset: 0x000832E8
		public static bool TryFromString(string name, out EAttachType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAttachType.Actor;
				return false;
			}
			if (name == "Actor")
			{
				value = EAttachType.Actor;
				return true;
			}
			if (name == "Entity")
			{
				value = EAttachType.Entity;
				return true;
			}
			if (name == "Dynamic")
			{
				value = EAttachType.Dynamic;
				return true;
			}
			if (name == "RelativePoint")
			{
				value = EAttachType.RelativePoint;
				return true;
			}
			if (!(name == "Player"))
			{
				value = EAttachType.Actor;
				return false;
			}
			value = EAttachType.Player;
			return true;
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x00085162 File Offset: 0x00083362
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Actor",
				"Entity",
				"Dynamic",
				"RelativePoint",
				"Player"
			};
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x00085192 File Offset: 0x00083392
		public static EAttachType[] GetValues()
		{
			return new EAttachType[]
			{
				EAttachType.Actor,
				EAttachType.Entity,
				EAttachType.Dynamic,
				EAttachType.RelativePoint,
				EAttachType.Player
			};
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x000851A5 File Offset: 0x000833A5
		public static string[] GetNames()
		{
			return new string[]
			{
				"Actor",
				"Entity",
				"Dynamic",
				"RelativePoint",
				"Player"
			};
		}
	}
}

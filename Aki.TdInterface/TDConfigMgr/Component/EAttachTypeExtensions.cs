using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A1 RID: 2465
	public static class EAttachTypeExtensions
	{
		// Token: 0x06003767 RID: 14183 RVA: 0x0008C8CC File Offset: 0x0008AACC
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

		// Token: 0x06003768 RID: 14184 RVA: 0x0008C92C File Offset: 0x0008AB2C
		public static EAttachType FromString(string name)
		{
			EAttachType result;
			if (!EAttachTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttachType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x0008C958 File Offset: 0x0008AB58
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

		// Token: 0x0600376A RID: 14186 RVA: 0x0008C9D2 File Offset: 0x0008ABD2
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

		// Token: 0x0600376B RID: 14187 RVA: 0x0008CA02 File Offset: 0x0008AC02
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

		// Token: 0x0600376C RID: 14188 RVA: 0x0008CA15 File Offset: 0x0008AC15
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

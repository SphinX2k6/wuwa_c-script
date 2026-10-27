using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093A RID: 2362
	public static class EEntityMatchTypeExtensions
	{
		// Token: 0x06003536 RID: 13622 RVA: 0x0008AE20 File Offset: 0x00089020
		public static string ToEnumString(this EEntityMatchType value)
		{
			string result;
			switch (value)
			{
			case EEntityMatchType.Player:
				result = "Player";
				break;
			case EEntityMatchType.AllCharacter:
				result = "AllCharacter";
				break;
			case EEntityMatchType.DynamicEntityMatch:
				result = "DynamicEntityMatch";
				break;
			case EEntityMatchType.SpecificBp:
				result = "SpecificBp";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x0008AE74 File Offset: 0x00089074
		public static EEntityMatchType FromString(string name)
		{
			EEntityMatchType result;
			if (!EEntityMatchTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityMatchType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x0008AEA0 File Offset: 0x000890A0
		public static bool TryFromString(string name, out EEntityMatchType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEntityMatchType.Player;
				return false;
			}
			if (name == "Player")
			{
				value = EEntityMatchType.Player;
				return true;
			}
			if (name == "AllCharacter")
			{
				value = EEntityMatchType.AllCharacter;
				return true;
			}
			if (name == "DynamicEntityMatch")
			{
				value = EEntityMatchType.DynamicEntityMatch;
				return true;
			}
			if (!(name == "SpecificBp"))
			{
				value = EEntityMatchType.Player;
				return false;
			}
			value = EEntityMatchType.SpecificBp;
			return true;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x0008AF08 File Offset: 0x00089108
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"AllCharacter",
				"DynamicEntityMatch",
				"SpecificBp"
			};
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x0008AF30 File Offset: 0x00089130
		public static EEntityMatchType[] GetValues()
		{
			return new EEntityMatchType[]
			{
				EEntityMatchType.Player,
				EEntityMatchType.AllCharacter,
				EEntityMatchType.DynamicEntityMatch,
				EEntityMatchType.SpecificBp
			};
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x0008AF43 File Offset: 0x00089143
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player",
				"AllCharacter",
				"DynamicEntityMatch",
				"SpecificBp"
			};
		}
	}
}

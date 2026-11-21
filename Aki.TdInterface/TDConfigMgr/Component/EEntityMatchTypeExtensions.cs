using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E7 RID: 2535
	public static class EEntityMatchTypeExtensions
	{
		// Token: 0x060038A2 RID: 14498 RVA: 0x000929A0 File Offset: 0x00090BA0
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

		// Token: 0x060038A3 RID: 14499 RVA: 0x000929F4 File Offset: 0x00090BF4
		public static EEntityMatchType FromString(string name)
		{
			EEntityMatchType result;
			if (!EEntityMatchTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityMatchType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x00092A20 File Offset: 0x00090C20
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

		// Token: 0x060038A5 RID: 14501 RVA: 0x00092A88 File Offset: 0x00090C88
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

		// Token: 0x060038A6 RID: 14502 RVA: 0x00092AB0 File Offset: 0x00090CB0
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

		// Token: 0x060038A7 RID: 14503 RVA: 0x00092AC3 File Offset: 0x00090CC3
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

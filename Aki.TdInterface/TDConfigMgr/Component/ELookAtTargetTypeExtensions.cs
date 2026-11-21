using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A49 RID: 2633
	public static class ELookAtTargetTypeExtensions
	{
		// Token: 0x06003A5B RID: 14939 RVA: 0x00096AB0 File Offset: 0x00094CB0
		public static string ToEnumString(this ELookAtTargetType value)
		{
			string result;
			if (value != ELookAtTargetType.Entity)
			{
				if (value != ELookAtTargetType.Player)
				{
					result = value.ToString();
				}
				else
				{
					result = "Player";
				}
			}
			else
			{
				result = "Entity";
			}
			return result;
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x00096AE8 File Offset: 0x00094CE8
		public static ELookAtTargetType FromString(string name)
		{
			ELookAtTargetType result;
			if (!ELookAtTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELookAtTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x00096B11 File Offset: 0x00094D11
		public static bool TryFromString(string name, out ELookAtTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELookAtTargetType.Entity;
				return false;
			}
			if (name == "Entity")
			{
				value = ELookAtTargetType.Entity;
				return true;
			}
			if (!(name == "Player"))
			{
				value = ELookAtTargetType.Entity;
				return false;
			}
			value = ELookAtTargetType.Player;
			return true;
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x00096B4A File Offset: 0x00094D4A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Entity",
				"Player"
			};
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x00096B62 File Offset: 0x00094D62
		public static ELookAtTargetType[] GetValues()
		{
			return new ELookAtTargetType[]
			{
				ELookAtTargetType.Entity,
				ELookAtTargetType.Player
			};
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00096B6E File Offset: 0x00094D6E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Entity",
				"Player"
			};
		}
	}
}

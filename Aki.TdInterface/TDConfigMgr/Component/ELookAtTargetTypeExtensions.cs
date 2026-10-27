using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000996 RID: 2454
	public static class ELookAtTargetTypeExtensions
	{
		// Token: 0x060036D4 RID: 14036 RVA: 0x0008EB44 File Offset: 0x0008CD44
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

		// Token: 0x060036D5 RID: 14037 RVA: 0x0008EB7C File Offset: 0x0008CD7C
		public static ELookAtTargetType FromString(string name)
		{
			ELookAtTargetType result;
			if (!ELookAtTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELookAtTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x0008EBA5 File Offset: 0x0008CDA5
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

		// Token: 0x060036D7 RID: 14039 RVA: 0x0008EBDE File Offset: 0x0008CDDE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Entity",
				"Player"
			};
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x0008EBF6 File Offset: 0x0008CDF6
		public static ELookAtTargetType[] GetValues()
		{
			return new ELookAtTargetType[]
			{
				ELookAtTargetType.Entity,
				ELookAtTargetType.Player
			};
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x0008EC02 File Offset: 0x0008CE02
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

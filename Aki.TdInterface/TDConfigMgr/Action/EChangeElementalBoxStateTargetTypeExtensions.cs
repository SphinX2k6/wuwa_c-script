using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002540 RID: 9536
	public static class EChangeElementalBoxStateTargetTypeExtensions
	{
		// Token: 0x0600CEFA RID: 52986 RVA: 0x001E0364 File Offset: 0x001DE564
		public static string ToEnumString(this EChangeElementalBoxStateTargetType value)
		{
			string result;
			if (value != EChangeElementalBoxStateTargetType.Player)
			{
				if (value != EChangeElementalBoxStateTargetType.TargetBoxId)
				{
					result = value.ToString();
				}
				else
				{
					result = "TargetBoxId";
				}
			}
			else
			{
				result = "Player";
			}
			return result;
		}

		// Token: 0x0600CEFB RID: 52987 RVA: 0x001E039C File Offset: 0x001DE59C
		public static EChangeElementalBoxStateTargetType FromString(string name)
		{
			EChangeElementalBoxStateTargetType result;
			if (!EChangeElementalBoxStateTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EChangeElementalBoxStateTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CEFC RID: 52988 RVA: 0x001E03C5 File Offset: 0x001DE5C5
		public static bool TryFromString(string name, out EChangeElementalBoxStateTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EChangeElementalBoxStateTargetType.Player;
				return false;
			}
			if (name == "Player")
			{
				value = EChangeElementalBoxStateTargetType.Player;
				return true;
			}
			if (!(name == "TargetBoxId"))
			{
				value = EChangeElementalBoxStateTargetType.Player;
				return false;
			}
			value = EChangeElementalBoxStateTargetType.TargetBoxId;
			return true;
		}

		// Token: 0x0600CEFD RID: 52989 RVA: 0x001E03FE File Offset: 0x001DE5FE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"TargetBoxId"
			};
		}

		// Token: 0x0600CEFE RID: 52990 RVA: 0x001E0416 File Offset: 0x001DE616
		public static EChangeElementalBoxStateTargetType[] GetValues()
		{
			return new EChangeElementalBoxStateTargetType[]
			{
				EChangeElementalBoxStateTargetType.Player,
				EChangeElementalBoxStateTargetType.TargetBoxId
			};
		}

		// Token: 0x0600CEFF RID: 52991 RVA: 0x001E0422 File Offset: 0x001DE622
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player",
				"TargetBoxId"
			};
		}
	}
}

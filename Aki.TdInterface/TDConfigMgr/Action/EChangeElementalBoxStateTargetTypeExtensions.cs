using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D1 RID: 8913
	public static class EChangeElementalBoxStateTargetTypeExtensions
	{
		// Token: 0x0600C32B RID: 49963 RVA: 0x001C855C File Offset: 0x001C675C
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

		// Token: 0x0600C32C RID: 49964 RVA: 0x001C8594 File Offset: 0x001C6794
		public static EChangeElementalBoxStateTargetType FromString(string name)
		{
			EChangeElementalBoxStateTargetType result;
			if (!EChangeElementalBoxStateTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EChangeElementalBoxStateTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C32D RID: 49965 RVA: 0x001C85BD File Offset: 0x001C67BD
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

		// Token: 0x0600C32E RID: 49966 RVA: 0x001C85F6 File Offset: 0x001C67F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"TargetBoxId"
			};
		}

		// Token: 0x0600C32F RID: 49967 RVA: 0x001C860E File Offset: 0x001C680E
		public static EChangeElementalBoxStateTargetType[] GetValues()
		{
			return new EChangeElementalBoxStateTargetType[]
			{
				EChangeElementalBoxStateTargetType.Player,
				EChangeElementalBoxStateTargetType.TargetBoxId
			};
		}

		// Token: 0x0600C330 RID: 49968 RVA: 0x001C861A File Offset: 0x001C681A
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

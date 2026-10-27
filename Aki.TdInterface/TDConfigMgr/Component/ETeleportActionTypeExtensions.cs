using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A34 RID: 2612
	public static class ETeleportActionTypeExtensions
	{
		// Token: 0x0600399B RID: 14747 RVA: 0x00094B48 File Offset: 0x00092D48
		public static string ToEnumString(this ETeleportActionType value)
		{
			string result;
			if (value != ETeleportActionType.Dodge)
			{
				if (value != ETeleportActionType.SlideRailStart)
				{
					result = value.ToString();
				}
				else
				{
					result = "SlideRailStart";
				}
			}
			else
			{
				result = "Dodge";
			}
			return result;
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x00094B80 File Offset: 0x00092D80
		public static ETeleportActionType FromString(string name)
		{
			ETeleportActionType result;
			if (!ETeleportActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleportActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00094BA9 File Offset: 0x00092DA9
		public static bool TryFromString(string name, out ETeleportActionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETeleportActionType.Dodge;
				return false;
			}
			if (name == "Dodge")
			{
				value = ETeleportActionType.Dodge;
				return true;
			}
			if (!(name == "SlideRailStart"))
			{
				value = ETeleportActionType.Dodge;
				return false;
			}
			value = ETeleportActionType.SlideRailStart;
			return true;
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x00094BE2 File Offset: 0x00092DE2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Dodge",
				"SlideRailStart"
			};
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00094BFA File Offset: 0x00092DFA
		public static ETeleportActionType[] GetValues()
		{
			return new ETeleportActionType[]
			{
				ETeleportActionType.Dodge,
				ETeleportActionType.SlideRailStart
			};
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00094C06 File Offset: 0x00092E06
		public static string[] GetNames()
		{
			return new string[]
			{
				"Dodge",
				"SlideRailStart"
			};
		}
	}
}

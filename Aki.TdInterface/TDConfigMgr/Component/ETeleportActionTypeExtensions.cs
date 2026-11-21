using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF9 RID: 2809
	public static class ETeleportActionTypeExtensions
	{
		// Token: 0x06003D73 RID: 15731 RVA: 0x0009D47C File Offset: 0x0009B67C
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

		// Token: 0x06003D74 RID: 15732 RVA: 0x0009D4B4 File Offset: 0x0009B6B4
		public static ETeleportActionType FromString(string name)
		{
			ETeleportActionType result;
			if (!ETeleportActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleportActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x0009D4DD File Offset: 0x0009B6DD
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

		// Token: 0x06003D76 RID: 15734 RVA: 0x0009D516 File Offset: 0x0009B716
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Dodge",
				"SlideRailStart"
			};
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x0009D52E File Offset: 0x0009B72E
		public static ETeleportActionType[] GetValues()
		{
			return new ETeleportActionType[]
			{
				ETeleportActionType.Dodge,
				ETeleportActionType.SlideRailStart
			};
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x0009D53A File Offset: 0x0009B73A
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

using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A32 RID: 2610
	public static class ETeleCtrlTriggerTypeExtensions
	{
		// Token: 0x06003992 RID: 14738 RVA: 0x00094A34 File Offset: 0x00092C34
		public static string ToEnumString(this ETeleCtrlTriggerType value)
		{
			string result;
			if (value != ETeleCtrlTriggerType.MechascoutJavelin)
			{
				if (value != ETeleCtrlTriggerType.MechascoutExplosiveBarrel)
				{
					result = value.ToString();
				}
				else
				{
					result = "MechascoutExplosiveBarrel";
				}
			}
			else
			{
				result = "MechascoutJavelin";
			}
			return result;
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00094A6C File Offset: 0x00092C6C
		public static ETeleCtrlTriggerType FromString(string name)
		{
			ETeleCtrlTriggerType result;
			if (!ETeleCtrlTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleCtrlTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00094A95 File Offset: 0x00092C95
		public static bool TryFromString(string name, out ETeleCtrlTriggerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETeleCtrlTriggerType.MechascoutJavelin;
				return false;
			}
			if (name == "MechascoutJavelin")
			{
				value = ETeleCtrlTriggerType.MechascoutJavelin;
				return true;
			}
			if (!(name == "MechascoutExplosiveBarrel"))
			{
				value = ETeleCtrlTriggerType.MechascoutJavelin;
				return false;
			}
			value = ETeleCtrlTriggerType.MechascoutExplosiveBarrel;
			return true;
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00094ACE File Offset: 0x00092CCE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MechascoutJavelin",
				"MechascoutExplosiveBarrel"
			};
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00094AE6 File Offset: 0x00092CE6
		public static ETeleCtrlTriggerType[] GetValues()
		{
			return new ETeleCtrlTriggerType[]
			{
				ETeleCtrlTriggerType.MechascoutJavelin,
				ETeleCtrlTriggerType.MechascoutExplosiveBarrel
			};
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00094AF2 File Offset: 0x00092CF2
		public static string[] GetNames()
		{
			return new string[]
			{
				"MechascoutJavelin",
				"MechascoutExplosiveBarrel"
			};
		}
	}
}

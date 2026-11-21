using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF7 RID: 2807
	public static class ETeleCtrlTriggerTypeExtensions
	{
		// Token: 0x06003D6A RID: 15722 RVA: 0x0009D368 File Offset: 0x0009B568
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

		// Token: 0x06003D6B RID: 15723 RVA: 0x0009D3A0 File Offset: 0x0009B5A0
		public static ETeleCtrlTriggerType FromString(string name)
		{
			ETeleCtrlTriggerType result;
			if (!ETeleCtrlTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleCtrlTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x0009D3C9 File Offset: 0x0009B5C9
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

		// Token: 0x06003D6D RID: 15725 RVA: 0x0009D402 File Offset: 0x0009B602
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MechascoutJavelin",
				"MechascoutExplosiveBarrel"
			};
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x0009D41A File Offset: 0x0009B61A
		public static ETeleCtrlTriggerType[] GetValues()
		{
			return new ETeleCtrlTriggerType[]
			{
				ETeleCtrlTriggerType.MechascoutJavelin,
				ETeleCtrlTriggerType.MechascoutExplosiveBarrel
			};
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x0009D426 File Offset: 0x0009B626
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

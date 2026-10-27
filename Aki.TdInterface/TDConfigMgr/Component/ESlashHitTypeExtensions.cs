using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0E RID: 2574
	public static class ESlashHitTypeExtensions
	{
		// Token: 0x060038F0 RID: 14576 RVA: 0x000932C8 File Offset: 0x000914C8
		public static string ToEnumString(this ESlashHitType value)
		{
			string result;
			switch (value)
			{
			case ESlashHitType.HeavySlash:
				result = "HeavySlash";
				break;
			case ESlashHitType.LightSlash:
				result = "LightSlash";
				break;
			case ESlashHitType.QTELeft:
				result = "QTELeft";
				break;
			case ESlashHitType.QTERight:
				result = "QTERight";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x0009331C File Offset: 0x0009151C
		public static ESlashHitType FromString(string name)
		{
			ESlashHitType result;
			if (!ESlashHitTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlashHitType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x00093348 File Offset: 0x00091548
		public static bool TryFromString(string name, out ESlashHitType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESlashHitType.HeavySlash;
				return false;
			}
			if (name == "HeavySlash")
			{
				value = ESlashHitType.HeavySlash;
				return true;
			}
			if (name == "LightSlash")
			{
				value = ESlashHitType.LightSlash;
				return true;
			}
			if (name == "QTELeft")
			{
				value = ESlashHitType.QTELeft;
				return true;
			}
			if (!(name == "QTERight"))
			{
				value = ESlashHitType.HeavySlash;
				return false;
			}
			value = ESlashHitType.QTERight;
			return true;
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x000933B0 File Offset: 0x000915B0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HeavySlash",
				"LightSlash",
				"QTELeft",
				"QTERight"
			};
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x000933D8 File Offset: 0x000915D8
		public static ESlashHitType[] GetValues()
		{
			return new ESlashHitType[]
			{
				ESlashHitType.HeavySlash,
				ESlashHitType.LightSlash,
				ESlashHitType.QTELeft,
				ESlashHitType.QTERight
			};
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x000933EB File Offset: 0x000915EB
		public static string[] GetNames()
		{
			return new string[]
			{
				"HeavySlash",
				"LightSlash",
				"QTELeft",
				"QTERight"
			};
		}
	}
}

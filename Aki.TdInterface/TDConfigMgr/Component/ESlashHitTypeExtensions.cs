using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD3 RID: 2771
	public static class ESlashHitTypeExtensions
	{
		// Token: 0x06003CC8 RID: 15560 RVA: 0x0009BBB8 File Offset: 0x00099DB8
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

		// Token: 0x06003CC9 RID: 15561 RVA: 0x0009BC0C File Offset: 0x00099E0C
		public static ESlashHitType FromString(string name)
		{
			ESlashHitType result;
			if (!ESlashHitTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlashHitType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x0009BC38 File Offset: 0x00099E38
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

		// Token: 0x06003CCB RID: 15563 RVA: 0x0009BCA0 File Offset: 0x00099EA0
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

		// Token: 0x06003CCC RID: 15564 RVA: 0x0009BCC8 File Offset: 0x00099EC8
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

		// Token: 0x06003CCD RID: 15565 RVA: 0x0009BCDB File Offset: 0x00099EDB
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

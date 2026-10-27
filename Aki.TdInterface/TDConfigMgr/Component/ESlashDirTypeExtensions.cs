using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0C RID: 2572
	public static class ESlashDirTypeExtensions
	{
		// Token: 0x060038E7 RID: 14567 RVA: 0x000930E4 File Offset: 0x000912E4
		public static string ToEnumString(this ESlashDirType value)
		{
			string result;
			switch (value)
			{
			case ESlashDirType.Horizontal:
				result = "Horizontal";
				break;
			case ESlashDirType.Vertical:
				result = "Vertical";
				break;
			case ESlashDirType.Positive45:
				result = "Positive45";
				break;
			case ESlashDirType.Negative45:
				result = "Negative45";
				break;
			case ESlashDirType.Positive30:
				result = "Positive30";
				break;
			case ESlashDirType.Negative30:
				result = "Negative30";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x00093150 File Offset: 0x00091350
		public static ESlashDirType FromString(string name)
		{
			ESlashDirType result;
			if (!ESlashDirTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlashDirType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0009317C File Offset: 0x0009137C
		public static bool TryFromString(string name, out ESlashDirType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESlashDirType.Horizontal;
				return false;
			}
			if (name == "Horizontal")
			{
				value = ESlashDirType.Horizontal;
				return true;
			}
			if (name == "Vertical")
			{
				value = ESlashDirType.Vertical;
				return true;
			}
			if (name == "Positive45")
			{
				value = ESlashDirType.Positive45;
				return true;
			}
			if (name == "Negative45")
			{
				value = ESlashDirType.Negative45;
				return true;
			}
			if (name == "Positive30")
			{
				value = ESlashDirType.Positive30;
				return true;
			}
			if (!(name == "Negative30"))
			{
				value = ESlashDirType.Horizontal;
				return false;
			}
			value = ESlashDirType.Negative30;
			return true;
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00093208 File Offset: 0x00091408
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Horizontal",
				"Vertical",
				"Positive45",
				"Negative45",
				"Positive30",
				"Negative30"
			};
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x00093240 File Offset: 0x00091440
		public static ESlashDirType[] GetValues()
		{
			return new ESlashDirType[]
			{
				ESlashDirType.Horizontal,
				ESlashDirType.Vertical,
				ESlashDirType.Positive45,
				ESlashDirType.Negative45,
				ESlashDirType.Positive30,
				ESlashDirType.Negative30
			};
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00093253 File Offset: 0x00091453
		public static string[] GetNames()
		{
			return new string[]
			{
				"Horizontal",
				"Vertical",
				"Positive45",
				"Negative45",
				"Positive30",
				"Negative30"
			};
		}
	}
}

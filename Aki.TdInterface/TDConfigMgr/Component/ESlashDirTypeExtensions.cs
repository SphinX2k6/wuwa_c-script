using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD1 RID: 2769
	public static class ESlashDirTypeExtensions
	{
		// Token: 0x06003CBF RID: 15551 RVA: 0x0009B9D4 File Offset: 0x00099BD4
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

		// Token: 0x06003CC0 RID: 15552 RVA: 0x0009BA40 File Offset: 0x00099C40
		public static ESlashDirType FromString(string name)
		{
			ESlashDirType result;
			if (!ESlashDirTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlashDirType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x0009BA6C File Offset: 0x00099C6C
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

		// Token: 0x06003CC2 RID: 15554 RVA: 0x0009BAF8 File Offset: 0x00099CF8
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

		// Token: 0x06003CC3 RID: 15555 RVA: 0x0009BB30 File Offset: 0x00099D30
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

		// Token: 0x06003CC4 RID: 15556 RVA: 0x0009BB43 File Offset: 0x00099D43
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

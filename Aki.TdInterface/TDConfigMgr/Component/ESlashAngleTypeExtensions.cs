using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ACF RID: 2767
	public static class ESlashAngleTypeExtensions
	{
		// Token: 0x06003CB6 RID: 15542 RVA: 0x0009B8C0 File Offset: 0x00099AC0
		public static string ToEnumString(this ESlashAngleType value)
		{
			string result;
			if (value != ESlashAngleType.Slash45)
			{
				if (value != ESlashAngleType.Slash30)
				{
					result = value.ToString();
				}
				else
				{
					result = "Slash30";
				}
			}
			else
			{
				result = "Slash45";
			}
			return result;
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x0009B8F8 File Offset: 0x00099AF8
		public static ESlashAngleType FromString(string name)
		{
			ESlashAngleType result;
			if (!ESlashAngleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlashAngleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x0009B921 File Offset: 0x00099B21
		public static bool TryFromString(string name, out ESlashAngleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESlashAngleType.Slash45;
				return false;
			}
			if (name == "Slash45")
			{
				value = ESlashAngleType.Slash45;
				return true;
			}
			if (!(name == "Slash30"))
			{
				value = ESlashAngleType.Slash45;
				return false;
			}
			value = ESlashAngleType.Slash30;
			return true;
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x0009B95A File Offset: 0x00099B5A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Slash45",
				"Slash30"
			};
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x0009B972 File Offset: 0x00099B72
		public static ESlashAngleType[] GetValues()
		{
			return new ESlashAngleType[]
			{
				ESlashAngleType.Slash45,
				ESlashAngleType.Slash30
			};
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x0009B97E File Offset: 0x00099B7E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Slash45",
				"Slash30"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0A RID: 2570
	public static class ESlashAngleTypeExtensions
	{
		// Token: 0x060038DE RID: 14558 RVA: 0x00092FD0 File Offset: 0x000911D0
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

		// Token: 0x060038DF RID: 14559 RVA: 0x00093008 File Offset: 0x00091208
		public static ESlashAngleType FromString(string name)
		{
			ESlashAngleType result;
			if (!ESlashAngleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlashAngleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x00093031 File Offset: 0x00091231
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

		// Token: 0x060038E1 RID: 14561 RVA: 0x0009306A File Offset: 0x0009126A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Slash45",
				"Slash30"
			};
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x00093082 File Offset: 0x00091282
		public static ESlashAngleType[] GetValues()
		{
			return new ESlashAngleType[]
			{
				ESlashAngleType.Slash45,
				ESlashAngleType.Slash30
			};
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0009308E File Offset: 0x0009128E
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

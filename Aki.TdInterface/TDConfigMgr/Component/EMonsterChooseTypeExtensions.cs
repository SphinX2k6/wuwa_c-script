using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099E RID: 2462
	public static class EMonsterChooseTypeExtensions
	{
		// Token: 0x060036F8 RID: 14072 RVA: 0x0008F008 File Offset: 0x0008D208
		public static string ToEnumString(this EMonsterChooseType value)
		{
			string result;
			if (value == EMonsterChooseType.RandomPoolChoose)
			{
				result = "RandomPoolChoose";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x0008F030 File Offset: 0x0008D230
		public static EMonsterChooseType FromString(string name)
		{
			EMonsterChooseType result;
			if (!EMonsterChooseTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMonsterChooseType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x0008F059 File Offset: 0x0008D259
		public static bool TryFromString(string name, out EMonsterChooseType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMonsterChooseType.RandomPoolChoose;
				return false;
			}
			if (name == "RandomPoolChoose")
			{
				value = EMonsterChooseType.RandomPoolChoose;
				return true;
			}
			value = EMonsterChooseType.RandomPoolChoose;
			return false;
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x0008F07E File Offset: 0x0008D27E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RandomPoolChoose"
			};
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x0008F08E File Offset: 0x0008D28E
		public static EMonsterChooseType[] GetValues()
		{
			return new EMonsterChooseType[1];
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x0008F096 File Offset: 0x0008D296
		public static string[] GetNames()
		{
			return new string[]
			{
				"RandomPoolChoose"
			};
		}
	}
}

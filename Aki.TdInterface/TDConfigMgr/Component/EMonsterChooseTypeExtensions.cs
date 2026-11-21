using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A51 RID: 2641
	public static class EMonsterChooseTypeExtensions
	{
		// Token: 0x06003A7F RID: 14975 RVA: 0x00096FB8 File Offset: 0x000951B8
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

		// Token: 0x06003A80 RID: 14976 RVA: 0x00096FE0 File Offset: 0x000951E0
		public static EMonsterChooseType FromString(string name)
		{
			EMonsterChooseType result;
			if (!EMonsterChooseTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMonsterChooseType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x00097009 File Offset: 0x00095209
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

		// Token: 0x06003A82 RID: 14978 RVA: 0x0009702E File Offset: 0x0009522E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RandomPoolChoose"
			};
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x0009703E File Offset: 0x0009523E
		public static EMonsterChooseType[] GetValues()
		{
			return new EMonsterChooseType[1];
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x00097046 File Offset: 0x00095246
		public static string[] GetNames()
		{
			return new string[]
			{
				"RandomPoolChoose"
			};
		}
	}
}

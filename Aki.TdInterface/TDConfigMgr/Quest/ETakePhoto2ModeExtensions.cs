using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013DE RID: 5086
	public static class ETakePhoto2ModeExtensions
	{
		// Token: 0x060071C1 RID: 29121 RVA: 0x0010FE48 File Offset: 0x0010E048
		public static string ToEnumString(this ETakePhoto2Mode value)
		{
			string result;
			if (value == ETakePhoto2Mode.BeforeYourEyes)
			{
				result = "BeforeYourEyes";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x0010FE70 File Offset: 0x0010E070
		public static ETakePhoto2Mode FromString(string name)
		{
			ETakePhoto2Mode result;
			if (!ETakePhoto2ModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETakePhoto2Mode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x0010FE99 File Offset: 0x0010E099
		public static bool TryFromString(string name, out ETakePhoto2Mode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETakePhoto2Mode.BeforeYourEyes;
				return false;
			}
			if (name == "BeforeYourEyes")
			{
				value = ETakePhoto2Mode.BeforeYourEyes;
				return true;
			}
			value = ETakePhoto2Mode.BeforeYourEyes;
			return false;
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x0010FEBE File Offset: 0x0010E0BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BeforeYourEyes"
			};
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x0010FECE File Offset: 0x0010E0CE
		public static ETakePhoto2Mode[] GetValues()
		{
			return new ETakePhoto2Mode[1];
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x0010FED6 File Offset: 0x0010E0D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"BeforeYourEyes"
			};
		}
	}
}

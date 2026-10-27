using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FC RID: 2556
	public static class ERotationTypeExtensions
	{
		// Token: 0x0600389F RID: 14495 RVA: 0x000928B4 File Offset: 0x00090AB4
		public static string ToEnumString(this ERotationType value)
		{
			string result;
			if (value != ERotationType.Relative)
			{
				if (value != ERotationType.Absolute)
				{
					result = value.ToString();
				}
				else
				{
					result = "Absolute";
				}
			}
			else
			{
				result = "Relative";
			}
			return result;
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x000928EC File Offset: 0x00090AEC
		public static ERotationType FromString(string name)
		{
			ERotationType result;
			if (!ERotationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERotationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x00092915 File Offset: 0x00090B15
		public static bool TryFromString(string name, out ERotationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERotationType.Relative;
				return false;
			}
			if (name == "Relative")
			{
				value = ERotationType.Relative;
				return true;
			}
			if (!(name == "Absolute"))
			{
				value = ERotationType.Relative;
				return false;
			}
			value = ERotationType.Absolute;
			return true;
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x0009294E File Offset: 0x00090B4E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Relative",
				"Absolute"
			};
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x00092966 File Offset: 0x00090B66
		public static ERotationType[] GetValues()
		{
			return new ERotationType[]
			{
				ERotationType.Relative,
				ERotationType.Absolute
			};
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x00092972 File Offset: 0x00090B72
		public static string[] GetNames()
		{
			return new string[]
			{
				"Relative",
				"Absolute"
			};
		}
	}
}

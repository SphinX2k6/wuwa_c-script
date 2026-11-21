using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200270A RID: 9994
	public static class ETetrisRotationExtensions
	{
		// Token: 0x0600D707 RID: 55047 RVA: 0x001F6924 File Offset: 0x001F4B24
		public static string ToEnumString(this ETetrisRotation value)
		{
			string result;
			switch (value)
			{
			case ETetrisRotation.Origin:
				result = "Origin";
				break;
			case ETetrisRotation.Clockwise90:
				result = "Clockwise90";
				break;
			case ETetrisRotation.Clockwise180:
				result = "Clockwise180";
				break;
			case ETetrisRotation.Clockwise270:
				result = "Clockwise270";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D708 RID: 55048 RVA: 0x001F6978 File Offset: 0x001F4B78
		public static ETetrisRotation FromString(string name)
		{
			ETetrisRotation result;
			if (!ETetrisRotationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETetrisRotation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D709 RID: 55049 RVA: 0x001F69A4 File Offset: 0x001F4BA4
		public static bool TryFromString(string name, out ETetrisRotation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETetrisRotation.Origin;
				return false;
			}
			if (name == "Origin")
			{
				value = ETetrisRotation.Origin;
				return true;
			}
			if (name == "Clockwise90")
			{
				value = ETetrisRotation.Clockwise90;
				return true;
			}
			if (name == "Clockwise180")
			{
				value = ETetrisRotation.Clockwise180;
				return true;
			}
			if (!(name == "Clockwise270"))
			{
				value = ETetrisRotation.Origin;
				return false;
			}
			value = ETetrisRotation.Clockwise270;
			return true;
		}

		// Token: 0x0600D70A RID: 55050 RVA: 0x001F6A0C File Offset: 0x001F4C0C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Origin",
				"Clockwise90",
				"Clockwise180",
				"Clockwise270"
			};
		}

		// Token: 0x0600D70B RID: 55051 RVA: 0x001F6A34 File Offset: 0x001F4C34
		public static ETetrisRotation[] GetValues()
		{
			return new ETetrisRotation[]
			{
				ETetrisRotation.Origin,
				ETetrisRotation.Clockwise90,
				ETetrisRotation.Clockwise180,
				ETetrisRotation.Clockwise270
			};
		}

		// Token: 0x0600D70C RID: 55052 RVA: 0x001F6A47 File Offset: 0x001F4C47
		public static string[] GetNames()
		{
			return new string[]
			{
				"Origin",
				"Clockwise90",
				"Clockwise180",
				"Clockwise270"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002469 RID: 9321
	public static class ETetrisRotationExtensions
	{
		// Token: 0x0600CA57 RID: 51799 RVA: 0x001DC870 File Offset: 0x001DAA70
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

		// Token: 0x0600CA58 RID: 51800 RVA: 0x001DC8C4 File Offset: 0x001DAAC4
		public static ETetrisRotation FromString(string name)
		{
			ETetrisRotation result;
			if (!ETetrisRotationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETetrisRotation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA59 RID: 51801 RVA: 0x001DC8F0 File Offset: 0x001DAAF0
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

		// Token: 0x0600CA5A RID: 51802 RVA: 0x001DC958 File Offset: 0x001DAB58
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

		// Token: 0x0600CA5B RID: 51803 RVA: 0x001DC980 File Offset: 0x001DAB80
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

		// Token: 0x0600CA5C RID: 51804 RVA: 0x001DC993 File Offset: 0x001DAB93
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

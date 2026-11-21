using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002506 RID: 9478
	public static class EAfterTeleportScreenColorExtensions
	{
		// Token: 0x0600CDF5 RID: 52725 RVA: 0x001DDCCC File Offset: 0x001DBECC
		public static string ToEnumString(this EAfterTeleportScreenColor value)
		{
			string result;
			if (value != EAfterTeleportScreenColor.Black)
			{
				if (value != EAfterTeleportScreenColor.White)
				{
					result = value.ToString();
				}
				else
				{
					result = "White";
				}
			}
			else
			{
				result = "Black";
			}
			return result;
		}

		// Token: 0x0600CDF6 RID: 52726 RVA: 0x001DDD04 File Offset: 0x001DBF04
		public static EAfterTeleportScreenColor FromString(string name)
		{
			EAfterTeleportScreenColor result;
			if (!EAfterTeleportScreenColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAfterTeleportScreenColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CDF7 RID: 52727 RVA: 0x001DDD2D File Offset: 0x001DBF2D
		public static bool TryFromString(string name, out EAfterTeleportScreenColor value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAfterTeleportScreenColor.Black;
				return false;
			}
			if (name == "Black")
			{
				value = EAfterTeleportScreenColor.Black;
				return true;
			}
			if (!(name == "White"))
			{
				value = EAfterTeleportScreenColor.Black;
				return false;
			}
			value = EAfterTeleportScreenColor.White;
			return true;
		}

		// Token: 0x0600CDF8 RID: 52728 RVA: 0x001DDD66 File Offset: 0x001DBF66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"White"
			};
		}

		// Token: 0x0600CDF9 RID: 52729 RVA: 0x001DDD7E File Offset: 0x001DBF7E
		public static EAfterTeleportScreenColor[] GetValues()
		{
			return new EAfterTeleportScreenColor[]
			{
				EAfterTeleportScreenColor.Black,
				EAfterTeleportScreenColor.White
			};
		}

		// Token: 0x0600CDFA RID: 52730 RVA: 0x001DDD8A File Offset: 0x001DBF8A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Black",
				"White"
			};
		}
	}
}

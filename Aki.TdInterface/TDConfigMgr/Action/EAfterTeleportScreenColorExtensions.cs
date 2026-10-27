using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002299 RID: 8857
	public static class EAfterTeleportScreenColorExtensions
	{
		// Token: 0x0600C22F RID: 49711 RVA: 0x001C5FD8 File Offset: 0x001C41D8
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

		// Token: 0x0600C230 RID: 49712 RVA: 0x001C6010 File Offset: 0x001C4210
		public static EAfterTeleportScreenColor FromString(string name)
		{
			EAfterTeleportScreenColor result;
			if (!EAfterTeleportScreenColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAfterTeleportScreenColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C231 RID: 49713 RVA: 0x001C6039 File Offset: 0x001C4239
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

		// Token: 0x0600C232 RID: 49714 RVA: 0x001C6072 File Offset: 0x001C4272
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"White"
			};
		}

		// Token: 0x0600C233 RID: 49715 RVA: 0x001C608A File Offset: 0x001C428A
		public static EAfterTeleportScreenColor[] GetValues()
		{
			return new EAfterTeleportScreenColor[]
			{
				EAfterTeleportScreenColor.Black,
				EAfterTeleportScreenColor.White
			};
		}

		// Token: 0x0600C234 RID: 49716 RVA: 0x001C6096 File Offset: 0x001C4296
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

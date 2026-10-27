using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A5 RID: 9125
	public static class EMp4BackgroundColorExtensions
	{
		// Token: 0x0600C6E5 RID: 50917 RVA: 0x001D1FE8 File Offset: 0x001D01E8
		public static string ToEnumString(this EMp4BackgroundColor value)
		{
			string result;
			if (value != EMp4BackgroundColor.Black)
			{
				if (value != EMp4BackgroundColor.White)
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

		// Token: 0x0600C6E6 RID: 50918 RVA: 0x001D2020 File Offset: 0x001D0220
		public static EMp4BackgroundColor FromString(string name)
		{
			EMp4BackgroundColor result;
			if (!EMp4BackgroundColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMp4BackgroundColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6E7 RID: 50919 RVA: 0x001D2049 File Offset: 0x001D0249
		public static bool TryFromString(string name, out EMp4BackgroundColor value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMp4BackgroundColor.Black;
				return false;
			}
			if (name == "Black")
			{
				value = EMp4BackgroundColor.Black;
				return true;
			}
			if (!(name == "White"))
			{
				value = EMp4BackgroundColor.Black;
				return false;
			}
			value = EMp4BackgroundColor.White;
			return true;
		}

		// Token: 0x0600C6E8 RID: 50920 RVA: 0x001D2082 File Offset: 0x001D0282
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"White"
			};
		}

		// Token: 0x0600C6E9 RID: 50921 RVA: 0x001D209A File Offset: 0x001D029A
		public static EMp4BackgroundColor[] GetValues()
		{
			return new EMp4BackgroundColor[]
			{
				EMp4BackgroundColor.Black,
				EMp4BackgroundColor.White
			};
		}

		// Token: 0x0600C6EA RID: 50922 RVA: 0x001D20A6 File Offset: 0x001D02A6
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

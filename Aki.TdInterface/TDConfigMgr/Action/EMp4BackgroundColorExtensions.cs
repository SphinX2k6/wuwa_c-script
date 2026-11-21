using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002630 RID: 9776
	public static class EMp4BackgroundColorExtensions
	{
		// Token: 0x0600D332 RID: 54066 RVA: 0x001EB188 File Offset: 0x001E9388
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

		// Token: 0x0600D333 RID: 54067 RVA: 0x001EB1C0 File Offset: 0x001E93C0
		public static EMp4BackgroundColor FromString(string name)
		{
			EMp4BackgroundColor result;
			if (!EMp4BackgroundColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMp4BackgroundColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D334 RID: 54068 RVA: 0x001EB1E9 File Offset: 0x001E93E9
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

		// Token: 0x0600D335 RID: 54069 RVA: 0x001EB222 File Offset: 0x001E9422
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"White"
			};
		}

		// Token: 0x0600D336 RID: 54070 RVA: 0x001EB23A File Offset: 0x001E943A
		public static EMp4BackgroundColor[] GetValues()
		{
			return new EMp4BackgroundColor[]
			{
				EMp4BackgroundColor.Black,
				EMp4BackgroundColor.White
			};
		}

		// Token: 0x0600D337 RID: 54071 RVA: 0x001EB246 File Offset: 0x001E9446
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

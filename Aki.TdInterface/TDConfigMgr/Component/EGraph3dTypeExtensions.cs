using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A07 RID: 2567
	public static class EGraph3dTypeExtensions
	{
		// Token: 0x06003932 RID: 14642 RVA: 0x00093E48 File Offset: 0x00092048
		public static string ToEnumString(this EGraph3dType value)
		{
			string result;
			if (value == EGraph3dType.Normal)
			{
				result = "Normal";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x00093E70 File Offset: 0x00092070
		public static EGraph3dType FromString(string name)
		{
			EGraph3dType result;
			if (!EGraph3dTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGraph3dType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x00093E99 File Offset: 0x00092099
		public static bool TryFromString(string name, out EGraph3dType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGraph3dType.Normal;
				return false;
			}
			if (name == "Normal")
			{
				value = EGraph3dType.Normal;
				return true;
			}
			value = EGraph3dType.Normal;
			return false;
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x00093EBE File Offset: 0x000920BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal"
			};
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00093ECE File Offset: 0x000920CE
		public static EGraph3dType[] GetValues()
		{
			return new EGraph3dType[1];
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x00093ED6 File Offset: 0x000920D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Normal"
			};
		}
	}
}

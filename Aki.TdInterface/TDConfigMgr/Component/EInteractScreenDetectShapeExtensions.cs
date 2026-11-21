using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2B RID: 2603
	public static class EInteractScreenDetectShapeExtensions
	{
		// Token: 0x060039D4 RID: 14804 RVA: 0x00095948 File Offset: 0x00093B48
		public static string ToEnumString(this EInteractScreenDetectShape value)
		{
			string result;
			if (value == EInteractScreenDetectShape.Circle)
			{
				result = "Circle";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00095970 File Offset: 0x00093B70
		public static EInteractScreenDetectShape FromString(string name)
		{
			EInteractScreenDetectShape result;
			if (!EInteractScreenDetectShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractScreenDetectShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00095999 File Offset: 0x00093B99
		public static bool TryFromString(string name, out EInteractScreenDetectShape value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractScreenDetectShape.Circle;
				return false;
			}
			if (name == "Circle")
			{
				value = EInteractScreenDetectShape.Circle;
				return true;
			}
			value = EInteractScreenDetectShape.Circle;
			return false;
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x000959BE File Offset: 0x00093BBE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Circle"
			};
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x000959CE File Offset: 0x00093BCE
		public static EInteractScreenDetectShape[] GetValues()
		{
			return new EInteractScreenDetectShape[1];
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x000959D6 File Offset: 0x00093BD6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Circle"
			};
		}
	}
}

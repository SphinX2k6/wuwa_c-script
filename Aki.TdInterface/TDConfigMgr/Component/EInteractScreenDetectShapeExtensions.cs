using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000978 RID: 2424
	public static class EInteractScreenDetectShapeExtensions
	{
		// Token: 0x0600364D RID: 13901 RVA: 0x0008D9DC File Offset: 0x0008BBDC
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

		// Token: 0x0600364E RID: 13902 RVA: 0x0008DA04 File Offset: 0x0008BC04
		public static EInteractScreenDetectShape FromString(string name)
		{
			EInteractScreenDetectShape result;
			if (!EInteractScreenDetectShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractScreenDetectShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x0008DA2D File Offset: 0x0008BC2D
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

		// Token: 0x06003650 RID: 13904 RVA: 0x0008DA52 File Offset: 0x0008BC52
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Circle"
			};
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x0008DA62 File Offset: 0x0008BC62
		public static EInteractScreenDetectShape[] GetValues()
		{
			return new EInteractScreenDetectShape[1];
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x0008DA6A File Offset: 0x0008BC6A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Circle"
			};
		}
	}
}

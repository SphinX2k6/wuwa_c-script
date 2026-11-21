using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AAB RID: 2731
	public static class EQteTypeExtensions
	{
		// Token: 0x06003C14 RID: 15380 RVA: 0x0009A528 File Offset: 0x00098728
		public static string ToEnumString(this EQteType value)
		{
			string result;
			if (value == EQteType.SingleBtn)
			{
				result = "SingleBtn";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x0009A550 File Offset: 0x00098750
		public static EQteType FromString(string name)
		{
			EQteType result;
			if (!EQteTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQteType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x0009A579 File Offset: 0x00098779
		public static bool TryFromString(string name, out EQteType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EQteType.SingleBtn;
				return false;
			}
			if (name == "SingleBtn")
			{
				value = EQteType.SingleBtn;
				return true;
			}
			value = EQteType.SingleBtn;
			return false;
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x0009A59E File Offset: 0x0009879E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SingleBtn"
			};
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x0009A5AE File Offset: 0x000987AE
		public static EQteType[] GetValues()
		{
			return new EQteType[1];
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x0009A5B6 File Offset: 0x000987B6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SingleBtn"
			};
		}
	}
}

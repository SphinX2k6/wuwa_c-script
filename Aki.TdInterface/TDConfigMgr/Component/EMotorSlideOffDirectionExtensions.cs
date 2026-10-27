using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A6 RID: 2470
	public static class EMotorSlideOffDirectionExtensions
	{
		// Token: 0x0600371C RID: 14108 RVA: 0x0008F45C File Offset: 0x0008D65C
		public static string ToEnumString(this EMotorSlideOffDirection value)
		{
			string result;
			if (value != EMotorSlideOffDirection.Left)
			{
				if (value != EMotorSlideOffDirection.Right)
				{
					result = value.ToString();
				}
				else
				{
					result = "Right";
				}
			}
			else
			{
				result = "Left";
			}
			return result;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x0008F494 File Offset: 0x0008D694
		public static EMotorSlideOffDirection FromString(string name)
		{
			EMotorSlideOffDirection result;
			if (!EMotorSlideOffDirectionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorSlideOffDirection 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x0008F4BD File Offset: 0x0008D6BD
		public static bool TryFromString(string name, out EMotorSlideOffDirection value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorSlideOffDirection.Left;
				return false;
			}
			if (name == "Left")
			{
				value = EMotorSlideOffDirection.Left;
				return true;
			}
			if (!(name == "Right"))
			{
				value = EMotorSlideOffDirection.Left;
				return false;
			}
			value = EMotorSlideOffDirection.Right;
			return true;
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x0008F4F6 File Offset: 0x0008D6F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Right"
			};
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x0008F50E File Offset: 0x0008D70E
		public static EMotorSlideOffDirection[] GetValues()
		{
			return new EMotorSlideOffDirection[]
			{
				EMotorSlideOffDirection.Left,
				EMotorSlideOffDirection.Right
			};
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x0008F51A File Offset: 0x0008D71A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Left",
				"Right"
			};
		}
	}
}

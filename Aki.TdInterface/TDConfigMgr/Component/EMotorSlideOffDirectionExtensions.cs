using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A5B RID: 2651
	public static class EMotorSlideOffDirectionExtensions
	{
		// Token: 0x06003AAC RID: 15020 RVA: 0x00097520 File Offset: 0x00095720
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

		// Token: 0x06003AAD RID: 15021 RVA: 0x00097558 File Offset: 0x00095758
		public static EMotorSlideOffDirection FromString(string name)
		{
			EMotorSlideOffDirection result;
			if (!EMotorSlideOffDirectionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorSlideOffDirection 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x00097581 File Offset: 0x00095781
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

		// Token: 0x06003AAF RID: 15023 RVA: 0x000975BA File Offset: 0x000957BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Right"
			};
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x000975D2 File Offset: 0x000957D2
		public static EMotorSlideOffDirection[] GetValues()
		{
			return new EMotorSlideOffDirection[]
			{
				EMotorSlideOffDirection.Left,
				EMotorSlideOffDirection.Right
			};
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x000975DE File Offset: 0x000957DE
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

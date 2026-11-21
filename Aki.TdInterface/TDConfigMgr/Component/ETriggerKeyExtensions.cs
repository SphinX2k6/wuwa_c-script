using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B07 RID: 2823
	public static class ETriggerKeyExtensions
	{
		// Token: 0x06003DB2 RID: 15794 RVA: 0x0009DC04 File Offset: 0x0009BE04
		public static string ToEnumString(this ETriggerKey value)
		{
			string result;
			switch (value)
			{
			case ETriggerKey.Left:
				result = "Left";
				break;
			case ETriggerKey.Right:
				result = "Right";
				break;
			case ETriggerKey.Jump:
				result = "Jump";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x0009DC4C File Offset: 0x0009BE4C
		public static ETriggerKey FromString(string name)
		{
			ETriggerKey result;
			if (!ETriggerKeyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETriggerKey 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x0009DC78 File Offset: 0x0009BE78
		public static bool TryFromString(string name, out ETriggerKey value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETriggerKey.Left;
				return false;
			}
			if (name == "Left")
			{
				value = ETriggerKey.Left;
				return true;
			}
			if (name == "Right")
			{
				value = ETriggerKey.Right;
				return true;
			}
			if (!(name == "Jump"))
			{
				value = ETriggerKey.Left;
				return false;
			}
			value = ETriggerKey.Jump;
			return true;
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x0009DCCE File Offset: 0x0009BECE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Right",
				"Jump"
			};
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x0009DCEE File Offset: 0x0009BEEE
		public static ETriggerKey[] GetValues()
		{
			return new ETriggerKey[]
			{
				ETriggerKey.Left,
				ETriggerKey.Right,
				ETriggerKey.Jump
			};
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x0009DCFE File Offset: 0x0009BEFE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Left",
				"Right",
				"Jump"
			};
		}
	}
}

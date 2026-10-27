using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A42 RID: 2626
	public static class ETriggerKeyExtensions
	{
		// Token: 0x060039DA RID: 14810 RVA: 0x00095298 File Offset: 0x00093498
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

		// Token: 0x060039DB RID: 14811 RVA: 0x000952E0 File Offset: 0x000934E0
		public static ETriggerKey FromString(string name)
		{
			ETriggerKey result;
			if (!ETriggerKeyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETriggerKey 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x0009530C File Offset: 0x0009350C
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

		// Token: 0x060039DD RID: 14813 RVA: 0x00095362 File Offset: 0x00093562
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Right",
				"Jump"
			};
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x00095382 File Offset: 0x00093582
		public static ETriggerKey[] GetValues()
		{
			return new ETriggerKey[]
			{
				ETriggerKey.Left,
				ETriggerKey.Right,
				ETriggerKey.Jump
			};
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00095392 File Offset: 0x00093592
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

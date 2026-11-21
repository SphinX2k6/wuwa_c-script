using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013E6 RID: 5094
	public static class ETetrisDirectionExtensions
	{
		// Token: 0x060071E5 RID: 29157 RVA: 0x001102D4 File Offset: 0x0010E4D4
		public static string ToEnumString(this ETetrisDirection value)
		{
			string result;
			if (value != ETetrisDirection.UpDown)
			{
				if (value != ETetrisDirection.RightLeft)
				{
					result = value.ToString();
				}
				else
				{
					result = "RightLeft";
				}
			}
			else
			{
				result = "UpDown";
			}
			return result;
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x0011030C File Offset: 0x0010E50C
		public static ETetrisDirection FromString(string name)
		{
			ETetrisDirection result;
			if (!ETetrisDirectionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETetrisDirection 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x00110335 File Offset: 0x0010E535
		public static bool TryFromString(string name, out ETetrisDirection value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETetrisDirection.UpDown;
				return false;
			}
			if (name == "UpDown")
			{
				value = ETetrisDirection.UpDown;
				return true;
			}
			if (!(name == "RightLeft"))
			{
				value = ETetrisDirection.UpDown;
				return false;
			}
			value = ETetrisDirection.RightLeft;
			return true;
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x0011036E File Offset: 0x0010E56E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UpDown",
				"RightLeft"
			};
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x00110386 File Offset: 0x0010E586
		public static ETetrisDirection[] GetValues()
		{
			return new ETetrisDirection[]
			{
				ETetrisDirection.UpDown,
				ETetrisDirection.RightLeft
			};
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x00110392 File Offset: 0x0010E592
		public static string[] GetNames()
		{
			return new string[]
			{
				"UpDown",
				"RightLeft"
			};
		}
	}
}

using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A0 RID: 4768
	public static class ETetrisDirectionExtensions
	{
		// Token: 0x06006B77 RID: 27511 RVA: 0x0010230C File Offset: 0x0010050C
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

		// Token: 0x06006B78 RID: 27512 RVA: 0x00102344 File Offset: 0x00100544
		public static ETetrisDirection FromString(string name)
		{
			ETetrisDirection result;
			if (!ETetrisDirectionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETetrisDirection 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x0010236D File Offset: 0x0010056D
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

		// Token: 0x06006B7A RID: 27514 RVA: 0x001023A6 File Offset: 0x001005A6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UpDown",
				"RightLeft"
			};
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x001023BE File Offset: 0x001005BE
		public static ETetrisDirection[] GetValues()
		{
			return new ETetrisDirection[]
			{
				ETetrisDirection.UpDown,
				ETetrisDirection.RightLeft
			};
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x001023CA File Offset: 0x001005CA
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

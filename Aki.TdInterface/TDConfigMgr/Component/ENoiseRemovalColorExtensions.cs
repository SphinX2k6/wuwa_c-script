using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B0 RID: 2480
	public static class ENoiseRemovalColorExtensions
	{
		// Token: 0x06003749 RID: 14153 RVA: 0x0008FCC4 File Offset: 0x0008DEC4
		public static string ToEnumString(this ENoiseRemovalColor value)
		{
			string result;
			switch (value)
			{
			case ENoiseRemovalColor.Red:
				result = "Red";
				break;
			case ENoiseRemovalColor.Blue:
				result = "Blue";
				break;
			case ENoiseRemovalColor.Green:
				result = "Green";
				break;
			case ENoiseRemovalColor.Black:
				result = "Black";
				break;
			case ENoiseRemovalColor.Purple:
				result = "Purple";
				break;
			case ENoiseRemovalColor.Core:
				result = "Core";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x0008FD30 File Offset: 0x0008DF30
		public static ENoiseRemovalColor FromString(string name)
		{
			ENoiseRemovalColor result;
			if (!ENoiseRemovalColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENoiseRemovalColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x0008FD5C File Offset: 0x0008DF5C
		public static bool TryFromString(string name, out ENoiseRemovalColor value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENoiseRemovalColor.Red;
				return false;
			}
			if (name == "Red")
			{
				value = ENoiseRemovalColor.Red;
				return true;
			}
			if (name == "Blue")
			{
				value = ENoiseRemovalColor.Blue;
				return true;
			}
			if (name == "Green")
			{
				value = ENoiseRemovalColor.Green;
				return true;
			}
			if (name == "Black")
			{
				value = ENoiseRemovalColor.Black;
				return true;
			}
			if (name == "Purple")
			{
				value = ENoiseRemovalColor.Purple;
				return true;
			}
			if (!(name == "Core"))
			{
				value = ENoiseRemovalColor.Red;
				return false;
			}
			value = ENoiseRemovalColor.Core;
			return true;
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x0008FDE8 File Offset: 0x0008DFE8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Red",
				"Blue",
				"Green",
				"Black",
				"Purple",
				"Core"
			};
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x0008FE20 File Offset: 0x0008E020
		public static ENoiseRemovalColor[] GetValues()
		{
			return new ENoiseRemovalColor[]
			{
				ENoiseRemovalColor.Red,
				ENoiseRemovalColor.Blue,
				ENoiseRemovalColor.Green,
				ENoiseRemovalColor.Black,
				ENoiseRemovalColor.Purple,
				ENoiseRemovalColor.Core
			};
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x0008FE33 File Offset: 0x0008E033
		public static string[] GetNames()
		{
			return new string[]
			{
				"Red",
				"Blue",
				"Green",
				"Black",
				"Purple",
				"Core"
			};
		}
	}
}

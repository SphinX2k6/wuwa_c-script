using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A65 RID: 2661
	public static class ENoiseRemovalColorExtensions
	{
		// Token: 0x06003AD9 RID: 15065 RVA: 0x00097DB8 File Offset: 0x00095FB8
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

		// Token: 0x06003ADA RID: 15066 RVA: 0x00097E24 File Offset: 0x00096024
		public static ENoiseRemovalColor FromString(string name)
		{
			ENoiseRemovalColor result;
			if (!ENoiseRemovalColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENoiseRemovalColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00097E50 File Offset: 0x00096050
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

		// Token: 0x06003ADC RID: 15068 RVA: 0x00097EDC File Offset: 0x000960DC
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

		// Token: 0x06003ADD RID: 15069 RVA: 0x00097F14 File Offset: 0x00096114
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

		// Token: 0x06003ADE RID: 15070 RVA: 0x00097F27 File Offset: 0x00096127
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

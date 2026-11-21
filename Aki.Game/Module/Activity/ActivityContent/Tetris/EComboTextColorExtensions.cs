using System;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FBF RID: 12223
	public static class EComboTextColorExtensions
	{
		// Token: 0x0601D043 RID: 118851 RVA: 0x008DC0B0 File Offset: 0x008DA2B0
		public static string ToEnumString(this EComboTextColor value)
		{
			string result;
			switch (value)
			{
			case EComboTextColor.Good:
				result = "03DD5A";
				break;
			case EComboTextColor.Great:
				result = "D200FF";
				break;
			case EComboTextColor.Excellent:
				result = "FF3000";
				break;
			case EComboTextColor.Unbelievable:
				result = "FFA800";
				break;
			case EComboTextColor.Combo:
				result = "00BBFA";
				break;
			case EComboTextColor.Default:
				result = "FFFFFF";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0601D044 RID: 118852 RVA: 0x008DC11C File Offset: 0x008DA31C
		public static EComboTextColor FromString(string name)
		{
			EComboTextColor result;
			if (!EComboTextColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EComboTextColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0601D045 RID: 118853 RVA: 0x008DC148 File Offset: 0x008DA348
		public static bool TryFromString(string name, out EComboTextColor value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EComboTextColor.Good;
				return false;
			}
			if (name == "03DD5A")
			{
				value = EComboTextColor.Good;
				return true;
			}
			if (name == "D200FF")
			{
				value = EComboTextColor.Great;
				return true;
			}
			if (name == "FF3000")
			{
				value = EComboTextColor.Excellent;
				return true;
			}
			if (name == "FFA800")
			{
				value = EComboTextColor.Unbelievable;
				return true;
			}
			if (name == "00BBFA")
			{
				value = EComboTextColor.Combo;
				return true;
			}
			if (!(name == "FFFFFF"))
			{
				value = EComboTextColor.Good;
				return false;
			}
			value = EComboTextColor.Default;
			return true;
		}

		// Token: 0x0601D046 RID: 118854 RVA: 0x008DC1D4 File Offset: 0x008DA3D4
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"03DD5A",
				"D200FF",
				"FF3000",
				"FFA800",
				"00BBFA",
				"FFFFFF"
			};
		}

		// Token: 0x0601D047 RID: 118855 RVA: 0x008DC20C File Offset: 0x008DA40C
		public static EComboTextColor[] GetValues()
		{
			return new EComboTextColor[]
			{
				EComboTextColor.Good,
				EComboTextColor.Great,
				EComboTextColor.Excellent,
				EComboTextColor.Unbelievable,
				EComboTextColor.Combo,
				EComboTextColor.Default
			};
		}

		// Token: 0x0601D048 RID: 118856 RVA: 0x008DC21F File Offset: 0x008DA41F
		public static string[] GetNames()
		{
			return new string[]
			{
				"Good",
				"Great",
				"Excellent",
				"Unbelievable",
				"Combo",
				"Default"
			};
		}
	}
}

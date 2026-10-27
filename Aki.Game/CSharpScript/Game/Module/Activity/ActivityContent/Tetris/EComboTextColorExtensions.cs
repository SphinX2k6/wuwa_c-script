using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200602D RID: 24621
	public static class EComboTextColorExtensions
	{
		// Token: 0x0603E500 RID: 255232 RVA: 0x00F0CA68 File Offset: 0x00F0AC68
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

		// Token: 0x0603E501 RID: 255233 RVA: 0x00F0CAD4 File Offset: 0x00F0ACD4
		public static EComboTextColor FromString(string name)
		{
			EComboTextColor result;
			if (!EComboTextColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EComboTextColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603E502 RID: 255234 RVA: 0x00F0CB00 File Offset: 0x00F0AD00
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

		// Token: 0x0603E503 RID: 255235 RVA: 0x00F0CB8C File Offset: 0x00F0AD8C
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

		// Token: 0x0603E504 RID: 255236 RVA: 0x00F0CBC4 File Offset: 0x00F0ADC4
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

		// Token: 0x0603E505 RID: 255237 RVA: 0x00F0CBD7 File Offset: 0x00F0ADD7
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

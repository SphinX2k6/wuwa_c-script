using System;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200007A RID: 122
	public static class ESpecialValueExtensions
	{
		// Token: 0x0600033B RID: 827 RVA: 0x0001154C File Offset: 0x0000F74C
		public static string ToEnumString(this ESpecialValue value)
		{
			string result;
			switch (value)
			{
			case ESpecialValue.Undefined:
				result = "___undefined___";
				break;
			case ESpecialValue.NaN:
				result = "___NaN___";
				break;
			case ESpecialValue.Infinity:
				result = "___Infinity___";
				break;
			case ESpecialValue.InfinityNegative:
				result = "___-Infinity___";
				break;
			case ESpecialValue.BigInt:
				result = "___BI___";
				break;
			case ESpecialValue.BooleanTrue:
				result = "___1B___";
				break;
			case ESpecialValue.BooleanFalse:
				result = "___0B___";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000115C4 File Offset: 0x0000F7C4
		public static ESpecialValue FromString(string name)
		{
			ESpecialValue result;
			if (!ESpecialValueExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialValue 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000115F0 File Offset: 0x0000F7F0
		public static bool TryFromString(string name, out ESpecialValue value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecialValue.Undefined;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length <= 9)
				{
					if (length != 8)
					{
						if (length == 9)
						{
							if (name == "___NaN___")
							{
								value = ESpecialValue.NaN;
								return true;
							}
						}
					}
					else
					{
						char c = name[3];
						if (c != '0')
						{
							if (c != '1')
							{
								if (c == 'B')
								{
									if (name == "___BI___")
									{
										value = ESpecialValue.BigInt;
										return true;
									}
								}
							}
							else if (name == "___1B___")
							{
								value = ESpecialValue.BooleanTrue;
								return true;
							}
						}
						else if (name == "___0B___")
						{
							value = ESpecialValue.BooleanFalse;
							return true;
						}
					}
				}
				else if (length != 14)
				{
					if (length == 15)
					{
						char c = name[3];
						if (c != '-')
						{
							if (c == 'u')
							{
								if (name == "___undefined___")
								{
									value = ESpecialValue.Undefined;
									return true;
								}
							}
						}
						else if (name == "___-Infinity___")
						{
							value = ESpecialValue.InfinityNegative;
							return true;
						}
					}
				}
				else if (name == "___Infinity___")
				{
					value = ESpecialValue.Infinity;
					return true;
				}
			}
			value = ESpecialValue.Undefined;
			return false;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000116FA File Offset: 0x0000F8FA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"___undefined___",
				"___NaN___",
				"___Infinity___",
				"___-Infinity___",
				"___BI___",
				"___1B___",
				"___0B___"
			};
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001173A File Offset: 0x0000F93A
		public static ESpecialValue[] GetValues()
		{
			return new ESpecialValue[]
			{
				ESpecialValue.Undefined,
				ESpecialValue.NaN,
				ESpecialValue.Infinity,
				ESpecialValue.InfinityNegative,
				ESpecialValue.BigInt,
				ESpecialValue.BooleanTrue,
				ESpecialValue.BooleanFalse
			};
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001174D File Offset: 0x0000F94D
		public static string[] GetNames()
		{
			return new string[]
			{
				"Undefined",
				"NaN",
				"Infinity",
				"InfinityNegative",
				"BigInt",
				"BooleanTrue",
				"BooleanFalse"
			};
		}
	}
}

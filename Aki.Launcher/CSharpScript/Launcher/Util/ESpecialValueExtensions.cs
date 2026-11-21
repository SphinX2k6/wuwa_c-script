using System;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200007D RID: 125
	public static class ESpecialValueExtensions
	{
		// Token: 0x0600034B RID: 843 RVA: 0x000123D0 File Offset: 0x000105D0
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

		// Token: 0x0600034C RID: 844 RVA: 0x00012448 File Offset: 0x00010648
		public static ESpecialValue FromString(string name)
		{
			ESpecialValue result;
			if (!ESpecialValueExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialValue 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00012474 File Offset: 0x00010674
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

		// Token: 0x0600034E RID: 846 RVA: 0x0001257E File Offset: 0x0001077E
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

		// Token: 0x0600034F RID: 847 RVA: 0x000125BE File Offset: 0x000107BE
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

		// Token: 0x06000350 RID: 848 RVA: 0x000125D1 File Offset: 0x000107D1
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

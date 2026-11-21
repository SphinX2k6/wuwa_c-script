using System;
using System.Globalization;

namespace System
{
	// Token: 0x020000C6 RID: 198
	internal static class AppContextConfigHelper
	{
		// Token: 0x0600095D RID: 2397 RVA: 0x0001D75C File Offset: 0x0001B95C
		internal static bool GetBooleanConfig(string switchName, bool defaultValue)
		{
			bool result;
			if (!AppContext.TryGetSwitch(switchName, out result))
			{
				return defaultValue;
			}
			return result;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0001D778 File Offset: 0x0001B978
		internal static bool GetBooleanConfig(string switchName, string envVariable, bool defaultValue = false)
		{
			string environmentVariable = Environment.GetEnvironmentVariable(envVariable);
			if (environmentVariable != null)
			{
				if (environmentVariable == "1" || bool.IsTrueStringIgnoreCase(environmentVariable))
				{
					return true;
				}
				if (environmentVariable == "0" || bool.IsFalseStringIgnoreCase(environmentVariable))
				{
					return false;
				}
			}
			return AppContextConfigHelper.GetBooleanConfig(switchName, defaultValue);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0001D7D0 File Offset: 0x0001B9D0
		internal static int GetInt32Config(string configName, int defaultValue, bool allowNegative = true)
		{
			int result;
			try
			{
				object data = AppContext.GetData(configName);
				int num = defaultValue;
				if (data is uint)
				{
					uint num2 = (uint)data;
					num = (int)num2;
				}
				else
				{
					string text = data as string;
					if (text == null)
					{
						IConvertible convertible = data as IConvertible;
						if (convertible != null)
						{
							num = convertible.ToInt32(NumberFormatInfo.InvariantInfo);
						}
					}
					else if (text.StartsWith('0'))
					{
						if (text.Length >= 2 && text[1] == 'x')
						{
							num = Convert.ToInt32(text, 16);
						}
						else
						{
							num = Convert.ToInt32(text, 8);
						}
					}
					else
					{
						num = int.Parse(text, NumberStyles.AllowLeadingSign, NumberFormatInfo.InvariantInfo);
					}
				}
				result = ((!allowNegative && num < 0) ? defaultValue : num);
			}
			catch (FormatException)
			{
				result = defaultValue;
			}
			catch (OverflowException)
			{
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0001D89C File Offset: 0x0001BA9C
		internal static int GetInt32Config(string configName, string envVariable, int defaultValue, bool allowNegative = true)
		{
			string environmentVariable = Environment.GetEnvironmentVariable(envVariable);
			if (environmentVariable != null)
			{
				try
				{
					int num;
					if (environmentVariable.StartsWith('0'))
					{
						if (environmentVariable.Length >= 2 && environmentVariable[1] == 'x')
						{
							num = Convert.ToInt32(environmentVariable, 16);
						}
						else
						{
							num = Convert.ToInt32(environmentVariable, 8);
						}
					}
					else
					{
						num = int.Parse(environmentVariable, NumberStyles.AllowLeadingSign, NumberFormatInfo.InvariantInfo);
					}
					if (allowNegative || num >= 0)
					{
						return num;
					}
				}
				catch (FormatException)
				{
				}
				catch (OverflowException)
				{
				}
			}
			return AppContextConfigHelper.GetInt32Config(configName, defaultValue, allowNegative);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0001D92C File Offset: 0x0001BB2C
		internal static short GetInt16Config(string configName, short defaultValue, bool allowNegative = true)
		{
			short result;
			try
			{
				object data = AppContext.GetData(configName);
				short num = defaultValue;
				if (data is uint)
				{
					uint num2 = (uint)data;
					num = (short)num2;
					if ((uint)num != num2)
					{
						return defaultValue;
					}
				}
				else
				{
					string text = data as string;
					if (text == null)
					{
						IConvertible convertible = data as IConvertible;
						if (convertible != null)
						{
							num = convertible.ToInt16(NumberFormatInfo.InvariantInfo);
						}
					}
					else if (text.StartsWith("0x"))
					{
						num = Convert.ToInt16(text, 16);
					}
					else if (text.StartsWith('0'))
					{
						num = Convert.ToInt16(text, 8);
					}
					else
					{
						num = short.Parse(text, NumberStyles.AllowLeadingSign, NumberFormatInfo.InvariantInfo);
					}
				}
				result = ((!allowNegative && num < 0) ? defaultValue : num);
			}
			catch (FormatException)
			{
				result = defaultValue;
			}
			catch (OverflowException)
			{
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0001D9F8 File Offset: 0x0001BBF8
		internal static short GetInt16Config(string configName, string envVariable, short defaultValue, bool allowNegative = true)
		{
			string environmentVariable = Environment.GetEnvironmentVariable(envVariable);
			if (environmentVariable != null)
			{
				try
				{
					short num;
					if (environmentVariable.StartsWith('0'))
					{
						if (environmentVariable.Length >= 2 && environmentVariable[1] == 'x')
						{
							num = Convert.ToInt16(environmentVariable, 16);
						}
						else
						{
							num = Convert.ToInt16(environmentVariable, 8);
						}
					}
					else
					{
						num = short.Parse(environmentVariable, NumberStyles.AllowLeadingSign, NumberFormatInfo.InvariantInfo);
					}
					if (allowNegative || num >= 0)
					{
						return num;
					}
				}
				catch (FormatException)
				{
				}
				catch (OverflowException)
				{
				}
			}
			return AppContextConfigHelper.GetInt16Config(configName, defaultValue, allowNegative);
		}
	}
}

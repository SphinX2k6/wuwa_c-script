using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

// Token: 0x02000103 RID: 259
[NullableContext(1)]
[Nullable(0)]
public static class StringUtils
{
	// Token: 0x06000A0A RID: 2570 RVA: 0x000325C8 File Offset: 0x000307C8
	public static string Format(string inString, [Nullable(new byte[]
	{
		1,
		2
	})] params string[] args)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		foreach (object obj in StringUtils.FormatRegexNew.Matches(inString))
		{
			Match match = (Match)obj;
			int num2 = int.Parse(match.Groups[1].Value);
			stringBuilder.Append(inString.Substring(num, match.Index - num));
			StringBuilder stringBuilder2 = stringBuilder;
			string value;
			if (num2 >= args.Length)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("{");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				defaultInterpolatedStringHandler.AppendLiteral("}");
				value = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else if ((value = args[num2]) == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("{");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				defaultInterpolatedStringHandler.AppendLiteral("}");
				value = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			stringBuilder2.Append(value);
			num = match.Index + match.Length;
		}
		stringBuilder.Append(inString.Substring(num));
		return stringBuilder.ToString();
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x000326FC File Offset: 0x000308FC
	public static string FormatStaticBuilder(string inString, params object[] args)
	{
		string[] array = StringUtils.FormatRegex.Split(inString);
		StringBuilder staticBuilder = StringUtils.StaticBuilder;
		staticBuilder.Clear();
		int i = 0;
		int num = array.Length;
		while (i < num)
		{
			staticBuilder.Append(array[i]);
			if (i != array.Length - 1)
			{
				StringBuilder stringBuilder = staticBuilder;
				string value;
				if (i >= args.Length)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("{");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i);
					defaultInterpolatedStringHandler.AppendLiteral("}");
					value = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					object obj = args[i];
					value = ((obj != null) ? obj.ToString() : null);
				}
				stringBuilder.Append(value);
			}
			i++;
		}
		return staticBuilder.ToString();
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00032798 File Offset: 0x00030998
	public static string Uint8ArrayToString(byte[] array)
	{
		List<string> list = new List<string>();
		int num = array.Length;
		int i = 0;
		while (i < num)
		{
			byte b = array[i++];
			switch (b >> 4)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			{
				List<string> list2 = list;
				char c = (char)b;
				list2.Add(c.ToString());
				break;
			}
			case 12:
			case 13:
			{
				byte b2 = array[i++];
				list.Add(((char)((int)(b & 31) << 6 | (int)(b2 & 63))).ToString());
				break;
			}
			case 14:
			{
				byte b2 = array[i++];
				byte b3 = array[i++];
				list.Add(((char)((int)(b & 15) << 12 | (int)(b2 & 63) << 6 | (int)(b3 & 63))).ToString());
				break;
			}
			}
		}
		return string.Join("", list);
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00032898 File Offset: 0x00030A98
	public static int GetStringRealCount(string src)
	{
		int num = 0;
		int length = src.Length;
		for (int i = 0; i < length; i++)
		{
			int num2 = (int)src[i];
			if (num2 >= 0 && num2 <= 128)
			{
				num++;
			}
			else
			{
				num += 2;
			}
		}
		return num;
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x000328DB File Offset: 0x00030ADB
	[NullableContext(2)]
	public static bool IsEmpty([NotNullWhen(false)] string content)
	{
		return string.IsNullOrEmpty(content);
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x000328E3 File Offset: 0x00030AE3
	public static string ParseTabAndLine(string content)
	{
		return content.Replace("\\n", "\n").Replace("\\r", "").Replace("\\t", "\t");
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00032914 File Offset: 0x00030B14
	public static bool IsIpAddress(string serverIp)
	{
		string pattern = "((\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.){3}(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])";
		return Regex.IsMatch(serverIp, pattern);
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x0003292E File Offset: 0x00030B2E
	[NullableContext(2)]
	public static bool IsBlank(string content)
	{
		return string.IsNullOrWhiteSpace(content);
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00032936 File Offset: 0x00030B36
	public static bool IsNothing(string content)
	{
		return StringUtils.IsEmpty(content) || content == "None";
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00032950 File Offset: 0x00030B50
	public static List<List<string>> ParseCsvContent(string content)
	{
		string text = "";
		List<string> list = new List<string>
		{
			""
		};
		List<List<string>> list2 = new List<List<string>>();
		list2.Add(list);
		int num = 0;
		int num2 = 0;
		bool flag = true;
		foreach (char c in content.StartsWith("﻿") ? content.Replace("﻿", "") : content)
		{
			if (c == '"')
			{
				if (flag && c.ToString() == text)
				{
					List<string> list3 = list;
					int num3 = num;
					List<string> list4 = list3;
					int index = num3;
					ReadOnlySpan<char> str = list3[num3];
					char c2 = c;
					list4[index] = str + new ReadOnlySpan<char>(ref c2);
				}
				flag = !flag;
			}
			else if (c == ',' && flag)
			{
				list.Add("");
				num++;
				c = '\0';
			}
			else if (c == '\n' && flag)
			{
				if (text == "\r")
				{
					list[num] = list[num].Substring(0, list[num].Length - 1);
				}
				List<string> list5 = new List<string>();
				char c2;
				c = (c2 = '\0');
				list5.Add(c2.ToString());
				list = list5;
				list2.Add(list);
				num2++;
				num = 0;
			}
			else
			{
				List<string> list3 = list;
				int num3 = num;
				List<string> list6 = list3;
				int index2 = num3;
				ReadOnlySpan<char> str2 = list3[num3];
				char c2 = c;
				list6[index2] = str2 + new ReadOnlySpan<char>(ref c2);
			}
			text = c.ToString();
		}
		List<string> list7 = list2[list2.Count - 1];
		if (list7.Count == 1 && list7[0] == "")
		{
			list2.RemoveAt(list2.Count - 1);
		}
		return list2;
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00032B1C File Offset: 0x00030D1C
	public static bool CheckIsOnlyLettersAndNumbers(string content)
	{
		return Regex.IsMatch(content, "^[A-Za-z0-9]*$");
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00032B29 File Offset: 0x00030D29
	public static bool CheckIsOnlyBlank(string content)
	{
		return Regex.IsMatch(content, "^\\s*$");
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00032B38 File Offset: 0x00030D38
	public static Dictionary<string, string> ParseCSVStringToMap(string content)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string[] array = content.Split(',', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(':', StringSplitOptions.None);
			if (array2.Length == 2)
			{
				string text = array2[0];
				string value = array2[1];
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(value))
				{
					dictionary[text] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x04000678 RID: 1656
	public const string ZERO_STRING = "0";

	// Token: 0x04000679 RID: 1657
	public const string ONE_STRING = "1";

	// Token: 0x0400067A RID: 1658
	public const string EMPTY_STRING = "";

	// Token: 0x0400067B RID: 1659
	public const string LINE_BREAK_STRING = "\n";

	// Token: 0x0400067C RID: 1660
	public const string TAB_STRING = "\t";

	// Token: 0x0400067D RID: 1661
	public const string SLASH_STRING = "/";

	// Token: 0x0400067E RID: 1662
	public const string SPEED_STRING = "/s";

	// Token: 0x0400067F RID: 1663
	public const string NONE_STRING = "None";

	// Token: 0x04000680 RID: 1664
	public const string EQUAL = "=";

	// Token: 0x04000681 RID: 1665
	public const string NOT_EQUAL = "!=";

	// Token: 0x04000682 RID: 1666
	public const string LESS_THAN = "<";

	// Token: 0x04000683 RID: 1667
	public const string LESS_EQUAL_THAN = "<=";

	// Token: 0x04000684 RID: 1668
	public const string GRATHER_THAN = ">";

	// Token: 0x04000685 RID: 1669
	public const string GRATHER_EQUAL_THAN = ">=";

	// Token: 0x04000686 RID: 1670
	private const string REG_PATTERN = "{[0-9]+}";

	// Token: 0x04000687 RID: 1671
	private const string REG_FLAGS = "g";

	// Token: 0x04000688 RID: 1672
	private const string UTF8_BOM_HEAD = "﻿";

	// Token: 0x04000689 RID: 1673
	[StaticVariableRuleIgnore]
	private static readonly Regex FormatRegex = new Regex("{[0-9]+}", RegexOptions.None);

	// Token: 0x0400068A RID: 1674
	[StaticVariableRuleIgnore]
	private static readonly StringBuilder StaticBuilder = new StringBuilder();

	// Token: 0x0400068B RID: 1675
	[StaticVariableRuleIgnore]
	private static readonly Regex FormatRegexNew = new Regex("\\{(\\d+)\\}", RegexOptions.None);
}

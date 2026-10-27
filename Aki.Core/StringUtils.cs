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
	// Token: 0x060009B9 RID: 2489 RVA: 0x00031C6C File Offset: 0x0002FE6C
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

	// Token: 0x060009BA RID: 2490 RVA: 0x00031DA0 File Offset: 0x0002FFA0
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

	// Token: 0x060009BB RID: 2491 RVA: 0x00031E3C File Offset: 0x0003003C
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

	// Token: 0x060009BC RID: 2492 RVA: 0x00031F3C File Offset: 0x0003013C
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

	// Token: 0x060009BD RID: 2493 RVA: 0x00031F7F File Offset: 0x0003017F
	[NullableContext(2)]
	public static bool IsEmpty([NotNullWhen(false)] string content)
	{
		return string.IsNullOrEmpty(content);
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00031F87 File Offset: 0x00030187
	public static string ParseTabAndLine(string content)
	{
		return content.Replace("\\n", "\n").Replace("\\r", "").Replace("\\t", "\t");
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00031FB8 File Offset: 0x000301B8
	public static bool IsIpAddress(string serverIp)
	{
		string pattern = "((\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.){3}(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])";
		return Regex.IsMatch(serverIp, pattern);
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00031FD2 File Offset: 0x000301D2
	[NullableContext(2)]
	public static bool IsBlank(string content)
	{
		return string.IsNullOrWhiteSpace(content);
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00031FDA File Offset: 0x000301DA
	public static bool IsNothing(string content)
	{
		return StringUtils.IsEmpty(content) || content == "None";
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00031FF4 File Offset: 0x000301F4
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

	// Token: 0x060009C3 RID: 2499 RVA: 0x000321C0 File Offset: 0x000303C0
	public static bool CheckIsOnlyLettersAndNumbers(string content)
	{
		return Regex.IsMatch(content, "^[A-Za-z0-9]*$");
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x000321CD File Offset: 0x000303CD
	public static bool CheckIsOnlyBlank(string content)
	{
		return Regex.IsMatch(content, "^\\s*$");
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x000321DC File Offset: 0x000303DC
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

	// Token: 0x0400066D RID: 1645
	public const string ZERO_STRING = "0";

	// Token: 0x0400066E RID: 1646
	public const string ONE_STRING = "1";

	// Token: 0x0400066F RID: 1647
	public const string EMPTY_STRING = "";

	// Token: 0x04000670 RID: 1648
	public const string LINE_BREAK_STRING = "\n";

	// Token: 0x04000671 RID: 1649
	public const string TAB_STRING = "\t";

	// Token: 0x04000672 RID: 1650
	public const string SLASH_STRING = "/";

	// Token: 0x04000673 RID: 1651
	public const string SPEED_STRING = "/s";

	// Token: 0x04000674 RID: 1652
	public const string NONE_STRING = "None";

	// Token: 0x04000675 RID: 1653
	public const string EQUAL = "=";

	// Token: 0x04000676 RID: 1654
	public const string NOT_EQUAL = "!=";

	// Token: 0x04000677 RID: 1655
	public const string LESS_THAN = "<";

	// Token: 0x04000678 RID: 1656
	public const string LESS_EQUAL_THAN = "<=";

	// Token: 0x04000679 RID: 1657
	public const string GRATHER_THAN = ">";

	// Token: 0x0400067A RID: 1658
	public const string GRATHER_EQUAL_THAN = ">=";

	// Token: 0x0400067B RID: 1659
	private const string REG_PATTERN = "{[0-9]+}";

	// Token: 0x0400067C RID: 1660
	private const string REG_FLAGS = "g";

	// Token: 0x0400067D RID: 1661
	private const string UTF8_BOM_HEAD = "﻿";

	// Token: 0x0400067E RID: 1662
	[StaticVariableRuleIgnore]
	private static readonly Regex FormatRegex = new Regex("{[0-9]+}", RegexOptions.None);

	// Token: 0x0400067F RID: 1663
	[StaticVariableRuleIgnore]
	private static readonly StringBuilder StaticBuilder = new StringBuilder();

	// Token: 0x04000680 RID: 1664
	[StaticVariableRuleIgnore]
	private static readonly Regex FormatRegexNew = new Regex("\\{(\\d+)\\}", RegexOptions.None);
}

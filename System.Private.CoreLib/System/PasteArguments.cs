using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	// Token: 0x0200018E RID: 398
	internal static class PasteArguments
	{
		// Token: 0x06001A0D RID: 6669 RVA: 0x0005551C File Offset: 0x0005371C
		internal static void AppendArgument(ref ValueStringBuilder stringBuilder, string argument)
		{
			if (stringBuilder.Length != 0)
			{
				stringBuilder.Append(' ');
			}
			if (argument.Length != 0 && PasteArguments.ContainsNoWhitespaceOrQuotes(argument))
			{
				stringBuilder.Append(argument);
				return;
			}
			stringBuilder.Append('"');
			int i = 0;
			while (i < argument.Length)
			{
				char c = argument[i++];
				if (c == '\\')
				{
					int num = 1;
					while (i < argument.Length && argument[i] == '\\')
					{
						i++;
						num++;
					}
					if (i == argument.Length)
					{
						stringBuilder.Append('\\', num * 2);
					}
					else if (argument[i] == '"')
					{
						stringBuilder.Append('\\', num * 2 + 1);
						stringBuilder.Append('"');
						i++;
					}
					else
					{
						stringBuilder.Append('\\', num);
					}
				}
				else if (c == '"')
				{
					stringBuilder.Append('\\');
					stringBuilder.Append('"');
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			stringBuilder.Append('"');
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0005560C File Offset: 0x0005380C
		private static bool ContainsNoWhitespaceOrQuotes(string s)
		{
			foreach (char c in s)
			{
				if (char.IsWhiteSpace(c) || c == '"')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00055644 File Offset: 0x00053844
		internal unsafe static string Paste(IEnumerable<string> arguments, bool pasteFirstArgumentUsingArgV0Rules)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			foreach (string text in arguments)
			{
				if (pasteFirstArgumentUsingArgV0Rules)
				{
					pasteFirstArgumentUsingArgV0Rules = false;
					bool flag = false;
					foreach (char c in text)
					{
						if (c == '"')
						{
							throw new ApplicationException(SR.Argv_IncludeDoubleQuote);
						}
						if (char.IsWhiteSpace(c))
						{
							flag = true;
						}
					}
					if (text.Length == 0 || flag)
					{
						valueStringBuilder.Append('"');
						valueStringBuilder.Append(text);
						valueStringBuilder.Append('"');
					}
					else
					{
						valueStringBuilder.Append(text);
					}
				}
				else
				{
					PasteArguments.AppendArgument(ref valueStringBuilder, text);
				}
			}
			return valueStringBuilder.ToString();
		}
	}
}

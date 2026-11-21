using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Reflection.Metadata
{
	// Token: 0x02000798 RID: 1944
	internal static class TypeNameParserHelpers
	{
		// Token: 0x06007BBF RID: 31679 RVA: 0x00123E6C File Offset: 0x0012206C
		internal unsafe static string GetGenericTypeFullName(ReadOnlySpan<char> fullTypeName, ReadOnlySpan<TypeName> genericArgs)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.Append(fullTypeName);
			valueStringBuilder.Append('[');
			ReadOnlySpan<TypeName> readOnlySpan = genericArgs;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				TypeName typeName = *readOnlySpan[i];
				valueStringBuilder.Append('[');
				valueStringBuilder.Append(typeName.AssemblyQualifiedName);
				valueStringBuilder.Append(']');
				valueStringBuilder.Append(',');
			}
			*valueStringBuilder[valueStringBuilder.Length - 1] = ']';
			return valueStringBuilder.ToString();
		}

		// Token: 0x06007BC0 RID: 31680 RVA: 0x00123F10 File Offset: 0x00122110
		internal unsafe static int GetFullTypeNameLength(ReadOnlySpan<char> input, out bool isNestedType)
		{
			isNestedType = false;
			int num = input.IndexOfAny(TypeNameParserHelpers.s_endOfFullTypeNameDelimitersSearchValues);
			if (num < 0)
			{
				return input.Length;
			}
			if (*input[num] == 92)
			{
				num = TypeNameParserHelpers.<GetFullTypeNameLength>g__GetUnescapedOffset|6_0(input, num);
			}
			isNestedType = (num > 0 && num < input.Length && *input[num] == 43);
			return num;
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x00123F70 File Offset: 0x00122170
		internal unsafe static ReadOnlySpan<char> GetName(ReadOnlySpan<char> fullName)
		{
			int num = fullName.LastIndexOfAny('.', '+');
			if (num > 0 && *fullName[num - 1] == 92)
			{
				num = TypeNameParserHelpers.<GetName>g__GetUnescapedOffset|7_0(fullName, num);
			}
			if (num >= 0)
			{
				return fullName.Slice(num + 1);
			}
			return fullName;
		}

		// Token: 0x06007BC2 RID: 31682 RVA: 0x00123FB4 File Offset: 0x001221B4
		internal unsafe static ReadOnlySpan<char> GetAssemblyNameCandidate(ReadOnlySpan<char> input)
		{
			int num = input.IndexOf(']');
			if (num > 0 && *input[num - 1] == 92)
			{
				num = TypeNameParserHelpers.<GetAssemblyNameCandidate>g__GetUnescapedOffset|8_0(input, num);
			}
			if (num >= 0)
			{
				return input.Slice(0, num);
			}
			return input;
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x00123FF4 File Offset: 0x001221F4
		internal static string GetRankOrModifierStringRepresentation(int rankOrModifier, ref ValueStringBuilder builder)
		{
			if (rankOrModifier == -3)
			{
				builder.Append('&');
			}
			else if (rankOrModifier == -2)
			{
				builder.Append('*');
			}
			else if (rankOrModifier == -1)
			{
				builder.Append("[]");
			}
			else if (rankOrModifier == 1)
			{
				builder.Append("[*]");
			}
			else
			{
				builder.Append('[');
				builder.Append(',', rankOrModifier - 1);
				builder.Append(']');
			}
			return builder.ToString();
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x00124068 File Offset: 0x00122268
		internal unsafe static bool IsBeginningOfGenericArgs(ref ReadOnlySpan<char> span, out bool doubleBrackets)
		{
			doubleBrackets = false;
			if (!span.IsEmpty && *span[0] == 91)
			{
				ReadOnlySpan<char> readOnlySpan = span.Slice(1).TrimStart();
				if (!readOnlySpan.IsEmpty)
				{
					if (*readOnlySpan[0] == 91)
					{
						doubleBrackets = true;
						span = readOnlySpan.Slice(1).TrimStart();
						return true;
					}
					char c = (char)(*readOnlySpan[0]);
					if (c != '*' && c != ',' && c != ']')
					{
						span = readOnlySpan;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x001240F4 File Offset: 0x001222F4
		internal unsafe static bool TryGetTypeNameInfo(TypeNameParseOptions options, ref ReadOnlySpan<char> input, ref List<int> nestedNameLengths, ref int recursiveDepth, out int totalLength)
		{
			totalLength = 0;
			for (;;)
			{
				bool flag;
				int num = TypeNameParserHelpers.GetFullTypeNameLength(input.Slice(totalLength), out flag);
				if (num <= 0)
				{
					break;
				}
				if (num > 1 && *input[0] == 46 && input.Slice(0, num).LastIndexOf('.') == 0)
				{
					input = input.Slice(1);
					num--;
				}
				if (flag)
				{
					if (!TypeNameParserHelpers.TryDive(options, ref recursiveDepth))
					{
						return false;
					}
					List<int> list;
					if ((list = nestedNameLengths) == null)
					{
						List<int> list2;
						nestedNameLengths = (list2 = new List<int>());
						list = list2;
					}
					list.Add(num);
					totalLength++;
				}
				totalLength += num;
				if (!flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x00124188 File Offset: 0x00122388
		internal static bool TryParseNextDecorator(ref ReadOnlySpan<char> input, out int rankOrModifier)
		{
			ReadOnlySpan<char> readOnlySpan = input;
			if (TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref input, '*'))
			{
				rankOrModifier = -2;
				return true;
			}
			if (TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref input, '&'))
			{
				rankOrModifier = -3;
				return true;
			}
			checked
			{
				if (TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref input, '['))
				{
					int num = 1;
					bool flag = false;
					while (!TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref input, ']'))
					{
						if (flag)
						{
							goto IL_73;
						}
						if (num == 1 && TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref input, '*'))
						{
							flag = true;
						}
						else
						{
							if (!TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref input, ','))
							{
								goto IL_73;
							}
							num++;
						}
					}
					rankOrModifier = ((num == 1 && !flag) ? -1 : num);
					return true;
				}
				IL_73:
				input = readOnlySpan;
				rankOrModifier = 0;
				return false;
			}
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x00124213 File Offset: 0x00122413
		internal unsafe static bool TryStripFirstCharAndTrailingSpaces(ref ReadOnlySpan<char> span, char value)
		{
			if (!span.IsEmpty && *span[0] == (ushort)value)
			{
				span = span.Slice(1).TrimStart();
				return true;
			}
			return false;
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x00124240 File Offset: 0x00122440
		[DoesNotReturn]
		internal static void ThrowArgumentException_InvalidTypeName(int errorIndex)
		{
			string argument_InvalidTypeName = SR.Argument_InvalidTypeName;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("typeName@");
			defaultInterpolatedStringHandler.AppendFormatted<int>(errorIndex);
			throw new ArgumentException(argument_InvalidTypeName, defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x00066B61 File Offset: 0x00064D61
		[DoesNotReturn]
		internal static void ThrowInvalidOperation_NotGenericType()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x00066B61 File Offset: 0x00064D61
		[DoesNotReturn]
		internal static void ThrowInvalidOperation_NotNestedType()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x00066B61 File Offset: 0x00064D61
		[DoesNotReturn]
		internal static void ThrowInvalidOperation_NoElement()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x00066B61 File Offset: 0x00064D61
		[DoesNotReturn]
		internal static void ThrowInvalidOperation_HasToBeArrayClass()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06007BCD RID: 31693 RVA: 0x00007B65 File Offset: 0x00005D65
		internal static bool IsMaxDepthExceeded(TypeNameParseOptions options, int depth)
		{
			return false;
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x0012427C File Offset: 0x0012247C
		internal static bool TryDive(TypeNameParseOptions options, ref int depth)
		{
			depth++;
			return !TypeNameParserHelpers.IsMaxDepthExceeded(options, depth);
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x001242A8 File Offset: 0x001224A8
		[CompilerGenerated]
		internal unsafe static int <GetFullTypeNameLength>g__GetUnescapedOffset|6_0(ReadOnlySpan<char> input, int startOffset)
		{
			int i;
			for (i = startOffset; i < input.Length; i++)
			{
				char c = (char)(*input[i]);
				if (c == '\\')
				{
					i++;
					if (i == input.Length || !TypeNameParserHelpers.<GetFullTypeNameLength>g__NeedsEscaping|6_1((char)(*input[i])))
					{
						return -1;
					}
				}
				else if (TypeNameParserHelpers.<GetFullTypeNameLength>g__NeedsEscaping|6_1(c))
				{
					break;
				}
			}
			return i;
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x00124300 File Offset: 0x00122500
		[CompilerGenerated]
		internal static bool <GetFullTypeNameLength>g__NeedsEscaping|6_1(char c)
		{
			switch (c)
			{
			case '&':
			case '*':
			case '+':
			case ',':
				break;
			case '\'':
			case '(':
			case ')':
				goto IL_40;
			default:
				switch (c)
				{
				case '[':
				case '\\':
				case ']':
					break;
				default:
					goto IL_40;
				}
				break;
			}
			return true;
			IL_40:
			return false;
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x00124350 File Offset: 0x00122550
		[CompilerGenerated]
		internal unsafe static int <GetName>g__GetUnescapedOffset|7_0(ReadOnlySpan<char> fullName, int startIndex)
		{
			int i;
			for (i = startIndex; i >= 0; i--)
			{
				char c = (char)(*fullName[i]);
				bool flag = c == '+' || c == '.';
				if (flag)
				{
					if (i == 0 || *fullName[i - 1] != 92)
					{
						break;
					}
					i--;
				}
			}
			return i;
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x001243A0 File Offset: 0x001225A0
		[CompilerGenerated]
		internal unsafe static int <GetAssemblyNameCandidate>g__GetUnescapedOffset|8_0(ReadOnlySpan<char> input, int startIndex)
		{
			int num = startIndex;
			while (num < input.Length && (*input[num] != 93 || *input[num - 1] == 92))
			{
				num++;
			}
			return num;
		}

		// Token: 0x04001782 RID: 6018
		private static readonly SearchValues<char> s_endOfFullTypeNameDelimitersSearchValues = SearchValues.Create("[]&*,+\\");
	}
}

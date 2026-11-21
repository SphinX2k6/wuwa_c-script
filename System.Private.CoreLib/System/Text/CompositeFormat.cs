using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000213 RID: 531
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("{Format}")]
	public sealed class CompositeFormat
	{
		// Token: 0x06002946 RID: 10566 RVA: 0x00080EB4 File Offset: 0x0007F0B4
		private CompositeFormat(string format, [TupleElementNames(new string[]
		{
			"Literal",
			"ArgIndex",
			"Alignment",
			"Format"
		})] ValueTuple<string, int, int, string>[] segments)
		{
			this.Format = format;
			this._segments = segments;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (ValueTuple<string, int, int, string> valueTuple in segments)
			{
				string item = valueTuple.Item1;
				if (item != null)
				{
					num += item.Length;
				}
				else if (valueTuple.Item2 >= 0)
				{
					num2++;
					num3 = Math.Max(num3, valueTuple.Item2 + 1);
				}
			}
			this._literalLength = num;
			this._formattedCount = num2;
			this._argsRequired = num3;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00080F48 File Offset: 0x0007F148
		public static CompositeFormat Parse([StringSyntax("CompositeFormat")] string format)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			List<ValueTuple<string, int, int, string>> list = new List<ValueTuple<string, int, int, string>>();
			int offset = 0;
			ExceptionResource resource = ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual;
			if (!CompositeFormat.TryParseLiterals(format, list, ref offset, ref resource))
			{
				ThrowHelper.ThrowFormatInvalidString(offset, resource);
			}
			return new CompositeFormat(format, list.ToArray());
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x00080F8F File Offset: 0x0007F18F
		public string Format { get; }

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x00080F97 File Offset: 0x0007F197
		public int MinimumArgumentCount
		{
			get
			{
				return this._argsRequired;
			}
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00080F9F File Offset: 0x0007F19F
		internal void ValidateNumberOfArgs(int numArgs)
		{
			if (numArgs < this._argsRequired)
			{
				ThrowHelper.ThrowFormatIndexOutOfRange();
			}
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00080FB0 File Offset: 0x0007F1B0
		private unsafe static bool TryParseLiterals(ReadOnlySpan<char> format, [TupleElementNames(new string[]
		{
			"Literal",
			"ArgIndex",
			"Alignment",
			"Format"
		})] List<ValueTuple<string, int, int, string>> segments, ref int failureOffset, ref ExceptionResource failureReason)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			int num = 0;
			ReadOnlySpan<char> readOnlySpan;
			for (;;)
			{
				readOnlySpan = format.Slice(num);
				int num2 = readOnlySpan.IndexOfAny('{', '}');
				if (num2 < 0)
				{
					break;
				}
				valueStringBuilder.Append(readOnlySpan.Slice(0, num2));
				num += num2;
				char c = (char)(*format[num]);
				char c2;
				if (!CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
				{
					goto IL_238;
				}
				if (c == c2)
				{
					valueStringBuilder.Append(c2);
					num++;
				}
				else
				{
					if (c != '{')
					{
						goto IL_22F;
					}
					segments.Add(new ValueTuple<string, int, int, string>(valueStringBuilder.ToString(), -1, 0, null));
					valueStringBuilder.Length = 0;
					int num3 = 0;
					string item = null;
					int num4 = (int)(c2 - '0');
					if (num4 >= 10)
					{
						goto IL_241;
					}
					if (!CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
					{
						goto IL_238;
					}
					if (c2 != '}')
					{
						while (char.IsAsciiDigit(c2))
						{
							num4 = num4 * 10 + (int)c2 - 48;
							if (!CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
							{
								goto IL_238;
							}
						}
						while (c2 == ' ')
						{
							if (!CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
							{
								goto IL_238;
							}
						}
						if (c2 == ',')
						{
							while (CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
							{
								if (c2 != ' ')
								{
									int num5 = 1;
									if (c2 == '-')
									{
										num5 = -1;
										if (!CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
										{
											break;
										}
									}
									num3 = (int)(c2 - '0');
									if (num3 >= 10)
									{
										goto IL_241;
									}
									if (!CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
									{
										break;
									}
									while (char.IsAsciiDigit(c2))
									{
										num3 = num3 * 10 + (int)c2 - 48;
										if (!CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
										{
											goto IL_238;
										}
									}
									num3 *= num5;
									while (c2 == ' ')
									{
										if (!CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
										{
											goto IL_238;
										}
									}
									goto IL_1CB;
								}
							}
							goto IL_238;
						}
						IL_1CB:
						if (c2 != '}')
						{
							if (c2 == ':')
							{
								int num6 = num;
								while (CompositeFormat.<TryParseLiterals>g__TryMoveNext|12_0(format, ref num, out c2))
								{
									if (c2 == '}')
									{
										num6++;
										item = format.Slice(num6, num - num6).ToString();
										goto IL_214;
									}
									if (c2 == '{')
									{
										break;
									}
								}
								goto IL_238;
							}
							goto IL_238;
						}
					}
					IL_214:
					num++;
					segments.Add(new ValueTuple<string, int, int, string>(null, num4, num3, item));
				}
			}
			valueStringBuilder.Append(readOnlySpan);
			segments.Add(new ValueTuple<string, int, int, string>(valueStringBuilder.ToString(), -1, 0, null));
			return true;
			goto IL_238;
			IL_22F:
			failureReason = ExceptionResource.Format_UnexpectedClosingBrace;
			failureOffset = num;
			return false;
			IL_238:
			failureReason = ExceptionResource.Format_UnclosedFormatItem;
			failureOffset = num;
			return false;
			IL_241:
			failureReason = ExceptionResource.Format_ExpectedAsciiDigit;
			failureOffset = num;
			return false;
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00081206 File Offset: 0x0007F406
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static bool <TryParseLiterals>g__TryMoveNext|12_0(ReadOnlySpan<char> format, ref int pos, out char nextChar)
		{
			pos++;
			if (pos >= format.Length)
			{
				nextChar = '\0';
				return false;
			}
			nextChar = (char)(*format[pos]);
			return true;
		}

		// Token: 0x04000730 RID: 1840
		[TupleElementNames(new string[]
		{
			"Literal",
			"ArgIndex",
			"Alignment",
			"Format"
		})]
		internal readonly ValueTuple<string, int, int, string>[] _segments;

		// Token: 0x04000731 RID: 1841
		internal readonly int _literalLength;

		// Token: 0x04000732 RID: 1842
		internal readonly int _formattedCount;

		// Token: 0x04000733 RID: 1843
		internal readonly int _argsRequired;
	}
}

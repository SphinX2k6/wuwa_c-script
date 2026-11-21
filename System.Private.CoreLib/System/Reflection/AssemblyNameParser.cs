using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Reflection
{
	// Token: 0x0200078B RID: 1931
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct AssemblyNameParser
	{
		// Token: 0x06007B7D RID: 31613 RVA: 0x001228B3 File Offset: 0x00120AB3
		private AssemblyNameParser(ReadOnlySpan<char> input)
		{
			if (input.Length == 0)
			{
				throw new ArgumentException(SR.Format_StringZeroLength);
			}
			this._input = input;
			this._index = 0;
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x001228D7 File Offset: 0x00120AD7
		public static AssemblyNameParser.AssemblyNameParts Parse(string name)
		{
			return AssemblyNameParser.Parse(name.AsSpan());
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x001228E4 File Offset: 0x00120AE4
		public static AssemblyNameParser.AssemblyNameParts Parse(ReadOnlySpan<char> name)
		{
			AssemblyNameParser assemblyNameParser = new AssemblyNameParser(name);
			AssemblyNameParser.AssemblyNameParts result = default(AssemblyNameParser.AssemblyNameParts);
			if (assemblyNameParser.TryParse(ref result))
			{
				return result;
			}
			throw new FileLoadException(SR.InvalidAssemblyName, name.ToString());
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x00122928 File Offset: 0x00120B28
		internal static bool TryParse(ReadOnlySpan<char> name, ref AssemblyNameParser.AssemblyNameParts parts)
		{
			AssemblyNameParser assemblyNameParser = new AssemblyNameParser(name);
			return assemblyNameParser.TryParse(ref parts);
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x00122945 File Offset: 0x00120B45
		private static bool TryRecordNewSeen([ScopedRef] ref AssemblyNameParser.AttributeKind seenAttributes, AssemblyNameParser.AttributeKind newAttribute)
		{
			if ((seenAttributes & newAttribute) != (AssemblyNameParser.AttributeKind)0)
			{
				return false;
			}
			seenAttributes |= newAttribute;
			return true;
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x00122958 File Offset: 0x00120B58
		private bool TryParse(ref AssemblyNameParser.AssemblyNameParts result)
		{
			string text;
			AssemblyNameParser.Token token;
			if (!this.TryGetNextToken(out text, out token) || token != AssemblyNameParser.Token.String || string.IsNullOrEmpty(text))
			{
				return false;
			}
			Version version = null;
			string cultureName = null;
			byte[] publicKeyOrToken = null;
			AssemblyNameFlags assemblyNameFlags = AssemblyNameFlags.None;
			AssemblyNameParser.AttributeKind attributeKind = (AssemblyNameParser.AttributeKind)0;
			string text2;
			if (!this.TryGetNextToken(out text2, out token))
			{
				return false;
			}
			while (token != AssemblyNameParser.Token.End)
			{
				if (token != AssemblyNameParser.Token.Comma)
				{
					return false;
				}
				string text3;
				if (!this.TryGetNextToken(out text3, out token) || token != AssemblyNameParser.Token.String)
				{
					return false;
				}
				if (!this.TryGetNextToken(out text2, out token) || token != AssemblyNameParser.Token.Equals)
				{
					return false;
				}
				string text4;
				if (!this.TryGetNextToken(out text4, out token) || token != AssemblyNameParser.Token.String)
				{
					return false;
				}
				if (text3 == string.Empty)
				{
					return false;
				}
				if (AssemblyNameParser.IsAttribute(text3, "Version"))
				{
					if (!AssemblyNameParser.TryRecordNewSeen(ref attributeKind, AssemblyNameParser.AttributeKind.Version))
					{
						return false;
					}
					if (!AssemblyNameParser.TryParseVersion(text4, ref version))
					{
						return false;
					}
				}
				else if (AssemblyNameParser.IsAttribute(text3, "Culture"))
				{
					if (!AssemblyNameParser.TryRecordNewSeen(ref attributeKind, AssemblyNameParser.AttributeKind.Culture))
					{
						return false;
					}
					if (!AssemblyNameParser.TryParseCulture(text4, out cultureName))
					{
						return false;
					}
				}
				else if (AssemblyNameParser.IsAttribute(text3, "PublicKeyToken"))
				{
					if (!AssemblyNameParser.TryRecordNewSeen(ref attributeKind, AssemblyNameParser.AttributeKind.PublicKeyOrToken))
					{
						return false;
					}
					if (!AssemblyNameParser.TryParsePKT(text4, true, out publicKeyOrToken))
					{
						return false;
					}
				}
				else if (AssemblyNameParser.IsAttribute(text3, "PublicKey"))
				{
					if (!AssemblyNameParser.TryRecordNewSeen(ref attributeKind, AssemblyNameParser.AttributeKind.PublicKeyOrToken))
					{
						return false;
					}
					if (!AssemblyNameParser.TryParsePKT(text4, false, out publicKeyOrToken))
					{
						return false;
					}
					assemblyNameFlags |= AssemblyNameFlags.PublicKey;
				}
				else if (AssemblyNameParser.IsAttribute(text3, "ProcessorArchitecture"))
				{
					if (!AssemblyNameParser.TryRecordNewSeen(ref attributeKind, AssemblyNameParser.AttributeKind.ProcessorArchitecture))
					{
						return false;
					}
					ProcessorArchitecture processorArchitecture;
					if (!AssemblyNameParser.TryParseProcessorArchitecture(text4, out processorArchitecture))
					{
						return false;
					}
					assemblyNameFlags |= (AssemblyNameFlags)(processorArchitecture << 4);
				}
				else if (AssemblyNameParser.IsAttribute(text3, "Retargetable"))
				{
					if (!AssemblyNameParser.TryRecordNewSeen(ref attributeKind, AssemblyNameParser.AttributeKind.Retargetable))
					{
						return false;
					}
					if (text4.Equals("Yes", StringComparison.OrdinalIgnoreCase))
					{
						assemblyNameFlags |= AssemblyNameFlags.Retargetable;
					}
					else if (!text4.Equals("No", StringComparison.OrdinalIgnoreCase))
					{
						return false;
					}
				}
				else if (AssemblyNameParser.IsAttribute(text3, "ContentType"))
				{
					if (!AssemblyNameParser.TryRecordNewSeen(ref attributeKind, AssemblyNameParser.AttributeKind.ContentType))
					{
						return false;
					}
					if (!text4.Equals("WindowsRuntime", StringComparison.OrdinalIgnoreCase))
					{
						return false;
					}
					assemblyNameFlags |= (AssemblyNameFlags)512;
				}
				if (!this.TryGetNextToken(out text2, out token))
				{
					return false;
				}
			}
			result = new AssemblyNameParser.AssemblyNameParts(text, version, cultureName, assemblyNameFlags, publicKeyOrToken);
			return true;
		}

		// Token: 0x06007B83 RID: 31619 RVA: 0x00122B74 File Offset: 0x00120D74
		private static bool IsAttribute(string candidate, string attributeKind)
		{
			return candidate.Equals(attributeKind, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06007B84 RID: 31620 RVA: 0x00122B80 File Offset: 0x00120D80
		private unsafe static bool TryParseVersion(string attributeValue, ref Version version)
		{
			ReadOnlySpan<char> source = attributeValue;
			Span<Range> destination = new Span<Range>(stackalloc byte[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(Range))], 5);
			destination = destination.Slice(0, source.Split(destination, '.', StringSplitOptions.None));
			int length = destination.Length;
			bool flag = length < 2 || length > 4;
			if (flag)
			{
				return false;
			}
			<>y__InlineArray4<ushort> <>y__InlineArray = default(<>y__InlineArray4<ushort>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ushort>, ushort>(ref <>y__InlineArray, 0) = ushort.MaxValue;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ushort>, ushort>(ref <>y__InlineArray, 1) = ushort.MaxValue;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ushort>, ushort>(ref <>y__InlineArray, 2) = ushort.MaxValue;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ushort>, ushort>(ref <>y__InlineArray, 3) = ushort.MaxValue;
			Span<ushort> span = <PrivateImplementationDetails>.InlineArrayAsSpan<<>y__InlineArray4<ushort>, ushort>(ref <>y__InlineArray, 4);
			for (int i = 0; i < destination.Length; i++)
			{
				Range range = *destination[i];
				length = source.Length;
				int offset = range.Start.GetOffset(length);
				int length2 = range.End.GetOffset(length) - offset;
				if (!ushort.TryParse(source.Slice(offset, length2), NumberStyles.None, NumberFormatInfo.InvariantInfo, span[i]))
				{
					return false;
				}
			}
			if (*span[0] == 65535 || *span[1] == 65535)
			{
				return false;
			}
			version = ((*span[2] == ushort.MaxValue) ? new Version((int)(*span[0]), (int)(*span[1])) : ((*span[3] == ushort.MaxValue) ? new Version((int)(*span[0]), (int)(*span[1]), (int)(*span[2])) : new Version((int)(*span[0]), (int)(*span[1]), (int)(*span[2]), (int)(*span[3]))));
			return true;
		}

		// Token: 0x06007B85 RID: 31621 RVA: 0x00122D48 File Offset: 0x00120F48
		private static bool TryParseCulture(string attributeValue, out string result)
		{
			if (attributeValue.Equals("Neutral", StringComparison.OrdinalIgnoreCase))
			{
				result = "";
				return true;
			}
			result = attributeValue;
			return true;
		}

		// Token: 0x06007B86 RID: 31622 RVA: 0x00122D68 File Offset: 0x00120F68
		private static bool TryParsePKT(string attributeValue, bool isToken, out byte[] result)
		{
			if (attributeValue.Equals("null", StringComparison.OrdinalIgnoreCase) || attributeValue == string.Empty)
			{
				result = Array.Empty<byte>();
				return true;
			}
			if (attributeValue.Length % 2 != 0 || (isToken && attributeValue.Length != 16))
			{
				result = null;
				return false;
			}
			byte[] array = new byte[attributeValue.Length / 2];
			int num;
			if (!HexConverter.TryDecodeFromUtf16(attributeValue.AsSpan(), array, out num))
			{
				result = null;
				return false;
			}
			result = array;
			return true;
		}

		// Token: 0x06007B87 RID: 31623 RVA: 0x00122DE4 File Offset: 0x00120FE4
		private static bool TryParseProcessorArchitecture(string attributeValue, out ProcessorArchitecture result)
		{
			ProcessorArchitecture processorArchitecture;
			if (attributeValue.Equals("msil", StringComparison.OrdinalIgnoreCase))
			{
				processorArchitecture = ProcessorArchitecture.MSIL;
			}
			else if (attributeValue.Equals("x86", StringComparison.OrdinalIgnoreCase))
			{
				processorArchitecture = ProcessorArchitecture.X86;
			}
			else if (attributeValue.Equals("ia64", StringComparison.OrdinalIgnoreCase))
			{
				processorArchitecture = ProcessorArchitecture.IA64;
			}
			else if (attributeValue.Equals("amd64", StringComparison.OrdinalIgnoreCase))
			{
				processorArchitecture = ProcessorArchitecture.Amd64;
			}
			else if (attributeValue.Equals("arm", StringComparison.OrdinalIgnoreCase))
			{
				processorArchitecture = ProcessorArchitecture.Arm;
			}
			else if (attributeValue.Equals("msil", StringComparison.OrdinalIgnoreCase))
			{
				processorArchitecture = ProcessorArchitecture.MSIL;
			}
			else
			{
				processorArchitecture = ProcessorArchitecture.None;
			}
			result = processorArchitecture;
			return result > ProcessorArchitecture.None;
		}

		// Token: 0x06007B88 RID: 31624 RVA: 0x00122E68 File Offset: 0x00121068
		private static bool IsWhiteSpace(char ch)
		{
			switch (ch)
			{
			case '\t':
			case '\n':
			case '\r':
				break;
			case '\v':
			case '\f':
				goto IL_26;
			default:
				if (ch != ' ')
				{
					goto IL_26;
				}
				break;
			}
			return true;
			IL_26:
			return false;
		}

		// Token: 0x06007B89 RID: 31625 RVA: 0x00122EA0 File Offset: 0x001210A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe bool TryGetNextChar(out char ch)
		{
			if (this._index < this._input.Length)
			{
				int index = this._index;
				this._index = index + 1;
				ch = (char)(*this._input[index]);
				if (ch == '\0')
				{
					return false;
				}
			}
			else
			{
				ch = '\0';
			}
			return true;
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x00122EEC File Offset: 0x001210EC
		private unsafe bool TryGetNextToken(out string tokenString, out AssemblyNameParser.Token token)
		{
			tokenString = string.Empty;
			char c;
			while (this.TryGetNextChar(out c))
			{
				if (c == '\0')
				{
					token = AssemblyNameParser.Token.End;
					return true;
				}
				if (c == ',')
				{
					token = AssemblyNameParser.Token.Comma;
					return true;
				}
				if (c == '=')
				{
					token = AssemblyNameParser.Token.Equals;
					return true;
				}
				if (!AssemblyNameParser.IsWhiteSpace(c))
				{
					Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
					bool flag;
					using (ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer))
					{
						char c2 = '\0';
						flag = (c == '"' || c == '\'');
						if (flag)
						{
							c2 = c;
							if (!this.TryGetNextChar(out c))
							{
								token = (AssemblyNameParser.Token)0;
								return false;
							}
						}
						while (c != '\0')
						{
							if (c2 == '\0' || c != c2)
							{
								bool flag2 = c2 == '\0';
								if (flag2)
								{
									bool flag3 = c == ',' || c == '=';
									flag2 = flag3;
								}
								if (flag2)
								{
									this._index--;
								}
								else
								{
									flag2 = (c2 == '\0');
									if (flag2)
									{
										bool flag3 = c == '"' || c == '\'';
										flag2 = flag3;
									}
									if (flag2)
									{
										token = (AssemblyNameParser.Token)0;
										return false;
									}
									if (c == '\\')
									{
										if (!this.TryGetNextChar(out c))
										{
											token = (AssemblyNameParser.Token)0;
											return false;
										}
										if (c <= '=')
										{
											if (c <= '\'')
											{
												if (c != '"' && c != '\'')
												{
													goto IL_190;
												}
											}
											else if (c != ',' && c != '=')
											{
												goto IL_190;
											}
										}
										else if (c <= 'n')
										{
											if (c != '\\')
											{
												if (c != 'n')
												{
													goto IL_190;
												}
												valueStringBuilder.Append('\n');
												goto IL_1A0;
											}
										}
										else
										{
											if (c == 'r')
											{
												valueStringBuilder.Append('\r');
												goto IL_1A0;
											}
											if (c != 't')
											{
												goto IL_190;
											}
											valueStringBuilder.Append('\t');
											goto IL_1A0;
										}
										valueStringBuilder.Append(c);
										goto IL_1A0;
										IL_190:
										token = (AssemblyNameParser.Token)0;
										return false;
									}
									else
									{
										valueStringBuilder.Append(c);
									}
									IL_1A0:
									if (!this.TryGetNextChar(out c))
									{
										token = (AssemblyNameParser.Token)0;
										return false;
									}
									continue;
								}
							}
							IL_1B5:
							int num = valueStringBuilder.Length;
							if (c2 == '\0')
							{
								while (num > 0 && AssemblyNameParser.IsWhiteSpace(*valueStringBuilder[num - 1]))
								{
									num--;
								}
							}
							tokenString = valueStringBuilder.AsSpan(0, num).ToString();
							token = AssemblyNameParser.Token.String;
							return true;
						}
						if (c2 == '\0')
						{
							goto IL_1B5;
						}
						token = (AssemblyNameParser.Token)0;
						flag = false;
					}
					return flag;
				}
			}
			token = (AssemblyNameParser.Token)0;
			return false;
		}

		// Token: 0x04001759 RID: 5977
		private readonly ReadOnlySpan<char> _input;

		// Token: 0x0400175A RID: 5978
		private int _index;

		// Token: 0x0200078C RID: 1932
		public readonly struct AssemblyNameParts
		{
			// Token: 0x06007B8B RID: 31627 RVA: 0x00123120 File Offset: 0x00121320
			public AssemblyNameParts(string name, Version version, string cultureName, AssemblyNameFlags flags, byte[] publicKeyOrToken)
			{
				this._name = name;
				this._version = version;
				this._cultureName = cultureName;
				this._flags = flags;
				this._publicKeyOrToken = publicKeyOrToken;
			}

			// Token: 0x0400175B RID: 5979
			public readonly string _name;

			// Token: 0x0400175C RID: 5980
			public readonly Version _version;

			// Token: 0x0400175D RID: 5981
			public readonly string _cultureName;

			// Token: 0x0400175E RID: 5982
			public readonly AssemblyNameFlags _flags;

			// Token: 0x0400175F RID: 5983
			public readonly byte[] _publicKeyOrToken;
		}

		// Token: 0x0200078D RID: 1933
		private enum Token
		{
			// Token: 0x04001761 RID: 5985
			Equals = 1,
			// Token: 0x04001762 RID: 5986
			Comma,
			// Token: 0x04001763 RID: 5987
			String,
			// Token: 0x04001764 RID: 5988
			End
		}

		// Token: 0x0200078E RID: 1934
		private enum AttributeKind
		{
			// Token: 0x04001766 RID: 5990
			Version = 1,
			// Token: 0x04001767 RID: 5991
			Culture,
			// Token: 0x04001768 RID: 5992
			PublicKeyOrToken = 4,
			// Token: 0x04001769 RID: 5993
			ProcessorArchitecture = 8,
			// Token: 0x0400176A RID: 5994
			Retargetable = 16,
			// Token: 0x0400176B RID: 5995
			ContentType = 32
		}
	}
}

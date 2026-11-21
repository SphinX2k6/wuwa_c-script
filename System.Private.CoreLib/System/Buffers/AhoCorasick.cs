using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Buffers
{
	// Token: 0x0200037B RID: 891
	internal readonly struct AhoCorasick
	{
		// Token: 0x06003BFB RID: 15355 RVA: 0x000C79BF File Offset: 0x000C5BBF
		public AhoCorasick(AhoCorasickNode[] nodes, IndexOfAnyAsciiSearcher.AsciiState startingAsciiChars)
		{
			this._nodes = nodes;
			this._startingAsciiChars = startingAsciiChars;
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06003BFC RID: 15356 RVA: 0x000C79D0 File Offset: 0x000C5BD0
		public unsafe bool ShouldUseAsciiFastScan
		{
			get
			{
				if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && this._startingAsciiChars.Bitmap != default(Vector256<byte>))
				{
					float num = 0f;
					for (int i = 0; i < 128; i++)
					{
						if (this._startingAsciiChars.Lookup.Contains128((char)i))
						{
							num += *CharacterFrequencyHelper.AsciiFrequency[i];
						}
					}
					return num <= 50f;
				}
				return false;
			}
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x000C7A48 File Offset: 0x000C5C48
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int IndexOfAny<TCaseSensitivity, TFastScanVariant>(ReadOnlySpan<char> span) where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity where TFastScanVariant : struct, AhoCorasick.IFastScan
		{
			if (!(typeof(TCaseSensitivity) == typeof(StringSearchValuesHelper.CaseInsensitiveUnicode)))
			{
				return this.IndexOfAnyCore<TCaseSensitivity, TFastScanVariant>(span);
			}
			return this.IndexOfAnyCaseInsensitiveUnicode<TFastScanVariant>(span);
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x000C7A74 File Offset: 0x000C5C74
		private unsafe int IndexOfAnyCore<TCaseSensitivity, TFastScanVariant>(ReadOnlySpan<char> span) where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity where TFastScanVariant : struct, AhoCorasick.IFastScan
		{
			ref AhoCorasickNode arrayDataReference = ref MemoryMarshal.GetArrayDataReference<AhoCorasickNode>(this._nodes);
			int num = 0;
			int num2 = -1;
			int num3 = 0;
			for (;;)
			{
				if (!IndexOfAnyAsciiSearcher.IsVectorizationSupported || !(typeof(TFastScanVariant) == typeof(AhoCorasick.IndexOfAnyAsciiFastScan)))
				{
					goto IL_7C;
				}
				int num4 = span.Length - num3;
				if (num4 < Vector128<ushort>.Count)
				{
					goto IL_7C;
				}
				int num5 = IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.DontNegate, IndexOfAnyAsciiSearcher.Default>(Unsafe.As<char, short>(Unsafe.Add<char>(MemoryMarshal.GetReference<char>(span), num3)), num4, Unsafe.AsRef<IndexOfAnyAsciiSearcher.AsciiState>(ref this._startingAsciiChars));
				if (num5 < 0)
				{
					break;
				}
				num3 += num5;
				IL_86:
				char c = StringSearchValuesHelper.ICaseSensitivity.TransformInput(*Unsafe.Add<char>(MemoryMarshal.GetReference<char>(span), num3));
				int num6;
				for (;;)
				{
					ref AhoCorasickNode ptr = ref Unsafe.Add<AhoCorasickNode>(ref arrayDataReference, (UIntPtr)num);
					if (ptr.TryGetChild(c, out num6))
					{
						goto Block_5;
					}
					if (num == 0)
					{
						break;
					}
					num = ptr.SuffixLink;
					if (num < 0)
					{
						return num2;
					}
				}
				if (num2 < 0)
				{
					num3++;
					continue;
				}
				break;
				Block_5:
				num = num6;
				int matchLength = Unsafe.Add<AhoCorasickNode>(ref arrayDataReference, (UIntPtr)num).MatchLength;
				if (matchLength != 0)
				{
					num2 = num3 + 1 - matchLength;
				}
				num3++;
				IL_7C:
				if (num3 < span.Length)
				{
					goto IL_86;
				}
				break;
			}
			return num2;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x000C7B78 File Offset: 0x000C5D78
		private unsafe int IndexOfAnyCaseInsensitiveUnicode<TFastScanVariant>(ReadOnlySpan<char> span) where TFastScanVariant : struct, AhoCorasick.IFastScan
		{
			ref AhoCorasickNode arrayDataReference = ref MemoryMarshal.GetArrayDataReference<AhoCorasickNode>(this._nodes);
			int num = 0;
			int num2 = -1;
			int num3 = 0;
			char c = '\0';
			for (;;)
			{
				if (!IndexOfAnyAsciiSearcher.IsVectorizationSupported || !(typeof(TFastScanVariant) == typeof(AhoCorasick.IndexOfAnyAsciiFastScan)))
				{
					goto IL_83;
				}
				if (c == '\0')
				{
					int num4 = span.Length - num3;
					if (num4 < Vector128<ushort>.Count)
					{
						goto IL_83;
					}
					int num5 = IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.DontNegate, IndexOfAnyAsciiSearcher.Default>(Unsafe.As<char, short>(Unsafe.Add<char>(MemoryMarshal.GetReference<char>(span), num3)), num4, Unsafe.AsRef<IndexOfAnyAsciiSearcher.AsciiState>(ref this._startingAsciiChars));
					if (num5 < 0)
					{
						break;
					}
					num3 += num5;
				}
				IL_90:
				char c2;
				if (c != '\0')
				{
					c2 = c;
					c = '\0';
				}
				else
				{
					c2 = *Unsafe.Add<char>(MemoryMarshal.GetReference<char>(span), num3);
					char l;
					if (char.IsHighSurrogate(c2) && num3 + 1 < span.Length && char.IsLowSurrogate(l = *Unsafe.Add<char>(MemoryMarshal.GetReference<char>(span), num3 + 1)))
					{
						if (GlobalizationMode.UseNls)
						{
							AhoCorasick.SurrogateToUpperNLS(c2, l, out c2, out c);
						}
						else
						{
							SurrogateCasing.ToUpper(c2, l, out c2, out c);
						}
					}
					else
					{
						c2 = TextInfo.ToUpperOrdinal(c2);
					}
				}
				int num6;
				for (;;)
				{
					ref AhoCorasickNode ptr = ref Unsafe.Add<AhoCorasickNode>(ref arrayDataReference, (UIntPtr)num);
					if (ptr.TryGetChild(c2, out num6))
					{
						goto Block_11;
					}
					if (num == 0)
					{
						break;
					}
					num = ptr.SuffixLink;
					if (num < 0)
					{
						return num2;
					}
				}
				if (num2 < 0)
				{
					num3++;
					continue;
				}
				break;
				Block_11:
				num = num6;
				int matchLength = Unsafe.Add<AhoCorasickNode>(ref arrayDataReference, (UIntPtr)num).MatchLength;
				if (matchLength != 0)
				{
					num2 = num3 + 1 - matchLength;
				}
				num3++;
				IL_83:
				if (num3 < span.Length)
				{
					goto IL_90;
				}
				break;
			}
			return num2;
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x000C7CE8 File Offset: 0x000C5EE8
		private unsafe static void SurrogateToUpperNLS(char h, char l, out char hr, out char lr)
		{
			<>y__InlineArray2<char> <>y__InlineArray = default(<>y__InlineArray2<char>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<char>, char>(ref <>y__InlineArray, 0) = h;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<char>, char>(ref <>y__InlineArray, 1) = l;
			ReadOnlySpan<char> source = <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<char>, char>(<>y__InlineArray, 2);
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)4], 2);
			Ordinal.ToUpperOrdinal(source, destination);
			hr = *destination[0];
			lr = *destination[1];
		}

		// Token: 0x04000CA1 RID: 3233
		private readonly AhoCorasickNode[] _nodes;

		// Token: 0x04000CA2 RID: 3234
		private readonly IndexOfAnyAsciiSearcher.AsciiState _startingAsciiChars;

		// Token: 0x0200037C RID: 892
		public interface IFastScan
		{
		}

		// Token: 0x0200037D RID: 893
		public readonly struct IndexOfAnyAsciiFastScan : AhoCorasick.IFastScan
		{
		}

		// Token: 0x0200037E RID: 894
		public readonly struct NoFastScan : AhoCorasick.IFastScan
		{
		}
	}
}

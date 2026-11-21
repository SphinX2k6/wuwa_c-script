using System;
using System.Buffers;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text.Unicode
{
	// Token: 0x02000250 RID: 592
	internal static class TextSegmentationUtility
	{
		// Token: 0x06002CEE RID: 11502 RVA: 0x0008F998 File Offset: 0x0008DB98
		private static int GetLengthOfFirstExtendedGraphemeCluster<T>(ReadOnlySpan<T> input, TextSegmentationUtility.DecodeFirstRune<T> decoder)
		{
			TextSegmentationUtility.Processor<T> processor = new TextSegmentationUtility.Processor<T>(input, decoder);
			processor.MoveNext();
			while (processor.CurrentType == GraphemeClusterBreakType.Prepend)
			{
				processor.MoveNext();
			}
			if (processor.CurrentCodeUnitOffset <= 0 || (processor.CurrentType != GraphemeClusterBreakType.Control && processor.CurrentType != GraphemeClusterBreakType.CR && processor.CurrentType != GraphemeClusterBreakType.LF))
			{
				GraphemeClusterBreakType currentType = processor.CurrentType;
				processor.MoveNext();
				switch (currentType)
				{
				case GraphemeClusterBreakType.CR:
					if (processor.CurrentType == GraphemeClusterBreakType.LF)
					{
						processor.MoveNext();
						goto IL_1BC;
					}
					goto IL_1BC;
				case GraphemeClusterBreakType.LF:
				case GraphemeClusterBreakType.Control:
					goto IL_1BC;
				case GraphemeClusterBreakType.Extend:
				case GraphemeClusterBreakType.ZWJ:
				case GraphemeClusterBreakType.Prepend:
				case GraphemeClusterBreakType.SpacingMark:
					goto IL_19E;
				case GraphemeClusterBreakType.Regional_Indicator:
					if (processor.CurrentType == GraphemeClusterBreakType.Regional_Indicator)
					{
						processor.MoveNext();
						goto IL_19E;
					}
					goto IL_19E;
				case GraphemeClusterBreakType.L:
					while (processor.CurrentType == GraphemeClusterBreakType.L)
					{
						processor.MoveNext();
					}
					if (processor.CurrentType == GraphemeClusterBreakType.V)
					{
						processor.MoveNext();
					}
					else if (processor.CurrentType == GraphemeClusterBreakType.LV)
					{
						processor.MoveNext();
					}
					else
					{
						if (processor.CurrentType == GraphemeClusterBreakType.LVT)
						{
							processor.MoveNext();
							goto IL_13A;
						}
						goto IL_19E;
					}
					break;
				case GraphemeClusterBreakType.V:
				case GraphemeClusterBreakType.LV:
					break;
				case GraphemeClusterBreakType.T:
				case GraphemeClusterBreakType.LVT:
					goto IL_13A;
				case GraphemeClusterBreakType.Extended_Pictograph:
					for (;;)
					{
						if (processor.CurrentType != GraphemeClusterBreakType.Extend)
						{
							if (processor.CurrentType != GraphemeClusterBreakType.ZWJ)
							{
								goto IL_19E;
							}
							processor.MoveNext();
							if (processor.CurrentType != GraphemeClusterBreakType.Extended_Pictograph)
							{
								goto IL_19E;
							}
							processor.MoveNext();
						}
						else
						{
							processor.MoveNext();
						}
					}
					break;
				default:
					goto IL_19E;
				}
				while (processor.CurrentType == GraphemeClusterBreakType.V)
				{
					processor.MoveNext();
				}
				if (processor.CurrentType != GraphemeClusterBreakType.T)
				{
					goto IL_19E;
				}
				processor.MoveNext();
				IL_13A:
				while (processor.CurrentType == GraphemeClusterBreakType.T)
				{
					processor.MoveNext();
				}
				IL_19E:
				while (processor.CurrentType == GraphemeClusterBreakType.Extend || processor.CurrentType == GraphemeClusterBreakType.ZWJ || processor.CurrentType == GraphemeClusterBreakType.SpacingMark)
				{
					processor.MoveNext();
				}
			}
			IL_1BC:
			return processor.CurrentCodeUnitOffset;
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x0008FB68 File Offset: 0x0008DD68
		public static int GetLengthOfFirstUtf16ExtendedGraphemeCluster(ReadOnlySpan<char> input)
		{
			return TextSegmentationUtility.GetLengthOfFirstExtendedGraphemeCluster<char>(input, TextSegmentationUtility._utf16Decoder);
		}

		// Token: 0x04000803 RID: 2051
		private static readonly TextSegmentationUtility.DecodeFirstRune<char> _utf16Decoder = new TextSegmentationUtility.DecodeFirstRune<char>(Rune.DecodeFromUtf16);

		// Token: 0x02000251 RID: 593
		// (Invoke) Token: 0x06002CF2 RID: 11506
		private delegate OperationStatus DecodeFirstRune<T>(ReadOnlySpan<T> input, out Rune rune, out int elementsConsumed);

		// Token: 0x02000252 RID: 594
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Auto)]
		private ref struct Processor<T>
		{
			// Token: 0x06002CF3 RID: 11507 RVA: 0x0008FB88 File Offset: 0x0008DD88
			internal Processor(ReadOnlySpan<T> buffer, TextSegmentationUtility.DecodeFirstRune<T> decoder)
			{
				this._buffer = buffer;
				this._decoder = decoder;
				this._codeUnitLengthOfCurrentScalar = 0;
				this.CurrentType = GraphemeClusterBreakType.Other;
				this.CurrentCodeUnitOffset = 0;
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x0008FBAD File Offset: 0x0008DDAD
			// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x0008FBB5 File Offset: 0x0008DDB5
			public int CurrentCodeUnitOffset { readonly get; private set; }

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x0008FBBE File Offset: 0x0008DDBE
			// (set) Token: 0x06002CF7 RID: 11511 RVA: 0x0008FBC6 File Offset: 0x0008DDC6
			public GraphemeClusterBreakType CurrentType { readonly get; private set; }

			// Token: 0x06002CF8 RID: 11512 RVA: 0x0008FBD0 File Offset: 0x0008DDD0
			public void MoveNext()
			{
				this.CurrentCodeUnitOffset += this._codeUnitLengthOfCurrentScalar;
				Rune rune;
				this._decoder(this._buffer.Slice(this.CurrentCodeUnitOffset), out rune, out this._codeUnitLengthOfCurrentScalar);
				this.CurrentType = CharUnicodeInfo.GetGraphemeClusterBreakType(rune);
			}

			// Token: 0x04000804 RID: 2052
			private readonly ReadOnlySpan<T> _buffer;

			// Token: 0x04000805 RID: 2053
			private readonly TextSegmentationUtility.DecodeFirstRune<T> _decoder;

			// Token: 0x04000806 RID: 2054
			private int _codeUnitLengthOfCurrentScalar;
		}
	}
}

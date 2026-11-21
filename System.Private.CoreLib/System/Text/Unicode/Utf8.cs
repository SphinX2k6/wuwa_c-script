using System;
using System.Buffers;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text.Unicode
{
	// Token: 0x02000254 RID: 596
	public static class Utf8
	{
		// Token: 0x06002D05 RID: 11525 RVA: 0x00090218 File Offset: 0x0008E418
		public unsafe static OperationStatus FromUtf16(ReadOnlySpan<char> source, Span<byte> destination, out int charsRead, out int bytesWritten, bool replaceInvalidSequences = true, bool isFinalBlock = true)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(destination))
				{
					byte* ptr2 = reference2;
					OperationStatus operationStatus = OperationStatus.Done;
					char* ptr3 = ptr;
					byte* ptr4 = ptr2;
					while (!source.IsEmpty)
					{
						operationStatus = Utf8Utility.TranscodeToUtf8((char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(source)), source.Length, (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(destination)), destination.Length, out ptr3, out ptr4);
						if (operationStatus <= OperationStatus.DestinationTooSmall || (operationStatus == OperationStatus.NeedMoreData && !isFinalBlock))
						{
							break;
						}
						if (!replaceInvalidSequences)
						{
							operationStatus = OperationStatus.InvalidData;
							break;
						}
						destination = destination.Slice((int)((long)((byte*)ptr4 - (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(destination)))));
						if (destination.Length <= 2)
						{
							operationStatus = OperationStatus.DestinationTooSmall;
							break;
						}
						*destination[0] = 239;
						*destination[1] = 191;
						*destination[2] = 189;
						destination = destination.Slice(3);
						source = source.Slice((int)((long)(((byte*)ptr3 - (byte*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(source))) / 2)) + 1);
						operationStatus = OperationStatus.Done;
						ptr3 = (char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(source));
						ptr4 = (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(destination));
					}
					charsRead = (int)((long)(ptr3 - ptr));
					bytesWritten = (int)((long)(ptr4 - ptr2));
					return operationStatus;
				}
			}
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x00090350 File Offset: 0x0008E550
		public unsafe static OperationStatus ToUtf16(ReadOnlySpan<byte> source, Span<char> destination, out int bytesRead, out int charsWritten, bool replaceInvalidSequences = true, bool isFinalBlock = true)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(source))
			{
				byte* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(destination))
				{
					char* ptr2 = reference2;
					OperationStatus operationStatus = OperationStatus.Done;
					byte* ptr3 = ptr;
					char* ptr4 = ptr2;
					while (!source.IsEmpty)
					{
						operationStatus = Utf8Utility.TranscodeToUtf16((byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(source)), source.Length, (char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(destination)), destination.Length, out ptr3, out ptr4);
						if (operationStatus <= OperationStatus.DestinationTooSmall || (operationStatus == OperationStatus.NeedMoreData && !isFinalBlock))
						{
							break;
						}
						if (!replaceInvalidSequences)
						{
							operationStatus = OperationStatus.InvalidData;
							break;
						}
						destination = destination.Slice((int)((long)(((byte*)ptr4 - (byte*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(destination))) / 2)));
						if (destination.IsEmpty)
						{
							operationStatus = OperationStatus.DestinationTooSmall;
							break;
						}
						*destination[0] = '�';
						destination = destination.Slice(1);
						source = source.Slice((int)((long)((byte*)ptr3 - (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(source)))));
						Rune rune;
						int start;
						Rune.DecodeFromUtf8(source, out rune, out start);
						source = source.Slice(start);
						operationStatus = OperationStatus.Done;
						ptr3 = (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(source));
						ptr4 = (char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(destination));
					}
					bytesRead = (int)((long)(ptr3 - ptr));
					charsWritten = (int)((long)(ptr4 - ptr2));
					return operationStatus;
				}
			}
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00090480 File Offset: 0x0008E680
		internal unsafe static OperationStatus ToUtf16PreservingReplacement(ReadOnlySpan<byte> source, Span<char> destination, out int bytesRead, out int charsWritten, bool replaceInvalidSequences = true, bool isFinalBlock = true)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(source))
			{
				byte* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(destination))
				{
					char* ptr2 = reference2;
					OperationStatus operationStatus = OperationStatus.Done;
					byte* ptr3 = ptr;
					char* ptr4 = ptr2;
					while (!source.IsEmpty)
					{
						operationStatus = Utf8Utility.TranscodeToUtf16((byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(source)), source.Length, (char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(destination)), destination.Length, out ptr3, out ptr4);
						if (operationStatus <= OperationStatus.DestinationTooSmall || (operationStatus == OperationStatus.NeedMoreData && !isFinalBlock))
						{
							break;
						}
						if (!replaceInvalidSequences)
						{
							operationStatus = OperationStatus.InvalidData;
							break;
						}
						source = source.Slice((int)((long)((byte*)ptr3 - (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(source)))));
						destination = destination.Slice((int)((long)(((byte*)ptr4 - (byte*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(destination))) / 2)));
						Rune rune;
						int num;
						Rune.DecodeFromUtf8(source, out rune, out num);
						if (destination.Length < num)
						{
							operationStatus = OperationStatus.DestinationTooSmall;
							break;
						}
						for (int i = 0; i < num; i++)
						{
							*destination[i] = (char)(57088 | (int)(*source[i]));
						}
						destination = destination.Slice(num);
						source = source.Slice(num);
						operationStatus = OperationStatus.Done;
						ptr3 = (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(source));
						ptr4 = (char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(destination));
					}
					bytesRead = (int)((long)(ptr3 - ptr));
					charsWritten = (int)((long)(ptr4 - ptr2));
					return operationStatus;
				}
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x000905D0 File Offset: 0x0008E7D0
		public static bool TryWrite(Span<byte> destination, [InterpolatedStringHandlerArgument("destination")] ref Utf8.TryWriteInterpolatedStringHandler handler, out int bytesWritten)
		{
			if (handler._success)
			{
				bytesWritten = handler._pos;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x000905E8 File Offset: 0x0008E7E8
		public static bool TryWrite(Span<byte> destination, [Nullable(2)] IFormatProvider provider, [InterpolatedStringHandlerArgument(new string[]
		{
			"destination",
			"provider"
		})] ref Utf8.TryWriteInterpolatedStringHandler handler, out int bytesWritten)
		{
			return Utf8.TryWrite(destination, ref handler, out bytesWritten);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x000905F4 File Offset: 0x0008E7F4
		public static bool IsValid(ReadOnlySpan<byte> value)
		{
			bool flag;
			return Utf8Utility.GetIndexOfFirstInvalidUtf8Sequence(value, out flag) < 0;
		}

		// Token: 0x02000255 RID: 597
		[CompilerFeatureRequired("RefStructs")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[InterpolatedStringHandler]
		public ref struct TryWriteInterpolatedStringHandler
		{
			// Token: 0x06002D0B RID: 11531 RVA: 0x0009060C File Offset: 0x0008E80C
			public TryWriteInterpolatedStringHandler(int literalLength, int formattedCount, Span<byte> destination, out bool shouldAppend)
			{
				this._destination = destination;
				this._provider = null;
				this._pos = 0;
				this._success = (shouldAppend = (destination.Length >= literalLength));
				this._hasCustomFormatter = false;
			}

			// Token: 0x06002D0C RID: 11532 RVA: 0x00090650 File Offset: 0x0008E850
			public TryWriteInterpolatedStringHandler(int literalLength, int formattedCount, Span<byte> destination, [Nullable(2)] IFormatProvider provider, out bool shouldAppend)
			{
				this._destination = destination;
				this._provider = provider;
				this._pos = 0;
				this._success = (shouldAppend = (destination.Length >= literalLength));
				this._hasCustomFormatter = (provider != null && DefaultInterpolatedStringHandler.HasCustomFormatter(provider));
			}

			// Token: 0x06002D0D RID: 11533 RVA: 0x000906A0 File Offset: 0x0008E8A0
			[NullableContext(1)]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool AppendLiteral(string value)
			{
				if (value != null)
				{
					Span<byte> span = this._destination.Slice(this._pos);
					int num = UTF8Encoding.UTF8EncodingSealed.ReadUtf8(value.GetRawStringData(), value.Length, MemoryMarshal.GetReference<byte>(span), span.Length);
					if (num < 0)
					{
						return this.Fail();
					}
					this._pos += num;
				}
				return true;
			}

			// Token: 0x06002D0E RID: 11534 RVA: 0x000906FC File Offset: 0x0008E8FC
			[NullableContext(1)]
			public bool AppendFormatted<[Nullable(2)] T>(T value)
			{
				if (this._hasCustomFormatter)
				{
					return this.AppendCustomFormatter<T>(value, null);
				}
				if (typeof(T).IsEnum)
				{
					return this.AppendEnum<T>(value, null);
				}
				if (!(value is IUtf8SpanFormattable))
				{
					string text;
					if (value is IFormattable)
					{
						if (value is ISpanFormattable)
						{
							return this.AppendSpanFormattable<T>(value, null);
						}
						text = ((IFormattable)((object)value)).ToString(null, this._provider);
					}
					else
					{
						ref T ptr = ref value;
						T t = default(T);
						string text2;
						if (t == null)
						{
							t = value;
							ptr = ref t;
							if (t == null)
							{
								text2 = null;
								goto IL_F1;
							}
						}
						text2 = ptr.ToString();
						IL_F1:
						text = text2;
					}
					return this.AppendFormatted(text.AsSpan());
				}
				int num;
				if (((IUtf8SpanFormattable)((object)value)).TryFormat(this._destination.Slice(this._pos), out num, default(ReadOnlySpan<char>), this._provider))
				{
					this._pos += num;
					return true;
				}
				return this.Fail();
			}

			// Token: 0x06002D0F RID: 11535 RVA: 0x00090808 File Offset: 0x0008EA08
			[NullableContext(2)]
			public bool AppendFormatted<T>([Nullable(1)] T value, string format)
			{
				if (this._hasCustomFormatter)
				{
					return this.AppendCustomFormatter<T>(value, format);
				}
				if (typeof(T).IsEnum)
				{
					return this.AppendEnum<T>(value, format);
				}
				if (!(value is IUtf8SpanFormattable))
				{
					string text;
					if (value is IFormattable)
					{
						if (value is ISpanFormattable)
						{
							return this.AppendSpanFormattable<T>(value, format);
						}
						text = ((IFormattable)((object)value)).ToString(format, this._provider);
					}
					else
					{
						ref T ptr = ref value;
						T t = default(T);
						string text2;
						if (t == null)
						{
							t = value;
							ptr = ref t;
							if (t == null)
							{
								text2 = null;
								goto IL_EE;
							}
						}
						text2 = ptr.ToString();
						IL_EE:
						text = text2;
					}
					return this.AppendFormatted(text.AsSpan());
				}
				int num;
				if (((IUtf8SpanFormattable)((object)value)).TryFormat(this._destination.Slice(this._pos), out num, format, this._provider))
				{
					this._pos += num;
					return true;
				}
				return this.Fail();
			}

			// Token: 0x06002D10 RID: 11536 RVA: 0x00090910 File Offset: 0x0008EB10
			[NullableContext(1)]
			public bool AppendFormatted<[Nullable(2)] T>(T value, int alignment)
			{
				int pos = this._pos;
				if (this.AppendFormatted<T>(value))
				{
					return alignment == 0 || this.TryAppendOrInsertAlignmentIfNeeded(pos, alignment);
				}
				return this.Fail();
			}

			// Token: 0x06002D11 RID: 11537 RVA: 0x00090944 File Offset: 0x0008EB44
			[NullableContext(2)]
			public bool AppendFormatted<T>([Nullable(1)] T value, int alignment, string format)
			{
				int pos = this._pos;
				if (this.AppendFormatted<T>(value, format))
				{
					return alignment == 0 || this.TryAppendOrInsertAlignmentIfNeeded(pos, alignment);
				}
				return this.Fail();
			}

			// Token: 0x06002D12 RID: 11538 RVA: 0x00090978 File Offset: 0x0008EB78
			public bool AppendFormatted([ScopedRef] ReadOnlySpan<char> value)
			{
				int num;
				if (Encoding.UTF8.TryGetBytes(value, this._destination.Slice(this._pos), out num))
				{
					this._pos += num;
					return true;
				}
				return this.Fail();
			}

			// Token: 0x06002D13 RID: 11539 RVA: 0x000909BC File Offset: 0x0008EBBC
			public bool AppendFormatted([ScopedRef] ReadOnlySpan<char> value, int alignment = 0, [Nullable(2)] string format = null)
			{
				int pos = this._pos;
				if (this.AppendFormatted(value))
				{
					return alignment == 0 || this.TryAppendOrInsertAlignmentIfNeeded(pos, alignment);
				}
				return this.Fail();
			}

			// Token: 0x06002D14 RID: 11540 RVA: 0x000909ED File Offset: 0x0008EBED
			public bool AppendFormatted([ScopedRef] ReadOnlySpan<byte> utf8Value)
			{
				if (utf8Value.TryCopyTo(this._destination.Slice(this._pos)))
				{
					this._pos += utf8Value.Length;
					return true;
				}
				return this.Fail();
			}

			// Token: 0x06002D15 RID: 11541 RVA: 0x00090A28 File Offset: 0x0008EC28
			public bool AppendFormatted([ScopedRef] ReadOnlySpan<byte> utf8Value, int alignment = 0, [Nullable(2)] string format = null)
			{
				int pos = this._pos;
				if (this.AppendFormatted(utf8Value))
				{
					return alignment == 0 || this.TryAppendOrInsertAlignmentIfNeeded(pos, alignment);
				}
				return this.Fail();
			}

			// Token: 0x06002D16 RID: 11542 RVA: 0x00090A59 File Offset: 0x0008EC59
			[NullableContext(2)]
			public bool AppendFormatted(string value)
			{
				if (!this._hasCustomFormatter)
				{
					return this.AppendFormatted(value.AsSpan());
				}
				return this.AppendCustomFormatter<string>(value, null);
			}

			// Token: 0x06002D17 RID: 11543 RVA: 0x00090A78 File Offset: 0x0008EC78
			[NullableContext(2)]
			public bool AppendFormatted(string value, int alignment = 0, string format = null)
			{
				return this.AppendFormatted<string>(value, alignment, format);
			}

			// Token: 0x06002D18 RID: 11544 RVA: 0x00090A83 File Offset: 0x0008EC83
			[NullableContext(2)]
			public bool AppendFormatted(object value, int alignment = 0, string format = null)
			{
				return this.AppendFormatted<object>(value, alignment, format);
			}

			// Token: 0x06002D19 RID: 11545 RVA: 0x00090A90 File Offset: 0x0008EC90
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool AppendCustomFormatter<T>(T value, string format)
			{
				ICustomFormatter customFormatter = (ICustomFormatter)this._provider.GetFormat(typeof(ICustomFormatter));
				if (customFormatter != null)
				{
					string text = customFormatter.Format(format, value, this._provider);
					if (text != null)
					{
						return this.AppendFormatted(text.AsSpan());
					}
				}
				return true;
			}

			// Token: 0x06002D1A RID: 11546 RVA: 0x00090AE0 File Offset: 0x0008ECE0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private unsafe bool AppendSpanFormattable<T>(T value, string format)
			{
				Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				int length;
				if (!((ISpanFormattable)((object)value)).TryFormat(destination, out length, format, this._provider))
				{
					return Utf8.TryWriteInterpolatedStringHandler.<AppendSpanFormattable>g__GrowAndAppendFormatted|20_0<T>(ref this, value, destination.Length, out length, format);
				}
				return this.AppendFormatted(destination.Slice(0, length));
			}

			// Token: 0x06002D1B RID: 11547 RVA: 0x00090B48 File Offset: 0x0008ED48
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private unsafe bool AppendEnum<T>(T value, string format)
			{
				Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				int length;
				if (!Enum.TryFormatUnconstrained<T>(value, destination, out length, format))
				{
					return Utf8.TryWriteInterpolatedStringHandler.<AppendEnum>g__GrowAndAppendFormatted|21_0<T>(ref this, value, destination.Length, out length, format);
				}
				return this.AppendFormatted(destination.Slice(0, length));
			}

			// Token: 0x06002D1C RID: 11548 RVA: 0x00090BA0 File Offset: 0x0008EDA0
			private bool TryAppendOrInsertAlignmentIfNeeded(int startingPos, int alignment)
			{
				int num = this._pos - startingPos;
				bool flag = false;
				if (alignment < 0)
				{
					flag = true;
					alignment = -alignment;
				}
				int num2 = alignment - num;
				if (num2 <= 0)
				{
					return true;
				}
				if (num2 <= this._destination.Length - this._pos)
				{
					if (flag)
					{
						this._destination.Slice(this._pos, num2).Fill(32);
					}
					else
					{
						this._destination.Slice(startingPos, num).CopyTo(this._destination.Slice(startingPos + num2));
						this._destination.Slice(startingPos, num2).Fill(32);
					}
					this._pos += num2;
					return true;
				}
				return this.Fail();
			}

			// Token: 0x06002D1D RID: 11549 RVA: 0x00090C52 File Offset: 0x0008EE52
			private bool Fail()
			{
				this._success = false;
				return false;
			}

			// Token: 0x06002D1E RID: 11550 RVA: 0x00090C5C File Offset: 0x0008EE5C
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool <AppendSpanFormattable>g__GrowAndAppendFormatted|20_0<T>([ScopedRef] ref Utf8.TryWriteInterpolatedStringHandler thisRef, T value, int length, out int charsWritten, string format)
			{
				bool result;
				for (;;)
				{
					int num = length * 2;
					if ((ulong)num > 2147483591UL)
					{
						num = ((length == 2147483591) ? (2147483591 + 1) : 2147483591);
					}
					length = num;
					char[] array = ArrayPool<char>.Shared.Rent(length);
					try
					{
						if (!((ISpanFormattable)((object)value)).TryFormat(array, out charsWritten, format, thisRef._provider))
						{
							continue;
						}
						result = thisRef.AppendFormatted(array.AsSpan(0, charsWritten));
					}
					finally
					{
						ArrayPool<char>.Shared.Return(array, false);
					}
					break;
				}
				return result;
			}

			// Token: 0x06002D1F RID: 11551 RVA: 0x00090CFC File Offset: 0x0008EEFC
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool <AppendEnum>g__GrowAndAppendFormatted|21_0<T>([ScopedRef] ref Utf8.TryWriteInterpolatedStringHandler thisRef, T value, int length, out int charsWritten, string format)
			{
				bool result;
				for (;;)
				{
					int num = length * 2;
					if ((ulong)num > 2147483591UL)
					{
						num = ((length == 2147483591) ? (2147483591 + 1) : 2147483591);
					}
					length = num;
					char[] array = ArrayPool<char>.Shared.Rent(length);
					try
					{
						if (!Enum.TryFormatUnconstrained<T>(value, array, out charsWritten, format))
						{
							continue;
						}
						result = thisRef.AppendFormatted(array.AsSpan(0, charsWritten));
					}
					finally
					{
						ArrayPool<char>.Shared.Return(array, false);
					}
					break;
				}
				return result;
			}

			// Token: 0x04000809 RID: 2057
			private readonly Span<byte> _destination;

			// Token: 0x0400080A RID: 2058
			private readonly IFormatProvider _provider;

			// Token: 0x0400080B RID: 2059
			internal int _pos;

			// Token: 0x0400080C RID: 2060
			internal bool _success;

			// Token: 0x0400080D RID: 2061
			private readonly bool _hasCustomFormatter;
		}
	}
}

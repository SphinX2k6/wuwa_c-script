using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Text
{
	// Token: 0x02000228 RID: 552
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Encoding : ICloneable
	{
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x00083680 File Offset: 0x00081880
		public static Encoding Default
		{
			get
			{
				return Encoding.s_defaultEncoding;
			}
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00083687 File Offset: 0x00081887
		protected Encoding() : this(0)
		{
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00083690 File Offset: 0x00081890
		protected Encoding(int codePage)
		{
			this._isReadOnly = true;
			base..ctor();
			ArgumentOutOfRangeException.ThrowIfNegative<int>(codePage, "codePage");
			this._codePage = codePage;
			this.SetDefaultFallbacks();
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000836B8 File Offset: 0x000818B8
		[NullableContext(2)]
		protected Encoding(int codePage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			this._isReadOnly = true;
			base..ctor();
			ArgumentOutOfRangeException.ThrowIfNegative<int>(codePage, "codePage");
			this._codePage = codePage;
			this.encoderFallback = (encoderFallback ?? EncoderFallback.ReplacementFallback);
			this.decoderFallback = (decoderFallback ?? DecoderFallback.ReplacementFallback);
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000803EE File Offset: 0x0007E5EE
		[MemberNotNull("encoderFallback")]
		[MemberNotNull("decoderFallback")]
		internal virtual void SetDefaultFallbacks()
		{
			this.encoderFallback = EncoderFallback.ReplacementFallback;
			this.decoderFallback = DecoderFallback.ReplacementFallback;
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x00083704 File Offset: 0x00081904
		public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			return Encoding.Convert(srcEncoding, dstEncoding, bytes, 0, bytes.Length);
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x0008371D File Offset: 0x0008191D
		public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(srcEncoding, "srcEncoding");
			ArgumentNullException.ThrowIfNull(dstEncoding, "dstEncoding");
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			return dstEncoding.GetBytes(srcEncoding.GetChars(bytes, index, count));
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00083750 File Offset: 0x00081950
		public static void RegisterProvider(EncodingProvider provider)
		{
			EncodingProvider.AddProvider(provider);
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x00083758 File Offset: 0x00081958
		public static Encoding GetEncoding(int codepage)
		{
			Encoding encoding = Encoding.FilterDisallowedEncodings(EncodingProvider.GetEncodingFromProvider(codepage));
			if (encoding != null)
			{
				return encoding;
			}
			if (codepage <= 1201)
			{
				if (codepage <= 3)
				{
					if (codepage == 0)
					{
						return Encoding.Default;
					}
					if (codepage - 1 > 2)
					{
						goto IL_108;
					}
				}
				else if (codepage != 42)
				{
					if (codepage == 1200)
					{
						return Encoding.Unicode;
					}
					if (codepage != 1201)
					{
						goto IL_108;
					}
					return Encoding.BigEndianUnicode;
				}
				throw new ArgumentException(SR.Format(SR.Argument_CodepageNotSupported, codepage), "codepage");
			}
			if (codepage <= 20127)
			{
				if (codepage == 12000)
				{
					return Encoding.UTF32;
				}
				if (codepage == 12001)
				{
					return Encoding.BigEndianUTF32;
				}
				if (codepage == 20127)
				{
					return Encoding.ASCII;
				}
			}
			else
			{
				if (codepage == 28591)
				{
					return Encoding.Latin1;
				}
				if (codepage != 65000)
				{
					if (codepage == 65001)
					{
						return Encoding.UTF8;
					}
				}
				else
				{
					if (LocalAppContextSwitches.EnableUnsafeUTF7Encoding)
					{
						return Encoding.UTF7;
					}
					string p = string.Format(CultureInfo.InvariantCulture, "https://aka.ms/dotnet-warnings/{0}", "SYSLIB0001");
					throw new NotSupportedException(SR.Format(SR.Encoding_UTF7_Disabled, p));
				}
			}
			IL_108:
			if (codepage < 0 || codepage > 65535)
			{
				throw new ArgumentOutOfRangeException("codepage", SR.Format(SR.ArgumentOutOfRange_Range, 0, 65535));
			}
			throw new NotSupportedException(SR.Format(SR.NotSupported_NoCodepageData, codepage));
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000838B4 File Offset: 0x00081AB4
		public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			Encoding encoding = Encoding.FilterDisallowedEncodings(EncodingProvider.GetEncodingFromProvider(codepage, encoderFallback, decoderFallback));
			if (encoding != null)
			{
				return encoding;
			}
			encoding = Encoding.GetEncoding(codepage);
			Encoding encoding2 = (Encoding)encoding.Clone();
			encoding2.EncoderFallback = encoderFallback;
			encoding2.DecoderFallback = decoderFallback;
			return encoding2;
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000838F4 File Offset: 0x00081AF4
		public static Encoding GetEncoding(string name)
		{
			return Encoding.FilterDisallowedEncodings(EncodingProvider.GetEncodingFromProvider(name)) ?? Encoding.GetEncoding(EncodingTable.GetCodePageFromName(name));
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00083910 File Offset: 0x00081B10
		public static Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			return Encoding.FilterDisallowedEncodings(EncodingProvider.GetEncodingFromProvider(name, encoderFallback, decoderFallback)) ?? Encoding.GetEncoding(EncodingTable.GetCodePageFromName(name), encoderFallback, decoderFallback);
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00083930 File Offset: 0x00081B30
		private static Encoding FilterDisallowedEncodings(Encoding encoding)
		{
			if (LocalAppContextSwitches.EnableUnsafeUTF7Encoding)
			{
				return encoding;
			}
			if (encoding == null || encoding.CodePage != 65000)
			{
				return encoding;
			}
			return null;
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x00083950 File Offset: 0x00081B50
		public static EncodingInfo[] GetEncodings()
		{
			Dictionary<int, EncodingInfo> encodingListFromProviders = EncodingProvider.GetEncodingListFromProviders();
			if (encodingListFromProviders != null)
			{
				return EncodingTable.GetEncodings(encodingListFromProviders);
			}
			return EncodingTable.GetEncodings();
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00083972 File Offset: 0x00081B72
		public virtual byte[] GetPreamble()
		{
			return Array.Empty<byte>();
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x00083979 File Offset: 0x00081B79
		[Nullable(0)]
		public virtual ReadOnlySpan<byte> Preamble
		{
			[NullableContext(0)]
			get
			{
				return this.GetPreamble();
			}
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x00083986 File Offset: 0x00081B86
		private void GetDataItem()
		{
			if (this._dataItem == null)
			{
				this._dataItem = EncodingTable.GetCodePageDataItem(this._codePage);
				if (this._dataItem == null)
				{
					throw new NotSupportedException(SR.Format(SR.NotSupported_NoCodepageData, this._codePage));
				}
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000839C4 File Offset: 0x00081BC4
		public virtual string BodyName
		{
			get
			{
				if (this._dataItem == null)
				{
					this.GetDataItem();
				}
				return this._dataItem.BodyName;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000839DF File Offset: 0x00081BDF
		public virtual string EncodingName
		{
			get
			{
				if (this._dataItem == null)
				{
					this.GetDataItem();
				}
				return this._dataItem.DisplayName;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x000839FA File Offset: 0x00081BFA
		public virtual string HeaderName
		{
			get
			{
				if (this._dataItem == null)
				{
					this.GetDataItem();
				}
				return this._dataItem.HeaderName;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x00083A15 File Offset: 0x00081C15
		public virtual string WebName
		{
			get
			{
				if (this._dataItem == null)
				{
					this.GetDataItem();
				}
				return this._dataItem.WebName;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x00083A30 File Offset: 0x00081C30
		public virtual int WindowsCodePage
		{
			get
			{
				if (this._dataItem == null)
				{
					this.GetDataItem();
				}
				return this._dataItem.UIFamilyCodePage;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x00083A4B File Offset: 0x00081C4B
		public virtual bool IsBrowserDisplay
		{
			get
			{
				if (this._dataItem == null)
				{
					this.GetDataItem();
				}
				return (this._dataItem.Flags & 2U) > 0U;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x00083A6B File Offset: 0x00081C6B
		public virtual bool IsBrowserSave
		{
			get
			{
				if (this._dataItem == null)
				{
					this.GetDataItem();
				}
				return (this._dataItem.Flags & 512U) > 0U;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x00083A8F File Offset: 0x00081C8F
		public virtual bool IsMailNewsDisplay
		{
			get
			{
				if (this._dataItem == null)
				{
					this.GetDataItem();
				}
				return (this._dataItem.Flags & 1U) > 0U;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x00083AAF File Offset: 0x00081CAF
		public virtual bool IsMailNewsSave
		{
			get
			{
				if (this._dataItem == null)
				{
					this.GetDataItem();
				}
				return (this._dataItem.Flags & 256U) > 0U;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsSingleByte
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x00083AD3 File Offset: 0x00081CD3
		// (set) Token: 0x06002A2F RID: 10799 RVA: 0x00083ADB File Offset: 0x00081CDB
		public EncoderFallback EncoderFallback
		{
			get
			{
				return this.encoderFallback;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.encoderFallback = value;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x00083B02 File Offset: 0x00081D02
		// (set) Token: 0x06002A31 RID: 10801 RVA: 0x00083B0A File Offset: 0x00081D0A
		public DecoderFallback DecoderFallback
		{
			get
			{
				return this.decoderFallback;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.decoderFallback = value;
			}
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00083B31 File Offset: 0x00081D31
		public virtual object Clone()
		{
			Encoding encoding = (Encoding)base.MemberwiseClone();
			encoding._isReadOnly = false;
			return encoding;
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002A33 RID: 10803 RVA: 0x00083B45 File Offset: 0x00081D45
		// (set) Token: 0x06002A34 RID: 10804 RVA: 0x00083B4D File Offset: 0x00081D4D
		public bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
			private protected set
			{
				this._isReadOnly = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x00083B56 File Offset: 0x00081D56
		public static Encoding ASCII
		{
			get
			{
				return ASCIIEncoding.s_default;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x00083B5D File Offset: 0x00081D5D
		public static Encoding Latin1
		{
			get
			{
				return Latin1Encoding.s_default;
			}
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x00083B64 File Offset: 0x00081D64
		public virtual int GetByteCount(char[] chars)
		{
			ArgumentNullException.ThrowIfNull(chars, "chars");
			return this.GetByteCount(chars, 0, chars.Length);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00083B7C File Offset: 0x00081D7C
		public virtual int GetByteCount(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			char[] array = s.ToCharArray();
			return this.GetByteCount(array, 0, array.Length);
		}

		// Token: 0x06002A39 RID: 10809
		public abstract int GetByteCount(char[] chars, int index, int count);

		// Token: 0x06002A3A RID: 10810 RVA: 0x00083BA8 File Offset: 0x00081DA8
		public unsafe int GetByteCount(string s, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(s, "s");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(index, s.Length - count, "index");
			char* ptr;
			if (s == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = s.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			return this.GetByteCount(ptr2 + index, count);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00083C08 File Offset: 0x00081E08
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe virtual int GetByteCount(char* chars, int count)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			char[] chars2 = new ReadOnlySpan<char>((void*)chars, count).ToArray();
			return this.GetByteCount(chars2, 0, count);
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00083C44 File Offset: 0x00081E44
		[NullableContext(0)]
		public unsafe virtual int GetByteCount(ReadOnlySpan<char> chars)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				return this.GetByteCount(chars2, chars.Length);
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00083C69 File Offset: 0x00081E69
		public virtual byte[] GetBytes(char[] chars)
		{
			ArgumentNullException.ThrowIfNull(chars, "chars");
			return this.GetBytes(chars, 0, chars.Length);
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00083C84 File Offset: 0x00081E84
		public virtual byte[] GetBytes(char[] chars, int index, int count)
		{
			byte[] array = new byte[this.GetByteCount(chars, index, count)];
			this.GetBytes(chars, index, count, array, 0);
			return array;
		}

		// Token: 0x06002A3F RID: 10815
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

		// Token: 0x06002A40 RID: 10816 RVA: 0x00083CB0 File Offset: 0x00081EB0
		public virtual byte[] GetBytes(string s)
		{
			ArgumentNullException.ThrowIfNull(s, "s");
			byte[] array = new byte[this.GetByteCount(s)];
			this.GetBytes(s, 0, s.Length, array, 0);
			return array;
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00083CE8 File Offset: 0x00081EE8
		public unsafe byte[] GetBytes(string s, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(s, "s");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(index, s.Length - count, "index");
			char* ptr;
			if (s == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = s.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			int byteCount = this.GetByteCount(ptr2 + index, count);
			if (byteCount == 0)
			{
				return Array.Empty<byte>();
			}
			byte[] array = new byte[byteCount];
			fixed (byte* ptr3 = &array[0])
			{
				byte* bytes = ptr3;
				this.GetBytes(ptr2 + index, count, bytes, byteCount);
			}
			return array;
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00083D78 File Offset: 0x00081F78
		public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return this.GetBytes(s.ToCharArray(), charIndex, charCount, bytes, byteIndex);
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00083D98 File Offset: 0x00081F98
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			char[] chars2 = new ReadOnlySpan<char>((void*)chars, charCount).ToArray();
			byte[] array = new byte[byteCount];
			int bytes2 = this.GetBytes(chars2, 0, charCount, array, 0);
			if (bytes2 < byteCount)
			{
				byteCount = bytes2;
			}
			new ReadOnlySpan<byte>(array, 0, byteCount).CopyTo(new Span<byte>((void*)bytes, byteCount));
			return byteCount;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00083E1C File Offset: 0x0008201C
		[NullableContext(0)]
		public unsafe virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				fixed (byte* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
				{
					byte* bytes2 = nonNullPinnableReference2;
					return this.GetBytes(chars2, chars.Length, bytes2, bytes.Length);
				}
			}
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00083E53 File Offset: 0x00082053
		[NullableContext(0)]
		public virtual bool TryGetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
		{
			if (this.GetByteCount(chars) <= bytes.Length)
			{
				bytesWritten = this.GetBytes(chars, bytes);
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00083E75 File Offset: 0x00082075
		public virtual int GetCharCount(byte[] bytes)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			return this.GetCharCount(bytes, 0, bytes.Length);
		}

		// Token: 0x06002A47 RID: 10823
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		// Token: 0x06002A48 RID: 10824 RVA: 0x00083E90 File Offset: 0x00082090
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe virtual int GetCharCount(byte* bytes, int count)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			byte[] bytes2 = new ReadOnlySpan<byte>((void*)bytes, count).ToArray();
			return this.GetCharCount(bytes2, 0, count);
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00083ECC File Offset: 0x000820CC
		[NullableContext(0)]
		public unsafe virtual int GetCharCount(ReadOnlySpan<byte> bytes)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				return this.GetCharCount(bytes2, bytes.Length);
			}
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00083EF1 File Offset: 0x000820F1
		public virtual char[] GetChars(byte[] bytes)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			return this.GetChars(bytes, 0, bytes.Length);
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00083F0C File Offset: 0x0008210C
		public virtual char[] GetChars(byte[] bytes, int index, int count)
		{
			char[] array = new char[this.GetCharCount(bytes, index, count)];
			this.GetChars(bytes, index, count, array, 0);
			return array;
		}

		// Token: 0x06002A4C RID: 10828
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		// Token: 0x06002A4D RID: 10829 RVA: 0x00083F38 File Offset: 0x00082138
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			byte[] bytes2 = new ReadOnlySpan<byte>((void*)bytes, byteCount).ToArray();
			char[] array = new char[charCount];
			int chars2 = this.GetChars(bytes2, 0, byteCount, array, 0);
			if (chars2 < charCount)
			{
				charCount = chars2;
			}
			new ReadOnlySpan<char>(array, 0, charCount).CopyTo(new Span<char>((void*)chars, charCount));
			return charCount;
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00083FBC File Offset: 0x000821BC
		[NullableContext(0)]
		public unsafe virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				fixed (char* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
				{
					char* chars2 = nonNullPinnableReference2;
					return this.GetChars(bytes2, bytes.Length, chars2, chars.Length);
				}
			}
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00083FF3 File Offset: 0x000821F3
		[NullableContext(0)]
		public virtual bool TryGetChars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten)
		{
			if (this.GetCharCount(bytes) <= chars.Length)
			{
				charsWritten = this.GetChars(bytes, chars);
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00084015 File Offset: 0x00082215
		[NullableContext(0)]
		[CLSCompliant(false)]
		[return: Nullable(1)]
		public unsafe string GetString(byte* bytes, int byteCount)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			return string.CreateStringFromEncoding(bytes, byteCount, this);
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00084038 File Offset: 0x00082238
		[NullableContext(0)]
		[return: Nullable(1)]
		public unsafe string GetString(ReadOnlySpan<byte> bytes)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				return string.CreateStringFromEncoding(nonNullPinnableReference, bytes.Length, this);
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x0008405B File Offset: 0x0008225B
		public virtual int CodePage
		{
			get
			{
				return this._codePage;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x00084063 File Offset: 0x00082263
		internal bool IsUTF8CodePage
		{
			get
			{
				return this.CodePage == 65001;
			}
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00084072 File Offset: 0x00082272
		public bool IsAlwaysNormalized()
		{
			return this.IsAlwaysNormalized(NormalizationForm.FormC);
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsAlwaysNormalized(NormalizationForm form)
		{
			return false;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x0008407B File Offset: 0x0008227B
		public virtual Decoder GetDecoder()
		{
			return new Encoding.DefaultDecoder(this);
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00084083 File Offset: 0x00082283
		public virtual Encoder GetEncoder()
		{
			return new Encoding.DefaultEncoder(this);
		}

		// Token: 0x06002A58 RID: 10840
		public abstract int GetMaxByteCount(int charCount);

		// Token: 0x06002A59 RID: 10841
		public abstract int GetMaxCharCount(int byteCount);

		// Token: 0x06002A5A RID: 10842 RVA: 0x0008408B File Offset: 0x0008228B
		public virtual string GetString(byte[] bytes)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			return this.GetString(bytes, 0, bytes.Length);
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x000840A3 File Offset: 0x000822A3
		public virtual string GetString(byte[] bytes, int index, int count)
		{
			return new string(this.GetChars(bytes, index, count));
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x000840B3 File Offset: 0x000822B3
		public static Encoding Unicode
		{
			get
			{
				return UnicodeEncoding.s_littleEndianDefault;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x000840BA File Offset: 0x000822BA
		public static Encoding BigEndianUnicode
		{
			get
			{
				return UnicodeEncoding.s_bigEndianDefault;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000840C1 File Offset: 0x000822C1
		[Obsolete("The UTF-7 encoding is insecure and should not be used. Consider using UTF-8 instead.", DiagnosticId = "SYSLIB0001", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static Encoding UTF7
		{
			get
			{
				return UTF7Encoding.s_default;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x000840C8 File Offset: 0x000822C8
		public static Encoding UTF8
		{
			get
			{
				return UTF8Encoding.s_default;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000840CF File Offset: 0x000822CF
		public static Encoding UTF32
		{
			get
			{
				return UTF32Encoding.s_default;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x000840D6 File Offset: 0x000822D6
		private static Encoding BigEndianUTF32
		{
			get
			{
				return UTF32Encoding.s_bigEndianDefault;
			}
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000840E0 File Offset: 0x000822E0
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			Encoding encoding = value as Encoding;
			return encoding != null && this._codePage == encoding._codePage && this.EncoderFallback.Equals(encoding.EncoderFallback) && this.DecoderFallback.Equals(encoding.DecoderFallback);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x0008412B File Offset: 0x0008232B
		public override int GetHashCode()
		{
			return this._codePage + this.EncoderFallback.GetHashCode() + this.DecoderFallback.GetHashCode();
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x0008414B File Offset: 0x0008234B
		public static Stream CreateTranscodingStream(Stream innerStream, Encoding innerStreamEncoding, Encoding outerStreamEncoding, bool leaveOpen = false)
		{
			ArgumentNullException.ThrowIfNull(innerStream, "innerStream");
			ArgumentNullException.ThrowIfNull(innerStreamEncoding, "innerStreamEncoding");
			ArgumentNullException.ThrowIfNull(outerStreamEncoding, "outerStreamEncoding");
			return new TranscodingStream(innerStream, innerStreamEncoding, outerStreamEncoding, leaveOpen);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00084177 File Offset: 0x00082377
		[DoesNotReturn]
		internal void ThrowBytesOverflow()
		{
			throw new ArgumentException(SR.Format(SR.Argument_EncodingConversionOverflowBytes, this._codePage, this.EncoderFallback.GetType()), "bytes");
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000841A3 File Offset: 0x000823A3
		internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
		{
			if (encoder == null || encoder._throwOnOverflow || nothingEncoded)
			{
				if (encoder != null && encoder.InternalHasFallbackBuffer)
				{
					encoder.FallbackBuffer.InternalReset();
				}
				this.ThrowBytesOverflow();
			}
			encoder.ClearMustFlush();
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x000841D7 File Offset: 0x000823D7
		[DoesNotReturn]
		[StackTraceHidden]
		internal static void ThrowConversionOverflow()
		{
			throw new ArgumentException(SR.Argument_ConversionOverflow);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000841E3 File Offset: 0x000823E3
		[DoesNotReturn]
		[StackTraceHidden]
		internal void ThrowCharsOverflow()
		{
			throw new ArgumentException(SR.Format(SR.Argument_EncodingConversionOverflowChars, this._codePage, this.DecoderFallback.GetType()), "chars");
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x0008420F File Offset: 0x0008240F
		internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
		{
			if (decoder == null || decoder._throwOnOverflow || nothingDecoded)
			{
				if (decoder != null && decoder.InternalHasFallbackBuffer)
				{
					decoder.FallbackBuffer.InternalReset();
				}
				this.ThrowCharsOverflow();
			}
			decoder.ClearMustFlush();
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x0001A4BD File Offset: 0x000186BD
		internal virtual OperationStatus DecodeFirstRune(ReadOnlySpan<byte> bytes, out Rune value, out int bytesConsumed)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x0001A4BD File Offset: 0x000186BD
		internal virtual OperationStatus EncodeRune(Rune value, Span<byte> bytes, out int bytesWritten)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x0001A4BD File Offset: 0x000186BD
		internal virtual bool TryGetByteCount(Rune value, out int byteCount)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x00084244 File Offset: 0x00082444
		internal unsafe virtual int GetByteCount(char* pChars, int charCount, EncoderNLS encoder)
		{
			int num = 0;
			int num2 = 0;
			if (!encoder.HasLeftoverData)
			{
				num = this.GetByteCountFast(pChars, charCount, encoder.Fallback, out num2);
				if (num2 == charCount)
				{
					return num;
				}
			}
			num += this.GetByteCountWithFallback(pChars, charCount, num2, encoder);
			if (num < 0)
			{
				Encoding.ThrowConversionOverflow();
			}
			return num;
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x0001A4BD File Offset: 0x000186BD
		private protected unsafe virtual int GetByteCountFast(char* pChars, int charsLength, EncoderFallback fallback, out int charsConsumed)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x0008428C File Offset: 0x0008248C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private protected unsafe int GetByteCountWithFallback(char* pCharsOriginal, int originalCharCount, int charsConsumedSoFar)
		{
			return this.GetByteCountWithFallback(new ReadOnlySpan<char>((void*)pCharsOriginal, originalCharCount).Slice(charsConsumedSoFar), originalCharCount, null);
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x000842B4 File Offset: 0x000824B4
		private unsafe int GetByteCountWithFallback(char* pOriginalChars, int originalCharCount, int charsConsumedSoFar, EncoderNLS encoder)
		{
			ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>((void*)pOriginalChars, originalCharCount).Slice(charsConsumedSoFar);
			int start;
			int num = encoder.DrainLeftoverDataForGetByteCount(readOnlySpan, out start);
			readOnlySpan = readOnlySpan.Slice(start);
			num += this.GetByteCountFast((char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(readOnlySpan)), readOnlySpan.Length, encoder.Fallback, out start);
			if (num < 0)
			{
				Encoding.ThrowConversionOverflow();
			}
			readOnlySpan = readOnlySpan.Slice(start);
			if (!readOnlySpan.IsEmpty)
			{
				num += this.GetByteCountWithFallback(readOnlySpan, originalCharCount, encoder);
				if (num < 0)
				{
					Encoding.ThrowConversionOverflow();
				}
			}
			return num;
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x0008433C File Offset: 0x0008253C
		private protected unsafe virtual int GetByteCountWithFallback(ReadOnlySpan<char> chars, int originalCharsLength, EncoderNLS encoder)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				EncoderFallbackBuffer encoderFallbackBuffer = EncoderFallbackBuffer.CreateAndInitialize(this, encoder, originalCharsLength);
				int num = 0;
				Rune rune;
				int start;
				while (Rune.DecodeFromUtf16(chars, out rune, out start) != OperationStatus.NeedMoreData || encoder == null || encoder.MustFlush)
				{
					int num2 = encoderFallbackBuffer.InternalFallbackGetByteCount(chars, out start);
					num += num2;
					if (num < 0)
					{
						Encoding.ThrowConversionOverflow();
					}
					chars = chars.Slice(start);
					if (!chars.IsEmpty)
					{
						num2 = this.GetByteCountFast((char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(chars)), chars.Length, null, out start);
						num += num2;
						if (num < 0)
						{
							Encoding.ThrowConversionOverflow();
						}
						chars = chars.Slice(start);
					}
					if (chars.IsEmpty)
					{
						break;
					}
				}
				return num;
			}
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x000843E8 File Offset: 0x000825E8
		internal unsafe virtual int GetBytes(char* pChars, int charCount, byte* pBytes, int byteCount, EncoderNLS encoder)
		{
			int num = 0;
			int num2 = 0;
			if (!encoder.HasLeftoverData)
			{
				num = this.GetBytesFast(pChars, charCount, pBytes, byteCount, out num2);
				if (num2 == charCount)
				{
					encoder._charsUsed = charCount;
					return num;
				}
			}
			return this.GetBytesWithFallback(pChars, charCount, pBytes, byteCount, num2, num, encoder);
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0001A4BD File Offset: 0x000186BD
		private protected unsafe virtual int GetBytesFast(char* pChars, int charsLength, byte* pBytes, int bytesLength, out int charsConsumed)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00084430 File Offset: 0x00082630
		[MethodImpl(MethodImplOptions.NoInlining)]
		private protected unsafe int GetBytesWithFallback(char* pOriginalChars, int originalCharCount, byte* pOriginalBytes, int originalByteCount, int charsConsumedSoFar, int bytesWrittenSoFar, bool throwForDestinationOverflow = true)
		{
			return this.GetBytesWithFallback(new ReadOnlySpan<char>((void*)pOriginalChars, originalCharCount).Slice(charsConsumedSoFar), originalCharCount, new Span<byte>((void*)pOriginalBytes, originalByteCount).Slice(bytesWrittenSoFar), originalByteCount, null, throwForDestinationOverflow);
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0008446C File Offset: 0x0008266C
		private unsafe int GetBytesWithFallback(char* pOriginalChars, int originalCharCount, byte* pOriginalBytes, int originalByteCount, int charsConsumedSoFar, int bytesWrittenSoFar, EncoderNLS encoder)
		{
			ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>((void*)pOriginalChars, originalCharCount).Slice(charsConsumedSoFar);
			Span<byte> span = new Span<byte>((void*)pOriginalBytes, originalByteCount).Slice(bytesWrittenSoFar);
			int start;
			int bytesFast;
			bool flag = encoder.TryDrainLeftoverDataForGetBytes(readOnlySpan, span, out start, out bytesFast);
			readOnlySpan = readOnlySpan.Slice(start);
			span = span.Slice(bytesFast);
			if (!flag)
			{
				this.ThrowBytesOverflow(encoder, span.Length == originalByteCount);
			}
			else
			{
				bytesFast = this.GetBytesFast((char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(readOnlySpan)), readOnlySpan.Length, (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(span)), span.Length, out start);
				readOnlySpan = readOnlySpan.Slice(start);
				span = span.Slice(bytesFast);
				if (!readOnlySpan.IsEmpty)
				{
					encoder._charsUsed = originalCharCount;
					return this.GetBytesWithFallback(readOnlySpan, originalCharCount, span, originalByteCount, encoder, true);
				}
			}
			encoder._charsUsed = originalCharCount - readOnlySpan.Length;
			return originalByteCount - span.Length;
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x00084550 File Offset: 0x00082750
		private protected unsafe virtual int GetBytesWithFallback(ReadOnlySpan<char> chars, int originalCharsLength, Span<byte> bytes, int originalBytesLength, EncoderNLS encoder, bool throwForDestinationOverflow = true)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(bytes))
				{
					EncoderFallbackBuffer encoderFallbackBuffer = EncoderFallbackBuffer.CreateAndInitialize(this, encoder, originalCharsLength);
					for (;;)
					{
						Rune value;
						int start;
						OperationStatus operationStatus = Rune.DecodeFromUtf16(chars, out value, out start);
						if (operationStatus != OperationStatus.NeedMoreData)
						{
							int num;
							if (operationStatus != OperationStatus.InvalidData && this.EncodeRune(value, bytes, out num) == OperationStatus.DestinationTooSmall)
							{
								goto IL_E7;
							}
						}
						else if (encoder != null && !encoder.MustFlush)
						{
							break;
						}
						int bytesFast;
						bool flag = encoderFallbackBuffer.TryInternalFallbackGetBytes(chars, bytes, out start, out bytesFast);
						chars = chars.Slice(start);
						bytes = bytes.Slice(bytesFast);
						if (!flag)
						{
							goto IL_E7;
						}
						if (!chars.IsEmpty)
						{
							bytesFast = this.GetBytesFast((char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(chars)), chars.Length, (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(bytes)), bytes.Length, out start);
							chars = chars.Slice(start);
							bytes = bytes.Slice(bytesFast);
						}
						if (chars.IsEmpty)
						{
							goto IL_E7;
						}
					}
					encoder._charLeftOver = (char)(*chars[0]);
					chars = ReadOnlySpan<char>.Empty;
					IL_E7:
					if (!chars.IsEmpty || encoderFallbackBuffer.Remaining > 0)
					{
						if (!throwForDestinationOverflow)
						{
							return -1;
						}
						this.ThrowBytesOverflow(encoder, bytes.Length == originalBytesLength);
					}
					if (encoder != null)
					{
						encoder._charsUsed = originalCharsLength - chars.Length;
					}
					return originalBytesLength - bytes.Length;
				}
			}
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00084690 File Offset: 0x00082890
		internal unsafe virtual int GetCharCount(byte* pBytes, int byteCount, DecoderNLS decoder)
		{
			int num = 0;
			int num2 = 0;
			if (!decoder.HasLeftoverData)
			{
				num = this.GetCharCountFast(pBytes, byteCount, decoder.Fallback, out num2);
				if (num2 == byteCount)
				{
					return num;
				}
			}
			num += this.GetCharCountWithFallback(pBytes, byteCount, num2, decoder);
			if (num < 0)
			{
				Encoding.ThrowConversionOverflow();
			}
			return num;
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x0001A4BD File Offset: 0x000186BD
		private protected unsafe virtual int GetCharCountFast(byte* pBytes, int bytesLength, DecoderFallback fallback, out int bytesConsumed)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000846D8 File Offset: 0x000828D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private protected unsafe int GetCharCountWithFallback(byte* pBytesOriginal, int originalByteCount, int bytesConsumedSoFar)
		{
			return this.GetCharCountWithFallback(new ReadOnlySpan<byte>((void*)pBytesOriginal, originalByteCount).Slice(bytesConsumedSoFar), originalByteCount, null);
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x00084700 File Offset: 0x00082900
		private unsafe int GetCharCountWithFallback(byte* pOriginalBytes, int originalByteCount, int bytesConsumedSoFar, DecoderNLS decoder)
		{
			ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>((void*)pOriginalBytes, originalByteCount).Slice(bytesConsumedSoFar);
			int num = 0;
			int start;
			if (decoder.HasLeftoverData)
			{
				num = decoder.DrainLeftoverDataForGetCharCount(readOnlySpan, out start);
				readOnlySpan = readOnlySpan.Slice(start);
			}
			num += this.GetCharCountFast((byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(readOnlySpan)), readOnlySpan.Length, decoder.Fallback, out start);
			if (num < 0)
			{
				Encoding.ThrowConversionOverflow();
			}
			readOnlySpan = readOnlySpan.Slice(start);
			if (!readOnlySpan.IsEmpty)
			{
				num += this.GetCharCountWithFallback(readOnlySpan, originalByteCount, decoder);
				if (num < 0)
				{
					Encoding.ThrowConversionOverflow();
				}
			}
			return num;
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00084794 File Offset: 0x00082994
		private unsafe int GetCharCountWithFallback(ReadOnlySpan<byte> bytes, int originalBytesLength, DecoderNLS decoder)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				DecoderFallbackBuffer decoderFallbackBuffer = DecoderFallbackBuffer.CreateAndInitialize(this, decoder, originalBytesLength);
				int num = 0;
				Rune rune;
				int num2;
				while (this.DecodeFirstRune(bytes, out rune, out num2) != OperationStatus.NeedMoreData || decoder == null || decoder.MustFlush)
				{
					int num3 = decoderFallbackBuffer.InternalFallbackGetCharCount(bytes, num2);
					num += num3;
					if (num < 0)
					{
						Encoding.ThrowConversionOverflow();
					}
					bytes = bytes.Slice(num2);
					if (!bytes.IsEmpty)
					{
						num3 = this.GetCharCountFast((byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(bytes)), bytes.Length, null, out num2);
						num += num3;
						if (num < 0)
						{
							Encoding.ThrowConversionOverflow();
						}
						bytes = bytes.Slice(num2);
					}
					if (bytes.IsEmpty)
					{
						break;
					}
				}
				return num;
			}
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00084840 File Offset: 0x00082A40
		internal unsafe virtual int GetChars(byte* pBytes, int byteCount, char* pChars, int charCount, DecoderNLS decoder)
		{
			int num = 0;
			int num2 = 0;
			if (!decoder.HasLeftoverData)
			{
				num = this.GetCharsFast(pBytes, byteCount, pChars, charCount, out num2);
				if (num2 == byteCount)
				{
					decoder._bytesUsed = byteCount;
					return num;
				}
			}
			return this.GetCharsWithFallback(pBytes, byteCount, pChars, charCount, num2, num, decoder);
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x0001A4BD File Offset: 0x000186BD
		private protected unsafe virtual int GetCharsFast(byte* pBytes, int bytesLength, char* pChars, int charsLength, out int bytesConsumed)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00084888 File Offset: 0x00082A88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private protected unsafe int GetCharsWithFallback(byte* pOriginalBytes, int originalByteCount, char* pOriginalChars, int originalCharCount, int bytesConsumedSoFar, int charsWrittenSoFar, bool throwForDestinationOverflow = true)
		{
			return this.GetCharsWithFallback(new ReadOnlySpan<byte>((void*)pOriginalBytes, originalByteCount).Slice(bytesConsumedSoFar), originalByteCount, new Span<char>((void*)pOriginalChars, originalCharCount).Slice(charsWrittenSoFar), originalCharCount, null, throwForDestinationOverflow);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000848C4 File Offset: 0x00082AC4
		private protected unsafe int GetCharsWithFallback(byte* pOriginalBytes, int originalByteCount, char* pOriginalChars, int originalCharCount, int bytesConsumedSoFar, int charsWrittenSoFar, DecoderNLS decoder)
		{
			ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>((void*)pOriginalBytes, originalByteCount).Slice(bytesConsumedSoFar);
			Span<char> span = new Span<char>((void*)pOriginalChars, originalCharCount).Slice(charsWrittenSoFar);
			int start2;
			int start;
			if (decoder.HasLeftoverData)
			{
				start = decoder.DrainLeftoverDataForGetChars(readOnlySpan, span, out start2);
				readOnlySpan = readOnlySpan.Slice(start2);
				span = span.Slice(start);
			}
			start = this.GetCharsFast((byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(readOnlySpan)), readOnlySpan.Length, (char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(span)), span.Length, out start2);
			readOnlySpan = readOnlySpan.Slice(start2);
			span = span.Slice(start);
			decoder._bytesUsed = originalByteCount;
			if (readOnlySpan.IsEmpty)
			{
				return originalCharCount - span.Length;
			}
			return this.GetCharsWithFallback(readOnlySpan, originalByteCount, span, originalCharCount, decoder, true);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00084988 File Offset: 0x00082B88
		private protected unsafe virtual int GetCharsWithFallback(ReadOnlySpan<byte> bytes, int originalBytesLength, Span<char> chars, int originalCharsLength, DecoderNLS decoder, bool throwForDestinationOverflow = true)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(chars))
				{
					DecoderFallbackBuffer decoderFallbackBuffer = DecoderFallbackBuffer.CreateAndInitialize(this, decoder, originalBytesLength);
					do
					{
						Rune rune;
						int num;
						OperationStatus operationStatus = this.DecodeFirstRune(bytes, out rune, out num);
						if (operationStatus != OperationStatus.NeedMoreData)
						{
							if (operationStatus != OperationStatus.InvalidData)
							{
								break;
							}
						}
						else if (decoder != null && !decoder.MustFlush)
						{
							goto Block_4;
						}
						int charsFast;
						if (!decoderFallbackBuffer.TryInternalFallbackGetChars(bytes, num, chars, out charsFast))
						{
							break;
						}
						bytes = bytes.Slice(num);
						chars = chars.Slice(charsFast);
						if (!bytes.IsEmpty)
						{
							charsFast = this.GetCharsFast((byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(bytes)), bytes.Length, (char*)Unsafe.AsPointer<char>(MemoryMarshal.GetReference<char>(chars)), chars.Length, out num);
							bytes = bytes.Slice(num);
							chars = chars.Slice(charsFast);
						}
					}
					while (!bytes.IsEmpty);
					goto IL_D0;
					Block_4:
					decoder.SetLeftoverData(bytes);
					bytes = ReadOnlySpan<byte>.Empty;
					IL_D0:
					if (!bytes.IsEmpty)
					{
						if (!throwForDestinationOverflow)
						{
							return -1;
						}
						this.ThrowCharsOverflow(decoder, chars.Length == originalCharsLength);
					}
					if (decoder != null)
					{
						decoder._bytesUsed = originalBytesLength - bytes.Length;
					}
					return originalCharsLength - chars.Length;
				}
			}
		}

		// Token: 0x04000768 RID: 1896
		private static readonly UTF8Encoding.UTF8EncodingSealed s_defaultEncoding = new UTF8Encoding.UTF8EncodingSealed(false);

		// Token: 0x04000769 RID: 1897
		internal int _codePage;

		// Token: 0x0400076A RID: 1898
		internal CodePageDataItem _dataItem;

		// Token: 0x0400076B RID: 1899
		[OptionalField(VersionAdded = 2)]
		private bool _isReadOnly;

		// Token: 0x0400076C RID: 1900
		internal EncoderFallback encoderFallback;

		// Token: 0x0400076D RID: 1901
		internal DecoderFallback decoderFallback;

		// Token: 0x02000229 RID: 553
		internal sealed class DefaultEncoder : Encoder
		{
			// Token: 0x06002A82 RID: 10882 RVA: 0x00084AB4 File Offset: 0x00082CB4
			public DefaultEncoder(Encoding encoding)
			{
				this._encoding = encoding;
			}

			// Token: 0x06002A83 RID: 10883 RVA: 0x00084AC3 File Offset: 0x00082CC3
			public override int GetByteCount(char[] chars, int index, int count, bool flush)
			{
				return this._encoding.GetByteCount(chars, index, count);
			}

			// Token: 0x06002A84 RID: 10884 RVA: 0x00084AD3 File Offset: 0x00082CD3
			public unsafe override int GetByteCount(char* chars, int count, bool flush)
			{
				return this._encoding.GetByteCount(chars, count);
			}

			// Token: 0x06002A85 RID: 10885 RVA: 0x00084AE2 File Offset: 0x00082CE2
			public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
			{
				return this._encoding.GetBytes(chars, charIndex, charCount, bytes, byteIndex);
			}

			// Token: 0x06002A86 RID: 10886 RVA: 0x00084AF6 File Offset: 0x00082CF6
			public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
			{
				return this._encoding.GetBytes(chars, charCount, bytes, byteCount);
			}

			// Token: 0x0400076E RID: 1902
			private readonly Encoding _encoding;
		}

		// Token: 0x0200022A RID: 554
		internal sealed class DefaultDecoder : Decoder
		{
			// Token: 0x06002A87 RID: 10887 RVA: 0x00084B08 File Offset: 0x00082D08
			public DefaultDecoder(Encoding encoding)
			{
				this._encoding = encoding;
			}

			// Token: 0x06002A88 RID: 10888 RVA: 0x00081B28 File Offset: 0x0007FD28
			public override int GetCharCount(byte[] bytes, int index, int count)
			{
				return this.GetCharCount(bytes, index, count, false);
			}

			// Token: 0x06002A89 RID: 10889 RVA: 0x00084B17 File Offset: 0x00082D17
			public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
			{
				return this._encoding.GetCharCount(bytes, index, count);
			}

			// Token: 0x06002A8A RID: 10890 RVA: 0x00084B27 File Offset: 0x00082D27
			public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
			{
				return this._encoding.GetCharCount(bytes, count);
			}

			// Token: 0x06002A8B RID: 10891 RVA: 0x00081BC4 File Offset: 0x0007FDC4
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
			{
				return this.GetChars(bytes, byteIndex, byteCount, chars, charIndex, false);
			}

			// Token: 0x06002A8C RID: 10892 RVA: 0x00084B36 File Offset: 0x00082D36
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
			{
				return this._encoding.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
			}

			// Token: 0x06002A8D RID: 10893 RVA: 0x00084B4A File Offset: 0x00082D4A
			public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
			{
				return this._encoding.GetChars(bytes, byteCount, chars, charCount);
			}

			// Token: 0x0400076F RID: 1903
			private readonly Encoding _encoding;
		}

		// Token: 0x0200022B RID: 555
		internal sealed class EncodingCharBuffer
		{
			// Token: 0x06002A8E RID: 10894 RVA: 0x00084B5C File Offset: 0x00082D5C
			internal unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
			{
				this._enc = enc;
				this._decoder = decoder;
				this._chars = charStart;
				this._charStart = charStart;
				this._charEnd = charStart + charCount;
				this._byteStart = byteStart;
				this._bytes = byteStart;
				this._byteEnd = byteStart + byteCount;
				this._fallbackBuffer = ((this._decoder == null) ? enc.DecoderFallback.CreateFallbackBuffer() : this._decoder.FallbackBuffer);
				this._fallbackBuffer.InternalInitialize(this._bytes, this._charEnd);
			}

			// Token: 0x06002A8F RID: 10895 RVA: 0x00084BF0 File Offset: 0x00082DF0
			internal unsafe bool AddChar(char ch, int numBytes)
			{
				if (this._chars != null)
				{
					if (this._chars >= this._charEnd)
					{
						this._bytes -= numBytes;
						this._enc.ThrowCharsOverflow(this._decoder, this._chars == this._charStart);
						return false;
					}
					char* chars = this._chars;
					this._chars = chars + 1;
					*chars = ch;
				}
				this._charCountResult++;
				return true;
			}

			// Token: 0x06002A90 RID: 10896 RVA: 0x00084C66 File Offset: 0x00082E66
			internal bool AddChar(char ch)
			{
				return this.AddChar(ch, 1);
			}

			// Token: 0x06002A91 RID: 10897 RVA: 0x00084C70 File Offset: 0x00082E70
			internal void AdjustBytes(int count)
			{
				this._bytes += count;
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x06002A92 RID: 10898 RVA: 0x00084C80 File Offset: 0x00082E80
			internal bool MoreData
			{
				get
				{
					return this._bytes < this._byteEnd;
				}
			}

			// Token: 0x06002A93 RID: 10899 RVA: 0x00084C90 File Offset: 0x00082E90
			internal unsafe byte GetNextByte()
			{
				if (this._bytes >= this._byteEnd)
				{
					return 0;
				}
				byte* bytes = this._bytes;
				this._bytes = bytes + 1;
				return *bytes;
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x06002A94 RID: 10900 RVA: 0x00084CBF File Offset: 0x00082EBF
			internal int BytesUsed
			{
				get
				{
					return (int)((long)(this._bytes - this._byteStart));
				}
			}

			// Token: 0x06002A95 RID: 10901 RVA: 0x00084CD4 File Offset: 0x00082ED4
			internal bool Fallback(byte fallbackByte)
			{
				byte[] byteBuffer = new byte[]
				{
					fallbackByte
				};
				return this.Fallback(byteBuffer);
			}

			// Token: 0x06002A96 RID: 10902 RVA: 0x00084CF4 File Offset: 0x00082EF4
			internal unsafe bool Fallback(byte[] byteBuffer)
			{
				if (this._chars != null)
				{
					char* chars = this._chars;
					if (!this._fallbackBuffer.InternalFallback(byteBuffer, this._bytes, ref this._chars))
					{
						this._bytes -= byteBuffer.Length;
						this._fallbackBuffer.InternalReset();
						this._enc.ThrowCharsOverflow(this._decoder, this._chars == this._charStart);
						return false;
					}
					this._charCountResult += (int)((long)(this._chars - chars));
				}
				else
				{
					this._charCountResult += this._fallbackBuffer.InternalFallback(byteBuffer, this._bytes);
				}
				return true;
			}

			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x06002A97 RID: 10903 RVA: 0x00084DA3 File Offset: 0x00082FA3
			internal int Count
			{
				get
				{
					return this._charCountResult;
				}
			}

			// Token: 0x04000770 RID: 1904
			private unsafe char* _chars;

			// Token: 0x04000771 RID: 1905
			private unsafe readonly char* _charStart;

			// Token: 0x04000772 RID: 1906
			private unsafe readonly char* _charEnd;

			// Token: 0x04000773 RID: 1907
			private int _charCountResult;

			// Token: 0x04000774 RID: 1908
			private readonly Encoding _enc;

			// Token: 0x04000775 RID: 1909
			private readonly DecoderNLS _decoder;

			// Token: 0x04000776 RID: 1910
			private unsafe readonly byte* _byteStart;

			// Token: 0x04000777 RID: 1911
			private unsafe readonly byte* _byteEnd;

			// Token: 0x04000778 RID: 1912
			private unsafe byte* _bytes;

			// Token: 0x04000779 RID: 1913
			private readonly DecoderFallbackBuffer _fallbackBuffer;
		}

		// Token: 0x0200022C RID: 556
		internal sealed class EncodingByteBuffer
		{
			// Token: 0x06002A98 RID: 10904 RVA: 0x00084DAC File Offset: 0x00082FAC
			internal unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
			{
				this._enc = inEncoding;
				this._encoder = inEncoder;
				this._charStart = inCharStart;
				this._chars = inCharStart;
				this._charEnd = inCharStart + inCharCount;
				this._bytes = inByteStart;
				this._byteStart = inByteStart;
				this._byteEnd = inByteStart + inByteCount;
				if (this._encoder == null)
				{
					this.fallbackBuffer = this._enc.EncoderFallback.CreateFallbackBuffer();
				}
				else
				{
					this.fallbackBuffer = this._encoder.FallbackBuffer;
					if (this._encoder._throwOnOverflow && this._encoder.InternalHasFallbackBuffer && this.fallbackBuffer.Remaining > 0)
					{
						throw new ArgumentException(SR.Format(SR.Argument_EncoderFallbackNotEmpty, this._encoder.Encoding.EncodingName, this._encoder.Fallback.GetType()));
					}
				}
				this.fallbackBuffer.InternalInitialize(this._chars, this._charEnd, this._encoder, this._bytes != null);
			}

			// Token: 0x06002A99 RID: 10905 RVA: 0x00084EB8 File Offset: 0x000830B8
			internal unsafe bool AddByte(byte b, int moreBytesExpected)
			{
				if (this._bytes != null)
				{
					if (this._bytes >= this._byteEnd - moreBytesExpected)
					{
						this.MovePrevious(true);
						return false;
					}
					byte* bytes = this._bytes;
					this._bytes = bytes + 1;
					*bytes = b;
				}
				this._byteCountResult++;
				return true;
			}

			// Token: 0x06002A9A RID: 10906 RVA: 0x00084F0A File Offset: 0x0008310A
			internal bool AddByte(byte b1)
			{
				return this.AddByte(b1, 0);
			}

			// Token: 0x06002A9B RID: 10907 RVA: 0x00084F14 File Offset: 0x00083114
			internal bool AddByte(byte b1, byte b2)
			{
				return this.AddByte(b1, b2, 0);
			}

			// Token: 0x06002A9C RID: 10908 RVA: 0x00084F1F File Offset: 0x0008311F
			internal bool AddByte(byte b1, byte b2, int moreBytesExpected)
			{
				return this.AddByte(b1, 1 + moreBytesExpected) && this.AddByte(b2, moreBytesExpected);
			}

			// Token: 0x06002A9D RID: 10909 RVA: 0x00084F38 File Offset: 0x00083138
			internal void MovePrevious(bool bThrow)
			{
				if (this.fallbackBuffer.bFallingBack)
				{
					this.fallbackBuffer.MovePrevious();
				}
				else if (this._chars != this._charStart)
				{
					this._chars--;
				}
				if (bThrow)
				{
					this._enc.ThrowBytesOverflow(this._encoder, this._bytes == this._byteStart);
				}
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x06002A9E RID: 10910 RVA: 0x00084F9E File Offset: 0x0008319E
			internal bool MoreData
			{
				get
				{
					return this.fallbackBuffer.Remaining > 0 || this._chars < this._charEnd;
				}
			}

			// Token: 0x06002A9F RID: 10911 RVA: 0x00084FC0 File Offset: 0x000831C0
			internal unsafe char GetNextChar()
			{
				char c = this.fallbackBuffer.InternalGetNextChar();
				if (c == '\0' && this._chars < this._charEnd)
				{
					char* chars = this._chars;
					this._chars = chars + 1;
					c = *chars;
				}
				return c;
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x00084FFE File Offset: 0x000831FE
			internal int CharsUsed
			{
				get
				{
					return (int)((long)(this._chars - this._charStart));
				}
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x00085011 File Offset: 0x00083211
			internal int Count
			{
				get
				{
					return this._byteCountResult;
				}
			}

			// Token: 0x0400077A RID: 1914
			private unsafe byte* _bytes;

			// Token: 0x0400077B RID: 1915
			private unsafe readonly byte* _byteStart;

			// Token: 0x0400077C RID: 1916
			private unsafe readonly byte* _byteEnd;

			// Token: 0x0400077D RID: 1917
			private unsafe char* _chars;

			// Token: 0x0400077E RID: 1918
			private unsafe readonly char* _charStart;

			// Token: 0x0400077F RID: 1919
			private unsafe readonly char* _charEnd;

			// Token: 0x04000780 RID: 1920
			private int _byteCountResult;

			// Token: 0x04000781 RID: 1921
			private readonly Encoding _enc;

			// Token: 0x04000782 RID: 1922
			private readonly EncoderNLS _encoder;

			// Token: 0x04000783 RID: 1923
			internal EncoderFallbackBuffer fallbackBuffer;
		}
	}
}

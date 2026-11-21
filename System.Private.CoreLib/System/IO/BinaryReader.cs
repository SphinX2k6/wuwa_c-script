using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.IO
{
	// Token: 0x020007D8 RID: 2008
	[NullableContext(1)]
	[Nullable(0)]
	public class BinaryReader : IDisposable
	{
		// Token: 0x060080AE RID: 32942 RVA: 0x0013004F File Offset: 0x0012E24F
		public BinaryReader(Stream input) : this(input, Encoding.UTF8, false)
		{
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x0013005E File Offset: 0x0012E25E
		public BinaryReader(Stream input, Encoding encoding) : this(input, encoding, false)
		{
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x0013006C File Offset: 0x0012E26C
		public BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
		{
			ArgumentNullException.ThrowIfNull(input, "input");
			ArgumentNullException.ThrowIfNull(encoding, "encoding");
			if (!input.CanRead)
			{
				throw new ArgumentException(SR.Argument_StreamNotReadable);
			}
			this._stream = input;
			this._encoding = encoding;
			this._maxCharsSize = encoding.GetMaxCharCount(128);
			this._2BytesPerChar = (encoding is UnicodeEncoding);
			this._isMemoryStream = (this._stream.GetType() == typeof(MemoryStream));
			this._leaveOpen = leaveOpen;
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060080B1 RID: 32945 RVA: 0x001300FD File Offset: 0x0012E2FD
		public virtual Stream BaseStream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x00130105 File Offset: 0x0012E305
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing && !this._leaveOpen)
				{
					this._stream.Close();
				}
				this._disposed = true;
			}
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x0013012C File Offset: 0x0012E32C
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x0013012C File Offset: 0x0012E32C
		public virtual void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x00130135 File Offset: 0x0012E335
		private void ThrowIfDisposed()
		{
			if (this._disposed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x00130144 File Offset: 0x0012E344
		public virtual int PeekChar()
		{
			this.ThrowIfDisposed();
			if (!this._stream.CanSeek)
			{
				return -1;
			}
			long position = this._stream.Position;
			int result = this.Read();
			this._stream.Position = position;
			return result;
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x00130184 File Offset: 0x0012E384
		public unsafe virtual int Read()
		{
			this.ThrowIfDisposed();
			int num = 0;
			long num2 = 0L;
			if (this._stream.CanSeek)
			{
				num2 = this._stream.Position;
			}
			if (this._decoder == null)
			{
				this._decoder = this._encoding.GetDecoder();
			}
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)128], 128);
			char result = '\0';
			while (num == 0)
			{
				int num3 = this._2BytesPerChar ? 2 : 1;
				int num4 = this._stream.ReadByte();
				*span[0] = (byte)num4;
				if (num4 == -1)
				{
					num3 = 0;
				}
				if (num3 == 2)
				{
					num4 = this._stream.ReadByte();
					*span[1] = (byte)num4;
					if (num4 == -1)
					{
						num3 = 1;
					}
				}
				if (num3 == 0)
				{
					return -1;
				}
				try
				{
					num = this._decoder.GetChars(span.Slice(0, num3), new Span<char>(ref result), false);
				}
				catch
				{
					if (this._stream.CanSeek)
					{
						this._stream.Seek(num2 - this._stream.Position, SeekOrigin.Current);
					}
					throw;
				}
			}
			return (int)result;
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x001302A8 File Offset: 0x0012E4A8
		public virtual byte ReadByte()
		{
			return this.InternalReadByte();
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x001302B0 File Offset: 0x0012E4B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private byte InternalReadByte()
		{
			this.ThrowIfDisposed();
			int num = this._stream.ReadByte();
			if (num == -1)
			{
				ThrowHelper.ThrowEndOfFileException();
			}
			return (byte)num;
		}

		// Token: 0x060080BA RID: 32954 RVA: 0x001302CD File Offset: 0x0012E4CD
		[CLSCompliant(false)]
		public virtual sbyte ReadSByte()
		{
			return (sbyte)this.InternalReadByte();
		}

		// Token: 0x060080BB RID: 32955 RVA: 0x001302D6 File Offset: 0x0012E4D6
		public virtual bool ReadBoolean()
		{
			return this.InternalReadByte() > 0;
		}

		// Token: 0x060080BC RID: 32956 RVA: 0x001302E1 File Offset: 0x0012E4E1
		public virtual char ReadChar()
		{
			int num = this.Read();
			if (num == -1)
			{
				ThrowHelper.ThrowEndOfFileException();
			}
			return (char)num;
		}

		// Token: 0x060080BD RID: 32957 RVA: 0x001302F4 File Offset: 0x0012E4F4
		public unsafe virtual short ReadInt16()
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)2], 2);
			return BinaryPrimitives.ReadInt16LittleEndian(this.InternalRead(buffer));
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x00130318 File Offset: 0x0012E518
		[CLSCompliant(false)]
		public unsafe virtual ushort ReadUInt16()
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)2], 2);
			return BinaryPrimitives.ReadUInt16LittleEndian(this.InternalRead(buffer));
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x0013033C File Offset: 0x0012E53C
		public unsafe virtual int ReadInt32()
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)4], 4);
			return BinaryPrimitives.ReadInt32LittleEndian(this.InternalRead(buffer));
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x00130360 File Offset: 0x0012E560
		[CLSCompliant(false)]
		public unsafe virtual uint ReadUInt32()
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)4], 4);
			return BinaryPrimitives.ReadUInt32LittleEndian(this.InternalRead(buffer));
		}

		// Token: 0x060080C1 RID: 32961 RVA: 0x00130384 File Offset: 0x0012E584
		public unsafe virtual long ReadInt64()
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)8], 8);
			return BinaryPrimitives.ReadInt64LittleEndian(this.InternalRead(buffer));
		}

		// Token: 0x060080C2 RID: 32962 RVA: 0x001303A8 File Offset: 0x0012E5A8
		[CLSCompliant(false)]
		public unsafe virtual ulong ReadUInt64()
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)8], 8);
			return BinaryPrimitives.ReadUInt64LittleEndian(this.InternalRead(buffer));
		}

		// Token: 0x060080C3 RID: 32963 RVA: 0x001303CC File Offset: 0x0012E5CC
		public unsafe virtual Half ReadHalf()
		{
			int num = sizeof(Half);
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)num], num);
			return BinaryPrimitives.ReadHalfLittleEndian(this.InternalRead(buffer));
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x001303F8 File Offset: 0x0012E5F8
		public unsafe virtual float ReadSingle()
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)4], 4);
			return BinaryPrimitives.ReadSingleLittleEndian(this.InternalRead(buffer));
		}

		// Token: 0x060080C5 RID: 32965 RVA: 0x0013041C File Offset: 0x0012E61C
		public unsafe virtual double ReadDouble()
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)8], 8);
			return BinaryPrimitives.ReadDoubleLittleEndian(this.InternalRead(buffer));
		}

		// Token: 0x060080C6 RID: 32966 RVA: 0x00130440 File Offset: 0x0012E640
		public unsafe virtual decimal ReadDecimal()
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)16], 16);
			ReadOnlySpan<byte> span = this.InternalRead(buffer);
			decimal result;
			try
			{
				result = decimal.ToDecimal(span);
			}
			catch (ArgumentException innerException)
			{
				throw new IOException(SR.Arg_DecBitCtor, innerException);
			}
			return result;
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x0013048C File Offset: 0x0012E68C
		public unsafe virtual string ReadString()
		{
			this.ThrowIfDisposed();
			int num = this.Read7BitEncodedInt();
			if (num < 0)
			{
				throw new IOException(SR.Format(SR.IO_InvalidStringLen_Len, num));
			}
			if (num == 0)
			{
				return string.Empty;
			}
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)128], 128);
			int num2 = 0;
			StringBuilder stringBuilder = null;
			int num3;
			for (;;)
			{
				int length = Math.Min(128, num - num2);
				num3 = this._stream.Read(span.Slice(0, length));
				if (num3 == 0)
				{
					ThrowHelper.ThrowEndOfFileException();
				}
				if (num2 == 0 && num3 == num)
				{
					break;
				}
				if (this._decoder == null)
				{
					this._decoder = this._encoding.GetDecoder();
				}
				if (this._charBuffer == null)
				{
					this._charBuffer = new char[this._maxCharsSize];
				}
				int chars = this._decoder.GetChars(span.Slice(0, num3), this._charBuffer, false);
				if (stringBuilder == null)
				{
					stringBuilder = StringBuilderCache.Acquire(Math.Min(num, 360));
				}
				stringBuilder.Append(this._charBuffer, 0, chars);
				num2 += num3;
				if (num2 >= num)
				{
					goto Block_9;
				}
			}
			return this._encoding.GetString(span.Slice(0, num3));
			Block_9:
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x001305C4 File Offset: 0x0012E7C4
		public virtual int Read(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			this.ThrowIfDisposed();
			return this.InternalReadChars(new Span<char>(buffer, index, count));
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x00130619 File Offset: 0x0012E819
		[NullableContext(0)]
		public virtual int Read(Span<char> buffer)
		{
			this.ThrowIfDisposed();
			return this.InternalReadChars(buffer);
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x00130628 File Offset: 0x0012E828
		private unsafe int InternalReadChars(Span<char> buffer)
		{
			if (this._decoder == null)
			{
				this._decoder = this._encoding.GetDecoder();
			}
			int num = 0;
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)128], 128);
			while (!buffer.IsEmpty)
			{
				int num2 = buffer.Length;
				if (this._2BytesPerChar)
				{
					num2 <<= 1;
				}
				if (num2 > 1)
				{
					DecoderNLS decoderNLS = this._decoder as DecoderNLS;
					if (decoderNLS == null || decoderNLS.HasState)
					{
						num2--;
						if (this._2BytesPerChar && num2 > 2)
						{
							num2 -= 2;
						}
					}
				}
				ReadOnlySpan<byte> bytes;
				if (this._isMemoryStream)
				{
					MemoryStream memoryStream = Unsafe.As<MemoryStream>(this._stream);
					int start = memoryStream.InternalGetPosition();
					num2 = memoryStream.InternalEmulateRead(num2);
					bytes = new ReadOnlySpan<byte>(memoryStream.InternalGetBuffer(), start, num2);
				}
				else
				{
					if (num2 > 128)
					{
						num2 = 128;
					}
					num2 = this._stream.Read(span.Slice(0, num2));
					bytes = span.Slice(0, num2);
				}
				if (bytes.IsEmpty)
				{
					break;
				}
				int chars = this._decoder.GetChars(bytes, buffer, false);
				buffer = buffer.Slice(chars);
				num += chars;
			}
			return num;
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x00130750 File Offset: 0x0012E950
		public virtual char[] ReadChars(int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			this.ThrowIfDisposed();
			if (count == 0)
			{
				return Array.Empty<char>();
			}
			char[] array = new char[count];
			int num = this.InternalReadChars(new Span<char>(array));
			if (num != count)
			{
				array = RuntimeHelpers.GetSubArray<char>(array, Range.EndAt(num));
			}
			return array;
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x001307A4 File Offset: 0x0012E9A4
		public virtual int Read(byte[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			this.ThrowIfDisposed();
			return this._stream.Read(buffer, index, count);
		}

		// Token: 0x060080CD RID: 32973 RVA: 0x001307F9 File Offset: 0x0012E9F9
		[NullableContext(0)]
		public virtual int Read(Span<byte> buffer)
		{
			this.ThrowIfDisposed();
			return this._stream.Read(buffer);
		}

		// Token: 0x060080CE RID: 32974 RVA: 0x00130810 File Offset: 0x0012EA10
		public virtual byte[] ReadBytes(int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			this.ThrowIfDisposed();
			if (count == 0)
			{
				return Array.Empty<byte>();
			}
			byte[] array = new byte[count];
			int num = this._stream.ReadAtLeast(array, array.Length, false);
			if (num != array.Length)
			{
				array = RuntimeHelpers.GetSubArray<byte>(array, Range.EndAt(num));
			}
			return array;
		}

		// Token: 0x060080CF RID: 32975 RVA: 0x0013086D File Offset: 0x0012EA6D
		private ReadOnlySpan<byte> InternalRead(Span<byte> buffer)
		{
			if (this._isMemoryStream)
			{
				return Unsafe.As<MemoryStream>(this._stream).InternalReadSpan(buffer.Length);
			}
			this.ThrowIfDisposed();
			this._stream.ReadExactly(buffer);
			return buffer;
		}

		// Token: 0x060080D0 RID: 32976 RVA: 0x001308A8 File Offset: 0x0012EAA8
		protected virtual void FillBuffer(int numBytes)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(numBytes, "numBytes");
			this.ThrowIfDisposed();
			if (numBytes != 0)
			{
				if (numBytes != 1)
				{
					if (this._stream.CanSeek)
					{
						this._stream.Seek((long)numBytes, SeekOrigin.Current);
						return;
					}
					byte[] array = ArrayPool<byte>.Shared.Rent(numBytes);
					this._stream.ReadExactly(array.AsSpan(0, numBytes));
					ArrayPool<byte>.Shared.Return(array, false);
				}
				else if (this._stream.ReadByte() == -1)
				{
					ThrowHelper.ThrowEndOfFileException();
					return;
				}
			}
			else if (this._stream.Read(Array.Empty<byte>(), 0, 0) == 0)
			{
				ThrowHelper.ThrowEndOfFileException();
				return;
			}
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x00130948 File Offset: 0x0012EB48
		public int Read7BitEncodedInt()
		{
			uint num = 0U;
			byte b;
			for (int i = 0; i < 28; i += 7)
			{
				b = this.ReadByte();
				num |= (uint)((uint)(b & 127) << i);
				if (b <= 127)
				{
					return (int)num;
				}
			}
			b = this.ReadByte();
			if (b > 15)
			{
				throw new FormatException(SR.Format_Bad7BitInt);
			}
			return (int)(num | (uint)((uint)b << 28));
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x001309A0 File Offset: 0x0012EBA0
		public long Read7BitEncodedInt64()
		{
			ulong num = 0UL;
			byte b;
			for (int i = 0; i < 63; i += 7)
			{
				b = this.ReadByte();
				num |= ((ulong)b & 127UL) << i;
				if (b <= 127)
				{
					return (long)num;
				}
			}
			b = this.ReadByte();
			if (b > 1)
			{
				throw new FormatException(SR.Format_Bad7BitInt);
			}
			return (long)(num | (ulong)b << 63);
		}

		// Token: 0x04001AD2 RID: 6866
		private readonly Stream _stream;

		// Token: 0x04001AD3 RID: 6867
		private readonly Encoding _encoding;

		// Token: 0x04001AD4 RID: 6868
		private Decoder _decoder;

		// Token: 0x04001AD5 RID: 6869
		private char[] _charBuffer;

		// Token: 0x04001AD6 RID: 6870
		private readonly int _maxCharsSize;

		// Token: 0x04001AD7 RID: 6871
		private readonly bool _2BytesPerChar;

		// Token: 0x04001AD8 RID: 6872
		private readonly bool _isMemoryStream;

		// Token: 0x04001AD9 RID: 6873
		private readonly bool _leaveOpen;

		// Token: 0x04001ADA RID: 6874
		private bool _disposed;
	}
}

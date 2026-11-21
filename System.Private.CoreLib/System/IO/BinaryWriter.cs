using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x020007D9 RID: 2009
	[NullableContext(1)]
	[Nullable(0)]
	public class BinaryWriter : IDisposable, IAsyncDisposable
	{
		// Token: 0x060080D3 RID: 32979 RVA: 0x001309F8 File Offset: 0x0012EBF8
		protected BinaryWriter()
		{
			this.OutStream = Stream.Null;
			this._encoding = Encoding.UTF8;
			this._useFastUtf8 = true;
		}

		// Token: 0x060080D4 RID: 32980 RVA: 0x00130A1D File Offset: 0x0012EC1D
		public BinaryWriter(Stream output) : this(output, Encoding.UTF8, false)
		{
		}

		// Token: 0x060080D5 RID: 32981 RVA: 0x00130A2C File Offset: 0x0012EC2C
		public BinaryWriter(Stream output, Encoding encoding) : this(output, encoding, false)
		{
		}

		// Token: 0x060080D6 RID: 32982 RVA: 0x00130A38 File Offset: 0x0012EC38
		public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen)
		{
			ArgumentNullException.ThrowIfNull(output, "output");
			ArgumentNullException.ThrowIfNull(encoding, "encoding");
			if (!output.CanWrite)
			{
				throw new ArgumentException(SR.Argument_StreamNotWritable);
			}
			this.OutStream = output;
			this._encoding = encoding;
			this._leaveOpen = leaveOpen;
			this._useFastUtf8 = (encoding.IsUTF8CodePage && encoding.EncoderFallback.MaxCharCount <= 1);
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x00130AAB File Offset: 0x0012ECAB
		public virtual void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x060080D8 RID: 32984 RVA: 0x00130AB4 File Offset: 0x0012ECB4
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this._leaveOpen)
				{
					this.OutStream.Flush();
					return;
				}
				this.OutStream.Close();
			}
		}

		// Token: 0x060080D9 RID: 32985 RVA: 0x00130AAB File Offset: 0x0012ECAB
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x060080DA RID: 32986 RVA: 0x00130AD8 File Offset: 0x0012ECD8
		public virtual ValueTask DisposeAsync()
		{
			ValueTask result;
			try
			{
				if (base.GetType() == typeof(BinaryWriter))
				{
					if (this._leaveOpen)
					{
						return new ValueTask(this.OutStream.FlushAsync());
					}
					this.OutStream.Close();
				}
				else
				{
					this.Dispose();
				}
				result = default(ValueTask);
			}
			catch (Exception exception)
			{
				result = ValueTask.FromException(exception);
			}
			return result;
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060080DB RID: 32987 RVA: 0x00130B50 File Offset: 0x0012ED50
		public virtual Stream BaseStream
		{
			get
			{
				this.Flush();
				return this.OutStream;
			}
		}

		// Token: 0x060080DC RID: 32988 RVA: 0x00130B5E File Offset: 0x0012ED5E
		public virtual void Flush()
		{
			this.OutStream.Flush();
		}

		// Token: 0x060080DD RID: 32989 RVA: 0x00130B6B File Offset: 0x0012ED6B
		public virtual long Seek(int offset, SeekOrigin origin)
		{
			return this.OutStream.Seek((long)offset, origin);
		}

		// Token: 0x060080DE RID: 32990 RVA: 0x00130B7B File Offset: 0x0012ED7B
		public virtual void Write(bool value)
		{
			this.OutStream.WriteByte((value > false) ? 1 : 0);
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x00130B8D File Offset: 0x0012ED8D
		public virtual void Write(byte value)
		{
			this.OutStream.WriteByte(value);
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x00130B9B File Offset: 0x0012ED9B
		[CLSCompliant(false)]
		public virtual void Write(sbyte value)
		{
			this.OutStream.WriteByte((byte)value);
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x00130BAA File Offset: 0x0012EDAA
		public virtual void Write(byte[] buffer)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			this.OutStream.Write(buffer, 0, buffer.Length);
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x00130BC7 File Offset: 0x0012EDC7
		public virtual void Write(byte[] buffer, int index, int count)
		{
			this.OutStream.Write(buffer, index, count);
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x00130BD8 File Offset: 0x0012EDD8
		public unsafe virtual void Write(char ch)
		{
			Rune rune;
			if (!Rune.TryCreate(ch, out rune))
			{
				throw new ArgumentException(SR.Arg_SurrogatesNotAllowedAsSingleChar);
			}
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)8], 8);
			if (this._useFastUtf8)
			{
				int length = rune.EncodeToUtf8(span);
				this.OutStream.Write(span.Slice(0, length));
				return;
			}
			byte[] array = null;
			int maxByteCount = this._encoding.GetMaxByteCount(1);
			if (maxByteCount > span.Length)
			{
				array = ArrayPool<byte>.Shared.Rent(maxByteCount);
				span = array;
			}
			int bytes = this._encoding.GetBytes(new ReadOnlySpan<char>(ref ch), span);
			this.OutStream.Write(span.Slice(0, bytes));
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x00130C9D File Offset: 0x0012EE9D
		public virtual void Write(char[] chars)
		{
			ArgumentNullException.ThrowIfNull(chars, "chars");
			this.WriteCharsCommonWithoutLengthPrefix(chars, false);
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x00130CB8 File Offset: 0x0012EEB8
		public virtual void Write(char[] chars, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (index > chars.Length - count)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexCount);
			}
			this.WriteCharsCommonWithoutLengthPrefix(chars.AsSpan(index, count), false);
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x00130D14 File Offset: 0x0012EF14
		public unsafe virtual void Write(double value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)8], 8);
			BinaryPrimitives.WriteDoubleLittleEndian(span, value);
			this.OutStream.Write(span);
		}

		// Token: 0x060080E7 RID: 32999 RVA: 0x00130D44 File Offset: 0x0012EF44
		public unsafe virtual void Write(decimal value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)16], 16);
			decimal.GetBytes(value, span);
			this.OutStream.Write(span);
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x00130D78 File Offset: 0x0012EF78
		public unsafe virtual void Write(short value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)2], 2);
			BinaryPrimitives.WriteInt16LittleEndian(span, value);
			this.OutStream.Write(span);
		}

		// Token: 0x060080E9 RID: 33001 RVA: 0x00130DA8 File Offset: 0x0012EFA8
		[CLSCompliant(false)]
		public unsafe virtual void Write(ushort value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)2], 2);
			BinaryPrimitives.WriteUInt16LittleEndian(span, value);
			this.OutStream.Write(span);
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x00130DD8 File Offset: 0x0012EFD8
		public unsafe virtual void Write(int value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)4], 4);
			BinaryPrimitives.WriteInt32LittleEndian(span, value);
			this.OutStream.Write(span);
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x00130E08 File Offset: 0x0012F008
		[CLSCompliant(false)]
		public unsafe virtual void Write(uint value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)4], 4);
			BinaryPrimitives.WriteUInt32LittleEndian(span, value);
			this.OutStream.Write(span);
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x00130E38 File Offset: 0x0012F038
		public unsafe virtual void Write(long value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)8], 8);
			BinaryPrimitives.WriteInt64LittleEndian(span, value);
			this.OutStream.Write(span);
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x00130E68 File Offset: 0x0012F068
		[CLSCompliant(false)]
		public unsafe virtual void Write(ulong value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)8], 8);
			BinaryPrimitives.WriteUInt64LittleEndian(span, value);
			this.OutStream.Write(span);
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x00130E98 File Offset: 0x0012F098
		public unsafe virtual void Write(float value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)4], 4);
			BinaryPrimitives.WriteSingleLittleEndian(span, value);
			this.OutStream.Write(span);
		}

		// Token: 0x060080EF RID: 33007 RVA: 0x00130EC8 File Offset: 0x0012F0C8
		public unsafe virtual void Write(Half value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)2], 2);
			BinaryPrimitives.WriteHalfLittleEndian(span, value);
			this.OutStream.Write(span);
		}

		// Token: 0x060080F0 RID: 33008 RVA: 0x00130EF8 File Offset: 0x0012F0F8
		public unsafe virtual void Write(string value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			if (this._useFastUtf8)
			{
				if (value.Length <= 42)
				{
					Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)128], 128);
					int bytes = this._encoding.GetBytes(value, span.Slice(1));
					*span[0] = (byte)bytes;
					this.OutStream.Write(span.Slice(0, bytes + 1));
					return;
				}
				if (value.Length <= 21845)
				{
					byte[] array = ArrayPool<byte>.Shared.Rent(value.Length * 3);
					int bytes2 = this._encoding.GetBytes(value, array);
					this.Write7BitEncodedInt(bytes2);
					this.OutStream.Write(array, 0, bytes2);
					ArrayPool<byte>.Shared.Return(array, false);
					return;
				}
			}
			int byteCount = this._encoding.GetByteCount(value);
			this.Write7BitEncodedInt(byteCount);
			this.WriteCharsCommonWithoutLengthPrefix(value, false);
		}

		// Token: 0x060080F1 RID: 33009 RVA: 0x00130FF8 File Offset: 0x0012F1F8
		[NullableContext(0)]
		public virtual void Write(ReadOnlySpan<byte> buffer)
		{
			if (base.GetType() == typeof(BinaryWriter))
			{
				this.OutStream.Write(buffer);
				return;
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			try
			{
				buffer.CopyTo(array);
				this.Write(array, 0, buffer.Length);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x00131078 File Offset: 0x0012F278
		[NullableContext(0)]
		public virtual void Write(ReadOnlySpan<char> chars)
		{
			this.WriteCharsCommonWithoutLengthPrefix(chars, true);
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x00131084 File Offset: 0x0012F284
		private void WriteCharsCommonWithoutLengthPrefix(ReadOnlySpan<char> chars, bool useThisWriteOverride)
		{
			byte[] array;
			if (chars.Length <= 65536)
			{
				int maxByteCount = this._encoding.GetMaxByteCount(chars.Length);
				if (maxByteCount <= 65536)
				{
					array = ArrayPool<byte>.Shared.Rent(maxByteCount);
					int bytes = this._encoding.GetBytes(chars, array);
					this.<WriteCharsCommonWithoutLengthPrefix>g__WriteToOutStream|39_0(array, 0, bytes, useThisWriteOverride);
					ArrayPool<byte>.Shared.Return(array, false);
					return;
				}
			}
			array = ArrayPool<byte>.Shared.Rent(65536);
			Encoder encoder = this._encoding.GetEncoder();
			bool flag;
			do
			{
				int start;
				int num;
				encoder.Convert(chars, array, true, out start, out num, out flag);
				if (num != 0)
				{
					this.<WriteCharsCommonWithoutLengthPrefix>g__WriteToOutStream|39_0(array, 0, num, useThisWriteOverride);
				}
				chars = chars.Slice(start);
			}
			while (!flag);
			ArrayPool<byte>.Shared.Return(array, false);
		}

		// Token: 0x060080F4 RID: 33012 RVA: 0x0013114C File Offset: 0x0012F34C
		public void Write7BitEncodedInt(int value)
		{
			uint num;
			for (num = (uint)value; num > 127U; num >>= 7)
			{
				this.Write((byte)(num | 4294967168U));
			}
			this.Write((byte)num);
		}

		// Token: 0x060080F5 RID: 33013 RVA: 0x0013117C File Offset: 0x0012F37C
		public void Write7BitEncodedInt64(long value)
		{
			ulong num;
			for (num = (ulong)value; num > 127UL; num >>= 7)
			{
				this.Write((byte)((uint)num | 4294967168U));
			}
			this.Write((byte)num);
		}

		// Token: 0x060080F7 RID: 33015 RVA: 0x001311B7 File Offset: 0x0012F3B7
		[CompilerGenerated]
		private void <WriteCharsCommonWithoutLengthPrefix>g__WriteToOutStream|39_0(byte[] buffer, int offset, int count, bool useThisWriteOverride)
		{
			if (useThisWriteOverride)
			{
				this.Write(buffer, offset, count);
				return;
			}
			this.OutStream.Write(buffer, offset, count);
		}

		// Token: 0x04001ADB RID: 6875
		public static readonly BinaryWriter Null = new BinaryWriter();

		// Token: 0x04001ADC RID: 6876
		protected Stream OutStream;

		// Token: 0x04001ADD RID: 6877
		private readonly Encoding _encoding;

		// Token: 0x04001ADE RID: 6878
		private readonly bool _leaveOpen;

		// Token: 0x04001ADF RID: 6879
		private readonly bool _useFastUtf8;
	}
}

using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000823 RID: 2083
	[NullableContext(1)]
	[Nullable(0)]
	public class StreamReader : TextReader
	{
		// Token: 0x0600849B RID: 33947 RVA: 0x0013E586 File Offset: 0x0013C786
		private void CheckAsyncTaskInProgress()
		{
			if (!this._asyncReadTask.IsCompleted)
			{
				StreamReader.ThrowAsyncIOInProgress();
			}
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x0013E59A File Offset: 0x0013C79A
		[DoesNotReturn]
		private static void ThrowAsyncIOInProgress()
		{
			throw new InvalidOperationException(SR.InvalidOperation_AsyncIOInProgress);
		}

		// Token: 0x0600849D RID: 33949 RVA: 0x0013E5A6 File Offset: 0x0013C7A6
		private StreamReader()
		{
			this._stream = Stream.Null;
			this._closable = true;
		}

		// Token: 0x0600849E RID: 33950 RVA: 0x0013E5CB File Offset: 0x0013C7CB
		public StreamReader(Stream stream) : this(stream, true)
		{
		}

		// Token: 0x0600849F RID: 33951 RVA: 0x0013E5D5 File Offset: 0x0013C7D5
		public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks) : this(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks, 1024, false)
		{
		}

		// Token: 0x060084A0 RID: 33952 RVA: 0x0013E5EA File Offset: 0x0013C7EA
		public StreamReader(Stream stream, Encoding encoding) : this(stream, encoding, true, 1024, false)
		{
		}

		// Token: 0x060084A1 RID: 33953 RVA: 0x0013E5FB File Offset: 0x0013C7FB
		public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks) : this(stream, encoding, detectEncodingFromByteOrderMarks, 1024, false)
		{
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x0013E60C File Offset: 0x0013C80C
		public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) : this(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, false)
		{
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x0013E61C File Offset: 0x0013C81C
		public StreamReader(Stream stream, [Nullable(2)] Encoding encoding = null, bool detectEncodingFromByteOrderMarks = true, int bufferSize = -1, bool leaveOpen = false)
		{
			if (stream == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.stream);
			}
			if (!stream.CanRead)
			{
				throw new ArgumentException(SR.Argument_StreamNotReadable);
			}
			if (bufferSize == -1)
			{
				bufferSize = 1024;
			}
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(bufferSize, "bufferSize");
			this._stream = stream;
			Encoding encoding2;
			if ((encoding2 = encoding) == null)
			{
				encoding2 = (encoding = Encoding.UTF8);
			}
			this._encoding = encoding2;
			this._decoder = encoding.GetDecoder();
			if (bufferSize < 128)
			{
				bufferSize = 128;
			}
			this._byteBuffer = new byte[bufferSize];
			this._maxCharsPerBuffer = encoding.GetMaxCharCount(bufferSize);
			this._charBuffer = new char[this._maxCharsPerBuffer];
			this._detectEncoding = detectEncodingFromByteOrderMarks;
			int length = encoding.Preamble.Length;
			this._checkPreamble = (length > 0 && length <= bufferSize);
			this._closable = !leaveOpen;
		}

		// Token: 0x060084A4 RID: 33956 RVA: 0x0013E707 File Offset: 0x0013C907
		public StreamReader(string path) : this(path, true)
		{
		}

		// Token: 0x060084A5 RID: 33957 RVA: 0x0013E711 File Offset: 0x0013C911
		public StreamReader(string path, bool detectEncodingFromByteOrderMarks) : this(path, Encoding.UTF8, detectEncodingFromByteOrderMarks, 1024)
		{
		}

		// Token: 0x060084A6 RID: 33958 RVA: 0x0013E725 File Offset: 0x0013C925
		public StreamReader(string path, Encoding encoding) : this(path, encoding, true, 1024)
		{
		}

		// Token: 0x060084A7 RID: 33959 RVA: 0x0013E735 File Offset: 0x0013C935
		public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) : this(path, encoding, detectEncodingFromByteOrderMarks, 1024)
		{
		}

		// Token: 0x060084A8 RID: 33960 RVA: 0x0013E745 File Offset: 0x0013C945
		public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) : this(StreamReader.ValidateArgsAndOpenPath(path, encoding, bufferSize), encoding, detectEncodingFromByteOrderMarks, bufferSize, false)
		{
		}

		// Token: 0x060084A9 RID: 33961 RVA: 0x0013E75B File Offset: 0x0013C95B
		public StreamReader(string path, FileStreamOptions options) : this(path, Encoding.UTF8, true, options)
		{
		}

		// Token: 0x060084AA RID: 33962 RVA: 0x0013E76B File Offset: 0x0013C96B
		public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, FileStreamOptions options) : this(StreamReader.ValidateArgsAndOpenPath(path, encoding, options), encoding, detectEncodingFromByteOrderMarks, 1024)
		{
		}

		// Token: 0x060084AB RID: 33963 RVA: 0x0013E784 File Offset: 0x0013C984
		private static FileStream ValidateArgsAndOpenPath(string path, Encoding encoding, FileStreamOptions options)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			ArgumentNullException.ThrowIfNull(encoding, "encoding");
			ArgumentNullException.ThrowIfNull(options, "options");
			if ((options.Access & FileAccess.Read) == (FileAccess)0)
			{
				throw new ArgumentException(SR.Argument_StreamNotReadable, "options");
			}
			return new FileStream(path, options);
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x0013E7D3 File Offset: 0x0013C9D3
		private static FileStream ValidateArgsAndOpenPath(string path, Encoding encoding, int bufferSize)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			ArgumentNullException.ThrowIfNull(encoding, "encoding");
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(bufferSize, "bufferSize");
			return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096);
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x0013E804 File Offset: 0x0013CA04
		public override void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x060084AE RID: 33966 RVA: 0x0013E810 File Offset: 0x0013CA10
		protected override void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			this._disposed = true;
			if (this._closable)
			{
				try
				{
					if (disposing)
					{
						this._stream.Close();
					}
				}
				finally
				{
					this._charPos = 0;
					this._charLen = 0;
					base.Dispose(disposing);
				}
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x060084AF RID: 33967 RVA: 0x0013E86C File Offset: 0x0013CA6C
		public virtual Encoding CurrentEncoding
		{
			get
			{
				return this._encoding;
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x060084B0 RID: 33968 RVA: 0x0013E874 File Offset: 0x0013CA74
		public virtual Stream BaseStream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x060084B1 RID: 33969 RVA: 0x0013E87C File Offset: 0x0013CA7C
		public void DiscardBufferedData()
		{
			this.CheckAsyncTaskInProgress();
			this._byteLen = 0;
			this._charLen = 0;
			this._charPos = 0;
			if (this._encoding != null)
			{
				this._decoder = this._encoding.GetDecoder();
			}
			this._isBlocked = false;
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x060084B2 RID: 33970 RVA: 0x0013E8B9 File Offset: 0x0013CAB9
		public bool EndOfStream
		{
			get
			{
				this.ThrowIfDisposed();
				this.CheckAsyncTaskInProgress();
				return this._charPos >= this._charLen && this.ReadBuffer() == 0;
			}
		}

		// Token: 0x060084B3 RID: 33971 RVA: 0x0013E8E0 File Offset: 0x0013CAE0
		public override int Peek()
		{
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen && this.ReadBuffer() == 0)
			{
				return -1;
			}
			return (int)this._charBuffer[this._charPos];
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x0013E914 File Offset: 0x0013CB14
		public override int Read()
		{
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen && this.ReadBuffer() == 0)
			{
				return -1;
			}
			int result = (int)this._charBuffer[this._charPos];
			this._charPos++;
			return result;
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x0013E960 File Offset: 0x0013CB60
		public override int Read(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			return this.ReadSpan(new Span<char>(buffer, index, count));
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x0013E9AF File Offset: 0x0013CBAF
		[NullableContext(0)]
		public override int Read(Span<char> buffer)
		{
			if (!(base.GetType() == typeof(StreamReader)))
			{
				return base.Read(buffer);
			}
			return this.ReadSpan(buffer);
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x0013E9D8 File Offset: 0x0013CBD8
		private int ReadSpan(Span<char> buffer)
		{
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			int num = 0;
			bool flag = false;
			int i = buffer.Length;
			while (i > 0)
			{
				int num2 = this._charLen - this._charPos;
				if (num2 == 0)
				{
					num2 = this.ReadBuffer(buffer.Slice(num), out flag);
				}
				if (num2 == 0)
				{
					break;
				}
				if (num2 > i)
				{
					num2 = i;
				}
				if (!flag)
				{
					new Span<char>(this._charBuffer, this._charPos, num2).CopyTo(buffer.Slice(num));
					this._charPos += num2;
				}
				num += num2;
				i -= num2;
				if (this._isBlocked)
				{
					break;
				}
			}
			return num;
		}

		// Token: 0x060084B8 RID: 33976 RVA: 0x0013EA74 File Offset: 0x0013CC74
		public override string ReadToEnd()
		{
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			StringBuilder stringBuilder = new StringBuilder(this._charLen - this._charPos);
			do
			{
				stringBuilder.Append(this._charBuffer, this._charPos, this._charLen - this._charPos);
				this._charPos = this._charLen;
				this.ReadBuffer();
			}
			while (this._charLen > 0);
			return stringBuilder.ToString();
		}

		// Token: 0x060084B9 RID: 33977 RVA: 0x0013EAE4 File Offset: 0x0013CCE4
		public override int ReadBlock(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			return base.ReadBlock(buffer, index, count);
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x0013EB3C File Offset: 0x0013CD3C
		[NullableContext(0)]
		public override int ReadBlock(Span<char> buffer)
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadBlock(buffer);
			}
			int num = 0;
			int num2;
			do
			{
				num2 = this.ReadSpan(buffer.Slice(num));
				num += num2;
			}
			while (num2 > 0 && num < buffer.Length);
			return num;
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x0013EB8C File Offset: 0x0013CD8C
		private void CompressBuffer(int n)
		{
			byte[] byteBuffer = this._byteBuffer;
			int num = byteBuffer.Length;
			new ReadOnlySpan<byte>(byteBuffer, n, this._byteLen - n).CopyTo(byteBuffer);
			this._byteLen -= n;
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x0013EBD0 File Offset: 0x0013CDD0
		private void DetectEncoding()
		{
			byte[] byteBuffer = this._byteBuffer;
			this._detectEncoding = false;
			bool flag = false;
			ushort num = BinaryPrimitives.ReadUInt16LittleEndian(byteBuffer);
			if (num == 65534)
			{
				this._encoding = Encoding.BigEndianUnicode;
				this.CompressBuffer(2);
				flag = true;
			}
			else if (num == 65279)
			{
				if (this._byteLen < 4 || byteBuffer[2] != 0 || byteBuffer[3] != 0)
				{
					this._encoding = Encoding.Unicode;
					this.CompressBuffer(2);
					flag = true;
				}
				else
				{
					this._encoding = Encoding.UTF32;
					this.CompressBuffer(4);
					flag = true;
				}
			}
			else if (this._byteLen >= 3 && num == 48111 && byteBuffer[2] == 191)
			{
				this._encoding = Encoding.UTF8;
				this.CompressBuffer(3);
				flag = true;
			}
			else if (this._byteLen >= 4 && num == 0 && byteBuffer[2] == 254 && byteBuffer[3] == 255)
			{
				this._encoding = new UTF32Encoding(true, true);
				this.CompressBuffer(4);
				flag = true;
			}
			else if (this._byteLen == 2)
			{
				this._detectEncoding = true;
			}
			if (flag)
			{
				this._decoder = this._encoding.GetDecoder();
				int maxCharCount = this._encoding.GetMaxCharCount(byteBuffer.Length);
				if (maxCharCount > this._maxCharsPerBuffer)
				{
					this._charBuffer = new char[maxCharCount];
				}
				this._maxCharsPerBuffer = maxCharCount;
			}
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x0013ED1C File Offset: 0x0013CF1C
		private bool IsPreamble()
		{
			return this._checkPreamble && this.<IsPreamble>g__IsPreambleWorker|57_0();
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x0013ED30 File Offset: 0x0013CF30
		internal virtual int ReadBuffer()
		{
			this._charLen = 0;
			this._charPos = 0;
			if (!this._checkPreamble)
			{
				this._byteLen = 0;
			}
			bool flag = false;
			for (;;)
			{
				if (this._checkPreamble)
				{
					int num = this._stream.Read(this._byteBuffer, this._bytePos, this._byteBuffer.Length - this._bytePos);
					if (num == 0)
					{
						break;
					}
					this._byteLen += num;
				}
				else
				{
					this._byteLen = this._stream.Read(this._byteBuffer, 0, this._byteBuffer.Length);
					if (this._byteLen == 0)
					{
						goto Block_4;
					}
				}
				this._isBlocked = (this._byteLen < this._byteBuffer.Length);
				if (!this.IsPreamble())
				{
					if (this._detectEncoding && this._byteLen >= 2)
					{
						this.DetectEncoding();
					}
					this._charLen = this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, 0, false);
				}
				if (this._charLen != 0)
				{
					goto IL_FA;
				}
			}
			flag = true;
			goto IL_FA;
			Block_4:
			flag = true;
			IL_FA:
			if (flag)
			{
				this._charLen = this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, 0, true);
				this._bytePos = 0;
				this._byteLen = 0;
			}
			return this._charLen;
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x0013EE74 File Offset: 0x0013D074
		private int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer)
		{
			this._charLen = 0;
			this._charPos = 0;
			if (!this._checkPreamble)
			{
				this._byteLen = 0;
			}
			bool flag = false;
			int num = 0;
			readToUserBuffer = (userBuffer.Length >= this._maxCharsPerBuffer);
			for (;;)
			{
				if (this._checkPreamble)
				{
					int num2 = this._stream.Read(this._byteBuffer, this._bytePos, this._byteBuffer.Length - this._bytePos);
					if (num2 == 0)
					{
						break;
					}
					this._byteLen += num2;
				}
				else
				{
					this._byteLen = this._stream.Read(this._byteBuffer, 0, this._byteBuffer.Length);
					if (this._byteLen == 0)
					{
						goto Block_4;
					}
				}
				this._isBlocked = (this._byteLen < this._byteBuffer.Length);
				if (!this.IsPreamble())
				{
					if (this._detectEncoding && this._byteLen >= 2)
					{
						this.DetectEncoding();
						readToUserBuffer = (userBuffer.Length >= this._maxCharsPerBuffer);
					}
					if (readToUserBuffer)
					{
						num = this._decoder.GetChars(new ReadOnlySpan<byte>(this._byteBuffer, 0, this._byteLen), userBuffer, false);
					}
					else
					{
						num = this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, 0, false);
						this._charLen = num;
					}
				}
				if (num != 0)
				{
					goto IL_14A;
				}
			}
			flag = true;
			goto IL_14A;
			Block_4:
			flag = true;
			IL_14A:
			if (flag)
			{
				if (readToUserBuffer)
				{
					num = this._decoder.GetChars(new ReadOnlySpan<byte>(this._byteBuffer, 0, this._byteLen), userBuffer, true);
				}
				else
				{
					num = this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, 0, true);
					this._charLen = num;
				}
				this._bytePos = 0;
				this._byteLen = 0;
			}
			this._isBlocked &= (num < userBuffer.Length);
			return num;
		}

		// Token: 0x060084C0 RID: 33984 RVA: 0x0013F044 File Offset: 0x0013D244
		[NullableContext(2)]
		public unsafe override string ReadLine()
		{
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen && this.ReadBuffer() == 0)
			{
				return null;
			}
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			ReadOnlySpan<char> readOnlySpan;
			int num;
			for (;;)
			{
				readOnlySpan = this._charBuffer.AsSpan(this._charPos, this._charLen - this._charPos);
				num = readOnlySpan.IndexOfAny('\r', '\n');
				if (num >= 0)
				{
					break;
				}
				valueStringBuilder.Append(readOnlySpan);
				if (this.ReadBuffer() <= 0)
				{
					goto Block_8;
				}
			}
			string result;
			if (valueStringBuilder.Length == 0)
			{
				result = new string(readOnlySpan.Slice(0, num));
			}
			else
			{
				result = valueStringBuilder.AsSpan() + readOnlySpan.Slice(0, num);
				valueStringBuilder.Dispose();
			}
			int num2 = (int)(*readOnlySpan[num]);
			this._charPos += num + 1;
			if (num2 == 13 && (this._charPos < this._charLen || this.ReadBuffer() > 0) && this._charBuffer[this._charPos] == '\n')
			{
				this._charPos++;
			}
			return result;
			Block_8:
			return valueStringBuilder.ToString();
		}

		// Token: 0x060084C1 RID: 33985 RVA: 0x0013F178 File Offset: 0x0013D378
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public override Task<string> ReadLineAsync()
		{
			return this.ReadLineAsync(default(CancellationToken)).AsTask();
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x0013F19C File Offset: 0x0013D39C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public override ValueTask<string> ReadLineAsync(CancellationToken cancellationToken)
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadLineAsync(cancellationToken);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task<string> task = this.ReadLineAsyncInternal(cancellationToken);
			this._asyncReadTask = task;
			return new ValueTask<string>(task);
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x0013F1EC File Offset: 0x0013D3EC
		private Task<string> ReadLineAsyncInternal(CancellationToken cancellationToken)
		{
			StreamReader.<ReadLineAsyncInternal>d__63 <ReadLineAsyncInternal>d__;
			<ReadLineAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadLineAsyncInternal>d__.<>4__this = this;
			<ReadLineAsyncInternal>d__.cancellationToken = cancellationToken;
			<ReadLineAsyncInternal>d__.<>1__state = -1;
			<ReadLineAsyncInternal>d__.<>t__builder.Start<StreamReader.<ReadLineAsyncInternal>d__63>(ref <ReadLineAsyncInternal>d__);
			return <ReadLineAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x0013F238 File Offset: 0x0013D438
		public override Task<string> ReadToEndAsync()
		{
			return this.ReadToEndAsync(default(CancellationToken));
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x0013F254 File Offset: 0x0013D454
		public override Task<string> ReadToEndAsync(CancellationToken cancellationToken)
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadToEndAsync(cancellationToken);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task<string> task = this.ReadToEndAsyncInternal(cancellationToken);
			this._asyncReadTask = task;
			return task;
		}

		// Token: 0x060084C6 RID: 33990 RVA: 0x0013F29C File Offset: 0x0013D49C
		private Task<string> ReadToEndAsyncInternal(CancellationToken cancellationToken)
		{
			StreamReader.<ReadToEndAsyncInternal>d__66 <ReadToEndAsyncInternal>d__;
			<ReadToEndAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadToEndAsyncInternal>d__.<>4__this = this;
			<ReadToEndAsyncInternal>d__.cancellationToken = cancellationToken;
			<ReadToEndAsyncInternal>d__.<>1__state = -1;
			<ReadToEndAsyncInternal>d__.<>t__builder.Start<StreamReader.<ReadToEndAsyncInternal>d__66>(ref <ReadToEndAsyncInternal>d__);
			return <ReadToEndAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x0013F2E8 File Offset: 0x0013D4E8
		public override Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadAsync(buffer, index, count);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task<int> task = this.ReadAsyncInternal(new Memory<char>(buffer, index, count), CancellationToken.None).AsTask();
			this._asyncReadTask = task;
			return task;
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x0013F37C File Offset: 0x0013D57C
		[NullableContext(0)]
		public override ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadAsync(buffer, cancellationToken);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled<int>(cancellationToken);
			}
			return this.ReadAsyncInternal(buffer, cancellationToken);
		}

		// Token: 0x060084C9 RID: 33993 RVA: 0x0013F3D0 File Offset: 0x0013D5D0
		internal override ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			StreamReader.<ReadAsyncInternal>d__69 <ReadAsyncInternal>d__;
			<ReadAsyncInternal>d__.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<ReadAsyncInternal>d__.<>4__this = this;
			<ReadAsyncInternal>d__.buffer = buffer;
			<ReadAsyncInternal>d__.cancellationToken = cancellationToken;
			<ReadAsyncInternal>d__.<>1__state = -1;
			<ReadAsyncInternal>d__.<>t__builder.Start<StreamReader.<ReadAsyncInternal>d__69>(ref <ReadAsyncInternal>d__);
			return <ReadAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060084CA RID: 33994 RVA: 0x0013F424 File Offset: 0x0013D624
		public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadBlockAsync(buffer, index, count);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task<int> task = base.ReadBlockAsync(buffer, index, count);
			this._asyncReadTask = task;
			return task;
		}

		// Token: 0x060084CB RID: 33995 RVA: 0x0013F4A4 File Offset: 0x0013D6A4
		[NullableContext(0)]
		public override ValueTask<int> ReadBlockAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadBlockAsync(buffer, cancellationToken);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled<int>(cancellationToken);
			}
			ValueTask<int> result = base.ReadBlockAsyncInternal(buffer, cancellationToken);
			if (result.IsCompletedSuccessfully)
			{
				return result;
			}
			Task<int> task = result.AsTask();
			this._asyncReadTask = task;
			return new ValueTask<int>(task);
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x0013F518 File Offset: 0x0013D718
		private ValueTask<int> ReadBufferAsync(CancellationToken cancellationToken)
		{
			StreamReader.<ReadBufferAsync>d__72 <ReadBufferAsync>d__;
			<ReadBufferAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<ReadBufferAsync>d__.<>4__this = this;
			<ReadBufferAsync>d__.cancellationToken = cancellationToken;
			<ReadBufferAsync>d__.<>1__state = -1;
			<ReadBufferAsync>d__.<>t__builder.Start<StreamReader.<ReadBufferAsync>d__72>(ref <ReadBufferAsync>d__);
			return <ReadBufferAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x0013F563 File Offset: 0x0013D763
		private void ThrowIfDisposed()
		{
			if (this._disposed)
			{
				this.<ThrowIfDisposed>g__ThrowObjectDisposedException|73_0();
			}
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x0013F580 File Offset: 0x0013D780
		[CompilerGenerated]
		private unsafe bool <IsPreamble>g__IsPreambleWorker|57_0()
		{
			ReadOnlySpan<byte> preamble = this._encoding.Preamble;
			int num = Math.Min(this._byteLen, preamble.Length);
			for (int i = this._bytePos; i < num; i++)
			{
				if (this._byteBuffer[i] != *preamble[i])
				{
					this._bytePos = 0;
					this._checkPreamble = false;
					return false;
				}
			}
			this._bytePos = num;
			if (this._bytePos == preamble.Length)
			{
				this.CompressBuffer(preamble.Length);
				this._bytePos = 0;
				this._checkPreamble = false;
				this._detectEncoding = false;
			}
			return this._checkPreamble;
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x0013F61E File Offset: 0x0013D81E
		[CompilerGenerated]
		private void <ThrowIfDisposed>g__ThrowObjectDisposedException|73_0()
		{
			throw new ObjectDisposedException(base.GetType().Name, SR.ObjectDisposed_ReaderClosed);
		}

		// Token: 0x04001C59 RID: 7257
		public new static readonly StreamReader Null = new StreamReader.NullStreamReader();

		// Token: 0x04001C5A RID: 7258
		private readonly Stream _stream;

		// Token: 0x04001C5B RID: 7259
		private Encoding _encoding;

		// Token: 0x04001C5C RID: 7260
		private Decoder _decoder;

		// Token: 0x04001C5D RID: 7261
		private readonly byte[] _byteBuffer;

		// Token: 0x04001C5E RID: 7262
		private char[] _charBuffer;

		// Token: 0x04001C5F RID: 7263
		private int _charPos;

		// Token: 0x04001C60 RID: 7264
		private int _charLen;

		// Token: 0x04001C61 RID: 7265
		private int _byteLen;

		// Token: 0x04001C62 RID: 7266
		private int _bytePos;

		// Token: 0x04001C63 RID: 7267
		private int _maxCharsPerBuffer;

		// Token: 0x04001C64 RID: 7268
		private bool _disposed;

		// Token: 0x04001C65 RID: 7269
		private bool _detectEncoding;

		// Token: 0x04001C66 RID: 7270
		private bool _checkPreamble;

		// Token: 0x04001C67 RID: 7271
		private bool _isBlocked;

		// Token: 0x04001C68 RID: 7272
		private readonly bool _closable;

		// Token: 0x04001C69 RID: 7273
		private Task _asyncReadTask = Task.CompletedTask;

		// Token: 0x02000824 RID: 2084
		internal sealed class NullStreamReader : StreamReader
		{
			// Token: 0x170011B0 RID: 4528
			// (get) Token: 0x060084D1 RID: 34001 RVA: 0x0013F635 File Offset: 0x0013D835
			public override Encoding CurrentEncoding
			{
				get
				{
					return Encoding.Unicode;
				}
			}

			// Token: 0x060084D2 RID: 34002 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x060084D3 RID: 34003 RVA: 0x0003F19A File Offset: 0x0003D39A
			public override int Peek()
			{
				return -1;
			}

			// Token: 0x060084D4 RID: 34004 RVA: 0x0003F19A File Offset: 0x0003D39A
			public override int Read()
			{
				return -1;
			}

			// Token: 0x060084D5 RID: 34005 RVA: 0x00007B65 File Offset: 0x00005D65
			public override int Read(char[] buffer, int index, int count)
			{
				return 0;
			}

			// Token: 0x060084D6 RID: 34006 RVA: 0x00007B65 File Offset: 0x00005D65
			public override int Read(Span<char> buffer)
			{
				return 0;
			}

			// Token: 0x060084D7 RID: 34007 RVA: 0x0013F63C File Offset: 0x0013D83C
			public override Task<int> ReadAsync(char[] buffer, int index, int count)
			{
				return Task.FromResult<int>(0);
			}

			// Token: 0x060084D8 RID: 34008 RVA: 0x0013F644 File Offset: 0x0013D844
			public override ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return default(ValueTask<int>);
				}
				return ValueTask.FromCanceled<int>(cancellationToken);
			}

			// Token: 0x060084D9 RID: 34009 RVA: 0x00007B65 File Offset: 0x00005D65
			public override int ReadBlock(char[] buffer, int index, int count)
			{
				return 0;
			}

			// Token: 0x060084DA RID: 34010 RVA: 0x00007B65 File Offset: 0x00005D65
			public override int ReadBlock(Span<char> buffer)
			{
				return 0;
			}

			// Token: 0x060084DB RID: 34011 RVA: 0x0013F63C File Offset: 0x0013D83C
			public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
			{
				return Task.FromResult<int>(0);
			}

			// Token: 0x060084DC RID: 34012 RVA: 0x0013F66C File Offset: 0x0013D86C
			public override ValueTask<int> ReadBlockAsync(Memory<char> buffer, CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return default(ValueTask<int>);
				}
				return ValueTask.FromCanceled<int>(cancellationToken);
			}

			// Token: 0x060084DD RID: 34013 RVA: 0x0001A4BA File Offset: 0x000186BA
			public override string ReadLine()
			{
				return null;
			}

			// Token: 0x060084DE RID: 34014 RVA: 0x0013F692 File Offset: 0x0013D892
			public override Task<string> ReadLineAsync()
			{
				return Task.FromResult<string>(null);
			}

			// Token: 0x060084DF RID: 34015 RVA: 0x0013F69C File Offset: 0x0013D89C
			public override ValueTask<string> ReadLineAsync(CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return default(ValueTask<string>);
				}
				return ValueTask.FromCanceled<string>(cancellationToken);
			}

			// Token: 0x060084E0 RID: 34016 RVA: 0x0012FE71 File Offset: 0x0012E071
			public override string ReadToEnd()
			{
				return "";
			}

			// Token: 0x060084E1 RID: 34017 RVA: 0x0013F6C2 File Offset: 0x0013D8C2
			public override Task<string> ReadToEndAsync()
			{
				return Task.FromResult<string>("");
			}

			// Token: 0x060084E2 RID: 34018 RVA: 0x0013F6CE File Offset: 0x0013D8CE
			public override Task<string> ReadToEndAsync(CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.FromResult<string>("");
				}
				return Task.FromCanceled<string>(cancellationToken);
			}

			// Token: 0x060084E3 RID: 34019 RVA: 0x0013F6EC File Offset: 0x0013D8EC
			internal override ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return default(ValueTask<int>);
				}
				return ValueTask.FromCanceled<int>(cancellationToken);
			}

			// Token: 0x060084E4 RID: 34020 RVA: 0x00007B65 File Offset: 0x00005D65
			internal override int ReadBuffer()
			{
				return 0;
			}
		}
	}
}

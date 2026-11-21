using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000829 RID: 2089
	[NullableContext(1)]
	[Nullable(0)]
	public class StreamWriter : TextWriter
	{
		// Token: 0x060084EE RID: 34030 RVA: 0x001404D6 File Offset: 0x0013E6D6
		private void CheckAsyncTaskInProgress()
		{
			if (!this._asyncWriteTask.IsCompleted)
			{
				StreamWriter.ThrowAsyncIOInProgress();
			}
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x0013E59A File Offset: 0x0013C79A
		[DoesNotReturn]
		private static void ThrowAsyncIOInProgress()
		{
			throw new InvalidOperationException(SR.InvalidOperation_AsyncIOInProgress);
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x060084F0 RID: 34032 RVA: 0x001404EA File Offset: 0x0013E6EA
		private static Encoding UTF8NoBOM
		{
			get
			{
				return EncodingCache.UTF8NoBOM;
			}
		}

		// Token: 0x060084F1 RID: 34033 RVA: 0x001404F1 File Offset: 0x0013E6F1
		public StreamWriter(Stream stream) : this(stream, StreamWriter.UTF8NoBOM, 1024, false)
		{
		}

		// Token: 0x060084F2 RID: 34034 RVA: 0x00140505 File Offset: 0x0013E705
		public StreamWriter(Stream stream, Encoding encoding) : this(stream, encoding, 1024, false)
		{
		}

		// Token: 0x060084F3 RID: 34035 RVA: 0x00140515 File Offset: 0x0013E715
		public StreamWriter(Stream stream, Encoding encoding, int bufferSize) : this(stream, encoding, bufferSize, false)
		{
		}

		// Token: 0x060084F4 RID: 34036 RVA: 0x00140524 File Offset: 0x0013E724
		public StreamWriter(Stream stream, [Nullable(2)] Encoding encoding = null, int bufferSize = -1, bool leaveOpen = false)
		{
			this._asyncWriteTask = Task.CompletedTask;
			base..ctor(null);
			if (stream == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.stream);
			}
			if (!stream.CanWrite)
			{
				throw new ArgumentException(SR.Argument_StreamNotWritable);
			}
			if (bufferSize == -1)
			{
				bufferSize = 1024;
			}
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(bufferSize, "bufferSize");
			this._stream = stream;
			this._encoding = (encoding ?? StreamWriter.UTF8NoBOM);
			this._encoder = this._encoding.GetEncoder();
			if (bufferSize < 128)
			{
				bufferSize = 128;
			}
			this._charBuffer = new char[bufferSize];
			this._charLen = bufferSize;
			if (this._stream.CanSeek && this._stream.Position > 0L)
			{
				this._haveWrittenPreamble = true;
			}
			this._closable = !leaveOpen;
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x001405EE File Offset: 0x0013E7EE
		public StreamWriter(string path) : this(path, false, StreamWriter.UTF8NoBOM, 1024)
		{
		}

		// Token: 0x060084F6 RID: 34038 RVA: 0x00140602 File Offset: 0x0013E802
		public StreamWriter(string path, bool append) : this(path, append, StreamWriter.UTF8NoBOM, 1024)
		{
		}

		// Token: 0x060084F7 RID: 34039 RVA: 0x00140616 File Offset: 0x0013E816
		public StreamWriter(string path, bool append, Encoding encoding) : this(path, append, encoding, 1024)
		{
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x00140626 File Offset: 0x0013E826
		public StreamWriter(string path, bool append, Encoding encoding, int bufferSize) : this(StreamWriter.ValidateArgsAndOpenPath(path, append, encoding, bufferSize), encoding, bufferSize, false)
		{
		}

		// Token: 0x060084F9 RID: 34041 RVA: 0x0014063C File Offset: 0x0013E83C
		public StreamWriter(string path, FileStreamOptions options) : this(path, StreamWriter.UTF8NoBOM, options)
		{
		}

		// Token: 0x060084FA RID: 34042 RVA: 0x0014064B File Offset: 0x0013E84B
		public StreamWriter(string path, Encoding encoding, FileStreamOptions options) : this(StreamWriter.ValidateArgsAndOpenPath(path, encoding, options), encoding, 4096)
		{
		}

		// Token: 0x060084FB RID: 34043 RVA: 0x00140661 File Offset: 0x0013E861
		private StreamWriter()
		{
			this._asyncWriteTask = Task.CompletedTask;
			base..ctor();
			this._stream = Stream.Null;
			this._encoding = StreamWriter.UTF8NoBOM;
			this._encoder = null;
			this._charBuffer = Array.Empty<char>();
		}

		// Token: 0x060084FC RID: 34044 RVA: 0x0014069C File Offset: 0x0013E89C
		private static FileStream ValidateArgsAndOpenPath(string path, Encoding encoding, FileStreamOptions options)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			ArgumentNullException.ThrowIfNull(encoding, "encoding");
			ArgumentNullException.ThrowIfNull(options, "options");
			if ((options.Access & FileAccess.Write) == (FileAccess)0)
			{
				throw new ArgumentException(SR.Argument_StreamNotWritable, "options");
			}
			return new FileStream(path, options);
		}

		// Token: 0x060084FD RID: 34045 RVA: 0x001406EB File Offset: 0x0013E8EB
		private static FileStream ValidateArgsAndOpenPath(string path, bool append, Encoding encoding, int bufferSize)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			ArgumentNullException.ThrowIfNull(encoding, "encoding");
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(bufferSize, "bufferSize");
			return new FileStream(path, append ? FileMode.Append : FileMode.Create, FileAccess.Write, FileShare.Read, 4096);
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x00140722 File Offset: 0x0013E922
		public override void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060084FF RID: 34047 RVA: 0x00140734 File Offset: 0x0013E934
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed && disposing)
				{
					this.CheckAsyncTaskInProgress();
					this.Flush(true, true);
				}
			}
			finally
			{
				this.CloseStreamFromDispose(disposing);
			}
		}

		// Token: 0x06008500 RID: 34048 RVA: 0x00140778 File Offset: 0x0013E978
		private void CloseStreamFromDispose(bool disposing)
		{
			if (this._closable && !this._disposed)
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
					this._disposed = true;
					this._charLen = 0;
					base.Dispose(disposing);
				}
			}
		}

		// Token: 0x06008501 RID: 34049 RVA: 0x001407CC File Offset: 0x0013E9CC
		public override ValueTask DisposeAsync()
		{
			if (!(base.GetType() != typeof(StreamWriter)))
			{
				return this.DisposeAsyncCore();
			}
			return base.DisposeAsync();
		}

		// Token: 0x06008502 RID: 34050 RVA: 0x001407F4 File Offset: 0x0013E9F4
		private ValueTask DisposeAsyncCore()
		{
			StreamWriter.<DisposeAsyncCore>d__37 <DisposeAsyncCore>d__;
			<DisposeAsyncCore>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<DisposeAsyncCore>d__.<>4__this = this;
			<DisposeAsyncCore>d__.<>1__state = -1;
			<DisposeAsyncCore>d__.<>t__builder.Start<StreamWriter.<DisposeAsyncCore>d__37>(ref <DisposeAsyncCore>d__);
			return <DisposeAsyncCore>d__.<>t__builder.Task;
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x00140837 File Offset: 0x0013EA37
		public override void Flush()
		{
			this.CheckAsyncTaskInProgress();
			this.Flush(true, true);
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x00140848 File Offset: 0x0013EA48
		private unsafe void Flush(bool flushStream, bool flushEncoder)
		{
			this.ThrowIfDisposed();
			if (this._charPos == 0 && !flushStream && !flushEncoder)
			{
				return;
			}
			if (!this._haveWrittenPreamble)
			{
				this._haveWrittenPreamble = true;
				ReadOnlySpan<byte> preamble = this._encoding.Preamble;
				if (preamble.Length > 0)
				{
					this._stream.Write(preamble);
				}
			}
			Span<byte> bytes;
			if (this._byteBuffer != null)
			{
				bytes = this._byteBuffer;
			}
			else
			{
				Span<byte> span;
				if (this._encoding.GetMaxByteCount(this._charPos) <= 1024)
				{
					span = new Span<byte>(stackalloc byte[(UIntPtr)1024], 1024);
				}
				else
				{
					span = (this._byteBuffer = new byte[this._encoding.GetMaxByteCount(this._charBuffer.Length)]);
				}
				bytes = span;
			}
			int bytes2 = this._encoder.GetBytes(new ReadOnlySpan<char>(this._charBuffer, 0, this._charPos), bytes, flushEncoder);
			this._charPos = 0;
			if (bytes2 > 0)
			{
				this._stream.Write(bytes.Slice(0, bytes2));
			}
			if (flushStream)
			{
				this._stream.Flush();
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06008505 RID: 34053 RVA: 0x0014095B File Offset: 0x0013EB5B
		// (set) Token: 0x06008506 RID: 34054 RVA: 0x00140963 File Offset: 0x0013EB63
		public virtual bool AutoFlush
		{
			get
			{
				return this._autoFlush;
			}
			set
			{
				this.CheckAsyncTaskInProgress();
				this._autoFlush = value;
				if (value)
				{
					this.Flush(true, false);
				}
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06008507 RID: 34055 RVA: 0x0014097D File Offset: 0x0013EB7D
		public virtual Stream BaseStream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06008508 RID: 34056 RVA: 0x00140985 File Offset: 0x0013EB85
		public override Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
		}

		// Token: 0x06008509 RID: 34057 RVA: 0x00140990 File Offset: 0x0013EB90
		public override void Write(char value)
		{
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen)
			{
				this.Flush(false, false);
			}
			this._charBuffer[this._charPos] = value;
			this._charPos++;
			if (this._autoFlush)
			{
				this.Flush(true, false);
			}
		}

		// Token: 0x0600850A RID: 34058 RVA: 0x001409E5 File Offset: 0x0013EBE5
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(char[] buffer)
		{
			this.WriteSpan(buffer, false);
		}

		// Token: 0x0600850B RID: 34059 RVA: 0x001409F4 File Offset: 0x0013EBF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			this.WriteSpan(buffer.AsSpan(index, count), false);
		}

		// Token: 0x0600850C RID: 34060 RVA: 0x00140A49 File Offset: 0x0013EC49
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(ReadOnlySpan<char> buffer)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				this.WriteSpan(buffer, false);
				return;
			}
			base.Write(buffer);
		}

		// Token: 0x0600850D RID: 34061 RVA: 0x00140A74 File Offset: 0x0013EC74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine)
		{
			this.CheckAsyncTaskInProgress();
			if (buffer.Length <= 4 && buffer.Length <= this._charLen - this._charPos)
			{
				for (int i = 0; i < buffer.Length; i++)
				{
					char[] charBuffer = this._charBuffer;
					int charPos = this._charPos;
					this._charPos = charPos + 1;
					charBuffer[charPos] = *buffer[i];
				}
			}
			else
			{
				this.ThrowIfDisposed();
				char[] charBuffer2 = this._charBuffer;
				fixed (char* reference = MemoryMarshal.GetReference<char>(buffer))
				{
					char* ptr = reference;
					fixed (char* ptr2 = &charBuffer2[0])
					{
						char* ptr3 = ptr2;
						char* ptr4 = ptr;
						int j = buffer.Length;
						int num = this._charPos;
						while (j > 0)
						{
							if (num == charBuffer2.Length)
							{
								this.Flush(false, false);
								num = 0;
							}
							int num2 = Math.Min(charBuffer2.Length - num, j);
							int num3 = num2 * 2;
							Buffer.MemoryCopy((void*)ptr4, (void*)(ptr3 + num), (long)num3, (long)num3);
							this._charPos += num2;
							num += num2;
							ptr4 += num2;
							j -= num2;
						}
					}
				}
			}
			if (appendNewLine)
			{
				char[] coreNewLine = this.CoreNewLine;
				for (int k = 0; k < coreNewLine.Length; k++)
				{
					if (this._charPos == this._charLen)
					{
						this.Flush(false, false);
					}
					this._charBuffer[this._charPos] = coreNewLine[k];
					this._charPos++;
				}
			}
			if (this._autoFlush)
			{
				this.Flush(true, false);
			}
		}

		// Token: 0x0600850E RID: 34062 RVA: 0x00140BEB File Offset: 0x0013EDEB
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(string value)
		{
			this.WriteSpan(value, false);
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x00140BFA File Offset: 0x0013EDFA
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteLine(string value)
		{
			this.CheckAsyncTaskInProgress();
			this.WriteSpan(value, true);
		}

		// Token: 0x06008510 RID: 34064 RVA: 0x00140C0F File Offset: 0x0013EE0F
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteLine(ReadOnlySpan<char> buffer)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				this.CheckAsyncTaskInProgress();
				this.WriteSpan(buffer, true);
				return;
			}
			base.WriteLine(buffer);
		}

		// Token: 0x06008511 RID: 34065 RVA: 0x00140C40 File Offset: 0x0013EE40
		private unsafe void WriteFormatHelper(string format, ReadOnlySpan<object> args, bool appendNewLine)
		{
			int num = ((format != null) ? format.Length : 0) + args.Length * 8;
			ValueStringBuilder valueStringBuilder;
			if (num <= 256)
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				valueStringBuilder = new ValueStringBuilder(initialBuffer);
			}
			else
			{
				valueStringBuilder = new ValueStringBuilder(num);
			}
			ValueStringBuilder valueStringBuilder2 = valueStringBuilder;
			valueStringBuilder2.AppendFormatHelper(null, format, args);
			this.WriteSpan(valueStringBuilder2.AsSpan(), appendNewLine);
			valueStringBuilder2.Dispose();
		}

		// Token: 0x06008512 RID: 34066 RVA: 0x00140CB2 File Offset: 0x0013EEB2
		public override void Write([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				this.WriteFormatHelper(format, new ReadOnlySpan<object>(ref arg0), false);
				return;
			}
			base.Write(format, arg0);
		}

		// Token: 0x06008513 RID: 34067 RVA: 0x00140CE4 File Offset: 0x0013EEE4
		[NullableContext(2)]
		public override void Write([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				TwoObjects twoObjects = new TwoObjects(arg0, arg1);
				this.WriteFormatHelper(format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<TwoObjects, object>(twoObjects, 2), false);
				return;
			}
			base.Write(format, arg0, arg1);
		}

		// Token: 0x06008514 RID: 34068 RVA: 0x00140D2C File Offset: 0x0013EF2C
		[NullableContext(2)]
		public override void Write([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				ThreeObjects threeObjects = new ThreeObjects(arg0, arg1, arg2);
				this.WriteFormatHelper(format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<ThreeObjects, object>(threeObjects, 3), false);
				return;
			}
			base.Write(format, arg0, arg1, arg2);
		}

		// Token: 0x06008515 RID: 34069 RVA: 0x00140D78 File Offset: 0x0013EF78
		public override void Write([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] arg)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				if (arg == null)
				{
					ArgumentNullException.Throw((format == null) ? "format" : "arg");
				}
				this.WriteFormatHelper(format, arg, false);
				return;
			}
			base.Write(format, arg);
		}

		// Token: 0x06008516 RID: 34070 RVA: 0x00140DCA File Offset: 0x0013EFCA
		public override void Write([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> arg)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				this.WriteFormatHelper(format, arg, false);
				return;
			}
			base.Write(format, arg);
		}

		// Token: 0x06008517 RID: 34071 RVA: 0x00140DF5 File Offset: 0x0013EFF5
		public override void WriteLine([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				this.WriteFormatHelper(format, new ReadOnlySpan<object>(ref arg0), true);
				return;
			}
			base.WriteLine(format, arg0);
		}

		// Token: 0x06008518 RID: 34072 RVA: 0x00140E28 File Offset: 0x0013F028
		[NullableContext(2)]
		public override void WriteLine([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				TwoObjects twoObjects = new TwoObjects(arg0, arg1);
				this.WriteFormatHelper(format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<TwoObjects, object>(twoObjects, 2), true);
				return;
			}
			base.WriteLine(format, arg0, arg1);
		}

		// Token: 0x06008519 RID: 34073 RVA: 0x00140E70 File Offset: 0x0013F070
		[NullableContext(2)]
		public override void WriteLine([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				ThreeObjects threeObjects = new ThreeObjects(arg0, arg1, arg2);
				this.WriteFormatHelper(format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<ThreeObjects, object>(threeObjects, 3), true);
				return;
			}
			base.WriteLine(format, arg0, arg1, arg2);
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x00140EBB File Offset: 0x0013F0BB
		public override void WriteLine([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] arg)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				ArgumentNullException.ThrowIfNull(arg, "arg");
				this.WriteFormatHelper(format, arg, true);
				return;
			}
			base.WriteLine(format, arg);
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x00140EF6 File Offset: 0x0013F0F6
		public override void WriteLine([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> arg)
		{
			if (base.GetType() == typeof(StreamWriter))
			{
				this.WriteFormatHelper(format, arg, true);
				return;
			}
			base.WriteLine(format, arg);
		}

		// Token: 0x0600851C RID: 34076 RVA: 0x00140F24 File Offset: 0x0013F124
		public override Task WriteAsync(char value)
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteAsync(value);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task task = this.WriteAsyncInternal(value, false);
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x0600851D RID: 34077 RVA: 0x00140F70 File Offset: 0x0013F170
		private Task WriteAsyncInternal(char value, bool appendNewLine)
		{
			StreamWriter.<WriteAsyncInternal>d__67 <WriteAsyncInternal>d__;
			<WriteAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncInternal>d__.<>4__this = this;
			<WriteAsyncInternal>d__.value = value;
			<WriteAsyncInternal>d__.appendNewLine = appendNewLine;
			<WriteAsyncInternal>d__.<>1__state = -1;
			<WriteAsyncInternal>d__.<>t__builder.Start<StreamWriter.<WriteAsyncInternal>d__67>(ref <WriteAsyncInternal>d__);
			return <WriteAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0600851E RID: 34078 RVA: 0x00140FC4 File Offset: 0x0013F1C4
		public override Task WriteAsync([Nullable(2)] string value)
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteAsync(value);
			}
			if (value != null)
			{
				this.ThrowIfDisposed();
				this.CheckAsyncTaskInProgress();
				Task task = this.WriteAsyncInternal(value.AsMemory(), false, default(CancellationToken));
				this._asyncWriteTask = task;
				return task;
			}
			return Task.CompletedTask;
		}

		// Token: 0x0600851F RID: 34079 RVA: 0x00141024 File Offset: 0x0013F224
		public override Task WriteAsync(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteAsync(buffer, index, count);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task task = this.WriteAsyncInternal(new ReadOnlyMemory<char>(buffer, index, count), false, default(CancellationToken));
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06008520 RID: 34080 RVA: 0x001410B4 File Offset: 0x0013F2B4
		[NullableContext(0)]
		[return: Nullable(1)]
		public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteAsync(buffer, cancellationToken);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task task = this.WriteAsyncInternal(buffer, false, cancellationToken);
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06008521 RID: 34081 RVA: 0x00141110 File Offset: 0x0013F310
		private Task WriteAsyncInternal(ReadOnlyMemory<char> source, bool appendNewLine, CancellationToken cancellationToken)
		{
			StreamWriter.<WriteAsyncInternal>d__71 <WriteAsyncInternal>d__;
			<WriteAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncInternal>d__.<>4__this = this;
			<WriteAsyncInternal>d__.source = source;
			<WriteAsyncInternal>d__.appendNewLine = appendNewLine;
			<WriteAsyncInternal>d__.cancellationToken = cancellationToken;
			<WriteAsyncInternal>d__.<>1__state = -1;
			<WriteAsyncInternal>d__.<>t__builder.Start<StreamWriter.<WriteAsyncInternal>d__71>(ref <WriteAsyncInternal>d__);
			return <WriteAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06008522 RID: 34082 RVA: 0x0014116C File Offset: 0x0013F36C
		public override Task WriteLineAsync()
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteLineAsync();
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task task = this.WriteAsyncInternal(ReadOnlyMemory<char>.Empty, true, default(CancellationToken));
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x001411C4 File Offset: 0x0013F3C4
		public override Task WriteLineAsync(char value)
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteLineAsync(value);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task task = this.WriteAsyncInternal(value, true);
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x00141210 File Offset: 0x0013F410
		public override Task WriteLineAsync([Nullable(2)] string value)
		{
			if (value == null)
			{
				return this.WriteLineAsync();
			}
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteLineAsync(value);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task task = this.WriteAsyncInternal(value.AsMemory(), true, default(CancellationToken));
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06008525 RID: 34085 RVA: 0x00141274 File Offset: 0x0013F474
		public override Task WriteLineAsync(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteLineAsync(buffer, index, count);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			Task task = this.WriteAsyncInternal(new ReadOnlyMemory<char>(buffer, index, count), true, default(CancellationToken));
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06008526 RID: 34086 RVA: 0x00141304 File Offset: 0x0013F504
		[NullableContext(0)]
		[return: Nullable(1)]
		public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteLineAsync(buffer, cancellationToken);
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task task = this.WriteAsyncInternal(buffer, true, cancellationToken);
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06008527 RID: 34087 RVA: 0x00141360 File Offset: 0x0013F560
		public override Task FlushAsync()
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.FlushAsync();
			}
			this.ThrowIfDisposed();
			this.CheckAsyncTaskInProgress();
			return this._asyncWriteTask = this.FlushAsyncInternal(true, true, CancellationToken.None);
		}

		// Token: 0x06008528 RID: 34088 RVA: 0x001413B0 File Offset: 0x0013F5B0
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (!(base.GetType() != typeof(StreamWriter)))
			{
				this.ThrowIfDisposed();
				this.CheckAsyncTaskInProgress();
				return this._asyncWriteTask = this.FlushAsyncInternal(true, true, cancellationToken);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return this.FlushAsync();
		}

		// Token: 0x06008529 RID: 34089 RVA: 0x00141409 File Offset: 0x0013F609
		private Task FlushAsyncInternal(bool flushStream, bool flushEncoder, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (this._charPos == 0 && !flushStream && !flushEncoder)
			{
				return Task.CompletedTask;
			}
			return this.<FlushAsyncInternal>g__Core|79_0(flushStream, flushEncoder, cancellationToken);
		}

		// Token: 0x0600852A RID: 34090 RVA: 0x00141438 File Offset: 0x0013F638
		private void ThrowIfDisposed()
		{
			if (this._disposed)
			{
				this.<ThrowIfDisposed>g__ThrowObjectDisposedException|80_0();
			}
		}

		// Token: 0x0600852C RID: 34092 RVA: 0x00141454 File Offset: 0x0013F654
		[CompilerGenerated]
		private Task <FlushAsyncInternal>g__Core|79_0(bool flushStream, bool flushEncoder, CancellationToken cancellationToken)
		{
			StreamWriter.<<FlushAsyncInternal>g__Core|79_0>d <<FlushAsyncInternal>g__Core|79_0>d;
			<<FlushAsyncInternal>g__Core|79_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<FlushAsyncInternal>g__Core|79_0>d.<>4__this = this;
			<<FlushAsyncInternal>g__Core|79_0>d.flushStream = flushStream;
			<<FlushAsyncInternal>g__Core|79_0>d.flushEncoder = flushEncoder;
			<<FlushAsyncInternal>g__Core|79_0>d.cancellationToken = cancellationToken;
			<<FlushAsyncInternal>g__Core|79_0>d.<>1__state = -1;
			<<FlushAsyncInternal>g__Core|79_0>d.<>t__builder.Start<StreamWriter.<<FlushAsyncInternal>g__Core|79_0>d>(ref <<FlushAsyncInternal>g__Core|79_0>d);
			return <<FlushAsyncInternal>g__Core|79_0>d.<>t__builder.Task;
		}

		// Token: 0x0600852D RID: 34093 RVA: 0x001414AF File Offset: 0x0013F6AF
		[CompilerGenerated]
		private void <ThrowIfDisposed>g__ThrowObjectDisposedException|80_0()
		{
			throw new ObjectDisposedException(base.GetType().Name, SR.ObjectDisposed_WriterClosed);
		}

		// Token: 0x04001C8C RID: 7308
		public new static readonly StreamWriter Null = new StreamWriter.NullStreamWriter();

		// Token: 0x04001C8D RID: 7309
		private readonly Stream _stream;

		// Token: 0x04001C8E RID: 7310
		private readonly Encoding _encoding;

		// Token: 0x04001C8F RID: 7311
		private readonly Encoder _encoder;

		// Token: 0x04001C90 RID: 7312
		private byte[] _byteBuffer;

		// Token: 0x04001C91 RID: 7313
		private readonly char[] _charBuffer;

		// Token: 0x04001C92 RID: 7314
		private int _charPos;

		// Token: 0x04001C93 RID: 7315
		private int _charLen;

		// Token: 0x04001C94 RID: 7316
		private bool _autoFlush;

		// Token: 0x04001C95 RID: 7317
		private bool _haveWrittenPreamble;

		// Token: 0x04001C96 RID: 7318
		private readonly bool _closable;

		// Token: 0x04001C97 RID: 7319
		private bool _disposed;

		// Token: 0x04001C98 RID: 7320
		private Task _asyncWriteTask;

		// Token: 0x0200082A RID: 2090
		private sealed class NullStreamWriter : StreamWriter
		{
			// Token: 0x170011B5 RID: 4533
			// (get) Token: 0x0600852E RID: 34094 RVA: 0x00007B65 File Offset: 0x00005D65
			// (set) Token: 0x0600852F RID: 34095 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override bool AutoFlush
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x170011B6 RID: 4534
			// (get) Token: 0x06008530 RID: 34096 RVA: 0x001414C6 File Offset: 0x0013F6C6
			// (set) Token: 0x06008531 RID: 34097 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override string NewLine
			{
				get
				{
					return base.NewLine;
				}
				[param: AllowNull]
				set
				{
				}
			}

			// Token: 0x170011B7 RID: 4535
			// (get) Token: 0x06008532 RID: 34098 RVA: 0x001414CE File Offset: 0x0013F6CE
			public override IFormatProvider FormatProvider
			{
				get
				{
					return CultureInfo.InvariantCulture;
				}
			}

			// Token: 0x06008533 RID: 34099 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Close()
			{
			}

			// Token: 0x06008534 RID: 34100 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x06008535 RID: 34101 RVA: 0x001414D8 File Offset: 0x0013F6D8
			public override ValueTask DisposeAsync()
			{
				return default(ValueTask);
			}

			// Token: 0x06008536 RID: 34102 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Flush()
			{
			}

			// Token: 0x06008537 RID: 34103 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task FlushAsync()
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008538 RID: 34104 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task FlushAsync(CancellationToken cancellationToken)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008539 RID: 34105 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(char value)
			{
			}

			// Token: 0x0600853A RID: 34106 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(char[] buffer)
			{
			}

			// Token: 0x0600853B RID: 34107 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(char[] buffer, int index, int count)
			{
			}

			// Token: 0x0600853C RID: 34108 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(ReadOnlySpan<char> buffer)
			{
			}

			// Token: 0x0600853D RID: 34109 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(bool value)
			{
			}

			// Token: 0x0600853E RID: 34110 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(int value)
			{
			}

			// Token: 0x0600853F RID: 34111 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(uint value)
			{
			}

			// Token: 0x06008540 RID: 34112 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(long value)
			{
			}

			// Token: 0x06008541 RID: 34113 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(ulong value)
			{
			}

			// Token: 0x06008542 RID: 34114 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(float value)
			{
			}

			// Token: 0x06008543 RID: 34115 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(double value)
			{
			}

			// Token: 0x06008544 RID: 34116 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(decimal value)
			{
			}

			// Token: 0x06008545 RID: 34117 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(string value)
			{
			}

			// Token: 0x06008546 RID: 34118 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(object value)
			{
			}

			// Token: 0x06008547 RID: 34119 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(StringBuilder value)
			{
			}

			// Token: 0x06008548 RID: 34120 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0)
			{
			}

			// Token: 0x06008549 RID: 34121 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
			{
			}

			// Token: 0x0600854A RID: 34122 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
			{
			}

			// Token: 0x0600854B RID: 34123 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write([StringSyntax("CompositeFormat")] string format, params object[] arg)
			{
			}

			// Token: 0x0600854C RID: 34124 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(char value)
			{
				return Task.CompletedTask;
			}

			// Token: 0x0600854D RID: 34125 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(string value)
			{
				return Task.CompletedTask;
			}

			// Token: 0x0600854E RID: 34126 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
			{
				return Task.CompletedTask;
			}

			// Token: 0x0600854F RID: 34127 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(char[] buffer, int index, int count)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008550 RID: 34128 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008551 RID: 34129 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine()
			{
			}

			// Token: 0x06008552 RID: 34130 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(char value)
			{
			}

			// Token: 0x06008553 RID: 34131 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(char[] buffer)
			{
			}

			// Token: 0x06008554 RID: 34132 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(char[] buffer, int index, int count)
			{
			}

			// Token: 0x06008555 RID: 34133 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(ReadOnlySpan<char> buffer)
			{
			}

			// Token: 0x06008556 RID: 34134 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(bool value)
			{
			}

			// Token: 0x06008557 RID: 34135 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(int value)
			{
			}

			// Token: 0x06008558 RID: 34136 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(uint value)
			{
			}

			// Token: 0x06008559 RID: 34137 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(long value)
			{
			}

			// Token: 0x0600855A RID: 34138 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(ulong value)
			{
			}

			// Token: 0x0600855B RID: 34139 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(float value)
			{
			}

			// Token: 0x0600855C RID: 34140 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(double value)
			{
			}

			// Token: 0x0600855D RID: 34141 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(decimal value)
			{
			}

			// Token: 0x0600855E RID: 34142 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(string value)
			{
			}

			// Token: 0x0600855F RID: 34143 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(StringBuilder value)
			{
			}

			// Token: 0x06008560 RID: 34144 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(object value)
			{
			}

			// Token: 0x06008561 RID: 34145 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0)
			{
			}

			// Token: 0x06008562 RID: 34146 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
			{
			}

			// Token: 0x06008563 RID: 34147 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
			{
			}

			// Token: 0x06008564 RID: 34148 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, params object[] arg)
			{
			}

			// Token: 0x06008565 RID: 34149 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(char value)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008566 RID: 34150 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(string value)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008567 RID: 34151 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008568 RID: 34152 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(char[] buffer, int index, int count)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008569 RID: 34153 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				return Task.CompletedTask;
			}

			// Token: 0x0600856A RID: 34154 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync()
			{
				return Task.CompletedTask;
			}
		}
	}
}

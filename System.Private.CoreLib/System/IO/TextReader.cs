using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000831 RID: 2097
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TextReader : MarshalByRefObject, IDisposable
	{
		// Token: 0x060085A3 RID: 34211 RVA: 0x001425C2 File Offset: 0x001407C2
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x001425C2 File Offset: 0x001407C2
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060085A5 RID: 34213 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x0003F19A File Offset: 0x0003D39A
		public virtual int Peek()
		{
			return -1;
		}

		// Token: 0x060085A7 RID: 34215 RVA: 0x0003F19A File Offset: 0x0003D39A
		public virtual int Read()
		{
			return -1;
		}

		// Token: 0x060085A8 RID: 34216 RVA: 0x001425D4 File Offset: 0x001407D4
		public virtual int Read(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			int i;
			for (i = 0; i < count; i++)
			{
				int num = this.Read();
				if (num == -1)
				{
					break;
				}
				buffer[index + i] = (char)num;
			}
			return i;
		}

		// Token: 0x060085A9 RID: 34217 RVA: 0x00142634 File Offset: 0x00140834
		[NullableContext(0)]
		public virtual int Read(Span<char> buffer)
		{
			char[] array = ArrayPool<char>.Shared.Rent(buffer.Length);
			int result;
			try
			{
				int num = this.Read(array, 0, buffer.Length);
				if (num > buffer.Length)
				{
					throw new IOException(SR.IO_InvalidReadLength);
				}
				new Span<char>(array, 0, num).CopyTo(buffer);
				result = num;
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x060085AA RID: 34218 RVA: 0x001426AC File Offset: 0x001408AC
		public virtual string ReadToEnd()
		{
			char[] array = new char[4096];
			StringBuilder stringBuilder = new StringBuilder(4096);
			int charCount;
			while ((charCount = this.Read(array, 0, array.Length)) != 0)
			{
				stringBuilder.Append(array, 0, charCount);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060085AB RID: 34219 RVA: 0x001426F0 File Offset: 0x001408F0
		public virtual int ReadBlock(char[] buffer, int index, int count)
		{
			int num = 0;
			int num2;
			do
			{
				num += (num2 = this.Read(buffer, index + num, count - num));
			}
			while (num2 > 0 && num < count);
			return num;
		}

		// Token: 0x060085AC RID: 34220 RVA: 0x0014271C File Offset: 0x0014091C
		[NullableContext(0)]
		public virtual int ReadBlock(Span<char> buffer)
		{
			char[] array = ArrayPool<char>.Shared.Rent(buffer.Length);
			int result;
			try
			{
				int num = this.ReadBlock(array, 0, buffer.Length);
				if (num > buffer.Length)
				{
					throw new IOException(SR.IO_InvalidReadLength);
				}
				new Span<char>(array, 0, num).CopyTo(buffer);
				result = num;
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x060085AD RID: 34221 RVA: 0x00142794 File Offset: 0x00140994
		[NullableContext(2)]
		public virtual string ReadLine()
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num;
			for (;;)
			{
				num = this.Read();
				if (num == -1)
				{
					goto IL_43;
				}
				if (num == 13 || num == 10)
				{
					break;
				}
				stringBuilder.Append((char)num);
			}
			if (num == 13 && this.Peek() == 10)
			{
				this.Read();
			}
			return stringBuilder.ToString();
			IL_43:
			if (stringBuilder.Length > 0)
			{
				return stringBuilder.ToString();
			}
			return null;
		}

		// Token: 0x060085AE RID: 34222 RVA: 0x001427F8 File Offset: 0x001409F8
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public virtual Task<string> ReadLineAsync()
		{
			return this.ReadLineCoreAsync(default(CancellationToken));
		}

		// Token: 0x060085AF RID: 34223 RVA: 0x00142814 File Offset: 0x00140A14
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public virtual ValueTask<string> ReadLineAsync(CancellationToken cancellationToken)
		{
			return new ValueTask<string>(this.ReadLineCoreAsync(cancellationToken));
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x00142822 File Offset: 0x00140A22
		private Task<string> ReadLineCoreAsync(CancellationToken cancellationToken)
		{
			return Task<string>.Factory.StartNew((object state) => ((TextReader)state).ReadLine(), this, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x00142858 File Offset: 0x00140A58
		public virtual Task<string> ReadToEndAsync()
		{
			return this.ReadToEndAsync(default(CancellationToken));
		}

		// Token: 0x060085B2 RID: 34226 RVA: 0x00142874 File Offset: 0x00140A74
		public virtual Task<string> ReadToEndAsync(CancellationToken cancellationToken)
		{
			TextReader.<ReadToEndAsync>d__17 <ReadToEndAsync>d__;
			<ReadToEndAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadToEndAsync>d__.<>4__this = this;
			<ReadToEndAsync>d__.cancellationToken = cancellationToken;
			<ReadToEndAsync>d__.<>1__state = -1;
			<ReadToEndAsync>d__.<>t__builder.Start<TextReader.<ReadToEndAsync>d__17>(ref <ReadToEndAsync>d__);
			return <ReadToEndAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060085B3 RID: 34227 RVA: 0x001428C0 File Offset: 0x00140AC0
		public virtual Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			return this.ReadAsyncInternal(new Memory<char>(buffer, index, count), default(CancellationToken)).AsTask();
		}

		// Token: 0x060085B4 RID: 34228 RVA: 0x00142920 File Offset: 0x00140B20
		[NullableContext(0)]
		public virtual ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<char> arraySegment;
			Task<int> task;
			if (!MemoryMarshal.TryGetArray<char>(buffer, out arraySegment))
			{
				task = Task<int>.Factory.StartNew(delegate(object state)
				{
					TupleSlim<TextReader, Memory<char>> tupleSlim = (TupleSlim<TextReader, Memory<char>>)state;
					return tupleSlim.Item1.Read(tupleSlim.Item2.Span);
				}, new TupleSlim<TextReader, Memory<char>>(this, buffer), cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
			else
			{
				task = this.ReadAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
			return new ValueTask<int>(task);
		}

		// Token: 0x060085B5 RID: 34229 RVA: 0x00142995 File Offset: 0x00140B95
		internal virtual ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			return new ValueTask<int>(Task<int>.Factory.StartNew(delegate(object state)
			{
				TupleSlim<TextReader, Memory<char>> tupleSlim = (TupleSlim<TextReader, Memory<char>>)state;
				return tupleSlim.Item1.Read(tupleSlim.Item2.Span);
			}, new TupleSlim<TextReader, Memory<char>>(this, buffer), cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default));
		}

		// Token: 0x060085B6 RID: 34230 RVA: 0x001429D4 File Offset: 0x00140BD4
		public virtual Task<int> ReadBlockAsync(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			return this.ReadBlockAsyncInternal(new Memory<char>(buffer, index, count), default(CancellationToken)).AsTask();
		}

		// Token: 0x060085B7 RID: 34231 RVA: 0x00142A34 File Offset: 0x00140C34
		[NullableContext(0)]
		public virtual ValueTask<int> ReadBlockAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<char> arraySegment;
			Task<int> task;
			if (!MemoryMarshal.TryGetArray<char>(buffer, out arraySegment))
			{
				task = Task<int>.Factory.StartNew(delegate(object state)
				{
					TupleSlim<TextReader, Memory<char>> tupleSlim = (TupleSlim<TextReader, Memory<char>>)state;
					return tupleSlim.Item1.ReadBlock(tupleSlim.Item2.Span);
				}, new TupleSlim<TextReader, Memory<char>>(this, buffer), cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
			else
			{
				task = this.ReadBlockAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
			return new ValueTask<int>(task);
		}

		// Token: 0x060085B8 RID: 34232 RVA: 0x00142AAC File Offset: 0x00140CAC
		internal ValueTask<int> ReadBlockAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			TextReader.<ReadBlockAsyncInternal>d__23 <ReadBlockAsyncInternal>d__;
			<ReadBlockAsyncInternal>d__.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<ReadBlockAsyncInternal>d__.<>4__this = this;
			<ReadBlockAsyncInternal>d__.buffer = buffer;
			<ReadBlockAsyncInternal>d__.cancellationToken = cancellationToken;
			<ReadBlockAsyncInternal>d__.<>1__state = -1;
			<ReadBlockAsyncInternal>d__.<>t__builder.Start<TextReader.<ReadBlockAsyncInternal>d__23>(ref <ReadBlockAsyncInternal>d__);
			return <ReadBlockAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x00142AFF File Offset: 0x00140CFF
		public static TextReader Synchronized(TextReader reader)
		{
			ArgumentNullException.ThrowIfNull(reader, "reader");
			if (!(reader is TextReader.SyncTextReader))
			{
				return new TextReader.SyncTextReader(reader);
			}
			return reader;
		}

		// Token: 0x04001CBA RID: 7354
		public static readonly TextReader Null = new StreamReader.NullStreamReader();

		// Token: 0x02000832 RID: 2098
		internal sealed class SyncTextReader : TextReader
		{
			// Token: 0x060085BB RID: 34235 RVA: 0x00142B28 File Offset: 0x00140D28
			internal SyncTextReader(TextReader t)
			{
				this._in = t;
			}

			// Token: 0x060085BC RID: 34236 RVA: 0x00142B37 File Offset: 0x00140D37
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Close()
			{
				this._in.Close();
			}

			// Token: 0x060085BD RID: 34237 RVA: 0x00142B44 File Offset: 0x00140D44
			[MethodImpl(MethodImplOptions.Synchronized)]
			protected override void Dispose(bool disposing)
			{
				if (disposing)
				{
					((IDisposable)this._in).Dispose();
				}
			}

			// Token: 0x060085BE RID: 34238 RVA: 0x00142B54 File Offset: 0x00140D54
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int Peek()
			{
				return this._in.Peek();
			}

			// Token: 0x060085BF RID: 34239 RVA: 0x00142B61 File Offset: 0x00140D61
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int Read()
			{
				return this._in.Read();
			}

			// Token: 0x060085C0 RID: 34240 RVA: 0x00142B6E File Offset: 0x00140D6E
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int Read(char[] buffer, int index, int count)
			{
				return this._in.Read(buffer, index, count);
			}

			// Token: 0x060085C1 RID: 34241 RVA: 0x00142B7E File Offset: 0x00140D7E
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int ReadBlock(char[] buffer, int index, int count)
			{
				return this._in.ReadBlock(buffer, index, count);
			}

			// Token: 0x060085C2 RID: 34242 RVA: 0x00142B8E File Offset: 0x00140D8E
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override string ReadLine()
			{
				return this._in.ReadLine();
			}

			// Token: 0x060085C3 RID: 34243 RVA: 0x00142B9B File Offset: 0x00140D9B
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override string ReadToEnd()
			{
				return this._in.ReadToEnd();
			}

			// Token: 0x060085C4 RID: 34244 RVA: 0x00142083 File Offset: 0x00140283
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<string> ReadLineAsync()
			{
				return Task.FromResult<string>(this.ReadLine());
			}

			// Token: 0x060085C5 RID: 34245 RVA: 0x00142090 File Offset: 0x00140290
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override ValueTask<string> ReadLineAsync(CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return new ValueTask<string>(this.ReadLine());
				}
				return ValueTask.FromCanceled<string>(cancellationToken);
			}

			// Token: 0x060085C6 RID: 34246 RVA: 0x001420AD File Offset: 0x001402AD
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<string> ReadToEndAsync()
			{
				return Task.FromResult<string>(this.ReadToEnd());
			}

			// Token: 0x060085C7 RID: 34247 RVA: 0x001420BA File Offset: 0x001402BA
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<string> ReadToEndAsync(CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.FromResult<string>(this.ReadToEnd());
				}
				return Task.FromCanceled<string>(cancellationToken);
			}

			// Token: 0x060085C8 RID: 34248 RVA: 0x00142BA8 File Offset: 0x00140DA8
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
			{
				ArgumentNullException.ThrowIfNull(buffer, "buffer");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (buffer.Length - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				return Task.FromResult<int>(this.ReadBlock(buffer, index, count));
			}

			// Token: 0x060085C9 RID: 34249 RVA: 0x00142BF8 File Offset: 0x00140DF8
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<int> ReadAsync(char[] buffer, int index, int count)
			{
				ArgumentNullException.ThrowIfNull(buffer, "buffer");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (buffer.Length - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				return Task.FromResult<int>(this.Read(buffer, index, count));
			}

			// Token: 0x04001CBB RID: 7355
			internal readonly TextReader _in;
		}
	}
}

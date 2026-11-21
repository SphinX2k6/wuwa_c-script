using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000836 RID: 2102
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TextWriter : MarshalByRefObject, IDisposable, IAsyncDisposable
	{
		// Token: 0x060085D4 RID: 34260 RVA: 0x00142F86 File Offset: 0x00141186
		protected TextWriter()
		{
		}

		// Token: 0x060085D5 RID: 34261 RVA: 0x00142FA4 File Offset: 0x001411A4
		[NullableContext(2)]
		protected TextWriter(IFormatProvider formatProvider)
		{
			this._internalFormatProvider = formatProvider;
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x060085D6 RID: 34262 RVA: 0x00142FC9 File Offset: 0x001411C9
		public virtual IFormatProvider FormatProvider
		{
			get
			{
				return this._internalFormatProvider ?? CultureInfo.CurrentCulture;
			}
		}

		// Token: 0x060085D7 RID: 34263 RVA: 0x00140722 File Offset: 0x0013E922
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060085D8 RID: 34264 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x00140722 File Offset: 0x0013E922
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060085DA RID: 34266 RVA: 0x00142FDC File Offset: 0x001411DC
		public virtual ValueTask DisposeAsync()
		{
			ValueTask valueTask;
			try
			{
				this.Dispose();
				valueTask = default(ValueTask);
				valueTask = valueTask;
			}
			catch (Exception exception)
			{
				valueTask = ValueTask.FromException(exception);
			}
			return valueTask;
		}

		// Token: 0x060085DB RID: 34267 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public virtual void Flush()
		{
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x060085DC RID: 34268
		public abstract Encoding Encoding { get; }

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x00143014 File Offset: 0x00141214
		// (set) Token: 0x060085DE RID: 34270 RVA: 0x0014301C File Offset: 0x0014121C
		public virtual string NewLine
		{
			get
			{
				return this.CoreNewLineStr;
			}
			[param: AllowNull]
			set
			{
				if (value == null)
				{
					value = "\r\n";
				}
				this.CoreNewLineStr = value;
				this.CoreNewLine = value.ToCharArray();
			}
		}

		// Token: 0x060085DF RID: 34271 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public virtual void Write(char value)
		{
		}

		// Token: 0x060085E0 RID: 34272 RVA: 0x0014303B File Offset: 0x0014123B
		[NullableContext(2)]
		public virtual void Write(char[] buffer)
		{
			if (buffer != null)
			{
				this.Write(buffer, 0, buffer.Length);
			}
		}

		// Token: 0x060085E1 RID: 34273 RVA: 0x0014304C File Offset: 0x0014124C
		public virtual void Write(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			for (int i = 0; i < count; i++)
			{
				this.Write(buffer[index + i]);
			}
		}

		// Token: 0x060085E2 RID: 34274 RVA: 0x001430A4 File Offset: 0x001412A4
		[NullableContext(0)]
		public virtual void Write(ReadOnlySpan<char> buffer)
		{
			char[] array = ArrayPool<char>.Shared.Rent(buffer.Length);
			try
			{
				buffer.CopyTo(new Span<char>(array));
				this.Write(array, 0, buffer.Length);
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x060085E3 RID: 34275 RVA: 0x00143100 File Offset: 0x00141300
		public virtual void Write(bool value)
		{
			this.Write(value ? "True" : "False");
		}

		// Token: 0x060085E4 RID: 34276 RVA: 0x00143117 File Offset: 0x00141317
		public virtual void Write(int value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		// Token: 0x060085E5 RID: 34277 RVA: 0x0014312C File Offset: 0x0014132C
		[CLSCompliant(false)]
		public virtual void Write(uint value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		// Token: 0x060085E6 RID: 34278 RVA: 0x00143141 File Offset: 0x00141341
		public virtual void Write(long value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		// Token: 0x060085E7 RID: 34279 RVA: 0x00143156 File Offset: 0x00141356
		[CLSCompliant(false)]
		public virtual void Write(ulong value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		// Token: 0x060085E8 RID: 34280 RVA: 0x0014316B File Offset: 0x0014136B
		public virtual void Write(float value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		// Token: 0x060085E9 RID: 34281 RVA: 0x00143180 File Offset: 0x00141380
		public virtual void Write(double value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		// Token: 0x060085EA RID: 34282 RVA: 0x00143195 File Offset: 0x00141395
		public virtual void Write(decimal value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		// Token: 0x060085EB RID: 34283 RVA: 0x001431AA File Offset: 0x001413AA
		[NullableContext(2)]
		public virtual void Write(string value)
		{
			if (value != null)
			{
				this.Write(value.ToCharArray());
			}
		}

		// Token: 0x060085EC RID: 34284 RVA: 0x001431BC File Offset: 0x001413BC
		[NullableContext(2)]
		public virtual void Write(object value)
		{
			if (value != null)
			{
				IFormattable formattable = value as IFormattable;
				if (formattable != null)
				{
					this.Write(formattable.ToString(null, this.FormatProvider));
					return;
				}
				this.Write(value.ToString());
			}
		}

		// Token: 0x060085ED RID: 34285 RVA: 0x001431F8 File Offset: 0x001413F8
		[NullableContext(2)]
		public virtual void Write(StringBuilder value)
		{
			if (value != null)
			{
				foreach (ReadOnlyMemory<char> readOnlyMemory in value.GetChunks())
				{
					this.Write(readOnlyMemory.Span);
				}
			}
		}

		// Token: 0x060085EE RID: 34286 RVA: 0x00143237 File Offset: 0x00141437
		public virtual void Write([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			this.Write(string.Format(this.FormatProvider, format, arg0));
		}

		// Token: 0x060085EF RID: 34287 RVA: 0x0014324C File Offset: 0x0014144C
		[NullableContext(2)]
		public virtual void Write([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
		{
			this.Write(string.Format(this.FormatProvider, format, arg0, arg1));
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x00143262 File Offset: 0x00141462
		[NullableContext(2)]
		public virtual void Write([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
		{
			this.Write(string.Format(this.FormatProvider, format, arg0, arg1, arg2));
		}

		// Token: 0x060085F1 RID: 34289 RVA: 0x0014327A File Offset: 0x0014147A
		public virtual void Write([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] arg)
		{
			this.Write(string.Format(this.FormatProvider, format, arg));
		}

		// Token: 0x060085F2 RID: 34290 RVA: 0x0014328F File Offset: 0x0014148F
		public virtual void Write([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> arg)
		{
			this.Write(string.Format(this.FormatProvider, format, arg));
		}

		// Token: 0x060085F3 RID: 34291 RVA: 0x001432A4 File Offset: 0x001414A4
		public virtual void WriteLine()
		{
			this.Write(this.CoreNewLine);
		}

		// Token: 0x060085F4 RID: 34292 RVA: 0x001432B2 File Offset: 0x001414B2
		public virtual void WriteLine(char value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x060085F5 RID: 34293 RVA: 0x001432C1 File Offset: 0x001414C1
		[NullableContext(2)]
		public virtual void WriteLine(char[] buffer)
		{
			this.Write(buffer);
			this.WriteLine();
		}

		// Token: 0x060085F6 RID: 34294 RVA: 0x001432D0 File Offset: 0x001414D0
		public virtual void WriteLine(char[] buffer, int index, int count)
		{
			this.Write(buffer, index, count);
			this.WriteLine();
		}

		// Token: 0x060085F7 RID: 34295 RVA: 0x001432E4 File Offset: 0x001414E4
		[NullableContext(0)]
		public virtual void WriteLine(ReadOnlySpan<char> buffer)
		{
			char[] array = ArrayPool<char>.Shared.Rent(buffer.Length);
			try
			{
				buffer.CopyTo(new Span<char>(array));
				this.WriteLine(array, 0, buffer.Length);
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x060085F8 RID: 34296 RVA: 0x00143340 File Offset: 0x00141540
		public virtual void WriteLine(bool value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x060085F9 RID: 34297 RVA: 0x0014334F File Offset: 0x0014154F
		public virtual void WriteLine(int value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x060085FA RID: 34298 RVA: 0x0014335E File Offset: 0x0014155E
		[CLSCompliant(false)]
		public virtual void WriteLine(uint value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x060085FB RID: 34299 RVA: 0x0014336D File Offset: 0x0014156D
		public virtual void WriteLine(long value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x060085FC RID: 34300 RVA: 0x0014337C File Offset: 0x0014157C
		[CLSCompliant(false)]
		public virtual void WriteLine(ulong value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x060085FD RID: 34301 RVA: 0x0014338B File Offset: 0x0014158B
		public virtual void WriteLine(float value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x0014339A File Offset: 0x0014159A
		public virtual void WriteLine(double value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x001433A9 File Offset: 0x001415A9
		public virtual void WriteLine(decimal value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x06008600 RID: 34304 RVA: 0x001433B8 File Offset: 0x001415B8
		[NullableContext(2)]
		public virtual void WriteLine(string value)
		{
			if (value != null)
			{
				this.Write(value);
			}
			this.Write(this.CoreNewLineStr);
		}

		// Token: 0x06008601 RID: 34305 RVA: 0x001433D0 File Offset: 0x001415D0
		[NullableContext(2)]
		public virtual void WriteLine(StringBuilder value)
		{
			this.Write(value);
			this.WriteLine();
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x001433E0 File Offset: 0x001415E0
		[NullableContext(2)]
		public virtual void WriteLine(object value)
		{
			if (value == null)
			{
				this.WriteLine();
				return;
			}
			IFormattable formattable = value as IFormattable;
			if (formattable != null)
			{
				this.WriteLine(formattable.ToString(null, this.FormatProvider));
				return;
			}
			this.WriteLine(value.ToString());
		}

		// Token: 0x06008603 RID: 34307 RVA: 0x00143421 File Offset: 0x00141621
		public virtual void WriteLine([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg0));
		}

		// Token: 0x06008604 RID: 34308 RVA: 0x00143436 File Offset: 0x00141636
		[NullableContext(2)]
		public virtual void WriteLine([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg0, arg1));
		}

		// Token: 0x06008605 RID: 34309 RVA: 0x0014344C File Offset: 0x0014164C
		[NullableContext(2)]
		public virtual void WriteLine([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg0, arg1, arg2));
		}

		// Token: 0x06008606 RID: 34310 RVA: 0x00143464 File Offset: 0x00141664
		public virtual void WriteLine([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] arg)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg));
		}

		// Token: 0x06008607 RID: 34311 RVA: 0x00143479 File Offset: 0x00141679
		public virtual void WriteLine([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> arg)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg));
		}

		// Token: 0x06008608 RID: 34312 RVA: 0x0014348E File Offset: 0x0014168E
		public virtual Task WriteAsync(char value)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				TupleSlim<TextWriter, char> tupleSlim = (TupleSlim<TextWriter, char>)state;
				tupleSlim.Item1.Write(tupleSlim.Item2);
			}, new TupleSlim<TextWriter, char>(this, value), CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x06008609 RID: 34313 RVA: 0x001434CB File Offset: 0x001416CB
		public virtual Task WriteAsync([Nullable(2)] string value)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				TupleSlim<TextWriter, string> tupleSlim = (TupleSlim<TextWriter, string>)state;
				tupleSlim.Item1.Write(tupleSlim.Item2);
			}, new TupleSlim<TextWriter, string>(this, value), CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x0600860A RID: 34314 RVA: 0x00143508 File Offset: 0x00141708
		public virtual Task WriteAsync([Nullable(2)] StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (value != null)
			{
				return this.<WriteAsync>g__WriteAsyncCore|62_0(value, cancellationToken);
			}
			return Task.CompletedTask;
		}

		// Token: 0x0600860B RID: 34315 RVA: 0x0014352B File Offset: 0x0014172B
		public Task WriteAsync([Nullable(2)] char[] buffer)
		{
			if (buffer == null)
			{
				return Task.CompletedTask;
			}
			return this.WriteAsync(buffer, 0, buffer.Length);
		}

		// Token: 0x0600860C RID: 34316 RVA: 0x00143541 File Offset: 0x00141741
		public virtual Task WriteAsync(char[] buffer, int index, int count)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				TupleSlim<TextWriter, char[], int, int> tupleSlim = (TupleSlim<TextWriter, char[], int, int>)state;
				tupleSlim.Item1.Write(tupleSlim.Item2, tupleSlim.Item3, tupleSlim.Item4);
			}, new TupleSlim<TextWriter, char[], int, int>(this, buffer, index, count), CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x0600860D RID: 34317 RVA: 0x00143580 File Offset: 0x00141780
		[NullableContext(0)]
		[return: Nullable(1)]
		public virtual Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			ArraySegment<char> arraySegment;
			if (!MemoryMarshal.TryGetArray<char>(buffer, out arraySegment))
			{
				return Task.Factory.StartNew(delegate(object state)
				{
					TupleSlim<TextWriter, ReadOnlyMemory<char>> tupleSlim = (TupleSlim<TextWriter, ReadOnlyMemory<char>>)state;
					tupleSlim.Item1.Write(tupleSlim.Item2.Span);
				}, new TupleSlim<TextWriter, ReadOnlyMemory<char>>(this, buffer), cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
			return this.WriteAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
		}

		// Token: 0x0600860E RID: 34318 RVA: 0x001435FA File Offset: 0x001417FA
		public virtual Task WriteLineAsync(char value)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				TupleSlim<TextWriter, char> tupleSlim = (TupleSlim<TextWriter, char>)state;
				tupleSlim.Item1.WriteLine(tupleSlim.Item2);
			}, new TupleSlim<TextWriter, char>(this, value), CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x0600860F RID: 34319 RVA: 0x00143637 File Offset: 0x00141837
		public virtual Task WriteLineAsync([Nullable(2)] string value)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				TupleSlim<TextWriter, string> tupleSlim = (TupleSlim<TextWriter, string>)state;
				tupleSlim.Item1.WriteLine(tupleSlim.Item2);
			}, new TupleSlim<TextWriter, string>(this, value), CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x06008610 RID: 34320 RVA: 0x00143674 File Offset: 0x00141874
		public virtual Task WriteLineAsync([Nullable(2)] StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (value != null)
			{
				return this.<WriteLineAsync>g__WriteLineAsyncCore|68_0(value, cancellationToken);
			}
			return this.WriteAsync(this.CoreNewLine, cancellationToken);
		}

		// Token: 0x06008611 RID: 34321 RVA: 0x001436A4 File Offset: 0x001418A4
		public Task WriteLineAsync([Nullable(2)] char[] buffer)
		{
			if (buffer == null)
			{
				return this.WriteLineAsync();
			}
			return this.WriteLineAsync(buffer, 0, buffer.Length);
		}

		// Token: 0x06008612 RID: 34322 RVA: 0x001436BB File Offset: 0x001418BB
		public virtual Task WriteLineAsync(char[] buffer, int index, int count)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				TupleSlim<TextWriter, char[], int, int> tupleSlim = (TupleSlim<TextWriter, char[], int, int>)state;
				tupleSlim.Item1.WriteLine(tupleSlim.Item2, tupleSlim.Item3, tupleSlim.Item4);
			}, new TupleSlim<TextWriter, char[], int, int>(this, buffer, index, count), CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x06008613 RID: 34323 RVA: 0x001436FC File Offset: 0x001418FC
		[NullableContext(0)]
		[return: Nullable(1)]
		public virtual Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			ArraySegment<char> arraySegment;
			if (!MemoryMarshal.TryGetArray<char>(buffer, out arraySegment))
			{
				return Task.Factory.StartNew(delegate(object state)
				{
					TupleSlim<TextWriter, ReadOnlyMemory<char>> tupleSlim = (TupleSlim<TextWriter, ReadOnlyMemory<char>>)state;
					tupleSlim.Item1.WriteLine(tupleSlim.Item2.Span);
				}, new TupleSlim<TextWriter, ReadOnlyMemory<char>>(this, buffer), cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
			return this.WriteLineAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
		}

		// Token: 0x06008614 RID: 34324 RVA: 0x00143776 File Offset: 0x00141976
		public virtual Task WriteLineAsync()
		{
			return this.WriteAsync(this.CoreNewLine);
		}

		// Token: 0x06008615 RID: 34325 RVA: 0x00143784 File Offset: 0x00141984
		public virtual Task FlushAsync()
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				((TextWriter)state).Flush();
			}, this, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x06008616 RID: 34326 RVA: 0x001437BB File Offset: 0x001419BB
		public virtual Task FlushAsync(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.FlushAsync();
			}
			return Task.FromCanceled(cancellationToken);
		}

		// Token: 0x06008617 RID: 34327 RVA: 0x001437D3 File Offset: 0x001419D3
		public static TextWriter Synchronized(TextWriter writer)
		{
			ArgumentNullException.ThrowIfNull(writer, "writer");
			if (!(writer is TextWriter.SyncTextWriter))
			{
				return new TextWriter.SyncTextWriter(writer);
			}
			return writer;
		}

		// Token: 0x06008618 RID: 34328 RVA: 0x001437F0 File Offset: 0x001419F0
		public static TextWriter CreateBroadcasting(params TextWriter[] writers)
		{
			ArgumentNullException.ThrowIfNull(writers, "writers");
			if (writers.Length == 0)
			{
				return TextWriter.Null;
			}
			return new TextWriter.BroadcastingTextWriter(new ReadOnlySpan<TextWriter>(writers).ToArray());
		}

		// Token: 0x0600861A RID: 34330 RVA: 0x00143840 File Offset: 0x00141A40
		[CompilerGenerated]
		private Task <WriteAsync>g__WriteAsyncCore|62_0(StringBuilder sb, CancellationToken ct)
		{
			TextWriter.<<WriteAsync>g__WriteAsyncCore|62_0>d <<WriteAsync>g__WriteAsyncCore|62_0>d;
			<<WriteAsync>g__WriteAsyncCore|62_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<WriteAsync>g__WriteAsyncCore|62_0>d.<>4__this = this;
			<<WriteAsync>g__WriteAsyncCore|62_0>d.sb = sb;
			<<WriteAsync>g__WriteAsyncCore|62_0>d.ct = ct;
			<<WriteAsync>g__WriteAsyncCore|62_0>d.<>1__state = -1;
			<<WriteAsync>g__WriteAsyncCore|62_0>d.<>t__builder.Start<TextWriter.<<WriteAsync>g__WriteAsyncCore|62_0>d>(ref <<WriteAsync>g__WriteAsyncCore|62_0>d);
			return <<WriteAsync>g__WriteAsyncCore|62_0>d.<>t__builder.Task;
		}

		// Token: 0x0600861B RID: 34331 RVA: 0x00143894 File Offset: 0x00141A94
		[CompilerGenerated]
		private Task <WriteLineAsync>g__WriteLineAsyncCore|68_0(StringBuilder sb, CancellationToken ct)
		{
			TextWriter.<<WriteLineAsync>g__WriteLineAsyncCore|68_0>d <<WriteLineAsync>g__WriteLineAsyncCore|68_0>d;
			<<WriteLineAsync>g__WriteLineAsyncCore|68_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<WriteLineAsync>g__WriteLineAsyncCore|68_0>d.<>4__this = this;
			<<WriteLineAsync>g__WriteLineAsyncCore|68_0>d.sb = sb;
			<<WriteLineAsync>g__WriteLineAsyncCore|68_0>d.ct = ct;
			<<WriteLineAsync>g__WriteLineAsyncCore|68_0>d.<>1__state = -1;
			<<WriteLineAsync>g__WriteLineAsyncCore|68_0>d.<>t__builder.Start<TextWriter.<<WriteLineAsync>g__WriteLineAsyncCore|68_0>d>(ref <<WriteLineAsync>g__WriteLineAsyncCore|68_0>d);
			return <<WriteLineAsync>g__WriteLineAsyncCore|68_0>d.<>t__builder.Task;
		}

		// Token: 0x04001CCF RID: 7375
		public static readonly TextWriter Null = new TextWriter.NullTextWriter();

		// Token: 0x04001CD0 RID: 7376
		private static readonly char[] s_coreNewLine = "\r\n".ToCharArray();

		// Token: 0x04001CD1 RID: 7377
		protected char[] CoreNewLine = TextWriter.s_coreNewLine;

		// Token: 0x04001CD2 RID: 7378
		private string CoreNewLineStr = "\r\n";

		// Token: 0x04001CD3 RID: 7379
		private readonly IFormatProvider _internalFormatProvider;

		// Token: 0x02000837 RID: 2103
		private sealed class NullTextWriter : TextWriter
		{
			// Token: 0x0600861C RID: 34332 RVA: 0x001438E7 File Offset: 0x00141AE7
			internal NullTextWriter()
			{
			}

			// Token: 0x170011BC RID: 4540
			// (get) Token: 0x0600861D RID: 34333 RVA: 0x001414CE File Offset: 0x0013F6CE
			public override IFormatProvider FormatProvider
			{
				get
				{
					return CultureInfo.InvariantCulture;
				}
			}

			// Token: 0x170011BD RID: 4541
			// (get) Token: 0x0600861E RID: 34334 RVA: 0x0013F635 File Offset: 0x0013D835
			public override Encoding Encoding
			{
				get
				{
					return Encoding.Unicode;
				}
			}

			// Token: 0x170011BE RID: 4542
			// (get) Token: 0x0600861F RID: 34335 RVA: 0x001414C6 File Offset: 0x0013F6C6
			// (set) Token: 0x06008620 RID: 34336 RVA: 0x0000FCFA File Offset: 0x0000DEFA
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

			// Token: 0x06008621 RID: 34337 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Flush()
			{
			}

			// Token: 0x06008622 RID: 34338 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task FlushAsync()
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008623 RID: 34339 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task FlushAsync(CancellationToken cancellationToken)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008624 RID: 34340 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(char value)
			{
			}

			// Token: 0x06008625 RID: 34341 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(char[] buffer)
			{
			}

			// Token: 0x06008626 RID: 34342 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(char[] buffer, int index, int count)
			{
			}

			// Token: 0x06008627 RID: 34343 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(ReadOnlySpan<char> buffer)
			{
			}

			// Token: 0x06008628 RID: 34344 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(bool value)
			{
			}

			// Token: 0x06008629 RID: 34345 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(int value)
			{
			}

			// Token: 0x0600862A RID: 34346 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(uint value)
			{
			}

			// Token: 0x0600862B RID: 34347 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(long value)
			{
			}

			// Token: 0x0600862C RID: 34348 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(ulong value)
			{
			}

			// Token: 0x0600862D RID: 34349 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(float value)
			{
			}

			// Token: 0x0600862E RID: 34350 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(double value)
			{
			}

			// Token: 0x0600862F RID: 34351 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(decimal value)
			{
			}

			// Token: 0x06008630 RID: 34352 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(string value)
			{
			}

			// Token: 0x06008631 RID: 34353 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(object value)
			{
			}

			// Token: 0x06008632 RID: 34354 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(StringBuilder value)
			{
			}

			// Token: 0x06008633 RID: 34355 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0)
			{
			}

			// Token: 0x06008634 RID: 34356 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
			{
			}

			// Token: 0x06008635 RID: 34357 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
			{
			}

			// Token: 0x06008636 RID: 34358 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write([StringSyntax("CompositeFormat")] string format, params object[] arg)
			{
			}

			// Token: 0x06008637 RID: 34359 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] ReadOnlySpan<object> arg)
			{
			}

			// Token: 0x06008638 RID: 34360 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(char value)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008639 RID: 34361 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(string value)
			{
				return Task.CompletedTask;
			}

			// Token: 0x0600863A RID: 34362 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
			{
				return Task.CompletedTask;
			}

			// Token: 0x0600863B RID: 34363 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(char[] buffer, int index, int count)
			{
				return Task.CompletedTask;
			}

			// Token: 0x0600863C RID: 34364 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				return Task.CompletedTask;
			}

			// Token: 0x0600863D RID: 34365 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine()
			{
			}

			// Token: 0x0600863E RID: 34366 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(char value)
			{
			}

			// Token: 0x0600863F RID: 34367 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(char[] buffer)
			{
			}

			// Token: 0x06008640 RID: 34368 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(char[] buffer, int index, int count)
			{
			}

			// Token: 0x06008641 RID: 34369 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(ReadOnlySpan<char> buffer)
			{
			}

			// Token: 0x06008642 RID: 34370 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(bool value)
			{
			}

			// Token: 0x06008643 RID: 34371 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(int value)
			{
			}

			// Token: 0x06008644 RID: 34372 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(uint value)
			{
			}

			// Token: 0x06008645 RID: 34373 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(long value)
			{
			}

			// Token: 0x06008646 RID: 34374 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(ulong value)
			{
			}

			// Token: 0x06008647 RID: 34375 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(float value)
			{
			}

			// Token: 0x06008648 RID: 34376 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(double value)
			{
			}

			// Token: 0x06008649 RID: 34377 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(decimal value)
			{
			}

			// Token: 0x0600864A RID: 34378 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(string value)
			{
			}

			// Token: 0x0600864B RID: 34379 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(StringBuilder value)
			{
			}

			// Token: 0x0600864C RID: 34380 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine(object value)
			{
			}

			// Token: 0x0600864D RID: 34381 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0)
			{
			}

			// Token: 0x0600864E RID: 34382 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
			{
			}

			// Token: 0x0600864F RID: 34383 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
			{
			}

			// Token: 0x06008650 RID: 34384 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, params object[] arg)
			{
			}

			// Token: 0x06008651 RID: 34385 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] ReadOnlySpan<object> arg)
			{
			}

			// Token: 0x06008652 RID: 34386 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(char value)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008653 RID: 34387 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(string value)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008654 RID: 34388 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008655 RID: 34389 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(char[] buffer, int index, int count)
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008656 RID: 34390 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				return Task.CompletedTask;
			}

			// Token: 0x06008657 RID: 34391 RVA: 0x001414EE File Offset: 0x0013F6EE
			public override Task WriteLineAsync()
			{
				return Task.CompletedTask;
			}
		}

		// Token: 0x02000838 RID: 2104
		internal sealed class SyncTextWriter : TextWriter, IDisposable
		{
			// Token: 0x06008658 RID: 34392 RVA: 0x001438EF File Offset: 0x00141AEF
			internal SyncTextWriter(TextWriter t)
			{
				this._out = t;
			}

			// Token: 0x170011BF RID: 4543
			// (get) Token: 0x06008659 RID: 34393 RVA: 0x001438FE File Offset: 0x00141AFE
			public override Encoding Encoding
			{
				get
				{
					return this._out.Encoding;
				}
			}

			// Token: 0x170011C0 RID: 4544
			// (get) Token: 0x0600865A RID: 34394 RVA: 0x0014390B File Offset: 0x00141B0B
			public override IFormatProvider FormatProvider
			{
				get
				{
					return this._out.FormatProvider;
				}
			}

			// Token: 0x170011C1 RID: 4545
			// (get) Token: 0x0600865B RID: 34395 RVA: 0x00143918 File Offset: 0x00141B18
			// (set) Token: 0x0600865C RID: 34396 RVA: 0x00143925 File Offset: 0x00141B25
			public override string NewLine
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				get
				{
					return this._out.NewLine;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				[param: AllowNull]
				set
				{
					this._out.NewLine = value;
				}
			}

			// Token: 0x0600865D RID: 34397 RVA: 0x00143933 File Offset: 0x00141B33
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Close()
			{
				this._out.Close();
			}

			// Token: 0x0600865E RID: 34398 RVA: 0x00143940 File Offset: 0x00141B40
			[MethodImpl(MethodImplOptions.Synchronized)]
			protected override void Dispose(bool disposing)
			{
				if (disposing)
				{
					((IDisposable)this._out).Dispose();
				}
			}

			// Token: 0x0600865F RID: 34399 RVA: 0x00143950 File Offset: 0x00141B50
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Flush()
			{
				this._out.Flush();
			}

			// Token: 0x06008660 RID: 34400 RVA: 0x0014395D File Offset: 0x00141B5D
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char value)
			{
				this._out.Write(value);
			}

			// Token: 0x06008661 RID: 34401 RVA: 0x0014396B File Offset: 0x00141B6B
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char[] buffer)
			{
				this._out.Write(buffer);
			}

			// Token: 0x06008662 RID: 34402 RVA: 0x00143979 File Offset: 0x00141B79
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char[] buffer, int index, int count)
			{
				this._out.Write(buffer, index, count);
			}

			// Token: 0x06008663 RID: 34403 RVA: 0x00143989 File Offset: 0x00141B89
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(ReadOnlySpan<char> buffer)
			{
				this._out.Write(buffer);
			}

			// Token: 0x06008664 RID: 34404 RVA: 0x00143997 File Offset: 0x00141B97
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(bool value)
			{
				this._out.Write(value);
			}

			// Token: 0x06008665 RID: 34405 RVA: 0x001439A5 File Offset: 0x00141BA5
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(int value)
			{
				this._out.Write(value);
			}

			// Token: 0x06008666 RID: 34406 RVA: 0x001439B3 File Offset: 0x00141BB3
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(uint value)
			{
				this._out.Write(value);
			}

			// Token: 0x06008667 RID: 34407 RVA: 0x001439C1 File Offset: 0x00141BC1
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(long value)
			{
				this._out.Write(value);
			}

			// Token: 0x06008668 RID: 34408 RVA: 0x001439CF File Offset: 0x00141BCF
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(ulong value)
			{
				this._out.Write(value);
			}

			// Token: 0x06008669 RID: 34409 RVA: 0x001439DD File Offset: 0x00141BDD
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(float value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600866A RID: 34410 RVA: 0x001439EB File Offset: 0x00141BEB
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(double value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600866B RID: 34411 RVA: 0x001439F9 File Offset: 0x00141BF9
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(decimal value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600866C RID: 34412 RVA: 0x00143A07 File Offset: 0x00141C07
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(string value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600866D RID: 34413 RVA: 0x00143A15 File Offset: 0x00141C15
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(StringBuilder value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600866E RID: 34414 RVA: 0x00143A23 File Offset: 0x00141C23
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(object value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600866F RID: 34415 RVA: 0x00143A31 File Offset: 0x00141C31
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0)
			{
				this._out.Write(format, arg0);
			}

			// Token: 0x06008670 RID: 34416 RVA: 0x00143A40 File Offset: 0x00141C40
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
			{
				this._out.Write(format, arg0, arg1);
			}

			// Token: 0x06008671 RID: 34417 RVA: 0x00143A50 File Offset: 0x00141C50
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
			{
				this._out.Write(format, arg0, arg1, arg2);
			}

			// Token: 0x06008672 RID: 34418 RVA: 0x00143A62 File Offset: 0x00141C62
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write([StringSyntax("CompositeFormat")] string format, params object[] arg)
			{
				this._out.Write(format, arg);
			}

			// Token: 0x06008673 RID: 34419 RVA: 0x00143A71 File Offset: 0x00141C71
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write([StringSyntax("CompositeFormat")] string format, [ParamCollection] ReadOnlySpan<object> arg)
			{
				this._out.Write(format, arg);
			}

			// Token: 0x06008674 RID: 34420 RVA: 0x00143A80 File Offset: 0x00141C80
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine()
			{
				this._out.WriteLine();
			}

			// Token: 0x06008675 RID: 34421 RVA: 0x00143A8D File Offset: 0x00141C8D
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(char value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06008676 RID: 34422 RVA: 0x00143A9B File Offset: 0x00141C9B
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(decimal value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06008677 RID: 34423 RVA: 0x00143AA9 File Offset: 0x00141CA9
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(char[] buffer)
			{
				this._out.WriteLine(buffer);
			}

			// Token: 0x06008678 RID: 34424 RVA: 0x00143AB7 File Offset: 0x00141CB7
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(char[] buffer, int index, int count)
			{
				this._out.WriteLine(buffer, index, count);
			}

			// Token: 0x06008679 RID: 34425 RVA: 0x00143AC7 File Offset: 0x00141CC7
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(ReadOnlySpan<char> buffer)
			{
				this._out.WriteLine(buffer);
			}

			// Token: 0x0600867A RID: 34426 RVA: 0x00143AD5 File Offset: 0x00141CD5
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(bool value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x0600867B RID: 34427 RVA: 0x00143AE3 File Offset: 0x00141CE3
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(int value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x0600867C RID: 34428 RVA: 0x00143AF1 File Offset: 0x00141CF1
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(uint value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x0600867D RID: 34429 RVA: 0x00143AFF File Offset: 0x00141CFF
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(long value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x0600867E RID: 34430 RVA: 0x00143B0D File Offset: 0x00141D0D
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(ulong value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x0600867F RID: 34431 RVA: 0x00143B1B File Offset: 0x00141D1B
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(float value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06008680 RID: 34432 RVA: 0x00143B29 File Offset: 0x00141D29
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(double value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06008681 RID: 34433 RVA: 0x00143B37 File Offset: 0x00141D37
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06008682 RID: 34434 RVA: 0x00143B45 File Offset: 0x00141D45
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(StringBuilder value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06008683 RID: 34435 RVA: 0x00143B53 File Offset: 0x00141D53
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(object value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06008684 RID: 34436 RVA: 0x00143B61 File Offset: 0x00141D61
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0)
			{
				this._out.WriteLine(format, arg0);
			}

			// Token: 0x06008685 RID: 34437 RVA: 0x00143B70 File Offset: 0x00141D70
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
			{
				this._out.WriteLine(format, arg0, arg1);
			}

			// Token: 0x06008686 RID: 34438 RVA: 0x00143B80 File Offset: 0x00141D80
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
			{
				this._out.WriteLine(format, arg0, arg1, arg2);
			}

			// Token: 0x06008687 RID: 34439 RVA: 0x00143B92 File Offset: 0x00141D92
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, params object[] arg)
			{
				this._out.WriteLine(format, arg);
			}

			// Token: 0x06008688 RID: 34440 RVA: 0x00143BA1 File Offset: 0x00141DA1
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, [ParamCollection] ReadOnlySpan<object> arg)
			{
				this._out.WriteLine(format, arg);
			}

			// Token: 0x06008689 RID: 34441 RVA: 0x00143BB0 File Offset: 0x00141DB0
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override ValueTask DisposeAsync()
			{
				base.Dispose();
				return default(ValueTask);
			}

			// Token: 0x0600868A RID: 34442 RVA: 0x00142447 File Offset: 0x00140647
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(char value)
			{
				this.Write(value);
				return Task.CompletedTask;
			}

			// Token: 0x0600868B RID: 34443 RVA: 0x00142455 File Offset: 0x00140655
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(string value)
			{
				this.Write(value);
				return Task.CompletedTask;
			}

			// Token: 0x0600868C RID: 34444 RVA: 0x00143BCC File Offset: 0x00141DCC
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled(cancellationToken);
				}
				this.Write(value);
				return Task.CompletedTask;
			}

			// Token: 0x0600868D RID: 34445 RVA: 0x00142463 File Offset: 0x00140663
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(char[] buffer, int index, int count)
			{
				this.Write(buffer, index, count);
				return Task.CompletedTask;
			}

			// Token: 0x0600868E RID: 34446 RVA: 0x00142473 File Offset: 0x00140673
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled(cancellationToken);
				}
				this.Write(buffer.Span);
				return Task.CompletedTask;
			}

			// Token: 0x0600868F RID: 34447 RVA: 0x00142591 File Offset: 0x00140791
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled(cancellationToken);
				}
				this.WriteLine(buffer.Span);
				return Task.CompletedTask;
			}

			// Token: 0x06008690 RID: 34448 RVA: 0x001424FB File Offset: 0x001406FB
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteLineAsync(char value)
			{
				this.WriteLine(value);
				return Task.CompletedTask;
			}

			// Token: 0x06008691 RID: 34449 RVA: 0x00143BEA File Offset: 0x00141DEA
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteLineAsync()
			{
				this.WriteLine();
				return Task.CompletedTask;
			}

			// Token: 0x06008692 RID: 34450 RVA: 0x00142509 File Offset: 0x00140709
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteLineAsync(string value)
			{
				this.WriteLine(value);
				return Task.CompletedTask;
			}

			// Token: 0x06008693 RID: 34451 RVA: 0x00143BF7 File Offset: 0x00141DF7
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteLineAsync(StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled(cancellationToken);
				}
				this.WriteLine(value);
				return Task.CompletedTask;
			}

			// Token: 0x06008694 RID: 34452 RVA: 0x00142581 File Offset: 0x00140781
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteLineAsync(char[] buffer, int index, int count)
			{
				this.WriteLine(buffer, index, count);
				return Task.CompletedTask;
			}

			// Token: 0x06008695 RID: 34453 RVA: 0x00143C15 File Offset: 0x00141E15
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task FlushAsync()
			{
				this.Flush();
				return Task.CompletedTask;
			}

			// Token: 0x06008696 RID: 34454 RVA: 0x00143C22 File Offset: 0x00141E22
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task FlushAsync(CancellationToken cancellationToken)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return Task.FromCanceled(cancellationToken);
				}
				this.Flush();
				return Task.CompletedTask;
			}

			// Token: 0x04001CD4 RID: 7380
			private readonly TextWriter _out;
		}

		// Token: 0x02000839 RID: 2105
		private sealed class BroadcastingTextWriter : TextWriter
		{
			// Token: 0x06008697 RID: 34455 RVA: 0x00143C40 File Offset: 0x00141E40
			public BroadcastingTextWriter(TextWriter[] writers)
			{
				for (int i = 0; i < writers.Length; i++)
				{
					ArgumentNullException.ThrowIfNull(writers[i], "writers");
				}
				this._writers = writers;
			}

			// Token: 0x170011C2 RID: 4546
			// (get) Token: 0x06008698 RID: 34456 RVA: 0x00143C77 File Offset: 0x00141E77
			public override Encoding Encoding
			{
				get
				{
					return this._writers[0].Encoding;
				}
			}

			// Token: 0x170011C3 RID: 4547
			// (get) Token: 0x06008699 RID: 34457 RVA: 0x00143C86 File Offset: 0x00141E86
			public override IFormatProvider FormatProvider
			{
				get
				{
					return this._writers[0].FormatProvider;
				}
			}

			// Token: 0x170011C4 RID: 4548
			// (get) Token: 0x0600869A RID: 34458 RVA: 0x001414C6 File Offset: 0x0013F6C6
			// (set) Token: 0x0600869B RID: 34459 RVA: 0x00143C98 File Offset: 0x00141E98
			public override string NewLine
			{
				get
				{
					return base.NewLine;
				}
				[param: AllowNull]
				set
				{
					base.NewLine = value;
					TextWriter[] writers = this._writers;
					for (int i = 0; i < writers.Length; i++)
					{
						writers[i].NewLine = value;
					}
				}
			}

			// Token: 0x0600869C RID: 34460 RVA: 0x00143CCC File Offset: 0x00141ECC
			protected override void Dispose(bool disposing)
			{
				if (disposing)
				{
					TextWriter[] writers = this._writers;
					for (int i = 0; i < writers.Length; i++)
					{
						writers[i].Dispose();
					}
				}
			}

			// Token: 0x0600869D RID: 34461 RVA: 0x00143CFC File Offset: 0x00141EFC
			public override ValueTask DisposeAsync()
			{
				TextWriter.BroadcastingTextWriter.<DisposeAsync>d__10 <DisposeAsync>d__;
				<DisposeAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
				<DisposeAsync>d__.<>4__this = this;
				<DisposeAsync>d__.<>1__state = -1;
				<DisposeAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<DisposeAsync>d__10>(ref <DisposeAsync>d__);
				return <DisposeAsync>d__.<>t__builder.Task;
			}

			// Token: 0x0600869E RID: 34462 RVA: 0x00143D40 File Offset: 0x00141F40
			public override void Flush()
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Flush();
				}
			}

			// Token: 0x0600869F RID: 34463 RVA: 0x00143D6C File Offset: 0x00141F6C
			public override Task FlushAsync()
			{
				TextWriter.BroadcastingTextWriter.<FlushAsync>d__12 <FlushAsync>d__;
				<FlushAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<FlushAsync>d__.<>4__this = this;
				<FlushAsync>d__.<>1__state = -1;
				<FlushAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<FlushAsync>d__12>(ref <FlushAsync>d__);
				return <FlushAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086A0 RID: 34464 RVA: 0x00143DB0 File Offset: 0x00141FB0
			public override Task FlushAsync(CancellationToken cancellationToken)
			{
				TextWriter.BroadcastingTextWriter.<FlushAsync>d__13 <FlushAsync>d__;
				<FlushAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<FlushAsync>d__.<>4__this = this;
				<FlushAsync>d__.cancellationToken = cancellationToken;
				<FlushAsync>d__.<>1__state = -1;
				<FlushAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<FlushAsync>d__13>(ref <FlushAsync>d__);
				return <FlushAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086A1 RID: 34465 RVA: 0x00143DFC File Offset: 0x00141FFC
			public override void Write(bool value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086A2 RID: 34466 RVA: 0x00143E28 File Offset: 0x00142028
			public override void Write(char value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086A3 RID: 34467 RVA: 0x00143E54 File Offset: 0x00142054
			public override void Write(char[] buffer, int index, int count)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(buffer, index, count);
				}
			}

			// Token: 0x060086A4 RID: 34468 RVA: 0x00143E84 File Offset: 0x00142084
			public override void Write(char[] buffer)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(buffer);
				}
			}

			// Token: 0x060086A5 RID: 34469 RVA: 0x00143EB0 File Offset: 0x001420B0
			public override void Write(decimal value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086A6 RID: 34470 RVA: 0x00143EDC File Offset: 0x001420DC
			public override void Write(double value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086A7 RID: 34471 RVA: 0x00143F08 File Offset: 0x00142108
			public override void Write(int value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086A8 RID: 34472 RVA: 0x00143F34 File Offset: 0x00142134
			public override void Write(long value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086A9 RID: 34473 RVA: 0x00143F60 File Offset: 0x00142160
			public override void Write(ReadOnlySpan<char> buffer)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(buffer);
				}
			}

			// Token: 0x060086AA RID: 34474 RVA: 0x00143F8C File Offset: 0x0014218C
			public override void Write(uint value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086AB RID: 34475 RVA: 0x00143FB8 File Offset: 0x001421B8
			public override void Write(ulong value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086AC RID: 34476 RVA: 0x00143FE4 File Offset: 0x001421E4
			public override void Write(float value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086AD RID: 34477 RVA: 0x00144010 File Offset: 0x00142210
			public override void Write(string value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086AE RID: 34478 RVA: 0x0014403C File Offset: 0x0014223C
			public override void Write(object value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086AF RID: 34479 RVA: 0x00144068 File Offset: 0x00142268
			public override void Write(StringBuilder value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(value);
				}
			}

			// Token: 0x060086B0 RID: 34480 RVA: 0x00144094 File Offset: 0x00142294
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(format, arg0);
				}
			}

			// Token: 0x060086B1 RID: 34481 RVA: 0x001440C0 File Offset: 0x001422C0
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(format, arg0, arg1);
				}
			}

			// Token: 0x060086B2 RID: 34482 RVA: 0x001440F0 File Offset: 0x001422F0
			public override void Write([StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(format, arg0, arg1, arg2);
				}
			}

			// Token: 0x060086B3 RID: 34483 RVA: 0x00144120 File Offset: 0x00142320
			public override void Write([StringSyntax("CompositeFormat")] string format, params object[] arg)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(format, arg);
				}
			}

			// Token: 0x060086B4 RID: 34484 RVA: 0x0014414C File Offset: 0x0014234C
			public override void Write([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] ReadOnlySpan<object> arg)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].Write(format, arg);
				}
			}

			// Token: 0x060086B5 RID: 34485 RVA: 0x00144178 File Offset: 0x00142378
			public override void WriteLine()
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine();
				}
			}

			// Token: 0x060086B6 RID: 34486 RVA: 0x001441A4 File Offset: 0x001423A4
			public override void WriteLine(char value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086B7 RID: 34487 RVA: 0x001441D0 File Offset: 0x001423D0
			public override void WriteLine(char[] buffer)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(buffer);
				}
			}

			// Token: 0x060086B8 RID: 34488 RVA: 0x001441FC File Offset: 0x001423FC
			public override void WriteLine(char[] buffer, int index, int count)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(buffer, index, count);
				}
			}

			// Token: 0x060086B9 RID: 34489 RVA: 0x0014422C File Offset: 0x0014242C
			public override void WriteLine(ReadOnlySpan<char> buffer)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(buffer);
				}
			}

			// Token: 0x060086BA RID: 34490 RVA: 0x00144258 File Offset: 0x00142458
			public override void WriteLine(bool value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086BB RID: 34491 RVA: 0x00144284 File Offset: 0x00142484
			public override void WriteLine(int value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086BC RID: 34492 RVA: 0x001442B0 File Offset: 0x001424B0
			public override void WriteLine(uint value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086BD RID: 34493 RVA: 0x001442DC File Offset: 0x001424DC
			public override void WriteLine(long value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086BE RID: 34494 RVA: 0x00144308 File Offset: 0x00142508
			public override void WriteLine(ulong value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086BF RID: 34495 RVA: 0x00144334 File Offset: 0x00142534
			public override void WriteLine(float value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086C0 RID: 34496 RVA: 0x00144360 File Offset: 0x00142560
			public override void WriteLine(double value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086C1 RID: 34497 RVA: 0x0014438C File Offset: 0x0014258C
			public override void WriteLine(decimal value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086C2 RID: 34498 RVA: 0x001443B8 File Offset: 0x001425B8
			public override void WriteLine(string value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086C3 RID: 34499 RVA: 0x001443E4 File Offset: 0x001425E4
			public override void WriteLine(StringBuilder value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086C4 RID: 34500 RVA: 0x00144410 File Offset: 0x00142610
			public override void WriteLine(object value)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(value);
				}
			}

			// Token: 0x060086C5 RID: 34501 RVA: 0x0014443C File Offset: 0x0014263C
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(format, arg0);
				}
			}

			// Token: 0x060086C6 RID: 34502 RVA: 0x00144468 File Offset: 0x00142668
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(format, arg0, arg1);
				}
			}

			// Token: 0x060086C7 RID: 34503 RVA: 0x00144498 File Offset: 0x00142698
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(format, arg0, arg1, arg2);
				}
			}

			// Token: 0x060086C8 RID: 34504 RVA: 0x001444C8 File Offset: 0x001426C8
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, params object[] arg)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(format, arg);
				}
			}

			// Token: 0x060086C9 RID: 34505 RVA: 0x001444F4 File Offset: 0x001426F4
			public override void WriteLine([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] ReadOnlySpan<object> arg)
			{
				TextWriter[] writers = this._writers;
				for (int i = 0; i < writers.Length; i++)
				{
					writers[i].WriteLine(format, arg);
				}
			}

			// Token: 0x060086CA RID: 34506 RVA: 0x00144520 File Offset: 0x00142720
			public override Task WriteAsync(char value)
			{
				TextWriter.BroadcastingTextWriter.<WriteAsync>d__55 <WriteAsync>d__;
				<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteAsync>d__.<>4__this = this;
				<WriteAsync>d__.value = value;
				<WriteAsync>d__.<>1__state = -1;
				<WriteAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteAsync>d__55>(ref <WriteAsync>d__);
				return <WriteAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086CB RID: 34507 RVA: 0x0014456C File Offset: 0x0014276C
			public override Task WriteAsync(string value)
			{
				TextWriter.BroadcastingTextWriter.<WriteAsync>d__56 <WriteAsync>d__;
				<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteAsync>d__.<>4__this = this;
				<WriteAsync>d__.value = value;
				<WriteAsync>d__.<>1__state = -1;
				<WriteAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteAsync>d__56>(ref <WriteAsync>d__);
				return <WriteAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086CC RID: 34508 RVA: 0x001445B8 File Offset: 0x001427B8
			public override Task WriteAsync(StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
			{
				TextWriter.BroadcastingTextWriter.<WriteAsync>d__57 <WriteAsync>d__;
				<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteAsync>d__.<>4__this = this;
				<WriteAsync>d__.value = value;
				<WriteAsync>d__.cancellationToken = cancellationToken;
				<WriteAsync>d__.<>1__state = -1;
				<WriteAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteAsync>d__57>(ref <WriteAsync>d__);
				return <WriteAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086CD RID: 34509 RVA: 0x0014460C File Offset: 0x0014280C
			public override Task WriteAsync(char[] buffer, int index, int count)
			{
				TextWriter.BroadcastingTextWriter.<WriteAsync>d__58 <WriteAsync>d__;
				<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteAsync>d__.<>4__this = this;
				<WriteAsync>d__.buffer = buffer;
				<WriteAsync>d__.index = index;
				<WriteAsync>d__.count = count;
				<WriteAsync>d__.<>1__state = -1;
				<WriteAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteAsync>d__58>(ref <WriteAsync>d__);
				return <WriteAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086CE RID: 34510 RVA: 0x00144668 File Offset: 0x00142868
			public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				TextWriter.BroadcastingTextWriter.<WriteAsync>d__59 <WriteAsync>d__;
				<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteAsync>d__.<>4__this = this;
				<WriteAsync>d__.buffer = buffer;
				<WriteAsync>d__.cancellationToken = cancellationToken;
				<WriteAsync>d__.<>1__state = -1;
				<WriteAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteAsync>d__59>(ref <WriteAsync>d__);
				return <WriteAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086CF RID: 34511 RVA: 0x001446BC File Offset: 0x001428BC
			public override Task WriteLineAsync(char value)
			{
				TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__60 <WriteLineAsync>d__;
				<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteLineAsync>d__.<>4__this = this;
				<WriteLineAsync>d__.value = value;
				<WriteLineAsync>d__.<>1__state = -1;
				<WriteLineAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__60>(ref <WriteLineAsync>d__);
				return <WriteLineAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086D0 RID: 34512 RVA: 0x00144708 File Offset: 0x00142908
			public override Task WriteLineAsync(string value)
			{
				TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__61 <WriteLineAsync>d__;
				<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteLineAsync>d__.<>4__this = this;
				<WriteLineAsync>d__.value = value;
				<WriteLineAsync>d__.<>1__state = -1;
				<WriteLineAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__61>(ref <WriteLineAsync>d__);
				return <WriteLineAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086D1 RID: 34513 RVA: 0x00144754 File Offset: 0x00142954
			public override Task WriteLineAsync(StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
			{
				TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__62 <WriteLineAsync>d__;
				<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteLineAsync>d__.<>4__this = this;
				<WriteLineAsync>d__.value = value;
				<WriteLineAsync>d__.cancellationToken = cancellationToken;
				<WriteLineAsync>d__.<>1__state = -1;
				<WriteLineAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__62>(ref <WriteLineAsync>d__);
				return <WriteLineAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086D2 RID: 34514 RVA: 0x001447A8 File Offset: 0x001429A8
			public override Task WriteLineAsync(char[] buffer, int index, int count)
			{
				TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__63 <WriteLineAsync>d__;
				<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteLineAsync>d__.<>4__this = this;
				<WriteLineAsync>d__.buffer = buffer;
				<WriteLineAsync>d__.index = index;
				<WriteLineAsync>d__.count = count;
				<WriteLineAsync>d__.<>1__state = -1;
				<WriteLineAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__63>(ref <WriteLineAsync>d__);
				return <WriteLineAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086D3 RID: 34515 RVA: 0x00144804 File Offset: 0x00142A04
			public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__64 <WriteLineAsync>d__;
				<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteLineAsync>d__.<>4__this = this;
				<WriteLineAsync>d__.buffer = buffer;
				<WriteLineAsync>d__.cancellationToken = cancellationToken;
				<WriteLineAsync>d__.<>1__state = -1;
				<WriteLineAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__64>(ref <WriteLineAsync>d__);
				return <WriteLineAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060086D4 RID: 34516 RVA: 0x00144858 File Offset: 0x00142A58
			public override Task WriteLineAsync()
			{
				TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__65 <WriteLineAsync>d__;
				<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteLineAsync>d__.<>4__this = this;
				<WriteLineAsync>d__.<>1__state = -1;
				<WriteLineAsync>d__.<>t__builder.Start<TextWriter.BroadcastingTextWriter.<WriteLineAsync>d__65>(ref <WriteLineAsync>d__);
				return <WriteLineAsync>d__.<>t__builder.Task;
			}

			// Token: 0x04001CD5 RID: 7381
			private readonly TextWriter[] _writers;
		}
	}
}

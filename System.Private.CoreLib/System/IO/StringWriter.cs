using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000830 RID: 2096
	[NullableContext(1)]
	[Nullable(0)]
	public class StringWriter : TextWriter
	{
		// Token: 0x06008587 RID: 34183 RVA: 0x001421CC File Offset: 0x001403CC
		public StringWriter() : this(new StringBuilder(), CultureInfo.CurrentCulture)
		{
		}

		// Token: 0x06008588 RID: 34184 RVA: 0x001421DE File Offset: 0x001403DE
		[NullableContext(2)]
		public StringWriter(IFormatProvider formatProvider) : this(new StringBuilder(), formatProvider)
		{
		}

		// Token: 0x06008589 RID: 34185 RVA: 0x001421EC File Offset: 0x001403EC
		public StringWriter(StringBuilder sb) : this(sb, CultureInfo.CurrentCulture)
		{
		}

		// Token: 0x0600858A RID: 34186 RVA: 0x001421FA File Offset: 0x001403FA
		public StringWriter(StringBuilder sb, [Nullable(2)] IFormatProvider formatProvider) : base(formatProvider)
		{
			ArgumentNullException.ThrowIfNull(sb, "sb");
			this._sb = sb;
			this._isOpen = true;
		}

		// Token: 0x0600858B RID: 34187 RVA: 0x0014221C File Offset: 0x0014041C
		public override void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x0600858C RID: 34188 RVA: 0x00142225 File Offset: 0x00140425
		protected override void Dispose(bool disposing)
		{
			this._isOpen = false;
			base.Dispose(disposing);
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x0600858D RID: 34189 RVA: 0x00142235 File Offset: 0x00140435
		public override Encoding Encoding
		{
			get
			{
				UnicodeEncoding result;
				if ((result = StringWriter.s_encoding) == null)
				{
					result = (StringWriter.s_encoding = new UnicodeEncoding(false, false));
				}
				return result;
			}
		}

		// Token: 0x0600858E RID: 34190 RVA: 0x0014224D File Offset: 0x0014044D
		public virtual StringBuilder GetStringBuilder()
		{
			return this._sb;
		}

		// Token: 0x0600858F RID: 34191 RVA: 0x00142255 File Offset: 0x00140455
		public override void Write(char value)
		{
			if (!this._isOpen)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
			}
			this._sb.Append(value);
		}

		// Token: 0x06008590 RID: 34192 RVA: 0x00142278 File Offset: 0x00140478
		public override void Write(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
			}
			this._sb.Append(buffer, index, count);
		}

		// Token: 0x06008591 RID: 34193 RVA: 0x001422DC File Offset: 0x001404DC
		[NullableContext(0)]
		public override void Write(ReadOnlySpan<char> buffer)
		{
			if (base.GetType() != typeof(StringWriter))
			{
				base.Write(buffer);
				return;
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
			}
			this._sb.Append(buffer);
		}

		// Token: 0x06008592 RID: 34194 RVA: 0x00142329 File Offset: 0x00140529
		[NullableContext(2)]
		public override void Write(string value)
		{
			if (!this._isOpen)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
			}
			if (value != null)
			{
				this._sb.Append(value);
			}
		}

		// Token: 0x06008593 RID: 34195 RVA: 0x00142350 File Offset: 0x00140550
		[NullableContext(2)]
		public override void Write(StringBuilder value)
		{
			if (base.GetType() != typeof(StringWriter))
			{
				base.Write(value);
				return;
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
			}
			this._sb.Append(value);
		}

		// Token: 0x06008594 RID: 34196 RVA: 0x001423A0 File Offset: 0x001405A0
		[NullableContext(0)]
		public override void WriteLine(ReadOnlySpan<char> buffer)
		{
			if (base.GetType() != typeof(StringWriter))
			{
				base.WriteLine(buffer);
				return;
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
			}
			this._sb.Append(buffer);
			this.WriteLine();
		}

		// Token: 0x06008595 RID: 34197 RVA: 0x001423F4 File Offset: 0x001405F4
		[NullableContext(2)]
		public override void WriteLine(StringBuilder value)
		{
			if (base.GetType() != typeof(StringWriter))
			{
				base.WriteLine(value);
				return;
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
			}
			this._sb.Append(value);
			this.WriteLine();
		}

		// Token: 0x06008596 RID: 34198 RVA: 0x00142447 File Offset: 0x00140647
		public override Task WriteAsync(char value)
		{
			this.Write(value);
			return Task.CompletedTask;
		}

		// Token: 0x06008597 RID: 34199 RVA: 0x00142455 File Offset: 0x00140655
		public override Task WriteAsync([Nullable(2)] string value)
		{
			this.Write(value);
			return Task.CompletedTask;
		}

		// Token: 0x06008598 RID: 34200 RVA: 0x00142463 File Offset: 0x00140663
		public override Task WriteAsync(char[] buffer, int index, int count)
		{
			this.Write(buffer, index, count);
			return Task.CompletedTask;
		}

		// Token: 0x06008599 RID: 34201 RVA: 0x00142473 File Offset: 0x00140673
		[NullableContext(0)]
		[return: Nullable(1)]
		public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			this.Write(buffer.Span);
			return Task.CompletedTask;
		}

		// Token: 0x0600859A RID: 34202 RVA: 0x00142498 File Offset: 0x00140698
		public override Task WriteAsync([Nullable(2)] StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(StringWriter))
			{
				return base.WriteAsync(value, cancellationToken);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
			}
			this._sb.Append(value);
			return Task.CompletedTask;
		}

		// Token: 0x0600859B RID: 34203 RVA: 0x001424FB File Offset: 0x001406FB
		public override Task WriteLineAsync(char value)
		{
			this.WriteLine(value);
			return Task.CompletedTask;
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x00142509 File Offset: 0x00140709
		public override Task WriteLineAsync([Nullable(2)] string value)
		{
			this.WriteLine(value);
			return Task.CompletedTask;
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x00142518 File Offset: 0x00140718
		public override Task WriteLineAsync([Nullable(2)] StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(StringWriter))
			{
				return base.WriteLineAsync(value, cancellationToken);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
			}
			this._sb.Append(value);
			this.WriteLine();
			return Task.CompletedTask;
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x00142581 File Offset: 0x00140781
		public override Task WriteLineAsync(char[] buffer, int index, int count)
		{
			this.WriteLine(buffer, index, count);
			return Task.CompletedTask;
		}

		// Token: 0x0600859F RID: 34207 RVA: 0x00142591 File Offset: 0x00140791
		[NullableContext(0)]
		[return: Nullable(1)]
		public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			this.WriteLine(buffer.Span);
			return Task.CompletedTask;
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x001414EE File Offset: 0x0013F6EE
		public override Task FlushAsync()
		{
			return Task.CompletedTask;
		}

		// Token: 0x060085A1 RID: 34209 RVA: 0x001425B5 File Offset: 0x001407B5
		public override string ToString()
		{
			return this._sb.ToString();
		}

		// Token: 0x04001CB7 RID: 7351
		private static UnicodeEncoding s_encoding;

		// Token: 0x04001CB8 RID: 7352
		private readonly StringBuilder _sb;

		// Token: 0x04001CB9 RID: 7353
		private bool _isOpen;
	}
}

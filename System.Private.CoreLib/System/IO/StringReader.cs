using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x0200082F RID: 2095
	[NullableContext(1)]
	[Nullable(0)]
	public class StringReader : TextReader
	{
		// Token: 0x06008574 RID: 34164 RVA: 0x00141DE6 File Offset: 0x0013FFE6
		public StringReader(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			this._s = s;
		}

		// Token: 0x06008575 RID: 34165 RVA: 0x0013E804 File Offset: 0x0013CA04
		public override void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x06008576 RID: 34166 RVA: 0x00141DFF File Offset: 0x0013FFFF
		protected override void Dispose(bool disposing)
		{
			this._s = null;
			this._pos = 0;
			base.Dispose(disposing);
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x00141E18 File Offset: 0x00140018
		public override int Peek()
		{
			string s = this._s;
			if (s == null)
			{
				StringReader.ThrowObjectDisposedException_ReaderClosed();
			}
			int pos = this._pos;
			if (pos < s.Length)
			{
				return (int)s[pos];
			}
			return -1;
		}

		// Token: 0x06008578 RID: 34168 RVA: 0x00141E50 File Offset: 0x00140050
		public override int Read()
		{
			string s = this._s;
			if (s == null)
			{
				StringReader.ThrowObjectDisposedException_ReaderClosed();
			}
			int pos = this._pos;
			if (pos < s.Length)
			{
				this._pos++;
				return (int)s[pos];
			}
			return -1;
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x00141E94 File Offset: 0x00140094
		public override int Read(char[] buffer, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			if (this._s == null)
			{
				StringReader.ThrowObjectDisposedException_ReaderClosed();
			}
			int num = this._s.Length - this._pos;
			if (num > 0)
			{
				if (num > count)
				{
					num = count;
				}
				this._s.CopyTo(this._pos, buffer, index, num);
				this._pos += num;
			}
			return num;
		}

		// Token: 0x0600857A RID: 34170 RVA: 0x00141F24 File Offset: 0x00140124
		[NullableContext(0)]
		public override int Read(Span<char> buffer)
		{
			if (base.GetType() != typeof(StringReader))
			{
				return base.Read(buffer);
			}
			string s = this._s;
			if (s == null)
			{
				StringReader.ThrowObjectDisposedException_ReaderClosed();
			}
			int num = s.Length - this._pos;
			if (num > 0)
			{
				if (num > buffer.Length)
				{
					num = buffer.Length;
				}
				s.AsSpan(this._pos, num).CopyTo(buffer);
				this._pos += num;
			}
			return num;
		}

		// Token: 0x0600857B RID: 34171 RVA: 0x00141FA8 File Offset: 0x001401A8
		[NullableContext(0)]
		public override int ReadBlock(Span<char> buffer)
		{
			return this.Read(buffer);
		}

		// Token: 0x0600857C RID: 34172 RVA: 0x00141FB4 File Offset: 0x001401B4
		public override string ReadToEnd()
		{
			string text = this._s;
			if (text == null)
			{
				StringReader.ThrowObjectDisposedException_ReaderClosed();
			}
			int pos = this._pos;
			this._pos = text.Length;
			if (pos != 0)
			{
				text = text.Substring(pos);
			}
			return text;
		}

		// Token: 0x0600857D RID: 34173 RVA: 0x00141FF0 File Offset: 0x001401F0
		[NullableContext(2)]
		public unsafe override string ReadLine()
		{
			string s = this._s;
			if (s == null)
			{
				StringReader.ThrowObjectDisposedException_ReaderClosed();
			}
			int num = this._pos;
			if (num >= s.Length)
			{
				return null;
			}
			ReadOnlySpan<char> span = s.AsSpan(num);
			int num2 = span.IndexOfAny('\r', '\n');
			if (num2 >= 0)
			{
				string result = s.Substring(num, num2);
				int num3 = (int)(*span[num2]);
				num += num2 + 1;
				if (num3 == 13 && num < s.Length && s[num] == '\n')
				{
					num++;
				}
				this._pos = num;
				return result;
			}
			string result2 = s.Substring(num);
			this._pos = s.Length;
			return result2;
		}

		// Token: 0x0600857E RID: 34174 RVA: 0x00142083 File Offset: 0x00140283
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public override Task<string> ReadLineAsync()
		{
			return Task.FromResult<string>(this.ReadLine());
		}

		// Token: 0x0600857F RID: 34175 RVA: 0x00142090 File Offset: 0x00140290
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public override ValueTask<string> ReadLineAsync(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<string>(this.ReadLine());
			}
			return ValueTask.FromCanceled<string>(cancellationToken);
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x001420AD File Offset: 0x001402AD
		public override Task<string> ReadToEndAsync()
		{
			return Task.FromResult<string>(this.ReadToEnd());
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x001420BA File Offset: 0x001402BA
		public override Task<string> ReadToEndAsync(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return Task.FromResult<string>(this.ReadToEnd());
			}
			return Task.FromCanceled<string>(cancellationToken);
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x001420D8 File Offset: 0x001402D8
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

		// Token: 0x06008583 RID: 34179 RVA: 0x00142127 File Offset: 0x00140327
		[NullableContext(0)]
		public override ValueTask<int> ReadBlockAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(this.ReadBlock(buffer.Span));
			}
			return ValueTask.FromCanceled<int>(cancellationToken);
		}

		// Token: 0x06008584 RID: 34180 RVA: 0x0014214C File Offset: 0x0014034C
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

		// Token: 0x06008585 RID: 34181 RVA: 0x0014219B File Offset: 0x0014039B
		[NullableContext(0)]
		public override ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(this.Read(buffer.Span));
			}
			return ValueTask.FromCanceled<int>(cancellationToken);
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x001421BF File Offset: 0x001403BF
		[DoesNotReturn]
		private static void ThrowObjectDisposedException_ReaderClosed()
		{
			throw new ObjectDisposedException(null, SR.ObjectDisposed_ReaderClosed);
		}

		// Token: 0x04001CB5 RID: 7349
		private string _s;

		// Token: 0x04001CB6 RID: 7350
		private int _pos;
	}
}

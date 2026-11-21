using System;
using System.Buffers;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text
{
	// Token: 0x0200023C RID: 572
	internal sealed class TranscodingStream : Stream
	{
		// Token: 0x06002BF3 RID: 11251 RVA: 0x0008A638 File Offset: 0x00088838
		internal TranscodingStream(Stream innerStream, Encoding innerEncoding, Encoding thisEncoding, bool leaveOpen)
		{
			this._innerStream = innerStream;
			this._leaveOpen = leaveOpen;
			this._innerEncoding = innerEncoding;
			this._thisEncoding = thisEncoding;
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x0008A65D File Offset: 0x0008885D
		public override bool CanRead
		{
			get
			{
				Stream innerStream = this._innerStream;
				return innerStream != null && innerStream.CanRead;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x0008A670 File Offset: 0x00088870
		public override bool CanWrite
		{
			get
			{
				Stream innerStream = this._innerStream;
				return innerStream != null && innerStream.CanWrite;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x00066BA5 File Offset: 0x00064DA5
		public override long Length
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_UnseekableStream);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x00066BA5 File Offset: 0x00064DA5
		// (set) Token: 0x06002BF9 RID: 11257 RVA: 0x0008A683 File Offset: 0x00088883
		public override long Position
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_UnseekableStream);
			}
			set
			{
				ThrowHelper.ThrowNotSupportedException_UnseekableStream();
			}
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x0008A68A File Offset: 0x0008888A
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToAsyncResult.Begin(this.ReadAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x0008A6A3 File Offset: 0x000888A3
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToAsyncResult.Begin(this.WriteAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x0008A6BC File Offset: 0x000888BC
		protected override void Dispose(bool disposing)
		{
			if (this._innerStream == null)
			{
				return;
			}
			ArraySegment<byte> segment = this.FinalFlushWriteBuffers();
			if (segment.Count != 0)
			{
				this._innerStream.Write(segment);
			}
			Stream innerStream = this._innerStream;
			this._innerStream = null;
			if (!this._leaveOpen)
			{
				innerStream.Dispose();
			}
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x0008A710 File Offset: 0x00088910
		public override ValueTask DisposeAsync()
		{
			if (this._innerStream == null)
			{
				return default(ValueTask);
			}
			ArraySegment<byte> pendingData = this.FinalFlushWriteBuffers();
			if (pendingData.Count != 0)
			{
				return this.<DisposeAsync>g__DisposeAsyncCore|30_0(pendingData);
			}
			Stream innerStream = this._innerStream;
			this._innerStream = null;
			if (!this._leaveOpen)
			{
				return innerStream.DisposeAsync();
			}
			return default(ValueTask);
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x0008A76D File Offset: 0x0008896D
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToAsyncResult.End<int>(asyncResult);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x0008A775 File Offset: 0x00088975
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToAsyncResult.End(asyncResult);
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x0008A77D File Offset: 0x0008897D
		[MemberNotNull(new string[]
		{
			"_innerDecoder",
			"_thisEncoder",
			"_readBuffer"
		})]
		private void EnsurePreReadConditions()
		{
			this.ThrowIfDisposed();
			if (this._innerDecoder == null)
			{
				this.<EnsurePreReadConditions>g__InitializeReadDataStructures|33_0();
			}
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x0008A793 File Offset: 0x00088993
		[MemberNotNull(new string[]
		{
			"_thisDecoder",
			"_innerEncoder"
		})]
		private void EnsurePreWriteConditions()
		{
			this.ThrowIfDisposed();
			if (this._innerEncoder == null)
			{
				this.<EnsurePreWriteConditions>g__InitializeReadDataStructures|34_0();
			}
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x0008A7AC File Offset: 0x000889AC
		private ArraySegment<byte> FinalFlushWriteBuffers()
		{
			if (this._thisDecoder == null || this._innerEncoder == null)
			{
				return default(ArraySegment<byte>);
			}
			char[] chars = Array.Empty<char>();
			int num = this._thisDecoder.GetCharCount(Array.Empty<byte>(), 0, 0, true);
			if (num > 0)
			{
				chars = new char[num];
				num = this._thisDecoder.GetChars(Array.Empty<byte>(), 0, 0, chars, 0, true);
			}
			byte[] array = Array.Empty<byte>();
			int num2 = this._innerEncoder.GetByteCount(chars, 0, num, true);
			if (num2 > 0)
			{
				array = new byte[num2];
				num2 = this._innerEncoder.GetBytes(chars, 0, num, array, 0, true);
			}
			return new ArraySegment<byte>(array, 0, num2);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x0008A84A File Offset: 0x00088A4A
		public override void Flush()
		{
			this.ThrowIfDisposed();
			this._innerStream.Flush();
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x0008A85D File Offset: 0x00088A5D
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			this.ThrowIfDisposed();
			return this._innerStream.FlushAsync(cancellationToken);
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x0008A871 File Offset: 0x00088A71
		public override int Read(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			return this.Read(new Span<byte>(buffer, offset, count));
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x0008A88C File Offset: 0x00088A8C
		public override int Read(Span<byte> buffer)
		{
			this.EnsurePreReadConditions();
			if (this._readBufferCount == 0)
			{
				byte[] array = ArrayPool<byte>.Shared.Rent(4096);
				char[] array2 = ArrayPool<char>.Shared.Rent(this._readCharBufferMaxSize);
				try
				{
					bool flag;
					int bytes;
					do
					{
						int num = this._innerStream.Read(array, 0, 4096);
						flag = (num == 0);
						int chars = this._innerDecoder.GetChars(array, 0, num, array2, 0, flag);
						bytes = this._thisEncoder.GetBytes(array2, 0, chars, this._readBuffer, 0, flag);
					}
					while (!flag && bytes == 0);
					this._readBufferOffset = 0;
					this._readBufferCount = bytes;
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(array, false);
					ArrayPool<char>.Shared.Return(array2, false);
				}
			}
			int num2 = Math.Min(this._readBufferCount, buffer.Length);
			this._readBuffer.AsSpan(this._readBufferOffset, num2).CopyTo(buffer);
			this._readBufferOffset += num2;
			this._readBufferCount -= num2;
			return num2;
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x0008A9A0 File Offset: 0x00088BA0
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			return this.ReadAsync(new Memory<byte>(buffer, offset, count), cancellationToken).AsTask();
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x0008A9CD File Offset: 0x00088BCD
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			this.EnsurePreReadConditions();
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled<int>(cancellationToken);
			}
			return this.<ReadAsync>g__ReadAsyncCore|41_0(buffer, cancellationToken);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x0008A9F0 File Offset: 0x00088BF0
		public override int ReadByte()
		{
			byte result = 0;
			if (this.Read(new Span<byte>(ref result)) == 0)
			{
				return -1;
			}
			return (int)result;
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00066BA5 File Offset: 0x00064DA5
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException(SR.NotSupported_UnseekableStream);
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x0008A683 File Offset: 0x00088883
		public override void SetLength(long value)
		{
			ThrowHelper.ThrowNotSupportedException_UnseekableStream();
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x0008AA11 File Offset: 0x00088C11
		[StackTraceHidden]
		private void ThrowIfDisposed()
		{
			if (this._innerStream == null)
			{
				this.ThrowObjectDisposedException();
			}
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x0008AA21 File Offset: 0x00088C21
		[DoesNotReturn]
		[StackTraceHidden]
		private void ThrowObjectDisposedException()
		{
			ThrowHelper.ThrowObjectDisposedException_StreamClosed(base.GetType().Name);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x0008AA33 File Offset: 0x00088C33
		public override void Write(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			this.Write(new ReadOnlySpan<byte>(buffer, offset, count));
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x0008AA4C File Offset: 0x00088C4C
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			this.EnsurePreWriteConditions();
			if (buffer.IsEmpty)
			{
				return;
			}
			int minimumLength = Math.Clamp(buffer.Length, 4096, 1048576);
			char[] array = ArrayPool<char>.Shared.Rent(minimumLength);
			byte[] array2 = ArrayPool<byte>.Shared.Rent(minimumLength);
			try
			{
				bool flag;
				do
				{
					int start;
					int length;
					this._thisDecoder.Convert(buffer, array, false, out start, out length, out flag);
					buffer = buffer.Slice(start);
					Span<char> span = array.AsSpan(0, length);
					bool flag2;
					do
					{
						int start2;
						int count;
						this._innerEncoder.Convert(span, array2, false, out start2, out count, out flag2);
						span = span.Slice(start2);
						this._innerStream.Write(array2, 0, count);
					}
					while (!flag2);
				}
				while (!flag);
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
				ArrayPool<byte>.Shared.Return(array2, false);
			}
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x0008AB34 File Offset: 0x00088D34
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			return this.WriteAsync(new ReadOnlyMemory<byte>(buffer, offset, count), cancellationToken).AsTask();
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x0008AB61 File Offset: 0x00088D61
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			this.EnsurePreWriteConditions();
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled(cancellationToken);
			}
			if (buffer.IsEmpty)
			{
				return ValueTask.CompletedTask;
			}
			return this.<WriteAsync>g__WriteAsyncCore|50_0(buffer, cancellationToken);
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x0008AB90 File Offset: 0x00088D90
		public override void WriteByte(byte value)
		{
			this.Write(new ReadOnlySpan<byte>(ref value));
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x0008ABA0 File Offset: 0x00088DA0
		[CompilerGenerated]
		private ValueTask <DisposeAsync>g__DisposeAsyncCore|30_0(ArraySegment<byte> pendingData)
		{
			TranscodingStream.<<DisposeAsync>g__DisposeAsyncCore|30_0>d <<DisposeAsync>g__DisposeAsyncCore|30_0>d;
			<<DisposeAsync>g__DisposeAsyncCore|30_0>d.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<<DisposeAsync>g__DisposeAsyncCore|30_0>d.<>4__this = this;
			<<DisposeAsync>g__DisposeAsyncCore|30_0>d.pendingData = pendingData;
			<<DisposeAsync>g__DisposeAsyncCore|30_0>d.<>1__state = -1;
			<<DisposeAsync>g__DisposeAsyncCore|30_0>d.<>t__builder.Start<TranscodingStream.<<DisposeAsync>g__DisposeAsyncCore|30_0>d>(ref <<DisposeAsync>g__DisposeAsyncCore|30_0>d);
			return <<DisposeAsync>g__DisposeAsyncCore|30_0>d.<>t__builder.Task;
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x0008ABEC File Offset: 0x00088DEC
		[CompilerGenerated]
		private void <EnsurePreReadConditions>g__InitializeReadDataStructures|33_0()
		{
			if (!this.CanRead)
			{
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
			this._innerDecoder = this._innerEncoding.GetDecoder();
			this._thisEncoder = this._thisEncoding.GetEncoder();
			this._readCharBufferMaxSize = this._innerEncoding.GetMaxCharCount(4096);
			this._readBuffer = GC.AllocateUninitializedArray<byte>(this._thisEncoding.GetMaxByteCount(this._readCharBufferMaxSize), false);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x0008AC5B File Offset: 0x00088E5B
		[CompilerGenerated]
		private void <EnsurePreWriteConditions>g__InitializeReadDataStructures|34_0()
		{
			if (!this.CanWrite)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
			this._innerEncoder = this._innerEncoding.GetEncoder();
			this._thisDecoder = this._thisEncoding.GetDecoder();
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x0008AC8C File Offset: 0x00088E8C
		[CompilerGenerated]
		private ValueTask<int> <ReadAsync>g__ReadAsyncCore|41_0(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			TranscodingStream.<<ReadAsync>g__ReadAsyncCore|41_0>d <<ReadAsync>g__ReadAsyncCore|41_0>d;
			<<ReadAsync>g__ReadAsyncCore|41_0>d.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<<ReadAsync>g__ReadAsyncCore|41_0>d.<>4__this = this;
			<<ReadAsync>g__ReadAsyncCore|41_0>d.buffer = buffer;
			<<ReadAsync>g__ReadAsyncCore|41_0>d.cancellationToken = cancellationToken;
			<<ReadAsync>g__ReadAsyncCore|41_0>d.<>1__state = -1;
			<<ReadAsync>g__ReadAsyncCore|41_0>d.<>t__builder.Start<TranscodingStream.<<ReadAsync>g__ReadAsyncCore|41_0>d>(ref <<ReadAsync>g__ReadAsyncCore|41_0>d);
			return <<ReadAsync>g__ReadAsyncCore|41_0>d.<>t__builder.Task;
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x0008ACE0 File Offset: 0x00088EE0
		[CompilerGenerated]
		private ValueTask <WriteAsync>g__WriteAsyncCore|50_0(ReadOnlyMemory<byte> remainingOuterEncodedBytes, CancellationToken cancellationToken)
		{
			TranscodingStream.<<WriteAsync>g__WriteAsyncCore|50_0>d <<WriteAsync>g__WriteAsyncCore|50_0>d;
			<<WriteAsync>g__WriteAsyncCore|50_0>d.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<<WriteAsync>g__WriteAsyncCore|50_0>d.<>4__this = this;
			<<WriteAsync>g__WriteAsyncCore|50_0>d.remainingOuterEncodedBytes = remainingOuterEncodedBytes;
			<<WriteAsync>g__WriteAsyncCore|50_0>d.cancellationToken = cancellationToken;
			<<WriteAsync>g__WriteAsyncCore|50_0>d.<>1__state = -1;
			<<WriteAsync>g__WriteAsyncCore|50_0>d.<>t__builder.Start<TranscodingStream.<<WriteAsync>g__WriteAsyncCore|50_0>d>(ref <<WriteAsync>g__WriteAsyncCore|50_0>d);
			return <<WriteAsync>g__WriteAsyncCore|50_0>d.<>t__builder.Task;
		}

		// Token: 0x040007A7 RID: 1959
		private readonly Encoding _innerEncoding;

		// Token: 0x040007A8 RID: 1960
		private readonly Encoding _thisEncoding;

		// Token: 0x040007A9 RID: 1961
		private Stream _innerStream;

		// Token: 0x040007AA RID: 1962
		private readonly bool _leaveOpen;

		// Token: 0x040007AB RID: 1963
		private Encoder _innerEncoder;

		// Token: 0x040007AC RID: 1964
		private Decoder _thisDecoder;

		// Token: 0x040007AD RID: 1965
		private Encoder _thisEncoder;

		// Token: 0x040007AE RID: 1966
		private Decoder _innerDecoder;

		// Token: 0x040007AF RID: 1967
		private int _readCharBufferMaxSize;

		// Token: 0x040007B0 RID: 1968
		private byte[] _readBuffer;

		// Token: 0x040007B1 RID: 1969
		private int _readBufferOffset;

		// Token: 0x040007B2 RID: 1970
		private int _readBufferCount;
	}
}

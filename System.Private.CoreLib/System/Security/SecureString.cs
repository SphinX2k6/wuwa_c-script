using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;

namespace System.Security
{
	// Token: 0x0200025D RID: 605
	public sealed class SecureString : IDisposable
	{
		// Token: 0x06002D7F RID: 11647 RVA: 0x00092679 File Offset: 0x00090879
		public SecureString()
		{
			this.Initialize(ReadOnlySpan<char>.Empty);
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x00092698 File Offset: 0x00090898
		[CLSCompliant(false)]
		public unsafe SecureString(char* value, int length)
		{
			ArgumentNullException.ThrowIfNull((void*)value, "value");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(length, 65536, "length");
			this.Initialize(new ReadOnlySpan<char>((void*)value, length));
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x000926EC File Offset: 0x000908EC
		private void Initialize(ReadOnlySpan<char> value)
		{
			this._buffer = SecureString.UnmanagedBuffer.Allocate(SecureString.GetAlignedByteSize(value.Length));
			this._decryptedLength = value.Length;
			SafeBuffer safeBuffer = null;
			try
			{
				Span<char> destination = this.AcquireSpan(ref safeBuffer);
				value.CopyTo(destination);
			}
			finally
			{
				this.ProtectMemory();
				if (safeBuffer != null)
				{
					safeBuffer.DangerousRelease();
				}
			}
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00092754 File Offset: 0x00090954
		private SecureString(SecureString str)
		{
			this._buffer = SecureString.UnmanagedBuffer.Allocate((int)str._buffer.ByteLength);
			SecureString.UnmanagedBuffer.Copy(str._buffer, this._buffer, str._buffer.ByteLength);
			this._decryptedLength = str._decryptedLength;
			this._encrypted = str._encrypted;
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x000927BD File Offset: 0x000909BD
		public int Length
		{
			get
			{
				this.EnsureNotDisposed();
				return Volatile.Read(ref this._decryptedLength);
			}
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x000927D0 File Offset: 0x000909D0
		private void EnsureCapacity(int capacity)
		{
			if (capacity > 65536)
			{
				throw new ArgumentOutOfRangeException("capacity", SR.ArgumentOutOfRange_Capacity);
			}
			if ((ulong)(capacity * 2) <= this._buffer.ByteLength)
			{
				return;
			}
			SecureString.UnmanagedBuffer buffer = this._buffer;
			SecureString.UnmanagedBuffer unmanagedBuffer = SecureString.UnmanagedBuffer.Allocate(SecureString.GetAlignedByteSize(capacity));
			SecureString.UnmanagedBuffer.Copy(buffer, unmanagedBuffer, (ulong)(this._decryptedLength * 2));
			this._buffer = unmanagedBuffer;
			buffer.Dispose();
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00092838 File Offset: 0x00090A38
		public unsafe void AppendChar(char c)
		{
			object methodLock = this._methodLock;
			lock (methodLock)
			{
				this.EnsureNotDisposed();
				this.EnsureNotReadOnly();
				SafeBuffer safeBuffer = null;
				try
				{
					this.UnprotectMemory();
					this.EnsureCapacity(this._decryptedLength + 1);
					*this.AcquireSpan(ref safeBuffer)[this._decryptedLength] = c;
					this._decryptedLength++;
				}
				finally
				{
					this.ProtectMemory();
					if (safeBuffer != null)
					{
						safeBuffer.DangerousRelease();
					}
				}
			}
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x000928D8 File Offset: 0x00090AD8
		public void Clear()
		{
			object methodLock = this._methodLock;
			lock (methodLock)
			{
				this.EnsureNotDisposed();
				this.EnsureNotReadOnly();
				this._decryptedLength = 0;
				SafeBuffer safeBuffer = null;
				try
				{
					this.AcquireSpan(ref safeBuffer).Clear();
				}
				finally
				{
					if (safeBuffer != null)
					{
						safeBuffer.DangerousRelease();
					}
				}
			}
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00092950 File Offset: 0x00090B50
		[NullableContext(1)]
		public SecureString Copy()
		{
			object methodLock = this._methodLock;
			SecureString result;
			lock (methodLock)
			{
				this.EnsureNotDisposed();
				result = new SecureString(this);
			}
			return result;
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00092998 File Offset: 0x00090B98
		public void Dispose()
		{
			object methodLock = this._methodLock;
			lock (methodLock)
			{
				if (this._buffer != null)
				{
					this._buffer.Dispose();
					this._buffer = null;
				}
			}
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000929EC File Offset: 0x00090BEC
		public unsafe void InsertAt(int index, char c)
		{
			object methodLock = this._methodLock;
			lock (methodLock)
			{
				if (index < 0 || index > this._decryptedLength)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexString);
				}
				this.EnsureNotDisposed();
				this.EnsureNotReadOnly();
				SafeBuffer safeBuffer = null;
				try
				{
					this.UnprotectMemory();
					this.EnsureCapacity(this._decryptedLength + 1);
					Span<char> span = this.AcquireSpan(ref safeBuffer);
					span.Slice(index, this._decryptedLength - index).CopyTo(span.Slice(index + 1));
					*span[index] = c;
					this._decryptedLength++;
				}
				finally
				{
					this.ProtectMemory();
					if (safeBuffer != null)
					{
						safeBuffer.DangerousRelease();
					}
				}
			}
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00092AC8 File Offset: 0x00090CC8
		public bool IsReadOnly()
		{
			this.EnsureNotDisposed();
			return Volatile.Read(ref this._readOnly);
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00092ADB File Offset: 0x00090CDB
		public void MakeReadOnly()
		{
			this.EnsureNotDisposed();
			Volatile.Write(ref this._readOnly, true);
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x00092AF0 File Offset: 0x00090CF0
		public void RemoveAt(int index)
		{
			object methodLock = this._methodLock;
			lock (methodLock)
			{
				if (index < 0 || index >= this._decryptedLength)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexString);
				}
				this.EnsureNotDisposed();
				this.EnsureNotReadOnly();
				SafeBuffer safeBuffer = null;
				try
				{
					this.UnprotectMemory();
					Span<char> span = this.AcquireSpan(ref safeBuffer);
					span.Slice(index + 1, this._decryptedLength - (index + 1)).CopyTo(span.Slice(index));
					this._decryptedLength--;
				}
				finally
				{
					this.ProtectMemory();
					if (safeBuffer != null)
					{
						safeBuffer.DangerousRelease();
					}
				}
			}
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00092BB4 File Offset: 0x00090DB4
		public unsafe void SetAt(int index, char c)
		{
			object methodLock = this._methodLock;
			lock (methodLock)
			{
				if (index < 0 || index >= this._decryptedLength)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexString);
				}
				this.EnsureNotDisposed();
				this.EnsureNotReadOnly();
				SafeBuffer safeBuffer = null;
				try
				{
					this.UnprotectMemory();
					*this.AcquireSpan(ref safeBuffer)[index] = c;
				}
				finally
				{
					this.ProtectMemory();
					if (safeBuffer != null)
					{
						safeBuffer.DangerousRelease();
					}
				}
			}
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x00092C50 File Offset: 0x00090E50
		private Span<char> AcquireSpan(ref SafeBuffer bufferToRelease)
		{
			SafeBuffer buffer = this._buffer;
			bool flag = false;
			buffer.DangerousAddRef(ref flag);
			bufferToRelease = buffer;
			return new Span<char>(buffer.DangerousGetHandle(), (int)(buffer.ByteLength / 2UL));
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x00092C86 File Offset: 0x00090E86
		private void EnsureNotReadOnly()
		{
			if (this._readOnly)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
			}
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x00092C9B File Offset: 0x00090E9B
		private void EnsureNotDisposed()
		{
			ObjectDisposedException.ThrowIf(this._buffer == null, this);
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x00092CAC File Offset: 0x00090EAC
		internal IntPtr MarshalToBSTR()
		{
			object methodLock = this._methodLock;
			IntPtr result;
			lock (methodLock)
			{
				this.EnsureNotDisposed();
				this.UnprotectMemory();
				SafeBuffer safeBuffer = null;
				IntPtr intPtr = IntPtr.Zero;
				int length = 0;
				try
				{
					Span<char> span = this.AcquireSpan(ref safeBuffer);
					length = this._decryptedLength;
					intPtr = Marshal.AllocBSTR(length);
					span.Slice(0, length).CopyTo(new Span<char>(intPtr, length));
					IntPtr intPtr2 = intPtr;
					intPtr = IntPtr.Zero;
					result = intPtr2;
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						new Span<char>(intPtr, length).Clear();
						Marshal.FreeBSTR(intPtr);
					}
					this.ProtectMemory();
					if (safeBuffer != null)
					{
						safeBuffer.DangerousRelease();
					}
				}
			}
			return result;
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00092D78 File Offset: 0x00090F78
		internal unsafe IntPtr MarshalToString(bool globalAlloc, bool unicode)
		{
			object methodLock = this._methodLock;
			IntPtr result;
			lock (methodLock)
			{
				this.EnsureNotDisposed();
				this.UnprotectMemory();
				SafeBuffer safeBuffer = null;
				IntPtr intPtr = IntPtr.Zero;
				int num = 0;
				try
				{
					Span<char> span = this.AcquireSpan(ref safeBuffer).Slice(0, this._decryptedLength);
					if (unicode)
					{
						num = (span.Length + 1) * 2;
					}
					else
					{
						num = Marshal.GetAnsiStringByteCount(span);
					}
					if (globalAlloc)
					{
						intPtr = Marshal.AllocHGlobal(num);
					}
					else
					{
						intPtr = Marshal.AllocCoTaskMem(num);
					}
					if (unicode)
					{
						Span<char> destination = new Span<char>(intPtr, num / 2);
						span.CopyTo(destination);
						*destination[destination.Length - 1] = '\0';
					}
					else
					{
						Marshal.GetAnsiStringBytes(span, new Span<byte>(intPtr, num));
					}
					IntPtr intPtr2 = intPtr;
					intPtr = IntPtr.Zero;
					result = intPtr2;
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						new Span<byte>(intPtr, num).Clear();
						if (globalAlloc)
						{
							Marshal.FreeHGlobal(intPtr);
						}
						else
						{
							Marshal.FreeCoTaskMem(intPtr);
						}
					}
					this.ProtectMemory();
					if (safeBuffer != null)
					{
						safeBuffer.DangerousRelease();
					}
				}
			}
			return result;
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00092EA8 File Offset: 0x000910A8
		private static int GetAlignedByteSize(int length)
		{
			return (Math.Max(length, 1) * 2 + 15) / 16 * 16;
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00092EBC File Offset: 0x000910BC
		private void ProtectMemory()
		{
			if (this._decryptedLength != 0 && !this._encrypted && !Interop.Crypt32.CryptProtectMemory(this._buffer, (uint)this._buffer.ByteLength, 0U))
			{
				throw new CryptographicException(Marshal.GetLastPInvokeError());
			}
			this._encrypted = true;
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x00092EFA File Offset: 0x000910FA
		private void UnprotectMemory()
		{
			if (this._decryptedLength != 0 && this._encrypted && !Interop.Crypt32.CryptUnprotectMemory(this._buffer, (uint)this._buffer.ByteLength, 0U))
			{
				throw new CryptographicException(Marshal.GetLastPInvokeError());
			}
			this._encrypted = false;
		}

		// Token: 0x04000812 RID: 2066
		private readonly object _methodLock = new object();

		// Token: 0x04000813 RID: 2067
		private SecureString.UnmanagedBuffer _buffer;

		// Token: 0x04000814 RID: 2068
		private int _decryptedLength;

		// Token: 0x04000815 RID: 2069
		private bool _encrypted;

		// Token: 0x04000816 RID: 2070
		private bool _readOnly;

		// Token: 0x0200025E RID: 606
		private sealed class UnmanagedBuffer : SafeBuffer
		{
			// Token: 0x06002D96 RID: 11670 RVA: 0x00092F38 File Offset: 0x00091138
			private UnmanagedBuffer() : base(true)
			{
			}

			// Token: 0x06002D97 RID: 11671 RVA: 0x00092F41 File Offset: 0x00091141
			public static SecureString.UnmanagedBuffer Allocate(int byteLength)
			{
				SecureString.UnmanagedBuffer unmanagedBuffer = new SecureString.UnmanagedBuffer();
				unmanagedBuffer.SetHandle(Marshal.AllocHGlobal(byteLength));
				unmanagedBuffer.Initialize((ulong)((long)byteLength));
				unmanagedBuffer._byteLength = byteLength;
				return unmanagedBuffer;
			}

			// Token: 0x06002D98 RID: 11672 RVA: 0x00092F64 File Offset: 0x00091164
			internal unsafe static void Copy(SecureString.UnmanagedBuffer source, SecureString.UnmanagedBuffer destination, ulong bytesLength)
			{
				if (bytesLength == 0UL)
				{
					return;
				}
				byte* ptr = null;
				byte* ptr2 = null;
				try
				{
					source.AcquirePointer(ref ptr);
					destination.AcquirePointer(ref ptr2);
					Buffer.MemoryCopy((void*)ptr, (void*)ptr2, destination.ByteLength, bytesLength);
				}
				finally
				{
					if (ptr2 != null)
					{
						destination.ReleasePointer();
					}
					if (ptr != null)
					{
						source.ReleasePointer();
					}
				}
			}

			// Token: 0x06002D99 RID: 11673 RVA: 0x00092FC4 File Offset: 0x000911C4
			protected override bool ReleaseHandle()
			{
				new Span<byte>(this.handle, this._byteLength).Clear();
				Marshal.FreeHGlobal(this.handle);
				return true;
			}

			// Token: 0x04000817 RID: 2071
			private int _byteLength;
		}
	}
}

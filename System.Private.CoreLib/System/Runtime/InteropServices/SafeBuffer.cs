using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005F0 RID: 1520
	public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600717B RID: 29051 RVA: 0x00110292 File Offset: 0x0010E492
		protected SafeBuffer(bool ownsHandle) : base(ownsHandle)
		{
			this._numBytes = SafeBuffer.Uninitialized;
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x000774B3 File Offset: 0x000756B3
		private static UIntPtr Uninitialized
		{
			get
			{
				return UIntPtr.MaxValue;
			}
		}

		// Token: 0x0600717D RID: 29053 RVA: 0x001102A6 File Offset: 0x0010E4A6
		[CLSCompliant(false)]
		public void Initialize(ulong numBytes)
		{
			if (8 == 4)
			{
			}
			if (numBytes >= (ulong)SafeBuffer.Uninitialized)
			{
				throw new ArgumentOutOfRangeException("numBytes", SR.ArgumentOutOfRange_UIntPtrMax);
			}
			this._numBytes = (UIntPtr)numBytes;
		}

		// Token: 0x0600717E RID: 29054 RVA: 0x001102D1 File Offset: 0x0010E4D1
		[CLSCompliant(false)]
		public void Initialize(uint numElements, uint sizeOfEachElement)
		{
			this.Initialize((ulong)numElements * (ulong)sizeOfEachElement);
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x001102DE File Offset: 0x0010E4DE
		[CLSCompliant(false)]
		public void Initialize<T>(uint numElements) where T : struct
		{
			this.Initialize(numElements, SafeBuffer.AlignedSizeOf<T>());
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x001102EC File Offset: 0x0010E4EC
		[CLSCompliant(false)]
		public unsafe void AcquirePointer(ref byte* pointer)
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			pointer = (IntPtr)((UIntPtr)0);
			bool flag = false;
			base.DangerousAddRef(ref flag);
			pointer = this.handle;
		}

		// Token: 0x06007181 RID: 29057 RVA: 0x00110322 File Offset: 0x0010E522
		public void ReleasePointer()
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			base.DangerousRelease();
		}

		// Token: 0x06007182 RID: 29058 RVA: 0x00110340 File Offset: 0x0010E540
		[CLSCompliant(false)]
		public unsafe T Read<T>(ulong byteOffset) where T : struct
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			uint num = SafeBuffer.SizeOf<T>();
			byte* ptr = this.handle + byteOffset;
			this.SpaceCheck(ptr, (UIntPtr)num);
			T result = default(T);
			bool flag = false;
			try
			{
				base.DangerousAddRef(ref flag);
				SpanHelpers.Memmove(Unsafe.As<T, byte>(ref result), ref *ptr, (UIntPtr)num);
			}
			finally
			{
				if (flag)
				{
					base.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x001103B8 File Offset: 0x0010E5B8
		[CLSCompliant(false)]
		public void ReadArray<T>(ulong byteOffset, [Nullable(new byte[]
		{
			1,
			0
		})] T[] array, int index, int count) where T : struct
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (array.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			this.ReadSpan<T>(byteOffset, new Span<T>(array, index, count));
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x0011040C File Offset: 0x0010E60C
		[CLSCompliant(false)]
		public unsafe void ReadSpan<T>(ulong byteOffset, Span<T> buffer) where T : struct
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			uint num = SafeBuffer.AlignedSizeOf<T>();
			byte* ptr = this.handle + byteOffset;
			this.SpaceCheck(ptr, checked((UIntPtr)(unchecked((ulong)num) * (ulong)(unchecked((long)buffer.Length)))));
			bool flag = false;
			try
			{
				base.DangerousAddRef(ref flag);
				ref T reference = ref MemoryMarshal.GetReference<T>(buffer);
				for (int i = 0; i < buffer.Length; i++)
				{
					Buffer.Memmove<T>(Unsafe.Add<T>(ref reference, i), Unsafe.AsRef<T>((void*)(ptr + (ulong)num * (ulong)((long)i))), (UIntPtr)((IntPtr)1));
				}
			}
			finally
			{
				if (flag)
				{
					base.DangerousRelease();
				}
			}
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x001104B0 File Offset: 0x0010E6B0
		[CLSCompliant(false)]
		public unsafe void Write<T>(ulong byteOffset, T value) where T : struct
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			uint num = SafeBuffer.SizeOf<T>();
			byte* ptr = this.handle + byteOffset;
			this.SpaceCheck(ptr, (UIntPtr)num);
			bool flag = false;
			try
			{
				base.DangerousAddRef(ref flag);
				SpanHelpers.Memmove(ref *ptr, Unsafe.As<T, byte>(ref value), (UIntPtr)num);
			}
			finally
			{
				if (flag)
				{
					base.DangerousRelease();
				}
			}
		}

		// Token: 0x06007186 RID: 29062 RVA: 0x00110520 File Offset: 0x0010E720
		[CLSCompliant(false)]
		public void WriteArray<T>(ulong byteOffset, [Nullable(new byte[]
		{
			1,
			0
		})] T[] array, int index, int count) where T : struct
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (array.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			this.WriteSpan<T>(byteOffset, new ReadOnlySpan<T>(array, index, count));
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x00110574 File Offset: 0x0010E774
		[CLSCompliant(false)]
		public unsafe void WriteSpan<T>(ulong byteOffset, ReadOnlySpan<T> data) where T : struct
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			uint num = SafeBuffer.AlignedSizeOf<T>();
			byte* ptr = this.handle + byteOffset;
			this.SpaceCheck(ptr, checked((UIntPtr)(unchecked((ulong)num) * (ulong)(unchecked((long)data.Length)))));
			bool flag = false;
			try
			{
				base.DangerousAddRef(ref flag);
				ref T reference = ref MemoryMarshal.GetReference<T>(data);
				for (int i = 0; i < data.Length; i++)
				{
					Buffer.Memmove<T>(Unsafe.AsRef<T>((void*)(ptr + (ulong)num * (ulong)((long)i))), Unsafe.Add<T>(ref reference, i), (UIntPtr)((IntPtr)1));
				}
			}
			finally
			{
				if (flag)
				{
					base.DangerousRelease();
				}
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06007188 RID: 29064 RVA: 0x00110618 File Offset: 0x0010E818
		[CLSCompliant(false)]
		public ulong ByteLength
		{
			get
			{
				if (this._numBytes == SafeBuffer.Uninitialized)
				{
					throw SafeBuffer.NotInitialized();
				}
				return (ulong)this._numBytes;
			}
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x00110634 File Offset: 0x0010E834
		private unsafe void SpaceCheck(byte* ptr, UIntPtr sizeInBytes)
		{
			if (this._numBytes < sizeInBytes)
			{
				SafeBuffer.NotEnoughRoom();
			}
			if ((ptr - this.handle) / 1 != this._numBytes - sizeInBytes)
			{
				SafeBuffer.NotEnoughRoom();
			}
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x0011065F File Offset: 0x0010E85F
		private static void NotEnoughRoom()
		{
			throw new ArgumentException(SR.Arg_BufferTooSmall);
		}

		// Token: 0x0600718B RID: 29067 RVA: 0x0011066B File Offset: 0x0010E86B
		private static InvalidOperationException NotInitialized()
		{
			return new InvalidOperationException(SR.InvalidOperation_MustCallInitialize);
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x00110678 File Offset: 0x0010E878
		internal static uint AlignedSizeOf<T>() where T : struct
		{
			uint num = SafeBuffer.SizeOf<T>();
			if (num == 1U || num == 2U)
			{
				return num;
			}
			return (uint)((ulong)(num + 3U) & 18446744073709551612UL);
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x0011069E File Offset: 0x0010E89E
		internal static uint SizeOf<T>() where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				throw new ArgumentException(SR.Argument_NeedStructWithNoRefs);
			}
			return (uint)sizeof(T);
		}

		// Token: 0x040012CC RID: 4812
		private UIntPtr _numBytes;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.IO
{
	// Token: 0x0200084C RID: 2124
	public class UnmanagedMemoryAccessor : IDisposable
	{
		// Token: 0x06008700 RID: 34560 RVA: 0x00005ACC File Offset: 0x00003CCC
		protected UnmanagedMemoryAccessor()
		{
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x00145CBB File Offset: 0x00143EBB
		[NullableContext(1)]
		public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity)
		{
			this.Initialize(buffer, offset, capacity, FileAccess.Read);
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x00145CCD File Offset: 0x00143ECD
		[NullableContext(1)]
		public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity, FileAccess access)
		{
			this.Initialize(buffer, offset, capacity, access);
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x00145CE0 File Offset: 0x00143EE0
		[NullableContext(1)]
		protected unsafe void Initialize(SafeBuffer buffer, long offset, long capacity, FileAccess access)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<long>(offset, "offset");
			ArgumentOutOfRangeException.ThrowIfNegative<long>(capacity, "capacity");
			if (buffer.ByteLength < (ulong)(offset + capacity))
			{
				throw new ArgumentException(SR.Argument_OffsetAndCapacityOutOfBounds);
			}
			if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				throw new ArgumentOutOfRangeException("access");
			}
			if (this._isOpen)
			{
				throw new InvalidOperationException(SR.InvalidOperation_CalledTwice);
			}
			byte* ptr = null;
			try
			{
				buffer.AcquirePointer(ref ptr);
				if (ptr + offset + capacity < ptr)
				{
					throw new ArgumentException(SR.Argument_UnmanagedMemAccessorWrapAround);
				}
			}
			finally
			{
				if (ptr != null)
				{
					buffer.ReleasePointer();
				}
			}
			this._offset = offset;
			this._buffer = buffer;
			this._capacity = capacity;
			this._access = access;
			this._isOpen = true;
			this._canRead = ((this._access & FileAccess.Read) > (FileAccess)0);
			this._canWrite = ((this._access & FileAccess.Write) > (FileAccess)0);
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06008704 RID: 34564 RVA: 0x00145DD0 File Offset: 0x00143FD0
		public long Capacity
		{
			get
			{
				return this._capacity;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06008705 RID: 34565 RVA: 0x00145DD8 File Offset: 0x00143FD8
		public bool CanRead
		{
			get
			{
				return this._isOpen && this._canRead;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06008706 RID: 34566 RVA: 0x00145DEA File Offset: 0x00143FEA
		public bool CanWrite
		{
			get
			{
				return this._isOpen && this._canWrite;
			}
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x00145DFC File Offset: 0x00143FFC
		protected virtual void Dispose(bool disposing)
		{
			this._isOpen = false;
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x00145E05 File Offset: 0x00144005
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06008709 RID: 34569 RVA: 0x00145E14 File Offset: 0x00144014
		protected bool IsOpen
		{
			get
			{
				return this._isOpen;
			}
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x00145E1C File Offset: 0x0014401C
		public bool ReadBoolean(long position)
		{
			return this.ReadByte(position) > 0;
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x00145E28 File Offset: 0x00144028
		public unsafe byte ReadByte(long position)
		{
			this.EnsureSafeToRead(position, 1);
			byte* ptr = null;
			byte result;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				result = (ptr + this._offset)[position];
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			return result;
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x00145E80 File Offset: 0x00144080
		public char ReadChar(long position)
		{
			return (char)this.ReadInt16(position);
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x00145E8C File Offset: 0x0014408C
		public unsafe short ReadInt16(long position)
		{
			this.EnsureSafeToRead(position, 2);
			byte* ptr = null;
			short result;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				result = Unsafe.ReadUnaligned<short>((void*)(ptr + this._offset + position));
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			return result;
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x00145EE8 File Offset: 0x001440E8
		public unsafe int ReadInt32(long position)
		{
			this.EnsureSafeToRead(position, 4);
			byte* ptr = null;
			int result;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				result = Unsafe.ReadUnaligned<int>((void*)(ptr + this._offset + position));
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			return result;
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x00145F44 File Offset: 0x00144144
		public unsafe long ReadInt64(long position)
		{
			this.EnsureSafeToRead(position, 8);
			byte* ptr = null;
			long result;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				result = Unsafe.ReadUnaligned<long>((void*)(ptr + this._offset + position));
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			return result;
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x00145FA0 File Offset: 0x001441A0
		public unsafe decimal ReadDecimal(long position)
		{
			this.EnsureSafeToRead(position, 16);
			byte* ptr = null;
			int lo;
			int mid;
			int hi;
			int num;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				ptr += this._offset + position;
				lo = Unsafe.ReadUnaligned<int>((void*)ptr);
				mid = Unsafe.ReadUnaligned<int>((void*)(ptr + 4));
				hi = Unsafe.ReadUnaligned<int>((void*)(ptr + 8));
				num = Unsafe.ReadUnaligned<int>((void*)(ptr + 12));
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			if ((num & 2130771967) != 0 || (num & 16711680) > 1835008)
			{
				throw new ArgumentException(SR.Arg_BadDecimal);
			}
			bool isNegative = (num & int.MinValue) != 0;
			byte scale = (byte)(num >> 16);
			return new decimal(lo, mid, hi, isNegative, scale);
		}

		// Token: 0x06008711 RID: 34577 RVA: 0x00146064 File Offset: 0x00144264
		public float ReadSingle(long position)
		{
			return BitConverter.Int32BitsToSingle(this.ReadInt32(position));
		}

		// Token: 0x06008712 RID: 34578 RVA: 0x00146072 File Offset: 0x00144272
		public double ReadDouble(long position)
		{
			return BitConverter.Int64BitsToDouble(this.ReadInt64(position));
		}

		// Token: 0x06008713 RID: 34579 RVA: 0x00146080 File Offset: 0x00144280
		[CLSCompliant(false)]
		public sbyte ReadSByte(long position)
		{
			return (sbyte)this.ReadByte(position);
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x00145E80 File Offset: 0x00144080
		[CLSCompliant(false)]
		public ushort ReadUInt16(long position)
		{
			return (ushort)this.ReadInt16(position);
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x0014608A File Offset: 0x0014428A
		[CLSCompliant(false)]
		public uint ReadUInt32(long position)
		{
			return (uint)this.ReadInt32(position);
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x00146093 File Offset: 0x00144293
		[CLSCompliant(false)]
		public ulong ReadUInt64(long position)
		{
			return (ulong)this.ReadInt64(position);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x0014609C File Offset: 0x0014429C
		public void Read<T>(long position, out T structure) where T : struct
		{
			ArgumentOutOfRangeException.ThrowIfNegative<long>(position, "position");
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", SR.ObjectDisposed_ViewAccessorClosed);
			}
			if (!this._canRead)
			{
				throw new NotSupportedException(SR.NotSupported_Reading);
			}
			uint num = SafeBuffer.SizeOf<T>();
			if (position <= this._capacity - (long)((ulong)num))
			{
				structure = this._buffer.Read<T>((ulong)(this._offset + position));
				return;
			}
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", SR.ArgumentOutOfRange_PositionLessThanCapacityRequired);
			}
			throw new ArgumentException(SR.Argument_NotEnoughBytesToRead, "position");
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x00146134 File Offset: 0x00144334
		public int ReadArray<T>(long position, [Nullable(new byte[]
		{
			1,
			0
		})] T[] array, int offset, int count) where T : struct
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offset, "offset");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (array.Length - offset < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", SR.ObjectDisposed_ViewAccessorClosed);
			}
			if (!this._canRead)
			{
				throw new NotSupportedException(SR.NotSupported_Reading);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<long>(position, "position");
			uint num = SafeBuffer.AlignedSizeOf<T>();
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", SR.ArgumentOutOfRange_PositionLessThanCapacityRequired);
			}
			int num2 = count;
			long num3 = this._capacity - position;
			if (num3 < 0L)
			{
				num2 = 0;
			}
			else
			{
				ulong num4 = (ulong)num * (ulong)((long)count);
				if (num3 < (long)num4)
				{
					num2 = (int)(num3 / (long)((ulong)num));
				}
			}
			this._buffer.ReadArray<T>((ulong)(this._offset + position), array, offset, num2);
			return num2;
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x00146209 File Offset: 0x00144409
		public void Write(long position, bool value)
		{
			this.Write(position, (value > false) ? 1 : 0);
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x00146218 File Offset: 0x00144418
		public unsafe void Write(long position, byte value)
		{
			this.EnsureSafeToWrite(position, 1);
			byte* ptr = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				(ptr + this._offset)[position] = value;
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x00146270 File Offset: 0x00144470
		public void Write(long position, char value)
		{
			this.Write(position, (short)value);
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x0014627C File Offset: 0x0014447C
		public unsafe void Write(long position, short value)
		{
			this.EnsureSafeToWrite(position, 2);
			byte* ptr = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				Unsafe.WriteUnaligned<short>((void*)(ptr + this._offset + position), value);
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		// Token: 0x0600871D RID: 34589 RVA: 0x001462D8 File Offset: 0x001444D8
		public unsafe void Write(long position, int value)
		{
			this.EnsureSafeToWrite(position, 4);
			byte* ptr = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				Unsafe.WriteUnaligned<int>((void*)(ptr + this._offset + position), value);
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x00146334 File Offset: 0x00144534
		public unsafe void Write(long position, long value)
		{
			this.EnsureSafeToWrite(position, 8);
			byte* ptr = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				Unsafe.WriteUnaligned<long>((void*)(ptr + this._offset + position), value);
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x00146390 File Offset: 0x00144590
		public unsafe void Write(long position, decimal value)
		{
			this.EnsureSafeToWrite(position, 16);
			Span<int> destination = new Span<int>(stackalloc byte[(UIntPtr)16], 4);
			int num;
			decimal.TryGetBits(value, destination, out num);
			byte* ptr = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				ptr += this._offset + position;
				Unsafe.WriteUnaligned<int>((void*)ptr, *destination[0]);
				Unsafe.WriteUnaligned<int>((void*)(ptr + 4), *destination[1]);
				Unsafe.WriteUnaligned<int>((void*)(ptr + 8), *destination[2]);
				Unsafe.WriteUnaligned<int>((void*)(ptr + 12), *destination[3]);
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x00146440 File Offset: 0x00144640
		public void Write(long position, float value)
		{
			this.Write(position, BitConverter.SingleToInt32Bits(value));
		}

		// Token: 0x06008721 RID: 34593 RVA: 0x0014644F File Offset: 0x0014464F
		public void Write(long position, double value)
		{
			this.Write(position, BitConverter.DoubleToInt64Bits(value));
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x0014645E File Offset: 0x0014465E
		[CLSCompliant(false)]
		public void Write(long position, sbyte value)
		{
			this.Write(position, (byte)value);
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x00146270 File Offset: 0x00144470
		[CLSCompliant(false)]
		public void Write(long position, ushort value)
		{
			this.Write(position, (short)value);
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x00146469 File Offset: 0x00144669
		[CLSCompliant(false)]
		public void Write(long position, uint value)
		{
			this.Write(position, (int)value);
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x00146473 File Offset: 0x00144673
		[CLSCompliant(false)]
		public void Write(long position, ulong value)
		{
			this.Write(position, (long)value);
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x00146480 File Offset: 0x00144680
		public void Write<T>(long position, ref T structure) where T : struct
		{
			ArgumentOutOfRangeException.ThrowIfNegative<long>(position, "position");
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", SR.ObjectDisposed_ViewAccessorClosed);
			}
			if (!this._canWrite)
			{
				throw new NotSupportedException(SR.NotSupported_Writing);
			}
			uint num = SafeBuffer.SizeOf<T>();
			if (position <= this._capacity - (long)((ulong)num))
			{
				this._buffer.Write<T>((ulong)(this._offset + position), structure);
				return;
			}
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", SR.ArgumentOutOfRange_PositionLessThanCapacityRequired);
			}
			throw new ArgumentException(SR.Argument_NotEnoughBytesToWrite, "position");
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x00146518 File Offset: 0x00144718
		public void WriteArray<T>(long position, [Nullable(new byte[]
		{
			1,
			0
		})] T[] array, int offset, int count) where T : struct
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offset, "offset");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (array.Length - offset < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<long>(position, "position");
			if (position >= this.Capacity)
			{
				throw new ArgumentOutOfRangeException("position", SR.ArgumentOutOfRange_PositionLessThanCapacityRequired);
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", SR.ObjectDisposed_ViewAccessorClosed);
			}
			if (!this._canWrite)
			{
				throw new NotSupportedException(SR.NotSupported_Writing);
			}
			this._buffer.WriteArray<T>((ulong)(this._offset + position), array, offset, count);
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x001465C4 File Offset: 0x001447C4
		private void EnsureSafeToRead(long position, int sizeOfType)
		{
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", SR.ObjectDisposed_ViewAccessorClosed);
			}
			if (!this._canRead)
			{
				throw new NotSupportedException(SR.NotSupported_Reading);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<long>(position, "position");
			if (position <= this._capacity - (long)sizeOfType)
			{
				return;
			}
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", SR.ArgumentOutOfRange_PositionLessThanCapacityRequired);
			}
			throw new ArgumentException(SR.Argument_NotEnoughBytesToRead, "position");
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x0014663C File Offset: 0x0014483C
		private void EnsureSafeToWrite(long position, int sizeOfType)
		{
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", SR.ObjectDisposed_ViewAccessorClosed);
			}
			if (!this._canWrite)
			{
				throw new NotSupportedException(SR.NotSupported_Writing);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<long>(position, "position");
			if (position <= this._capacity - (long)sizeOfType)
			{
				return;
			}
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", SR.ArgumentOutOfRange_PositionLessThanCapacityRequired);
			}
			throw new ArgumentException(SR.Argument_NotEnoughBytesToWrite, "position");
		}

		// Token: 0x04001D63 RID: 7523
		private SafeBuffer _buffer;

		// Token: 0x04001D64 RID: 7524
		private long _offset;

		// Token: 0x04001D65 RID: 7525
		private long _capacity;

		// Token: 0x04001D66 RID: 7526
		private FileAccess _access;

		// Token: 0x04001D67 RID: 7527
		private bool _isOpen;

		// Token: 0x04001D68 RID: 7528
		private bool _canRead;

		// Token: 0x04001D69 RID: 7529
		private bool _canWrite;
	}
}

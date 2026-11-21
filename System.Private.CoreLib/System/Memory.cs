using System;
using System.Buffers;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000167 RID: 359
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(MemoryDebugView<>))]
	[DebuggerDisplay("{ToString(),raw}")]
	public readonly struct Memory<[Nullable(2)] T> : IEquatable<Memory<T>>
	{
		// Token: 0x0600175C RID: 5980 RVA: 0x00046A04 File Offset: 0x00044C04
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Memory([Nullable(new byte[]
		{
			2,
			1
		})] T[] array)
		{
			if (array == null)
			{
				this = default(Memory<T>);
				return;
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			this._object = array;
			this._index = 0;
			this._length = array.Length;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00046A60 File Offset: 0x00044C60
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Memory(T[] array, int start)
		{
			if (array == null)
			{
				if (start != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				this = default(Memory<T>);
				return;
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			if (start > array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._object = array;
			this._index = start;
			this._length = array.Length - start;
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00046AD4 File Offset: 0x00044CD4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Memory([Nullable(new byte[]
		{
			2,
			1
		})] T[] array, int start, int length)
		{
			if (array == null)
			{
				if (start != 0 || length != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				this = default(Memory<T>);
				return;
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			if ((ulong)start + (ulong)length > (ulong)array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._object = array;
			this._index = start;
			this._length = length;
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00046B49 File Offset: 0x00044D49
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Memory(MemoryManager<T> manager, int length)
		{
			if (length < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._object = manager;
			this._index = 0;
			this._length = length;
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00046B69 File Offset: 0x00044D69
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Memory(MemoryManager<T> manager, int start, int length)
		{
			if (length < 0 || start < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._object = manager;
			this._index = start;
			this._length = length;
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00046B8D File Offset: 0x00044D8D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Memory(object obj, int start, int length)
		{
			this._object = obj;
			this._index = start;
			this._length = length;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00046BA4 File Offset: 0x00044DA4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator Memory<T>([Nullable(new byte[]
		{
			2,
			1
		})] T[] array)
		{
			return new Memory<T>(array);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00046BAC File Offset: 0x00044DAC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator Memory<T>([Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> segment)
		{
			return new Memory<T>(segment.Array, segment.Offset, segment.Count);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00046BC8 File Offset: 0x00044DC8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static implicit operator ReadOnlyMemory<T>([Nullable(new byte[]
		{
			0,
			1
		})] Memory<T> memory)
		{
			return *Unsafe.As<Memory<T>, ReadOnlyMemory<T>>(ref memory);
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x00046BD8 File Offset: 0x00044DD8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> Empty
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return default(Memory<T>);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x00046BEE File Offset: 0x00044DEE
		public int Length
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00046BF6 File Offset: 0x00044DF6
		public bool IsEmpty
		{
			get
			{
				return this._length == 0;
			}
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00046C04 File Offset: 0x00044E04
		public override string ToString()
		{
			if (!(typeof(T) == typeof(char)))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
				defaultInterpolatedStringHandler.AppendLiteral("System.Memory<");
				defaultInterpolatedStringHandler.AppendFormatted(typeof(T).Name);
				defaultInterpolatedStringHandler.AppendLiteral(">[");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this._length);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string text = this._object as string;
			if (text == null)
			{
				return this.Span.ToString();
			}
			return text.Substring(this._index, this._length);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00046CBB File Offset: 0x00044EBB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public Memory<T> Slice(int start)
		{
			if (start > this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			return new Memory<T>(this._object, this._index + start, this._length - start);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00046CE8 File Offset: 0x00044EE8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public Memory<T> Slice(int start, int length)
		{
			if ((ulong)start + (ulong)length > (ulong)this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new Memory<T>(this._object, this._index + start, length);
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x00046D14 File Offset: 0x00044F14
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public Span<T> Span
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				ref T ptr = ref Unsafe.NullRef<T>();
				int num = 0;
				object @object = this._object;
				if (@object != null)
				{
					if (typeof(T) == typeof(char) && @object.GetType() == typeof(string))
					{
						ptr = Unsafe.As<char, T>(Unsafe.As<string>(@object).GetRawStringData());
						num = Unsafe.As<string>(@object).Length;
					}
					else if (RuntimeHelpers.ObjectHasComponentSize(@object))
					{
						ptr = MemoryMarshal.GetArrayDataReference<T>(Unsafe.As<T[]>(@object));
						num = Unsafe.As<T[]>(@object).Length;
					}
					else
					{
						Span<T> span = Unsafe.As<MemoryManager<T>>(@object).GetSpan();
						ptr = MemoryMarshal.GetReference<T>(span);
						num = span.Length;
					}
					UIntPtr uintPtr = (UIntPtr)(this._index & int.MaxValue);
					int length = this._length;
					if ((ulong)uintPtr + (ulong)length > (ulong)num)
					{
						ThrowHelper.ThrowArgumentOutOfRangeException();
					}
					ptr = Unsafe.Add<T>(ref ptr, (IntPtr)uintPtr);
					num = length;
				}
				return new Span<T>(ref ptr, num);
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00046DFC File Offset: 0x00044FFC
		public void CopyTo([Nullable(new byte[]
		{
			0,
			1
		})] Memory<T> destination)
		{
			this.Span.CopyTo(destination.Span);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00046E20 File Offset: 0x00045020
		public bool TryCopyTo([Nullable(new byte[]
		{
			0,
			1
		})] Memory<T> destination)
		{
			return this.Span.TryCopyTo(destination.Span);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00046E44 File Offset: 0x00045044
		public MemoryHandle Pin()
		{
			object @object = this._object;
			if (@object == null)
			{
				return default(MemoryHandle);
			}
			if (typeof(T) == typeof(char))
			{
				string text = @object as string;
				if (text != null)
				{
					GCHandle handle = GCHandle.Alloc(@object, GCHandleType.Pinned);
					return new MemoryHandle(Unsafe.AsPointer<char>(Unsafe.Add<char>(text.GetRawStringData(), this._index)), handle, null);
				}
			}
			if (!RuntimeHelpers.ObjectHasComponentSize(@object))
			{
				return Unsafe.As<MemoryManager<T>>(@object).Pin(this._index);
			}
			if (this._index < 0)
			{
				return new MemoryHandle(Unsafe.Add<T>(Unsafe.AsPointer<T>(MemoryMarshal.GetArrayDataReference<T>(Unsafe.As<T[]>(@object))), this._index & int.MaxValue), default(GCHandle), null);
			}
			GCHandle handle2 = GCHandle.Alloc(@object, GCHandleType.Pinned);
			return new MemoryHandle(Unsafe.Add<T>(Unsafe.AsPointer<T>(MemoryMarshal.GetArrayDataReference<T>(Unsafe.As<T[]>(@object))), this._index), handle2, null);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00046F34 File Offset: 0x00045134
		public T[] ToArray()
		{
			return this.Span.ToArray();
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00046F50 File Offset: 0x00045150
		[NullableContext(2)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is ReadOnlyMemory<T>)
			{
				return ((ReadOnlyMemory<T>)obj).Equals(this);
			}
			if (obj is Memory<T>)
			{
				Memory<T> other = (Memory<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00046F97 File Offset: 0x00045197
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] Memory<T> other)
		{
			return this._object == other._object && this._index == other._index && this._length == other._length;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00046FC5 File Offset: 0x000451C5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			if (this._object == null)
			{
				return 0;
			}
			return HashCode.Combine<int, int, int>(RuntimeHelpers.GetHashCode(this._object), this._index, this._length);
		}

		// Token: 0x040004F3 RID: 1267
		private readonly object _object;

		// Token: 0x040004F4 RID: 1268
		private readonly int _index;

		// Token: 0x040004F5 RID: 1269
		private readonly int _length;
	}
}

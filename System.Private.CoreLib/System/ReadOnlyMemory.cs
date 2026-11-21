using System;
using System.Buffers;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x0200019C RID: 412
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(MemoryDebugView<>))]
	[DebuggerDisplay("{ToString(),raw}")]
	public readonly struct ReadOnlyMemory<[Nullable(2)] T> : IEquatable<ReadOnlyMemory<T>>
	{
		// Token: 0x06001A8D RID: 6797 RVA: 0x0005687A File Offset: 0x00054A7A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlyMemory([Nullable(new byte[]
		{
			2,
			1
		})] T[] array)
		{
			if (array == null)
			{
				this = default(ReadOnlyMemory<T>);
				return;
			}
			this._object = array;
			this._index = 0;
			this._length = array.Length;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0005689E File Offset: 0x00054A9E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlyMemory([Nullable(new byte[]
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
				this = default(ReadOnlyMemory<T>);
				return;
			}
			if ((ulong)start + (ulong)length > (ulong)array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._object = array;
			this._index = start;
			this._length = length;
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000568DB File Offset: 0x00054ADB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlyMemory(object obj, int start, int length)
		{
			this._object = obj;
			this._index = start;
			this._length = length;
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000568F2 File Offset: 0x00054AF2
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator ReadOnlyMemory<T>([Nullable(new byte[]
		{
			2,
			1
		})] T[] array)
		{
			return new ReadOnlyMemory<T>(array);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000568FA File Offset: 0x00054AFA
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator ReadOnlyMemory<T>([Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> segment)
		{
			return new ReadOnlyMemory<T>(segment.Array, segment.Offset, segment.Count);
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x00056918 File Offset: 0x00054B18
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlyMemory<T> Empty
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return default(ReadOnlyMemory<T>);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0005692E File Offset: 0x00054B2E
		public int Length
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x00056936 File Offset: 0x00054B36
		public bool IsEmpty
		{
			get
			{
				return this._length == 0;
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00056944 File Offset: 0x00054B44
		public override string ToString()
		{
			if (!(typeof(T) == typeof(char)))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
				defaultInterpolatedStringHandler.AppendLiteral("System.ReadOnlyMemory<");
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

		// Token: 0x06001A96 RID: 6806 RVA: 0x000569FB File Offset: 0x00054BFB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ReadOnlyMemory<T> Slice(int start)
		{
			if (start > this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			return new ReadOnlyMemory<T>(this._object, this._index + start, this._length - start);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00056A28 File Offset: 0x00054C28
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ReadOnlyMemory<T> Slice(int start, int length)
		{
			if ((ulong)start + (ulong)length > (ulong)this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			return new ReadOnlyMemory<T>(this._object, this._index + start, length);
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x00056A54 File Offset: 0x00054C54
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public ReadOnlySpan<T> Span
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
				return new ReadOnlySpan<T>(ref ptr, num);
			}
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00056B3C File Offset: 0x00054D3C
		public void CopyTo([Nullable(new byte[]
		{
			0,
			1
		})] Memory<T> destination)
		{
			this.Span.CopyTo(destination.Span);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00056B60 File Offset: 0x00054D60
		public bool TryCopyTo([Nullable(new byte[]
		{
			0,
			1
		})] Memory<T> destination)
		{
			return this.Span.TryCopyTo(destination.Span);
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00056B84 File Offset: 0x00054D84
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

		// Token: 0x06001A9C RID: 6812 RVA: 0x00056C74 File Offset: 0x00054E74
		public T[] ToArray()
		{
			return this.Span.ToArray();
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00056C90 File Offset: 0x00054E90
		[NullableContext(2)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is ReadOnlyMemory<T>)
			{
				ReadOnlyMemory<T> other = (ReadOnlyMemory<T>)obj;
				return this.Equals(other);
			}
			if (obj is Memory<T>)
			{
				Memory<T> memory = (Memory<T>)obj;
				return this.Equals(memory);
			}
			return false;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00056CD1 File Offset: 0x00054ED1
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlyMemory<T> other)
		{
			return this._object == other._object && this._index == other._index && this._length == other._length;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00056CFF File Offset: 0x00054EFF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			if (this._object == null)
			{
				return 0;
			}
			return HashCode.Combine<int, int, int>(RuntimeHelpers.GetHashCode(this._object), this._index, this._length);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00056D27 File Offset: 0x00054F27
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal object GetObjectStartLength(out int start, out int length)
		{
			start = this._index;
			length = this._length;
			return this._object;
		}

		// Token: 0x04000559 RID: 1369
		private readonly object _object;

		// Token: 0x0400055A RID: 1370
		private readonly int _index;

		// Token: 0x0400055B RID: 1371
		private readonly int _length;

		// Token: 0x0400055C RID: 1372
		internal const int RemoveFlagsBitMask = 2147483647;
	}
}

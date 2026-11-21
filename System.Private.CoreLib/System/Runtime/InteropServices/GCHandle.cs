using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200059E RID: 1438
	[NullableContext(2)]
	[Nullable(0)]
	public struct GCHandle : IEquatable<GCHandle>
	{
		// Token: 0x06006E87 RID: 28295
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr InternalAlloc(object value, GCHandleType type);

		// Token: 0x06006E88 RID: 28296
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalFree(IntPtr handle);

		// Token: 0x06006E89 RID: 28297
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern object InternalGet(IntPtr handle);

		// Token: 0x06006E8A RID: 28298
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalSet(IntPtr handle, object value);

		// Token: 0x06006E8B RID: 28299 RVA: 0x0010AB78 File Offset: 0x00108D78
		private GCHandle(object value, GCHandleType type)
		{
			if (type > GCHandleType.Pinned)
			{
				throw new ArgumentOutOfRangeException("type", SR.ArgumentOutOfRange_Enum);
			}
			if (type == GCHandleType.Pinned && !Marshal.IsPinnable(value))
			{
				throw new ArgumentException(SR.ArgumentException_NotIsomorphic, "value");
			}
			IntPtr intPtr = GCHandle.InternalAlloc(value, type);
			if (type == GCHandleType.Pinned)
			{
				intPtr |= (IntPtr)1;
			}
			this._handle = intPtr;
		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x0010ABCD File Offset: 0x00108DCD
		private GCHandle(IntPtr handle)
		{
			this._handle = handle;
		}

		// Token: 0x06006E8D RID: 28301 RVA: 0x0010ABD6 File Offset: 0x00108DD6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GCHandle Alloc(object value)
		{
			return new GCHandle(value, GCHandleType.Normal);
		}

		// Token: 0x06006E8E RID: 28302 RVA: 0x0010ABDF File Offset: 0x00108DDF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GCHandle Alloc(object value, GCHandleType type)
		{
			return new GCHandle(value, type);
		}

		// Token: 0x06006E8F RID: 28303 RVA: 0x0010ABE8 File Offset: 0x00108DE8
		public void Free()
		{
			IntPtr handle = Interlocked.Exchange(ref this._handle, IntPtr.Zero);
			GCHandle.ThrowIfInvalid(handle);
			GCHandle.InternalFree(GCHandle.GetHandleValue(handle));
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06006E90 RID: 28304 RVA: 0x0010AC0A File Offset: 0x00108E0A
		// (set) Token: 0x06006E91 RID: 28305 RVA: 0x0010AC22 File Offset: 0x00108E22
		public object Target
		{
			readonly get
			{
				IntPtr handle = this._handle;
				GCHandle.ThrowIfInvalid(handle);
				return GCHandle.InternalGet(GCHandle.GetHandleValue(handle));
			}
			set
			{
				IntPtr handle = this._handle;
				GCHandle.ThrowIfInvalid(handle);
				if (GCHandle.IsPinned(handle) && !Marshal.IsPinnable(value))
				{
					throw new ArgumentException(SR.ArgumentException_NotIsomorphic, "value");
				}
				GCHandle.InternalSet(GCHandle.GetHandleValue(handle), value);
			}
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x0010AC5C File Offset: 0x00108E5C
		public readonly IntPtr AddrOfPinnedObject()
		{
			IntPtr handle = this._handle;
			GCHandle.ThrowIfInvalid(handle);
			if (!GCHandle.IsPinned(handle))
			{
				ThrowHelper.ThrowInvalidOperationException_HandleIsNotPinned();
			}
			object obj = GCHandle.InternalGet(GCHandle.GetHandleValue(handle));
			if (obj == null)
			{
				return (IntPtr)0;
			}
			if (!RuntimeHelpers.ObjectHasComponentSize(obj))
			{
				return Unsafe.AsPointer<byte>(obj.GetRawData());
			}
			if (obj.GetType() == typeof(string))
			{
				return Unsafe.AsPointer<char>(Unsafe.As<string>(obj).GetRawStringData());
			}
			return Unsafe.AsPointer<byte>(MemoryMarshal.GetArrayDataReference(Unsafe.As<Array>(obj)));
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06006E93 RID: 28307 RVA: 0x0010ACDF File Offset: 0x00108EDF
		public readonly bool IsAllocated
		{
			get
			{
				return this._handle > (IntPtr)0;
			}
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x0010ACEB File Offset: 0x00108EEB
		public static explicit operator GCHandle(IntPtr value)
		{
			return GCHandle.FromIntPtr(value);
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x0010ACF3 File Offset: 0x00108EF3
		public static GCHandle FromIntPtr(IntPtr value)
		{
			GCHandle.ThrowIfInvalid(value);
			return new GCHandle(value);
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x0010AD01 File Offset: 0x00108F01
		public static explicit operator IntPtr(GCHandle value)
		{
			return GCHandle.ToIntPtr(value);
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x0010AD09 File Offset: 0x00108F09
		public static IntPtr ToIntPtr(GCHandle value)
		{
			return value._handle;
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x0010AD11 File Offset: 0x00108F11
		public override readonly int GetHashCode()
		{
			return this._handle.GetHashCode();
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x0010AD20 File Offset: 0x00108F20
		public override readonly bool Equals([NotNullWhen(true)] object o)
		{
			if (o is GCHandle)
			{
				GCHandle other = (GCHandle)o;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x0010AD45 File Offset: 0x00108F45
		public readonly bool Equals(GCHandle other)
		{
			return this._handle == other._handle;
		}

		// Token: 0x06006E9B RID: 28315 RVA: 0x0010AD45 File Offset: 0x00108F45
		public static bool operator ==(GCHandle a, GCHandle b)
		{
			return a._handle == b._handle;
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x0010AD55 File Offset: 0x00108F55
		public static bool operator !=(GCHandle a, GCHandle b)
		{
			return a._handle != b._handle;
		}

		// Token: 0x06006E9D RID: 28317 RVA: 0x0010AD68 File Offset: 0x00108F68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IntPtr GetHandleValue(IntPtr handle)
		{
			return new IntPtr((long)(handle & (IntPtr)(-2)));
		}

		// Token: 0x06006E9E RID: 28318 RVA: 0x0004515E File Offset: 0x0004335E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsPinned(IntPtr handle)
		{
			return (handle & (IntPtr)1) > (IntPtr)0;
		}

		// Token: 0x06006E9F RID: 28319 RVA: 0x0010AD75 File Offset: 0x00108F75
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void ThrowIfInvalid(IntPtr handle)
		{
			if (handle == 0)
			{
				ThrowHelper.ThrowInvalidOperationException_HandleIsNotInitialized();
			}
		}

		// Token: 0x04001210 RID: 4624
		private IntPtr _handle;
	}
}

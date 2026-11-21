using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x020003FE RID: 1022
	public class Overlapped
	{
		// Token: 0x060040CC RID: 16588 RVA: 0x00005ACC File Offset: 0x00003CCC
		public Overlapped()
		{
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x000D8083 File Offset: 0x000D6283
		[NullableContext(2)]
		public Overlapped(int offsetLo, int offsetHi, IntPtr hEvent, IAsyncResult ar)
		{
			this._offsetLow = offsetLo;
			this._offsetHigh = offsetHi;
			this._eventHandle = hEvent;
			this._asyncResult = ar;
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x000D80A8 File Offset: 0x000D62A8
		[NullableContext(2)]
		[Obsolete("This constructor is not 64-bit compatible and has been deprecated. Use the constructor that accepts an IntPtr for the event handle instead.")]
		public Overlapped(int offsetLo, int offsetHi, int hEvent, IAsyncResult ar) : this(offsetLo, offsetHi, new IntPtr(hEvent), ar)
		{
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x000D80BA File Offset: 0x000D62BA
		// (set) Token: 0x060040D0 RID: 16592 RVA: 0x000D80C2 File Offset: 0x000D62C2
		[Nullable(1)]
		public IAsyncResult AsyncResult
		{
			[NullableContext(1)]
			get
			{
				return this._asyncResult;
			}
			[NullableContext(1)]
			set
			{
				this._asyncResult = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x000D80CB File Offset: 0x000D62CB
		// (set) Token: 0x060040D2 RID: 16594 RVA: 0x000D80E9 File Offset: 0x000D62E9
		public unsafe int OffsetLow
		{
			get
			{
				if (this._pNativeOverlapped == null)
				{
					return this._offsetLow;
				}
				return this._pNativeOverlapped->OffsetLow;
			}
			set
			{
				*(ref (this._pNativeOverlapped != null) ? ref this._pNativeOverlapped->OffsetLow : ref this._offsetLow) = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x000D810A File Offset: 0x000D630A
		// (set) Token: 0x060040D4 RID: 16596 RVA: 0x000D8128 File Offset: 0x000D6328
		public unsafe int OffsetHigh
		{
			get
			{
				if (this._pNativeOverlapped == null)
				{
					return this._offsetHigh;
				}
				return this._pNativeOverlapped->OffsetHigh;
			}
			set
			{
				*(ref (this._pNativeOverlapped != null) ? ref this._pNativeOverlapped->OffsetHigh : ref this._offsetHigh) = value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x000D814C File Offset: 0x000D634C
		// (set) Token: 0x060040D6 RID: 16598 RVA: 0x000D8167 File Offset: 0x000D6367
		[Obsolete("Overlapped.EventHandle is not 64-bit compatible and has been deprecated. Use EventHandleIntPtr instead.")]
		public int EventHandle
		{
			get
			{
				return this.EventHandleIntPtr.ToInt32();
			}
			set
			{
				this.EventHandleIntPtr = new IntPtr(value);
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060040D7 RID: 16599 RVA: 0x000D8175 File Offset: 0x000D6375
		// (set) Token: 0x060040D8 RID: 16600 RVA: 0x000D8193 File Offset: 0x000D6393
		public unsafe IntPtr EventHandleIntPtr
		{
			get
			{
				if (this._pNativeOverlapped == null)
				{
					return this._eventHandle;
				}
				return this._pNativeOverlapped->EventHandle;
			}
			set
			{
				*(ref (this._pNativeOverlapped != null) ? ref this._pNativeOverlapped->EventHandle : ref this._eventHandle) = value;
			}
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x000D81B4 File Offset: 0x000D63B4
		[Obsolete("This overload is not safe and has been deprecated. Use Pack(IOCompletionCallback?, object?) instead.")]
		[CLSCompliant(false)]
		public unsafe NativeOverlapped* Pack([Nullable(2)] IOCompletionCallback iocb)
		{
			return this.Pack(iocb, null);
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x000D81C0 File Offset: 0x000D63C0
		[NullableContext(2)]
		[CLSCompliant(false)]
		[return: Nullable(0)]
		public unsafe NativeOverlapped* Pack(IOCompletionCallback iocb, object userData)
		{
			if (this._pNativeOverlapped != null)
			{
				throw new InvalidOperationException(SR.InvalidOperation_Overlapped_Pack);
			}
			if (iocb != null)
			{
				ExecutionContext executionContext = ExecutionContext.Capture();
				this._callback = ((executionContext != null && !executionContext.IsDefault) ? new IOCompletionCallbackHelper(iocb, executionContext) : iocb);
			}
			else
			{
				this._callback = null;
			}
			return this.AllocateNativeOverlapped(userData);
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x000D8216 File Offset: 0x000D6416
		[Obsolete("This overload is not safe and has been deprecated. Use UnsafePack(IOCompletionCallback?, object?) instead.")]
		[CLSCompliant(false)]
		public unsafe NativeOverlapped* UnsafePack([Nullable(2)] IOCompletionCallback iocb)
		{
			return this.UnsafePack(iocb, null);
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x000D8220 File Offset: 0x000D6420
		[NullableContext(2)]
		[CLSCompliant(false)]
		[return: Nullable(0)]
		public unsafe NativeOverlapped* UnsafePack(IOCompletionCallback iocb, object userData)
		{
			if (this._pNativeOverlapped != null)
			{
				throw new InvalidOperationException(SR.InvalidOperation_Overlapped_Pack);
			}
			this._callback = iocb;
			return this.AllocateNativeOverlapped(userData);
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x000D8245 File Offset: 0x000D6445
		[CLSCompliant(false)]
		[return: Nullable(1)]
		public unsafe static Overlapped Unpack(NativeOverlapped* nativeOverlappedPtr)
		{
			ArgumentNullException.ThrowIfNull((void*)nativeOverlappedPtr, "nativeOverlappedPtr");
			return Overlapped.GetOverlappedFromNative(nativeOverlappedPtr);
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x000D8258 File Offset: 0x000D6458
		[CLSCompliant(false)]
		public unsafe static void Free(NativeOverlapped* nativeOverlappedPtr)
		{
			ArgumentNullException.ThrowIfNull((void*)nativeOverlappedPtr, "nativeOverlappedPtr");
			Overlapped.GetOverlappedFromNative(nativeOverlappedPtr)._pNativeOverlapped = null;
			Overlapped.FreeNativeOverlapped(nativeOverlappedPtr);
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x000D8278 File Offset: 0x000D6478
		private unsafe NativeOverlapped* AllocateNativeOverlapped(object userData)
		{
			NativeOverlapped* ptr = null;
			NativeOverlapped* result;
			try
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)1);
				if (userData != null)
				{
					if (userData.GetType() == typeof(object[]))
					{
						uintPtr += (UIntPtr)((IntPtr)((object[])userData).Length);
					}
					else
					{
						uintPtr++;
					}
				}
				ptr = (NativeOverlapped*)NativeMemory.Alloc((UIntPtr)((IntPtr)(sizeof(NativeOverlapped) + 8) + (IntPtr)(uintPtr * (UIntPtr)((IntPtr)sizeof(GCHandle)))));
				*Overlapped.GCHandleCountRef(ptr) = (UIntPtr)((IntPtr)0);
				ptr->InternalLow = (IntPtr)0;
				ptr->InternalHigh = (IntPtr)0;
				ptr->OffsetLow = this._offsetLow;
				ptr->OffsetHigh = this._offsetHigh;
				ptr->EventHandle = this._eventHandle;
				*Overlapped.GCHandleRef(ptr, (UIntPtr)((IntPtr)0)) = GCHandle.Alloc(this);
				(*Overlapped.GCHandleCountRef(ptr))++;
				if (userData != null)
				{
					if (userData.GetType() == typeof(object[]))
					{
						object[] array = (object[])userData;
						for (int i = 0; i < array.Length; i++)
						{
							*Overlapped.GCHandleRef(ptr, (UIntPtr)((IntPtr)(i + 1))) = GCHandle.Alloc(array[i], GCHandleType.Pinned);
							(*Overlapped.GCHandleCountRef(ptr))++;
						}
					}
					else
					{
						*Overlapped.GCHandleRef(ptr, (UIntPtr)((IntPtr)1)) = GCHandle.Alloc(userData, GCHandleType.Pinned);
						(*Overlapped.GCHandleCountRef(ptr))++;
					}
				}
				this._pNativeOverlapped = ptr;
				if (NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ThreadPoolIOPack(ptr);
				}
				NativeOverlapped* ptr2 = ptr;
				ptr = null;
				result = ptr2;
			}
			finally
			{
				if (ptr != null)
				{
					this._pNativeOverlapped = null;
					Overlapped.FreeNativeOverlapped(ptr);
				}
			}
			return result;
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x000D83FC File Offset: 0x000D65FC
		internal unsafe static void FreeNativeOverlapped(NativeOverlapped* pNativeOverlapped)
		{
			UIntPtr uintPtr = *Overlapped.GCHandleCountRef(pNativeOverlapped);
			for (UIntPtr uintPtr2 = (UIntPtr)((IntPtr)0); uintPtr2 < uintPtr; uintPtr2++)
			{
				Overlapped.GCHandleRef(pNativeOverlapped, uintPtr2).Free();
			}
			NativeMemory.Free((void*)pNativeOverlapped);
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x000D8430 File Offset: 0x000D6630
		private unsafe static ref UIntPtr GCHandleCountRef(NativeOverlapped* pNativeOverlapped)
		{
			return ref *(UIntPtr*)(pNativeOverlapped + 1);
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x000D843A File Offset: 0x000D663A
		private unsafe static ref GCHandle GCHandleRef(NativeOverlapped* pNativeOverlapped, UIntPtr index)
		{
			return ref *(GCHandle*)(pNativeOverlapped + 1 + sizeof(UIntPtr) / sizeof(NativeOverlapped) + (ulong)index * (ulong)((long)sizeof(GCHandle)) / (ulong)sizeof(NativeOverlapped));
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x000D8457 File Offset: 0x000D6657
		internal unsafe static Overlapped GetOverlappedFromNative(NativeOverlapped* pNativeOverlapped)
		{
			return (Overlapped)Overlapped.GCHandleRef(pNativeOverlapped, (UIntPtr)((IntPtr)0)).Target;
		}

		// Token: 0x04000D94 RID: 3476
		private IAsyncResult _asyncResult;

		// Token: 0x04000D95 RID: 3477
		internal object _callback;

		// Token: 0x04000D96 RID: 3478
		private unsafe NativeOverlapped* _pNativeOverlapped;

		// Token: 0x04000D97 RID: 3479
		private IntPtr _eventHandle;

		// Token: 0x04000D98 RID: 3480
		private int _offsetLow;

		// Token: 0x04000D99 RID: 3481
		private int _offsetHigh;
	}
}

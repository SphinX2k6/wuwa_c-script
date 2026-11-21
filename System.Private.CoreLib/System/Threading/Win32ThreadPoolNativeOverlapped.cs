using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x0200045F RID: 1119
	internal struct Win32ThreadPoolNativeOverlapped
	{
		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06004323 RID: 17187 RVA: 0x000DFCAD File Offset: 0x000DDEAD
		internal Win32ThreadPoolNativeOverlapped.OverlappedData Data
		{
			get
			{
				return Win32ThreadPoolNativeOverlapped.s_dataArray[this._dataIndex];
			}
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x000DFCBC File Offset: 0x000DDEBC
		internal unsafe static Win32ThreadPoolNativeOverlapped* Allocate(IOCompletionCallback callback, object state, object pinData, PreAllocatedOverlapped preAllocated, bool flowExecutionControl)
		{
			Win32ThreadPoolNativeOverlapped* ptr = Win32ThreadPoolNativeOverlapped.AllocateNew();
			try
			{
				ptr->SetData(callback, state, pinData, preAllocated, flowExecutionControl);
			}
			catch
			{
				Win32ThreadPoolNativeOverlapped.Free(ptr);
				throw;
			}
			return ptr;
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x000DFCF8 File Offset: 0x000DDEF8
		private unsafe static Win32ThreadPoolNativeOverlapped* AllocateNew()
		{
			IntPtr intPtr;
			Win32ThreadPoolNativeOverlapped* ptr;
			while ((intPtr = Volatile.Read(ref Win32ThreadPoolNativeOverlapped.s_freeList)) != IntPtr.Zero)
			{
				ptr = intPtr;
				if (Interlocked.CompareExchange(ref Win32ThreadPoolNativeOverlapped.s_freeList, ptr->_nextFree, intPtr) == intPtr)
				{
					ptr->_nextFree = IntPtr.Zero;
					return ptr;
				}
			}
			ptr = (Win32ThreadPoolNativeOverlapped*)NativeMemory.Alloc((UIntPtr)((IntPtr)sizeof(Win32ThreadPoolNativeOverlapped)));
			*ptr = default(Win32ThreadPoolNativeOverlapped);
			Win32ThreadPoolNativeOverlapped.OverlappedData value = new Win32ThreadPoolNativeOverlapped.OverlappedData();
			int num = Interlocked.Increment(ref Win32ThreadPoolNativeOverlapped.s_dataCount) - 1;
			if (num < 0)
			{
				Environment.FailFast("Too many outstanding Win32ThreadPoolNativeOverlapped instances");
			}
			for (;;)
			{
				Win32ThreadPoolNativeOverlapped.OverlappedData[] array = Volatile.Read<Win32ThreadPoolNativeOverlapped.OverlappedData[]>(ref Win32ThreadPoolNativeOverlapped.s_dataArray);
				int num2 = (array == null) ? 0 : array.Length;
				if (num2 <= num)
				{
					int i = num2;
					if (i == 0)
					{
						i = 128;
					}
					while (i <= num)
					{
						i = i * 3 / 2;
					}
					Win32ThreadPoolNativeOverlapped.OverlappedData[] array2 = array;
					Array.Resize<Win32ThreadPoolNativeOverlapped.OverlappedData>(ref array2, i);
					if (Interlocked.CompareExchange<Win32ThreadPoolNativeOverlapped.OverlappedData[]>(ref Win32ThreadPoolNativeOverlapped.s_dataArray, array2, array) != array)
					{
						continue;
					}
					array = array2;
				}
				if (Win32ThreadPoolNativeOverlapped.s_dataArray[num] != null)
				{
					break;
				}
				Interlocked.Exchange<Win32ThreadPoolNativeOverlapped.OverlappedData>(ref array[num], value);
			}
			ptr->_dataIndex = num;
			return ptr;
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x000DFDF4 File Offset: 0x000DDFF4
		private void SetData(IOCompletionCallback callback, object state, object pinData, PreAllocatedOverlapped preAllocated, bool flowExecutionContext)
		{
			Win32ThreadPoolNativeOverlapped.OverlappedData data = this.Data;
			data._callback = callback;
			data._state = state;
			data._executionContext = (flowExecutionContext ? ExecutionContext.Capture() : null);
			data._preAllocated = preAllocated;
			if (pinData != null)
			{
				object[] array = pinData as object[];
				if (array != null && array.GetType() == typeof(object[]))
				{
					if (data._pinnedData == null || data._pinnedData.Length < array.Length)
					{
						Array.Resize<GCHandle>(ref data._pinnedData, array.Length);
					}
					for (int i = 0; i < array.Length; i++)
					{
						if (!data._pinnedData[i].IsAllocated)
						{
							data._pinnedData[i] = GCHandle.Alloc(array[i], GCHandleType.Pinned);
						}
						else
						{
							data._pinnedData[i].Target = array[i];
						}
					}
					return;
				}
				Win32ThreadPoolNativeOverlapped.OverlappedData overlappedData = data;
				if (overlappedData._pinnedData == null)
				{
					overlappedData._pinnedData = new GCHandle[1];
				}
				if (!data._pinnedData[0].IsAllocated)
				{
					data._pinnedData[0] = GCHandle.Alloc(pinData, GCHandleType.Pinned);
					return;
				}
				data._pinnedData[0].Target = pinData;
			}
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x000DFF1C File Offset: 0x000DE11C
		internal unsafe static void Free(Win32ThreadPoolNativeOverlapped* overlapped)
		{
			overlapped->Data.Reset();
			overlapped->_overlapped = default(NativeOverlapped);
			IntPtr intPtr;
			do
			{
				intPtr = Volatile.Read(ref Win32ThreadPoolNativeOverlapped.s_freeList);
				overlapped->_nextFree = intPtr;
			}
			while (Interlocked.CompareExchange(ref Win32ThreadPoolNativeOverlapped.s_freeList, overlapped, intPtr) != intPtr);
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x00007B62 File Offset: 0x00005D62
		internal unsafe static NativeOverlapped* ToNativeOverlapped(Win32ThreadPoolNativeOverlapped* overlapped)
		{
			return (NativeOverlapped*)overlapped;
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x00007B62 File Offset: 0x00005D62
		internal unsafe static Win32ThreadPoolNativeOverlapped* FromNativeOverlapped(NativeOverlapped* overlapped)
		{
			return (Win32ThreadPoolNativeOverlapped*)overlapped;
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x000DFF64 File Offset: 0x000DE164
		internal unsafe static void CompleteWithCallback(uint errorCode, uint bytesWritten, Win32ThreadPoolNativeOverlapped* overlapped)
		{
			Win32ThreadPoolNativeOverlapped.OverlappedData data = overlapped->Data;
			data._completed = true;
			if (data._executionContext == null)
			{
				data._callback(errorCode, bytesWritten, Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(overlapped));
				return;
			}
			ContextCallback contextCallback = Win32ThreadPoolNativeOverlapped.s_executionContextCallback;
			if (contextCallback == null)
			{
				ContextCallback contextCallback2;
				if ((contextCallback2 = Win32ThreadPoolNativeOverlapped.<>O.<0>__OnExecutionContextCallback) == null)
				{
					contextCallback2 = (Win32ThreadPoolNativeOverlapped.<>O.<0>__OnExecutionContextCallback = new ContextCallback(Win32ThreadPoolNativeOverlapped.OnExecutionContextCallback));
				}
				contextCallback = (Win32ThreadPoolNativeOverlapped.s_executionContextCallback = contextCallback2);
			}
			Win32ThreadPoolNativeOverlapped.ExecutionContextCallbackArgs executionContextCallbackArgs = Win32ThreadPoolNativeOverlapped.t_executionContextCallbackArgs;
			if (executionContextCallbackArgs == null)
			{
				executionContextCallbackArgs = new Win32ThreadPoolNativeOverlapped.ExecutionContextCallbackArgs();
			}
			Win32ThreadPoolNativeOverlapped.t_executionContextCallbackArgs = null;
			executionContextCallbackArgs._errorCode = errorCode;
			executionContextCallbackArgs._bytesWritten = bytesWritten;
			executionContextCallbackArgs._overlapped = overlapped;
			executionContextCallbackArgs._data = data;
			ExecutionContext.Run(data._executionContext, contextCallback, executionContextCallbackArgs);
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x000E0004 File Offset: 0x000DE204
		private unsafe static void OnExecutionContextCallback(object state)
		{
			Win32ThreadPoolNativeOverlapped.ExecutionContextCallbackArgs executionContextCallbackArgs = (Win32ThreadPoolNativeOverlapped.ExecutionContextCallbackArgs)state;
			uint errorCode = executionContextCallbackArgs._errorCode;
			uint bytesWritten = executionContextCallbackArgs._bytesWritten;
			Win32ThreadPoolNativeOverlapped* overlapped = executionContextCallbackArgs._overlapped;
			Win32ThreadPoolNativeOverlapped.OverlappedData data = executionContextCallbackArgs._data;
			executionContextCallbackArgs._data = null;
			Win32ThreadPoolNativeOverlapped.t_executionContextCallbackArgs = executionContextCallbackArgs;
			data._callback(errorCode, bytesWritten, Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(overlapped));
		}

		// Token: 0x04000EBA RID: 3770
		[ThreadStatic]
		private static Win32ThreadPoolNativeOverlapped.ExecutionContextCallbackArgs t_executionContextCallbackArgs;

		// Token: 0x04000EBB RID: 3771
		private static ContextCallback s_executionContextCallback;

		// Token: 0x04000EBC RID: 3772
		private static Win32ThreadPoolNativeOverlapped.OverlappedData[] s_dataArray;

		// Token: 0x04000EBD RID: 3773
		private static int s_dataCount;

		// Token: 0x04000EBE RID: 3774
		private static IntPtr s_freeList;

		// Token: 0x04000EBF RID: 3775
		private NativeOverlapped _overlapped;

		// Token: 0x04000EC0 RID: 3776
		private IntPtr _nextFree;

		// Token: 0x04000EC1 RID: 3777
		private int _dataIndex;

		// Token: 0x02000460 RID: 1120
		private sealed class ExecutionContextCallbackArgs
		{
			// Token: 0x04000EC2 RID: 3778
			internal uint _errorCode;

			// Token: 0x04000EC3 RID: 3779
			internal uint _bytesWritten;

			// Token: 0x04000EC4 RID: 3780
			internal unsafe Win32ThreadPoolNativeOverlapped* _overlapped;

			// Token: 0x04000EC5 RID: 3781
			internal Win32ThreadPoolNativeOverlapped.OverlappedData _data;
		}

		// Token: 0x02000461 RID: 1121
		internal sealed class OverlappedData
		{
			// Token: 0x0600432D RID: 17197 RVA: 0x000E0054 File Offset: 0x000DE254
			internal void Reset()
			{
				if (this._pinnedData != null)
				{
					for (int i = 0; i < this._pinnedData.Length; i++)
					{
						if (this._pinnedData[i].IsAllocated && this._pinnedData[i].Target != null)
						{
							this._pinnedData[i].Target = null;
						}
					}
				}
				this._callback = null;
				this._state = null;
				this._executionContext = null;
				this._completed = false;
				this._preAllocated = null;
			}

			// Token: 0x04000EC6 RID: 3782
			internal GCHandle[] _pinnedData;

			// Token: 0x04000EC7 RID: 3783
			internal IOCompletionCallback _callback;

			// Token: 0x04000EC8 RID: 3784
			internal object _state;

			// Token: 0x04000EC9 RID: 3785
			internal ExecutionContext _executionContext;

			// Token: 0x04000ECA RID: 3786
			internal ThreadPoolBoundHandle _boundHandle;

			// Token: 0x04000ECB RID: 3787
			internal PreAllocatedOverlapped _preAllocated;

			// Token: 0x04000ECC RID: 3788
			internal bool _completed;
		}

		// Token: 0x02000462 RID: 1122
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000ECD RID: 3789
			public static ContextCallback <0>__OnExecutionContextCallback;
		}
	}
}

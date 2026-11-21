using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x02000623 RID: 1571
	[CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder), MarshalMode.ManagedToUnmanagedIn, typeof(SafeHandleMarshaller<>.ManagedToUnmanagedIn))]
	[CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder), MarshalMode.ManagedToUnmanagedRef, typeof(SafeHandleMarshaller<>.ManagedToUnmanagedRef))]
	[CustomMarshaller(typeof(CustomMarshallerAttribute.GenericPlaceholder), MarshalMode.ManagedToUnmanagedOut, typeof(SafeHandleMarshaller<>.ManagedToUnmanagedOut))]
	public static class SafeHandleMarshaller<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T> where T : SafeHandle
	{
		// Token: 0x02000624 RID: 1572
		public struct ManagedToUnmanagedIn
		{
			// Token: 0x0600721E RID: 29214 RVA: 0x00111DB8 File Offset: 0x0010FFB8
			[NullableContext(1)]
			public void FromManaged(T handle)
			{
				this._handle = handle;
				handle.DangerousAddRef(ref this._addRefd);
			}

			// Token: 0x0600721F RID: 29215 RVA: 0x00111DD2 File Offset: 0x0010FFD2
			public IntPtr ToUnmanaged()
			{
				return this._handle.DangerousGetHandle();
			}

			// Token: 0x06007220 RID: 29216 RVA: 0x00111DE4 File Offset: 0x0010FFE4
			public void Free()
			{
				if (this._addRefd)
				{
					this._handle.DangerousRelease();
				}
			}

			// Token: 0x04001391 RID: 5009
			private bool _addRefd;

			// Token: 0x04001392 RID: 5010
			private T _handle;
		}

		// Token: 0x02000625 RID: 1573
		[NullableContext(1)]
		[Nullable(0)]
		public struct ManagedToUnmanagedRef
		{
			// Token: 0x06007221 RID: 29217 RVA: 0x00111DFE File Offset: 0x0010FFFE
			public ManagedToUnmanagedRef()
			{
				this._handle = default(T);
				this._originalHandleValue = (IntPtr)0;
				this._handleToReturn = default(T);
				this._addRefd = false;
				this._callInvoked = false;
				this._newHandle = Activator.CreateInstance<T>();
			}

			// Token: 0x06007222 RID: 29218 RVA: 0x00111E39 File Offset: 0x00110039
			public void FromManaged(T handle)
			{
				this._handle = handle;
				handle.DangerousAddRef(ref this._addRefd);
				this._originalHandleValue = handle.DangerousGetHandle();
			}

			// Token: 0x06007223 RID: 29219 RVA: 0x00111E64 File Offset: 0x00110064
			public IntPtr ToUnmanaged()
			{
				return this._originalHandleValue;
			}

			// Token: 0x06007224 RID: 29220 RVA: 0x00111E6C File Offset: 0x0011006C
			public void FromUnmanaged(IntPtr value)
			{
				if (value == this._originalHandleValue)
				{
					this._handleToReturn = this._handle;
					return;
				}
				Marshal.InitHandle(this._newHandle, value);
				this._handleToReturn = this._newHandle;
			}

			// Token: 0x06007225 RID: 29221 RVA: 0x00111EA1 File Offset: 0x001100A1
			public void OnInvoked()
			{
				this._callInvoked = true;
			}

			// Token: 0x06007226 RID: 29222 RVA: 0x00111EAA File Offset: 0x001100AA
			public T ToManagedFinally()
			{
				return this._handleToReturn;
			}

			// Token: 0x06007227 RID: 29223 RVA: 0x00111EB2 File Offset: 0x001100B2
			public void Free()
			{
				if (this._addRefd)
				{
					this._handle.DangerousRelease();
				}
				if (!this._callInvoked)
				{
					this._newHandle.Dispose();
				}
			}

			// Token: 0x04001393 RID: 5011
			private bool _addRefd;

			// Token: 0x04001394 RID: 5012
			private bool _callInvoked;

			// Token: 0x04001395 RID: 5013
			private T _handle;

			// Token: 0x04001396 RID: 5014
			private IntPtr _originalHandleValue;

			// Token: 0x04001397 RID: 5015
			private T _newHandle;

			// Token: 0x04001398 RID: 5016
			private T _handleToReturn;
		}

		// Token: 0x02000626 RID: 1574
		public struct ManagedToUnmanagedOut
		{
			// Token: 0x06007228 RID: 29224 RVA: 0x00111EE4 File Offset: 0x001100E4
			public ManagedToUnmanagedOut()
			{
				this._initialized = false;
				this._newHandle = Activator.CreateInstance<T>();
			}

			// Token: 0x06007229 RID: 29225 RVA: 0x00111EF8 File Offset: 0x001100F8
			public void FromUnmanaged(IntPtr value)
			{
				this._initialized = true;
				Marshal.InitHandle(this._newHandle, value);
			}

			// Token: 0x0600722A RID: 29226 RVA: 0x00111F12 File Offset: 0x00110112
			[NullableContext(1)]
			public T ToManaged()
			{
				return this._newHandle;
			}

			// Token: 0x0600722B RID: 29227 RVA: 0x00111F1A File Offset: 0x0011011A
			public void Free()
			{
				if (!this._initialized)
				{
					this._newHandle.Dispose();
				}
			}

			// Token: 0x04001399 RID: 5017
			private bool _initialized;

			// Token: 0x0400139A RID: 5018
			private T _newHandle;
		}
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005D5 RID: 1493
	[NullableContext(1)]
	public interface ICustomMarshaler
	{
		// Token: 0x06007030 RID: 28720
		[DynamicDependency("GetCustomMarshalerInstance", typeof(Marshal))]
		object MarshalNativeToManaged(IntPtr pNativeData);

		// Token: 0x06007031 RID: 28721
		IntPtr MarshalManagedToNative(object ManagedObj);

		// Token: 0x06007032 RID: 28722
		void CleanUpNativeData(IntPtr pNativeData);

		// Token: 0x06007033 RID: 28723
		void CleanUpManagedData(object ManagedObj);

		// Token: 0x06007034 RID: 28724
		int GetNativeDataSize();
	}
}

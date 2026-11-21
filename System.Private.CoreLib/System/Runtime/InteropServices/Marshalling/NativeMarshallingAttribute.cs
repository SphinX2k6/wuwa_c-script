using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x0200061C RID: 1564
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class NativeMarshallingAttribute : Attribute
	{
		// Token: 0x060071FC RID: 29180 RVA: 0x00111B21 File Offset: 0x0010FD21
		public NativeMarshallingAttribute(Type nativeType)
		{
			this.NativeType = nativeType;
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x060071FD RID: 29181 RVA: 0x00111B30 File Offset: 0x0010FD30
		public Type NativeType { get; }
	}
}

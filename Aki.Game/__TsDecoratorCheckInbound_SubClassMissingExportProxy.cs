using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B26 RID: 11046
public class __TsDecoratorCheckInbound_SubClassMissingExportProxy : __TsDecoratorCheckInbound_InheritProxy
{
	// Token: 0x0601BDCD RID: 114125 RVA: 0x008A6BA0 File Offset: 0x008A4DA0
	[NullableContext(1)]
	protected __TsDecoratorCheckInbound_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInbound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDCE RID: 114126 RVA: 0x008A6BD3 File Offset: 0x008A4DD3
	protected __TsDecoratorCheckInbound_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

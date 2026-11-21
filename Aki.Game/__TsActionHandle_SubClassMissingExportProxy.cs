using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E06 RID: 11782
public class __TsActionHandle_SubClassMissingExportProxy : __TsActionHandle_InheritProxy
{
	// Token: 0x0601C6D5 RID: 116437 RVA: 0x008BA448 File Offset: 0x008B8648
	[NullableContext(1)]
	protected __TsActionHandle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsActionHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6D6 RID: 116438 RVA: 0x008BA47B File Offset: 0x008B867B
	protected __TsActionHandle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

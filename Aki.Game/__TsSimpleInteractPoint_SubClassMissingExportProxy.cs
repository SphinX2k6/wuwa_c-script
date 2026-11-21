using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EC6 RID: 11974
public class __TsSimpleInteractPoint_SubClassMissingExportProxy : __TsSimpleInteractPoint_InheritProxy
{
	// Token: 0x0601C8EF RID: 116975 RVA: 0x008BDBB8 File Offset: 0x008BBDB8
	[NullableContext(1)]
	protected __TsSimpleInteractPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8F0 RID: 116976 RVA: 0x008BDBEB File Offset: 0x008BBDEB
	protected __TsSimpleInteractPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

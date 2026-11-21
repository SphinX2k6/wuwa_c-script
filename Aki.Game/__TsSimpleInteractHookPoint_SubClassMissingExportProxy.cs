using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EC2 RID: 11970
public class __TsSimpleInteractHookPoint_SubClassMissingExportProxy : __TsSimpleInteractHookPoint_InheritProxy
{
	// Token: 0x0601C8E7 RID: 116967 RVA: 0x008BDAC8 File Offset: 0x008BBCC8
	[NullableContext(1)]
	protected __TsSimpleInteractHookPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractHookPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8E8 RID: 116968 RVA: 0x008BDAFB File Offset: 0x008BBCFB
	protected __TsSimpleInteractHookPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

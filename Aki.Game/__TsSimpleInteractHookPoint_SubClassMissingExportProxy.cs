using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003947 RID: 14663
public class __TsSimpleInteractHookPoint_SubClassMissingExportProxy : __TsSimpleInteractHookPoint_InheritProxy
{
	// Token: 0x0601EC43 RID: 126019 RVA: 0x0089A0BC File Offset: 0x008982BC
	[NullableContext(1)]
	protected __TsSimpleInteractHookPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractHookPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC44 RID: 126020 RVA: 0x0089A0EF File Offset: 0x008982EF
	protected __TsSimpleInteractHookPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

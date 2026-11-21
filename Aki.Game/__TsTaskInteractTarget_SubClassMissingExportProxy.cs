using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BFE RID: 11262
public class __TsTaskInteractTarget_SubClassMissingExportProxy : __TsTaskInteractTarget_InheritProxy
{
	// Token: 0x0601C017 RID: 114711 RVA: 0x008AB9EC File Offset: 0x008A9BEC
	[NullableContext(1)]
	protected __TsTaskInteractTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskInteractTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C018 RID: 114712 RVA: 0x008ABA1F File Offset: 0x008A9C1F
	protected __TsTaskInteractTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

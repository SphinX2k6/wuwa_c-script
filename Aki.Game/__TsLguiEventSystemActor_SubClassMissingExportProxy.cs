using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F40 RID: 12096
public class __TsLguiEventSystemActor_SubClassMissingExportProxy : __TsLguiEventSystemActor_InheritProxy
{
	// Token: 0x0601CAEB RID: 117483 RVA: 0x008C1030 File Offset: 0x008BF230
	[NullableContext(1)]
	protected __TsLguiEventSystemActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLguiEventSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAEC RID: 117484 RVA: 0x008C1063 File Offset: 0x008BF263
	protected __TsLguiEventSystemActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

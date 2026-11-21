using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E0C RID: 11788
public class __TsCharacterController_SubClassMissingExportProxy : __TsCharacterController_InheritProxy
{
	// Token: 0x0601C700 RID: 116480 RVA: 0x008BA834 File Offset: 0x008B8A34
	[NullableContext(1)]
	protected __TsCharacterController_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C701 RID: 116481 RVA: 0x008BA867 File Offset: 0x008B8A67
	protected __TsCharacterController_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

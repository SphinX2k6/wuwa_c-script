using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002D96 RID: 11670
public class __TsAnimNotifyEnableCollision_SubClassMissingExportProxy : __TsAnimNotifyEnableCollision_InheritProxy
{
	// Token: 0x0601C581 RID: 116097 RVA: 0x008B7A10 File Offset: 0x008B5C10
	[NullableContext(1)]
	protected __TsAnimNotifyEnableCollision_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEnableCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C582 RID: 116098 RVA: 0x008B7A43 File Offset: 0x008B5C43
	protected __TsAnimNotifyEnableCollision_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

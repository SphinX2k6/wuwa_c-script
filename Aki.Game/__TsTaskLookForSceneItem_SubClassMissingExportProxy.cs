using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200368B RID: 13963
public class __TsTaskLookForSceneItem_SubClassMissingExportProxy : __TsTaskLookForSceneItem_InheritProxy
{
	// Token: 0x0601E303 RID: 123651 RVA: 0x008840C0 File Offset: 0x008822C0
	[NullableContext(1)]
	protected __TsTaskLookForSceneItem_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskLookForSceneItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E304 RID: 123652 RVA: 0x008840F3 File Offset: 0x008822F3
	protected __TsTaskLookForSceneItem_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

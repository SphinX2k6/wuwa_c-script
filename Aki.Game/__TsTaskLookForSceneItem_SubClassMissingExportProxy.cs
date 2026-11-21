using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C00 RID: 11264
public class __TsTaskLookForSceneItem_SubClassMissingExportProxy : __TsTaskLookForSceneItem_InheritProxy
{
	// Token: 0x0601C01C RID: 114716 RVA: 0x008ABA98 File Offset: 0x008A9C98
	[NullableContext(1)]
	protected __TsTaskLookForSceneItem_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskLookForSceneItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C01D RID: 114717 RVA: 0x008ABACB File Offset: 0x008A9CCB
	protected __TsTaskLookForSceneItem_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200368F RID: 13967
public class __TsTaskMoveToActor_SubClassMissingExportProxy : __TsTaskMoveToActor_InheritProxy
{
	// Token: 0x0601E30E RID: 123662 RVA: 0x00884248 File Offset: 0x00882448
	[NullableContext(1)]
	protected __TsTaskMoveToActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E30F RID: 123663 RVA: 0x0088427B File Offset: 0x0088247B
	protected __TsTaskMoveToActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E22 RID: 11810
public class __TsGameSplineActor_SubClassMissingExportProxy : __TsGameSplineActor_InheritProxy
{
	// Token: 0x0601C732 RID: 116530 RVA: 0x008BAE0C File Offset: 0x008B900C
	[NullableContext(1)]
	protected __TsGameSplineActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameSplineActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C733 RID: 116531 RVA: 0x008BAE3F File Offset: 0x008B903F
	protected __TsGameSplineActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

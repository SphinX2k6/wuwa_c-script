using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038A9 RID: 14505
public class __TsGameSplineActor_SubClassMissingExportProxy : __TsGameSplineActor_InheritProxy
{
	// Token: 0x0601EA58 RID: 125528 RVA: 0x00895904 File Offset: 0x00893B04
	[NullableContext(1)]
	protected __TsGameSplineActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameSplineActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA59 RID: 125529 RVA: 0x00895937 File Offset: 0x00893B37
	protected __TsGameSplineActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

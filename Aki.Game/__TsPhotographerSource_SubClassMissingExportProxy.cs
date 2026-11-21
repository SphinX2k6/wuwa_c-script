using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E3A RID: 11834
public class __TsPhotographerSource_SubClassMissingExportProxy : __TsPhotographerSource_InheritProxy
{
	// Token: 0x0601C784 RID: 116612 RVA: 0x008BB68C File Offset: 0x008B988C
	[NullableContext(1)]
	protected __TsPhotographerSource_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographerSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C785 RID: 116613 RVA: 0x008BB6BF File Offset: 0x008B98BF
	protected __TsPhotographerSource_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

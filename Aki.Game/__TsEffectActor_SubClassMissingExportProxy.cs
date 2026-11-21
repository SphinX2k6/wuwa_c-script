using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E14 RID: 11796
public class __TsEffectActor_SubClassMissingExportProxy : __TsEffectActor_InheritProxy
{
	// Token: 0x0601C714 RID: 116500 RVA: 0x008BAA58 File Offset: 0x008B8C58
	[NullableContext(1)]
	protected __TsEffectActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C715 RID: 116501 RVA: 0x008BAA8B File Offset: 0x008B8C8B
	protected __TsEffectActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

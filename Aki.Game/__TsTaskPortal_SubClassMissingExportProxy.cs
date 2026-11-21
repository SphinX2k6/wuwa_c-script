using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C1A RID: 11290
public class __TsTaskPortal_SubClassMissingExportProxy : __TsTaskPortal_InheritProxy
{
	// Token: 0x0601C064 RID: 114788 RVA: 0x008AC490 File Offset: 0x008AA690
	[NullableContext(1)]
	protected __TsTaskPortal_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPortal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C065 RID: 114789 RVA: 0x008AC4C3 File Offset: 0x008AA6C3
	protected __TsTaskPortal_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

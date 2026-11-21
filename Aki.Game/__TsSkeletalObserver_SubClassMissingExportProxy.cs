using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E46 RID: 11846
public class __TsSkeletalObserver_SubClassMissingExportProxy : __TsSkeletalObserver_InheritProxy
{
	// Token: 0x0601C7A3 RID: 116643 RVA: 0x008BB9BC File Offset: 0x008B9BBC
	[NullableContext(1)]
	protected __TsSkeletalObserver_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSkeletalObserver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7A4 RID: 116644 RVA: 0x008BB9EF File Offset: 0x008B9BEF
	protected __TsSkeletalObserver_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

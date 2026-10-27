using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038CD RID: 14541
public class __TsSkeletalObserver_SubClassMissingExportProxy : __TsSkeletalObserver_InheritProxy
{
	// Token: 0x0601EAE9 RID: 125673 RVA: 0x00897428 File Offset: 0x00895628
	[NullableContext(1)]
	protected __TsSkeletalObserver_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSkeletalObserver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAEA RID: 125674 RVA: 0x0089745B File Offset: 0x0089565B
	protected __TsSkeletalObserver_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

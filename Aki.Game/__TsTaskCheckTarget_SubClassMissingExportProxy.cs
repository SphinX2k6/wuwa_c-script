using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BDC RID: 11228
public class __TsTaskCheckTarget_SubClassMissingExportProxy : __TsTaskCheckTarget_InheritProxy
{
	// Token: 0x0601BFBB RID: 114619 RVA: 0x008AAD5C File Offset: 0x008A8F5C
	[NullableContext(1)]
	protected __TsTaskCheckTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskCheckTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BFBC RID: 114620 RVA: 0x008AAD8F File Offset: 0x008A8F8F
	protected __TsTaskCheckTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003663 RID: 13923
public class __TsTaskChangePatrol_SubClassMissingExportProxy : __TsTaskChangePatrol_InheritProxy
{
	// Token: 0x0601E294 RID: 123540 RVA: 0x008830E8 File Offset: 0x008812E8
	[NullableContext(1)]
	protected __TsTaskChangePatrol_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangePatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E295 RID: 123541 RVA: 0x0088311B File Offset: 0x0088131B
	protected __TsTaskChangePatrol_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

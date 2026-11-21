using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BD8 RID: 11224
public class __TsTaskChangePatrol_SubClassMissingExportProxy : __TsTaskChangePatrol_InheritProxy
{
	// Token: 0x0601BFAF RID: 114607 RVA: 0x008AABCC File Offset: 0x008A8DCC
	[NullableContext(1)]
	protected __TsTaskChangePatrol_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangePatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BFB0 RID: 114608 RVA: 0x008AABFF File Offset: 0x008A8DFF
	protected __TsTaskChangePatrol_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

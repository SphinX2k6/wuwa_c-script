using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BE0 RID: 11232
public class __TsTaskDoTurn_SubClassMissingExportProxy : __TsTaskDoTurn_InheritProxy
{
	// Token: 0x0601BFC6 RID: 114630 RVA: 0x008AAEE0 File Offset: 0x008A90E0
	[NullableContext(1)]
	protected __TsTaskDoTurn_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskDoTurn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BFC7 RID: 114631 RVA: 0x008AAF13 File Offset: 0x008A9113
	protected __TsTaskDoTurn_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

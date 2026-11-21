using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B28 RID: 11048
public class __TsDecoratorCheckInInteraction_SubClassMissingExportProxy : __TsDecoratorCheckInInteraction_InheritProxy
{
	// Token: 0x0601BDD2 RID: 114130 RVA: 0x008A6C4C File Offset: 0x008A4E4C
	[NullableContext(1)]
	protected __TsDecoratorCheckInInteraction_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDD3 RID: 114131 RVA: 0x008A6C7F File Offset: 0x008A4E7F
	protected __TsDecoratorCheckInInteraction_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

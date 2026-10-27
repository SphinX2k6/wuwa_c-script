using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035B3 RID: 13747
public class __TsDecoratorCheckInInteraction_SubClassMissingExportProxy : __TsDecoratorCheckInInteraction_InheritProxy
{
	// Token: 0x0601E0AA RID: 123050 RVA: 0x0087EBB8 File Offset: 0x0087CDB8
	[NullableContext(1)]
	protected __TsDecoratorCheckInInteraction_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0AB RID: 123051 RVA: 0x0087EBEB File Offset: 0x0087CDEB
	protected __TsDecoratorCheckInInteraction_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035AF RID: 13743
public class __TsDecoratorCheckFsmState_SubClassMissingExportProxy : __TsDecoratorCheckFsmState_InheritProxy
{
	// Token: 0x0601E0A0 RID: 123040 RVA: 0x0087EA60 File Offset: 0x0087CC60
	[NullableContext(1)]
	protected __TsDecoratorCheckFsmState_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckFsmState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0A1 RID: 123041 RVA: 0x0087EA93 File Offset: 0x0087CC93
	protected __TsDecoratorCheckFsmState_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035B1 RID: 13745
public class __TsDecoratorCheckInbound_SubClassMissingExportProxy : __TsDecoratorCheckInbound_InheritProxy
{
	// Token: 0x0601E0A5 RID: 123045 RVA: 0x0087EB0C File Offset: 0x0087CD0C
	[NullableContext(1)]
	protected __TsDecoratorCheckInbound_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInbound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0A6 RID: 123046 RVA: 0x0087EB3F File Offset: 0x0087CD3F
	protected __TsDecoratorCheckInbound_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

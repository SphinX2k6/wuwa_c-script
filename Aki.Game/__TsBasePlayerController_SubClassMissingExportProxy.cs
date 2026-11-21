using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E0A RID: 11786
public class __TsBasePlayerController_SubClassMissingExportProxy : __TsBasePlayerController_InheritProxy
{
	// Token: 0x0601C6F3 RID: 116467 RVA: 0x008BA72C File Offset: 0x008B892C
	[NullableContext(1)]
	protected __TsBasePlayerController_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBasePlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6F4 RID: 116468 RVA: 0x008BA75F File Offset: 0x008B895F
	protected __TsBasePlayerController_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

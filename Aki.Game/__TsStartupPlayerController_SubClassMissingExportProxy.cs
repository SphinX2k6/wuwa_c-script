using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E0E RID: 11790
public class __TsStartupPlayerController_SubClassMissingExportProxy : __TsStartupPlayerController_InheritProxy
{
	// Token: 0x0601C704 RID: 116484 RVA: 0x008BA8AC File Offset: 0x008B8AAC
	[NullableContext(1)]
	protected __TsStartupPlayerController_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsStartupPlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C705 RID: 116485 RVA: 0x008BA8DF File Offset: 0x008B8ADF
	protected __TsStartupPlayerController_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

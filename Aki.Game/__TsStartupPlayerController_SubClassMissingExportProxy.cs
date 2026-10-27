using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003895 RID: 14485
public class __TsStartupPlayerController_SubClassMissingExportProxy : __TsStartupPlayerController_InheritProxy
{
	// Token: 0x0601EA26 RID: 125478 RVA: 0x008951D4 File Offset: 0x008933D4
	[NullableContext(1)]
	protected __TsStartupPlayerController_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsStartupPlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA27 RID: 125479 RVA: 0x00895207 File Offset: 0x00893407
	protected __TsStartupPlayerController_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

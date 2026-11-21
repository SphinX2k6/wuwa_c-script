using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002ED2 RID: 11986
public class __TsBaseVehicle_SubClassMissingExportProxy : __TsBaseVehicle_InheritProxy
{
	// Token: 0x0601C921 RID: 117025 RVA: 0x008BE0E8 File Offset: 0x008BC2E8
	[NullableContext(1)]
	protected __TsBaseVehicle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C922 RID: 117026 RVA: 0x008BE11B File Offset: 0x008BC31B
	protected __TsBaseVehicle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

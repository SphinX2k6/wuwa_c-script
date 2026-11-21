using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EBE RID: 11966
public class __TsSimpleInteractBase_SubClassMissingExportProxy : __TsSimpleInteractBase_InheritProxy
{
	// Token: 0x0601C8DF RID: 116959 RVA: 0x008BD9D8 File Offset: 0x008BBBD8
	[NullableContext(1)]
	protected __TsSimpleInteractBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8E0 RID: 116960 RVA: 0x008BDA0B File Offset: 0x008BBC0B
	protected __TsSimpleInteractBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

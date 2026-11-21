using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B0C RID: 11020
public class __TsDecoratorActorsLocation_SubClassMissingExportProxy : __TsDecoratorActorsLocation_InheritProxy
{
	// Token: 0x0601BD8C RID: 114060 RVA: 0x008A62E4 File Offset: 0x008A44E4
	[NullableContext(1)]
	protected __TsDecoratorActorsLocation_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorActorsLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD8D RID: 114061 RVA: 0x008A6317 File Offset: 0x008A4517
	protected __TsDecoratorActorsLocation_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

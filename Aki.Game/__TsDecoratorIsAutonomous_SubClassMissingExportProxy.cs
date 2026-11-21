using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B46 RID: 11078
public class __TsDecoratorIsAutonomous_SubClassMissingExportProxy : __TsDecoratorIsAutonomous_InheritProxy
{
	// Token: 0x0601BE1F RID: 114207 RVA: 0x008A76CC File Offset: 0x008A58CC
	[NullableContext(1)]
	protected __TsDecoratorIsAutonomous_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorIsAutonomous.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE20 RID: 114208 RVA: 0x008A76FF File Offset: 0x008A58FF
	protected __TsDecoratorIsAutonomous_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

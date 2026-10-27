using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035D1 RID: 13777
public class __TsDecoratorIsAutonomous_SubClassMissingExportProxy : __TsDecoratorIsAutonomous_InheritProxy
{
	// Token: 0x0601E0F7 RID: 123127 RVA: 0x0087F638 File Offset: 0x0087D838
	[NullableContext(1)]
	protected __TsDecoratorIsAutonomous_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorIsAutonomous.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0F8 RID: 123128 RVA: 0x0087F66B File Offset: 0x0087D86B
	protected __TsDecoratorIsAutonomous_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

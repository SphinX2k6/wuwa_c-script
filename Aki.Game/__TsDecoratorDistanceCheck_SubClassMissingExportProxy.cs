using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002AF8 RID: 11000
public class __TsDecoratorDistanceCheck_SubClassMissingExportProxy : __TsDecoratorDistanceCheck_InheritProxy
{
	// Token: 0x0601BD5A RID: 114010 RVA: 0x008A5C2C File Offset: 0x008A3E2C
	[NullableContext(1)]
	protected __TsDecoratorDistanceCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistanceCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD5B RID: 114011 RVA: 0x008A5C5F File Offset: 0x008A3E5F
	protected __TsDecoratorDistanceCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

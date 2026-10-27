using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003599 RID: 13721
public class __TsDecoratorBlackboard_SubClassMissingExportProxy : __TsDecoratorBlackboard_InheritProxy
{
	// Token: 0x0601E069 RID: 122985 RVA: 0x0087E2FC File Offset: 0x0087C4FC
	[NullableContext(1)]
	protected __TsDecoratorBlackboard_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E06A RID: 122986 RVA: 0x0087E32F File Offset: 0x0087C52F
	protected __TsDecoratorBlackboard_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

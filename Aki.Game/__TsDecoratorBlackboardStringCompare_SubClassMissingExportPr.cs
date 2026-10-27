using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035A7 RID: 13735
public class __TsDecoratorBlackboardStringCompare_SubClassMissingExportProxy : __TsDecoratorBlackboardStringCompare_InheritProxy
{
	// Token: 0x0601E08C RID: 123020 RVA: 0x0087E7B0 File Offset: 0x0087C9B0
	[NullableContext(1)]
	protected __TsDecoratorBlackboardStringCompare_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardStringCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E08D RID: 123021 RVA: 0x0087E7E3 File Offset: 0x0087C9E3
	protected __TsDecoratorBlackboardStringCompare_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

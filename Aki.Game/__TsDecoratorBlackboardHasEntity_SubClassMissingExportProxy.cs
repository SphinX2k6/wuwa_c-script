using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035A3 RID: 13731
public class __TsDecoratorBlackboardHasEntity_SubClassMissingExportProxy : __TsDecoratorBlackboardHasEntity_InheritProxy
{
	// Token: 0x0601E082 RID: 123010 RVA: 0x0087E658 File Offset: 0x0087C858
	[NullableContext(1)]
	protected __TsDecoratorBlackboardHasEntity_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardHasEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E083 RID: 123011 RVA: 0x0087E68B File Offset: 0x0087C88B
	protected __TsDecoratorBlackboardHasEntity_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

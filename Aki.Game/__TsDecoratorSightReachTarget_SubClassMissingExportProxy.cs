using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035DF RID: 13791
public class __TsDecoratorSightReachTarget_SubClassMissingExportProxy : __TsDecoratorSightReachTarget_InheritProxy
{
	// Token: 0x0601E11A RID: 123162 RVA: 0x0087FAEC File Offset: 0x0087DCEC
	[NullableContext(1)]
	protected __TsDecoratorSightReachTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorSightReachTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E11B RID: 123163 RVA: 0x0087FB1F File Offset: 0x0087DD1F
	protected __TsDecoratorSightReachTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

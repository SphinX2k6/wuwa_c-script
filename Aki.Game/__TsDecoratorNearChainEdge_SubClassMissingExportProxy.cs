using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035D5 RID: 13781
public class __TsDecoratorNearChainEdge_SubClassMissingExportProxy : __TsDecoratorNearChainEdge_InheritProxy
{
	// Token: 0x0601E101 RID: 123137 RVA: 0x0087F790 File Offset: 0x0087D990
	[NullableContext(1)]
	protected __TsDecoratorNearChainEdge_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorNearChainEdge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E102 RID: 123138 RVA: 0x0087F7C3 File Offset: 0x0087D9C3
	protected __TsDecoratorNearChainEdge_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

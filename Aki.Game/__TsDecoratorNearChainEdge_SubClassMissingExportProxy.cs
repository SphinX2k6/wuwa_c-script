using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B4A RID: 11082
public class __TsDecoratorNearChainEdge_SubClassMissingExportProxy : __TsDecoratorNearChainEdge_InheritProxy
{
	// Token: 0x0601BE29 RID: 114217 RVA: 0x008A7824 File Offset: 0x008A5A24
	[NullableContext(1)]
	protected __TsDecoratorNearChainEdge_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorNearChainEdge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE2A RID: 114218 RVA: 0x008A7857 File Offset: 0x008A5A57
	protected __TsDecoratorNearChainEdge_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

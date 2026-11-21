using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B38 RID: 11064
public class __TsDecoratorDistance_SubClassMissingExportProxy : __TsDecoratorDistance_InheritProxy
{
	// Token: 0x0601BDFC RID: 114172 RVA: 0x008A7218 File Offset: 0x008A5418
	[NullableContext(1)]
	protected __TsDecoratorDistance_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDFD RID: 114173 RVA: 0x008A724B File Offset: 0x008A544B
	protected __TsDecoratorDistance_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

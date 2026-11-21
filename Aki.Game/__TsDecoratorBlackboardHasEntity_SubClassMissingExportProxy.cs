using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B18 RID: 11032
public class __TsDecoratorBlackboardHasEntity_SubClassMissingExportProxy : __TsDecoratorBlackboardHasEntity_InheritProxy
{
	// Token: 0x0601BDAA RID: 114090 RVA: 0x008A66EC File Offset: 0x008A48EC
	[NullableContext(1)]
	protected __TsDecoratorBlackboardHasEntity_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardHasEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDAB RID: 114091 RVA: 0x008A671F File Offset: 0x008A491F
	protected __TsDecoratorBlackboardHasEntity_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

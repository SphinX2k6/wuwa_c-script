using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035E3 RID: 13795
public class __TsDecoratorTagCount_SubClassMissingExportProxy : __TsDecoratorTagCount_InheritProxy
{
	// Token: 0x0601E124 RID: 123172 RVA: 0x0087FC44 File Offset: 0x0087DE44
	[NullableContext(1)]
	protected __TsDecoratorTagCount_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTagCount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E125 RID: 123173 RVA: 0x0087FC77 File Offset: 0x0087DE77
	protected __TsDecoratorTagCount_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

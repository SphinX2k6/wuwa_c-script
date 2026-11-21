using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B04 RID: 11012
public class __TsDecoratorTimeSpanCheck_SubClassMissingExportProxy : __TsDecoratorTimeSpanCheck_InheritProxy
{
	// Token: 0x0601BD78 RID: 114040 RVA: 0x008A6034 File Offset: 0x008A4234
	[NullableContext(1)]
	protected __TsDecoratorTimeSpanCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTimeSpanCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD79 RID: 114041 RVA: 0x008A6067 File Offset: 0x008A4267
	protected __TsDecoratorTimeSpanCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

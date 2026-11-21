using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B34 RID: 11060
public class __TsDecoratorCoolDown_SubClassMissingExportProxy : __TsDecoratorCoolDown_InheritProxy
{
	// Token: 0x0601BDF2 RID: 114162 RVA: 0x008A70C0 File Offset: 0x008A52C0
	[NullableContext(1)]
	protected __TsDecoratorCoolDown_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCoolDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDF3 RID: 114163 RVA: 0x008A70F3 File Offset: 0x008A52F3
	protected __TsDecoratorCoolDown_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

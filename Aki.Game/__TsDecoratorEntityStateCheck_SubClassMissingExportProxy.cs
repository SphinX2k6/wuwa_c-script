using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003587 RID: 13703
public class __TsDecoratorEntityStateCheck_SubClassMissingExportProxy : __TsDecoratorEntityStateCheck_InheritProxy
{
	// Token: 0x0601E03C RID: 122940 RVA: 0x0087DCF0 File Offset: 0x0087BEF0
	[NullableContext(1)]
	protected __TsDecoratorEntityStateCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorEntityStateCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E03D RID: 122941 RVA: 0x0087DD23 File Offset: 0x0087BF23
	protected __TsDecoratorEntityStateCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

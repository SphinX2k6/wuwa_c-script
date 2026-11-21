using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002AFC RID: 11004
public class __TsDecoratorEntityStateCheck_SubClassMissingExportProxy : __TsDecoratorEntityStateCheck_InheritProxy
{
	// Token: 0x0601BD64 RID: 114020 RVA: 0x008A5D84 File Offset: 0x008A3F84
	[NullableContext(1)]
	protected __TsDecoratorEntityStateCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorEntityStateCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD65 RID: 114021 RVA: 0x008A5DB7 File Offset: 0x008A3FB7
	protected __TsDecoratorEntityStateCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A1 RID: 14753
public class __EffectModelPostProcess_SubClassMissingExportProxy : __EffectModelPostProcess_InheritProxy
{
	// Token: 0x0601EE27 RID: 126503 RVA: 0x008A03F4 File Offset: 0x0089E5F4
	[NullableContext(1)]
	protected __EffectModelPostProcess_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelPostProcess.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE28 RID: 126504 RVA: 0x008A0427 File Offset: 0x0089E627
	protected __EffectModelPostProcess_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

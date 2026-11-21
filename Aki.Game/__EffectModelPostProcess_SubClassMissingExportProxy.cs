using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F1C RID: 12060
public class __EffectModelPostProcess_SubClassMissingExportProxy : __EffectModelPostProcess_InheritProxy
{
	// Token: 0x0601CA54 RID: 117332 RVA: 0x008C02B0 File Offset: 0x008BE4B0
	[NullableContext(1)]
	protected __EffectModelPostProcess_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelPostProcess.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA55 RID: 117333 RVA: 0x008C02E3 File Offset: 0x008BE4E3
	protected __EffectModelPostProcess_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F2A RID: 12074
public class __NiagaraScalabilitySetting_SubClassMissingExportProxy : __NiagaraScalabilitySetting_InheritProxy
{
	// Token: 0x0601CA70 RID: 117360 RVA: 0x008C05F8 File Offset: 0x008BE7F8
	[NullableContext(1)]
	protected __NiagaraScalabilitySetting_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NiagaraScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA71 RID: 117361 RVA: 0x008C062B File Offset: 0x008BE82B
	protected __NiagaraScalabilitySetting_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

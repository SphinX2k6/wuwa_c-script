using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F29 RID: 12073
public class __NiagaraScalabilitySetting_InheritProxy : NiagaraScalabilitySetting
{
	// Token: 0x0601CA6E RID: 117358 RVA: 0x008C05BC File Offset: 0x008BE7BC
	[NullableContext(1)]
	public __NiagaraScalabilitySetting_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NiagaraScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA6F RID: 117359 RVA: 0x008C05EF File Offset: 0x008BE7EF
	protected __NiagaraScalabilitySetting_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

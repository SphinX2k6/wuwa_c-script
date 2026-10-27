using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039AE RID: 14766
public class __NiagaraScalabilitySetting_InheritProxy : NiagaraScalabilitySetting
{
	// Token: 0x0601EE41 RID: 126529 RVA: 0x008A0700 File Offset: 0x0089E900
	[NullableContext(1)]
	public __NiagaraScalabilitySetting_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NiagaraScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE42 RID: 126530 RVA: 0x008A0733 File Offset: 0x0089E933
	protected __NiagaraScalabilitySetting_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

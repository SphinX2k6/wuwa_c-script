using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039AF RID: 14767
public class __NiagaraScalabilitySetting_SubClassMissingExportProxy : __NiagaraScalabilitySetting_InheritProxy
{
	// Token: 0x0601EE43 RID: 126531 RVA: 0x008A073C File Offset: 0x0089E93C
	[NullableContext(1)]
	protected __NiagaraScalabilitySetting_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NiagaraScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE44 RID: 126532 RVA: 0x008A076F File Offset: 0x0089E96F
	protected __NiagaraScalabilitySetting_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

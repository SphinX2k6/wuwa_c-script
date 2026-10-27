using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003993 RID: 14739
public class __EffectModelGhost_SubClassMissingExportProxy : __EffectModelGhost_InheritProxy
{
	// Token: 0x0601EE0B RID: 126475 RVA: 0x008A00AC File Offset: 0x0089E2AC
	[NullableContext(1)]
	protected __EffectModelGhost_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE0C RID: 126476 RVA: 0x008A00DF File Offset: 0x0089E2DF
	protected __EffectModelGhost_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

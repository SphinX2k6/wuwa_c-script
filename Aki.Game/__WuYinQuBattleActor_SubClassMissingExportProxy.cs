using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EE2 RID: 12002
public class __WuYinQuBattleActor_SubClassMissingExportProxy : __WuYinQuBattleActor_InheritProxy
{
	// Token: 0x0601C97D RID: 117117 RVA: 0x008BE880 File Offset: 0x008BCA80
	[NullableContext(1)]
	protected __WuYinQuBattleActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WuYinQuBattleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C97E RID: 117118 RVA: 0x008BE8B3 File Offset: 0x008BCAB3
	protected __WuYinQuBattleActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}

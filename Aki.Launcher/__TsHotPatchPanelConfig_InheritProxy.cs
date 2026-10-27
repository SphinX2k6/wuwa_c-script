using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02000015 RID: 21
public class __TsHotPatchPanelConfig_InheritProxy : TsHotPatchPanelConfig
{
	// Token: 0x060000B7 RID: 183 RVA: 0x0000749C File Offset: 0x0000569C
	[NullableContext(1)]
	public __TsHotPatchPanelConfig_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHotPatchPanelConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000074CF File Offset: 0x000056CF
	protected __TsHotPatchPanelConfig_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x000074D8 File Offset: 0x000056D8
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x060000BA RID: 186 RVA: 0x000074E0 File Offset: 0x000056E0
	protected override void __CPPCALL_OnEnableBP_Implementation()
	{
		base.OnEnableBP_Implementation();
	}

	// Token: 0x060000BB RID: 187 RVA: 0x000074E8 File Offset: 0x000056E8
	protected override void __CPPCALL_OnDisableBP_Implementation()
	{
		base.OnDisableBP_Implementation();
	}
}

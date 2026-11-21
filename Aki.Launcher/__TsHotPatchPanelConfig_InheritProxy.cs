using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02000015 RID: 21
public class __TsHotPatchPanelConfig_InheritProxy : TsHotPatchPanelConfig
{
	// Token: 0x060000B7 RID: 183 RVA: 0x000074D4 File Offset: 0x000056D4
	[NullableContext(1)]
	public __TsHotPatchPanelConfig_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHotPatchPanelConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00007507 File Offset: 0x00005707
	protected __TsHotPatchPanelConfig_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00007510 File Offset: 0x00005710
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00007518 File Offset: 0x00005718
	protected override void __CPPCALL_OnEnableBP_Implementation()
	{
		base.OnEnableBP_Implementation();
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00007520 File Offset: 0x00005720
	protected override void __CPPCALL_OnDisableBP_Implementation()
	{
		base.OnDisableBP_Implementation();
	}
}

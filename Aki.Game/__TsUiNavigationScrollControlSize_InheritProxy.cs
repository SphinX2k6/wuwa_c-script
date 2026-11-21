using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E5F RID: 11871
public class __TsUiNavigationScrollControlSize_InheritProxy : TsUiNavigationScrollControlSize
{
	// Token: 0x0601C7F8 RID: 116728 RVA: 0x008BC130 File Offset: 0x008BA330
	[NullableContext(1)]
	public __TsUiNavigationScrollControlSize_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationScrollControlSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7F9 RID: 116729 RVA: 0x008BC163 File Offset: 0x008BA363
	protected __TsUiNavigationScrollControlSize_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C7FA RID: 116730 RVA: 0x008BC16C File Offset: 0x008BA36C
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x0601C7FB RID: 116731 RVA: 0x008BC174 File Offset: 0x008BA374
	protected unsafe override void __CPPCALL_LateUpdateBP_Implementation(ULGUIBehaviour.__LateUpdateBP_FunctionParams* __Params)
	{
		base.LateUpdateBP_Implementation(__Params->DeltaTime);
	}

	// Token: 0x0601C7FC RID: 116732 RVA: 0x008BC182 File Offset: 0x008BA382
	protected override void __CPPCALL_OnDisableBP_Implementation()
	{
		base.OnDisableBP_Implementation();
	}
}

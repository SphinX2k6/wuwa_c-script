using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200391C RID: 14620
public class __TsCharacterDebugComponent_InheritProxy : TsCharacterDebugComponent
{
	// Token: 0x0601EBB0 RID: 125872 RVA: 0x00898988 File Offset: 0x00896B88
	[NullableContext(1)]
	public __TsCharacterDebugComponent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterDebugComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBB1 RID: 125873 RVA: 0x008989BB File Offset: 0x00896BBB
	protected __TsCharacterDebugComponent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EBB2 RID: 125874 RVA: 0x008989C4 File Offset: 0x00896BC4
	protected unsafe override void __CPPCALL_SetMovementDebug_Implementation(TsCharacterDebugComponent.__SetMovementDebug_FunctionParams* __Params)
	{
		base.SetMovementDebug_Implementation(__Params->newDebug);
	}

	// Token: 0x0601EBB3 RID: 125875 RVA: 0x008989D2 File Offset: 0x00896BD2
	protected override void __CPPCALL_ChangeEnterClimbTrace_Implementation()
	{
		base.ChangeEnterClimbTrace_Implementation();
	}

	// Token: 0x0601EBB4 RID: 125876 RVA: 0x008989DA File Offset: 0x00896BDA
	protected override void __CPPCALL_ChangeVaultClimbTrace_Implementation()
	{
		base.ChangeVaultClimbTrace_Implementation();
	}

	// Token: 0x0601EBB5 RID: 125877 RVA: 0x008989E2 File Offset: 0x00896BE2
	protected override void __CPPCALL_ChangeUpArriveClimbTrace_Implementation()
	{
		base.ChangeUpArriveClimbTrace_Implementation();
	}

	// Token: 0x0601EBB6 RID: 125878 RVA: 0x008989EA File Offset: 0x00896BEA
	protected override void __CPPCALL_ChangeClimbingTrace_Implementation()
	{
		base.ChangeClimbingTrace_Implementation();
	}

	// Token: 0x0601EBB7 RID: 125879 RVA: 0x008989F2 File Offset: 0x00896BF2
	protected override void __CPPCALL_ChangeNoTop_Implementation()
	{
		base.ChangeNoTop_Implementation();
	}

	// Token: 0x0601EBB8 RID: 125880 RVA: 0x008989FA File Offset: 0x00896BFA
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EBB9 RID: 125881 RVA: 0x00898A02 File Offset: 0x00896C02
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(UActorComponent.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601EBBA RID: 125882 RVA: 0x00898A10 File Offset: 0x00896C10
	protected unsafe override void __CPPCALL_ActivateDebugSpeed_Implementation(TsCharacterDebugComponent.__ActivateDebugSpeed_FunctionParams* __Params)
	{
		base.ActivateDebugSpeed_Implementation(__Params->activate);
	}

	// Token: 0x0601EBBB RID: 125883 RVA: 0x00898A1E File Offset: 0x00896C1E
	protected override void __CPPCALL_DebugDrawActivateArea_Implementation()
	{
		base.DebugDrawActivateArea_Implementation();
	}

	// Token: 0x0601EBBC RID: 125884 RVA: 0x00898A26 File Offset: 0x00896C26
	protected unsafe override void __CPPCALL_SetDebugRiseEnable_Implementation(TsCharacterDebugComponent.__SetDebugRiseEnable_FunctionParams* __Params)
	{
		base.SetDebugRiseEnable_Implementation(__Params->enable);
	}

	// Token: 0x0601EBBD RID: 125885 RVA: 0x00898A34 File Offset: 0x00896C34
	protected override void __CPPCALL_DrawDebugPatrolPoints_Implementation()
	{
		base.DrawDebugPatrolPoints_Implementation();
	}

	// Token: 0x0601EBBE RID: 125886 RVA: 0x00898A3C File Offset: 0x00896C3C
	protected override void __CPPCALL_DrawErrorNavigationPaths_Implementation()
	{
		base.DrawErrorNavigationPaths_Implementation();
	}
}

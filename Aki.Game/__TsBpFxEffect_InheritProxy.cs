using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002ED9 RID: 11993
public class __TsBpFxEffect_InheritProxy : TsBpFxEffect
{
	// Token: 0x0601C933 RID: 117043 RVA: 0x008BE36C File Offset: 0x008BC56C
	[NullableContext(1)]
	public __TsBpFxEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBpFxEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C934 RID: 117044 RVA: 0x008BE39F File Offset: 0x008BC59F
	protected __TsBpFxEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C935 RID: 117045 RVA: 0x008BE3A8 File Offset: 0x008BC5A8
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C936 RID: 117046 RVA: 0x008BE3B0 File Offset: 0x008BC5B0
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(TsBpFxEffect.__ReceiveEndPlay_FunctionParams* __Params)
	{
		base.ReceiveEndPlay_Implementation(__Params->endPlayReason);
	}

	// Token: 0x0601C937 RID: 117047 RVA: 0x008BE3BE File Offset: 0x008BC5BE
	protected override void __CPPCALL_TryRecord_Implementation()
	{
		base.TryRecord_Implementation();
	}

	// Token: 0x0601C938 RID: 117048 RVA: 0x008BE3C6 File Offset: 0x008BC5C6
	protected unsafe override void __CPPCALL_AddAutoFloatTrack_Implementation(TsBpFxEffect.__AddAutoFloatTrack_FunctionParams* __Params)
	{
		base.AddAutoFloatTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601C939 RID: 117049 RVA: 0x008BE3D4 File Offset: 0x008BC5D4
	protected unsafe override void __CPPCALL_AddAutoVectorTrack_Implementation(TsBpFxEffect.__AddAutoVectorTrack_FunctionParams* __Params)
	{
		base.AddAutoVectorTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601C93A RID: 117050 RVA: 0x008BE3E2 File Offset: 0x008BC5E2
	protected unsafe override void __CPPCALL_AddAutoObjectTrack_Implementation(TsBpFxEffect.__AddAutoObjectTrack_FunctionParams* __Params)
	{
		base.AddAutoObjectTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601C93B RID: 117051 RVA: 0x008BE3F0 File Offset: 0x008BC5F0
	protected override void __CPPCALL_OnRecordStart_Implementation()
	{
		base.OnRecordStart_Implementation();
	}

	// Token: 0x0601C93C RID: 117052 RVA: 0x008BE3F8 File Offset: 0x008BC5F8
	protected unsafe override void __CPPCALL_OnRecordTick_Implementation(TsBpFxEffect.__OnRecordTick_FunctionParams* __Params)
	{
		base.OnRecordTick_Implementation(__Params->deltaSeconds);
	}

	// Token: 0x0601C93D RID: 117053 RVA: 0x008BE406 File Offset: 0x008BC606
	protected override void __CPPCALL_OnRecordStop_Implementation()
	{
		base.OnRecordStop_Implementation();
	}
}

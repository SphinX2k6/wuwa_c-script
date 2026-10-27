using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200395E RID: 14686
public class __TsBpFxEffect_InheritProxy : TsBpFxEffect
{
	// Token: 0x0601ECA2 RID: 126114 RVA: 0x0089B350 File Offset: 0x00899550
	[NullableContext(1)]
	public __TsBpFxEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBpFxEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ECA3 RID: 126115 RVA: 0x0089B383 File Offset: 0x00899583
	protected __TsBpFxEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ECA4 RID: 126116 RVA: 0x0089B38C File Offset: 0x0089958C
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601ECA5 RID: 126117 RVA: 0x0089B394 File Offset: 0x00899594
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(TsBpFxEffect.__ReceiveEndPlay_FunctionParams* __Params)
	{
		base.ReceiveEndPlay_Implementation(__Params->endPlayReason);
	}

	// Token: 0x0601ECA6 RID: 126118 RVA: 0x0089B3A2 File Offset: 0x008995A2
	protected override void __CPPCALL_TryRecord_Implementation()
	{
		base.TryRecord_Implementation();
	}

	// Token: 0x0601ECA7 RID: 126119 RVA: 0x0089B3AA File Offset: 0x008995AA
	protected unsafe override void __CPPCALL_AddAutoFloatTrack_Implementation(TsBpFxEffect.__AddAutoFloatTrack_FunctionParams* __Params)
	{
		base.AddAutoFloatTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601ECA8 RID: 126120 RVA: 0x0089B3B8 File Offset: 0x008995B8
	protected unsafe override void __CPPCALL_AddAutoVectorTrack_Implementation(TsBpFxEffect.__AddAutoVectorTrack_FunctionParams* __Params)
	{
		base.AddAutoVectorTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601ECA9 RID: 126121 RVA: 0x0089B3C6 File Offset: 0x008995C6
	protected unsafe override void __CPPCALL_AddAutoObjectTrack_Implementation(TsBpFxEffect.__AddAutoObjectTrack_FunctionParams* __Params)
	{
		base.AddAutoObjectTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601ECAA RID: 126122 RVA: 0x0089B3D4 File Offset: 0x008995D4
	protected override void __CPPCALL_OnRecordStart_Implementation()
	{
		base.OnRecordStart_Implementation();
	}

	// Token: 0x0601ECAB RID: 126123 RVA: 0x0089B3DC File Offset: 0x008995DC
	protected unsafe override void __CPPCALL_OnRecordTick_Implementation(TsBpFxEffect.__OnRecordTick_FunctionParams* __Params)
	{
		base.OnRecordTick_Implementation(__Params->deltaSeconds);
	}

	// Token: 0x0601ECAC RID: 126124 RVA: 0x0089B3EA File Offset: 0x008995EA
	protected override void __CPPCALL_OnRecordStop_Implementation()
	{
		base.OnRecordStop_Implementation();
	}
}

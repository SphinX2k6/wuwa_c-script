using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.AnimNotifyInteraction.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200012D RID: 301
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEffectTrig.TsAnimNotifyStateEffectTrig_C")]
public class TsAnimNotifyStateEffectTrig : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700030F RID: 783
	// (get) Token: 0x06001286 RID: 4742 RVA: 0x0006897B File Offset: 0x00066B7B
	// (set) Token: 0x06001287 RID: 4743 RVA: 0x0006898B File Offset: 0x00066B8B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int AteIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_AteIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_AteIndex) = value;
		}
	}

	// Token: 0x17000310 RID: 784
	// (get) Token: 0x06001288 RID: 4744 RVA: 0x0006899C File Offset: 0x00066B9C
	// (set) Token: 0x06001289 RID: 4745 RVA: 0x000689AC File Offset: 0x00066BAC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EEffectAction 攻击类型
	{
		get
		{
			return (EEffectAction)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_攻击类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_攻击类型) = (byte)value;
		}
	}

	// Token: 0x17000311 RID: 785
	// (get) Token: 0x0600128A RID: 4746 RVA: 0x000689BD File Offset: 0x00066BBD
	// (set) Token: 0x0600128B RID: 4747 RVA: 0x000689CD File Offset: 0x00066BCD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 攻击半径
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_攻击半径);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_攻击半径) = value;
		}
	}

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x0600128C RID: 4748 RVA: 0x000689DE File Offset: 0x00066BDE
	// (set) Token: 0x0600128D RID: 4749 RVA: 0x000689EE File Offset: 0x00066BEE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 攻击强度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_攻击强度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_攻击强度) = value;
		}
	}

	// Token: 0x17000313 RID: 787
	// (get) Token: 0x0600128E RID: 4750 RVA: 0x000689FF File Offset: 0x00066BFF
	// (set) Token: 0x0600128F RID: 4751 RVA: 0x00068A0F File Offset: 0x00066C0F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 纹理高度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_纹理高度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_纹理高度) = value;
		}
	}

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x06001290 RID: 4752 RVA: 0x00068A20 File Offset: 0x00066C20
	// (set) Token: 0x06001291 RID: 4753 RVA: 0x00068A34 File Offset: 0x00066C34
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector 特效节点Location
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_特效节点Location);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEffectTrig.__PropertyOffset_特效节点Location) = value;
		}
	}

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x06001292 RID: 4754 RVA: 0x00068A49 File Offset: 0x00066C49
	// (set) Token: 0x06001293 RID: 4755 RVA: 0x00068A5D File Offset: 0x00066C5D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UMaterialParameterCollection AteMPC
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateEffectTrig.__PropertyOffset_AteMPC);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateEffectTrig.__PropertyOffset_AteMPC, value);
		}
	}

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x06001294 RID: 4756 RVA: 0x00068A72 File Offset: 0x00066C72
	// (set) Token: 0x06001295 RID: 4757 RVA: 0x00068A86 File Offset: 0x00066C86
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat CurveFloat
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateEffectTrig.__PropertyOffset_CurveFloat);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateEffectTrig.__PropertyOffset_CurveFloat, value);
		}
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x00068A9C File Offset: 0x00066C9C
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.NotifyTotalDuration = totalDuration;
		this.ElapsedTime = 0f;
		if (!(meshComp.GetOwner() is ACharacter))
		{
			Log.Instance.Warn(ELogModule.RenderEffect, ELogAuthor.ZJL, "TsAnimNotifyEffectTrig Owner非Character", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (this.AteMPC == null)
		{
			Log.Instance.Warn(ELogModule.RenderEffect, ELogAuthor.ZJL, "TsAnimNotifyEffectTrig 未配置 MPC", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (!EffectTriggerMaterialParameterRegistry.IsValidActionAndIndex(this.攻击类型, this.AteIndex))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.ZJL;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 2);
			defaultInterpolatedStringHandler.AppendLiteral("TsAnimNotifyEffectTrig 攻击类型或AteIndex无效 攻击类型=");
			defaultInterpolatedStringHandler.AppendFormatted<EEffectAction>(this.攻击类型);
			defaultInterpolatedStringHandler.AppendLiteral(" AteIndex=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.AteIndex);
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.AteMPC, EffectTriggerMaterialParameterRegistry.GetTriggerParameterName(this.攻击类型, this.AteIndex), UGameplayStatics.GetRealTimeSeconds(GlobalData.World));
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.AteMPC, EffectTriggerMaterialParameterRegistry.GetDurationParameterName(this.攻击类型, this.AteIndex), totalDuration);
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.AteMPC, EffectTriggerMaterialParameterRegistry.GetAttackRadiusParameterName(this.攻击类型, this.AteIndex), this.攻击半径);
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.AteMPC, EffectTriggerMaterialParameterRegistry.GetAttackMagnitudeParameterName(this.攻击类型, this.AteIndex), this.攻击强度);
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.AteMPC, EffectTriggerMaterialParameterRegistry.GetTextureHeightParameterName(this.攻击类型, this.AteIndex), this.纹理高度);
		Vector tempVectorDouble = this.TempVectorDouble;
		FVector 特效节点Location = this.特效节点Location;
		tempVectorDouble.FromUeVector(特效节点Location);
		FTransformDouble ftransformDouble = meshComp.D_K2_GetComponentToWorld();
		Vector tempVector = this.TempVector;
		FVectorDouble fvectorDouble = this.TempVectorDouble.ToUeVector(false);
		FVectorDouble fvectorDouble2 = ftransformDouble.TransformPosition(fvectorDouble);
		tempVector.FromUeVector(fvectorDouble2);
		UObject world = GlobalData.World;
		UMaterialParameterCollection ateMPC = this.AteMPC;
		FName actorLocationParameterName = EffectTriggerMaterialParameterRegistry.GetActorLocationParameterName(this.攻击类型, this.AteIndex);
		FLinearColor flinearColor = UKismetMathLibrary.Conv_VectorDoubleToLinearColor(this.TempVector.ToUeVector(false));
		UKismetMaterialLibrary.SetVectorParameterValue(world, ateMPC, actorLocationParameterName, flinearColor);
		return true;
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x00068CB8 File Offset: 0x00066EB8
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if (this.AteMPC == null || this.CurveFloat == null)
		{
			return false;
		}
		this.ElapsedTime += frameDeltaTime;
		float inTime = (this.NotifyTotalDuration > 0f) ? Math.Min(this.ElapsedTime / this.NotifyTotalDuration, 1f) : 0f;
		float floatValue = this.CurveFloat.GetFloatValue(inTime);
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.AteMPC, EffectTriggerMaterialParameterRegistry.GetCurveFloatParameterName(this.攻击类型, this.AteIndex), floatValue);
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.AteMPC, EffectTriggerMaterialParameterRegistry.GetElapsedTimeParameterName(this.攻击类型, this.AteIndex), this.ElapsedTime);
		return true;
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00068D68 File Offset: 0x00066F68
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		this.ElapsedTime = 0f;
		this.NotifyTotalDuration = 0f;
		return true;
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00068D81 File Offset: 0x00066F81
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "触发特效ANS";
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00068D88 File Offset: 0x00066F88
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateEffectTrig._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEffectTrig.TsAnimNotifyStateEffectTrig_C");
		}
		return TsAnimNotifyStateEffectTrig._ClassPtr;
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00068DAC File Offset: 0x00066FAC
	public TsAnimNotifyStateEffectTrig() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEffectTrig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x00068DD4 File Offset: 0x00066FD4
	[NullableContext(1)]
	public TsAnimNotifyStateEffectTrig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEffectTrig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x00068E07 File Offset: 0x00067007
	protected TsAnimNotifyStateEffectTrig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x00068E28 File Offset: 0x00067028
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x00068E64 File Offset: 0x00067064
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x00068EA0 File Offset: 0x000670A0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x00068ED3 File Offset: 0x000670D3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04000DBE RID: 3518
	[Nullable(1)]
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x04000DBF RID: 3519
	[Nullable(1)]
	private readonly Vector TempVectorDouble = Vector.Create();

	// Token: 0x04000DC0 RID: 3520
	private float NotifyTotalDuration;

	// Token: 0x04000DC1 RID: 3521
	private float ElapsedTime;

	// Token: 0x04000DC2 RID: 3522
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEffectTrig.TsAnimNotifyStateEffectTrig_C";

	// Token: 0x04000DC3 RID: 3523
	private static IntPtr _ClassPtr;

	// Token: 0x04000DC4 RID: 3524
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000DC5 RID: 3525
	private static int __PropertyOffset_AteIndex;

	// Token: 0x04000DC6 RID: 3526
	private static int __PropertyOffset_攻击类型;

	// Token: 0x04000DC7 RID: 3527
	private static int __PropertyOffset_攻击半径;

	// Token: 0x04000DC8 RID: 3528
	private static int __PropertyOffset_攻击强度;

	// Token: 0x04000DC9 RID: 3529
	private static int __PropertyOffset_纹理高度;

	// Token: 0x04000DCA RID: 3530
	private static int __PropertyOffset_特效节点Location;

	// Token: 0x04000DCB RID: 3531
	private static int __PropertyOffset_AteMPC;

	// Token: 0x04000DCC RID: 3532
	private static int __PropertyOffset_CurveFloat;
}

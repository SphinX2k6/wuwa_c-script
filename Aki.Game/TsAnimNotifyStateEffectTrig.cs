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
	// Token: 0x17000312 RID: 786
	// (get) Token: 0x0600128C RID: 4748 RVA: 0x0006A28B File Offset: 0x0006848B
	// (set) Token: 0x0600128D RID: 4749 RVA: 0x0006A29B File Offset: 0x0006849B
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

	// Token: 0x17000313 RID: 787
	// (get) Token: 0x0600128E RID: 4750 RVA: 0x0006A2AC File Offset: 0x000684AC
	// (set) Token: 0x0600128F RID: 4751 RVA: 0x0006A2BC File Offset: 0x000684BC
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

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x06001290 RID: 4752 RVA: 0x0006A2CD File Offset: 0x000684CD
	// (set) Token: 0x06001291 RID: 4753 RVA: 0x0006A2DD File Offset: 0x000684DD
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

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x06001292 RID: 4754 RVA: 0x0006A2EE File Offset: 0x000684EE
	// (set) Token: 0x06001293 RID: 4755 RVA: 0x0006A2FE File Offset: 0x000684FE
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

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x06001294 RID: 4756 RVA: 0x0006A30F File Offset: 0x0006850F
	// (set) Token: 0x06001295 RID: 4757 RVA: 0x0006A31F File Offset: 0x0006851F
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

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x06001296 RID: 4758 RVA: 0x0006A330 File Offset: 0x00068530
	// (set) Token: 0x06001297 RID: 4759 RVA: 0x0006A344 File Offset: 0x00068544
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

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x06001298 RID: 4760 RVA: 0x0006A359 File Offset: 0x00068559
	// (set) Token: 0x06001299 RID: 4761 RVA: 0x0006A36D File Offset: 0x0006856D
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

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x0600129A RID: 4762 RVA: 0x0006A382 File Offset: 0x00068582
	// (set) Token: 0x0600129B RID: 4763 RVA: 0x0006A396 File Offset: 0x00068596
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

	// Token: 0x0600129C RID: 4764 RVA: 0x0006A3AC File Offset: 0x000685AC
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

	// Token: 0x0600129D RID: 4765 RVA: 0x0006A5C8 File Offset: 0x000687C8
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

	// Token: 0x0600129E RID: 4766 RVA: 0x0006A678 File Offset: 0x00068878
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		this.ElapsedTime = 0f;
		this.NotifyTotalDuration = 0f;
		return true;
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x0006A691 File Offset: 0x00068891
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "触发特效ANS";
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x0006A698 File Offset: 0x00068898
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateEffectTrig._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEffectTrig.TsAnimNotifyStateEffectTrig_C");
		}
		return TsAnimNotifyStateEffectTrig._ClassPtr;
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x0006A6BC File Offset: 0x000688BC
	public TsAnimNotifyStateEffectTrig() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEffectTrig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x0006A6E4 File Offset: 0x000688E4
	[NullableContext(1)]
	public TsAnimNotifyStateEffectTrig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEffectTrig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x0006A717 File Offset: 0x00068917
	protected TsAnimNotifyStateEffectTrig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x0006A738 File Offset: 0x00068938
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x0006A774 File Offset: 0x00068974
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x0006A7B0 File Offset: 0x000689B0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x0006A7E3 File Offset: 0x000689E3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04000DC6 RID: 3526
	[Nullable(1)]
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x04000DC7 RID: 3527
	[Nullable(1)]
	private readonly Vector TempVectorDouble = Vector.Create();

	// Token: 0x04000DC8 RID: 3528
	private float NotifyTotalDuration;

	// Token: 0x04000DC9 RID: 3529
	private float ElapsedTime;

	// Token: 0x04000DCA RID: 3530
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEffectTrig.TsAnimNotifyStateEffectTrig_C";

	// Token: 0x04000DCB RID: 3531
	private static IntPtr _ClassPtr;

	// Token: 0x04000DCC RID: 3532
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000DCD RID: 3533
	private static int __PropertyOffset_AteIndex;

	// Token: 0x04000DCE RID: 3534
	private static int __PropertyOffset_攻击类型;

	// Token: 0x04000DCF RID: 3535
	private static int __PropertyOffset_攻击半径;

	// Token: 0x04000DD0 RID: 3536
	private static int __PropertyOffset_攻击强度;

	// Token: 0x04000DD1 RID: 3537
	private static int __PropertyOffset_纹理高度;

	// Token: 0x04000DD2 RID: 3538
	private static int __PropertyOffset_特效节点Location;

	// Token: 0x04000DD3 RID: 3539
	private static int __PropertyOffset_AteMPC;

	// Token: 0x04000DD4 RID: 3540
	private static int __PropertyOffset_CurveFloat;
}

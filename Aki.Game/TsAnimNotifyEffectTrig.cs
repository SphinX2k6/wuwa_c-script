using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.AnimNotifyInteraction.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B3 RID: 435
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEffectTrig.TsAnimNotifyEffectTrig_C")]
public class TsAnimNotifyEffectTrig : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000468 RID: 1128
	// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0008D393 File Offset: 0x0008B593
	// (set) Token: 0x06001B62 RID: 7010 RVA: 0x0008D3A3 File Offset: 0x0008B5A3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int AteIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_AteIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_AteIndex) = value;
		}
	}

	// Token: 0x17000469 RID: 1129
	// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0008D3B4 File Offset: 0x0008B5B4
	// (set) Token: 0x06001B64 RID: 7012 RVA: 0x0008D3C4 File Offset: 0x0008B5C4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EEffectAction 攻击类型
	{
		get
		{
			return (EEffectAction)(*(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_攻击类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_攻击类型) = (byte)value;
		}
	}

	// Token: 0x1700046A RID: 1130
	// (get) Token: 0x06001B65 RID: 7013 RVA: 0x0008D3D5 File Offset: 0x0008B5D5
	// (set) Token: 0x06001B66 RID: 7014 RVA: 0x0008D3E5 File Offset: 0x0008B5E5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 攻击半径
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_攻击半径);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_攻击半径) = value;
		}
	}

	// Token: 0x1700046B RID: 1131
	// (get) Token: 0x06001B67 RID: 7015 RVA: 0x0008D3F6 File Offset: 0x0008B5F6
	// (set) Token: 0x06001B68 RID: 7016 RVA: 0x0008D406 File Offset: 0x0008B606
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 攻击强度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_攻击强度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_攻击强度) = value;
		}
	}

	// Token: 0x1700046C RID: 1132
	// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0008D417 File Offset: 0x0008B617
	// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0008D427 File Offset: 0x0008B627
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 持续时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_持续时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_持续时间) = value;
		}
	}

	// Token: 0x1700046D RID: 1133
	// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0008D438 File Offset: 0x0008B638
	// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0008D448 File Offset: 0x0008B648
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 纹理高度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_纹理高度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_纹理高度) = value;
		}
	}

	// Token: 0x1700046E RID: 1134
	// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0008D459 File Offset: 0x0008B659
	// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0008D46D File Offset: 0x0008B66D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector 特效节点Location
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_特效节点Location);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyEffectTrig.__PropertyOffset_特效节点Location) = value;
		}
	}

	// Token: 0x1700046F RID: 1135
	// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0008D482 File Offset: 0x0008B682
	// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0008D496 File Offset: 0x0008B696
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UMaterialParameterCollection AteMPC
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyEffectTrig.__PropertyOffset_AteMPC);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyEffectTrig.__PropertyOffset_AteMPC, value);
		}
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x0008D4AC File Offset: 0x0008B6AC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
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
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.AteMPC, EffectTriggerMaterialParameterRegistry.GetDurationParameterName(this.攻击类型, this.AteIndex), this.持续时间);
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

	// Token: 0x06001B72 RID: 7026 RVA: 0x0008D6B8 File Offset: 0x0008B8B8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "触发特效";
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x0008D6BF File Offset: 0x0008B8BF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyEffectTrig._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEffectTrig.TsAnimNotifyEffectTrig_C");
		}
		return TsAnimNotifyEffectTrig._ClassPtr;
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x0008D6E4 File Offset: 0x0008B8E4
	public TsAnimNotifyEffectTrig() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEffectTrig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x0008D70C File Offset: 0x0008B90C
	[NullableContext(1)]
	public TsAnimNotifyEffectTrig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEffectTrig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x0008D73F File Offset: 0x0008B93F
	protected TsAnimNotifyEffectTrig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x0008D760 File Offset: 0x0008B960
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x0008D793 File Offset: 0x0008B993
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04001181 RID: 4481
	[Nullable(1)]
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x04001182 RID: 4482
	[Nullable(1)]
	private readonly Vector TempVectorDouble = Vector.Create();

	// Token: 0x04001183 RID: 4483
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEffectTrig.TsAnimNotifyEffectTrig_C";

	// Token: 0x04001184 RID: 4484
	private static IntPtr _ClassPtr;

	// Token: 0x04001185 RID: 4485
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001186 RID: 4486
	private static int __PropertyOffset_AteIndex;

	// Token: 0x04001187 RID: 4487
	private static int __PropertyOffset_攻击类型;

	// Token: 0x04001188 RID: 4488
	private static int __PropertyOffset_攻击半径;

	// Token: 0x04001189 RID: 4489
	private static int __PropertyOffset_攻击强度;

	// Token: 0x0400118A RID: 4490
	private static int __PropertyOffset_持续时间;

	// Token: 0x0400118B RID: 4491
	private static int __PropertyOffset_纹理高度;

	// Token: 0x0400118C RID: 4492
	private static int __PropertyOffset_特效节点Location;

	// Token: 0x0400118D RID: 4493
	private static int __PropertyOffset_AteMPC;
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.AnimNotifyInteraction.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B7 RID: 439
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEffectTrig.TsAnimNotifyEffectTrig_C")]
public class TsAnimNotifyEffectTrig : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700048A RID: 1162
	// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00093C9B File Offset: 0x00091E9B
	// (set) Token: 0x06001BFF RID: 7167 RVA: 0x00093CAB File Offset: 0x00091EAB
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

	// Token: 0x1700048B RID: 1163
	// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00093CBC File Offset: 0x00091EBC
	// (set) Token: 0x06001C01 RID: 7169 RVA: 0x00093CCC File Offset: 0x00091ECC
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

	// Token: 0x1700048C RID: 1164
	// (get) Token: 0x06001C02 RID: 7170 RVA: 0x00093CDD File Offset: 0x00091EDD
	// (set) Token: 0x06001C03 RID: 7171 RVA: 0x00093CED File Offset: 0x00091EED
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

	// Token: 0x1700048D RID: 1165
	// (get) Token: 0x06001C04 RID: 7172 RVA: 0x00093CFE File Offset: 0x00091EFE
	// (set) Token: 0x06001C05 RID: 7173 RVA: 0x00093D0E File Offset: 0x00091F0E
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

	// Token: 0x1700048E RID: 1166
	// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00093D1F File Offset: 0x00091F1F
	// (set) Token: 0x06001C07 RID: 7175 RVA: 0x00093D2F File Offset: 0x00091F2F
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

	// Token: 0x1700048F RID: 1167
	// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00093D40 File Offset: 0x00091F40
	// (set) Token: 0x06001C09 RID: 7177 RVA: 0x00093D50 File Offset: 0x00091F50
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

	// Token: 0x17000490 RID: 1168
	// (get) Token: 0x06001C0A RID: 7178 RVA: 0x00093D61 File Offset: 0x00091F61
	// (set) Token: 0x06001C0B RID: 7179 RVA: 0x00093D75 File Offset: 0x00091F75
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

	// Token: 0x17000491 RID: 1169
	// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00093D8A File Offset: 0x00091F8A
	// (set) Token: 0x06001C0D RID: 7181 RVA: 0x00093D9E File Offset: 0x00091F9E
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

	// Token: 0x06001C0E RID: 7182 RVA: 0x00093DB4 File Offset: 0x00091FB4
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

	// Token: 0x06001C0F RID: 7183 RVA: 0x00093FC0 File Offset: 0x000921C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "触发特效";
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x00093FC7 File Offset: 0x000921C7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyEffectTrig._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEffectTrig.TsAnimNotifyEffectTrig_C");
		}
		return TsAnimNotifyEffectTrig._ClassPtr;
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x00093FEC File Offset: 0x000921EC
	public TsAnimNotifyEffectTrig() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEffectTrig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x00094014 File Offset: 0x00092214
	[NullableContext(1)]
	public TsAnimNotifyEffectTrig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEffectTrig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x00094047 File Offset: 0x00092247
	protected TsAnimNotifyEffectTrig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x00094068 File Offset: 0x00092268
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x0009409B File Offset: 0x0009229B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x040011C4 RID: 4548
	[Nullable(1)]
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x040011C5 RID: 4549
	[Nullable(1)]
	private readonly Vector TempVectorDouble = Vector.Create();

	// Token: 0x040011C6 RID: 4550
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEffectTrig.TsAnimNotifyEffectTrig_C";

	// Token: 0x040011C7 RID: 4551
	private static IntPtr _ClassPtr;

	// Token: 0x040011C8 RID: 4552
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011C9 RID: 4553
	private static int __PropertyOffset_AteIndex;

	// Token: 0x040011CA RID: 4554
	private static int __PropertyOffset_攻击类型;

	// Token: 0x040011CB RID: 4555
	private static int __PropertyOffset_攻击半径;

	// Token: 0x040011CC RID: 4556
	private static int __PropertyOffset_攻击强度;

	// Token: 0x040011CD RID: 4557
	private static int __PropertyOffset_持续时间;

	// Token: 0x040011CE RID: 4558
	private static int __PropertyOffset_纹理高度;

	// Token: 0x040011CF RID: 4559
	private static int __PropertyOffset_特效节点Location;

	// Token: 0x040011D0 RID: 4560
	private static int __PropertyOffset_AteMPC;
}

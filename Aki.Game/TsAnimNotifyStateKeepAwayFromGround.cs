using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000142 RID: 322
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepAwayFromGround.TsAnimNotifyStateKeepAwayFromGround_C")]
public class TsAnimNotifyStateKeepAwayFromGround : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060013AC RID: 5036 RVA: 0x0006E4DD File Offset: 0x0006C6DD
	static TsAnimNotifyStateKeepAwayFromGround()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateKeepAwayFromGround.CreateStaticDefaultValue), new Action(TsAnimNotifyStateKeepAwayFromGround.ResetStaticDefaultValue));
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x0006E4FC File Offset: 0x0006C6FC
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateKeepAwayFromGround.paramsMap = new Dictionary<int, KeepAwayFromGroundParam>();
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x0006E508 File Offset: 0x0006C708
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateKeepAwayFromGround.paramsMap = null;
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x060013AF RID: 5039 RVA: 0x0006E510 File Offset: 0x0006C710
	// (set) Token: 0x060013B0 RID: 5040 RVA: 0x0006E520 File Offset: 0x0006C720
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 距离水平面最小高度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_距离水平面最小高度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_距离水平面最小高度) = value;
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x060013B1 RID: 5041 RVA: 0x0006E531 File Offset: 0x0006C731
	// (set) Token: 0x060013B2 RID: 5042 RVA: 0x0006E541 File Offset: 0x0006C741
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 距离水平面最大高度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_距离水平面最大高度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_距离水平面最大高度) = value;
		}
	}

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0006E552 File Offset: 0x0006C752
	// (set) Token: 0x060013B4 RID: 5044 RVA: 0x0006E566 File Offset: 0x0006C766
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat MoveCurve
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_MoveCurve);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_MoveCurve, value);
		}
	}

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0006E57B File Offset: 0x0006C77B
	// (set) Token: 0x060013B6 RID: 5046 RVA: 0x0006E58B File Offset: 0x0006C78B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_MaxSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_MaxSpeed) = value;
		}
	}

	// Token: 0x17000337 RID: 823
	// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0006E59C File Offset: 0x0006C79C
	// (set) Token: 0x060013B8 RID: 5048 RVA: 0x0006E5AC File Offset: 0x0006C7AC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 不使用默认插值曲线
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_不使用默认插值曲线) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepAwayFromGround.__PropertyOffset_不使用默认插值曲线) = (value ? 1 : 0);
		}
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x0006E5C0 File Offset: 0x0006C7C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x0006E668 File Offset: 0x0006C868
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		this.TsMinHeight = this.距离水平面最小高度;
		this.TsMaxHeight = this.距离水平面最大高度;
		this.TsIgnoreInterpolation = this.不使用默认插值曲线;
		this.TsMaxSpeed = this.MaxSpeed;
		this.TsTmpVector = Vector.Create();
		if (this.TsMaxHeight > 0f && this.TsMaxHeight < this.TsMinHeight)
		{
			Log.Instance.Error(ELogModule.Test, ELogAuthor.HXY, "Z轴帧事件参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (this.TsMaxSpeed <= 0f)
		{
			return false;
		}
		int id = ((TsBaseCharacter)owner).CharacterActorComponent.Entity.Id;
		KeepAwayFromGroundParam keepAwayFromGroundParam = null;
		if (!TsAnimNotifyStateKeepAwayFromGround.paramsMap.TryGetValue(id, out keepAwayFromGroundParam))
		{
			keepAwayFromGroundParam = new KeepAwayFromGroundParam();
			TsAnimNotifyStateKeepAwayFromGround.paramsMap[id] = keepAwayFromGroundParam;
		}
		keepAwayFromGroundParam.NowTime = 0f;
		keepAwayFromGroundParam.TotalTime = totalDuration;
		return true;
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x0006E758 File Offset: 0x0006C958
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x0006E800 File Offset: 0x0006CA00
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if ((double)frameDeltaTime < 0.0001)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		int id = characterActorComponent.Entity.Id;
		KeepAwayFromGroundParam keepAwayFromGroundParam = null;
		if (!TsAnimNotifyStateKeepAwayFromGround.paramsMap.TryGetValue(id, out keepAwayFromGroundParam))
		{
			return false;
		}
		this.MoveToTarget(frameDeltaTime, keepAwayFromGroundParam, characterActorComponent);
		keepAwayFromGroundParam.NowTime += frameDeltaTime;
		return true;
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x0006E86C File Offset: 0x0006CA6C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x0006E90C File Offset: 0x0006CB0C
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		int id = ((TsBaseCharacter)owner).CharacterActorComponent.Entity.Id;
		TsAnimNotifyStateKeepAwayFromGround.paramsMap.Remove(id);
		return true;
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x0006E950 File Offset: 0x0006CB50
	[NullableContext(1)]
	private float GetRate(float delta, KeepAwayFromGroundParam param)
	{
		double num = 1.0;
		float num2 = param.NowTime + delta;
		if (param.TotalTime <= num2)
		{
			return 1f;
		}
		if (this.MoveCurve != null)
		{
			float floatValue = this.MoveCurve.GetFloatValue(param.NowTime / param.TotalTime);
			float floatValue2 = this.MoveCurve.GetFloatValue(num2 / param.TotalTime);
			if (floatValue >= 1f)
			{
				return 0f;
			}
			num = (double)((floatValue2 - floatValue) / (1f - floatValue));
		}
		else if (!this.TsIgnoreInterpolation)
		{
			double cubicValue = MathUtils.Instance.GetCubicValue((double)(param.NowTime / param.TotalTime));
			double cubicValue2 = MathUtils.Instance.GetCubicValue((double)(num2 / param.TotalTime));
			if (cubicValue >= 1.0)
			{
				return 0f;
			}
			num = (cubicValue2 - cubicValue) / (1.0 - cubicValue);
		}
		return (float)num;
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x0006EA30 File Offset: 0x0006CC30
	[NullableContext(1)]
	private void MoveToTarget(float frameDeltaTime, KeepAwayFromGroundParam param, CharacterActorComponent actorComp)
	{
		BaseMoveComponent component = actorComp.Entity.GetComponent<CharacterMoveComponent>();
		float heightDetect = (this.TsMaxHeight <= 0f) ? this.TsMinHeight : this.TsMaxHeight;
		float heightAboveGround = component.GetHeightAboveGround(heightDetect);
		if (heightAboveGround < this.TsMinHeight)
		{
			this.TsTmpVector.Set(0.0, 0.0, (double)(this.TsMinHeight - heightAboveGround));
			float rate = this.GetRate(frameDeltaTime, param);
			if (rate <= 0f)
			{
				return;
			}
			this.TsTmpVector.Z = Math.Min(this.TsTmpVector.Z * (double)rate, (double)(this.TsMaxSpeed * frameDeltaTime));
		}
		else
		{
			if (this.TsMaxHeight <= 0f || heightAboveGround < this.TsMaxHeight || actorComp.ActorLocationProxy.Z <= actorComp.LastActorLocation.Z)
			{
				return;
			}
			this.TsTmpVector.Set(0.0, 0.0, actorComp.LastActorLocation.Z - actorComp.ActorLocationProxy.Z);
		}
		actorComp.AddActorWorldOffset(this.TsTmpVector.ToUeVector(false), "TsAnimNotifyStateKeepAwayFromGround.AddActorWorldOffset", true);
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x0006EB54 File Offset: 0x0006CD54
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x0006EBCF File Offset: 0x0006CDCF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色和地面保持一定距离";
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x0006EBD6 File Offset: 0x0006CDD6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateKeepAwayFromGround._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepAwayFromGround.TsAnimNotifyStateKeepAwayFromGround_C");
		}
		return TsAnimNotifyStateKeepAwayFromGround._ClassPtr;
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x0006EBFC File Offset: 0x0006CDFC
	public TsAnimNotifyStateKeepAwayFromGround() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateKeepAwayFromGround.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x0006EC24 File Offset: 0x0006CE24
	[NullableContext(1)]
	public TsAnimNotifyStateKeepAwayFromGround(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateKeepAwayFromGround.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x0006EC57 File Offset: 0x0006CE57
	protected TsAnimNotifyStateKeepAwayFromGround(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x0006EC60 File Offset: 0x0006CE60
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x0006EC9C File Offset: 0x0006CE9C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x0006ECD8 File Offset: 0x0006CED8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x0006ED0B File Offset: 0x0006CF0B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E4E RID: 3662
	[Nullable(1)]
	private static Dictionary<int, KeepAwayFromGroundParam> paramsMap;

	// Token: 0x04000E4F RID: 3663
	private float TsMinHeight;

	// Token: 0x04000E50 RID: 3664
	private float TsMaxHeight;

	// Token: 0x04000E51 RID: 3665
	private float TsMaxSpeed;

	// Token: 0x04000E52 RID: 3666
	[Nullable(1)]
	private Vector TsTmpVector;

	// Token: 0x04000E53 RID: 3667
	private bool TsIgnoreInterpolation;

	// Token: 0x04000E54 RID: 3668
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepAwayFromGround.TsAnimNotifyStateKeepAwayFromGround_C";

	// Token: 0x04000E55 RID: 3669
	private static IntPtr _ClassPtr;

	// Token: 0x04000E56 RID: 3670
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E57 RID: 3671
	private static int __PropertyOffset_距离水平面最小高度;

	// Token: 0x04000E58 RID: 3672
	private static int __PropertyOffset_距离水平面最大高度;

	// Token: 0x04000E59 RID: 3673
	private static int __PropertyOffset_MoveCurve;

	// Token: 0x04000E5A RID: 3674
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x04000E5B RID: 3675
	private static int __PropertyOffset_不使用默认插值曲线;
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000117 RID: 279
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraModify.TsAnimNotifyStateCameraModify_C")]
public class TsAnimNotifyStateCameraModify : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x06001088 RID: 4232 RVA: 0x0005E56B File Offset: 0x0005C76B
	// (set) Token: 0x06001089 RID: 4233 RVA: 0x0005E57F File Offset: 0x0005C77F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x0600108A RID: 4234 RVA: 0x0005E594 File Offset: 0x0005C794
	// (set) Token: 0x0600108B RID: 4235 RVA: 0x0005E5A4 File Offset: 0x0005C7A4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 淡入时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_淡入时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_淡入时间) = value;
		}
	}

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x0600108C RID: 4236 RVA: 0x0005E5B5 File Offset: 0x0005C7B5
	// (set) Token: 0x0600108D RID: 4237 RVA: 0x0005E5C5 File Offset: 0x0005C7C5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 淡出时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_淡出时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_淡出时间) = value;
		}
	}

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x0600108E RID: 4238 RVA: 0x0005E5D8 File Offset: 0x0005C7D8
	// (set) Token: 0x0600108F RID: 4239 RVA: 0x0005E611 File Offset: 0x0005C811
	[UProperty(EPropertyFlags.CPF_None)]
	public SBaseCurve 淡入曲线
	{
		get
		{
			base.FastCheckIsValid();
			SBaseCurve result;
			if ((result = this._淡入曲线) == null)
			{
				result = (this._淡入曲线 = new SBaseCurve(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_淡入曲线, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_淡入曲线, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x06001090 RID: 4240 RVA: 0x0005E63C File Offset: 0x0005C83C
	// (set) Token: 0x06001091 RID: 4241 RVA: 0x0005E675 File Offset: 0x0005C875
	[UProperty(EPropertyFlags.CPF_None)]
	public SBaseCurve 淡出曲线
	{
		get
		{
			base.FastCheckIsValid();
			SBaseCurve result;
			if ((result = this._淡出曲线) == null)
			{
				result = (this._淡出曲线 = new SBaseCurve(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_淡出曲线, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_淡出曲线, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06001092 RID: 4242 RVA: 0x0005E69D File Offset: 0x0005C89D
	// (set) Token: 0x06001093 RID: 4243 RVA: 0x0005E6AD File Offset: 0x0005C8AD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 打断淡出时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_打断淡出时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_打断淡出时间) = value;
		}
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x06001094 RID: 4244 RVA: 0x0005E6C0 File Offset: 0x0005C8C0
	// (set) Token: 0x06001095 RID: 4245 RVA: 0x0005E6F9 File Offset: 0x0005C8F9
	[UProperty(EPropertyFlags.CPF_None)]
	public SCameraModifier_Settings 相机修改配置
	{
		get
		{
			base.FastCheckIsValid();
			SCameraModifier_Settings result;
			if ((result = this._相机修改配置) == null)
			{
				result = (this._相机修改配置 = new SCameraModifier_Settings(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_相机修改配置, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_相机修改配置, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x06001096 RID: 4246 RVA: 0x0005E721 File Offset: 0x0005C921
	// (set) Token: 0x06001097 RID: 4247 RVA: 0x0005E731 File Offset: 0x0005C931
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECameraAnsEffectiveClientType 生效客户端类型
	{
		get
		{
			return (ECameraAnsEffectiveClientType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_生效客户端类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_生效客户端类型) = (byte)value;
		}
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x06001098 RID: 4248 RVA: 0x0005E742 File Offset: 0x0005C942
	// (set) Token: 0x06001099 RID: 4249 RVA: 0x0005E756 File Offset: 0x0005C956
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CameraAttachSocket
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_CameraAttachSocket)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_CameraAttachSocket)), value);
		}
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x0600109A RID: 4250 RVA: 0x0005E76C File Offset: 0x0005C96C
	// (set) Token: 0x0600109B RID: 4251 RVA: 0x0005E7A5 File Offset: 0x0005C9A5
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SCameraModifier_Condition> 条件
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SCameraModifier_Condition> result;
			if ((result = this._条件) == null)
			{
				result = (this._条件 = new TArray<SCameraModifier_Condition>(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_条件, this));
			}
			return result;
		}
		set
		{
			this.条件.CopyAssign(value);
		}
	}

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x0600109C RID: 4252 RVA: 0x0005E7B3 File Offset: 0x0005C9B3
	// (set) Token: 0x0600109D RID: 4253 RVA: 0x0005E7C3 File Offset: 0x0005C9C3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 打断后继续
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_打断后继续) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraModify.__PropertyOffset_打断后继续) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x0005E7D4 File Offset: 0x0005C9D4
	[NullableContext(2)]
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

	// Token: 0x0600109F RID: 4255 RVA: 0x0005E87C File Offset: 0x0005CA7C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter) && !(owner is TsBaseVehicle))
		{
			return false;
		}
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return false;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById((owner as TsBaseCharacter).EntityId);
		if (entityById == null || !entityById.Valid)
		{
			return false;
		}
		this.IsStopByCharacterType = !CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityById);
		return !this.IsStopByCharacterType && this.CheckAndPlayCameraModify(meshComp, animation, entityById);
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x0005E91C File Offset: 0x0005CB1C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
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
			ptr2->FrameDeltaTime = deltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x0005E9C4 File Offset: 0x0005CBC4
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
	{
		if (!this.打断后继续)
		{
			return true;
		}
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
		if (tsBaseCharacter == null && tsBaseVehicle == null)
		{
			return false;
		}
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return false;
		}
		if (fightCameraLogicComponent.HasCameraModify())
		{
			return true;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById((tsBaseCharacter != null) ? tsBaseCharacter.EntityId : tsBaseVehicle.EntityId);
		return entityById != null && entityById.Valid && !this.IsStopByCharacterType && this.CheckAndPlayCameraModify(meshComp, animation, entityById);
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x0005EA74 File Offset: 0x0005CC74
	[NullableContext(2)]
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

	// Token: 0x060010A3 RID: 4259 RVA: 0x0005EB14 File Offset: 0x0005CD14
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter) && !(owner is TsBaseVehicle))
		{
			return false;
		}
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return false;
		}
		fightCameraLogicComponent.StopCameraModify(animation, this.ModifyInstance);
		return true;
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x0005EB78 File Offset: 0x0005CD78
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

	// Token: 0x060010A5 RID: 4261 RVA: 0x0005EBF3 File Offset: 0x0005CDF3
	protected override string GetNotifyName_Implementation()
	{
		return "ModifyANS镜头";
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x0005EBFC File Offset: 0x0005CDFC
	private bool CheckAndPlayCameraModify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, EntityHandle entityHandle)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter) && !(owner is TsBaseVehicle))
		{
			return false;
		}
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return false;
		}
		if (CameraUtility.CheckApplyCameraModifyCondition(entityHandle, this.相机修改配置, this.生效客户端类型, this.条件))
		{
			OneOf<TsBaseCharacter, TsBaseVehicle> newLookAtActor = default(OneOf<TsBaseCharacter, TsBaseVehicle>);
			if (this.生效客户端类型 != ECameraAnsEffectiveClientType.单客户端_角色为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.全客户端_角色为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.锁定目标客户端_角色为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.仇恨目标客户端_角色为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.单客户端_载具为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.全客户端_载具为中心_)
			{
				newLookAtActor = (owner as TsBaseCharacter);
				if (this.生效客户端类型 != ECameraAnsEffectiveClientType.单客户端_声骸为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.全客户端_声骸为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.单客户端_伴生物为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.全客户端_伴生物为中心_)
				{
					this.相机修改配置.IsLockInput = true;
					this.相机修改配置.OverrideCameraInput = true;
				}
			}
			this.ModifyInstance = fightCameraLogicComponent.ApplyCameraModify(new FGameplayTag?(this.Tag), 100f, this.淡入时间, this.淡出时间, this.相机修改配置, animation, this.打断淡出时间, this.淡入曲线, this.淡出曲线, newLookAtActor, this.CameraAttachSocket.ToString(), owner as TsBaseCharacter);
		}
		return true;
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x0005ED51 File Offset: 0x0005CF51
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCameraModify._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraModify.TsAnimNotifyStateCameraModify_C");
		}
		return TsAnimNotifyStateCameraModify._ClassPtr;
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x0005ED78 File Offset: 0x0005CF78
	public TsAnimNotifyStateCameraModify() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraModify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x0005EDA0 File Offset: 0x0005CFA0
	public TsAnimNotifyStateCameraModify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x0005EDD3 File Offset: 0x0005CFD3
	protected TsAnimNotifyStateCameraModify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x0005EDDC File Offset: 0x0005CFDC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x0005EE18 File Offset: 0x0005D018
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x0005EE54 File Offset: 0x0005D054
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x0005EE87 File Offset: 0x0005D087
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CAA RID: 3242
	private const int MODIFY_TIME_LENGTH = 100;

	// Token: 0x04000CAB RID: 3243
	private int ModifyInstance;

	// Token: 0x04000CAC RID: 3244
	private bool IsStopByCharacterType;

	// Token: 0x04000CAD RID: 3245
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraModify.TsAnimNotifyStateCameraModify_C";

	// Token: 0x04000CAE RID: 3246
	private static IntPtr _ClassPtr;

	// Token: 0x04000CAF RID: 3247
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CB0 RID: 3248
	private static int __PropertyOffset_Tag;

	// Token: 0x04000CB1 RID: 3249
	private static int __PropertyOffset_淡入时间;

	// Token: 0x04000CB2 RID: 3250
	private static int __PropertyOffset_淡出时间;

	// Token: 0x04000CB3 RID: 3251
	private static int __PropertyOffset_淡入曲线;

	// Token: 0x04000CB4 RID: 3252
	[Nullable(2)]
	private SBaseCurve _淡入曲线;

	// Token: 0x04000CB5 RID: 3253
	private static int __PropertyOffset_淡出曲线;

	// Token: 0x04000CB6 RID: 3254
	[Nullable(2)]
	private SBaseCurve _淡出曲线;

	// Token: 0x04000CB7 RID: 3255
	private static int __PropertyOffset_打断淡出时间;

	// Token: 0x04000CB8 RID: 3256
	private static int __PropertyOffset_相机修改配置;

	// Token: 0x04000CB9 RID: 3257
	[Nullable(2)]
	private SCameraModifier_Settings _相机修改配置;

	// Token: 0x04000CBA RID: 3258
	private static int __PropertyOffset_生效客户端类型;

	// Token: 0x04000CBB RID: 3259
	private static int __PropertyOffset_CameraAttachSocket;

	// Token: 0x04000CBC RID: 3260
	private static int __PropertyOffset_条件;

	// Token: 0x04000CBD RID: 3261
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SCameraModifier_Condition> _条件;

	// Token: 0x04000CBE RID: 3262
	private static int __PropertyOffset_打断后继续;
}

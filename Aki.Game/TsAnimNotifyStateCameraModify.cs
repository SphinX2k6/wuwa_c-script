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
	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x0600108E RID: 4238 RVA: 0x0005F8A7 File Offset: 0x0005DAA7
	// (set) Token: 0x0600108F RID: 4239 RVA: 0x0005F8BB File Offset: 0x0005DABB
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

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x06001090 RID: 4240 RVA: 0x0005F8D0 File Offset: 0x0005DAD0
	// (set) Token: 0x06001091 RID: 4241 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
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

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06001092 RID: 4242 RVA: 0x0005F8F1 File Offset: 0x0005DAF1
	// (set) Token: 0x06001093 RID: 4243 RVA: 0x0005F901 File Offset: 0x0005DB01
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

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x06001094 RID: 4244 RVA: 0x0005F914 File Offset: 0x0005DB14
	// (set) Token: 0x06001095 RID: 4245 RVA: 0x0005F94D File Offset: 0x0005DB4D
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

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x06001096 RID: 4246 RVA: 0x0005F978 File Offset: 0x0005DB78
	// (set) Token: 0x06001097 RID: 4247 RVA: 0x0005F9B1 File Offset: 0x0005DBB1
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

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x06001098 RID: 4248 RVA: 0x0005F9D9 File Offset: 0x0005DBD9
	// (set) Token: 0x06001099 RID: 4249 RVA: 0x0005F9E9 File Offset: 0x0005DBE9
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

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x0600109A RID: 4250 RVA: 0x0005F9FC File Offset: 0x0005DBFC
	// (set) Token: 0x0600109B RID: 4251 RVA: 0x0005FA35 File Offset: 0x0005DC35
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

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x0600109C RID: 4252 RVA: 0x0005FA5D File Offset: 0x0005DC5D
	// (set) Token: 0x0600109D RID: 4253 RVA: 0x0005FA6D File Offset: 0x0005DC6D
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

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x0600109E RID: 4254 RVA: 0x0005FA7E File Offset: 0x0005DC7E
	// (set) Token: 0x0600109F RID: 4255 RVA: 0x0005FA92 File Offset: 0x0005DC92
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

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0005FAA8 File Offset: 0x0005DCA8
	// (set) Token: 0x060010A1 RID: 4257 RVA: 0x0005FAE1 File Offset: 0x0005DCE1
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

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0005FAEF File Offset: 0x0005DCEF
	// (set) Token: 0x060010A3 RID: 4259 RVA: 0x0005FAFF File Offset: 0x0005DCFF
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

	// Token: 0x060010A4 RID: 4260 RVA: 0x0005FB10 File Offset: 0x0005DD10
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraModify) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateCameraModify.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x0005FBD0 File Offset: 0x0005DDD0
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

	// Token: 0x060010A6 RID: 4262 RVA: 0x0005FC70 File Offset: 0x0005DE70
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraModify) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateCameraModify.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, deltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = deltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x0005FD30 File Offset: 0x0005DF30
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

	// Token: 0x060010A8 RID: 4264 RVA: 0x0005FDE0 File Offset: 0x0005DFE0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraModify) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateCameraModify.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x0005FE98 File Offset: 0x0005E098
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

	// Token: 0x060010AA RID: 4266 RVA: 0x0005FEFC File Offset: 0x0005E0FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraModify) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateCameraModify.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x0005FF8C File Offset: 0x0005E18C
	protected override string GetNotifyName_Implementation()
	{
		return "ModifyANS镜头";
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x0005FF94 File Offset: 0x0005E194
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

	// Token: 0x060010AD RID: 4269 RVA: 0x000600E9 File Offset: 0x0005E2E9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCameraModify._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraModify.TsAnimNotifyStateCameraModify_C");
		}
		return TsAnimNotifyStateCameraModify._ClassPtr;
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00060110 File Offset: 0x0005E310
	public TsAnimNotifyStateCameraModify() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraModify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x00060138 File Offset: 0x0005E338
	public TsAnimNotifyStateCameraModify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x0006016B File Offset: 0x0005E36B
	protected TsAnimNotifyStateCameraModify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x00060174 File Offset: 0x0005E374
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x000601B0 File Offset: 0x0005E3B0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x000601EC File Offset: 0x0005E3EC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x0006021F File Offset: 0x0005E41F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CB2 RID: 3250
	private const int MODIFY_TIME_LENGTH = 100;

	// Token: 0x04000CB3 RID: 3251
	private int ModifyInstance;

	// Token: 0x04000CB4 RID: 3252
	private bool IsStopByCharacterType;

	// Token: 0x04000CB5 RID: 3253
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraModify.TsAnimNotifyStateCameraModify_C";

	// Token: 0x04000CB6 RID: 3254
	private static IntPtr _ClassPtr;

	// Token: 0x04000CB7 RID: 3255
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CB8 RID: 3256
	private static int __PropertyOffset_Tag;

	// Token: 0x04000CB9 RID: 3257
	private static int __PropertyOffset_淡入时间;

	// Token: 0x04000CBA RID: 3258
	private static int __PropertyOffset_淡出时间;

	// Token: 0x04000CBB RID: 3259
	private static int __PropertyOffset_淡入曲线;

	// Token: 0x04000CBC RID: 3260
	[Nullable(2)]
	private SBaseCurve _淡入曲线;

	// Token: 0x04000CBD RID: 3261
	private static int __PropertyOffset_淡出曲线;

	// Token: 0x04000CBE RID: 3262
	[Nullable(2)]
	private SBaseCurve _淡出曲线;

	// Token: 0x04000CBF RID: 3263
	private static int __PropertyOffset_打断淡出时间;

	// Token: 0x04000CC0 RID: 3264
	private static int __PropertyOffset_相机修改配置;

	// Token: 0x04000CC1 RID: 3265
	[Nullable(2)]
	private SCameraModifier_Settings _相机修改配置;

	// Token: 0x04000CC2 RID: 3266
	private static int __PropertyOffset_生效客户端类型;

	// Token: 0x04000CC3 RID: 3267
	private static int __PropertyOffset_CameraAttachSocket;

	// Token: 0x04000CC4 RID: 3268
	private static int __PropertyOffset_条件;

	// Token: 0x04000CC5 RID: 3269
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SCameraModifier_Condition> _条件;

	// Token: 0x04000CC6 RID: 3270
	private static int __PropertyOffset_打断后继续;
}

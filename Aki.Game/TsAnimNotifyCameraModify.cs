using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A1 RID: 417
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraModify.TsAnimNotifyCameraModify_C")]
public class TsAnimNotifyCameraModify : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000460 RID: 1120
	// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0008FBA3 File Offset: 0x0008DDA3
	// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0008FBB7 File Offset: 0x0008DDB7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x17000461 RID: 1121
	// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0008FBCC File Offset: 0x0008DDCC
	// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0008FBDC File Offset: 0x0008DDDC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 持续时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_持续时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_持续时间) = value;
		}
	}

	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0008FBED File Offset: 0x0008DDED
	// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0008FBFD File Offset: 0x0008DDFD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 淡入时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_淡入时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_淡入时间) = value;
		}
	}

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0008FC0E File Offset: 0x0008DE0E
	// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0008FC1E File Offset: 0x0008DE1E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 淡出时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_淡出时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_淡出时间) = value;
		}
	}

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0008FC30 File Offset: 0x0008DE30
	// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0008FC69 File Offset: 0x0008DE69
	[UProperty(EPropertyFlags.CPF_None)]
	public SBaseCurve 淡入曲线
	{
		get
		{
			base.FastCheckIsValid();
			SBaseCurve result;
			if ((result = this._淡入曲线) == null)
			{
				result = (this._淡入曲线 = new SBaseCurve(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_淡入曲线, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_淡入曲线, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x06001ADE RID: 6878 RVA: 0x0008FC94 File Offset: 0x0008DE94
	// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0008FCCD File Offset: 0x0008DECD
	[UProperty(EPropertyFlags.CPF_None)]
	public SBaseCurve 淡出曲线
	{
		get
		{
			base.FastCheckIsValid();
			SBaseCurve result;
			if ((result = this._淡出曲线) == null)
			{
				result = (this._淡出曲线 = new SBaseCurve(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_淡出曲线, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_淡出曲线, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x0008FCF5 File Offset: 0x0008DEF5
	// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0008FD05 File Offset: 0x0008DF05
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 打断淡出时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_打断淡出时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_打断淡出时间) = value;
		}
	}

	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0008FD18 File Offset: 0x0008DF18
	// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0008FD51 File Offset: 0x0008DF51
	[UProperty(EPropertyFlags.CPF_None)]
	public SCameraModifier_Settings 相机修改配置
	{
		get
		{
			base.FastCheckIsValid();
			SCameraModifier_Settings result;
			if ((result = this._相机修改配置) == null)
			{
				result = (this._相机修改配置 = new SCameraModifier_Settings(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_相机修改配置, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_相机修改配置, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17000468 RID: 1128
	// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0008FD79 File Offset: 0x0008DF79
	// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0008FD89 File Offset: 0x0008DF89
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECameraAnsEffectiveClientType 生效客户端类型
	{
		get
		{
			return (ECameraAnsEffectiveClientType)(*(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_生效客户端类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_生效客户端类型) = (byte)value;
		}
	}

	// Token: 0x17000469 RID: 1129
	// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0008FD9A File Offset: 0x0008DF9A
	// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x0008FDAE File Offset: 0x0008DFAE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CameraAttachSocket
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_CameraAttachSocket)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_CameraAttachSocket)), value);
		}
	}

	// Token: 0x1700046A RID: 1130
	// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0008FDC4 File Offset: 0x0008DFC4
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SCameraModifier_Condition> 条件
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SCameraModifier_Condition> result;
			if ((result = this._条件) == null)
			{
				result = (this._条件 = new TArray<SCameraModifier_Condition>(base.NativePtr + (IntPtr)TsAnimNotifyCameraModify.__PropertyOffset_条件, this));
			}
			return result;
		}
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x0008FE00 File Offset: 0x0008E000
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyCameraModify) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyCameraModify.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x0008FEB8 File Offset: 0x0008E0B8
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
		if (tsBaseCharacter == null && tsBaseVehicle == null)
		{
			return false;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById((tsBaseCharacter != null) ? tsBaseCharacter.EntityId : tsBaseVehicle.EntityId);
		if (entityById == null || !entityById.Valid)
		{
			return false;
		}
		if (!CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityById))
		{
			return false;
		}
		FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
		if (logicComponent == null || !logicComponent.Valid)
		{
			return false;
		}
		UAnimMontage anim = null;
		UAnimMontage uanimMontage = animation as UAnimMontage;
		if (uanimMontage != null)
		{
			anim = uanimMontage;
		}
		if (CameraUtility.CheckApplyCameraModifyCondition(entityById, this.相机修改配置, this.生效客户端类型, this.条件))
		{
			AActor aactor = null;
			if (this.生效客户端类型 != ECameraAnsEffectiveClientType.单客户端_角色为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.全客户端_角色为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.锁定目标客户端_角色为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.仇恨目标客户端_角色为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.单客户端_载具为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.全客户端_载具为中心_)
			{
				aactor = owner;
				if (this.生效客户端类型 != ECameraAnsEffectiveClientType.单客户端_声骸为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.全客户端_声骸为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.单客户端_伴生物为中心_ && this.生效客户端类型 != ECameraAnsEffectiveClientType.全客户端_伴生物为中心_)
				{
					this.相机修改配置.IsLockInput = true;
					this.相机修改配置.OverrideCameraInput = true;
				}
			}
			OneOf<TsBaseCharacter, TsBaseVehicle> newLookAtActor = default(OneOf<TsBaseCharacter, TsBaseVehicle>);
			TsBaseCharacter tsBaseCharacter2 = aactor as TsBaseCharacter;
			if (tsBaseCharacter2 != null)
			{
				newLookAtActor = tsBaseCharacter2;
			}
			else
			{
				TsBaseVehicle tsBaseVehicle2 = aactor as TsBaseVehicle;
				if (tsBaseVehicle2 != null)
				{
					newLookAtActor = tsBaseVehicle2;
				}
			}
			OneOf<TsBaseCharacter, TsBaseVehicle> animOwner = default(OneOf<TsBaseCharacter, TsBaseVehicle>);
			TsBaseCharacter tsBaseCharacter3 = owner as TsBaseCharacter;
			if (tsBaseCharacter3 != null)
			{
				animOwner = tsBaseCharacter3;
			}
			else
			{
				TsBaseVehicle tsBaseVehicle3 = owner as TsBaseVehicle;
				if (tsBaseVehicle3 != null)
				{
					animOwner = tsBaseVehicle3;
				}
			}
			logicComponent.ApplyCameraModify(new FGameplayTag?(this.Tag), this.持续时间, this.淡入时间, this.淡出时间, this.相机修改配置, anim, this.打断淡出时间, this.淡入曲线, this.淡出曲线, newLookAtActor, this.CameraAttachSocket, animOwner);
		}
		return true;
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x000900AC File Offset: 0x0008E2AC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyCameraModify) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyCameraModify.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x0009013C File Offset: 0x0008E33C
	protected override string GetNotifyName_Implementation()
	{
		return "Modify镜头";
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x00090143 File Offset: 0x0008E343
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCameraModify._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraModify.TsAnimNotifyCameraModify_C");
		}
		return TsAnimNotifyCameraModify._ClassPtr;
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x00090168 File Offset: 0x0008E368
	public TsAnimNotifyCameraModify() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraModify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x00090190 File Offset: 0x0008E390
	public TsAnimNotifyCameraModify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x000901C3 File Offset: 0x0008E3C3
	protected TsAnimNotifyCameraModify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x000901CC File Offset: 0x0008E3CC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x000901FF File Offset: 0x0008E3FF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001151 RID: 4433
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraModify.TsAnimNotifyCameraModify_C";

	// Token: 0x04001152 RID: 4434
	private static IntPtr _ClassPtr;

	// Token: 0x04001153 RID: 4435
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001154 RID: 4436
	private static int __PropertyOffset_Tag;

	// Token: 0x04001155 RID: 4437
	private static int __PropertyOffset_持续时间;

	// Token: 0x04001156 RID: 4438
	private static int __PropertyOffset_淡入时间;

	// Token: 0x04001157 RID: 4439
	private static int __PropertyOffset_淡出时间;

	// Token: 0x04001158 RID: 4440
	private static int __PropertyOffset_淡入曲线;

	// Token: 0x04001159 RID: 4441
	[Nullable(2)]
	private SBaseCurve _淡入曲线;

	// Token: 0x0400115A RID: 4442
	private static int __PropertyOffset_淡出曲线;

	// Token: 0x0400115B RID: 4443
	[Nullable(2)]
	private SBaseCurve _淡出曲线;

	// Token: 0x0400115C RID: 4444
	private static int __PropertyOffset_打断淡出时间;

	// Token: 0x0400115D RID: 4445
	private static int __PropertyOffset_相机修改配置;

	// Token: 0x0400115E RID: 4446
	[Nullable(2)]
	private SCameraModifier_Settings _相机修改配置;

	// Token: 0x0400115F RID: 4447
	private static int __PropertyOffset_生效客户端类型;

	// Token: 0x04001160 RID: 4448
	private static int __PropertyOffset_CameraAttachSocket;

	// Token: 0x04001161 RID: 4449
	private static int __PropertyOffset_条件;

	// Token: 0x04001162 RID: 4450
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SCameraModifier_Condition> _条件;
}

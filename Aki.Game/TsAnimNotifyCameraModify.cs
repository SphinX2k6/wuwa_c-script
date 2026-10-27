using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200019D RID: 413
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraModify.TsAnimNotifyCameraModify_C")]
public class TsAnimNotifyCameraModify : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x06001A37 RID: 6711 RVA: 0x000895E3 File Offset: 0x000877E3
	// (set) Token: 0x06001A38 RID: 6712 RVA: 0x000895F7 File Offset: 0x000877F7
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

	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0008960C File Offset: 0x0008780C
	// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0008961C File Offset: 0x0008781C
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

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0008962D File Offset: 0x0008782D
	// (set) Token: 0x06001A3C RID: 6716 RVA: 0x0008963D File Offset: 0x0008783D
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

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0008964E File Offset: 0x0008784E
	// (set) Token: 0x06001A3E RID: 6718 RVA: 0x0008965E File Offset: 0x0008785E
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

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00089670 File Offset: 0x00087870
	// (set) Token: 0x06001A40 RID: 6720 RVA: 0x000896A9 File Offset: 0x000878A9
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

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x06001A41 RID: 6721 RVA: 0x000896D4 File Offset: 0x000878D4
	// (set) Token: 0x06001A42 RID: 6722 RVA: 0x0008970D File Offset: 0x0008790D
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

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00089735 File Offset: 0x00087935
	// (set) Token: 0x06001A44 RID: 6724 RVA: 0x00089745 File Offset: 0x00087945
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

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00089758 File Offset: 0x00087958
	// (set) Token: 0x06001A46 RID: 6726 RVA: 0x00089791 File Offset: 0x00087991
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

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06001A47 RID: 6727 RVA: 0x000897B9 File Offset: 0x000879B9
	// (set) Token: 0x06001A48 RID: 6728 RVA: 0x000897C9 File Offset: 0x000879C9
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

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x06001A49 RID: 6729 RVA: 0x000897DA File Offset: 0x000879DA
	// (set) Token: 0x06001A4A RID: 6730 RVA: 0x000897EE File Offset: 0x000879EE
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

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x06001A4B RID: 6731 RVA: 0x00089804 File Offset: 0x00087A04
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

	// Token: 0x06001A4C RID: 6732 RVA: 0x00089840 File Offset: 0x00087A40
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x06001A4D RID: 6733 RVA: 0x000898E0 File Offset: 0x00087AE0
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

	// Token: 0x06001A4E RID: 6734 RVA: 0x00089AD4 File Offset: 0x00087CD4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001A4F RID: 6735 RVA: 0x00089B4F File Offset: 0x00087D4F
	protected override string GetNotifyName_Implementation()
	{
		return "Modify镜头";
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x00089B56 File Offset: 0x00087D56
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCameraModify._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraModify.TsAnimNotifyCameraModify_C");
		}
		return TsAnimNotifyCameraModify._ClassPtr;
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x00089B7C File Offset: 0x00087D7C
	public TsAnimNotifyCameraModify() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraModify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x00089BA4 File Offset: 0x00087DA4
	public TsAnimNotifyCameraModify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A53 RID: 6739 RVA: 0x00089BD7 File Offset: 0x00087DD7
	protected TsAnimNotifyCameraModify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A54 RID: 6740 RVA: 0x00089BE0 File Offset: 0x00087DE0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A55 RID: 6741 RVA: 0x00089C13 File Offset: 0x00087E13
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400110E RID: 4366
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraModify.TsAnimNotifyCameraModify_C";

	// Token: 0x0400110F RID: 4367
	private static IntPtr _ClassPtr;

	// Token: 0x04001110 RID: 4368
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001111 RID: 4369
	private static int __PropertyOffset_Tag;

	// Token: 0x04001112 RID: 4370
	private static int __PropertyOffset_持续时间;

	// Token: 0x04001113 RID: 4371
	private static int __PropertyOffset_淡入时间;

	// Token: 0x04001114 RID: 4372
	private static int __PropertyOffset_淡出时间;

	// Token: 0x04001115 RID: 4373
	private static int __PropertyOffset_淡入曲线;

	// Token: 0x04001116 RID: 4374
	[Nullable(2)]
	private SBaseCurve _淡入曲线;

	// Token: 0x04001117 RID: 4375
	private static int __PropertyOffset_淡出曲线;

	// Token: 0x04001118 RID: 4376
	[Nullable(2)]
	private SBaseCurve _淡出曲线;

	// Token: 0x04001119 RID: 4377
	private static int __PropertyOffset_打断淡出时间;

	// Token: 0x0400111A RID: 4378
	private static int __PropertyOffset_相机修改配置;

	// Token: 0x0400111B RID: 4379
	[Nullable(2)]
	private SCameraModifier_Settings _相机修改配置;

	// Token: 0x0400111C RID: 4380
	private static int __PropertyOffset_生效客户端类型;

	// Token: 0x0400111D RID: 4381
	private static int __PropertyOffset_CameraAttachSocket;

	// Token: 0x0400111E RID: 4382
	private static int __PropertyOffset_条件;

	// Token: 0x0400111F RID: 4383
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SCameraModifier_Condition> _条件;
}

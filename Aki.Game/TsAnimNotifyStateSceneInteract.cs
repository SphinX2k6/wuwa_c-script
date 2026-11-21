using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Module;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000165 RID: 357
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSceneInteract.TsAnimNotifyStateSceneInteract_C")]
public class TsAnimNotifyStateSceneInteract : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003C9 RID: 969
	// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0007EF7D File Offset: 0x0007D17D
	// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0007EF91 File Offset: 0x0007D191
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_SocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_SocketName) = value;
		}
	}

	// Token: 0x170003CA RID: 970
	// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0007EFA8 File Offset: 0x0007D1A8
	// (set) Token: 0x060016D5 RID: 5845 RVA: 0x0007EFE1 File Offset: 0x0007D1E1
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<BP_SceneBattleInteract_C> DataAssetRef
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<BP_SceneBattleInteract_C> result;
			if ((result = this._DataAssetRef) == null)
			{
				result = (this._DataAssetRef = new TSoftObjectPtr<BP_SceneBattleInteract_C>(base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_DataAssetRef, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_DataAssetRef, 1);
		}
	}

	// Token: 0x170003CB RID: 971
	// (get) Token: 0x060016D6 RID: 5846 RVA: 0x0007F006 File Offset: 0x0007D206
	// (set) Token: 0x060016D7 RID: 5847 RVA: 0x0007F016 File Offset: 0x0007D216
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int QualityRequire
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_QualityRequire);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_QualityRequire) = value;
		}
	}

	// Token: 0x170003CC RID: 972
	// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0007F027 File Offset: 0x0007D227
	// (set) Token: 0x060016D9 RID: 5849 RVA: 0x0007F037 File Offset: 0x0007D237
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IgnoreCommonWeapon
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_IgnoreCommonWeapon) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_IgnoreCommonWeapon) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003CD RID: 973
	// (get) Token: 0x060016DA RID: 5850 RVA: 0x0007F048 File Offset: 0x0007D248
	// (set) Token: 0x060016DB RID: 5851 RVA: 0x0007F058 File Offset: 0x0007D258
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ShieldWaterMoveEffect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_ShieldWaterMoveEffect) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSceneInteract.__PropertyOffset_ShieldWaterMoveEffect) = (value ? 1 : 0);
		}
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x0007F06C File Offset: 0x0007D26C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSceneInteract) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSceneInteract.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016DD RID: 5853 RVA: 0x0007F12C File Offset: 0x0007D32C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.DataAssetRef == null)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		bool flag = owner is TsBaseCharacter;
		bool flag2 = owner is TsBaseVehicle;
		if (flag || flag2)
		{
			if (!SceneBattleInteractModel.Instance.Open)
			{
				return false;
			}
			if (this.QualityRequire > 0)
			{
				int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.IMAGEQUALITY, true, true);
				if (currentValue == null || currentValue.Value < 3)
				{
					return false;
				}
			}
			BP_SceneBattleInteract_C bp_SceneBattleInteract_C = ResourceSystem.Instance.Load<BP_SceneBattleInteract_C>(this.DataAssetRef.ToAssetPathName(), "js_undefined");
			if (bp_SceneBattleInteract_C == null)
			{
				return false;
			}
			SceneBattleInteractEffect sceneBattleInteractEffect = SceneBattleInteractModel.Instance.CreateSceneBattleInteract(bp_SceneBattleInteract_C, 0f, 0f);
			if (sceneBattleInteractEffect != null)
			{
				int id = sceneBattleInteractEffect.Id;
				sceneBattleInteractEffect.SetDispatchWeaponEventEnable(true);
				sceneBattleInteractEffect.SetUpdateLocationSocket(meshComp, FNameUtil.IsNothing(this.SocketName) ? FNameUtil.EMPTY : this.SocketName);
				sceneBattleInteractEffect.SetEnable(true, 20000f);
				sceneBattleInteractEffect.SetIgnoreCommonWeapon(this.IgnoreCommonWeapon);
				this.HandleMap[meshComp] = id;
				if (flag)
				{
					global::ESceneBattleInteractEntityType esceneBattleInteractEntityType = (global::ESceneBattleInteractEntityType)bp_SceneBattleInteract_C.EntityType;
					if (esceneBattleInteractEntityType == global::ESceneBattleInteractEntityType.Player || esceneBattleInteractEntityType == global::ESceneBattleInteractEntityType.Summoned)
					{
						TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
						Entity entity;
						if (tsBaseCharacter == null)
						{
							entity = null;
						}
						else
						{
							CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
							entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
						}
						Entity entity2 = entity;
						if (entity2 != null && entity2.Valid)
						{
							if (esceneBattleInteractEntityType == global::ESceneBattleInteractEntityType.Summoned)
							{
								CreatureDataComponent component = entity2.GetComponent<CreatureDataComponent>();
								long? num = (component != null) ? new long?(component.GetSummonerId()) : null;
								if (num != null && num.Value != 0L)
								{
									int entityId = CreatureModel.Instance.GetEntityId(num.Value);
									sceneBattleInteractEffect.BindEntityId(entityId);
								}
							}
							else
							{
								sceneBattleInteractEffect.BindEntityId(entity2.Id);
							}
						}
					}
				}
				if (this.ShieldWaterMoveEffect)
				{
					TsBaseCharacter tsBaseCharacter2 = owner as TsBaseCharacter;
					Entity entity3;
					if ((entity3 = ((tsBaseCharacter2 != null) ? tsBaseCharacter2.GetEntityNoBlueprint() : null)) == null)
					{
						TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
						entity3 = ((tsBaseVehicle != null) ? tsBaseVehicle.GetEntityNoBlueprint() : null);
					}
					Entity entity4 = entity3;
					if (entity4 != null && entity4.Valid)
					{
						BaseTagComponent component2 = entity4.GetComponent<BaseTagComponent>();
						if (component2 != null)
						{
							component2.TagContainer.UpdateExactTag(ETagChannel.Anim, GameplayTagDefine.EGameplayTagId["GameplayEffect.ShieldWaterMoveEffect"], 1);
							return true;
						}
					}
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x0007F364 File Offset: 0x0007D564
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSceneInteract) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSceneInteract.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016DF RID: 5855 RVA: 0x0007F41C File Offset: 0x0007D61C
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.DataAssetRef == null)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		int num;
		if (tsBaseCharacter != null && this.HandleMap.TryGetValue(meshComp, out num) && num != 0)
		{
			if (SceneBattleInteractModel.Instance.Open)
			{
				SceneBattleInteractModel.Instance.DestroySceneBattleInteract(num);
			}
			this.HandleMap.Remove(meshComp);
			if (this.ShieldWaterMoveEffect)
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
				if (entity != null && entity.Valid)
				{
					BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
					if (component != null)
					{
						component.TagContainer.UpdateExactTag(ETagChannel.Anim, GameplayTagDefine.EGameplayTagId["GameplayEffect.ShieldWaterMoveEffect"], -1);
						return true;
					}
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x0007F4D4 File Offset: 0x0007D6D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSceneInteract) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSceneInteract.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016E1 RID: 5857 RVA: 0x0007F564 File Offset: 0x0007D764
	protected override string GetNotifyName_Implementation()
	{
		return "场景物件交互";
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x0007F56B File Offset: 0x0007D76B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSceneInteract._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSceneInteract.TsAnimNotifyStateSceneInteract_C");
		}
		return TsAnimNotifyStateSceneInteract._ClassPtr;
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x0007F590 File Offset: 0x0007D790
	public TsAnimNotifyStateSceneInteract() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSceneInteract.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x0007F5B8 File Offset: 0x0007D7B8
	public TsAnimNotifyStateSceneInteract(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSceneInteract.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x0007F5EB File Offset: 0x0007D7EB
	protected TsAnimNotifyStateSceneInteract(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x0007F600 File Offset: 0x0007D800
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x0007F63C File Offset: 0x0007D83C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x0007F66F File Offset: 0x0007D86F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FBF RID: 4031
	private const float MAX_ENABLE_TIME = 20000f;

	// Token: 0x04000FC0 RID: 4032
	private readonly Dictionary<USkeletalMeshComponent, int> HandleMap = new Dictionary<USkeletalMeshComponent, int>();

	// Token: 0x04000FC1 RID: 4033
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSceneInteract.TsAnimNotifyStateSceneInteract_C";

	// Token: 0x04000FC2 RID: 4034
	private static IntPtr _ClassPtr;

	// Token: 0x04000FC3 RID: 4035
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FC4 RID: 4036
	private static int __PropertyOffset_SocketName;

	// Token: 0x04000FC5 RID: 4037
	private static int __PropertyOffset_DataAssetRef;

	// Token: 0x04000FC6 RID: 4038
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<BP_SceneBattleInteract_C> _DataAssetRef;

	// Token: 0x04000FC7 RID: 4039
	private static int __PropertyOffset_QualityRequire;

	// Token: 0x04000FC8 RID: 4040
	private static int __PropertyOffset_IgnoreCommonWeapon;

	// Token: 0x04000FC9 RID: 4041
	private static int __PropertyOffset_ShieldWaterMoveEffect;
}

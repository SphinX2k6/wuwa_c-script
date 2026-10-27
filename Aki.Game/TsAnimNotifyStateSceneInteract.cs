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

// Token: 0x02000161 RID: 353
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSceneInteract.TsAnimNotifyStateSceneInteract_C")]
public class TsAnimNotifyStateSceneInteract : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003A7 RID: 935
	// (get) Token: 0x06001635 RID: 5685 RVA: 0x000796E5 File Offset: 0x000778E5
	// (set) Token: 0x06001636 RID: 5686 RVA: 0x000796F9 File Offset: 0x000778F9
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

	// Token: 0x170003A8 RID: 936
	// (get) Token: 0x06001637 RID: 5687 RVA: 0x00079710 File Offset: 0x00077910
	// (set) Token: 0x06001638 RID: 5688 RVA: 0x00079749 File Offset: 0x00077949
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

	// Token: 0x170003A9 RID: 937
	// (get) Token: 0x06001639 RID: 5689 RVA: 0x0007976E File Offset: 0x0007796E
	// (set) Token: 0x0600163A RID: 5690 RVA: 0x0007977E File Offset: 0x0007797E
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

	// Token: 0x170003AA RID: 938
	// (get) Token: 0x0600163B RID: 5691 RVA: 0x0007978F File Offset: 0x0007798F
	// (set) Token: 0x0600163C RID: 5692 RVA: 0x0007979F File Offset: 0x0007799F
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

	// Token: 0x170003AB RID: 939
	// (get) Token: 0x0600163D RID: 5693 RVA: 0x000797B0 File Offset: 0x000779B0
	// (set) Token: 0x0600163E RID: 5694 RVA: 0x000797C0 File Offset: 0x000779C0
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

	// Token: 0x0600163F RID: 5695 RVA: 0x000797D4 File Offset: 0x000779D4
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

	// Token: 0x06001640 RID: 5696 RVA: 0x0007987C File Offset: 0x00077A7C
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

	// Token: 0x06001641 RID: 5697 RVA: 0x00079AB4 File Offset: 0x00077CB4
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

	// Token: 0x06001642 RID: 5698 RVA: 0x00079B54 File Offset: 0x00077D54
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

	// Token: 0x06001643 RID: 5699 RVA: 0x00079C0C File Offset: 0x00077E0C
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

	// Token: 0x06001644 RID: 5700 RVA: 0x00079C87 File Offset: 0x00077E87
	protected override string GetNotifyName_Implementation()
	{
		return "场景物件交互";
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x00079C8E File Offset: 0x00077E8E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSceneInteract._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSceneInteract.TsAnimNotifyStateSceneInteract_C");
		}
		return TsAnimNotifyStateSceneInteract._ClassPtr;
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x00079CB4 File Offset: 0x00077EB4
	public TsAnimNotifyStateSceneInteract() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSceneInteract.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x00079CDC File Offset: 0x00077EDC
	public TsAnimNotifyStateSceneInteract(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSceneInteract.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x00079D0F File Offset: 0x00077F0F
	protected TsAnimNotifyStateSceneInteract(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x00079D24 File Offset: 0x00077F24
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x00079D60 File Offset: 0x00077F60
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x00079D93 File Offset: 0x00077F93
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F7C RID: 3964
	private const float MAX_ENABLE_TIME = 20000f;

	// Token: 0x04000F7D RID: 3965
	private readonly Dictionary<USkeletalMeshComponent, int> HandleMap = new Dictionary<USkeletalMeshComponent, int>();

	// Token: 0x04000F7E RID: 3966
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSceneInteract.TsAnimNotifyStateSceneInteract_C";

	// Token: 0x04000F7F RID: 3967
	private static IntPtr _ClassPtr;

	// Token: 0x04000F80 RID: 3968
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F81 RID: 3969
	private static int __PropertyOffset_SocketName;

	// Token: 0x04000F82 RID: 3970
	private static int __PropertyOffset_DataAssetRef;

	// Token: 0x04000F83 RID: 3971
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<BP_SceneBattleInteract_C> _DataAssetRef;

	// Token: 0x04000F84 RID: 3972
	private static int __PropertyOffset_QualityRequire;

	// Token: 0x04000F85 RID: 3973
	private static int __PropertyOffset_IgnoreCommonWeapon;

	// Token: 0x04000F86 RID: 3974
	private static int __PropertyOffset_ShieldWaterMoveEffect;
}

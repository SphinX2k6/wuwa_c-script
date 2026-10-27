using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200011F RID: 287
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCleanBurstCamera.TsAnimNotifyStateCleanBurstCamera_C")]
public class TsAnimNotifyStateCleanBurstCamera : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x06001137 RID: 4407 RVA: 0x0006130A File Offset: 0x0005F50A
	// (set) Token: 0x06001138 RID: 4408 RVA: 0x0006131A File Offset: 0x0005F51A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 隐藏敌对目标Mesh
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCleanBurstCamera.__PropertyOffset_隐藏敌对目标Mesh) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCleanBurstCamera.__PropertyOffset_隐藏敌对目标Mesh) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x06001139 RID: 4409 RVA: 0x0006132B File Offset: 0x0005F52B
	// (set) Token: 0x0600113A RID: 4410 RVA: 0x0006133B File Offset: 0x0005F53B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 隐藏敌对目标特效
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCleanBurstCamera.__PropertyOffset_隐藏敌对目标特效) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCleanBurstCamera.__PropertyOffset_隐藏敌对目标特效) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x0600113B RID: 4411 RVA: 0x0006134C File Offset: 0x0005F54C
	// (set) Token: 0x0600113C RID: 4412 RVA: 0x0006135C File Offset: 0x0005F55C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 不接受命中特效
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCleanBurstCamera.__PropertyOffset_不接受命中特效) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCleanBurstCamera.__PropertyOffset_不接受命中特效) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00061370 File Offset: 0x0005F570
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

	// Token: 0x0600113E RID: 4414 RVA: 0x00061418 File Offset: 0x0005F618
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		this.TsHideMesh = this.隐藏敌对目标Mesh;
		this.TsHideEffect = this.隐藏敌对目标特效;
		this.TsNoHitEffect = this.不接受命中特效;
		foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
		{
			if (entityHandle.IsInit)
			{
				WorldEntity entity = entityHandle.Entity;
				if (entity != null && entity.Active)
				{
					CharacterActorComponent component = entityHandle.Entity.GetComponent<CharacterActorComponent>();
					TsBaseCharacter tsBaseCharacter2 = (component != null) ? component.Actor : null;
					if (tsBaseCharacter2 != null && tsBaseCharacter2 != owner && CampUtils.GetCampRelationship(tsBaseCharacter2.Camp, tsBaseCharacter.Camp) != ERelation.Friend)
					{
						if (this.TsHiddenMap == null)
						{
							this.TsHiddenMap = new Dictionary<EntityHandle, int>();
						}
						if (this.TsHideEffect)
						{
							this.HideEffect(entityHandle, true);
							this.TsHiddenMap[entityHandle] = -1;
						}
						if (this.TsHideMesh)
						{
							int value = component.DisableActor("[TsAnimNotifyStateCleanBurstCamera] 大招镜头帧事件隐藏Mesh");
							this.TsHiddenMap[entityHandle] = value;
						}
					}
				}
			}
		}
		if (this.TsNoHitEffect)
		{
			Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
			if (entityNoBlueprint != null)
			{
				BaseTagComponent component2 = entityNoBlueprint.GetComponent<BaseTagComponent>();
				if (component2 != null)
				{
					component2.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.不接受命中特效"], 1);
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.HCW;
				string message = "No Entity for TsBaseCharacter ANS CleanBurstCamera Begin";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", tsBaseCharacter);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		return true;
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x000615DC File Offset: 0x0005F7DC
	[NullableContext(2)]
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

	// Token: 0x06001140 RID: 4416 RVA: 0x00061684 File Offset: 0x0005F884
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if (this.TsHideEffect && this.TsHiddenMap != null)
		{
			foreach (EntityHandle entityHandle in this.TsHiddenMap.Keys)
			{
				if (entityHandle.Valid)
				{
					this.HideEffect(entityHandle, true);
				}
			}
		}
		return true;
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x000616F8 File Offset: 0x0005F8F8
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

	// Token: 0x06001142 RID: 4418 RVA: 0x00061798 File Offset: 0x0005F998
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.TsNoHitEffect)
		{
			TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
				if (entityNoBlueprint != null)
				{
					BaseTagComponent component = entityNoBlueprint.GetComponent<BaseTagComponent>();
					if (component != null)
					{
						component.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.不接受命中特效"], -1);
					}
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Test;
					ELogAuthor author = ELogAuthor.HCW;
					string message = "No Entity for TsBaseCharacter ANS CleanBurstCamera End";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", tsBaseCharacter);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}
		if (this.TsHiddenMap == null)
		{
			return true;
		}
		foreach (KeyValuePair<EntityHandle, int> keyValuePair in this.TsHiddenMap)
		{
			EntityHandle key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (key.Valid)
			{
				if (this.TsHideMesh)
				{
					CharacterActorComponent component2 = key.Entity.GetComponent<CharacterActorComponent>();
					if (component2 != null)
					{
						component2.EnableActor(value);
					}
				}
				if (this.TsHideEffect)
				{
					this.HideEffect(key, false);
				}
			}
		}
		this.TsHiddenMap = null;
		return true;
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x000618B8 File Offset: 0x0005FAB8
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

	// Token: 0x06001144 RID: 4420 RVA: 0x00061933 File Offset: 0x0005FB33
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "大招时显隐Mesh和特效";
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x0006193A File Offset: 0x0005FB3A
	[NullableContext(1)]
	private void HideEffect(EntityHandle handle, bool hidden)
	{
		CharacterSkillComponent component = handle.Entity.GetComponent<CharacterSkillComponent>();
		if (component != null)
		{
			Skill currentSkill = component.CurrentSkill;
			if (currentSkill != null)
			{
				currentSkill.SetEffectHidden(hidden);
			}
		}
		CharacterGameplayCueComponent component2 = handle.Entity.GetComponent<CharacterGameplayCueComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.SetHidden(hidden);
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00061974 File Offset: 0x0005FB74
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCleanBurstCamera._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCleanBurstCamera.TsAnimNotifyStateCleanBurstCamera_C");
		}
		return TsAnimNotifyStateCleanBurstCamera._ClassPtr;
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00061998 File Offset: 0x0005FB98
	public TsAnimNotifyStateCleanBurstCamera() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCleanBurstCamera.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x000619C0 File Offset: 0x0005FBC0
	[NullableContext(1)]
	public TsAnimNotifyStateCleanBurstCamera(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCleanBurstCamera.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x000619F3 File Offset: 0x0005FBF3
	protected TsAnimNotifyStateCleanBurstCamera(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x000619FC File Offset: 0x0005FBFC
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x00061A38 File Offset: 0x0005FC38
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00061A74 File Offset: 0x0005FC74
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00061AA7 File Offset: 0x0005FCA7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CF6 RID: 3318
	private bool TsHideMesh;

	// Token: 0x04000CF7 RID: 3319
	private bool TsHideEffect;

	// Token: 0x04000CF8 RID: 3320
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EntityHandle, int> TsHiddenMap;

	// Token: 0x04000CF9 RID: 3321
	private bool TsNoHitEffect;

	// Token: 0x04000CFA RID: 3322
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCleanBurstCamera.TsAnimNotifyStateCleanBurstCamera_C";

	// Token: 0x04000CFB RID: 3323
	private static IntPtr _ClassPtr;

	// Token: 0x04000CFC RID: 3324
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CFD RID: 3325
	private static int __PropertyOffset_隐藏敌对目标Mesh;

	// Token: 0x04000CFE RID: 3326
	private static int __PropertyOffset_隐藏敌对目标特效;

	// Token: 0x04000CFF RID: 3327
	private static int __PropertyOffset_不接受命中特效;
}

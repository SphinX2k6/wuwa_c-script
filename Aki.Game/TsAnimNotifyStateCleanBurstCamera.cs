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
	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x0600113D RID: 4413 RVA: 0x00062896 File Offset: 0x00060A96
	// (set) Token: 0x0600113E RID: 4414 RVA: 0x000628A6 File Offset: 0x00060AA6
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

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x0600113F RID: 4415 RVA: 0x000628B7 File Offset: 0x00060AB7
	// (set) Token: 0x06001140 RID: 4416 RVA: 0x000628C7 File Offset: 0x00060AC7
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

	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x06001141 RID: 4417 RVA: 0x000628D8 File Offset: 0x00060AD8
	// (set) Token: 0x06001142 RID: 4418 RVA: 0x000628E8 File Offset: 0x00060AE8
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

	// Token: 0x06001143 RID: 4419 RVA: 0x000628FC File Offset: 0x00060AFC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCleanBurstCamera) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateCleanBurstCamera.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001144 RID: 4420 RVA: 0x000629BC File Offset: 0x00060BBC
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

	// Token: 0x06001145 RID: 4421 RVA: 0x00062B80 File Offset: 0x00060D80
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCleanBurstCamera) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateCleanBurstCamera.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00062C40 File Offset: 0x00060E40
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

	// Token: 0x06001147 RID: 4423 RVA: 0x00062CB4 File Offset: 0x00060EB4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCleanBurstCamera) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateCleanBurstCamera.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001148 RID: 4424 RVA: 0x00062D6C File Offset: 0x00060F6C
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

	// Token: 0x06001149 RID: 4425 RVA: 0x00062E8C File Offset: 0x0006108C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCleanBurstCamera) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateCleanBurstCamera.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600114A RID: 4426 RVA: 0x00062F1C File Offset: 0x0006111C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "大招时显隐Mesh和特效";
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x00062F23 File Offset: 0x00061123
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

	// Token: 0x0600114C RID: 4428 RVA: 0x00062F5D File Offset: 0x0006115D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCleanBurstCamera._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCleanBurstCamera.TsAnimNotifyStateCleanBurstCamera_C");
		}
		return TsAnimNotifyStateCleanBurstCamera._ClassPtr;
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00062F84 File Offset: 0x00061184
	public TsAnimNotifyStateCleanBurstCamera() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCleanBurstCamera.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00062FAC File Offset: 0x000611AC
	[NullableContext(1)]
	public TsAnimNotifyStateCleanBurstCamera(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCleanBurstCamera.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x00062FDF File Offset: 0x000611DF
	protected TsAnimNotifyStateCleanBurstCamera(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x00062FE8 File Offset: 0x000611E8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x00063024 File Offset: 0x00061224
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x00063060 File Offset: 0x00061260
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x00063093 File Offset: 0x00061293
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CFE RID: 3326
	private bool TsHideMesh;

	// Token: 0x04000CFF RID: 3327
	private bool TsHideEffect;

	// Token: 0x04000D00 RID: 3328
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EntityHandle, int> TsHiddenMap;

	// Token: 0x04000D01 RID: 3329
	private bool TsNoHitEffect;

	// Token: 0x04000D02 RID: 3330
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCleanBurstCamera.TsAnimNotifyStateCleanBurstCamera_C";

	// Token: 0x04000D03 RID: 3331
	private static IntPtr _ClassPtr;

	// Token: 0x04000D04 RID: 3332
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D05 RID: 3333
	private static int __PropertyOffset_隐藏敌对目标Mesh;

	// Token: 0x04000D06 RID: 3334
	private static int __PropertyOffset_隐藏敌对目标特效;

	// Token: 0x04000D07 RID: 3335
	private static int __PropertyOffset_不接受命中特效;
}

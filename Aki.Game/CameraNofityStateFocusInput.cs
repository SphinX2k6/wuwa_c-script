using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001EF RID: 495
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Camera/Event/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Camera/Event/CameraNofityStateFocusInput.CameraNofityStateFocusInput_C")]
public class CameraNofityStateFocusInput : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x06001F41 RID: 8001 RVA: 0x0009A5E4 File Offset: 0x000987E4
	// (set) Token: 0x06001F42 RID: 8002 RVA: 0x0009A5F4 File Offset: 0x000987F4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CameraNofityStateFocusInput.__PropertyOffset_MinDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)CameraNofityStateFocusInput.__PropertyOffset_MinDistance) = value;
		}
	}

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x06001F43 RID: 8003 RVA: 0x0009A605 File Offset: 0x00098805
	// (set) Token: 0x06001F44 RID: 8004 RVA: 0x0009A615 File Offset: 0x00098815
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CameraNofityStateFocusInput.__PropertyOffset_MaxDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)CameraNofityStateFocusInput.__PropertyOffset_MaxDistance) = value;
		}
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0009A626 File Offset: 0x00098826
	// (set) Token: 0x06001F46 RID: 8006 RVA: 0x0009A63A File Offset: 0x0009883A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string LockOnPart
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)CameraNofityStateFocusInput.__PropertyOffset_LockOnPart)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)CameraNofityStateFocusInput.__PropertyOffset_LockOnPart)), value);
		}
	}

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x06001F47 RID: 8007 RVA: 0x0009A64F File Offset: 0x0009884F
	// (set) Token: 0x06001F48 RID: 8008 RVA: 0x0009A65F File Offset: 0x0009885F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECameraAnsEffectiveClientType 生效客户端类型
	{
		get
		{
			return (ECameraAnsEffectiveClientType)(*(base.NativePtr + (IntPtr)CameraNofityStateFocusInput.__PropertyOffset_生效客户端类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)CameraNofityStateFocusInput.__PropertyOffset_生效客户端类型) = (byte)value;
		}
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x0009A670 File Offset: 0x00098870
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

	// Token: 0x06001F4A RID: 8010 RVA: 0x0009A718 File Offset: 0x00098918
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		if (this.LockOnMap.ContainsKey(tsBaseCharacter.EntityId))
		{
			return false;
		}
		EntityHandle entityByActor = ActorUtils.GetEntityByActor(owner, true);
		if (!CameraUtility.CheckCameraEffectiveClientType(entityByActor, this.生效客户端类型))
		{
			return false;
		}
		Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
		if (entityNoBlueprint != null && entityNoBlueprint.Valid)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				return false;
			}
			BaseActorComponent component = entityNoBlueprint.GetComponent<BaseActorComponent>();
			Vector v = (component != null) ? component.ActorLocationProxy : null;
			BaseActorComponent component2 = getCurrentEntity.Entity.GetComponent<BaseActorComponent>();
			Vector v2 = (component2 != null) ? component2.ActorLocationProxy : null;
			double num = Vector.Dist(v, v2);
			if (num < (double)this.MinDistance || num > (double)this.MaxDistance)
			{
				return false;
			}
			WorldEntity entity = getCurrentEntity.Entity;
			CharacterLockOnComponent characterLockOnComponent = (entity != null) ? entity.GetComponent<CharacterLockOnComponent>() : null;
			if (characterLockOnComponent != null)
			{
				LockOnInfo lockOnInfo = new LockOnInfo(null, "");
				lockOnInfo.EntityHandle = entityByActor;
				lockOnInfo.SocketName = ((this.LockOnPart == "None") ? "" : this.LockOnPart);
				this.LockOnMap[tsBaseCharacter.EntityId] = lockOnInfo;
				characterLockOnComponent.ForceLookAt(lockOnInfo, true);
			}
		}
		return false;
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x0009A850 File Offset: 0x00098A50
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

	// Token: 0x06001F4C RID: 8012 RVA: 0x0009A8F0 File Offset: 0x00098AF0
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		LockOnInfo target;
		if (!this.LockOnMap.TryGetValue(tsBaseCharacter.EntityId, out target))
		{
			return false;
		}
		if (!owner.IsValid())
		{
			return false;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null)
		{
			return false;
		}
		WorldEntity entity = getCurrentEntity.Entity;
		CharacterLockOnComponent characterLockOnComponent = (entity != null) ? entity.GetComponent<CharacterLockOnComponent>() : null;
		if (characterLockOnComponent != null)
		{
			characterLockOnComponent.ForceLookAt(target, false);
		}
		this.LockOnMap.Remove(tsBaseCharacter.EntityId);
		return true;
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x0009A978 File Offset: 0x00098B78
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

	// Token: 0x06001F4E RID: 8014 RVA: 0x0009A9F3 File Offset: 0x00098BF3
	protected override string GetNotifyName_Implementation()
	{
		return "强制锁定目标";
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x0009A9FA File Offset: 0x00098BFA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CameraNofityStateFocusInput._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Camera/Event/CameraNofityStateFocusInput.CameraNofityStateFocusInput_C");
		}
		return CameraNofityStateFocusInput._ClassPtr;
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x0009AA20 File Offset: 0x00098C20
	public CameraNofityStateFocusInput() : this(BuiltinUtils.AllocNativeUObject(CameraNofityStateFocusInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x0009AA48 File Offset: 0x00098C48
	public CameraNofityStateFocusInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CameraNofityStateFocusInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x0009AA7B File Offset: 0x00098C7B
	protected CameraNofityStateFocusInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x0009AA90 File Offset: 0x00098C90
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x0009AACC File Offset: 0x00098CCC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x0009AAFF File Offset: 0x00098CFF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012E7 RID: 4839
	private readonly Dictionary<int, LockOnInfo> LockOnMap = new Dictionary<int, LockOnInfo>();

	// Token: 0x040012E8 RID: 4840
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Camera/Event/CameraNofityStateFocusInput.CameraNofityStateFocusInput_C";

	// Token: 0x040012E9 RID: 4841
	private static IntPtr _ClassPtr;

	// Token: 0x040012EA RID: 4842
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012EB RID: 4843
	private static int __PropertyOffset_MinDistance;

	// Token: 0x040012EC RID: 4844
	private static int __PropertyOffset_MaxDistance;

	// Token: 0x040012ED RID: 4845
	private static int __PropertyOffset_LockOnPart;

	// Token: 0x040012EE RID: 4846
	private static int __PropertyOffset_生效客户端类型;
}

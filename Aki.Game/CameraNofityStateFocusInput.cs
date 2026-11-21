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

// Token: 0x020001F3 RID: 499
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Camera/Event/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Camera/Event/CameraNofityStateFocusInput.CameraNofityStateFocusInput_C")]
public class CameraNofityStateFocusInput : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000518 RID: 1304
	// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x000A196C File Offset: 0x0009FB6C
	// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x000A197C File Offset: 0x0009FB7C
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

	// Token: 0x17000519 RID: 1305
	// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x000A198D File Offset: 0x0009FB8D
	// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x000A199D File Offset: 0x0009FB9D
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

	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x000A19AE File Offset: 0x0009FBAE
	// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x000A19C2 File Offset: 0x0009FBC2
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

	// Token: 0x1700051B RID: 1307
	// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x000A19D7 File Offset: 0x0009FBD7
	// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x000A19E7 File Offset: 0x0009FBE7
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

	// Token: 0x06001FF8 RID: 8184 RVA: 0x000A19F8 File Offset: 0x0009FBF8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CameraNofityStateFocusInput) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), CameraNofityStateFocusInput.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001FF9 RID: 8185 RVA: 0x000A1AB8 File Offset: 0x0009FCB8
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

	// Token: 0x06001FFA RID: 8186 RVA: 0x000A1BF0 File Offset: 0x0009FDF0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CameraNofityStateFocusInput) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), CameraNofityStateFocusInput.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001FFB RID: 8187 RVA: 0x000A1CA8 File Offset: 0x0009FEA8
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

	// Token: 0x06001FFC RID: 8188 RVA: 0x000A1D30 File Offset: 0x0009FF30
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CameraNofityStateFocusInput) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), CameraNofityStateFocusInput.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001FFD RID: 8189 RVA: 0x000A1DC0 File Offset: 0x0009FFC0
	protected override string GetNotifyName_Implementation()
	{
		return "强制锁定目标";
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x000A1DC7 File Offset: 0x0009FFC7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CameraNofityStateFocusInput._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Camera/Event/CameraNofityStateFocusInput.CameraNofityStateFocusInput_C");
		}
		return CameraNofityStateFocusInput._ClassPtr;
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x000A1DEC File Offset: 0x0009FFEC
	public CameraNofityStateFocusInput() : this(BuiltinUtils.AllocNativeUObject(CameraNofityStateFocusInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002000 RID: 8192 RVA: 0x000A1E14 File Offset: 0x000A0014
	public CameraNofityStateFocusInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CameraNofityStateFocusInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x000A1E47 File Offset: 0x000A0047
	protected CameraNofityStateFocusInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x000A1E5C File Offset: 0x000A005C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x000A1E98 File Offset: 0x000A0098
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x000A1ECB File Offset: 0x000A00CB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400132A RID: 4906
	private readonly Dictionary<int, LockOnInfo> LockOnMap = new Dictionary<int, LockOnInfo>();

	// Token: 0x0400132B RID: 4907
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Camera/Event/CameraNofityStateFocusInput.CameraNofityStateFocusInput_C";

	// Token: 0x0400132C RID: 4908
	private static IntPtr _ClassPtr;

	// Token: 0x0400132D RID: 4909
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400132E RID: 4910
	private static int __PropertyOffset_MinDistance;

	// Token: 0x0400132F RID: 4911
	private static int __PropertyOffset_MaxDistance;

	// Token: 0x04001330 RID: 4912
	private static int __PropertyOffset_LockOnPart;

	// Token: 0x04001331 RID: 4913
	private static int __PropertyOffset_生效客户端类型;
}

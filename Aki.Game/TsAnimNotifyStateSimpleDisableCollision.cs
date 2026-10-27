using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000172 RID: 370
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSimpleDisableCollision.TsAnimNotifyStateSimpleDisableCollision_C")]
public class TsAnimNotifyStateSimpleDisableCollision : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600175F RID: 5983 RVA: 0x0007DF2B File Offset: 0x0007C12B
	static TsAnimNotifyStateSimpleDisableCollision()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateSimpleDisableCollision.CreateStaticDefaultValue), new Action(TsAnimNotifyStateSimpleDisableCollision.ResetStaticDefaultValue));
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x0007DF4A File Offset: 0x0007C14A
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, int>>();
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x0007DF56 File Offset: 0x0007C156
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap = null;
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x0007DF5E File Offset: 0x0007C15E
	[NullableContext(1)]
	[return: Nullable(2)]
	private BaseActorComponent GetActorComponent(TsBaseCharacter owner)
	{
		if (owner.CharacterActorComponent != null)
		{
			return owner.CharacterActorComponent;
		}
		return owner.SimpleNpcActorComponent;
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x0007DF78 File Offset: 0x0007C178
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

	// Token: 0x06001764 RID: 5988 RVA: 0x0007E020 File Offset: 0x0007C220
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			BaseActorComponent actorComponent = this.GetActorComponent(tsBaseCharacter);
			if (actorComponent == null || !actorComponent.Valid)
			{
				return true;
			}
			Dictionary<UAnimNotifyState, int> dictionary;
			if (!TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap.TryGetValue(meshComp, out dictionary))
			{
				dictionary = (TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap[meshComp] = new Dictionary<UAnimNotifyState, int>());
			}
			if (dictionary.ContainsKey(this))
			{
				return false;
			}
			int value = actorComponent.DisableCollision("TsAnimNotifyStateSimpleDisableCollision.K2_NotifyBegin");
			dictionary[this] = value;
		}
		return true;
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x0007E098 File Offset: 0x0007C298
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

	// Token: 0x06001766 RID: 5990 RVA: 0x0007E138 File Offset: 0x0007C338
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter && TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap.ContainsKey(meshComp))
		{
			Dictionary<UAnimNotifyState, int> dictionary = TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap[meshComp];
			if (dictionary.ContainsKey(this))
			{
				int handle = dictionary[this];
				EntityHandle handle2 = CharacterModel.Instance.GetHandle((owner as TsBaseCharacter).EntityId);
				if (handle2 != null && handle2.Valid)
				{
					BaseActorComponent actorComponent = this.GetActorComponent(owner as TsBaseCharacter);
					if (actorComponent != null)
					{
						actorComponent.EnableCollision(handle);
					}
				}
				dictionary.Remove(this);
				if (dictionary.Count == 0)
				{
					TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap.Remove(meshComp);
				}
			}
		}
		return true;
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x0007E1DC File Offset: 0x0007C3DC
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

	// Token: 0x06001768 RID: 5992 RVA: 0x0007E257 File Offset: 0x0007C457
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "禁用Actor碰撞";
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x0007E25E File Offset: 0x0007C45E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSimpleDisableCollision._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSimpleDisableCollision.TsAnimNotifyStateSimpleDisableCollision_C");
		}
		return TsAnimNotifyStateSimpleDisableCollision._ClassPtr;
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x0007E284 File Offset: 0x0007C484
	public TsAnimNotifyStateSimpleDisableCollision() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSimpleDisableCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x0007E2AC File Offset: 0x0007C4AC
	[NullableContext(1)]
	public TsAnimNotifyStateSimpleDisableCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSimpleDisableCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x0007E2DF File Offset: 0x0007C4DF
	protected TsAnimNotifyStateSimpleDisableCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x0007E2E8 File Offset: 0x0007C4E8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x0007E324 File Offset: 0x0007C524
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x0007E357 File Offset: 0x0007C557
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FE6 RID: 4070
	[Nullable(1)]
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, int>> collisionDisableHandleMap;

	// Token: 0x04000FE7 RID: 4071
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSimpleDisableCollision.TsAnimNotifyStateSimpleDisableCollision_C";

	// Token: 0x04000FE8 RID: 4072
	private static IntPtr _ClassPtr;

	// Token: 0x04000FE9 RID: 4073
	private static IntPtr _ClassDefaultObjectPtr;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000138 RID: 312
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideActor.TsAnimNotifyStateHideActor_C")]
public class TsAnimNotifyStateHideActor : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600131E RID: 4894 RVA: 0x0006B967 File Offset: 0x00069B67
	static TsAnimNotifyStateHideActor()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateHideActor.CreateStaticDefaultValue), new Action(TsAnimNotifyStateHideActor.ResetStaticDefaultValue));
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x0006B986 File Offset: 0x00069B86
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateHideActor.disableActorHandleMap = new Dictionary<int, int>();
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x0006B992 File Offset: 0x00069B92
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateHideActor.disableActorHandleMap = null;
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x0006B99C File Offset: 0x00069B9C
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

	// Token: 0x06001322 RID: 4898 RVA: 0x0006BA44 File Offset: 0x00069C44
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (owner is TsBaseCharacter)
		{
			if ((owner as TsBaseCharacter).CharacterActorComponent != null)
			{
				int value = (owner as TsBaseCharacter).CharacterActorComponent.DisableActor("TsAnimNotifyStateHideActor");
				TsAnimNotifyStateHideActor.disableActorHandleMap[(owner as TsBaseCharacter).CharacterActorComponent.Entity.Id] = value;
			}
			return true;
		}
		owner.SetActorHiddenInGame(true);
		return true;
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x0006BAB4 File Offset: 0x00069CB4
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

	// Token: 0x06001324 RID: 4900 RVA: 0x0006BB54 File Offset: 0x00069D54
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (owner is TsBaseCharacter)
		{
			if ((owner as TsBaseCharacter).CharacterActorComponent != null)
			{
				int id = (owner as TsBaseCharacter).CharacterActorComponent.Entity.Id;
				int handle;
				if (TsAnimNotifyStateHideActor.disableActorHandleMap.TryGetValue(id, out handle))
				{
					(owner as TsBaseCharacter).CharacterActorComponent.EnableActor(handle);
					TsAnimNotifyStateHideActor.disableActorHandleMap.Remove(id);
				}
			}
			return true;
		}
		owner.SetActorHiddenInGame(false);
		return true;
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x0006BBD0 File Offset: 0x00069DD0
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

	// Token: 0x06001326 RID: 4902 RVA: 0x0006BC4B File Offset: 0x00069E4B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏Actor";
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x0006BC52 File Offset: 0x00069E52
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateHideActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideActor.TsAnimNotifyStateHideActor_C");
		}
		return TsAnimNotifyStateHideActor._ClassPtr;
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x0006BC78 File Offset: 0x00069E78
	public TsAnimNotifyStateHideActor() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x0006BCA0 File Offset: 0x00069EA0
	[NullableContext(1)]
	public TsAnimNotifyStateHideActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x0006BCD3 File Offset: 0x00069ED3
	protected TsAnimNotifyStateHideActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x0006BCDC File Offset: 0x00069EDC
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x0006BD18 File Offset: 0x00069F18
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x0006BD4B File Offset: 0x00069F4B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E11 RID: 3601
	[Nullable(1)]
	private static Dictionary<int, int> disableActorHandleMap;

	// Token: 0x04000E12 RID: 3602
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideActor.TsAnimNotifyStateHideActor_C";

	// Token: 0x04000E13 RID: 3603
	private static IntPtr _ClassPtr;

	// Token: 0x04000E14 RID: 3604
	private static IntPtr _ClassDefaultObjectPtr;
}

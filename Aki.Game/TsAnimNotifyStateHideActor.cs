using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000139 RID: 313
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideActor.TsAnimNotifyStateHideActor_C")]
public class TsAnimNotifyStateHideActor : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600139C RID: 5020 RVA: 0x0006FE53 File Offset: 0x0006E053
	static TsAnimNotifyStateHideActor()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateHideActor.CreateStaticDefaultValue), new Action(TsAnimNotifyStateHideActor.ResetStaticDefaultValue));
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x0006FE72 File Offset: 0x0006E072
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateHideActor.disableActorHandleMap = new Dictionary<int, int>();
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x0006FE7E File Offset: 0x0006E07E
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateHideActor.disableActorHandleMap = null;
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x0006FE88 File Offset: 0x0006E088
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateHideActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateHideActor.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013A0 RID: 5024 RVA: 0x0006FF48 File Offset: 0x0006E148
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

	// Token: 0x060013A1 RID: 5025 RVA: 0x0006FFB8 File Offset: 0x0006E1B8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateHideActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateHideActor.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013A2 RID: 5026 RVA: 0x00070070 File Offset: 0x0006E270
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

	// Token: 0x060013A3 RID: 5027 RVA: 0x000700EC File Offset: 0x0006E2EC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateHideActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateHideActor.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013A4 RID: 5028 RVA: 0x0007017C File Offset: 0x0006E37C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏Actor";
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x00070183 File Offset: 0x0006E383
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateHideActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideActor.TsAnimNotifyStateHideActor_C");
		}
		return TsAnimNotifyStateHideActor._ClassPtr;
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x000701A8 File Offset: 0x0006E3A8
	public TsAnimNotifyStateHideActor() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x000701D0 File Offset: 0x0006E3D0
	[NullableContext(1)]
	public TsAnimNotifyStateHideActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x00070203 File Offset: 0x0006E403
	protected TsAnimNotifyStateHideActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x0007020C File Offset: 0x0006E40C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x00070248 File Offset: 0x0006E448
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x0007027B File Offset: 0x0006E47B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E43 RID: 3651
	[Nullable(1)]
	private static Dictionary<int, int> disableActorHandleMap;

	// Token: 0x04000E44 RID: 3652
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideActor.TsAnimNotifyStateHideActor_C";

	// Token: 0x04000E45 RID: 3653
	private static IntPtr _ClassPtr;

	// Token: 0x04000E46 RID: 3654
	private static IntPtr _ClassDefaultObjectPtr;
}

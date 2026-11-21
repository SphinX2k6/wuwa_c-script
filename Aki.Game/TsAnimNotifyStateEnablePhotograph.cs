using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200012F RID: 303
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnablePhotograph.TsAnimNotifyStateEnablePhotograph_C")]
public class TsAnimNotifyStateEnablePhotograph : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700031F RID: 799
	// (get) Token: 0x060012BF RID: 4799 RVA: 0x0006AE47 File Offset: 0x00069047
	// (set) Token: 0x060012C0 RID: 4800 RVA: 0x0006AE5B File Offset: 0x0006905B
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string MontageTag
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateEnablePhotograph.__PropertyOffset_MontageTag)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateEnablePhotograph.__PropertyOffset_MontageTag)), value);
		}
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x0006AE70 File Offset: 0x00069070
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateEnablePhotograph) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateEnablePhotograph.StaticClass(), out intPtr, out num))
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

	// Token: 0x060012C2 RID: 4802 RVA: 0x0006AF30 File Offset: 0x00069130
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity != null)
			{
				int pbDataId = entity.GetComponent<CreatureDataComponent>().GetPbDataId();
				HashSet<string> valueOrDefault = PhotographModel.Instance.MontageTagSet.GetValueOrDefault(pbDataId);
				if (valueOrDefault != null)
				{
					valueOrDefault.Add(this.MontageTag);
				}
				else
				{
					HashSet<string> value = new HashSet<string>
					{
						this.MontageTag
					};
					PhotographModel.Instance.MontageTagSet[pbDataId] = value;
				}
			}
		}
		return true;
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x0006AFC0 File Offset: 0x000691C0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateEnablePhotograph) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateEnablePhotograph.StaticClass(), out intPtr, out num))
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

	// Token: 0x060012C4 RID: 4804 RVA: 0x0006B078 File Offset: 0x00069278
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity != null)
			{
				int pbDataId = entity.GetComponent<CreatureDataComponent>().GetPbDataId();
				HashSet<string> valueOrDefault = PhotographModel.Instance.MontageTagSet.GetValueOrDefault(pbDataId);
				if (valueOrDefault != null)
				{
					valueOrDefault.Remove(this.MontageTag);
					if (valueOrDefault.Count == 0)
					{
						PhotographModel.Instance.MontageTagSet.Remove(pbDataId);
					}
				}
			}
		}
		return true;
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x0006B0F6 File Offset: 0x000692F6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateEnablePhotograph._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnablePhotograph.TsAnimNotifyStateEnablePhotograph_C");
		}
		return TsAnimNotifyStateEnablePhotograph._ClassPtr;
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x0006B11C File Offset: 0x0006931C
	public TsAnimNotifyStateEnablePhotograph() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnablePhotograph.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x0006B144 File Offset: 0x00069344
	[NullableContext(1)]
	public TsAnimNotifyStateEnablePhotograph(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnablePhotograph.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x0006B177 File Offset: 0x00069377
	protected TsAnimNotifyStateEnablePhotograph(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x0006B180 File Offset: 0x00069380
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x0006B1BC File Offset: 0x000693BC
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000DE2 RID: 3554
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnablePhotograph.TsAnimNotifyStateEnablePhotograph_C";

	// Token: 0x04000DE3 RID: 3555
	private static IntPtr _ClassPtr;

	// Token: 0x04000DE4 RID: 3556
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000DE5 RID: 3557
	private static int __PropertyOffset_MontageTag;
}

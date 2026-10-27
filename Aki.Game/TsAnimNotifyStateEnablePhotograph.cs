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
	// Token: 0x1700031C RID: 796
	// (get) Token: 0x060012B9 RID: 4793 RVA: 0x000694F3 File Offset: 0x000676F3
	// (set) Token: 0x060012BA RID: 4794 RVA: 0x00069507 File Offset: 0x00067707
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

	// Token: 0x060012BB RID: 4795 RVA: 0x0006951C File Offset: 0x0006771C
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

	// Token: 0x060012BC RID: 4796 RVA: 0x000695C4 File Offset: 0x000677C4
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

	// Token: 0x060012BD RID: 4797 RVA: 0x00069654 File Offset: 0x00067854
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

	// Token: 0x060012BE RID: 4798 RVA: 0x000696F4 File Offset: 0x000678F4
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

	// Token: 0x060012BF RID: 4799 RVA: 0x00069772 File Offset: 0x00067972
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateEnablePhotograph._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnablePhotograph.TsAnimNotifyStateEnablePhotograph_C");
		}
		return TsAnimNotifyStateEnablePhotograph._ClassPtr;
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00069798 File Offset: 0x00067998
	public TsAnimNotifyStateEnablePhotograph() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnablePhotograph.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x000697C0 File Offset: 0x000679C0
	[NullableContext(1)]
	public TsAnimNotifyStateEnablePhotograph(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnablePhotograph.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x000697F3 File Offset: 0x000679F3
	protected TsAnimNotifyStateEnablePhotograph(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x000697FC File Offset: 0x000679FC
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x00069838 File Offset: 0x00067A38
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000DDA RID: 3546
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnablePhotograph.TsAnimNotifyStateEnablePhotograph_C";

	// Token: 0x04000DDB RID: 3547
	private static IntPtr _ClassPtr;

	// Token: 0x04000DDC RID: 3548
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000DDD RID: 3549
	private static int __PropertyOffset_MontageTag;
}

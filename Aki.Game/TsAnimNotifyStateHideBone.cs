using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200013A RID: 314
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideBone.TsAnimNotifyStateHideBone_C")]
public class TsAnimNotifyStateHideBone : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000325 RID: 805
	// (get) Token: 0x06001340 RID: 4928 RVA: 0x0006C47B File Offset: 0x0006A67B
	// (set) Token: 0x06001341 RID: 4929 RVA: 0x0006C48F File Offset: 0x0006A68F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BoneName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateHideBone.__PropertyOffset_BoneName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateHideBone.__PropertyOffset_BoneName)), value);
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x06001342 RID: 4930 RVA: 0x0006C4A4 File Offset: 0x0006A6A4
	// (set) Token: 0x06001343 RID: 4931 RVA: 0x0006C4B8 File Offset: 0x0006A6B8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string IgnoreTsBaseCharacter
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateHideBone.__PropertyOffset_IgnoreTsBaseCharacter)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateHideBone.__PropertyOffset_IgnoreTsBaseCharacter)), value);
		}
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x0006C4D0 File Offset: 0x0006A6D0
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

	// Token: 0x06001345 RID: 4933 RVA: 0x0006C578 File Offset: 0x0006A778
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (!string.IsNullOrEmpty(this.IgnoreTsBaseCharacter))
		{
			MeshComponentUtils.HideBone(meshComp, this.BoneName, true);
			return true;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterAnimationComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterAnimationComponent>();
			if (component != null)
			{
				component.HideBone(FNameUtil.GetDynamicFName(this.BoneName).Value, true, false);
			}
		}
		return true;
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x0006C5E4 File Offset: 0x0006A7E4
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

	// Token: 0x06001347 RID: 4935 RVA: 0x0006C684 File Offset: 0x0006A884
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!string.IsNullOrEmpty(this.IgnoreTsBaseCharacter))
		{
			MeshComponentUtils.HideBone(meshComp, this.BoneName, false);
			return true;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			CharacterAnimationComponent characterAnimationComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CharacterAnimationComponent>() : null;
			if (characterAnimationComponent != null)
			{
				characterAnimationComponent.HideBone(FNameUtil.GetDynamicFName(this.BoneName).Value, false, false);
			}
		}
		return true;
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x0006C6F4 File Offset: 0x0006A8F4
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

	// Token: 0x06001349 RID: 4937 RVA: 0x0006C76F File Offset: 0x0006A96F
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏骨骼";
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x0006C776 File Offset: 0x0006A976
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateHideBone._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideBone.TsAnimNotifyStateHideBone_C");
		}
		return TsAnimNotifyStateHideBone._ClassPtr;
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x0006C79C File Offset: 0x0006A99C
	public TsAnimNotifyStateHideBone() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideBone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x0006C7C4 File Offset: 0x0006A9C4
	public TsAnimNotifyStateHideBone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideBone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x0006C7F7 File Offset: 0x0006A9F7
	protected TsAnimNotifyStateHideBone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x0006C800 File Offset: 0x0006AA00
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x0006C83C File Offset: 0x0006AA3C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x0006C86F File Offset: 0x0006AA6F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E1C RID: 3612
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideBone.TsAnimNotifyStateHideBone_C";

	// Token: 0x04000E1D RID: 3613
	private static IntPtr _ClassPtr;

	// Token: 0x04000E1E RID: 3614
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E1F RID: 3615
	private static int __PropertyOffset_BoneName;

	// Token: 0x04000E20 RID: 3616
	private static int __PropertyOffset_IgnoreTsBaseCharacter;
}

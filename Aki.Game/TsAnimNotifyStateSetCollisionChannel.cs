using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000162 RID: 354
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionChannel.TsAnimNotifyStateSetCollisionChannel_C")]
public class TsAnimNotifyStateSetCollisionChannel : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003AC RID: 940
	// (get) Token: 0x0600164C RID: 5708 RVA: 0x00079DA8 File Offset: 0x00077FA8
	[Nullable(new byte[]
	{
		1,
		0
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<TEnumAsByte<ECollisionChannel>> IgnoreChannels
	{
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		get
		{
			base.FastCheckIsValid();
			TArray<TEnumAsByte<ECollisionChannel>> result;
			if ((result = this._IgnoreChannels) == null)
			{
				result = (this._IgnoreChannels = new TArray<TEnumAsByte<ECollisionChannel>>(base.NativePtr + (IntPtr)TsAnimNotifyStateSetCollisionChannel.__PropertyOffset_IgnoreChannels, this));
			}
			return result;
		}
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x00079DE4 File Offset: 0x00077FE4
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

	// Token: 0x0600164E RID: 5710 RVA: 0x00079E8C File Offset: 0x0007808C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			int num = this.IgnoreChannels.Num();
			for (int i = 0; i < num; i++)
			{
				tsBaseCharacter.CapsuleComponent.SetCollisionResponseToChannel(this.IgnoreChannels.Get(i), ECollisionResponse.ECR_Ignore);
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x00079EE0 File Offset: 0x000780E0
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

	// Token: 0x06001650 RID: 5712 RVA: 0x00079F80 File Offset: 0x00078180
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			int num = this.IgnoreChannels.Num();
			for (int i = 0; i < num; i++)
			{
				tsBaseCharacter.CapsuleComponent.SetCollisionResponseToChannel(this.IgnoreChannels.Get(i), ECollisionResponse.ECR_Block);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x00079FD4 File Offset: 0x000781D4
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

	// Token: 0x06001652 RID: 5714 RVA: 0x0007A04F File Offset: 0x0007824F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置碰撞预设";
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x0007A056 File Offset: 0x00078256
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetCollisionChannel._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionChannel.TsAnimNotifyStateSetCollisionChannel_C");
		}
		return TsAnimNotifyStateSetCollisionChannel._ClassPtr;
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x0007A07C File Offset: 0x0007827C
	public TsAnimNotifyStateSetCollisionChannel() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetCollisionChannel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x0007A0A4 File Offset: 0x000782A4
	[NullableContext(1)]
	public TsAnimNotifyStateSetCollisionChannel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetCollisionChannel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x0007A0D7 File Offset: 0x000782D7
	protected TsAnimNotifyStateSetCollisionChannel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x0007A0E0 File Offset: 0x000782E0
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x0007A11C File Offset: 0x0007831C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x0007A14F File Offset: 0x0007834F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F87 RID: 3975
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionChannel.TsAnimNotifyStateSetCollisionChannel_C";

	// Token: 0x04000F88 RID: 3976
	private static IntPtr _ClassPtr;

	// Token: 0x04000F89 RID: 3977
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F8A RID: 3978
	private static int __PropertyOffset_IgnoreChannels;

	// Token: 0x04000F8B RID: 3979
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private TArray<TEnumAsByte<ECollisionChannel>> _IgnoreChannels;
}

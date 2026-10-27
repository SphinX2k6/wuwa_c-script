using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D7 RID: 471
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMovementMode.TsAnimNotifySetMovementMode_C")]
public class TsAnimNotifySetMovementMode : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004B2 RID: 1202
	// (get) Token: 0x06001D57 RID: 7511 RVA: 0x000941AF File Offset: 0x000923AF
	// (set) Token: 0x06001D58 RID: 7512 RVA: 0x000941C3 File Offset: 0x000923C3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EMovementMode> MovementMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySetMovementMode.__PropertyOffset_MovementMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySetMovementMode.__PropertyOffset_MovementMode) = value;
		}
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x000941D8 File Offset: 0x000923D8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x06001D5A RID: 7514 RVA: 0x00094278 File Offset: 0x00092478
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			tsBaseCharacter.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = this.MovementMode,
				Context = "[TsAnimNotifySetMovementMode.K2_Notify]"
			});
		}
		return true;
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x000942BC File Offset: 0x000924BC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001D5C RID: 7516 RVA: 0x00094337 File Offset: 0x00092537
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置移动模式";
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x0009433E File Offset: 0x0009253E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySetMovementMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMovementMode.TsAnimNotifySetMovementMode_C");
		}
		return TsAnimNotifySetMovementMode._ClassPtr;
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x00094364 File Offset: 0x00092564
	public TsAnimNotifySetMovementMode() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetMovementMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x0009438C File Offset: 0x0009258C
	[NullableContext(1)]
	public TsAnimNotifySetMovementMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetMovementMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x000943BF File Offset: 0x000925BF
	protected TsAnimNotifySetMovementMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x000943C8 File Offset: 0x000925C8
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x000943FB File Offset: 0x000925FB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001243 RID: 4675
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMovementMode.TsAnimNotifySetMovementMode_C";

	// Token: 0x04001244 RID: 4676
	private static IntPtr _ClassPtr;

	// Token: 0x04001245 RID: 4677
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001246 RID: 4678
	private static int __PropertyOffset_MovementMode;
}

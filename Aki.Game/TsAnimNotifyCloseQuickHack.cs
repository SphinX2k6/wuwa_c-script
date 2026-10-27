using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuickHack;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001AA RID: 426
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCloseQuickHack.TsAnimNotifyCloseQuickHack_C")]
public class TsAnimNotifyCloseQuickHack : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001AF1 RID: 6897 RVA: 0x0008BBA8 File Offset: 0x00089DA8
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

	// Token: 0x06001AF2 RID: 6898 RVA: 0x0008BC48 File Offset: 0x00089E48
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.IsAutonomousProxy)
			{
				QuickHackController.Instance.CloseQuickHack();
			}
		}
		return true;
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x0008BC84 File Offset: 0x00089E84
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

	// Token: 0x06001AF4 RID: 6900 RVA: 0x0008BCFF File Offset: 0x00089EFF
	protected override string GetNotifyName_Implementation()
	{
		return "关闭快速破解";
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x0008BD06 File Offset: 0x00089F06
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCloseQuickHack._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCloseQuickHack.TsAnimNotifyCloseQuickHack_C");
		}
		return TsAnimNotifyCloseQuickHack._ClassPtr;
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x0008BD2C File Offset: 0x00089F2C
	public TsAnimNotifyCloseQuickHack() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCloseQuickHack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x0008BD54 File Offset: 0x00089F54
	public TsAnimNotifyCloseQuickHack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCloseQuickHack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x0008BD87 File Offset: 0x00089F87
	protected TsAnimNotifyCloseQuickHack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x0008BD90 File Offset: 0x00089F90
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x0008BDC3 File Offset: 0x00089FC3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001159 RID: 4441
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCloseQuickHack.TsAnimNotifyCloseQuickHack_C";

	// Token: 0x0400115A RID: 4442
	private static IntPtr _ClassPtr;

	// Token: 0x0400115B RID: 4443
	private static IntPtr _ClassDefaultObjectPtr;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuickHack;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C5 RID: 453
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyOpenQuickHack.TsAnimNotifyOpenQuickHack_C")]
public class TsAnimNotifyOpenQuickHack : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000487 RID: 1159
	// (get) Token: 0x06001C51 RID: 7249 RVA: 0x0009093F File Offset: 0x0008EB3F
	// (set) Token: 0x06001C52 RID: 7250 RVA: 0x0009094F File Offset: 0x0008EB4F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int DeviceId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_DeviceId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_DeviceId) = value;
		}
	}

	// Token: 0x17000488 RID: 1160
	// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00090960 File Offset: 0x0008EB60
	// (set) Token: 0x06001C54 RID: 7252 RVA: 0x00090970 File Offset: 0x0008EB70
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CloseWhenInteractFinish
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_CloseWhenInteractFinish) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_CloseWhenInteractFinish) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000489 RID: 1161
	// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00090981 File Offset: 0x0008EB81
	// (set) Token: 0x06001C56 RID: 7254 RVA: 0x00090995 File Offset: 0x0008EB95
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag InteractFinishGameplayEventTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_InteractFinishGameplayEventTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_InteractFinishGameplayEventTag) = value;
		}
	}

	// Token: 0x06001C57 RID: 7255 RVA: 0x000909AC File Offset: 0x0008EBAC
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

	// Token: 0x06001C58 RID: 7256 RVA: 0x00090A4C File Offset: 0x0008EC4C
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		int deviceId = this.DeviceId;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.IsAutonomousProxy && deviceId > 0)
			{
				QuickHackController.Instance.OpenQuickHack(deviceId, tsBaseCharacter.GetEntityIdNoBlueprint(), this.CloseWhenInteractFinish, new FGameplayTag?(this.InteractFinishGameplayEventTag), null);
			}
		}
		return true;
	}

	// Token: 0x06001C59 RID: 7257 RVA: 0x00090AAC File Offset: 0x0008ECAC
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

	// Token: 0x06001C5A RID: 7258 RVA: 0x00090B27 File Offset: 0x0008ED27
	protected override string GetNotifyName_Implementation()
	{
		return "开启快速破解";
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x00090B2E File Offset: 0x0008ED2E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyOpenQuickHack._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyOpenQuickHack.TsAnimNotifyOpenQuickHack_C");
		}
		return TsAnimNotifyOpenQuickHack._ClassPtr;
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x00090B54 File Offset: 0x0008ED54
	public TsAnimNotifyOpenQuickHack() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyOpenQuickHack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x00090B7C File Offset: 0x0008ED7C
	public TsAnimNotifyOpenQuickHack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyOpenQuickHack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C5E RID: 7262 RVA: 0x00090BAF File Offset: 0x0008EDAF
	protected TsAnimNotifyOpenQuickHack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C5F RID: 7263 RVA: 0x00090BB8 File Offset: 0x0008EDB8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C60 RID: 7264 RVA: 0x00090BEB File Offset: 0x0008EDEB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011DC RID: 4572
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyOpenQuickHack.TsAnimNotifyOpenQuickHack_C";

	// Token: 0x040011DD RID: 4573
	private static IntPtr _ClassPtr;

	// Token: 0x040011DE RID: 4574
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011DF RID: 4575
	private static int __PropertyOffset_DeviceId;

	// Token: 0x040011E0 RID: 4576
	private static int __PropertyOffset_CloseWhenInteractFinish;

	// Token: 0x040011E1 RID: 4577
	private static int __PropertyOffset_InteractFinishGameplayEventTag;
}

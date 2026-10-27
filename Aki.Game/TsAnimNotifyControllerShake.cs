using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Module.Gamepad;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001AB RID: 427
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyControllerShake.TsAnimNotifyControllerShake_C")]
public class TsAnimNotifyControllerShake : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700045C RID: 1116
	// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0008BDD7 File Offset: 0x00089FD7
	// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0008BDEB File Offset: 0x00089FEB
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroForceFeedbackEffect Effect
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroForceFeedbackEffect>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyControllerShake.__PropertyOffset_Effect);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyControllerShake.__PropertyOffset_Effect, value);
		}
	}

	// Token: 0x1700045D RID: 1117
	// (get) Token: 0x06001AFD RID: 6909 RVA: 0x0008BE00 File Offset: 0x0008A000
	// (set) Token: 0x06001AFE RID: 6910 RVA: 0x0008BE14 File Offset: 0x0008A014
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName Name
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyControllerShake.__PropertyOffset_Name);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyControllerShake.__PropertyOffset_Name) = value;
		}
	}

	// Token: 0x1700045E RID: 1118
	// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0008BE29 File Offset: 0x0008A029
	// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0008BE39 File Offset: 0x0008A039
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsLooping
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyControllerShake.__PropertyOffset_IsLooping) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyControllerShake.__PropertyOffset_IsLooping) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700045F RID: 1119
	// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0008BE4A File Offset: 0x0008A04A
	// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0008BE5A File Offset: 0x0008A05A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsIgnoreTimeDilation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyControllerShake.__PropertyOffset_IsIgnoreTimeDilation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyControllerShake.__PropertyOffset_IsIgnoreTimeDilation) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000460 RID: 1120
	// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0008BE6B File Offset: 0x0008A06B
	// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0008BE7B File Offset: 0x0008A07B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsPlayWhilePaused
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyControllerShake.__PropertyOffset_IsPlayWhilePaused) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyControllerShake.__PropertyOffset_IsPlayWhilePaused) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x0008BE8C File Offset: 0x0008A08C
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

	// Token: 0x06001B06 RID: 6918 RVA: 0x0008BF2C File Offset: 0x0008A12C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!Info.Instance.IsInGamepad())
		{
			return true;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.IsAutonomousProxy && Global.CharacterController != null)
			{
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(tsBaseCharacter.GetEntityIdNoBlueprint());
				if (entityById == null || !entityById.Valid)
				{
					return false;
				}
				if (!CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityById))
				{
					return false;
				}
				GamepadController.Instance.PlayKuroForceFeedback(this.Effect, new FName?(this.Name), this.IsLooping, this.IsIgnoreTimeDilation, this.IsPlayWhilePaused, "TsAnimNotifyControllerShake");
			}
		}
		return true;
	}

	// Token: 0x06001B07 RID: 6919 RVA: 0x0008BFD4 File Offset: 0x0008A1D4
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

	// Token: 0x06001B08 RID: 6920 RVA: 0x0008C04F File Offset: 0x0008A24F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "手柄震动";
	}

	// Token: 0x06001B09 RID: 6921 RVA: 0x0008C056 File Offset: 0x0008A256
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyControllerShake._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyControllerShake.TsAnimNotifyControllerShake_C");
		}
		return TsAnimNotifyControllerShake._ClassPtr;
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x0008C07C File Offset: 0x0008A27C
	public TsAnimNotifyControllerShake() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyControllerShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x0008C0A4 File Offset: 0x0008A2A4
	[NullableContext(1)]
	public TsAnimNotifyControllerShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyControllerShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x0008C0D7 File Offset: 0x0008A2D7
	protected TsAnimNotifyControllerShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x0008C0E0 File Offset: 0x0008A2E0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x0008C113 File Offset: 0x0008A313
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400115C RID: 4444
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyControllerShake.TsAnimNotifyControllerShake_C";

	// Token: 0x0400115D RID: 4445
	private static IntPtr _ClassPtr;

	// Token: 0x0400115E RID: 4446
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400115F RID: 4447
	private static int __PropertyOffset_Effect;

	// Token: 0x04001160 RID: 4448
	private static int __PropertyOffset_Name;

	// Token: 0x04001161 RID: 4449
	private static int __PropertyOffset_IsLooping;

	// Token: 0x04001162 RID: 4450
	private static int __PropertyOffset_IsIgnoreTimeDilation;

	// Token: 0x04001163 RID: 4451
	private static int __PropertyOffset_IsPlayWhilePaused;
}

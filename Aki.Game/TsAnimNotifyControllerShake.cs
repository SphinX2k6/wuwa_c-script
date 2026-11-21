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

// Token: 0x020001AF RID: 431
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyControllerShake.TsAnimNotifyControllerShake_C")]
public class TsAnimNotifyControllerShake : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700047E RID: 1150
	// (get) Token: 0x06001B98 RID: 7064 RVA: 0x000925AB File Offset: 0x000907AB
	// (set) Token: 0x06001B99 RID: 7065 RVA: 0x000925BF File Offset: 0x000907BF
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

	// Token: 0x1700047F RID: 1151
	// (get) Token: 0x06001B9A RID: 7066 RVA: 0x000925D4 File Offset: 0x000907D4
	// (set) Token: 0x06001B9B RID: 7067 RVA: 0x000925E8 File Offset: 0x000907E8
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

	// Token: 0x17000480 RID: 1152
	// (get) Token: 0x06001B9C RID: 7068 RVA: 0x000925FD File Offset: 0x000907FD
	// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0009260D File Offset: 0x0009080D
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

	// Token: 0x17000481 RID: 1153
	// (get) Token: 0x06001B9E RID: 7070 RVA: 0x0009261E File Offset: 0x0009081E
	// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0009262E File Offset: 0x0009082E
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

	// Token: 0x17000482 RID: 1154
	// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0009263F File Offset: 0x0009083F
	// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0009264F File Offset: 0x0009084F
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

	// Token: 0x06001BA2 RID: 7074 RVA: 0x00092660 File Offset: 0x00090860
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyControllerShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyControllerShake.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x00092718 File Offset: 0x00090918
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

	// Token: 0x06001BA4 RID: 7076 RVA: 0x000927C0 File Offset: 0x000909C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyControllerShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyControllerShake.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x00092850 File Offset: 0x00090A50
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "手柄震动";
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x00092857 File Offset: 0x00090A57
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyControllerShake._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyControllerShake.TsAnimNotifyControllerShake_C");
		}
		return TsAnimNotifyControllerShake._ClassPtr;
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x0009287C File Offset: 0x00090A7C
	public TsAnimNotifyControllerShake() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyControllerShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x000928A4 File Offset: 0x00090AA4
	[NullableContext(1)]
	public TsAnimNotifyControllerShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyControllerShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x000928D7 File Offset: 0x00090AD7
	protected TsAnimNotifyControllerShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x000928E0 File Offset: 0x00090AE0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x00092913 File Offset: 0x00090B13
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400119F RID: 4511
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyControllerShake.TsAnimNotifyControllerShake_C";

	// Token: 0x040011A0 RID: 4512
	private static IntPtr _ClassPtr;

	// Token: 0x040011A1 RID: 4513
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011A2 RID: 4514
	private static int __PropertyOffset_Effect;

	// Token: 0x040011A3 RID: 4515
	private static int __PropertyOffset_Name;

	// Token: 0x040011A4 RID: 4516
	private static int __PropertyOffset_IsLooping;

	// Token: 0x040011A5 RID: 4517
	private static int __PropertyOffset_IsIgnoreTimeDilation;

	// Token: 0x040011A6 RID: 4518
	private static int __PropertyOffset_IsPlayWhilePaused;
}

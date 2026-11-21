using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200010D RID: 269
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttachActorToSocket.TsAnimNotifyStateAttachActorToSocket_C")]
public class TsAnimNotifyStateAttachActorToSocket : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000288 RID: 648
	// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0005C113 File Offset: 0x0005A313
	// (set) Token: 0x06000FCA RID: 4042 RVA: 0x0005C127 File Offset: 0x0005A327
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_SocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_SocketName) = value;
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0005C13C File Offset: 0x0005A33C
	// (set) Token: 0x06000FCC RID: 4044 RVA: 0x0005C150 File Offset: 0x0005A350
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName ActorTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_ActorTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_ActorTag) = value;
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0005C165 File Offset: 0x0005A365
	// (set) Token: 0x06000FCE RID: 4046 RVA: 0x0005C175 File Offset: 0x0005A375
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAttachmentRule LocationAttachRule
	{
		get
		{
			return (EAttachmentRule)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_LocationAttachRule));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_LocationAttachRule) = (byte)value;
		}
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0005C186 File Offset: 0x0005A386
	// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x0005C196 File Offset: 0x0005A396
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAttachmentRule RotationAttachRule
	{
		get
		{
			return (EAttachmentRule)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_RotationAttachRule));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_RotationAttachRule) = (byte)value;
		}
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0005C1A7 File Offset: 0x0005A3A7
	// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x0005C1B7 File Offset: 0x0005A3B7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAttachmentRule ScaleAttachRule
	{
		get
		{
			return (EAttachmentRule)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_ScaleAttachRule));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_ScaleAttachRule) = (byte)value;
		}
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0005C1C8 File Offset: 0x0005A3C8
	// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x0005C1D8 File Offset: 0x0005A3D8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EDetachmentRule LocationDetachRule
	{
		get
		{
			return (EDetachmentRule)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_LocationDetachRule));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_LocationDetachRule) = (byte)value;
		}
	}

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x0005C1E9 File Offset: 0x0005A3E9
	// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x0005C1F9 File Offset: 0x0005A3F9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EDetachmentRule RotationDetachRule
	{
		get
		{
			return (EDetachmentRule)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_RotationDetachRule));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_RotationDetachRule) = (byte)value;
		}
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x0005C20A File Offset: 0x0005A40A
	// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x0005C21A File Offset: 0x0005A41A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EDetachmentRule ScaleDetachRule
	{
		get
		{
			return (EDetachmentRule)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_ScaleDetachRule));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachActorToSocket.__PropertyOffset_ScaleDetachRule) = (byte)value;
		}
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x0005C22C File Offset: 0x0005A42C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttachActorToSocket) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAttachActorToSocket.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000FDA RID: 4058 RVA: 0x0005C2EC File Offset: 0x0005A4EC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.ActorTag == null)
		{
			return false;
		}
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(this.ActorTag, ECollectActorType.Default);
		if (actorWithTag == null)
		{
			return false;
		}
		if (actorWithTag != null)
		{
			actorWithTag.K2_AttachToComponent(meshComp, this.SocketName, this.LocationAttachRule, this.RotationAttachRule, this.ScaleAttachRule, false, true);
		}
		return true;
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x0005C348 File Offset: 0x0005A548
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttachActorToSocket) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAttachActorToSocket.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComponent, animSequence);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animSequence != null) ? animSequence.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x0005C400 File Offset: 0x0005A600
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		if (this.ActorTag == null)
		{
			return false;
		}
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(this.ActorTag, ECollectActorType.Default);
		if (actorWithTag == null)
		{
			return false;
		}
		if (actorWithTag != null)
		{
			actorWithTag.K2_DetachFromActor(this.LocationDetachRule, this.RotationDetachRule, this.ScaleDetachRule);
		}
		return true;
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x0005C450 File Offset: 0x0005A650
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttachActorToSocket) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAttachActorToSocket.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000FDE RID: 4062 RVA: 0x0005C4E0 File Offset: 0x0005A6E0
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "附加Actor到Socket";
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x0005C4E7 File Offset: 0x0005A6E7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAttachActorToSocket._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttachActorToSocket.TsAnimNotifyStateAttachActorToSocket_C");
		}
		return TsAnimNotifyStateAttachActorToSocket._ClassPtr;
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x0005C50C File Offset: 0x0005A70C
	public TsAnimNotifyStateAttachActorToSocket() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttachActorToSocket.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x0005C534 File Offset: 0x0005A734
	[NullableContext(1)]
	public TsAnimNotifyStateAttachActorToSocket(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttachActorToSocket.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x0005C567 File Offset: 0x0005A767
	protected TsAnimNotifyStateAttachActorToSocket(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x0005C570 File Offset: 0x0005A770
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x0005C5AC File Offset: 0x0005A7AC
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x0005C5DF File Offset: 0x0005A7DF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C53 RID: 3155
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttachActorToSocket.TsAnimNotifyStateAttachActorToSocket_C";

	// Token: 0x04000C54 RID: 3156
	private static IntPtr _ClassPtr;

	// Token: 0x04000C55 RID: 3157
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C56 RID: 3158
	private static int __PropertyOffset_SocketName;

	// Token: 0x04000C57 RID: 3159
	private static int __PropertyOffset_ActorTag;

	// Token: 0x04000C58 RID: 3160
	private static int __PropertyOffset_LocationAttachRule;

	// Token: 0x04000C59 RID: 3161
	private static int __PropertyOffset_RotationAttachRule;

	// Token: 0x04000C5A RID: 3162
	private static int __PropertyOffset_ScaleAttachRule;

	// Token: 0x04000C5B RID: 3163
	private static int __PropertyOffset_LocationDetachRule;

	// Token: 0x04000C5C RID: 3164
	private static int __PropertyOffset_RotationDetachRule;

	// Token: 0x04000C5D RID: 3165
	private static int __PropertyOffset_ScaleDetachRule;
}

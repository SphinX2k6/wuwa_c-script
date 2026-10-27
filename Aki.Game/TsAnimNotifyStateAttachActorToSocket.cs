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
	// Token: 0x17000285 RID: 645
	// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x0005AFAF File Offset: 0x000591AF
	// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x0005AFC3 File Offset: 0x000591C3
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

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0005AFD8 File Offset: 0x000591D8
	// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x0005AFEC File Offset: 0x000591EC
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

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0005B001 File Offset: 0x00059201
	// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x0005B011 File Offset: 0x00059211
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

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0005B022 File Offset: 0x00059222
	// (set) Token: 0x06000FCA RID: 4042 RVA: 0x0005B032 File Offset: 0x00059232
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

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0005B043 File Offset: 0x00059243
	// (set) Token: 0x06000FCC RID: 4044 RVA: 0x0005B053 File Offset: 0x00059253
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

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0005B064 File Offset: 0x00059264
	// (set) Token: 0x06000FCE RID: 4046 RVA: 0x0005B074 File Offset: 0x00059274
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

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0005B085 File Offset: 0x00059285
	// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x0005B095 File Offset: 0x00059295
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

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0005B0A6 File Offset: 0x000592A6
	// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x0005B0B6 File Offset: 0x000592B6
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

	// Token: 0x06000FD3 RID: 4051 RVA: 0x0005B0C8 File Offset: 0x000592C8
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

	// Token: 0x06000FD4 RID: 4052 RVA: 0x0005B170 File Offset: 0x00059370
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

	// Token: 0x06000FD5 RID: 4053 RVA: 0x0005B1CC File Offset: 0x000593CC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animSequence != null) ? animSequence.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x0005B26C File Offset: 0x0005946C
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

	// Token: 0x06000FD7 RID: 4055 RVA: 0x0005B2BC File Offset: 0x000594BC
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

	// Token: 0x06000FD8 RID: 4056 RVA: 0x0005B337 File Offset: 0x00059537
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "附加Actor到Socket";
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x0005B33E File Offset: 0x0005953E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAttachActorToSocket._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttachActorToSocket.TsAnimNotifyStateAttachActorToSocket_C");
		}
		return TsAnimNotifyStateAttachActorToSocket._ClassPtr;
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x0005B364 File Offset: 0x00059564
	public TsAnimNotifyStateAttachActorToSocket() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttachActorToSocket.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x0005B38C File Offset: 0x0005958C
	[NullableContext(1)]
	public TsAnimNotifyStateAttachActorToSocket(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttachActorToSocket.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x0005B3BF File Offset: 0x000595BF
	protected TsAnimNotifyStateAttachActorToSocket(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x0005B3C8 File Offset: 0x000595C8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x0005B404 File Offset: 0x00059604
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x0005B437 File Offset: 0x00059637
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C4B RID: 3147
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttachActorToSocket.TsAnimNotifyStateAttachActorToSocket_C";

	// Token: 0x04000C4C RID: 3148
	private static IntPtr _ClassPtr;

	// Token: 0x04000C4D RID: 3149
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C4E RID: 3150
	private static int __PropertyOffset_SocketName;

	// Token: 0x04000C4F RID: 3151
	private static int __PropertyOffset_ActorTag;

	// Token: 0x04000C50 RID: 3152
	private static int __PropertyOffset_LocationAttachRule;

	// Token: 0x04000C51 RID: 3153
	private static int __PropertyOffset_RotationAttachRule;

	// Token: 0x04000C52 RID: 3154
	private static int __PropertyOffset_ScaleAttachRule;

	// Token: 0x04000C53 RID: 3155
	private static int __PropertyOffset_LocationDetachRule;

	// Token: 0x04000C54 RID: 3156
	private static int __PropertyOffset_RotationDetachRule;

	// Token: 0x04000C55 RID: 3157
	private static int __PropertyOffset_ScaleDetachRule;
}

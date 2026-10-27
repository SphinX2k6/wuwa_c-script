using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000169 RID: 361
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetNearClip.TsAnimNotifyStateSetNearClip_C")]
public class TsAnimNotifyStateSetNearClip : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003BB RID: 955
	// (get) Token: 0x060016C4 RID: 5828 RVA: 0x0007B927 File Offset: 0x00079B27
	// (set) Token: 0x060016C5 RID: 5829 RVA: 0x0007B937 File Offset: 0x00079B37
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float NearClip
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetNearClip.__PropertyOffset_NearClip);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetNearClip.__PropertyOffset_NearClip) = value;
		}
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x0007B948 File Offset: 0x00079B48
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

	// Token: 0x060016C7 RID: 5831 RVA: 0x0007B9EE File Offset: 0x00079BEE
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (!(meshComp.GetOwner() is TsBaseCharacter))
		{
			return false;
		}
		if (this.NearClip < 1f)
		{
			return false;
		}
		this.CameraNearClipId = CameraNearClipController.Instance.EnableAbsoluteNearClip(500, this.NearClip);
		return true;
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x0007BA2C File Offset: 0x00079C2C
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

	// Token: 0x060016C9 RID: 5833 RVA: 0x0007BACB File Offset: 0x00079CCB
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!(meshComp.GetOwner() is TsBaseCharacter))
		{
			return false;
		}
		if (this.CameraNearClipId > 0)
		{
			CameraNearClipController.Instance.DisableCameraNearClip(this.CameraNearClipId);
			this.CameraNearClipId = 0;
		}
		return true;
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x0007BB00 File Offset: 0x00079D00
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

	// Token: 0x060016CB RID: 5835 RVA: 0x0007BB7B File Offset: 0x00079D7B
	protected override string GetNotifyName_Implementation()
	{
		return "设置相机近裁剪面";
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x0007BB82 File Offset: 0x00079D82
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetNearClip._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetNearClip.TsAnimNotifyStateSetNearClip_C");
		}
		return TsAnimNotifyStateSetNearClip._ClassPtr;
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x0007BBA8 File Offset: 0x00079DA8
	public TsAnimNotifyStateSetNearClip() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetNearClip.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x0007BBD0 File Offset: 0x00079DD0
	public TsAnimNotifyStateSetNearClip(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetNearClip.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x0007BC03 File Offset: 0x00079E03
	protected TsAnimNotifyStateSetNearClip(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x0007BC0C File Offset: 0x00079E0C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x0007BC48 File Offset: 0x00079E48
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x0007BC7B File Offset: 0x00079E7B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FAF RID: 4015
	private int CameraNearClipId;

	// Token: 0x04000FB0 RID: 4016
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetNearClip.TsAnimNotifyStateSetNearClip_C";

	// Token: 0x04000FB1 RID: 4017
	private static IntPtr _ClassPtr;

	// Token: 0x04000FB2 RID: 4018
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FB3 RID: 4019
	private static int __PropertyOffset_NearClip;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016D RID: 365
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetNearClip.TsAnimNotifyStateSetNearClip_C")]
public class TsAnimNotifyStateSetNearClip : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003DD RID: 989
	// (get) Token: 0x06001761 RID: 5985 RVA: 0x000813CB File Offset: 0x0007F5CB
	// (set) Token: 0x06001762 RID: 5986 RVA: 0x000813DB File Offset: 0x0007F5DB
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

	// Token: 0x06001763 RID: 5987 RVA: 0x000813EC File Offset: 0x0007F5EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetNearClip) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSetNearClip.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001764 RID: 5988 RVA: 0x000814AA File Offset: 0x0007F6AA
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

	// Token: 0x06001765 RID: 5989 RVA: 0x000814E8 File Offset: 0x0007F6E8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetNearClip) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSetNearClip.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x0008159E File Offset: 0x0007F79E
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

	// Token: 0x06001767 RID: 5991 RVA: 0x000815D0 File Offset: 0x0007F7D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetNearClip) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSetNearClip.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001768 RID: 5992 RVA: 0x00081660 File Offset: 0x0007F860
	protected override string GetNotifyName_Implementation()
	{
		return "设置相机近裁剪面";
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x00081667 File Offset: 0x0007F867
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetNearClip._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetNearClip.TsAnimNotifyStateSetNearClip_C");
		}
		return TsAnimNotifyStateSetNearClip._ClassPtr;
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x0008168C File Offset: 0x0007F88C
	public TsAnimNotifyStateSetNearClip() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetNearClip.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x000816B4 File Offset: 0x0007F8B4
	public TsAnimNotifyStateSetNearClip(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetNearClip.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x000816E7 File Offset: 0x0007F8E7
	protected TsAnimNotifyStateSetNearClip(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x000816F0 File Offset: 0x0007F8F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x0008172C File Offset: 0x0007F92C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x0008175F File Offset: 0x0007F95F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FF2 RID: 4082
	private int CameraNearClipId;

	// Token: 0x04000FF3 RID: 4083
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetNearClip.TsAnimNotifyStateSetNearClip_C";

	// Token: 0x04000FF4 RID: 4084
	private static IntPtr _ClassPtr;

	// Token: 0x04000FF5 RID: 4085
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FF6 RID: 4086
	private static int __PropertyOffset_NearClip;
}

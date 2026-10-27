using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200019F RID: 415
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraStateChange.TsAnimNotifyCameraStateChange_C")]
public class TsAnimNotifyCameraStateChange : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00089FE7 File Offset: 0x000881E7
	// (set) Token: 0x06001A67 RID: 6759 RVA: 0x00089FF7 File Offset: 0x000881F7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否为单客户端
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraStateChange.__PropertyOffset_是否为单客户端) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraStateChange.__PropertyOffset_是否为单客户端) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0008A008 File Offset: 0x00088208
	// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0008A018 File Offset: 0x00088218
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否跟随
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraStateChange.__PropertyOffset_是否跟随) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraStateChange.__PropertyOffset_是否跟随) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x0008A02C File Offset: 0x0008822C
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

	// Token: 0x06001A6B RID: 6763 RVA: 0x0008A0CC File Offset: 0x000882CC
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (this.是否为单客户端)
		{
			TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
			if (tsBaseCharacter == null || tsBaseCharacter != Global.BaseCharacter)
			{
				return true;
			}
		}
		CameraController.Instance.MainModel.FightCamera.LogicComponent.IsFollowing = this.是否跟随;
		return true;
	}

	// Token: 0x06001A6C RID: 6764 RVA: 0x0008A11C File Offset: 0x0008831C
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

	// Token: 0x06001A6D RID: 6765 RVA: 0x0008A197 File Offset: 0x00088397
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "摄像机状态改变";
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x0008A19E File Offset: 0x0008839E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCameraStateChange._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraStateChange.TsAnimNotifyCameraStateChange_C");
		}
		return TsAnimNotifyCameraStateChange._ClassPtr;
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x0008A1C4 File Offset: 0x000883C4
	public TsAnimNotifyCameraStateChange() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraStateChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x0008A1EC File Offset: 0x000883EC
	[NullableContext(1)]
	public TsAnimNotifyCameraStateChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraStateChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A71 RID: 6769 RVA: 0x0008A21F File Offset: 0x0008841F
	protected TsAnimNotifyCameraStateChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A72 RID: 6770 RVA: 0x0008A228 File Offset: 0x00088428
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x0008A25B File Offset: 0x0008845B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001126 RID: 4390
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraStateChange.TsAnimNotifyCameraStateChange_C";

	// Token: 0x04001127 RID: 4391
	private static IntPtr _ClassPtr;

	// Token: 0x04001128 RID: 4392
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001129 RID: 4393
	private static int __PropertyOffset_是否为单客户端;

	// Token: 0x0400112A RID: 4394
	private static int __PropertyOffset_是否跟随;
}

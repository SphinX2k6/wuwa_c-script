using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A3 RID: 419
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraStateChange.TsAnimNotifyCameraStateChange_C")]
public class TsAnimNotifyCameraStateChange : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700046E RID: 1134
	// (get) Token: 0x06001B03 RID: 6915 RVA: 0x00090603 File Offset: 0x0008E803
	// (set) Token: 0x06001B04 RID: 6916 RVA: 0x00090613 File Offset: 0x0008E813
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

	// Token: 0x1700046F RID: 1135
	// (get) Token: 0x06001B05 RID: 6917 RVA: 0x00090624 File Offset: 0x0008E824
	// (set) Token: 0x06001B06 RID: 6918 RVA: 0x00090634 File Offset: 0x0008E834
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

	// Token: 0x06001B07 RID: 6919 RVA: 0x00090648 File Offset: 0x0008E848
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyCameraStateChange) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyCameraStateChange.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B08 RID: 6920 RVA: 0x00090700 File Offset: 0x0008E900
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

	// Token: 0x06001B09 RID: 6921 RVA: 0x00090750 File Offset: 0x0008E950
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyCameraStateChange) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyCameraStateChange.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B0A RID: 6922 RVA: 0x000907E0 File Offset: 0x0008E9E0
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "摄像机状态改变";
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x000907E7 File Offset: 0x0008E9E7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCameraStateChange._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraStateChange.TsAnimNotifyCameraStateChange_C");
		}
		return TsAnimNotifyCameraStateChange._ClassPtr;
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x0009080C File Offset: 0x0008EA0C
	public TsAnimNotifyCameraStateChange() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraStateChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x00090834 File Offset: 0x0008EA34
	[NullableContext(1)]
	public TsAnimNotifyCameraStateChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraStateChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x00090867 File Offset: 0x0008EA67
	protected TsAnimNotifyCameraStateChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x00090870 File Offset: 0x0008EA70
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x000908A3 File Offset: 0x0008EAA3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001169 RID: 4457
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraStateChange.TsAnimNotifyCameraStateChange_C";

	// Token: 0x0400116A RID: 4458
	private static IntPtr _ClassPtr;

	// Token: 0x0400116B RID: 4459
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400116C RID: 4460
	private static int __PropertyOffset_是否为单客户端;

	// Token: 0x0400116D RID: 4461
	private static int __PropertyOffset_是否跟随;
}

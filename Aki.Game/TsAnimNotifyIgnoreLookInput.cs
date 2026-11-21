using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C3 RID: 451
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyIgnoreLookInput.TsAnimNotifyIgnoreLookInput_C")]
public class TsAnimNotifyIgnoreLookInput : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004A1 RID: 1185
	// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x000961BB File Offset: 0x000943BB
	// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x000961CB File Offset: 0x000943CB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bIgnoreLookInput
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyIgnoreLookInput.__PropertyOffset_bIgnoreLookInput) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyIgnoreLookInput.__PropertyOffset_bIgnoreLookInput) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001CA8 RID: 7336 RVA: 0x000961DC File Offset: 0x000943DC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyIgnoreLookInput) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyIgnoreLookInput.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001CA9 RID: 7337 RVA: 0x00096294 File Offset: 0x00094494
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsCharacterController characterController = Global.CharacterController;
		if (characterController != null && characterController.IsValid() && characterController.IsLookInputIgnored() != this.bIgnoreLookInput)
		{
			characterController.SetIgnoreLookInput(this.bIgnoreLookInput);
		}
		return true;
	}

	// Token: 0x06001CAA RID: 7338 RVA: 0x000962D0 File Offset: 0x000944D0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyIgnoreLookInput) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyIgnoreLookInput.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001CAB RID: 7339 RVA: 0x00096360 File Offset: 0x00094560
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置禁用镜头输入";
	}

	// Token: 0x06001CAC RID: 7340 RVA: 0x00096367 File Offset: 0x00094567
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyIgnoreLookInput._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyIgnoreLookInput.TsAnimNotifyIgnoreLookInput_C");
		}
		return TsAnimNotifyIgnoreLookInput._ClassPtr;
	}

	// Token: 0x06001CAD RID: 7341 RVA: 0x0009638C File Offset: 0x0009458C
	public TsAnimNotifyIgnoreLookInput() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyIgnoreLookInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CAE RID: 7342 RVA: 0x000963B4 File Offset: 0x000945B4
	[NullableContext(1)]
	public TsAnimNotifyIgnoreLookInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyIgnoreLookInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CAF RID: 7343 RVA: 0x000963E7 File Offset: 0x000945E7
	protected TsAnimNotifyIgnoreLookInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CB0 RID: 7344 RVA: 0x000963F0 File Offset: 0x000945F0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CB1 RID: 7345 RVA: 0x00096423 File Offset: 0x00094623
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001205 RID: 4613
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyIgnoreLookInput.TsAnimNotifyIgnoreLookInput_C";

	// Token: 0x04001206 RID: 4614
	private static IntPtr _ClassPtr;

	// Token: 0x04001207 RID: 4615
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001208 RID: 4616
	private static int __PropertyOffset_bIgnoreLookInput;
}

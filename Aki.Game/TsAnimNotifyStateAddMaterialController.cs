using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002896 RID: 10390
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyStateAddMaterialController.TsAnimNotifyStateAddMaterialController_C")]
public class TsAnimNotifyStateAddMaterialController : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B2A RID: 11050
	// (get) Token: 0x0601A53E RID: 107838 RVA: 0x00826045 File Offset: 0x00824245
	// (set) Token: 0x0601A53F RID: 107839 RVA: 0x00826059 File Offset: 0x00824259
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C ControllerData
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddMaterialController.__PropertyOffset_ControllerData);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddMaterialController.__PropertyOffset_ControllerData, value);
		}
	}

	// Token: 0x17002B2B RID: 11051
	// (get) Token: 0x0601A540 RID: 107840 RVA: 0x0082606E File Offset: 0x0082426E
	// (set) Token: 0x0601A541 RID: 107841 RVA: 0x00826082 File Offset: 0x00824282
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UObject UserData
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddMaterialController.__PropertyOffset_UserData);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddMaterialController.__PropertyOffset_UserData, value);
		}
	}

	// Token: 0x17002B2C RID: 11052
	// (get) Token: 0x0601A542 RID: 107842 RVA: 0x00826097 File Offset: 0x00824297
	// (set) Token: 0x0601A543 RID: 107843 RVA: 0x0082609F File Offset: 0x0082429F
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<USkeletalMeshComponent, int> Handles { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x0601A544 RID: 107844 RVA: 0x008260A8 File Offset: 0x008242A8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddMaterialController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAddMaterialController.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601A545 RID: 107845 RVA: 0x00826168 File Offset: 0x00824368
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		CharRenderingComponent charRenderingComponent = owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return false;
		}
		if (this.Handles == null)
		{
			this.Handles = new Dictionary<USkeletalMeshComponent, int>();
		}
		int value = charRenderingComponent.AddMaterialControllerDataWithUserData(this.ControllerData, this.UserData);
		this.Handles[meshComp] = value;
		return true;
	}

	// Token: 0x0601A546 RID: 107846 RVA: 0x008261D4 File Offset: 0x008243D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddMaterialController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAddMaterialController.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601A547 RID: 107847 RVA: 0x0082628C File Offset: 0x0082448C
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		CharRenderingComponent charRenderingComponent = owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return false;
		}
		if (this.Handles == null)
		{
			return false;
		}
		int handle;
		if (!this.Handles.TryGetValue(meshComp, out handle))
		{
			return false;
		}
		this.Handles.Remove(meshComp);
		charRenderingComponent.RemoveMaterialControllerData(handle);
		return true;
	}

	// Token: 0x0601A548 RID: 107848 RVA: 0x008262F1 File Offset: 0x008244F1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddMaterialController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyStateAddMaterialController.TsAnimNotifyStateAddMaterialController_C");
		}
		return TsAnimNotifyStateAddMaterialController._ClassPtr;
	}

	// Token: 0x0601A549 RID: 107849 RVA: 0x00826318 File Offset: 0x00824518
	public TsAnimNotifyStateAddMaterialController() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddMaterialController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601A54A RID: 107850 RVA: 0x00826340 File Offset: 0x00824540
	public TsAnimNotifyStateAddMaterialController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601A54B RID: 107851 RVA: 0x00826373 File Offset: 0x00824573
	protected TsAnimNotifyStateAddMaterialController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601A54C RID: 107852 RVA: 0x0082637C File Offset: 0x0082457C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601A54D RID: 107853 RVA: 0x008263B8 File Offset: 0x008245B8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E744 RID: 59204
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyStateAddMaterialController.TsAnimNotifyStateAddMaterialController_C";

	// Token: 0x0400E745 RID: 59205
	private static IntPtr _ClassPtr;

	// Token: 0x0400E746 RID: 59206
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E747 RID: 59207
	private static int __PropertyOffset_ControllerData;

	// Token: 0x0400E748 RID: 59208
	private static int __PropertyOffset_UserData;
}

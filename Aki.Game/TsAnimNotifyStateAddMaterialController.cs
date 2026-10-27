using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003324 RID: 13092
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyStateAddMaterialController.TsAnimNotifyStateAddMaterialController_C")]
public class TsAnimNotifyStateAddMaterialController : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700278D RID: 10125
	// (get) Token: 0x0601C845 RID: 116805 RVA: 0x007FFAA9 File Offset: 0x007FDCA9
	// (set) Token: 0x0601C846 RID: 116806 RVA: 0x007FFABD File Offset: 0x007FDCBD
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

	// Token: 0x1700278E RID: 10126
	// (get) Token: 0x0601C847 RID: 116807 RVA: 0x007FFAD2 File Offset: 0x007FDCD2
	// (set) Token: 0x0601C848 RID: 116808 RVA: 0x007FFAE6 File Offset: 0x007FDCE6
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

	// Token: 0x1700278F RID: 10127
	// (get) Token: 0x0601C849 RID: 116809 RVA: 0x007FFAFB File Offset: 0x007FDCFB
	// (set) Token: 0x0601C84A RID: 116810 RVA: 0x007FFB03 File Offset: 0x007FDD03
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

	// Token: 0x0601C84B RID: 116811 RVA: 0x007FFB0C File Offset: 0x007FDD0C
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

	// Token: 0x0601C84C RID: 116812 RVA: 0x007FFBB4 File Offset: 0x007FDDB4
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

	// Token: 0x0601C84D RID: 116813 RVA: 0x007FFC20 File Offset: 0x007FDE20
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

	// Token: 0x0601C84E RID: 116814 RVA: 0x007FFCC0 File Offset: 0x007FDEC0
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

	// Token: 0x0601C84F RID: 116815 RVA: 0x007FFD25 File Offset: 0x007FDF25
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddMaterialController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyStateAddMaterialController.TsAnimNotifyStateAddMaterialController_C");
		}
		return TsAnimNotifyStateAddMaterialController._ClassPtr;
	}

	// Token: 0x0601C850 RID: 116816 RVA: 0x007FFD4C File Offset: 0x007FDF4C
	public TsAnimNotifyStateAddMaterialController() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddMaterialController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C851 RID: 116817 RVA: 0x007FFD74 File Offset: 0x007FDF74
	public TsAnimNotifyStateAddMaterialController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C852 RID: 116818 RVA: 0x007FFDA7 File Offset: 0x007FDFA7
	protected TsAnimNotifyStateAddMaterialController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C853 RID: 116819 RVA: 0x007FFDB0 File Offset: 0x007FDFB0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601C854 RID: 116820 RVA: 0x007FFDEC File Offset: 0x007FDFEC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E293 RID: 58003
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyStateAddMaterialController.TsAnimNotifyStateAddMaterialController_C";

	// Token: 0x0400E294 RID: 58004
	private static IntPtr _ClassPtr;

	// Token: 0x0400E295 RID: 58005
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E296 RID: 58006
	private static int __PropertyOffset_ControllerData;

	// Token: 0x0400E297 RID: 58007
	private static int __PropertyOffset_UserData;
}

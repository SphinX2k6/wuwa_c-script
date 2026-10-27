using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200017B RID: 379
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshControl.TsAnimNotifyStateSubMeshControl_C")]
public class TsAnimNotifyStateSubMeshControl : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003DC RID: 988
	// (get) Token: 0x060017ED RID: 6125 RVA: 0x00080283 File Offset: 0x0007E483
	// (set) Token: 0x060017EE RID: 6126 RVA: 0x00080297 File Offset: 0x0007E497
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string MeshName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_MeshName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_MeshName)), value);
		}
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x060017EF RID: 6127 RVA: 0x000802AC File Offset: 0x0007E4AC
	// (set) Token: 0x060017F0 RID: 6128 RVA: 0x000802BC File Offset: 0x0007E4BC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 开始是否可见
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_开始是否可见) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_开始是否可见) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x060017F1 RID: 6129 RVA: 0x000802CD File Offset: 0x0007E4CD
	// (set) Token: 0x060017F2 RID: 6130 RVA: 0x000802E1 File Offset: 0x0007E4E1
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C 开始材质
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSubMeshControl.__PropertyOffset_开始材质);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSubMeshControl.__PropertyOffset_开始材质, value);
		}
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x060017F3 RID: 6131 RVA: 0x000802F8 File Offset: 0x0007E4F8
	// (set) Token: 0x060017F4 RID: 6132 RVA: 0x00080331 File Offset: 0x0007E531
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> 开始特效
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._开始特效) == null)
			{
				result = (this._开始特效 = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_开始特效, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_开始特效, 1);
		}
	}

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x060017F5 RID: 6133 RVA: 0x00080356 File Offset: 0x0007E556
	// (set) Token: 0x060017F6 RID: 6134 RVA: 0x00080366 File Offset: 0x0007E566
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 开始延迟时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_开始延迟时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_开始延迟时间) = value;
		}
	}

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x060017F7 RID: 6135 RVA: 0x00080377 File Offset: 0x0007E577
	// (set) Token: 0x060017F8 RID: 6136 RVA: 0x00080387 File Offset: 0x0007E587
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 结束是否可见
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_结束是否可见) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_结束是否可见) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00080398 File Offset: 0x0007E598
	// (set) Token: 0x060017FA RID: 6138 RVA: 0x000803AC File Offset: 0x0007E5AC
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C 结束材质
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSubMeshControl.__PropertyOffset_结束材质);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSubMeshControl.__PropertyOffset_结束材质, value);
		}
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x060017FB RID: 6139 RVA: 0x000803C4 File Offset: 0x0007E5C4
	// (set) Token: 0x060017FC RID: 6140 RVA: 0x000803FD File Offset: 0x0007E5FD
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> 结束特效
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._结束特效) == null)
			{
				result = (this._结束特效 = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_结束特效, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_结束特效, 1);
		}
	}

	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x060017FD RID: 6141 RVA: 0x00080422 File Offset: 0x0007E622
	// (set) Token: 0x060017FE RID: 6142 RVA: 0x00080432 File Offset: 0x0007E632
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 结束延迟时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_结束延迟时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_结束延迟时间) = value;
		}
	}

	// Token: 0x170003E5 RID: 997
	// (get) Token: 0x060017FF RID: 6143 RVA: 0x00080443 File Offset: 0x0007E643
	// (set) Token: 0x06001800 RID: 6144 RVA: 0x00080457 File Offset: 0x0007E657
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag EnableTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_EnableTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshControl.__PropertyOffset_EnableTag) = value;
		}
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x0008046C File Offset: 0x0007E66C
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

	// Token: 0x06001802 RID: 6146 RVA: 0x00080514 File Offset: 0x0007E714
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.ActivateSet == null)
		{
			this.ActivateSet = new HashSet<USkeletalMeshComponent>();
		}
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = (aactor as TsBaseCharacter).GetEntityNoBlueprint();
		SubMeshComponent subMeshComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<SubMeshComponent>() : null;
		if (subMeshComponent == null)
		{
			return false;
		}
		if (this.EnableTag.TagName != "None")
		{
			BaseTagComponent baseTagComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null && !baseTagComponent.HasTag(this.EnableTag.TagId()))
			{
				return false;
			}
		}
		this.ActivateSet.Add(meshComp);
		subMeshComponent.SetSubMeshOrder(this.MeshName, this.开始是否可见, this.开始材质, this.开始特效, this.开始延迟时间 * 1000f);
		return true;
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x000805E4 File Offset: 0x0007E7E4
	[NullableContext(2)]
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

	// Token: 0x06001804 RID: 6148 RVA: 0x00080684 File Offset: 0x0007E884
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		HashSet<USkeletalMeshComponent> activateSet = this.ActivateSet;
		if (activateSet == null || !activateSet.Contains(meshComp))
		{
			return false;
		}
		this.ActivateSet.Remove(meshComp);
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = (aactor as TsBaseCharacter).GetEntityNoBlueprint();
		SubMeshComponent subMeshComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<SubMeshComponent>() : null;
		if (subMeshComponent == null)
		{
			return false;
		}
		subMeshComponent.SetSubMeshOrder(this.MeshName, this.结束是否可见, this.结束材质, this.结束特效, this.结束延迟时间 * 1000f);
		return true;
	}

	// Token: 0x06001805 RID: 6149 RVA: 0x00080718 File Offset: 0x0007E918
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

	// Token: 0x06001806 RID: 6150 RVA: 0x00080793 File Offset: 0x0007E993
	protected override string GetNotifyName_Implementation()
	{
		return "子Mesh可见性控制";
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x0008079A File Offset: 0x0007E99A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSubMeshControl._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshControl.TsAnimNotifyStateSubMeshControl_C");
		}
		return TsAnimNotifyStateSubMeshControl._ClassPtr;
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x000807C0 File Offset: 0x0007E9C0
	public TsAnimNotifyStateSubMeshControl() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSubMeshControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x000807E8 File Offset: 0x0007E9E8
	public TsAnimNotifyStateSubMeshControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSubMeshControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x0008081B File Offset: 0x0007EA1B
	protected TsAnimNotifyStateSubMeshControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x00080830 File Offset: 0x0007EA30
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x0008086C File Offset: 0x0007EA6C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x0008089F File Offset: 0x0007EA9F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001010 RID: 4112
	private HashSet<USkeletalMeshComponent> ActivateSet = new HashSet<USkeletalMeshComponent>();

	// Token: 0x04001011 RID: 4113
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshControl.TsAnimNotifyStateSubMeshControl_C";

	// Token: 0x04001012 RID: 4114
	private static IntPtr _ClassPtr;

	// Token: 0x04001013 RID: 4115
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001014 RID: 4116
	private static int __PropertyOffset_MeshName;

	// Token: 0x04001015 RID: 4117
	private static int __PropertyOffset_开始是否可见;

	// Token: 0x04001016 RID: 4118
	private static int __PropertyOffset_开始材质;

	// Token: 0x04001017 RID: 4119
	private static int __PropertyOffset_开始特效;

	// Token: 0x04001018 RID: 4120
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _开始特效;

	// Token: 0x04001019 RID: 4121
	private static int __PropertyOffset_开始延迟时间;

	// Token: 0x0400101A RID: 4122
	private static int __PropertyOffset_结束是否可见;

	// Token: 0x0400101B RID: 4123
	private static int __PropertyOffset_结束材质;

	// Token: 0x0400101C RID: 4124
	private static int __PropertyOffset_结束特效;

	// Token: 0x0400101D RID: 4125
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _结束特效;

	// Token: 0x0400101E RID: 4126
	private static int __PropertyOffset_结束延迟时间;

	// Token: 0x0400101F RID: 4127
	private static int __PropertyOffset_EnableTag;
}

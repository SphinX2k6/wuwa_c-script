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

// Token: 0x0200017F RID: 383
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshControl.TsAnimNotifyStateSubMeshControl_C")]
public class TsAnimNotifyStateSubMeshControl : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x0600188A RID: 6282 RVA: 0x00086167 File Offset: 0x00084367
	// (set) Token: 0x0600188B RID: 6283 RVA: 0x0008617B File Offset: 0x0008437B
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

	// Token: 0x170003FF RID: 1023
	// (get) Token: 0x0600188C RID: 6284 RVA: 0x00086190 File Offset: 0x00084390
	// (set) Token: 0x0600188D RID: 6285 RVA: 0x000861A0 File Offset: 0x000843A0
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

	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x0600188E RID: 6286 RVA: 0x000861B1 File Offset: 0x000843B1
	// (set) Token: 0x0600188F RID: 6287 RVA: 0x000861C5 File Offset: 0x000843C5
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

	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x06001890 RID: 6288 RVA: 0x000861DC File Offset: 0x000843DC
	// (set) Token: 0x06001891 RID: 6289 RVA: 0x00086215 File Offset: 0x00084415
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

	// Token: 0x17000402 RID: 1026
	// (get) Token: 0x06001892 RID: 6290 RVA: 0x0008623A File Offset: 0x0008443A
	// (set) Token: 0x06001893 RID: 6291 RVA: 0x0008624A File Offset: 0x0008444A
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

	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x06001894 RID: 6292 RVA: 0x0008625B File Offset: 0x0008445B
	// (set) Token: 0x06001895 RID: 6293 RVA: 0x0008626B File Offset: 0x0008446B
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

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x06001896 RID: 6294 RVA: 0x0008627C File Offset: 0x0008447C
	// (set) Token: 0x06001897 RID: 6295 RVA: 0x00086290 File Offset: 0x00084490
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

	// Token: 0x17000405 RID: 1029
	// (get) Token: 0x06001898 RID: 6296 RVA: 0x000862A8 File Offset: 0x000844A8
	// (set) Token: 0x06001899 RID: 6297 RVA: 0x000862E1 File Offset: 0x000844E1
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

	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x0600189A RID: 6298 RVA: 0x00086306 File Offset: 0x00084506
	// (set) Token: 0x0600189B RID: 6299 RVA: 0x00086316 File Offset: 0x00084516
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

	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x0600189C RID: 6300 RVA: 0x00086327 File Offset: 0x00084527
	// (set) Token: 0x0600189D RID: 6301 RVA: 0x0008633B File Offset: 0x0008453B
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

	// Token: 0x0600189E RID: 6302 RVA: 0x00086350 File Offset: 0x00084550
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSubMeshControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSubMeshControl.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600189F RID: 6303 RVA: 0x00086410 File Offset: 0x00084610
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

	// Token: 0x060018A0 RID: 6304 RVA: 0x000864E0 File Offset: 0x000846E0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSubMeshControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSubMeshControl.StaticClass(), out intPtr, out num))
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

	// Token: 0x060018A1 RID: 6305 RVA: 0x00086598 File Offset: 0x00084798
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

	// Token: 0x060018A2 RID: 6306 RVA: 0x0008662C File Offset: 0x0008482C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSubMeshControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSubMeshControl.StaticClass(), out intPtr, out num))
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

	// Token: 0x060018A3 RID: 6307 RVA: 0x000866BC File Offset: 0x000848BC
	protected override string GetNotifyName_Implementation()
	{
		return "子Mesh可见性控制";
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x000866C3 File Offset: 0x000848C3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSubMeshControl._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshControl.TsAnimNotifyStateSubMeshControl_C");
		}
		return TsAnimNotifyStateSubMeshControl._ClassPtr;
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x000866E8 File Offset: 0x000848E8
	public TsAnimNotifyStateSubMeshControl() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSubMeshControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x00086710 File Offset: 0x00084910
	public TsAnimNotifyStateSubMeshControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSubMeshControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x00086743 File Offset: 0x00084943
	protected TsAnimNotifyStateSubMeshControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x00086758 File Offset: 0x00084958
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x00086794 File Offset: 0x00084994
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x000867C7 File Offset: 0x000849C7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001053 RID: 4179
	private HashSet<USkeletalMeshComponent> ActivateSet = new HashSet<USkeletalMeshComponent>();

	// Token: 0x04001054 RID: 4180
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshControl.TsAnimNotifyStateSubMeshControl_C";

	// Token: 0x04001055 RID: 4181
	private static IntPtr _ClassPtr;

	// Token: 0x04001056 RID: 4182
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001057 RID: 4183
	private static int __PropertyOffset_MeshName;

	// Token: 0x04001058 RID: 4184
	private static int __PropertyOffset_开始是否可见;

	// Token: 0x04001059 RID: 4185
	private static int __PropertyOffset_开始材质;

	// Token: 0x0400105A RID: 4186
	private static int __PropertyOffset_开始特效;

	// Token: 0x0400105B RID: 4187
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _开始特效;

	// Token: 0x0400105C RID: 4188
	private static int __PropertyOffset_开始延迟时间;

	// Token: 0x0400105D RID: 4189
	private static int __PropertyOffset_结束是否可见;

	// Token: 0x0400105E RID: 4190
	private static int __PropertyOffset_结束材质;

	// Token: 0x0400105F RID: 4191
	private static int __PropertyOffset_结束特效;

	// Token: 0x04001060 RID: 4192
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _结束特效;

	// Token: 0x04001061 RID: 4193
	private static int __PropertyOffset_结束延迟时间;

	// Token: 0x04001062 RID: 4194
	private static int __PropertyOffset_EnableTag;
}

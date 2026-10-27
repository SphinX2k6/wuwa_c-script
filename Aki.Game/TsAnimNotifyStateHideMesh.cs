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

// Token: 0x0200013C RID: 316
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideMesh.TsAnimNotifyStateHideMesh_C")]
public class TsAnimNotifyStateHideMesh : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001352 RID: 4946 RVA: 0x0006C89D File Offset: 0x0006AA9D
	static TsAnimNotifyStateHideMesh()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateHideMesh.CreateStaticDefaultValue), new Action(TsAnimNotifyStateHideMesh.ResetStaticDefaultValue));
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x0006C8BC File Offset: 0x0006AABC
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateHideMesh._actorAnsMap = new Dictionary<AActor, Dictionary<TsAnimNotifyStateHideMesh, HideMeshParams>>();
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x0006C8C8 File Offset: 0x0006AAC8
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateHideMesh._actorAnsMap = null;
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x06001355 RID: 4949 RVA: 0x0006C8D0 File Offset: 0x0006AAD0
	// (set) Token: 0x06001356 RID: 4950 RVA: 0x0006C8E4 File Offset: 0x0006AAE4
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ChildMeshName
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateHideMesh.__PropertyOffset_ChildMeshName)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateHideMesh.__PropertyOffset_ChildMeshName)), value);
		}
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x06001357 RID: 4951 RVA: 0x0006C8F9 File Offset: 0x0006AAF9
	// (set) Token: 0x06001358 RID: 4952 RVA: 0x0006C909 File Offset: 0x0006AB09
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideChildren
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateHideMesh.__PropertyOffset_HideChildren) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateHideMesh.__PropertyOffset_HideChildren) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x06001359 RID: 4953 RVA: 0x0006C91A File Offset: 0x0006AB1A
	// (set) Token: 0x0600135A RID: 4954 RVA: 0x0006C92A File Offset: 0x0006AB2A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideChildrenActors
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateHideMesh.__PropertyOffset_HideChildrenActors) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateHideMesh.__PropertyOffset_HideChildrenActors) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x0600135B RID: 4955 RVA: 0x0006C93B File Offset: 0x0006AB3B
	// (set) Token: 0x0600135C RID: 4956 RVA: 0x0006C94F File Offset: 0x0006AB4F
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C EndEffect
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateHideMesh.__PropertyOffset_EndEffect);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateHideMesh.__PropertyOffset_EndEffect, value);
		}
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x0600135D RID: 4957 RVA: 0x0006C964 File Offset: 0x0006AB64
	// (set) Token: 0x0600135E RID: 4958 RVA: 0x0006C974 File Offset: 0x0006AB74
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Hide
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateHideMesh.__PropertyOffset_Hide) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateHideMesh.__PropertyOffset_Hide) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x0006C988 File Offset: 0x0006AB88
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

	// Token: 0x06001360 RID: 4960 RVA: 0x0006CA30 File Offset: 0x0006AC30
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		UMeshComponent umeshComponent = null;
		if (string.IsNullOrEmpty(this.ChildMeshName))
		{
			umeshComponent = meshComp;
		}
		else
		{
			TArray<UActorComponent> tarray = owner.K2_GetComponentsByClass(UMeshComponent.StaticClass());
			for (int i = tarray.Num() - 1; i >= 0; i--)
			{
				UMeshComponent umeshComponent2 = tarray.Get(i) as UMeshComponent;
				if (((umeshComponent2 != null) ? umeshComponent2.GetName() : null) == this.ChildMeshName)
				{
					umeshComponent = umeshComponent2;
					break;
				}
			}
		}
		if (umeshComponent == null)
		{
			return false;
		}
		if (TsAnimNotifyStateHideMesh._actorAnsMap == null)
		{
			return false;
		}
		Dictionary<TsAnimNotifyStateHideMesh, HideMeshParams> dictionary;
		if (!TsAnimNotifyStateHideMesh._actorAnsMap.TryGetValue(owner, out dictionary))
		{
			dictionary = new Dictionary<TsAnimNotifyStateHideMesh, HideMeshParams>();
			TsAnimNotifyStateHideMesh._actorAnsMap[owner] = dictionary;
		}
		HideMeshParams hideMeshParams;
		if (dictionary.TryGetValue(this, out hideMeshParams))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "TsAnimNotifyStateHideMesh Error.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Mesh", meshComp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Anim", animation);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		HideMeshParams hideMeshParams2 = new HideMeshParams(umeshComponent);
		dictionary[this] = hideMeshParams2;
		Entity entity = null;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			entity = tsBaseCharacter.GetEntityNoBlueprint();
		}
		else
		{
			TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
			if (tsBaseVehicle != null)
			{
				entity = tsBaseVehicle.GetEntityNoBlueprint();
			}
		}
		if (owner is TsBaseCharacter || owner is TsBaseVehicle)
		{
			BaseAnimationComponent baseAnimationComponent = (entity != null) ? entity.GetComponent<BaseAnimationComponent>() : null;
			if (baseAnimationComponent != null)
			{
				baseAnimationComponent.StartForceDisableAnimOptimization(EForceDisableAnimOptimization.HideMesh, false);
			}
			else
			{
				VehicleAnimationComponent vehicleAnimationComponent = (entity != null) ? entity.GetComponent<VehicleAnimationComponent>() : null;
				if (vehicleAnimationComponent != null)
				{
					vehicleAnimationComponent.StartForceDisableAnimOptimization(EForceDisableAnimOptimization.HideMesh, false);
				}
			}
			SubMeshComponent subMeshComponent = (entity != null) ? entity.GetComponent<SubMeshComponent>() : null;
			if (subMeshComponent != null)
			{
				hideMeshParams2.HideKey = subMeshComponent.SetHideMesh(hideMeshParams2.MeshComp, !this.Hide, this.HideChildren, this.HideChildrenActors, 0);
				return true;
			}
		}
		umeshComponent.SetVisibility(!this.Hide, this.HideChildren);
		if (this.HideChildrenActors)
		{
			if (string.IsNullOrEmpty(this.ChildMeshName))
			{
				TArray<AActor> tarray2 = new TArray<AActor>();
				owner.GetAllChildActors(ref tarray2, true);
				for (int j = tarray2.Num() - 1; j >= 0; j--)
				{
					AActor aactor = tarray2.Get(j);
					if (!aactor.bHidden)
					{
						hideMeshParams2.Children.Add(aactor);
					}
				}
			}
			else
			{
				TArray<USceneComponent> attachChildren = umeshComponent.AttachChildren;
				for (int k = attachChildren.Num() - 1; k >= 0; k--)
				{
					AActor owner2 = attachChildren.Get(k).GetOwner();
					if ((owner2 == null || !owner2.bHidden) && owner2 != null)
					{
						hideMeshParams2.Children.Add(owner2);
					}
				}
			}
			foreach (AActor aactor2 in hideMeshParams2.Children)
			{
				aactor2.SetActorHiddenInGame(this.Hide);
			}
		}
		return true;
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x0006CD20 File Offset: 0x0006AF20
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

	// Token: 0x06001362 RID: 4962 RVA: 0x0006CDC0 File Offset: 0x0006AFC0
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		Dictionary<TsAnimNotifyStateHideMesh, HideMeshParams> dictionary;
		if (TsAnimNotifyStateHideMesh._actorAnsMap == null || !TsAnimNotifyStateHideMesh._actorAnsMap.TryGetValue(owner, out dictionary))
		{
			return false;
		}
		HideMeshParams hideMeshParams;
		if (!dictionary.TryGetValue(this, out hideMeshParams))
		{
			return false;
		}
		dictionary.Remove(this);
		if (dictionary.Count == 0)
		{
			TsAnimNotifyStateHideMesh._actorAnsMap.Remove(owner);
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
		if (tsBaseCharacter != null || tsBaseVehicle != null)
		{
			Entity entity = ((tsBaseCharacter != null) ? tsBaseCharacter.GetEntityNoBlueprint() : null) ?? ((tsBaseVehicle != null) ? tsBaseVehicle.GetEntityNoBlueprint() : null);
			BaseAnimationComponent baseAnimationComponent = (entity != null) ? entity.GetComponent<BaseAnimationComponent>() : null;
			if (baseAnimationComponent != null)
			{
				baseAnimationComponent.CancelForceDisableAnimOptimization(EForceDisableAnimOptimization.HideMesh);
			}
			else
			{
				VehicleAnimationComponent vehicleAnimationComponent = (entity != null) ? entity.GetComponent<VehicleAnimationComponent>() : null;
				if (vehicleAnimationComponent != null)
				{
					vehicleAnimationComponent.CancelForceDisableAnimOptimization(EForceDisableAnimOptimization.HideMesh);
				}
			}
			if (hideMeshParams.HideKey != 0)
			{
				SubMeshComponent subMeshComponent = (entity != null) ? entity.GetComponent<SubMeshComponent>() : null;
				if (subMeshComponent != null)
				{
					subMeshComponent.SetHideMesh(hideMeshParams.MeshComp, this.Hide, this.HideChildren, this.HideChildrenActors, hideMeshParams.HideKey);
					return true;
				}
			}
		}
		hideMeshParams.MeshComp.SetVisibility(this.Hide, this.HideChildren);
		if (this.HideChildrenActors)
		{
			foreach (AActor aactor in hideMeshParams.Children)
			{
				aactor.SetActorHiddenInGame(!this.Hide);
			}
		}
		if (this.EndEffect != null)
		{
			CharRenderingComponent charRenderingComponent = owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				charRenderingComponent.AddMaterialControllerData(this.EndEffect);
			}
		}
		return true;
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x0006CF6C File Offset: 0x0006B16C
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

	// Token: 0x06001364 RID: 4964 RVA: 0x0006CFE7 File Offset: 0x0006B1E7
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏网格体";
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x0006CFEE File Offset: 0x0006B1EE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateHideMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideMesh.TsAnimNotifyStateHideMesh_C");
		}
		return TsAnimNotifyStateHideMesh._ClassPtr;
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x0006D014 File Offset: 0x0006B214
	public TsAnimNotifyStateHideMesh() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x0006D03C File Offset: 0x0006B23C
	[NullableContext(1)]
	public TsAnimNotifyStateHideMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x0006D06F File Offset: 0x0006B26F
	protected TsAnimNotifyStateHideMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x0006D078 File Offset: 0x0006B278
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x0006D0B4 File Offset: 0x0006B2B4
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x0006D0E7 File Offset: 0x0006B2E7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E24 RID: 3620
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})]
	private static Dictionary<AActor, Dictionary<TsAnimNotifyStateHideMesh, HideMeshParams>> _actorAnsMap;

	// Token: 0x04000E25 RID: 3621
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideMesh.TsAnimNotifyStateHideMesh_C";

	// Token: 0x04000E26 RID: 3622
	private static IntPtr _ClassPtr;

	// Token: 0x04000E27 RID: 3623
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E28 RID: 3624
	private static int __PropertyOffset_ChildMeshName;

	// Token: 0x04000E29 RID: 3625
	private static int __PropertyOffset_HideChildren;

	// Token: 0x04000E2A RID: 3626
	private static int __PropertyOffset_HideChildrenActors;

	// Token: 0x04000E2B RID: 3627
	private static int __PropertyOffset_EndEffect;

	// Token: 0x04000E2C RID: 3628
	private static int __PropertyOffset_Hide;
}

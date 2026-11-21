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

// Token: 0x0200013D RID: 317
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideMesh.TsAnimNotifyStateHideMesh_C")]
public class TsAnimNotifyStateHideMesh : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060013D0 RID: 5072 RVA: 0x00070E55 File Offset: 0x0006F055
	static TsAnimNotifyStateHideMesh()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateHideMesh.CreateStaticDefaultValue), new Action(TsAnimNotifyStateHideMesh.ResetStaticDefaultValue));
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00070E74 File Offset: 0x0006F074
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateHideMesh._actorAnsMap = new Dictionary<AActor, Dictionary<TsAnimNotifyStateHideMesh, HideMeshParams>>();
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x00070E80 File Offset: 0x0006F080
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateHideMesh._actorAnsMap = null;
	}

	// Token: 0x17000342 RID: 834
	// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00070E88 File Offset: 0x0006F088
	// (set) Token: 0x060013D4 RID: 5076 RVA: 0x00070E9C File Offset: 0x0006F09C
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

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00070EB1 File Offset: 0x0006F0B1
	// (set) Token: 0x060013D6 RID: 5078 RVA: 0x00070EC1 File Offset: 0x0006F0C1
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

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x060013D7 RID: 5079 RVA: 0x00070ED2 File Offset: 0x0006F0D2
	// (set) Token: 0x060013D8 RID: 5080 RVA: 0x00070EE2 File Offset: 0x0006F0E2
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

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00070EF3 File Offset: 0x0006F0F3
	// (set) Token: 0x060013DA RID: 5082 RVA: 0x00070F07 File Offset: 0x0006F107
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

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x060013DB RID: 5083 RVA: 0x00070F1C File Offset: 0x0006F11C
	// (set) Token: 0x060013DC RID: 5084 RVA: 0x00070F2C File Offset: 0x0006F12C
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

	// Token: 0x060013DD RID: 5085 RVA: 0x00070F40 File Offset: 0x0006F140
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateHideMesh) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateHideMesh.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013DE RID: 5086 RVA: 0x00071000 File Offset: 0x0006F200
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

	// Token: 0x060013DF RID: 5087 RVA: 0x000712F0 File Offset: 0x0006F4F0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateHideMesh) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateHideMesh.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013E0 RID: 5088 RVA: 0x000713A8 File Offset: 0x0006F5A8
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

	// Token: 0x060013E1 RID: 5089 RVA: 0x00071554 File Offset: 0x0006F754
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateHideMesh) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateHideMesh.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013E2 RID: 5090 RVA: 0x000715E4 File Offset: 0x0006F7E4
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏网格体";
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x000715EB File Offset: 0x0006F7EB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateHideMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideMesh.TsAnimNotifyStateHideMesh_C");
		}
		return TsAnimNotifyStateHideMesh._ClassPtr;
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x00071610 File Offset: 0x0006F810
	public TsAnimNotifyStateHideMesh() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00071638 File Offset: 0x0006F838
	[NullableContext(1)]
	public TsAnimNotifyStateHideMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x0007166B File Offset: 0x0006F86B
	protected TsAnimNotifyStateHideMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00071674 File Offset: 0x0006F874
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x000716B0 File Offset: 0x0006F8B0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x000716E3 File Offset: 0x0006F8E3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E56 RID: 3670
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})]
	private static Dictionary<AActor, Dictionary<TsAnimNotifyStateHideMesh, HideMeshParams>> _actorAnsMap;

	// Token: 0x04000E57 RID: 3671
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideMesh.TsAnimNotifyStateHideMesh_C";

	// Token: 0x04000E58 RID: 3672
	private static IntPtr _ClassPtr;

	// Token: 0x04000E59 RID: 3673
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E5A RID: 3674
	private static int __PropertyOffset_ChildMeshName;

	// Token: 0x04000E5B RID: 3675
	private static int __PropertyOffset_HideChildren;

	// Token: 0x04000E5C RID: 3676
	private static int __PropertyOffset_HideChildrenActors;

	// Token: 0x04000E5D RID: 3677
	private static int __PropertyOffset_EndEffect;

	// Token: 0x04000E5E RID: 3678
	private static int __PropertyOffset_Hide;
}

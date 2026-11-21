using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029CF RID: 10703
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerDataGroup.AnimNotifyAddMeshMaterialControllerDataGroup_C")]
public class AnimNotifyAddMeshMaterialControllerDataGroup : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B5D RID: 11101
	// (get) Token: 0x0601AC56 RID: 109654 RVA: 0x008387BB File Offset: 0x008369BB
	// (set) Token: 0x0601AC57 RID: 109655 RVA: 0x008387CF File Offset: 0x008369CF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerDataGroup_C MaterialAssetData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyAddMeshMaterialControllerDataGroup.__PropertyOffset_MaterialAssetData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyAddMeshMaterialControllerDataGroup.__PropertyOffset_MaterialAssetData, value);
		}
	}

	// Token: 0x17002B5E RID: 11102
	// (get) Token: 0x0601AC58 RID: 109656 RVA: 0x008387E4 File Offset: 0x008369E4
	// (set) Token: 0x0601AC59 RID: 109657 RVA: 0x008387F4 File Offset: 0x008369F4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideMeshAfterPlay
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyAddMeshMaterialControllerDataGroup.__PropertyOffset_HideMeshAfterPlay) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyAddMeshMaterialControllerDataGroup.__PropertyOffset_HideMeshAfterPlay) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601AC5A RID: 109658 RVA: 0x00838808 File Offset: 0x00836A08
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyAddMeshMaterialControllerDataGroup) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), AnimNotifyAddMeshMaterialControllerDataGroup.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AC5B RID: 109659 RVA: 0x008388C8 File Offset: 0x00836AC8
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (GlobalData.World == null)
		{
			return false;
		}
		if (meshComp == null || !meshComp.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.MY;
			string message = "错误：动画Mesh不合法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", (meshComp != null) ? meshComp.GetOwner() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("动画", animation);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		meshComp.SetHiddenInGame(false, false);
		if (!this.IsAllValid(meshComp, animation))
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderCharacter;
			ELogAuthor author2 = ELogAuthor.LSY;
			string message2 = "材质控制器不应该在角色蓝图上使用此动画通知，请检查动画";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", (meshComp != null) ? meshComp.GetOwner() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("动画", animation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("材质控制器组", this.MaterialAssetData);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData materialControllerData = new AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData();
		if (owner is AEffectSystemActor)
		{
			materialControllerData.CharRenderingComponent = (owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
			if (materialControllerData.CharRenderingComponent == null)
			{
				materialControllerData.CharRenderingComponent = (owner.AddComponentByClass(CharRenderingComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as CharRenderingComponent);
				CharRenderingComponent charRenderingComponent = materialControllerData.CharRenderingComponent;
				if (charRenderingComponent != null)
				{
					charRenderingComponent.Init(ECharacterRenderingType.Effect);
				}
			}
		}
		if (materialControllerData.CharRenderingComponent == null)
		{
			AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData materialControllerData2 = materialControllerData;
			TSubclassOf<AActor> actorClass = BP_MaterialControllerRenderActor_C.StaticClass();
			FTransformDouble ftransformDouble = owner.D_GetTransform();
			materialControllerData2.RenderActor = (UKuroRenderingRuntimeBPPluginBPLibrary.D_SpawnActorFromClass(meshComp, actorClass, ftransformDouble, ESpawnActorCollisionHandlingMethod.Undefined, null, null, true) as BP_MaterialControllerRenderActor_C);
			if (materialControllerData.RenderActor != null)
			{
				materialControllerData.RenderActor.RefActor = owner;
				materialControllerData.CharRenderingComponent = materialControllerData.RenderActor.CharRenderingComponent;
				materialControllerData.CharRenderingComponent.Init(ECharacterRenderingType.Default);
				materialControllerData.CharRenderingComponent.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, meshComp);
			}
		}
		if (materialControllerData.CharRenderingComponent == null)
		{
			return false;
		}
		materialControllerData.CharRenderingComponent.SetLogicOwner(owner);
		materialControllerData.HandleId = materialControllerData.CharRenderingComponent.AddMaterialControllerDataGroup(this.MaterialAssetData);
		Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData> dictionary;
		if (!AnimNotifyAddMeshMaterialControllerDataGroup.materialControllerStateHandleMap.TryGetValue(meshComp, out dictionary))
		{
			dictionary = new Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData>();
			AnimNotifyAddMeshMaterialControllerDataGroup.materialControllerStateHandleMap[meshComp] = dictionary;
		}
		dictionary[this] = materialControllerData;
		return true;
	}

	// Token: 0x0601AC5C RID: 109660 RVA: 0x00838B30 File Offset: 0x00836D30
	public unsafe bool IsAllValid(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		PD_CharacterControllerDataGroup_C materialAssetData = this.MaterialAssetData;
		if (materialAssetData == null || !materialAssetData.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.MY;
			string message = "错误：特效DA不合法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", (meshComp != null) ? meshComp.GetOwner() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("动画", animation);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (meshComp == null || !meshComp.IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderCharacter;
			ELogAuthor author2 = ELogAuthor.MY;
			string message2 = "错误：动画Mesh不合法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", (meshComp != null) ? meshComp.GetOwner() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("动画", animation);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}
		return true;
	}

	// Token: 0x0601AC5D RID: 109661 RVA: 0x00838C20 File Offset: 0x00836E20
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyAddMeshMaterialControllerDataGroup) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), AnimNotifyAddMeshMaterialControllerDataGroup.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AC5E RID: 109662 RVA: 0x00838CD8 File Offset: 0x00836ED8
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (GlobalData.World == null)
		{
			return false;
		}
		if (meshComp == null)
		{
			return true;
		}
		Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData> dictionary;
		if (!AnimNotifyAddMeshMaterialControllerDataGroup.materialControllerStateHandleMap.TryGetValue(meshComp, out dictionary))
		{
			return true;
		}
		AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData materialControllerData;
		if (!dictionary.TryGetValue(this, out materialControllerData))
		{
			return true;
		}
		dictionary.Remove(this);
		if (dictionary.Count == 0)
		{
			AnimNotifyAddMeshMaterialControllerDataGroup.materialControllerStateHandleMap.Remove(meshComp);
		}
		if (materialControllerData.CharRenderingComponent != null && materialControllerData.HandleId >= 0)
		{
			materialControllerData.CharRenderingComponent.RemoveMaterialControllerDataGroup(materialControllerData.HandleId);
		}
		if (materialControllerData.RenderActor != null)
		{
			materialControllerData.CharRenderingComponent.Destroy();
			materialControllerData.RenderActor.K2_DestroyActor();
		}
		if (this.HideMeshAfterPlay)
		{
			meshComp.SetHiddenInGame(true, false);
		}
		return true;
	}

	// Token: 0x0601AC5F RID: 109663 RVA: 0x00838D80 File Offset: 0x00836F80
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyAddMeshMaterialControllerDataGroup) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), AnimNotifyAddMeshMaterialControllerDataGroup.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AC60 RID: 109664 RVA: 0x00838E10 File Offset: 0x00837010
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		PD_CharacterControllerDataGroup_C materialAssetData = this.MaterialAssetData;
		string text = (materialAssetData != null) ? materialAssetData.GetName() : null;
		if (!string.IsNullOrEmpty(text))
		{
			return "召唤物/NPC材质控制器组:" + UBlueprintPathsLibrary.GetBaseFilename(text, true);
		}
		return "召唤物/NPC材质控制器组";
	}

	// Token: 0x0601AC61 RID: 109665 RVA: 0x00838E4F File Offset: 0x0083704F
	static AnimNotifyAddMeshMaterialControllerDataGroup()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnimNotifyAddMeshMaterialControllerDataGroup.CreateStaticDefaultValue), new Action(AnimNotifyAddMeshMaterialControllerDataGroup.ResetStaticDefaultValue));
	}

	// Token: 0x0601AC62 RID: 109666 RVA: 0x00838E6E File Offset: 0x0083706E
	public static void CreateStaticDefaultValue()
	{
		AnimNotifyAddMeshMaterialControllerDataGroup.materialControllerStateHandleMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData>>();
	}

	// Token: 0x0601AC63 RID: 109667 RVA: 0x00838E7A File Offset: 0x0083707A
	public static void ResetStaticDefaultValue()
	{
		AnimNotifyAddMeshMaterialControllerDataGroup.materialControllerStateHandleMap = null;
	}

	// Token: 0x0601AC64 RID: 109668 RVA: 0x00838E82 File Offset: 0x00837082
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddMeshMaterialControllerDataGroup._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerDataGroup.AnimNotifyAddMeshMaterialControllerDataGroup_C");
		}
		return AnimNotifyAddMeshMaterialControllerDataGroup._ClassPtr;
	}

	// Token: 0x0601AC65 RID: 109669 RVA: 0x00838EA8 File Offset: 0x008370A8
	public AnimNotifyAddMeshMaterialControllerDataGroup() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMeshMaterialControllerDataGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AC66 RID: 109670 RVA: 0x00838ED0 File Offset: 0x008370D0
	[NullableContext(1)]
	public AnimNotifyAddMeshMaterialControllerDataGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMeshMaterialControllerDataGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AC67 RID: 109671 RVA: 0x00838F03 File Offset: 0x00837103
	protected AnimNotifyAddMeshMaterialControllerDataGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AC68 RID: 109672 RVA: 0x00838F0C File Offset: 0x0083710C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601AC69 RID: 109673 RVA: 0x00838F48 File Offset: 0x00837148
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AC6A RID: 109674 RVA: 0x00838F7B File Offset: 0x0083717B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E902 RID: 59650
	[Nullable(1)]
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData>> materialControllerStateHandleMap;

	// Token: 0x0400E903 RID: 59651
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerDataGroup.AnimNotifyAddMeshMaterialControllerDataGroup_C";

	// Token: 0x0400E904 RID: 59652
	private static IntPtr _ClassPtr;

	// Token: 0x0400E905 RID: 59653
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E906 RID: 59654
	private static int __PropertyOffset_MaterialAssetData;

	// Token: 0x0400E907 RID: 59655
	private static int __PropertyOffset_HideMeshAfterPlay;

	// Token: 0x020089E0 RID: 35296
	[Nullable(0)]
	private class MaterialControllerData
	{
		// Token: 0x0402BE03 RID: 179715
		public int HandleId = -1;

		// Token: 0x0402BE04 RID: 179716
		public BP_MaterialControllerRenderActor_C RenderActor;

		// Token: 0x0402BE05 RID: 179717
		public CharRenderingComponent CharRenderingComponent;
	}
}

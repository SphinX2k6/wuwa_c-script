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

// Token: 0x0200345B RID: 13403
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerDataGroup.AnimNotifyAddMeshMaterialControllerDataGroup_C")]
public class AnimNotifyAddMeshMaterialControllerDataGroup : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027C2 RID: 10178
	// (get) Token: 0x0601CF57 RID: 118615 RVA: 0x00811ECB File Offset: 0x008100CB
	// (set) Token: 0x0601CF58 RID: 118616 RVA: 0x00811EDF File Offset: 0x008100DF
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

	// Token: 0x170027C3 RID: 10179
	// (get) Token: 0x0601CF59 RID: 118617 RVA: 0x00811EF4 File Offset: 0x008100F4
	// (set) Token: 0x0601CF5A RID: 118618 RVA: 0x00811F04 File Offset: 0x00810104
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

	// Token: 0x0601CF5B RID: 118619 RVA: 0x00811F18 File Offset: 0x00810118
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

	// Token: 0x0601CF5C RID: 118620 RVA: 0x00811FC0 File Offset: 0x008101C0
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

	// Token: 0x0601CF5D RID: 118621 RVA: 0x00812228 File Offset: 0x00810428
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

	// Token: 0x0601CF5E RID: 118622 RVA: 0x00812318 File Offset: 0x00810518
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

	// Token: 0x0601CF5F RID: 118623 RVA: 0x008123B8 File Offset: 0x008105B8
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

	// Token: 0x0601CF60 RID: 118624 RVA: 0x00812460 File Offset: 0x00810660
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

	// Token: 0x0601CF61 RID: 118625 RVA: 0x008124DC File Offset: 0x008106DC
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

	// Token: 0x0601CF62 RID: 118626 RVA: 0x0081251B File Offset: 0x0081071B
	static AnimNotifyAddMeshMaterialControllerDataGroup()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnimNotifyAddMeshMaterialControllerDataGroup.CreateStaticDefaultValue), new Action(AnimNotifyAddMeshMaterialControllerDataGroup.ResetStaticDefaultValue));
	}

	// Token: 0x0601CF63 RID: 118627 RVA: 0x0081253A File Offset: 0x0081073A
	public static void CreateStaticDefaultValue()
	{
		AnimNotifyAddMeshMaterialControllerDataGroup.materialControllerStateHandleMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData>>();
	}

	// Token: 0x0601CF64 RID: 118628 RVA: 0x00812546 File Offset: 0x00810746
	public static void ResetStaticDefaultValue()
	{
		AnimNotifyAddMeshMaterialControllerDataGroup.materialControllerStateHandleMap = null;
	}

	// Token: 0x0601CF65 RID: 118629 RVA: 0x0081254E File Offset: 0x0081074E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddMeshMaterialControllerDataGroup._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerDataGroup.AnimNotifyAddMeshMaterialControllerDataGroup_C");
		}
		return AnimNotifyAddMeshMaterialControllerDataGroup._ClassPtr;
	}

	// Token: 0x0601CF66 RID: 118630 RVA: 0x00812574 File Offset: 0x00810774
	public AnimNotifyAddMeshMaterialControllerDataGroup() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMeshMaterialControllerDataGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CF67 RID: 118631 RVA: 0x0081259C File Offset: 0x0081079C
	[NullableContext(1)]
	public AnimNotifyAddMeshMaterialControllerDataGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMeshMaterialControllerDataGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CF68 RID: 118632 RVA: 0x008125CF File Offset: 0x008107CF
	protected AnimNotifyAddMeshMaterialControllerDataGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CF69 RID: 118633 RVA: 0x008125D8 File Offset: 0x008107D8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601CF6A RID: 118634 RVA: 0x00812614 File Offset: 0x00810814
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601CF6B RID: 118635 RVA: 0x00812647 File Offset: 0x00810847
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E451 RID: 58449
	[Nullable(1)]
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerDataGroup.MaterialControllerData>> materialControllerStateHandleMap;

	// Token: 0x0400E452 RID: 58450
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerDataGroup.AnimNotifyAddMeshMaterialControllerDataGroup_C";

	// Token: 0x0400E453 RID: 58451
	private static IntPtr _ClassPtr;

	// Token: 0x0400E454 RID: 58452
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E455 RID: 58453
	private static int __PropertyOffset_MaterialAssetData;

	// Token: 0x0400E456 RID: 58454
	private static int __PropertyOffset_HideMeshAfterPlay;

	// Token: 0x020097BD RID: 38845
	[Nullable(0)]
	private class MaterialControllerData
	{
		// Token: 0x04030776 RID: 198518
		public int HandleId = -1;

		// Token: 0x04030777 RID: 198519
		public BP_MaterialControllerRenderActor_C RenderActor;

		// Token: 0x04030778 RID: 198520
		public CharRenderingComponent CharRenderingComponent;
	}
}

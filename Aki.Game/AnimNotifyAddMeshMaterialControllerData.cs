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

// Token: 0x0200345A RID: 13402
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerData.AnimNotifyAddMeshMaterialControllerData_C")]
public class AnimNotifyAddMeshMaterialControllerData : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027C0 RID: 10176
	// (get) Token: 0x0601CF42 RID: 118594 RVA: 0x0081173B File Offset: 0x0080F93B
	// (set) Token: 0x0601CF43 RID: 118595 RVA: 0x0081174F File Offset: 0x0080F94F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C MaterialAssetData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyAddMeshMaterialControllerData.__PropertyOffset_MaterialAssetData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyAddMeshMaterialControllerData.__PropertyOffset_MaterialAssetData, value);
		}
	}

	// Token: 0x170027C1 RID: 10177
	// (get) Token: 0x0601CF44 RID: 118596 RVA: 0x00811764 File Offset: 0x0080F964
	// (set) Token: 0x0601CF45 RID: 118597 RVA: 0x00811774 File Offset: 0x0080F974
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideMeshAfterPlay
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyAddMeshMaterialControllerData.__PropertyOffset_HideMeshAfterPlay) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyAddMeshMaterialControllerData.__PropertyOffset_HideMeshAfterPlay) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601CF46 RID: 118598 RVA: 0x00811788 File Offset: 0x0080F988
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

	// Token: 0x0601CF47 RID: 118599 RVA: 0x00811830 File Offset: 0x0080FA30
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
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("材质控制器", this.MaterialAssetData);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		AnimNotifyAddMeshMaterialControllerData.MaterialControllerData materialControllerData = new AnimNotifyAddMeshMaterialControllerData.MaterialControllerData();
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
			AnimNotifyAddMeshMaterialControllerData.MaterialControllerData materialControllerData2 = materialControllerData;
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
		materialControllerData.HandleId = materialControllerData.CharRenderingComponent.AddMaterialControllerData(this.MaterialAssetData);
		Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerData.MaterialControllerData> dictionary;
		if (!AnimNotifyAddMeshMaterialControllerData.materialControllerStateHandleMap.TryGetValue(meshComp, out dictionary))
		{
			dictionary = new Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerData.MaterialControllerData>();
			AnimNotifyAddMeshMaterialControllerData.materialControllerStateHandleMap[meshComp] = dictionary;
		}
		dictionary[this] = materialControllerData;
		return true;
	}

	// Token: 0x0601CF48 RID: 118600 RVA: 0x00811A98 File Offset: 0x0080FC98
	public unsafe bool IsAllValid(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		PD_CharacterControllerData_C materialAssetData = this.MaterialAssetData;
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

	// Token: 0x0601CF49 RID: 118601 RVA: 0x00811B88 File Offset: 0x0080FD88
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

	// Token: 0x0601CF4A RID: 118602 RVA: 0x00811C28 File Offset: 0x0080FE28
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
		Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerData.MaterialControllerData> dictionary;
		if (!AnimNotifyAddMeshMaterialControllerData.materialControllerStateHandleMap.TryGetValue(meshComp, out dictionary))
		{
			return true;
		}
		AnimNotifyAddMeshMaterialControllerData.MaterialControllerData materialControllerData;
		if (!dictionary.TryGetValue(this, out materialControllerData))
		{
			return true;
		}
		dictionary.Remove(this);
		if (dictionary.Count == 0)
		{
			AnimNotifyAddMeshMaterialControllerData.materialControllerStateHandleMap.Remove(meshComp);
		}
		if (materialControllerData.CharRenderingComponent != null && materialControllerData.HandleId >= 0)
		{
			materialControllerData.CharRenderingComponent.RemoveMaterialControllerData(materialControllerData.HandleId);
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

	// Token: 0x0601CF4B RID: 118603 RVA: 0x00811CD0 File Offset: 0x0080FED0
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

	// Token: 0x0601CF4C RID: 118604 RVA: 0x00811D4C File Offset: 0x0080FF4C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		PD_CharacterControllerData_C materialAssetData = this.MaterialAssetData;
		string text = (materialAssetData != null) ? materialAssetData.GetName() : null;
		if (!string.IsNullOrEmpty(text))
		{
			return "召唤物/NPC材质控制器:" + UBlueprintPathsLibrary.GetBaseFilename(text, true);
		}
		return "召唤物/NPC材质控制器";
	}

	// Token: 0x0601CF4D RID: 118605 RVA: 0x00811D8B File Offset: 0x0080FF8B
	static AnimNotifyAddMeshMaterialControllerData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnimNotifyAddMeshMaterialControllerData.CreateStaticDefaultValue), new Action(AnimNotifyAddMeshMaterialControllerData.ResetStaticDefaultValue));
	}

	// Token: 0x0601CF4E RID: 118606 RVA: 0x00811DAA File Offset: 0x0080FFAA
	public static void CreateStaticDefaultValue()
	{
		AnimNotifyAddMeshMaterialControllerData.materialControllerStateHandleMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerData.MaterialControllerData>>();
	}

	// Token: 0x0601CF4F RID: 118607 RVA: 0x00811DB6 File Offset: 0x0080FFB6
	public static void ResetStaticDefaultValue()
	{
		AnimNotifyAddMeshMaterialControllerData.materialControllerStateHandleMap = null;
	}

	// Token: 0x0601CF50 RID: 118608 RVA: 0x00811DBE File Offset: 0x0080FFBE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddMeshMaterialControllerData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerData.AnimNotifyAddMeshMaterialControllerData_C");
		}
		return AnimNotifyAddMeshMaterialControllerData._ClassPtr;
	}

	// Token: 0x0601CF51 RID: 118609 RVA: 0x00811DE4 File Offset: 0x0080FFE4
	public AnimNotifyAddMeshMaterialControllerData() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMeshMaterialControllerData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CF52 RID: 118610 RVA: 0x00811E0C File Offset: 0x0081000C
	[NullableContext(1)]
	public AnimNotifyAddMeshMaterialControllerData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMeshMaterialControllerData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CF53 RID: 118611 RVA: 0x00811E3F File Offset: 0x0081003F
	protected AnimNotifyAddMeshMaterialControllerData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CF54 RID: 118612 RVA: 0x00811E48 File Offset: 0x00810048
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601CF55 RID: 118613 RVA: 0x00811E84 File Offset: 0x00810084
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601CF56 RID: 118614 RVA: 0x00811EB7 File Offset: 0x008100B7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E44B RID: 58443
	[Nullable(1)]
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerData.MaterialControllerData>> materialControllerStateHandleMap;

	// Token: 0x0400E44C RID: 58444
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerData.AnimNotifyAddMeshMaterialControllerData_C";

	// Token: 0x0400E44D RID: 58445
	private static IntPtr _ClassPtr;

	// Token: 0x0400E44E RID: 58446
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E44F RID: 58447
	private static int __PropertyOffset_MaterialAssetData;

	// Token: 0x0400E450 RID: 58448
	private static int __PropertyOffset_HideMeshAfterPlay;

	// Token: 0x020097BC RID: 38844
	[Nullable(0)]
	private class MaterialControllerData
	{
		// Token: 0x04030773 RID: 198515
		public int HandleId = -1;

		// Token: 0x04030774 RID: 198516
		public BP_MaterialControllerRenderActor_C RenderActor;

		// Token: 0x04030775 RID: 198517
		public CharRenderingComponent CharRenderingComponent;
	}
}

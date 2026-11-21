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

// Token: 0x020029CE RID: 10702
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerData.AnimNotifyAddMeshMaterialControllerData_C")]
public class AnimNotifyAddMeshMaterialControllerData : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B5B RID: 11099
	// (get) Token: 0x0601AC41 RID: 109633 RVA: 0x00837FE7 File Offset: 0x008361E7
	// (set) Token: 0x0601AC42 RID: 109634 RVA: 0x00837FFB File Offset: 0x008361FB
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

	// Token: 0x17002B5C RID: 11100
	// (get) Token: 0x0601AC43 RID: 109635 RVA: 0x00838010 File Offset: 0x00836210
	// (set) Token: 0x0601AC44 RID: 109636 RVA: 0x00838020 File Offset: 0x00836220
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

	// Token: 0x0601AC45 RID: 109637 RVA: 0x00838034 File Offset: 0x00836234
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyAddMeshMaterialControllerData) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), AnimNotifyAddMeshMaterialControllerData.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AC46 RID: 109638 RVA: 0x008380F4 File Offset: 0x008362F4
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

	// Token: 0x0601AC47 RID: 109639 RVA: 0x0083835C File Offset: 0x0083655C
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

	// Token: 0x0601AC48 RID: 109640 RVA: 0x0083844C File Offset: 0x0083664C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyAddMeshMaterialControllerData) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), AnimNotifyAddMeshMaterialControllerData.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AC49 RID: 109641 RVA: 0x00838504 File Offset: 0x00836704
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

	// Token: 0x0601AC4A RID: 109642 RVA: 0x008385AC File Offset: 0x008367AC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyAddMeshMaterialControllerData) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), AnimNotifyAddMeshMaterialControllerData.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AC4B RID: 109643 RVA: 0x0083863C File Offset: 0x0083683C
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

	// Token: 0x0601AC4C RID: 109644 RVA: 0x0083867B File Offset: 0x0083687B
	static AnimNotifyAddMeshMaterialControllerData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnimNotifyAddMeshMaterialControllerData.CreateStaticDefaultValue), new Action(AnimNotifyAddMeshMaterialControllerData.ResetStaticDefaultValue));
	}

	// Token: 0x0601AC4D RID: 109645 RVA: 0x0083869A File Offset: 0x0083689A
	public static void CreateStaticDefaultValue()
	{
		AnimNotifyAddMeshMaterialControllerData.materialControllerStateHandleMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerData.MaterialControllerData>>();
	}

	// Token: 0x0601AC4E RID: 109646 RVA: 0x008386A6 File Offset: 0x008368A6
	public static void ResetStaticDefaultValue()
	{
		AnimNotifyAddMeshMaterialControllerData.materialControllerStateHandleMap = null;
	}

	// Token: 0x0601AC4F RID: 109647 RVA: 0x008386AE File Offset: 0x008368AE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddMeshMaterialControllerData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerData.AnimNotifyAddMeshMaterialControllerData_C");
		}
		return AnimNotifyAddMeshMaterialControllerData._ClassPtr;
	}

	// Token: 0x0601AC50 RID: 109648 RVA: 0x008386D4 File Offset: 0x008368D4
	public AnimNotifyAddMeshMaterialControllerData() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMeshMaterialControllerData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AC51 RID: 109649 RVA: 0x008386FC File Offset: 0x008368FC
	[NullableContext(1)]
	public AnimNotifyAddMeshMaterialControllerData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMeshMaterialControllerData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AC52 RID: 109650 RVA: 0x0083872F File Offset: 0x0083692F
	protected AnimNotifyAddMeshMaterialControllerData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AC53 RID: 109651 RVA: 0x00838738 File Offset: 0x00836938
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601AC54 RID: 109652 RVA: 0x00838774 File Offset: 0x00836974
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AC55 RID: 109653 RVA: 0x008387A7 File Offset: 0x008369A7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E8FC RID: 59644
	[Nullable(1)]
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyAddMeshMaterialControllerData.MaterialControllerData>> materialControllerStateHandleMap;

	// Token: 0x0400E8FD RID: 59645
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMeshMaterialControllerData.AnimNotifyAddMeshMaterialControllerData_C";

	// Token: 0x0400E8FE RID: 59646
	private static IntPtr _ClassPtr;

	// Token: 0x0400E8FF RID: 59647
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E900 RID: 59648
	private static int __PropertyOffset_MaterialAssetData;

	// Token: 0x0400E901 RID: 59649
	private static int __PropertyOffset_HideMeshAfterPlay;

	// Token: 0x020089DF RID: 35295
	[Nullable(0)]
	private class MaterialControllerData
	{
		// Token: 0x0402BE00 RID: 179712
		public int HandleId = -1;

		// Token: 0x0402BE01 RID: 179713
		public BP_MaterialControllerRenderActor_C RenderActor;

		// Token: 0x0402BE02 RID: 179714
		public CharRenderingComponent CharRenderingComponent;
	}
}

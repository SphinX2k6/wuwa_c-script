using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Core.Common;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200345E RID: 13406
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyStateAddMaterialControllerData.AnimNotifyStateAddMaterialControllerData_C")]
public class AnimNotifyStateAddMaterialControllerData : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027C4 RID: 10180
	// (get) Token: 0x0601CF7A RID: 118650 RVA: 0x0081289C File Offset: 0x00810A9C
	// (set) Token: 0x0601CF7B RID: 118651 RVA: 0x008128B0 File Offset: 0x00810AB0
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C MaterialAssetData
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyStateAddMaterialControllerData.__PropertyOffset_MaterialAssetData);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyStateAddMaterialControllerData.__PropertyOffset_MaterialAssetData, value);
		}
	}

	// Token: 0x170027C5 RID: 10181
	// (get) Token: 0x0601CF7C RID: 118652 RVA: 0x008128C5 File Offset: 0x00810AC5
	// (set) Token: 0x0601CF7D RID: 118653 RVA: 0x008128D5 File Offset: 0x00810AD5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NeedAnyTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerData.__PropertyOffset_NeedAnyTag) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerData.__PropertyOffset_NeedAnyTag) = (value ? 1 : 0);
		}
	}

	// Token: 0x170027C6 RID: 10182
	// (get) Token: 0x0601CF7E RID: 118654 RVA: 0x008128E8 File Offset: 0x00810AE8
	// (set) Token: 0x0601CF7F RID: 118655 RVA: 0x00812921 File Offset: 0x00810B21
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<FGameplayTag, bool> PlayNeedTags
	{
		get
		{
			base.FastCheckIsValid();
			TMap<FGameplayTag, bool> result;
			if ((result = this._PlayNeedTags) == null)
			{
				result = (this._PlayNeedTags = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerData.__PropertyOffset_PlayNeedTags, this));
			}
			return result;
		}
		set
		{
			this.PlayNeedTags.CopyAssign(value);
		}
	}

	// Token: 0x170027C7 RID: 10183
	// (get) Token: 0x0601CF80 RID: 118656 RVA: 0x0081292F File Offset: 0x00810B2F
	// (set) Token: 0x0601CF81 RID: 118657 RVA: 0x0081293F File Offset: 0x00810B3F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool TagCheckWithOwner
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerData.__PropertyOffset_TagCheckWithOwner) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerData.__PropertyOffset_TagCheckWithOwner) = (value ? 1 : 0);
		}
	}

	// Token: 0x170027C8 RID: 10184
	// (get) Token: 0x0601CF82 RID: 118658 RVA: 0x00812950 File Offset: 0x00810B50
	// (set) Token: 0x0601CF83 RID: 118659 RVA: 0x00812960 File Offset: 0x00810B60
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OnlyAddOnTsBaseCharacter
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerData.__PropertyOffset_OnlyAddOnTsBaseCharacter) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerData.__PropertyOffset_OnlyAddOnTsBaseCharacter) = (value ? 1 : 0);
		}
	}

	// Token: 0x170027C9 RID: 10185
	// (get) Token: 0x0601CF84 RID: 118660 RVA: 0x00812971 File Offset: 0x00810B71
	// (set) Token: 0x0601CF85 RID: 118661 RVA: 0x00812981 File Offset: 0x00810B81
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OnlyAddOnUiActor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerData.__PropertyOffset_OnlyAddOnUiActor) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerData.__PropertyOffset_OnlyAddOnUiActor) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601CF86 RID: 118662 RVA: 0x00812994 File Offset: 0x00810B94
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

	// Token: 0x0601CF87 RID: 118663 RVA: 0x00812A3C File Offset: 0x00810C3C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (!this.IsAllValid(meshComp, animation))
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (this.OnlyAddOnTsBaseCharacter && !(owner is TsBaseCharacter))
		{
			return false;
		}
		bool flag = this.OnlyAddOnUiActor;
		if (flag)
		{
			bool flag2 = owner is TsUiSceneRoleActor || owner is TsSkeletalObserver;
			flag = !flag2;
		}
		if (flag)
		{
			return false;
		}
		if (!Info.Instance.IsInCg() && !this.GameplayTagsCheck(owner))
		{
			return false;
		}
		flag = (owner is TsUiSceneRoleActor || owner is TsSkeletalObserver);
		if (flag && !this.UiModelTagsCheck(owner))
		{
			return false;
		}
		CharRenderingComponent charRenderingComponent = null;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		int num;
		if (tsBaseCharacter != null)
		{
			charRenderingComponent = tsBaseCharacter.CharRenderingComponent;
			if (!charRenderingComponent.CheckInit())
			{
				charRenderingComponent.Init(tsBaseCharacter.RenderType);
			}
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			string text = (characterActorComponent != null) ? characterActorComponent.GetReplaceEffect(UKismetSystemLibrary.GetPathName(this.MaterialAssetData)) : null;
			PD_CharacterControllerData_C data = (!string.IsNullOrEmpty(text)) ? ResourceSystem.Instance.Load<PD_CharacterControllerData_C>(text, "js_undefined") : this.MaterialAssetData;
			num = (int)charRenderingComponent.AddMaterialControllerDataWithAnimObject(data, meshComp, null);
		}
		else
		{
			TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
			if (tsBaseVehicle != null)
			{
				charRenderingComponent = tsBaseVehicle.CharRenderingComponent;
				if (!charRenderingComponent.CheckInit())
				{
					charRenderingComponent.Init(tsBaseVehicle.RenderType);
				}
				Entity entityNoBlueprint = tsBaseVehicle.GetEntityNoBlueprint();
				string text2;
				if (entityNoBlueprint == null)
				{
					text2 = null;
				}
				else
				{
					BaseActorComponent component = entityNoBlueprint.GetComponent<BaseActorComponent>();
					text2 = ((component != null) ? component.GetReplaceEffect(UKismetSystemLibrary.GetPathName(this.MaterialAssetData)) : null);
				}
				string text3 = text2;
				PD_CharacterControllerData_C data2 = (!string.IsNullOrEmpty(text3)) ? ResourceSystem.Instance.Load<PD_CharacterControllerData_C>(text3, "js_undefined") : this.MaterialAssetData;
				num = (int)charRenderingComponent.AddMaterialControllerDataWithAnimObject(data2, meshComp, null);
			}
			else
			{
				TsUiSceneRoleActor tsUiSceneRoleActor = owner as TsUiSceneRoleActor;
				if (tsUiSceneRoleActor != null)
				{
					num = tsUiSceneRoleActor.Model.CheckGetComponent<UiModelRenderingMaterialComponent>().AddRenderingMaterialWithAnimObject(this.MaterialAssetData, meshComp);
				}
				else
				{
					charRenderingComponent = (owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
					if (charRenderingComponent == null)
					{
						charRenderingComponent = (owner.AddComponentByClass(CharRenderingComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as CharRenderingComponent);
						charRenderingComponent.Init(ECharacterRenderingType.Effect);
						charRenderingComponent.SetLogicOwner(owner);
					}
					num = (int)charRenderingComponent.AddMaterialControllerDataWithAnimObject(this.MaterialAssetData, meshComp, null);
				}
			}
		}
		if (num >= 0)
		{
			Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerData.MaterialControllerData> dictionary;
			if (!AnimNotifyStateAddMaterialControllerData.MaterialControllerStateHandleMap.TryGetValue(meshComp, out dictionary))
			{
				dictionary = new Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerData.MaterialControllerData>();
				AnimNotifyStateAddMaterialControllerData.MaterialControllerStateHandleMap[meshComp] = dictionary;
			}
			AnimNotifyStateAddMaterialControllerData.MaterialControllerData value = new AnimNotifyStateAddMaterialControllerData.MaterialControllerData
			{
				HandleId = num,
				CharRenderingComponent = charRenderingComponent
			};
			dictionary[this] = value;
			return true;
		}
		return false;
	}

	// Token: 0x0601CF88 RID: 118664 RVA: 0x00812CBC File Offset: 0x00810EBC
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

	// Token: 0x0601CF89 RID: 118665 RVA: 0x00812D5C File Offset: 0x00810F5C
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp == null)
		{
			return true;
		}
		Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerData.MaterialControllerData> dictionary;
		if (!AnimNotifyStateAddMaterialControllerData.MaterialControllerStateHandleMap.TryGetValue(meshComp, out dictionary))
		{
			return true;
		}
		AnimNotifyStateAddMaterialControllerData.MaterialControllerData materialControllerData;
		if (!dictionary.TryGetValue(this, out materialControllerData))
		{
			return true;
		}
		dictionary.Remove(this);
		if (dictionary.Count == 0)
		{
			AnimNotifyStateAddMaterialControllerData.MaterialControllerStateHandleMap.Remove(meshComp);
		}
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		try
		{
			TsUiSceneRoleActor tsUiSceneRoleActor = owner as TsUiSceneRoleActor;
			if (tsUiSceneRoleActor != null)
			{
				tsUiSceneRoleActor.Model.CheckGetComponent<UiModelRenderingMaterialComponent>().RemoveRenderingMaterialWithEnding(materialControllerData.HandleId);
				return true;
			}
			CharRenderingComponent charRenderingComponent = materialControllerData.CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				charRenderingComponent.RemoveMaterialControllerDataWithEnding(materialControllerData.HandleId);
			}
			return true;
		}
		catch
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "AnimNotifyStateAddMaterialControllerData移除材质控制器特效失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", (meshComp != null) ? meshComp.GetOwner() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("动画", animation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("handleId", materialControllerData.HandleId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return false;
	}

	// Token: 0x0601CF8A RID: 118666 RVA: 0x00812E98 File Offset: 0x00811098
	[NullableContext(2)]
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
		AActor owner = meshComp.GetOwner();
		if (owner == null || !owner.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.RenderCharacter;
			ELogAuthor author3 = ELogAuthor.MY;
			string message3 = "错误：动画Owner不合法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Actor", meshComp.GetOwner());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("动画", animation);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return false;
		}
		return true;
	}

	// Token: 0x0601CF8B RID: 118667 RVA: 0x00812FFC File Offset: 0x008111FC
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

	// Token: 0x0601CF8C RID: 118668 RVA: 0x00813078 File Offset: 0x00811278
	protected override string GetNotifyName_Implementation()
	{
		PD_CharacterControllerData_C materialAssetData = this.MaterialAssetData;
		string text = (materialAssetData != null) ? materialAssetData.GetName() : null;
		if (!string.IsNullOrEmpty(text))
		{
			return "材质控制器:" + UBlueprintPathsLibrary.GetBaseFilename(text, true);
		}
		return "材质控制器";
	}

	// Token: 0x0601CF8D RID: 118669 RVA: 0x008130B8 File Offset: 0x008112B8
	private bool UiModelTagsCheck(AActor outer)
	{
		List<UiModelTagComponent> selfAndOwnerComponents = UiModelUtil.Instance.GetSelfAndOwnerComponents<UiModelTagComponent>(outer, this.TagCheckWithOwner);
		if (selfAndOwnerComponents == null || selfAndOwnerComponents.Count == 0)
		{
			return true;
		}
		foreach (UiModelTagComponent @object in selfAndOwnerComponents)
		{
			if (TsAnimNotifyUtils.CheckTags(this.NeedAnyTag, this.PlayNeedTags, new Func<int, bool>(@object.ContainsTagById)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601CF8E RID: 118670 RVA: 0x00813144 File Offset: 0x00811344
	private bool GameplayTagsCheck(AActor outer)
	{
		BaseTagComponent baseTagComponent = null;
		TsBaseCharacter tsBaseCharacter = outer as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			BaseTagComponent baseTagComponent2;
			if (characterActorComponent == null)
			{
				baseTagComponent2 = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				baseTagComponent2 = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
			baseTagComponent = baseTagComponent2;
		}
		else if (this.TagCheckWithOwner)
		{
			int num = 0;
			TsEffectActor tsEffectActor = outer as TsEffectActor;
			if (tsEffectActor != null)
			{
				num = tsEffectActor.OwnerEntityId;
			}
			else
			{
				AEffectSystemActor aeffectSystemActor = outer as AEffectSystemActor;
				if (aeffectSystemActor != null)
				{
					num = aeffectSystemActor.GetOwnerEntityId();
				}
			}
			if (num != 0)
			{
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(num);
				BaseTagComponent baseTagComponent3;
				if (entityById == null)
				{
					baseTagComponent3 = null;
				}
				else
				{
					WorldEntity entity2 = entityById.Entity;
					baseTagComponent3 = ((entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null);
				}
				baseTagComponent = baseTagComponent3;
			}
		}
		return baseTagComponent == null || TsAnimNotifyUtils.CheckTags(this.NeedAnyTag, this.PlayNeedTags, new Func<int, bool>(baseTagComponent.HasTag));
	}

	// Token: 0x0601CF8F RID: 118671 RVA: 0x008131F9 File Offset: 0x008113F9
	static AnimNotifyStateAddMaterialControllerData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnimNotifyStateAddMaterialControllerData.CreateStaticDefaultValue), new Action(AnimNotifyStateAddMaterialControllerData.ResetStaticDefaultValue));
	}

	// Token: 0x0601CF90 RID: 118672 RVA: 0x00813218 File Offset: 0x00811418
	public static void CreateStaticDefaultValue()
	{
		AnimNotifyStateAddMaterialControllerData.MaterialControllerStateHandleMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerData.MaterialControllerData>>();
	}

	// Token: 0x0601CF91 RID: 118673 RVA: 0x00813224 File Offset: 0x00811424
	public static void ResetStaticDefaultValue()
	{
		AnimNotifyStateAddMaterialControllerData.MaterialControllerStateHandleMap = null;
	}

	// Token: 0x0601CF92 RID: 118674 RVA: 0x0081322C File Offset: 0x0081142C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStateAddMaterialControllerData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyStateAddMaterialControllerData.AnimNotifyStateAddMaterialControllerData_C");
		}
		return AnimNotifyStateAddMaterialControllerData._ClassPtr;
	}

	// Token: 0x0601CF93 RID: 118675 RVA: 0x00813250 File Offset: 0x00811450
	public AnimNotifyStateAddMaterialControllerData() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateAddMaterialControllerData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CF94 RID: 118676 RVA: 0x00813278 File Offset: 0x00811478
	public AnimNotifyStateAddMaterialControllerData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateAddMaterialControllerData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CF95 RID: 118677 RVA: 0x008132AB File Offset: 0x008114AB
	protected AnimNotifyStateAddMaterialControllerData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CF96 RID: 118678 RVA: 0x008132B4 File Offset: 0x008114B4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601CF97 RID: 118679 RVA: 0x008132F0 File Offset: 0x008114F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601CF98 RID: 118680 RVA: 0x00813323 File Offset: 0x00811523
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E45D RID: 58461
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerData.MaterialControllerData>> MaterialControllerStateHandleMap;

	// Token: 0x0400E45E RID: 58462
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyStateAddMaterialControllerData.AnimNotifyStateAddMaterialControllerData_C";

	// Token: 0x0400E45F RID: 58463
	private static IntPtr _ClassPtr;

	// Token: 0x0400E460 RID: 58464
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E461 RID: 58465
	private static int __PropertyOffset_MaterialAssetData;

	// Token: 0x0400E462 RID: 58466
	private static int __PropertyOffset_NeedAnyTag;

	// Token: 0x0400E463 RID: 58467
	private static int __PropertyOffset_PlayNeedTags;

	// Token: 0x0400E464 RID: 58468
	[Nullable(2)]
	private TMap<FGameplayTag, bool> _PlayNeedTags;

	// Token: 0x0400E465 RID: 58469
	private static int __PropertyOffset_TagCheckWithOwner;

	// Token: 0x0400E466 RID: 58470
	private static int __PropertyOffset_OnlyAddOnTsBaseCharacter;

	// Token: 0x0400E467 RID: 58471
	private static int __PropertyOffset_OnlyAddOnUiActor;

	// Token: 0x020097BE RID: 38846
	[NullableContext(0)]
	private class MaterialControllerData
	{
		// Token: 0x04030779 RID: 198521
		public int HandleId = -1;

		// Token: 0x0403077A RID: 198522
		[Nullable(2)]
		public CharRenderingComponent CharRenderingComponent;
	}
}

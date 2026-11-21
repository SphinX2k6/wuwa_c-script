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

// Token: 0x020029D2 RID: 10706
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyStateAddMaterialControllerData.AnimNotifyStateAddMaterialControllerData_C")]
public class AnimNotifyStateAddMaterialControllerData : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B5F RID: 11103
	// (get) Token: 0x0601AC79 RID: 109689 RVA: 0x008391F8 File Offset: 0x008373F8
	// (set) Token: 0x0601AC7A RID: 109690 RVA: 0x0083920C File Offset: 0x0083740C
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

	// Token: 0x17002B60 RID: 11104
	// (get) Token: 0x0601AC7B RID: 109691 RVA: 0x00839221 File Offset: 0x00837421
	// (set) Token: 0x0601AC7C RID: 109692 RVA: 0x00839231 File Offset: 0x00837431
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

	// Token: 0x17002B61 RID: 11105
	// (get) Token: 0x0601AC7D RID: 109693 RVA: 0x00839244 File Offset: 0x00837444
	// (set) Token: 0x0601AC7E RID: 109694 RVA: 0x0083927D File Offset: 0x0083747D
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

	// Token: 0x17002B62 RID: 11106
	// (get) Token: 0x0601AC7F RID: 109695 RVA: 0x0083928B File Offset: 0x0083748B
	// (set) Token: 0x0601AC80 RID: 109696 RVA: 0x0083929B File Offset: 0x0083749B
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

	// Token: 0x17002B63 RID: 11107
	// (get) Token: 0x0601AC81 RID: 109697 RVA: 0x008392AC File Offset: 0x008374AC
	// (set) Token: 0x0601AC82 RID: 109698 RVA: 0x008392BC File Offset: 0x008374BC
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

	// Token: 0x17002B64 RID: 11108
	// (get) Token: 0x0601AC83 RID: 109699 RVA: 0x008392CD File Offset: 0x008374CD
	// (set) Token: 0x0601AC84 RID: 109700 RVA: 0x008392DD File Offset: 0x008374DD
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

	// Token: 0x0601AC85 RID: 109701 RVA: 0x008392F0 File Offset: 0x008374F0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateAddMaterialControllerData) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), AnimNotifyStateAddMaterialControllerData.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AC86 RID: 109702 RVA: 0x008393B0 File Offset: 0x008375B0
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

	// Token: 0x0601AC87 RID: 109703 RVA: 0x00839630 File Offset: 0x00837830
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateAddMaterialControllerData) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), AnimNotifyStateAddMaterialControllerData.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AC88 RID: 109704 RVA: 0x008396E8 File Offset: 0x008378E8
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

	// Token: 0x0601AC89 RID: 109705 RVA: 0x00839824 File Offset: 0x00837A24
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

	// Token: 0x0601AC8A RID: 109706 RVA: 0x00839988 File Offset: 0x00837B88
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateAddMaterialControllerData) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), AnimNotifyStateAddMaterialControllerData.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AC8B RID: 109707 RVA: 0x00839A18 File Offset: 0x00837C18
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

	// Token: 0x0601AC8C RID: 109708 RVA: 0x00839A58 File Offset: 0x00837C58
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

	// Token: 0x0601AC8D RID: 109709 RVA: 0x00839AE4 File Offset: 0x00837CE4
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

	// Token: 0x0601AC8E RID: 109710 RVA: 0x00839B99 File Offset: 0x00837D99
	static AnimNotifyStateAddMaterialControllerData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnimNotifyStateAddMaterialControllerData.CreateStaticDefaultValue), new Action(AnimNotifyStateAddMaterialControllerData.ResetStaticDefaultValue));
	}

	// Token: 0x0601AC8F RID: 109711 RVA: 0x00839BB8 File Offset: 0x00837DB8
	public static void CreateStaticDefaultValue()
	{
		AnimNotifyStateAddMaterialControllerData.MaterialControllerStateHandleMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerData.MaterialControllerData>>();
	}

	// Token: 0x0601AC90 RID: 109712 RVA: 0x00839BC4 File Offset: 0x00837DC4
	public static void ResetStaticDefaultValue()
	{
		AnimNotifyStateAddMaterialControllerData.MaterialControllerStateHandleMap = null;
	}

	// Token: 0x0601AC91 RID: 109713 RVA: 0x00839BCC File Offset: 0x00837DCC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStateAddMaterialControllerData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyStateAddMaterialControllerData.AnimNotifyStateAddMaterialControllerData_C");
		}
		return AnimNotifyStateAddMaterialControllerData._ClassPtr;
	}

	// Token: 0x0601AC92 RID: 109714 RVA: 0x00839BF0 File Offset: 0x00837DF0
	public AnimNotifyStateAddMaterialControllerData() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateAddMaterialControllerData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AC93 RID: 109715 RVA: 0x00839C18 File Offset: 0x00837E18
	public AnimNotifyStateAddMaterialControllerData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateAddMaterialControllerData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AC94 RID: 109716 RVA: 0x00839C4B File Offset: 0x00837E4B
	protected AnimNotifyStateAddMaterialControllerData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AC95 RID: 109717 RVA: 0x00839C54 File Offset: 0x00837E54
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601AC96 RID: 109718 RVA: 0x00839C90 File Offset: 0x00837E90
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AC97 RID: 109719 RVA: 0x00839CC3 File Offset: 0x00837EC3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E90E RID: 59662
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerData.MaterialControllerData>> MaterialControllerStateHandleMap;

	// Token: 0x0400E90F RID: 59663
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyStateAddMaterialControllerData.AnimNotifyStateAddMaterialControllerData_C";

	// Token: 0x0400E910 RID: 59664
	private static IntPtr _ClassPtr;

	// Token: 0x0400E911 RID: 59665
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E912 RID: 59666
	private static int __PropertyOffset_MaterialAssetData;

	// Token: 0x0400E913 RID: 59667
	private static int __PropertyOffset_NeedAnyTag;

	// Token: 0x0400E914 RID: 59668
	private static int __PropertyOffset_PlayNeedTags;

	// Token: 0x0400E915 RID: 59669
	[Nullable(2)]
	private TMap<FGameplayTag, bool> _PlayNeedTags;

	// Token: 0x0400E916 RID: 59670
	private static int __PropertyOffset_TagCheckWithOwner;

	// Token: 0x0400E917 RID: 59671
	private static int __PropertyOffset_OnlyAddOnTsBaseCharacter;

	// Token: 0x0400E918 RID: 59672
	private static int __PropertyOffset_OnlyAddOnUiActor;

	// Token: 0x020089E1 RID: 35297
	[NullableContext(0)]
	private class MaterialControllerData
	{
		// Token: 0x0402BE06 RID: 179718
		public int HandleId = -1;

		// Token: 0x0402BE07 RID: 179719
		[Nullable(2)]
		public CharRenderingComponent CharRenderingComponent;
	}
}

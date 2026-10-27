using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200345F RID: 13407
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyStateAddMaterialControllerDataGroup.AnimNotifyStateAddMaterialControllerDataGroup_C")]
public class AnimNotifyStateAddMaterialControllerDataGroup : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027CA RID: 10186
	// (get) Token: 0x0601CF99 RID: 118681 RVA: 0x00813337 File Offset: 0x00811537
	// (set) Token: 0x0601CF9A RID: 118682 RVA: 0x0081334B File Offset: 0x0081154B
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerDataGroup_C MaterialAssetData
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_MaterialAssetData);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_MaterialAssetData, value);
		}
	}

	// Token: 0x170027CB RID: 10187
	// (get) Token: 0x0601CF9B RID: 118683 RVA: 0x00813360 File Offset: 0x00811560
	// (set) Token: 0x0601CF9C RID: 118684 RVA: 0x00813370 File Offset: 0x00811570
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NeedAnyTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_NeedAnyTag) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_NeedAnyTag) = (value ? 1 : 0);
		}
	}

	// Token: 0x170027CC RID: 10188
	// (get) Token: 0x0601CF9D RID: 118685 RVA: 0x00813384 File Offset: 0x00811584
	// (set) Token: 0x0601CF9E RID: 118686 RVA: 0x008133BD File Offset: 0x008115BD
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<FGameplayTag, bool> PlayNeedTags
	{
		get
		{
			base.FastCheckIsValid();
			TMap<FGameplayTag, bool> result;
			if ((result = this._PlayNeedTags) == null)
			{
				result = (this._PlayNeedTags = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_PlayNeedTags, this));
			}
			return result;
		}
		set
		{
			this.PlayNeedTags.CopyAssign(value);
		}
	}

	// Token: 0x170027CD RID: 10189
	// (get) Token: 0x0601CF9F RID: 118687 RVA: 0x008133CB File Offset: 0x008115CB
	// (set) Token: 0x0601CFA0 RID: 118688 RVA: 0x008133DB File Offset: 0x008115DB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool TagCheckWithOwner
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_TagCheckWithOwner) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_TagCheckWithOwner) = (value ? 1 : 0);
		}
	}

	// Token: 0x170027CE RID: 10190
	// (get) Token: 0x0601CFA1 RID: 118689 RVA: 0x008133EC File Offset: 0x008115EC
	// (set) Token: 0x0601CFA2 RID: 118690 RVA: 0x008133FC File Offset: 0x008115FC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OnlyAddOnTsBaseCharacter
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_OnlyAddOnTsBaseCharacter) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_OnlyAddOnTsBaseCharacter) = (value ? 1 : 0);
		}
	}

	// Token: 0x170027CF RID: 10191
	// (get) Token: 0x0601CFA3 RID: 118691 RVA: 0x0081340D File Offset: 0x0081160D
	// (set) Token: 0x0601CFA4 RID: 118692 RVA: 0x0081341D File Offset: 0x0081161D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OnlyAddOnUiActor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_OnlyAddOnUiActor) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateAddMaterialControllerDataGroup.__PropertyOffset_OnlyAddOnUiActor) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601CFA5 RID: 118693 RVA: 0x00813430 File Offset: 0x00811630
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

	// Token: 0x0601CFA6 RID: 118694 RVA: 0x008134D8 File Offset: 0x008116D8
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
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		CharRenderingComponent charRenderingComponent;
		int num;
		if (tsBaseCharacter != null)
		{
			charRenderingComponent = tsBaseCharacter.CharRenderingComponent;
			if (!charRenderingComponent.CheckInit())
			{
				charRenderingComponent.Init(tsBaseCharacter.RenderType);
			}
			num = (int)charRenderingComponent.AddMaterialControllerDataGroupWithAnimObject(this.MaterialAssetData, meshComp);
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
			num = (int)charRenderingComponent.AddMaterialControllerDataGroupWithAnimObject(this.MaterialAssetData, meshComp);
		}
		if (num >= 0)
		{
			Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerData> dictionary;
			if (!AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerStateHandleMap.TryGetValue(meshComp, out dictionary))
			{
				dictionary = new Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerData>();
				AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerStateHandleMap[meshComp] = dictionary;
			}
			AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerData value = new AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerData
			{
				HandleId = num,
				CharRenderingComponent = charRenderingComponent
			};
			dictionary[this] = value;
			return true;
		}
		return false;
	}

	// Token: 0x0601CFA7 RID: 118695 RVA: 0x00813628 File Offset: 0x00811828
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

	// Token: 0x0601CFA8 RID: 118696 RVA: 0x008136C8 File Offset: 0x008118C8
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp == null)
		{
			return true;
		}
		Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerData> dictionary;
		if (!AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerStateHandleMap.TryGetValue(meshComp, out dictionary))
		{
			return true;
		}
		AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerData materialControllerData;
		if (!dictionary.TryGetValue(this, out materialControllerData))
		{
			return true;
		}
		dictionary.Remove(this);
		if (dictionary.Count == 0)
		{
			AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerStateHandleMap.Remove(meshComp);
		}
		try
		{
			CharRenderingComponent charRenderingComponent = materialControllerData.CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				charRenderingComponent.RemoveMaterialControllerDataGroupWithEnding(materialControllerData.HandleId);
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

	// Token: 0x0601CFA9 RID: 118697 RVA: 0x008137CC File Offset: 0x008119CC
	[NullableContext(2)]
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

	// Token: 0x0601CFAA RID: 118698 RVA: 0x00813930 File Offset: 0x00811B30
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

	// Token: 0x0601CFAB RID: 118699 RVA: 0x008139AC File Offset: 0x00811BAC
	protected override string GetNotifyName_Implementation()
	{
		PD_CharacterControllerDataGroup_C materialAssetData = this.MaterialAssetData;
		string text = (materialAssetData != null) ? materialAssetData.GetName() : null;
		if (!string.IsNullOrEmpty(text))
		{
			return "材质控制器组:" + UBlueprintPathsLibrary.GetBaseFilename(text, true);
		}
		return "材质控制器组";
	}

	// Token: 0x0601CFAC RID: 118700 RVA: 0x008139EC File Offset: 0x00811BEC
	private bool UiModelTagsCheck(AActor outer)
	{
		List<UiModelTagComponent> selfAndOwnerComponents = UiModelUtil.Instance.GetSelfAndOwnerComponents<UiModelTagComponent>(outer, this.TagCheckWithOwner);
		return selfAndOwnerComponents.Count == 0 || selfAndOwnerComponents.Any((UiModelTagComponent tagComp) => TsAnimNotifyUtils.CheckTags(this.NeedAnyTag, this.PlayNeedTags, new Func<int, bool>(tagComp.ContainsTagById)));
	}

	// Token: 0x0601CFAD RID: 118701 RVA: 0x00813A28 File Offset: 0x00811C28
	private bool GameplayTagsCheck(TsBaseCharacter outer)
	{
		AnimNotifyStateAddMaterialControllerDataGroup.<>c__DisplayClass28_0 CS$<>8__locals1 = new AnimNotifyStateAddMaterialControllerDataGroup.<>c__DisplayClass28_0();
		AnimNotifyStateAddMaterialControllerDataGroup.<>c__DisplayClass28_0 CS$<>8__locals2 = CS$<>8__locals1;
		CharacterActorComponent characterActorComponent = outer.CharacterActorComponent;
		BaseTagComponent tagComp;
		if (characterActorComponent == null)
		{
			tagComp = null;
		}
		else
		{
			Entity entity = characterActorComponent.Entity;
			tagComp = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		CS$<>8__locals2.tagComp = tagComp;
		return !CS$<>8__locals1.tagComp || TsAnimNotifyUtils.CheckTags(this.NeedAnyTag, this.PlayNeedTags, (int tagId) => CS$<>8__locals1.tagComp.HasTag(tagId));
	}

	// Token: 0x0601CFAE RID: 118702 RVA: 0x00813A8B File Offset: 0x00811C8B
	static AnimNotifyStateAddMaterialControllerDataGroup()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnimNotifyStateAddMaterialControllerDataGroup.CreateStaticDefaultValue), new Action(AnimNotifyStateAddMaterialControllerDataGroup.ResetStaticDefaultValue));
	}

	// Token: 0x0601CFAF RID: 118703 RVA: 0x00813AAA File Offset: 0x00811CAA
	public static void CreateStaticDefaultValue()
	{
		AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerStateHandleMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerData>>();
	}

	// Token: 0x0601CFB0 RID: 118704 RVA: 0x00813AB6 File Offset: 0x00811CB6
	public static void ResetStaticDefaultValue()
	{
		AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerStateHandleMap = null;
	}

	// Token: 0x0601CFB1 RID: 118705 RVA: 0x00813ABE File Offset: 0x00811CBE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStateAddMaterialControllerDataGroup._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyStateAddMaterialControllerDataGroup.AnimNotifyStateAddMaterialControllerDataGroup_C");
		}
		return AnimNotifyStateAddMaterialControllerDataGroup._ClassPtr;
	}

	// Token: 0x0601CFB2 RID: 118706 RVA: 0x00813AE4 File Offset: 0x00811CE4
	public AnimNotifyStateAddMaterialControllerDataGroup() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateAddMaterialControllerDataGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CFB3 RID: 118707 RVA: 0x00813B0C File Offset: 0x00811D0C
	public AnimNotifyStateAddMaterialControllerDataGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateAddMaterialControllerDataGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CFB4 RID: 118708 RVA: 0x00813B3F File Offset: 0x00811D3F
	protected AnimNotifyStateAddMaterialControllerDataGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CFB5 RID: 118709 RVA: 0x00813B48 File Offset: 0x00811D48
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601CFB6 RID: 118710 RVA: 0x00813B84 File Offset: 0x00811D84
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601CFB7 RID: 118711 RVA: 0x00813BB7 File Offset: 0x00811DB7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E468 RID: 58472
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, AnimNotifyStateAddMaterialControllerDataGroup.MaterialControllerData>> MaterialControllerStateHandleMap;

	// Token: 0x0400E469 RID: 58473
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyStateAddMaterialControllerDataGroup.AnimNotifyStateAddMaterialControllerDataGroup_C";

	// Token: 0x0400E46A RID: 58474
	private static IntPtr _ClassPtr;

	// Token: 0x0400E46B RID: 58475
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E46C RID: 58476
	private static int __PropertyOffset_MaterialAssetData;

	// Token: 0x0400E46D RID: 58477
	private static int __PropertyOffset_NeedAnyTag;

	// Token: 0x0400E46E RID: 58478
	private static int __PropertyOffset_PlayNeedTags;

	// Token: 0x0400E46F RID: 58479
	[Nullable(2)]
	private TMap<FGameplayTag, bool> _PlayNeedTags;

	// Token: 0x0400E470 RID: 58480
	private static int __PropertyOffset_TagCheckWithOwner;

	// Token: 0x0400E471 RID: 58481
	private static int __PropertyOffset_OnlyAddOnTsBaseCharacter;

	// Token: 0x0400E472 RID: 58482
	private static int __PropertyOffset_OnlyAddOnUiActor;

	// Token: 0x020097BF RID: 38847
	[NullableContext(0)]
	private class MaterialControllerData
	{
		// Token: 0x0403077B RID: 198523
		public int HandleId = -1;

		// Token: 0x0403077C RID: 198524
		[Nullable(2)]
		public CharRenderingComponent CharRenderingComponent;
	}
}

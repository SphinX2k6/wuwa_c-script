using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003459 RID: 13401
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMaterialControllerDataGroup.AnimNotifyAddMaterialControllerDataGroup_C")]
public class AnimNotifyAddMaterialControllerDataGroup : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027BF RID: 10175
	// (get) Token: 0x0601CF35 RID: 118581 RVA: 0x008111E3 File Offset: 0x0080F3E3
	// (set) Token: 0x0601CF36 RID: 118582 RVA: 0x008111F7 File Offset: 0x0080F3F7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerDataGroup_C MaterialAssetData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyAddMaterialControllerDataGroup.__PropertyOffset_MaterialAssetData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyAddMaterialControllerDataGroup.__PropertyOffset_MaterialAssetData, value);
		}
	}

	// Token: 0x0601CF37 RID: 118583 RVA: 0x0081120C File Offset: 0x0080F40C
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
		for (int i = 0; i < this.MaterialAssetData.DataMap.Num(); i++)
		{
			PD_CharacterControllerData_C key = this.MaterialAssetData.DataMap.GetKey(i);
			if (key != null && key.DataType != ECharacterControllerType.Timeline)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.RenderCharacter;
				ELogAuthor author4 = ELogAuthor.MY;
				string message4 = "错误：DAGroup的每一个子项不能是Runtime类型,Runtime类型请使用AnimNotifyStateAddMaterialControllerDataGroup";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Actor", (meshComp != null) ? meshComp.GetOwner() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("动画", animation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("DAGroup", this.MaterialAssetData);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601CF38 RID: 118584 RVA: 0x00811440 File Offset: 0x0080F640
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x0601CF39 RID: 118585 RVA: 0x008114E0 File Offset: 0x0080F6E0
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!this.IsAllValid(meshComp, animation))
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			if (!tsBaseCharacter.CharRenderingComponent.CheckInit())
			{
				tsBaseCharacter.CharRenderingComponent.Init(tsBaseCharacter.RenderType);
			}
			return tsBaseCharacter.CharRenderingComponent.AddMaterialControllerDataGroupWithAnimObject(this.MaterialAssetData, meshComp) >= 0f;
		}
		CharRenderingComponent charRenderingComponent = owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			charRenderingComponent = (owner.AddComponentByClass(CharRenderingComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as CharRenderingComponent);
			charRenderingComponent.Init(ECharacterRenderingType.Effect);
			charRenderingComponent.SetLogicOwner(owner);
		}
		return charRenderingComponent.AddMaterialControllerDataGroupWithAnimObject(this.MaterialAssetData, meshComp) >= 0f;
	}

	// Token: 0x0601CF3A RID: 118586 RVA: 0x008115B0 File Offset: 0x0080F7B0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x0601CF3B RID: 118587 RVA: 0x0081162C File Offset: 0x0080F82C
	[NullableContext(1)]
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

	// Token: 0x0601CF3C RID: 118588 RVA: 0x0081166B File Offset: 0x0080F86B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddMaterialControllerDataGroup._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMaterialControllerDataGroup.AnimNotifyAddMaterialControllerDataGroup_C");
		}
		return AnimNotifyAddMaterialControllerDataGroup._ClassPtr;
	}

	// Token: 0x0601CF3D RID: 118589 RVA: 0x00811690 File Offset: 0x0080F890
	public AnimNotifyAddMaterialControllerDataGroup() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMaterialControllerDataGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CF3E RID: 118590 RVA: 0x008116B8 File Offset: 0x0080F8B8
	[NullableContext(1)]
	public AnimNotifyAddMaterialControllerDataGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMaterialControllerDataGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CF3F RID: 118591 RVA: 0x008116EB File Offset: 0x0080F8EB
	protected AnimNotifyAddMaterialControllerDataGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CF40 RID: 118592 RVA: 0x008116F4 File Offset: 0x0080F8F4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601CF41 RID: 118593 RVA: 0x00811727 File Offset: 0x0080F927
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E447 RID: 58439
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMaterialControllerDataGroup.AnimNotifyAddMaterialControllerDataGroup_C";

	// Token: 0x0400E448 RID: 58440
	private static IntPtr _ClassPtr;

	// Token: 0x0400E449 RID: 58441
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E44A RID: 58442
	private static int __PropertyOffset_MaterialAssetData;
}

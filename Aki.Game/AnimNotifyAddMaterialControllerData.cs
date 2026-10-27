using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003458 RID: 13400
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMaterialControllerData.AnimNotifyAddMaterialControllerData_C")]
public class AnimNotifyAddMaterialControllerData : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027BD RID: 10173
	// (get) Token: 0x0601CF26 RID: 118566 RVA: 0x00810C40 File Offset: 0x0080EE40
	// (set) Token: 0x0601CF27 RID: 118567 RVA: 0x00810C54 File Offset: 0x0080EE54
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C MaterialAssetData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyAddMaterialControllerData.__PropertyOffset_MaterialAssetData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyAddMaterialControllerData.__PropertyOffset_MaterialAssetData, value);
		}
	}

	// Token: 0x170027BE RID: 10174
	// (get) Token: 0x0601CF28 RID: 118568 RVA: 0x00810C69 File Offset: 0x0080EE69
	// (set) Token: 0x0601CF29 RID: 118569 RVA: 0x00810C79 File Offset: 0x0080EE79
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool RemoveWhenRevive
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyAddMaterialControllerData.__PropertyOffset_RemoveWhenRevive) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyAddMaterialControllerData.__PropertyOffset_RemoveWhenRevive) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601CF2A RID: 118570 RVA: 0x00810C8C File Offset: 0x0080EE8C
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
		if (this.MaterialAssetData.DataType != ECharacterControllerType.Timeline)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.RenderCharacter;
			ELogAuthor author4 = ELogAuthor.MY;
			string message4 = "错误：特效DA不能是Runtime类型,Runtime类型请使用AnimNotifyStateAddMaterialControllerData";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Actor", (meshComp != null) ? meshComp.GetOwner() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("动画", animation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("DA", this.MaterialAssetData);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
			return false;
		}
		return true;
	}

	// Token: 0x0601CF2B RID: 118571 RVA: 0x00810E84 File Offset: 0x0080F084
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

	// Token: 0x0601CF2C RID: 118572 RVA: 0x00810F24 File Offset: 0x0080F124
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
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
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			if (!tsBaseCharacter.CharRenderingComponent.CheckInit())
			{
				tsBaseCharacter.CharRenderingComponent.Init(tsBaseCharacter.RenderType);
			}
			float num = tsBaseCharacter.CharRenderingComponent.AddMaterialControllerDataWithAnimObject(this.MaterialAssetData, meshComp, null);
			bool flag = num >= 0f;
			if (flag && this.RemoveWhenRevive)
			{
				RoleDeathComponent component = EntitySystem.Instance.GetComponent<RoleDeathComponent>(tsBaseCharacter.EntityId);
				if (component != null)
				{
					component.AddMaterialHandle((int)num);
				}
			}
			if (flag)
			{
				EventSystem.Instance.Emit<AActor, int>(EEventName.OnAnimNotifyMaterialControllerHandleAdded, owner, (int)num);
			}
			return flag;
		}
		TsUiSceneRoleActor tsUiSceneRoleActor = owner as TsUiSceneRoleActor;
		if (tsUiSceneRoleActor != null)
		{
			return tsUiSceneRoleActor.Model.CheckGetComponent<UiModelRenderingMaterialComponent>().AddRenderingMaterialByData(this.MaterialAssetData) >= 0;
		}
		CharRenderingComponent charRenderingComponent = owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			charRenderingComponent = (owner.AddComponentByClass(CharRenderingComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as CharRenderingComponent);
			charRenderingComponent.Init(ECharacterRenderingType.Effect);
			charRenderingComponent.SetLogicOwner(owner);
		}
		charRenderingComponent.AddMaterialControllerDataWithAnimObject(this.MaterialAssetData, meshComp, null);
		return false;
	}

	// Token: 0x0601CF2D RID: 118573 RVA: 0x00811060 File Offset: 0x0080F260
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

	// Token: 0x0601CF2E RID: 118574 RVA: 0x008110DC File Offset: 0x0080F2DC
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		string name = this.MaterialAssetData.GetName();
		if (!string.IsNullOrEmpty(name))
		{
			return "材质控制器:" + UBlueprintPathsLibrary.GetBaseFilename(name, true);
		}
		return "材质控制器";
	}

	// Token: 0x0601CF2F RID: 118575 RVA: 0x00811114 File Offset: 0x0080F314
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddMaterialControllerData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMaterialControllerData.AnimNotifyAddMaterialControllerData_C");
		}
		return AnimNotifyAddMaterialControllerData._ClassPtr;
	}

	// Token: 0x0601CF30 RID: 118576 RVA: 0x00811138 File Offset: 0x0080F338
	public AnimNotifyAddMaterialControllerData() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMaterialControllerData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CF31 RID: 118577 RVA: 0x00811160 File Offset: 0x0080F360
	[NullableContext(1)]
	public AnimNotifyAddMaterialControllerData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMaterialControllerData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CF32 RID: 118578 RVA: 0x00811193 File Offset: 0x0080F393
	protected AnimNotifyAddMaterialControllerData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CF33 RID: 118579 RVA: 0x0081119C File Offset: 0x0080F39C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601CF34 RID: 118580 RVA: 0x008111CF File Offset: 0x0080F3CF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E442 RID: 58434
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMaterialControllerData.AnimNotifyAddMaterialControllerData_C";

	// Token: 0x0400E443 RID: 58435
	private static IntPtr _ClassPtr;

	// Token: 0x0400E444 RID: 58436
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E445 RID: 58437
	private static int __PropertyOffset_MaterialAssetData;

	// Token: 0x0400E446 RID: 58438
	private static int __PropertyOffset_RemoveWhenRevive;
}

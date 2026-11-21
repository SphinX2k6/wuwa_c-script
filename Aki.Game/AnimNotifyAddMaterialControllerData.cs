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

// Token: 0x020029CC RID: 10700
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMaterialControllerData.AnimNotifyAddMaterialControllerData_C")]
public class AnimNotifyAddMaterialControllerData : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B58 RID: 11096
	// (get) Token: 0x0601AC25 RID: 109605 RVA: 0x00837494 File Offset: 0x00835694
	// (set) Token: 0x0601AC26 RID: 109606 RVA: 0x008374A8 File Offset: 0x008356A8
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

	// Token: 0x17002B59 RID: 11097
	// (get) Token: 0x0601AC27 RID: 109607 RVA: 0x008374BD File Offset: 0x008356BD
	// (set) Token: 0x0601AC28 RID: 109608 RVA: 0x008374CD File Offset: 0x008356CD
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

	// Token: 0x0601AC29 RID: 109609 RVA: 0x008374E0 File Offset: 0x008356E0
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

	// Token: 0x0601AC2A RID: 109610 RVA: 0x008376D8 File Offset: 0x008358D8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyAddMaterialControllerData) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), AnimNotifyAddMaterialControllerData.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AC2B RID: 109611 RVA: 0x00837790 File Offset: 0x00835990
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

	// Token: 0x0601AC2C RID: 109612 RVA: 0x008378CC File Offset: 0x00835ACC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyAddMaterialControllerData) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), AnimNotifyAddMaterialControllerData.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0601AC2D RID: 109613 RVA: 0x0083795C File Offset: 0x00835B5C
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

	// Token: 0x0601AC2E RID: 109614 RVA: 0x00837994 File Offset: 0x00835B94
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddMaterialControllerData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMaterialControllerData.AnimNotifyAddMaterialControllerData_C");
		}
		return AnimNotifyAddMaterialControllerData._ClassPtr;
	}

	// Token: 0x0601AC2F RID: 109615 RVA: 0x008379B8 File Offset: 0x00835BB8
	public AnimNotifyAddMaterialControllerData() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMaterialControllerData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AC30 RID: 109616 RVA: 0x008379E0 File Offset: 0x00835BE0
	[NullableContext(1)]
	public AnimNotifyAddMaterialControllerData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMaterialControllerData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AC31 RID: 109617 RVA: 0x00837A13 File Offset: 0x00835C13
	protected AnimNotifyAddMaterialControllerData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AC32 RID: 109618 RVA: 0x00837A1C File Offset: 0x00835C1C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AC33 RID: 109619 RVA: 0x00837A4F File Offset: 0x00835C4F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E8F3 RID: 59635
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMaterialControllerData.AnimNotifyAddMaterialControllerData_C";

	// Token: 0x0400E8F4 RID: 59636
	private static IntPtr _ClassPtr;

	// Token: 0x0400E8F5 RID: 59637
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E8F6 RID: 59638
	private static int __PropertyOffset_MaterialAssetData;

	// Token: 0x0400E8F7 RID: 59639
	private static int __PropertyOffset_RemoveWhenRevive;
}

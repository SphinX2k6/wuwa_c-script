using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200348C RID: 13452
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDebugActor.ItemMaterialDebugActor_C")]
public class ItemMaterialDebugActor : AKuroEffectActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D318 RID: 119576 RVA: 0x00821428 File Offset: 0x0081F628
	public override void EditorTick(float deltaSecond)
	{
		ItemMaterialManager.Instance.Tick(deltaSecond * 1000f);
		this.SimpleMaterialControllerUpdate();
	}

	// Token: 0x1700286E RID: 10350
	// (get) Token: 0x0601D319 RID: 119577 RVA: 0x00821441 File Offset: 0x0081F641
	// (set) Token: 0x0601D31A RID: 119578 RVA: 0x00821455 File Offset: 0x0081F655
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor Actor
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + ItemMaterialDebugActor.__PropertyOffset_Actor);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ItemMaterialDebugActor.__PropertyOffset_Actor, value);
		}
	}

	// Token: 0x1700286F RID: 10351
	// (get) Token: 0x0601D31B RID: 119579 RVA: 0x0082146A File Offset: 0x0081F66A
	// (set) Token: 0x0601D31C RID: 119580 RVA: 0x0082147E File Offset: 0x0081F67E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SimpleScalarNameTest
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_SimpleScalarNameTest);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_SimpleScalarNameTest) = value;
		}
	}

	// Token: 0x17002870 RID: 10352
	// (get) Token: 0x0601D31D RID: 119581 RVA: 0x00821493 File Offset: 0x0081F693
	// (set) Token: 0x0601D31E RID: 119582 RVA: 0x008214A3 File Offset: 0x0081F6A3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SimpleScalarValueTest
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_SimpleScalarValueTest);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_SimpleScalarValueTest) = value;
		}
	}

	// Token: 0x17002871 RID: 10353
	// (get) Token: 0x0601D31F RID: 119583 RVA: 0x008214B4 File Offset: 0x0081F6B4
	// (set) Token: 0x0601D320 RID: 119584 RVA: 0x008214C8 File Offset: 0x0081F6C8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SimpleVectorNameTest
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_SimpleVectorNameTest);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_SimpleVectorNameTest) = value;
		}
	}

	// Token: 0x17002872 RID: 10354
	// (get) Token: 0x0601D321 RID: 119585 RVA: 0x008214DD File Offset: 0x0081F6DD
	// (set) Token: 0x0601D322 RID: 119586 RVA: 0x008214F1 File Offset: 0x0081F6F1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FLinearColor SimpleVectorValueTest
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_SimpleVectorValueTest);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_SimpleVectorValueTest) = value;
		}
	}

	// Token: 0x17002873 RID: 10355
	// (get) Token: 0x0601D323 RID: 119587 RVA: 0x00821506 File Offset: 0x0081F706
	// (set) Token: 0x0601D324 RID: 119588 RVA: 0x0082151A File Offset: 0x0081F71A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ItemMaterialControllerGlobalData GlobalMaterialData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<ItemMaterialControllerGlobalData>(base.NativePtr / (IntPtr)sizeof(void*) + ItemMaterialDebugActor.__PropertyOffset_GlobalMaterialData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ItemMaterialDebugActor.__PropertyOffset_GlobalMaterialData, value);
		}
	}

	// Token: 0x17002874 RID: 10356
	// (get) Token: 0x0601D325 RID: 119589 RVA: 0x0082152F File Offset: 0x0081F72F
	// (set) Token: 0x0601D326 RID: 119590 RVA: 0x00821543 File Offset: 0x0081F743
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ItemMaterialControllerActorData MaterialData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<ItemMaterialControllerActorData>(base.NativePtr / (IntPtr)sizeof(void*) + ItemMaterialDebugActor.__PropertyOffset_MaterialData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ItemMaterialDebugActor.__PropertyOffset_MaterialData, value);
		}
	}

	// Token: 0x17002875 RID: 10357
	// (get) Token: 0x0601D327 RID: 119591 RVA: 0x00821558 File Offset: 0x0081F758
	// (set) Token: 0x0601D328 RID: 119592 RVA: 0x00821568 File Offset: 0x0081F768
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ActorMaterialControllerNum
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_ActorMaterialControllerNum);
		}
		set
		{
			*(base.NativePtr + (IntPtr)ItemMaterialDebugActor.__PropertyOffset_ActorMaterialControllerNum) = value;
		}
	}

	// Token: 0x0601D329 RID: 119593 RVA: 0x0082157C File Offset: 0x0081F77C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void DisableAllActorData()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DisableAllActorData"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D32A RID: 119594 RVA: 0x008215EC File Offset: 0x0081F7EC
	protected void DisableAllActorData_Implementation()
	{
		ItemMaterialManager.Instance.DisableAllActorData();
	}

	// Token: 0x0601D32B RID: 119595 RVA: 0x008215FC File Offset: 0x0081F7FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void DisableActorData()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DisableActorData"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D32C RID: 119596 RVA: 0x0082166C File Offset: 0x0081F86C
	protected void DisableActorData_Implementation()
	{
		ItemMaterialManager.Instance.DisableActorData((int)this.ActorMaterialControllerNum);
	}

	// Token: 0x0601D32D RID: 119597 RVA: 0x00821680 File Offset: 0x0081F880
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void EnableActorData()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EnableActorData"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D32E RID: 119598 RVA: 0x008216F0 File Offset: 0x0081F8F0
	protected void EnableActorData_Implementation()
	{
		if (this.Controllers == null)
		{
			this.Controllers = new List<ItemMaterialActorController>();
		}
		if (this.Actor != null && this.MaterialData != null)
		{
			ItemMaterialManager.Instance.AddMaterialData(this.Actor, this.MaterialData);
		}
	}

	// Token: 0x0601D32F RID: 119599 RVA: 0x0082172C File Offset: 0x0081F92C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SimpleMaterialControllerDisable()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SimpleMaterialControllerDisable"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D330 RID: 119600 RVA: 0x0082179C File Offset: 0x0081F99C
	protected void SimpleMaterialControllerDisable_Implementation()
	{
		ItemMaterialManager.Instance.DisableSimpleMaterialController((int)this.ActorMaterialControllerNum);
	}

	// Token: 0x0601D331 RID: 119601 RVA: 0x008217B0 File Offset: 0x0081F9B0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SimpleMaterialControllerUpdate()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SimpleMaterialControllerUpdate"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601D332 RID: 119602 RVA: 0x00821820 File Offset: 0x0081FA20
	protected void SimpleMaterialControllerUpdate_Implementation()
	{
		if (this.Actor != null && this.SimpleScalarNameTest != null && this.SimpleScalarValueTest != 0f && this.SimpleVectorNameTest != null)
		{
			FLinearColor simpleVectorValueTest = this.SimpleVectorValueTest;
			Dictionary<FName, float> dictionary = new Dictionary<FName, float>();
			Dictionary<FName, FLinearColor> dictionary2 = new Dictionary<FName, FLinearColor>();
			dictionary[this.SimpleScalarNameTest] = this.SimpleScalarValueTest;
			dictionary2[this.SimpleVectorNameTest] = this.SimpleVectorValueTest;
			ItemMaterialManager.Instance.AddSimpleMaterialController(this.Actor, dictionary, dictionary2);
		}
	}

	// Token: 0x0601D333 RID: 119603 RVA: 0x008218B2 File Offset: 0x0081FAB2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (ItemMaterialDebugActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDebugActor.ItemMaterialDebugActor_C");
		}
		return ItemMaterialDebugActor._ClassPtr;
	}

	// Token: 0x0601D334 RID: 119604 RVA: 0x008218D8 File Offset: 0x0081FAD8
	public ItemMaterialDebugActor() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDebugActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D335 RID: 119605 RVA: 0x00821900 File Offset: 0x0081FB00
	[NullableContext(1)]
	public ItemMaterialDebugActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D336 RID: 119606 RVA: 0x00821933 File Offset: 0x0081FB33
	protected ItemMaterialDebugActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D337 RID: 119607 RVA: 0x00821947 File Offset: 0x0081FB47
	protected virtual void __CPPCALL_DisableAllActorData_Implementation()
	{
		this.DisableAllActorData_Implementation();
	}

	// Token: 0x0601D338 RID: 119608 RVA: 0x0082194F File Offset: 0x0081FB4F
	protected virtual void __CPPCALL_DisableActorData_Implementation()
	{
		this.DisableActorData_Implementation();
	}

	// Token: 0x0601D339 RID: 119609 RVA: 0x00821957 File Offset: 0x0081FB57
	protected virtual void __CPPCALL_EnableActorData_Implementation()
	{
		this.EnableActorData_Implementation();
	}

	// Token: 0x0601D33A RID: 119610 RVA: 0x0082195F File Offset: 0x0081FB5F
	protected virtual void __CPPCALL_SimpleMaterialControllerDisable_Implementation()
	{
		this.SimpleMaterialControllerDisable_Implementation();
	}

	// Token: 0x0601D33B RID: 119611 RVA: 0x00821967 File Offset: 0x0081FB67
	protected virtual void __CPPCALL_SimpleMaterialControllerUpdate_Implementation()
	{
		this.SimpleMaterialControllerUpdate_Implementation();
	}

	// Token: 0x0400E640 RID: 58944
	public int GlobalNum;

	// Token: 0x0400E641 RID: 58945
	public ItemMaterialGlobalController GlobalItemMaterialController;

	// Token: 0x0400E642 RID: 58946
	[Nullable(1)]
	public List<ItemMaterialActorController> Controllers = new List<ItemMaterialActorController>();

	// Token: 0x0400E643 RID: 58947
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDebugActor.ItemMaterialDebugActor_C";

	// Token: 0x0400E644 RID: 58948
	private static IntPtr _ClassPtr;

	// Token: 0x0400E645 RID: 58949
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E646 RID: 58950
	private static int __PropertyOffset_Actor;

	// Token: 0x0400E647 RID: 58951
	private static int __PropertyOffset_SimpleScalarNameTest;

	// Token: 0x0400E648 RID: 58952
	private static int __PropertyOffset_SimpleScalarValueTest;

	// Token: 0x0400E649 RID: 58953
	private static int __PropertyOffset_SimpleVectorNameTest;

	// Token: 0x0400E64A RID: 58954
	private static int __PropertyOffset_SimpleVectorValueTest;

	// Token: 0x0400E64B RID: 58955
	private static int __PropertyOffset_GlobalMaterialData;

	// Token: 0x0400E64C RID: 58956
	private static int __PropertyOffset_MaterialData;

	// Token: 0x0400E64D RID: 58957
	private static int __PropertyOffset_ActorMaterialControllerNum;
}

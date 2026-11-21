using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002A00 RID: 10752
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDebugActor.ItemMaterialDebugActor_C")]
public class ItemMaterialDebugActor : AKuroEffectActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601B01E RID: 110622 RVA: 0x00848724 File Offset: 0x00846924
	public override void EditorTick(float deltaSecond)
	{
		ItemMaterialManager.Instance.Tick(deltaSecond * 1000f);
		this.SimpleMaterialControllerUpdate();
	}

	// Token: 0x17002C0B RID: 11275
	// (get) Token: 0x0601B01F RID: 110623 RVA: 0x0084873D File Offset: 0x0084693D
	// (set) Token: 0x0601B020 RID: 110624 RVA: 0x00848751 File Offset: 0x00846951
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

	// Token: 0x17002C0C RID: 11276
	// (get) Token: 0x0601B021 RID: 110625 RVA: 0x00848766 File Offset: 0x00846966
	// (set) Token: 0x0601B022 RID: 110626 RVA: 0x0084877A File Offset: 0x0084697A
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

	// Token: 0x17002C0D RID: 11277
	// (get) Token: 0x0601B023 RID: 110627 RVA: 0x0084878F File Offset: 0x0084698F
	// (set) Token: 0x0601B024 RID: 110628 RVA: 0x0084879F File Offset: 0x0084699F
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

	// Token: 0x17002C0E RID: 11278
	// (get) Token: 0x0601B025 RID: 110629 RVA: 0x008487B0 File Offset: 0x008469B0
	// (set) Token: 0x0601B026 RID: 110630 RVA: 0x008487C4 File Offset: 0x008469C4
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

	// Token: 0x17002C0F RID: 11279
	// (get) Token: 0x0601B027 RID: 110631 RVA: 0x008487D9 File Offset: 0x008469D9
	// (set) Token: 0x0601B028 RID: 110632 RVA: 0x008487ED File Offset: 0x008469ED
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

	// Token: 0x17002C10 RID: 11280
	// (get) Token: 0x0601B029 RID: 110633 RVA: 0x00848802 File Offset: 0x00846A02
	// (set) Token: 0x0601B02A RID: 110634 RVA: 0x00848816 File Offset: 0x00846A16
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

	// Token: 0x17002C11 RID: 11281
	// (get) Token: 0x0601B02B RID: 110635 RVA: 0x0084882B File Offset: 0x00846A2B
	// (set) Token: 0x0601B02C RID: 110636 RVA: 0x0084883F File Offset: 0x00846A3F
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

	// Token: 0x17002C12 RID: 11282
	// (get) Token: 0x0601B02D RID: 110637 RVA: 0x00848854 File Offset: 0x00846A54
	// (set) Token: 0x0601B02E RID: 110638 RVA: 0x00848864 File Offset: 0x00846A64
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

	// Token: 0x0601B02F RID: 110639 RVA: 0x00848878 File Offset: 0x00846A78
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void DisableAllActorData()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(ItemMaterialDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DisableAllActorData"), ItemMaterialDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.DisableAllActorData_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B030 RID: 110640 RVA: 0x008488D1 File Offset: 0x00846AD1
	protected void DisableAllActorData_Implementation()
	{
		ItemMaterialManager.Instance.DisableAllActorData();
	}

	// Token: 0x0601B031 RID: 110641 RVA: 0x008488E0 File Offset: 0x00846AE0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void DisableActorData()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(ItemMaterialDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DisableActorData"), ItemMaterialDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.DisableActorData_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B032 RID: 110642 RVA: 0x00848939 File Offset: 0x00846B39
	protected void DisableActorData_Implementation()
	{
		ItemMaterialManager.Instance.DisableActorData((int)this.ActorMaterialControllerNum);
	}

	// Token: 0x0601B033 RID: 110643 RVA: 0x00848950 File Offset: 0x00846B50
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void EnableActorData()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(ItemMaterialDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("EnableActorData"), ItemMaterialDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.EnableActorData_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B034 RID: 110644 RVA: 0x008489A9 File Offset: 0x00846BA9
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

	// Token: 0x0601B035 RID: 110645 RVA: 0x008489E8 File Offset: 0x00846BE8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void SimpleMaterialControllerDisable()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(ItemMaterialDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SimpleMaterialControllerDisable"), ItemMaterialDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.SimpleMaterialControllerDisable_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B036 RID: 110646 RVA: 0x00848A41 File Offset: 0x00846C41
	protected void SimpleMaterialControllerDisable_Implementation()
	{
		ItemMaterialManager.Instance.DisableSimpleMaterialController((int)this.ActorMaterialControllerNum);
	}

	// Token: 0x0601B037 RID: 110647 RVA: 0x00848A58 File Offset: 0x00846C58
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void SimpleMaterialControllerUpdate()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(ItemMaterialDebugActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SimpleMaterialControllerUpdate"), ItemMaterialDebugActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.SimpleMaterialControllerUpdate_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601B038 RID: 110648 RVA: 0x00848AB4 File Offset: 0x00846CB4
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

	// Token: 0x0601B039 RID: 110649 RVA: 0x00848B46 File Offset: 0x00846D46
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (ItemMaterialDebugActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDebugActor.ItemMaterialDebugActor_C");
		}
		return ItemMaterialDebugActor._ClassPtr;
	}

	// Token: 0x0601B03A RID: 110650 RVA: 0x00848B6C File Offset: 0x00846D6C
	public ItemMaterialDebugActor() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDebugActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B03B RID: 110651 RVA: 0x00848B94 File Offset: 0x00846D94
	[NullableContext(1)]
	public ItemMaterialDebugActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B03C RID: 110652 RVA: 0x00848BC7 File Offset: 0x00846DC7
	protected ItemMaterialDebugActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601B03D RID: 110653 RVA: 0x00848BDB File Offset: 0x00846DDB
	protected virtual void __CPPCALL_DisableAllActorData_Implementation()
	{
		this.DisableAllActorData_Implementation();
	}

	// Token: 0x0601B03E RID: 110654 RVA: 0x00848BE3 File Offset: 0x00846DE3
	protected virtual void __CPPCALL_DisableActorData_Implementation()
	{
		this.DisableActorData_Implementation();
	}

	// Token: 0x0601B03F RID: 110655 RVA: 0x00848BEB File Offset: 0x00846DEB
	protected virtual void __CPPCALL_EnableActorData_Implementation()
	{
		this.EnableActorData_Implementation();
	}

	// Token: 0x0601B040 RID: 110656 RVA: 0x00848BF3 File Offset: 0x00846DF3
	protected virtual void __CPPCALL_SimpleMaterialControllerDisable_Implementation()
	{
		this.SimpleMaterialControllerDisable_Implementation();
	}

	// Token: 0x0601B041 RID: 110657 RVA: 0x00848BFB File Offset: 0x00846DFB
	protected virtual void __CPPCALL_SimpleMaterialControllerUpdate_Implementation()
	{
		this.SimpleMaterialControllerUpdate_Implementation();
	}

	// Token: 0x0400EAF6 RID: 60150
	public int GlobalNum;

	// Token: 0x0400EAF7 RID: 60151
	public ItemMaterialGlobalController GlobalItemMaterialController;

	// Token: 0x0400EAF8 RID: 60152
	[Nullable(1)]
	public List<ItemMaterialActorController> Controllers = new List<ItemMaterialActorController>();

	// Token: 0x0400EAF9 RID: 60153
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDebugActor.ItemMaterialDebugActor_C";

	// Token: 0x0400EAFA RID: 60154
	private static IntPtr _ClassPtr;

	// Token: 0x0400EAFB RID: 60155
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EAFC RID: 60156
	private static int __PropertyOffset_Actor;

	// Token: 0x0400EAFD RID: 60157
	private static int __PropertyOffset_SimpleScalarNameTest;

	// Token: 0x0400EAFE RID: 60158
	private static int __PropertyOffset_SimpleScalarValueTest;

	// Token: 0x0400EAFF RID: 60159
	private static int __PropertyOffset_SimpleVectorNameTest;

	// Token: 0x0400EB00 RID: 60160
	private static int __PropertyOffset_SimpleVectorValueTest;

	// Token: 0x0400EB01 RID: 60161
	private static int __PropertyOffset_GlobalMaterialData;

	// Token: 0x0400EB02 RID: 60162
	private static int __PropertyOffset_MaterialData;

	// Token: 0x0400EB03 RID: 60163
	private static int __PropertyOffset_ActorMaterialControllerNum;
}

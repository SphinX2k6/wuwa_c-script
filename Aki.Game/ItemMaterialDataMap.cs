using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200348B RID: 13451
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDataMap.ItemMaterialDataMap_C")]
public class ItemMaterialDataMap : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700286B RID: 10347
	// (get) Token: 0x0601D311 RID: 119569 RVA: 0x00821340 File Offset: 0x0081F540
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<float, ItemMaterialControllerActorData> Map
	{
		get
		{
			base.FastCheckIsValid();
			TMap<float, ItemMaterialControllerActorData> result;
			if ((result = this._Map) == null)
			{
				result = (this._Map = new TMap<float, ItemMaterialControllerActorData>(base.NativePtr + (IntPtr)ItemMaterialDataMap.__PropertyOffset_Map, this));
			}
			return result;
		}
	}

	// Token: 0x0601D312 RID: 119570 RVA: 0x00821379 File Offset: 0x0081F579
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (ItemMaterialDataMap._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDataMap.ItemMaterialDataMap_C");
		}
		return ItemMaterialDataMap._ClassPtr;
	}

	// Token: 0x0601D313 RID: 119571 RVA: 0x008213A0 File Offset: 0x0081F5A0
	public ItemMaterialDataMap() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDataMap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D314 RID: 119572 RVA: 0x008213C8 File Offset: 0x0081F5C8
	public ItemMaterialDataMap(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDataMap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D315 RID: 119573 RVA: 0x008213FB File Offset: 0x0081F5FB
	protected ItemMaterialDataMap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x1700286C RID: 10348
	// (get) Token: 0x0601D316 RID: 119574 RVA: 0x00821404 File Offset: 0x0081F604
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		get
		{
			return *(base.NativePtr + (IntPtr)ItemMaterialDataMap.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x1700286D RID: 10349
	// (get) Token: 0x0601D317 RID: 119575 RVA: 0x00821414 File Offset: 0x0081F614
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ItemMaterialDataMap.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0400E639 RID: 58937
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDataMap.ItemMaterialDataMap_C";

	// Token: 0x0400E63A RID: 58938
	private static IntPtr _ClassPtr;

	// Token: 0x0400E63B RID: 58939
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E63C RID: 58940
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400E63D RID: 58941
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400E63E RID: 58942
	private static int __PropertyOffset_Map;

	// Token: 0x0400E63F RID: 58943
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<float, ItemMaterialControllerActorData> _Map;
}

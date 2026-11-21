using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029FF RID: 10751
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDataMap.ItemMaterialDataMap_C")]
public class ItemMaterialDataMap : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002C09 RID: 11273
	// (get) Token: 0x0601B018 RID: 110616 RVA: 0x0084864C File Offset: 0x0084684C
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

	// Token: 0x0601B019 RID: 110617 RVA: 0x00848685 File Offset: 0x00846885
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (ItemMaterialDataMap._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDataMap.ItemMaterialDataMap_C");
		}
		return ItemMaterialDataMap._ClassPtr;
	}

	// Token: 0x0601B01A RID: 110618 RVA: 0x008486AC File Offset: 0x008468AC
	public ItemMaterialDataMap() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDataMap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B01B RID: 110619 RVA: 0x008486D4 File Offset: 0x008468D4
	public ItemMaterialDataMap(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDataMap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B01C RID: 110620 RVA: 0x00848707 File Offset: 0x00846907
	protected ItemMaterialDataMap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17002C0A RID: 11274
	// (get) Token: 0x0601B01D RID: 110621 RVA: 0x00848710 File Offset: 0x00846910
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ItemMaterialDataMap.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0400EAF0 RID: 60144
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/MaterialController/ItemMaterialDataMap.ItemMaterialDataMap_C";

	// Token: 0x0400EAF1 RID: 60145
	private static IntPtr _ClassPtr;

	// Token: 0x0400EAF2 RID: 60146
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EAF3 RID: 60147
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400EAF4 RID: 60148
	private static int __PropertyOffset_Map;

	// Token: 0x0400EAF5 RID: 60149
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<float, ItemMaterialControllerActorData> _Map;
}

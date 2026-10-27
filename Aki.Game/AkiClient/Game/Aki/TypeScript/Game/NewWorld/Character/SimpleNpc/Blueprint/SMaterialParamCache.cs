using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint
{
	// Token: 0x02003A18 RID: 14872
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SMaterialParamCache.SMaterialParamCache")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 172)]
	public class SMaterialParamCache : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F347 RID: 127815 RVA: 0x008B0280 File Offset: 0x008AE480
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialParamCache._ScriptStructPtr != 0) ? SMaterialParamCache._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SMaterialParamCache.SMaterialParamCache", ref SMaterialParamCache._ScriptStructPtr);
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x0601F348 RID: 127816 RVA: 0x008B02A4 File Offset: 0x008AE4A4
		// (set) Token: 0x0601F349 RID: 127817 RVA: 0x008B02B8 File Offset: 0x008AE4B8
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic sourceMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialParamCache.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialParamCache.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x0601F34A RID: 127818 RVA: 0x008B02D0 File Offset: 0x008AE4D0
		// (set) Token: 0x0601F34B RID: 127819 RVA: 0x008B0313 File Offset: 0x008AE513
		public TMap<FName, float> floatCaches
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._floatCaches) == null)
				{
					result = (this._floatCaches = new TMap<FName, float>(base.NativePtr + (IntPtr)SMaterialParamCache.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.floatCaches.CopyAssign(value);
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x0601F34C RID: 127820 RVA: 0x008B0324 File Offset: 0x008AE524
		// (set) Token: 0x0601F34D RID: 127821 RVA: 0x008B0367 File Offset: 0x008AE567
		public TMap<FName, FLinearColor> colorCaches
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._colorCaches) == null)
				{
					result = (this._colorCaches = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)SMaterialParamCache.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.colorCaches.CopyAssign(value);
			}
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x0601F34E RID: 127822 RVA: 0x008B0375 File Offset: 0x008AE575
		// (set) Token: 0x0601F34F RID: 127823 RVA: 0x008B0385 File Offset: 0x008AE585
		public unsafe int slotIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMaterialParamCache.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMaterialParamCache.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0601F350 RID: 127824 RVA: 0x008B0396 File Offset: 0x008AE596
		public SMaterialParamCache()
		{
		}

		// Token: 0x0601F351 RID: 127825 RVA: 0x008B039E File Offset: 0x008AE59E
		public SMaterialParamCache(UMaterialInstanceDynamic sourceMaterial, TMap<FName, float> floatCaches, TMap<FName, FLinearColor> colorCaches, int slotIndex)
		{
			this.sourceMaterial = sourceMaterial;
			this.floatCaches = floatCaches;
			this.colorCaches = colorCaches;
			this.slotIndex = slotIndex;
		}

		// Token: 0x0601F352 RID: 127826 RVA: 0x008B03C3 File Offset: 0x008AE5C3
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialParamCache.StaticStruct();
		}

		// Token: 0x0601F353 RID: 127827 RVA: 0x008B03CF File Offset: 0x008AE5CF
		[NullableContext(2)]
		public SMaterialParamCache(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F354 RID: 127828 RVA: 0x008B03D9 File Offset: 0x008AE5D9
		public SMaterialParamCache(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F355 RID: 127829 RVA: 0x008B03E4 File Offset: 0x008AE5E4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialParamCache(Pointer, false, true);
		}

		// Token: 0x0601F356 RID: 127830 RVA: 0x008B03EE File Offset: 0x008AE5EE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialParamCache(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF3E RID: 61246
		public const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SMaterialParamCache.SMaterialParamCache";

		// Token: 0x0400EF3F RID: 61247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF40 RID: 61248
		internal static int __PropertyOffset_0;

		// Token: 0x0400EF41 RID: 61249
		internal static int __PropertyOffset_1;

		// Token: 0x0400EF42 RID: 61250
		[Nullable(2)]
		private TMap<FName, float> _floatCaches;

		// Token: 0x0400EF43 RID: 61251
		internal static int __PropertyOffset_2;

		// Token: 0x0400EF44 RID: 61252
		[Nullable(2)]
		private TMap<FName, FLinearColor> _colorCaches;

		// Token: 0x0400EF45 RID: 61253
		internal static int __PropertyOffset_3;
	}
}

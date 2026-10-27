using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUGrassInteraction
{
	// Token: 0x02003CA7 RID: 15527
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUGrassInteraction/Struct_GPUInteractiveFoliage.Struct_GPUInteractiveFoliage")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class Struct_GPUInteractiveFoliage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060247B1 RID: 149425 RVA: 0x0094005C File Offset: 0x0093E25C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Struct_GPUInteractiveFoliage._ScriptStructPtr != 0) ? Struct_GPUInteractiveFoliage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/GPUGrassInteraction/Struct_GPUInteractiveFoliage.Struct_GPUInteractiveFoliage", ref Struct_GPUInteractiveFoliage._ScriptStructPtr);
		}

		// Token: 0x1700474B RID: 18251
		// (get) Token: 0x060247B2 RID: 149426 RVA: 0x00940080 File Offset: 0x0093E280
		// (set) Token: 0x060247B3 RID: 149427 RVA: 0x00940094 File Offset: 0x0093E294
		[Nullable(2)]
		public unsafe UStaticMesh Static_Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GPUInteractiveFoliage.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GPUInteractiveFoliage.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700474C RID: 18252
		// (get) Token: 0x060247B4 RID: 149428 RVA: 0x009400A9 File Offset: 0x0093E2A9
		// (set) Token: 0x060247B5 RID: 149429 RVA: 0x009400BD File Offset: 0x0093E2BD
		[Nullable(2)]
		public unsafe UHoudiniPointCache Houdini_Point_Cache
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GPUInteractiveFoliage.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GPUInteractiveFoliage.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700474D RID: 18253
		// (get) Token: 0x060247B6 RID: 149430 RVA: 0x009400D4 File Offset: 0x0093E2D4
		// (set) Token: 0x060247B7 RID: 149431 RVA: 0x00940117 File Offset: 0x0093E317
		public TArray<UMaterialInterface> Interaction_Material
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Interaction_Material) == null)
				{
					result = (this._Interaction_Material = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)Struct_GPUInteractiveFoliage.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Interaction_Material.CopyAssign(value);
			}
		}

		// Token: 0x1700474E RID: 18254
		// (get) Token: 0x060247B8 RID: 149432 RVA: 0x00940128 File Offset: 0x0093E328
		// (set) Token: 0x060247B9 RID: 149433 RVA: 0x0094016B File Offset: 0x0093E36B
		public TArray<UMaterialInterface> Normal_Material
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Normal_Material) == null)
				{
					result = (this._Normal_Material = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)Struct_GPUInteractiveFoliage.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Normal_Material.CopyAssign(value);
			}
		}

		// Token: 0x1700474F RID: 18255
		// (get) Token: 0x060247BA RID: 149434 RVA: 0x00940179 File Offset: 0x0093E379
		// (set) Token: 0x060247BB RID: 149435 RVA: 0x0094018D File Offset: 0x0093E38D
		[Nullable(2)]
		public unsafe BP_GPUFoliageInteraction_C Data_Asset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GPUFoliageInteraction_C>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GPUInteractiveFoliage.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GPUInteractiveFoliage.__PropertyOffset_4, value);
			}
		}

		// Token: 0x060247BC RID: 149436 RVA: 0x009401A2 File Offset: 0x0093E3A2
		public Struct_GPUInteractiveFoliage()
		{
		}

		// Token: 0x060247BD RID: 149437 RVA: 0x009401AA File Offset: 0x0093E3AA
		public Struct_GPUInteractiveFoliage(UStaticMesh Static_Mesh, UHoudiniPointCache Houdini_Point_Cache, TArray<UMaterialInterface> Interaction_Material, TArray<UMaterialInterface> Normal_Material, BP_GPUFoliageInteraction_C Data_Asset)
		{
			this.Static_Mesh = Static_Mesh;
			this.Houdini_Point_Cache = Houdini_Point_Cache;
			this.Interaction_Material = Interaction_Material;
			this.Normal_Material = Normal_Material;
			this.Data_Asset = Data_Asset;
		}

		// Token: 0x060247BE RID: 149438 RVA: 0x009401D7 File Offset: 0x0093E3D7
		protected override IntPtr GetUStructPtr()
		{
			return Struct_GPUInteractiveFoliage.StaticStruct();
		}

		// Token: 0x060247BF RID: 149439 RVA: 0x009401E3 File Offset: 0x0093E3E3
		[NullableContext(2)]
		public Struct_GPUInteractiveFoliage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060247C0 RID: 149440 RVA: 0x009401ED File Offset: 0x0093E3ED
		public Struct_GPUInteractiveFoliage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060247C1 RID: 149441 RVA: 0x009401F8 File Offset: 0x0093E3F8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Struct_GPUInteractiveFoliage(Pointer, false, true);
		}

		// Token: 0x060247C2 RID: 149442 RVA: 0x00940202 File Offset: 0x0093E402
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Struct_GPUInteractiveFoliage(Pointer, MemoryOwner);
		}

		// Token: 0x040121C3 RID: 74179
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUGrassInteraction/Struct_GPUInteractiveFoliage.Struct_GPUInteractiveFoliage";

		// Token: 0x040121C4 RID: 74180
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121C5 RID: 74181
		internal static int __PropertyOffset_0;

		// Token: 0x040121C6 RID: 74182
		internal static int __PropertyOffset_1;

		// Token: 0x040121C7 RID: 74183
		internal static int __PropertyOffset_2;

		// Token: 0x040121C8 RID: 74184
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Interaction_Material;

		// Token: 0x040121C9 RID: 74185
		internal static int __PropertyOffset_3;

		// Token: 0x040121CA RID: 74186
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Normal_Material;

		// Token: 0x040121CB RID: 74187
		internal static int __PropertyOffset_4;
	}
}

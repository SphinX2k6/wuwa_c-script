using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._3_3_FoliageColorFading
{
	// Token: 0x02003C14 RID: 15380
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_3_FoliageColorFading/BP_ColorFadingFromFoliage.BP_ColorFadingFromFoliage_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1556)]
	public class BP_ColorFadingFromFoliage_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060232FE RID: 144126 RVA: 0x0091CB80 File Offset: 0x0091AD80
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ColorFadingFromFoliage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_3_FoliageColorFading/BP_ColorFadingFromFoliage.BP_ColorFadingFromFoliage_C");
			}
			return BP_ColorFadingFromFoliage_C._ClassPtr;
		}

		// Token: 0x060232FF RID: 144127 RVA: 0x0091CBA4 File Offset: 0x0091ADA4
		public BP_ColorFadingFromFoliage_C() : this(BuiltinUtils.AllocNativeUObject(BP_ColorFadingFromFoliage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023300 RID: 144128 RVA: 0x0091CBCC File Offset: 0x0091ADCC
		[NullableContext(1)]
		public BP_ColorFadingFromFoliage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ColorFadingFromFoliage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x06023301 RID: 144129 RVA: 0x0091CBFF File Offset: 0x0091ADFF
		// (set) Token: 0x06023302 RID: 144130 RVA: 0x0091CC13 File Offset: 0x0091AE13
		public unsafe UStaticMeshComponent TranslucentFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x06023303 RID: 144131 RVA: 0x0091CC28 File Offset: 0x0091AE28
		// (set) Token: 0x06023304 RID: 144132 RVA: 0x0091CC3C File Offset: 0x0091AE3C
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x06023305 RID: 144133 RVA: 0x0091CC51 File Offset: 0x0091AE51
		// (set) Token: 0x06023306 RID: 144134 RVA: 0x0091CC65 File Offset: 0x0091AE65
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x06023307 RID: 144135 RVA: 0x0091CC7A File Offset: 0x0091AE7A
		// (set) Token: 0x06023308 RID: 144136 RVA: 0x0091CC8E File Offset: 0x0091AE8E
		public unsafe UMaterialInstanceDynamic ShapeDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x06023309 RID: 144137 RVA: 0x0091CCA3 File Offset: 0x0091AEA3
		// (set) Token: 0x0602330A RID: 144138 RVA: 0x0091CCB7 File Offset: 0x0091AEB7
		public unsafe UMaterialInstanceDynamic ShapeDMI_ES3_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x0602330B RID: 144139 RVA: 0x0091CCCC File Offset: 0x0091AECC
		// (set) Token: 0x0602330C RID: 144140 RVA: 0x0091CCDC File Offset: 0x0091AEDC
		public unsafe bool Is_ES3_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x0602330D RID: 144141 RVA: 0x0091CCED File Offset: 0x0091AEED
		// (set) Token: 0x0602330E RID: 144142 RVA: 0x0091CD01 File Offset: 0x0091AF01
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x0602330F RID: 144143 RVA: 0x0091CD16 File Offset: 0x0091AF16
		// (set) Token: 0x06023310 RID: 144144 RVA: 0x0091CD26 File Offset: 0x0091AF26
		public unsafe bool Unused_Fogging
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x06023311 RID: 144145 RVA: 0x0091CD37 File Offset: 0x0091AF37
		// (set) Token: 0x06023312 RID: 144146 RVA: 0x0091CD4B File Offset: 0x0091AF4B
		public unsafe UStaticMesh TranslucentFoliageMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x06023313 RID: 144147 RVA: 0x0091CD60 File Offset: 0x0091AF60
		// (set) Token: 0x06023314 RID: 144148 RVA: 0x0091CD74 File Offset: 0x0091AF74
		public unsafe UMaterialInstance TranslucentFoliageMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x06023315 RID: 144149 RVA: 0x0091CD89 File Offset: 0x0091AF89
		// (set) Token: 0x06023316 RID: 144150 RVA: 0x0091CD9D File Offset: 0x0091AF9D
		public unsafe UMaterialInstance TranslucentFoliageMaterial_LOD1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorFadingFromFoliage_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x06023317 RID: 144151 RVA: 0x0091CDB2 File Offset: 0x0091AFB2
		// (set) Token: 0x06023318 RID: 144152 RVA: 0x0091CDC2 File Offset: 0x0091AFC2
		public unsafe float SphereMeshScale_Mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x06023319 RID: 144153 RVA: 0x0091CDD3 File Offset: 0x0091AFD3
		// (set) Token: 0x0602331A RID: 144154 RVA: 0x0091CDE3 File Offset: 0x0091AFE3
		public unsafe float SphereMeshScale_PC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x0602331B RID: 144155 RVA: 0x0091CDF4 File Offset: 0x0091AFF4
		// (set) Token: 0x0602331C RID: 144156 RVA: 0x0091CE04 File Offset: 0x0091B004
		public unsafe float SphereMeshScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorFadingFromFoliage_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x0602331D RID: 144157 RVA: 0x0091CE15 File Offset: 0x0091B015
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set__TranslucentFoliageMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__Set__TranslucentFoliageMesh_NativeFunctionPtr, null);
		}

		// Token: 0x0602331E RID: 144158 RVA: 0x0091CE29 File Offset: 0x0091B029
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Is_ES3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__Is_ES3_NativeFunctionPtr, null);
		}

		// Token: 0x0602331F RID: 144159 RVA: 0x0091CE3D File Offset: 0x0091B03D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_TranslusentSphereMaterial()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__Set_TranslusentSphereMaterial_NativeFunctionPtr, null);
		}

		// Token: 0x06023320 RID: 144160 RVA: 0x0091CE51 File Offset: 0x0091B051
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023321 RID: 144161 RVA: 0x0091CE65 File Offset: 0x0091B065
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023322 RID: 144162 RVA: 0x0091CE7A File Offset: 0x0091B07A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023323 RID: 144163 RVA: 0x0091CE8E File Offset: 0x0091B08E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023324 RID: 144164 RVA: 0x0091CEA4 File Offset: 0x0091B0A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ColorFadingFromFoliage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ColorFadingFromFoliage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ColorFadingFromFoliage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ColorFadingFromFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023325 RID: 144165 RVA: 0x0091CEEC File Offset: 0x0091B0EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ColorFadingFromFoliage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ColorFadingFromFoliage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ColorFadingFromFoliage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ColorFadingFromFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023326 RID: 144166 RVA: 0x0091CF34 File Offset: 0x0091B134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ColorFadingFromFoliage_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ColorFadingFromFoliage_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ColorFadingFromFoliage_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ColorFadingFromFoliage_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023327 RID: 144167 RVA: 0x0091CF7C File Offset: 0x0091B17C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ColorFadingFromFoliage_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ColorFadingFromFoliage_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ColorFadingFromFoliage_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ColorFadingFromFoliage_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ColorFadingFromFoliage_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023328 RID: 144168 RVA: 0x0091CFC3 File Offset: 0x0091B1C3
		protected BP_ColorFadingFromFoliage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401157F RID: 71039
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_3_FoliageColorFading/BP_ColorFadingFromFoliage.BP_ColorFadingFromFoliage_C";

		// Token: 0x04011580 RID: 71040
		private static IntPtr _ClassPtr;

		// Token: 0x04011581 RID: 71041
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011582 RID: 71042
		internal static int __PropertyOffset_1;

		// Token: 0x04011583 RID: 71043
		internal static int __PropertyOffset_2;

		// Token: 0x04011584 RID: 71044
		internal static int __PropertyOffset_3;

		// Token: 0x04011585 RID: 71045
		internal static int __PropertyOffset_4;

		// Token: 0x04011586 RID: 71046
		internal static int __PropertyOffset_5;

		// Token: 0x04011587 RID: 71047
		internal static int __PropertyOffset_6;

		// Token: 0x04011588 RID: 71048
		internal static int __PropertyOffset_7;

		// Token: 0x04011589 RID: 71049
		internal static int __PropertyOffset_8;

		// Token: 0x0401158A RID: 71050
		internal static int __PropertyOffset_9;

		// Token: 0x0401158B RID: 71051
		internal static int __PropertyOffset_10;

		// Token: 0x0401158C RID: 71052
		internal static int __PropertyOffset_11;

		// Token: 0x0401158D RID: 71053
		internal static int __PropertyOffset_12;

		// Token: 0x0401158E RID: 71054
		internal static int __PropertyOffset_13;

		// Token: 0x0401158F RID: 71055
		internal static int __PropertyOffset_14;

		// Token: 0x04011590 RID: 71056
		private static IntPtr __Set__TranslucentFoliageMesh_NativeFunctionPtr;

		// Token: 0x04011591 RID: 71057
		private static IntPtr __Is_ES3_NativeFunctionPtr;

		// Token: 0x04011592 RID: 71058
		private static IntPtr __Set_TranslusentSphereMaterial_NativeFunctionPtr;

		// Token: 0x04011593 RID: 71059
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011594 RID: 71060
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011595 RID: 71061
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011596 RID: 71062
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009E24 RID: 40484
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403166F RID: 202351
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E25 RID: 40485
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031670 RID: 202352
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

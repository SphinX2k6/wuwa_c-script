using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader.PrismRefractionSky
{
	// Token: 0x02003C03 RID: 15363
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/PrismRefractionSky/BP_PrismRefractionSky.BP_PrismRefractionSky_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class BP_PrismRefractionSky_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022FA9 RID: 143273 RVA: 0x009176B8 File Offset: 0x009158B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PrismRefractionSky_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/PrismRefractionSky/BP_PrismRefractionSky.BP_PrismRefractionSky_C");
			}
			return BP_PrismRefractionSky_C._ClassPtr;
		}

		// Token: 0x06022FAA RID: 143274 RVA: 0x009176DC File Offset: 0x009158DC
		public BP_PrismRefractionSky_C() : this(BuiltinUtils.AllocNativeUObject(BP_PrismRefractionSky_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022FAB RID: 143275 RVA: 0x00917704 File Offset: 0x00915904
		[NullableContext(1)]
		public BP_PrismRefractionSky_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PrismRefractionSky_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x06022FAC RID: 143276 RVA: 0x00917737 File Offset: 0x00915937
		// (set) Token: 0x06022FAD RID: 143277 RVA: 0x0091774B File Offset: 0x0091594B
		public unsafe UStaticMeshComponent SM_RefractionSkyBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x06022FAE RID: 143278 RVA: 0x00917760 File Offset: 0x00915960
		// (set) Token: 0x06022FAF RID: 143279 RVA: 0x00917774 File Offset: 0x00915974
		public unsafe UNiagaraComponent PrismRefractionPolygon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x06022FB0 RID: 143280 RVA: 0x00917789 File Offset: 0x00915989
		// (set) Token: 0x06022FB1 RID: 143281 RVA: 0x0091779D File Offset: 0x0091599D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x06022FB2 RID: 143282 RVA: 0x009177B2 File Offset: 0x009159B2
		// (set) Token: 0x06022FB3 RID: 143283 RVA: 0x009177C2 File Offset: 0x009159C2
		public unsafe float StaticMeshScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x06022FB4 RID: 143284 RVA: 0x009177D3 File Offset: 0x009159D3
		// (set) Token: 0x06022FB5 RID: 143285 RVA: 0x009177E3 File Offset: 0x009159E3
		public unsafe float Sky_RotationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x06022FB6 RID: 143286 RVA: 0x009177F4 File Offset: 0x009159F4
		// (set) Token: 0x06022FB7 RID: 143287 RVA: 0x00917808 File Offset: 0x00915A08
		public unsafe UMaterialInstanceDynamic DMI_SkyBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x06022FB8 RID: 143288 RVA: 0x0091781D File Offset: 0x00915A1D
		// (set) Token: 0x06022FB9 RID: 143289 RVA: 0x00917831 File Offset: 0x00915A31
		public unsafe UMaterialInstance MI_SkyBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PrismRefractionSky_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x06022FBA RID: 143290 RVA: 0x00917846 File Offset: 0x00915A46
		// (set) Token: 0x06022FBB RID: 143291 RVA: 0x00917856 File Offset: 0x00915A56
		public unsafe int SpawnCount_Out
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x06022FBC RID: 143292 RVA: 0x00917867 File Offset: 0x00915A67
		// (set) Token: 0x06022FBD RID: 143293 RVA: 0x00917877 File Offset: 0x00915A77
		public unsafe int SpawnCount_Internal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x06022FBE RID: 143294 RVA: 0x00917888 File Offset: 0x00915A88
		// (set) Token: 0x06022FBF RID: 143295 RVA: 0x00917898 File Offset: 0x00915A98
		public unsafe float Scale_Out
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x06022FC0 RID: 143296 RVA: 0x009178A9 File Offset: 0x00915AA9
		// (set) Token: 0x06022FC1 RID: 143297 RVA: 0x009178B9 File Offset: 0x00915AB9
		public unsafe float Scale_Internal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x06022FC2 RID: 143298 RVA: 0x009178CA File Offset: 0x00915ACA
		// (set) Token: 0x06022FC3 RID: 143299 RVA: 0x009178DA File Offset: 0x00915ADA
		public unsafe bool _________________________________
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x06022FC4 RID: 143300 RVA: 0x009178EB File Offset: 0x00915AEB
		// (set) Token: 0x06022FC5 RID: 143301 RVA: 0x009178FB File Offset: 0x00915AFB
		public unsafe float RotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x06022FC6 RID: 143302 RVA: 0x0091790C File Offset: 0x00915B0C
		// (set) Token: 0x06022FC7 RID: 143303 RVA: 0x00917920 File Offset: 0x00915B20
		public unsafe FVectorDouble WorldLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PrismRefractionSky_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x06022FC8 RID: 143304 RVA: 0x00917935 File Offset: 0x00915B35
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PrismRefractionSky_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022FC9 RID: 143305 RVA: 0x00917949 File Offset: 0x00915B49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PrismRefractionSky_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022FCA RID: 143306 RVA: 0x0091795E File Offset: 0x00915B5E
		protected BP_PrismRefractionSky_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401138F RID: 70543
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/PrismRefractionSky/BP_PrismRefractionSky.BP_PrismRefractionSky_C";

		// Token: 0x04011390 RID: 70544
		private static IntPtr _ClassPtr;

		// Token: 0x04011391 RID: 70545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011392 RID: 70546
		internal static int __PropertyOffset_0;

		// Token: 0x04011393 RID: 70547
		internal static int __PropertyOffset_1;

		// Token: 0x04011394 RID: 70548
		internal static int __PropertyOffset_2;

		// Token: 0x04011395 RID: 70549
		internal static int __PropertyOffset_3;

		// Token: 0x04011396 RID: 70550
		internal static int __PropertyOffset_4;

		// Token: 0x04011397 RID: 70551
		internal static int __PropertyOffset_5;

		// Token: 0x04011398 RID: 70552
		internal static int __PropertyOffset_6;

		// Token: 0x04011399 RID: 70553
		internal static int __PropertyOffset_7;

		// Token: 0x0401139A RID: 70554
		internal static int __PropertyOffset_8;

		// Token: 0x0401139B RID: 70555
		internal static int __PropertyOffset_9;

		// Token: 0x0401139C RID: 70556
		internal static int __PropertyOffset_10;

		// Token: 0x0401139D RID: 70557
		internal static int __PropertyOffset_11;

		// Token: 0x0401139E RID: 70558
		internal static int __PropertyOffset_12;

		// Token: 0x0401139F RID: 70559
		internal static int __PropertyOffset_13;

		// Token: 0x040113A0 RID: 70560
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}

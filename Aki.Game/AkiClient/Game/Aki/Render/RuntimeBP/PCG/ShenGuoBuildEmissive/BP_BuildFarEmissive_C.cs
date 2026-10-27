using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.ShenGuoBuildEmissive
{
	// Token: 0x02003C01 RID: 15361
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/ShenGuoBuildEmissive/BP_BuildFarEmissive.BP_BuildFarEmissive_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class BP_BuildFarEmissive_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F72 RID: 143218 RVA: 0x00917201 File Offset: 0x00915401
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BuildFarEmissive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/ShenGuoBuildEmissive/BP_BuildFarEmissive.BP_BuildFarEmissive_C");
			}
			return BP_BuildFarEmissive_C._ClassPtr;
		}

		// Token: 0x06022F73 RID: 143219 RVA: 0x00917228 File Offset: 0x00915428
		public BP_BuildFarEmissive_C() : this(BuiltinUtils.AllocNativeUObject(BP_BuildFarEmissive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F74 RID: 143220 RVA: 0x00917250 File Offset: 0x00915450
		[NullableContext(1)]
		public BP_BuildFarEmissive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BuildFarEmissive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x06022F75 RID: 143221 RVA: 0x00917283 File Offset: 0x00915483
		// (set) Token: 0x06022F76 RID: 143222 RVA: 0x00917297 File Offset: 0x00915497
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x06022F77 RID: 143223 RVA: 0x009172AC File Offset: 0x009154AC
		// (set) Token: 0x06022F78 RID: 143224 RVA: 0x009172C0 File Offset: 0x009154C0
		public unsafe UStaticMeshComponent SM_LifePlaySphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x06022F79 RID: 143225 RVA: 0x009172D5 File Offset: 0x009154D5
		// (set) Token: 0x06022F7A RID: 143226 RVA: 0x009172E9 File Offset: 0x009154E9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x06022F7B RID: 143227 RVA: 0x009172FE File Offset: 0x009154FE
		// (set) Token: 0x06022F7C RID: 143228 RVA: 0x0091730E File Offset: 0x0091550E
		public unsafe bool DebugFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x06022F7D RID: 143229 RVA: 0x0091731F File Offset: 0x0091551F
		// (set) Token: 0x06022F7E RID: 143230 RVA: 0x0091732F File Offset: 0x0091552F
		public unsafe float Sphere_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x06022F7F RID: 143231 RVA: 0x00917340 File Offset: 0x00915540
		// (set) Token: 0x06022F80 RID: 143232 RVA: 0x00917354 File Offset: 0x00915554
		public unsafe FVectorDouble Sphere_WorldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x06022F81 RID: 143233 RVA: 0x00917369 File Offset: 0x00915569
		// (set) Token: 0x06022F82 RID: 143234 RVA: 0x0091737D File Offset: 0x0091557D
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x06022F83 RID: 143235 RVA: 0x00917392 File Offset: 0x00915592
		// (set) Token: 0x06022F84 RID: 143236 RVA: 0x009173A2 File Offset: 0x009155A2
		public unsafe float FadeStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x06022F85 RID: 143237 RVA: 0x009173B3 File Offset: 0x009155B3
		// (set) Token: 0x06022F86 RID: 143238 RVA: 0x009173C3 File Offset: 0x009155C3
		public unsafe float FadeAttenuationDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BuildFarEmissive_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x06022F87 RID: 143239 RVA: 0x009173D4 File Offset: 0x009155D4
		// (set) Token: 0x06022F88 RID: 143240 RVA: 0x009173E8 File Offset: 0x009155E8
		public unsafe UMaterialInstance DebugMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x06022F89 RID: 143241 RVA: 0x009173FD File Offset: 0x009155FD
		// (set) Token: 0x06022F8A RID: 143242 RVA: 0x00917411 File Offset: 0x00915611
		public unsafe UMaterialInstanceDynamic Material_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x06022F8B RID: 143243 RVA: 0x00917426 File Offset: 0x00915626
		// (set) Token: 0x06022F8C RID: 143244 RVA: 0x0091743A File Offset: 0x0091563A
		public unsafe UMaterialInstanceDynamic DebugMaterial_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BuildFarEmissive_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x06022F8D RID: 143245 RVA: 0x0091744F File Offset: 0x0091564F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void set_Parameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BuildFarEmissive_C.__set_Parameter_NativeFunctionPtr, null);
		}

		// Token: 0x06022F8E RID: 143246 RVA: 0x00917463 File Offset: 0x00915663
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Fade_Distance_Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BuildFarEmissive_C.__Fade_Distance_Debug_NativeFunctionPtr, null);
		}

		// Token: 0x06022F8F RID: 143247 RVA: 0x00917477 File Offset: 0x00915677
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BuildFarEmissive_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022F90 RID: 143248 RVA: 0x0091748B File Offset: 0x0091568B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BuildFarEmissive_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022F91 RID: 143249 RVA: 0x009174A0 File Offset: 0x009156A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BuildFarEmissive_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022F92 RID: 143250 RVA: 0x009174B4 File Offset: 0x009156B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BuildFarEmissive_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022F93 RID: 143251 RVA: 0x009174C9 File Offset: 0x009156C9
		protected BP_BuildFarEmissive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011370 RID: 70512
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/ShenGuoBuildEmissive/BP_BuildFarEmissive.BP_BuildFarEmissive_C";

		// Token: 0x04011371 RID: 70513
		private static IntPtr _ClassPtr;

		// Token: 0x04011372 RID: 70514
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011373 RID: 70515
		internal static int __PropertyOffset_1;

		// Token: 0x04011374 RID: 70516
		internal static int __PropertyOffset_2;

		// Token: 0x04011375 RID: 70517
		internal static int __PropertyOffset_3;

		// Token: 0x04011376 RID: 70518
		internal static int __PropertyOffset_4;

		// Token: 0x04011377 RID: 70519
		internal static int __PropertyOffset_5;

		// Token: 0x04011378 RID: 70520
		internal static int __PropertyOffset_6;

		// Token: 0x04011379 RID: 70521
		internal static int __PropertyOffset_7;

		// Token: 0x0401137A RID: 70522
		internal static int __PropertyOffset_8;

		// Token: 0x0401137B RID: 70523
		internal static int __PropertyOffset_9;

		// Token: 0x0401137C RID: 70524
		internal static int __PropertyOffset_10;

		// Token: 0x0401137D RID: 70525
		internal static int __PropertyOffset_11;

		// Token: 0x0401137E RID: 70526
		internal static int __PropertyOffset_12;

		// Token: 0x0401137F RID: 70527
		private static IntPtr __set_Parameter_NativeFunctionPtr;

		// Token: 0x04011380 RID: 70528
		private static IntPtr __Fade_Distance_Debug_NativeFunctionPtr;

		// Token: 0x04011381 RID: 70529
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011382 RID: 70530
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}

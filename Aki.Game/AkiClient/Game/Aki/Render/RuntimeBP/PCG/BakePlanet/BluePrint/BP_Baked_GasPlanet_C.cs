using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BakePlanet.BluePrint
{
	// Token: 0x02003CD9 RID: 15577
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BakePlanet/BluePrint/BP_Baked_GasPlanet.BP_Baked_GasPlanet_C")]
	[UnrealStructLayout(1264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1264)]
	public class BP_Baked_GasPlanet_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024F38 RID: 151352 RVA: 0x0094D266 File Offset: 0x0094B466
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Baked_GasPlanet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BakePlanet/BluePrint/BP_Baked_GasPlanet.BP_Baked_GasPlanet_C");
			}
			return BP_Baked_GasPlanet_C._ClassPtr;
		}

		// Token: 0x06024F39 RID: 151353 RVA: 0x0094D28C File Offset: 0x0094B48C
		public BP_Baked_GasPlanet_C() : this(BuiltinUtils.AllocNativeUObject(BP_Baked_GasPlanet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024F3A RID: 151354 RVA: 0x0094D2B4 File Offset: 0x0094B4B4
		[NullableContext(1)]
		public BP_Baked_GasPlanet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Baked_GasPlanet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049F7 RID: 18935
		// (get) Token: 0x06024F3B RID: 151355 RVA: 0x0094D2E7 File Offset: 0x0094B4E7
		// (set) Token: 0x06024F3C RID: 151356 RVA: 0x0094D2FB File Offset: 0x0094B4FB
		public unsafe UStaticMeshComponent Rings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170049F8 RID: 18936
		// (get) Token: 0x06024F3D RID: 151357 RVA: 0x0094D310 File Offset: 0x0094B510
		// (set) Token: 0x06024F3E RID: 151358 RVA: 0x0094D324 File Offset: 0x0094B524
		public unsafe UStaticMeshComponent Planet
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170049F9 RID: 18937
		// (get) Token: 0x06024F3F RID: 151359 RVA: 0x0094D339 File Offset: 0x0094B539
		// (set) Token: 0x06024F40 RID: 151360 RVA: 0x0094D34D File Offset: 0x0094B54D
		public unsafe UStaticMeshComponent root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170049FA RID: 18938
		// (get) Token: 0x06024F41 RID: 151361 RVA: 0x0094D362 File Offset: 0x0094B562
		// (set) Token: 0x06024F42 RID: 151362 RVA: 0x0094D376 File Offset: 0x0094B576
		public unsafe UMaterialInstanceDynamic DMI_Atmosphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170049FB RID: 18939
		// (get) Token: 0x06024F43 RID: 151363 RVA: 0x0094D38B File Offset: 0x0094B58B
		// (set) Token: 0x06024F44 RID: 151364 RVA: 0x0094D39F File Offset: 0x0094B59F
		public unsafe UMaterialInstanceDynamic DMI_Planet
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170049FC RID: 18940
		// (get) Token: 0x06024F45 RID: 151365 RVA: 0x0094D3B4 File Offset: 0x0094B5B4
		// (set) Token: 0x06024F46 RID: 151366 RVA: 0x0094D3C8 File Offset: 0x0094B5C8
		public unsafe UMaterialInstanceDynamic DMI_Rings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170049FD RID: 18941
		// (get) Token: 0x06024F47 RID: 151367 RVA: 0x0094D3DD File Offset: 0x0094B5DD
		// (set) Token: 0x06024F48 RID: 151368 RVA: 0x0094D3F1 File Offset: 0x0094B5F1
		public unsafe ADirectionalLight SunLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADirectionalLight>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170049FE RID: 18942
		// (get) Token: 0x06024F49 RID: 151369 RVA: 0x0094D406 File Offset: 0x0094B606
		// (set) Token: 0x06024F4A RID: 151370 RVA: 0x0094D416 File Offset: 0x0094B616
		public unsafe float PlanetRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170049FF RID: 18943
		// (get) Token: 0x06024F4B RID: 151371 RVA: 0x0094D427 File Offset: 0x0094B627
		// (set) Token: 0x06024F4C RID: 151372 RVA: 0x0094D43B File Offset: 0x0094B63B
		public unsafe UMaterialInstance Planet_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004A00 RID: 18944
		// (get) Token: 0x06024F4D RID: 151373 RVA: 0x0094D450 File Offset: 0x0094B650
		// (set) Token: 0x06024F4E RID: 151374 RVA: 0x0094D464 File Offset: 0x0094B664
		public unsafe UMaterialInstance Rings_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_GasPlanet_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004A01 RID: 18945
		// (get) Token: 0x06024F4F RID: 151375 RVA: 0x0094D479 File Offset: 0x0094B679
		// (set) Token: 0x06024F50 RID: 151376 RVA: 0x0094D489 File Offset: 0x0094B689
		public unsafe float Global_Tile_Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004A02 RID: 18946
		// (get) Token: 0x06024F51 RID: 151377 RVA: 0x0094D49A File Offset: 0x0094B69A
		// (set) Token: 0x06024F52 RID: 151378 RVA: 0x0094D4AA File Offset: 0x0094B6AA
		public unsafe float Inner_Edge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004A03 RID: 18947
		// (get) Token: 0x06024F53 RID: 151379 RVA: 0x0094D4BB File Offset: 0x0094B6BB
		// (set) Token: 0x06024F54 RID: 151380 RVA: 0x0094D4CB File Offset: 0x0094B6CB
		public unsafe float Outer_Edge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x06024F55 RID: 151381 RVA: 0x0094D4DC File Offset: 0x0094B6DC
		// (set) Token: 0x06024F56 RID: 151382 RVA: 0x0094D4EC File Offset: 0x0094B6EC
		public unsafe float Frequency_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004A05 RID: 18949
		// (get) Token: 0x06024F57 RID: 151383 RVA: 0x0094D4FD File Offset: 0x0094B6FD
		// (set) Token: 0x06024F58 RID: 151384 RVA: 0x0094D50D File Offset: 0x0094B70D
		public unsafe float Frequency_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004A06 RID: 18950
		// (get) Token: 0x06024F59 RID: 151385 RVA: 0x0094D51E File Offset: 0x0094B71E
		// (set) Token: 0x06024F5A RID: 151386 RVA: 0x0094D52E File Offset: 0x0094B72E
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x06024F5B RID: 151387 RVA: 0x0094D53F File Offset: 0x0094B73F
		// (set) Token: 0x06024F5C RID: 151388 RVA: 0x0094D54F File Offset: 0x0094B74F
		public unsafe float Seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x06024F5D RID: 151389 RVA: 0x0094D560 File Offset: 0x0094B760
		// (set) Token: 0x06024F5E RID: 151390 RVA: 0x0094D570 File Offset: 0x0094B770
		public unsafe float Edge_Hardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004A09 RID: 18953
		// (get) Token: 0x06024F5F RID: 151391 RVA: 0x0094D581 File Offset: 0x0094B781
		// (set) Token: 0x06024F60 RID: 151392 RVA: 0x0094D591 File Offset: 0x0094B791
		public unsafe float Shadow_Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004A0A RID: 18954
		// (get) Token: 0x06024F61 RID: 151393 RVA: 0x0094D5A2 File Offset: 0x0094B7A2
		// (set) Token: 0x06024F62 RID: 151394 RVA: 0x0094D5B2 File Offset: 0x0094B7B2
		public unsafe float Shadow_Hardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004A0B RID: 18955
		// (get) Token: 0x06024F63 RID: 151395 RVA: 0x0094D5C3 File Offset: 0x0094B7C3
		// (set) Token: 0x06024F64 RID: 151396 RVA: 0x0094D5D3 File Offset: 0x0094B7D3
		public unsafe float Scattering_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004A0C RID: 18956
		// (get) Token: 0x06024F65 RID: 151397 RVA: 0x0094D5E4 File Offset: 0x0094B7E4
		// (set) Token: 0x06024F66 RID: 151398 RVA: 0x0094D5F4 File Offset: 0x0094B7F4
		public unsafe float Scattering_Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x06024F67 RID: 151399 RVA: 0x0094D605 File Offset: 0x0094B805
		// (set) Token: 0x06024F68 RID: 151400 RVA: 0x0094D619 File Offset: 0x0094B819
		public unsafe FLinearColor Rings_Color_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x06024F69 RID: 151401 RVA: 0x0094D62E File Offset: 0x0094B82E
		// (set) Token: 0x06024F6A RID: 151402 RVA: 0x0094D642 File Offset: 0x0094B842
		public unsafe FLinearColor Rings_Color_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x06024F6B RID: 151403 RVA: 0x0094D657 File Offset: 0x0094B857
		// (set) Token: 0x06024F6C RID: 151404 RVA: 0x0094D66B File Offset: 0x0094B86B
		public unsafe FLinearColor Rings_Color_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x06024F6D RID: 151405 RVA: 0x0094D680 File Offset: 0x0094B880
		// (set) Token: 0x06024F6E RID: 151406 RVA: 0x0094D694 File Offset: 0x0094B894
		public unsafe FLinearColor Rings_Color_4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x06024F6F RID: 151407 RVA: 0x0094D6A9 File Offset: 0x0094B8A9
		// (set) Token: 0x06024F70 RID: 151408 RVA: 0x0094D6BD File Offset: 0x0094B8BD
		public unsafe FLinearColor Rings_Scatering_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_GasPlanet_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x06024F71 RID: 151409 RVA: 0x0094D6D2 File Offset: 0x0094B8D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Baked_GasPlanet_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024F72 RID: 151410 RVA: 0x0094D6E6 File Offset: 0x0094B8E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Baked_GasPlanet_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024F73 RID: 151411 RVA: 0x0094D6FB File Offset: 0x0094B8FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Baked_GasPlanet_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024F74 RID: 151412 RVA: 0x0094D70F File Offset: 0x0094B90F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Baked_GasPlanet_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024F75 RID: 151413 RVA: 0x0094D724 File Offset: 0x0094B924
		protected BP_Baked_GasPlanet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012600 RID: 75264
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BakePlanet/BluePrint/BP_Baked_GasPlanet.BP_Baked_GasPlanet_C";

		// Token: 0x04012601 RID: 75265
		private static IntPtr _ClassPtr;

		// Token: 0x04012602 RID: 75266
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012603 RID: 75267
		internal static int __PropertyOffset_1;

		// Token: 0x04012604 RID: 75268
		internal static int __PropertyOffset_2;

		// Token: 0x04012605 RID: 75269
		internal static int __PropertyOffset_3;

		// Token: 0x04012606 RID: 75270
		internal static int __PropertyOffset_4;

		// Token: 0x04012607 RID: 75271
		internal static int __PropertyOffset_5;

		// Token: 0x04012608 RID: 75272
		internal static int __PropertyOffset_6;

		// Token: 0x04012609 RID: 75273
		internal static int __PropertyOffset_7;

		// Token: 0x0401260A RID: 75274
		internal static int __PropertyOffset_8;

		// Token: 0x0401260B RID: 75275
		internal static int __PropertyOffset_9;

		// Token: 0x0401260C RID: 75276
		internal static int __PropertyOffset_10;

		// Token: 0x0401260D RID: 75277
		internal static int __PropertyOffset_11;

		// Token: 0x0401260E RID: 75278
		internal static int __PropertyOffset_12;

		// Token: 0x0401260F RID: 75279
		internal static int __PropertyOffset_13;

		// Token: 0x04012610 RID: 75280
		internal static int __PropertyOffset_14;

		// Token: 0x04012611 RID: 75281
		internal static int __PropertyOffset_15;

		// Token: 0x04012612 RID: 75282
		internal static int __PropertyOffset_16;

		// Token: 0x04012613 RID: 75283
		internal static int __PropertyOffset_17;

		// Token: 0x04012614 RID: 75284
		internal static int __PropertyOffset_18;

		// Token: 0x04012615 RID: 75285
		internal static int __PropertyOffset_19;

		// Token: 0x04012616 RID: 75286
		internal static int __PropertyOffset_20;

		// Token: 0x04012617 RID: 75287
		internal static int __PropertyOffset_21;

		// Token: 0x04012618 RID: 75288
		internal static int __PropertyOffset_22;

		// Token: 0x04012619 RID: 75289
		internal static int __PropertyOffset_23;

		// Token: 0x0401261A RID: 75290
		internal static int __PropertyOffset_24;

		// Token: 0x0401261B RID: 75291
		internal static int __PropertyOffset_25;

		// Token: 0x0401261C RID: 75292
		internal static int __PropertyOffset_26;

		// Token: 0x0401261D RID: 75293
		internal static int __PropertyOffset_27;

		// Token: 0x0401261E RID: 75294
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401261F RID: 75295
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}

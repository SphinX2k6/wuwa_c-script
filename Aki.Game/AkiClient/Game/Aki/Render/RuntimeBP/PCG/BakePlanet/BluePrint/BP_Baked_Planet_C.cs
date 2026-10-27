using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BakePlanet.BluePrint
{
	// Token: 0x02003CDA RID: 15578
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BakePlanet/BluePrint/BP_Baked_Planet.BP_Baked_Planet_C")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1201)]
	public class BP_Baked_Planet_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024F76 RID: 151414 RVA: 0x0094D72D File Offset: 0x0094B92D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Baked_Planet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BakePlanet/BluePrint/BP_Baked_Planet.BP_Baked_Planet_C");
			}
			return BP_Baked_Planet_C._ClassPtr;
		}

		// Token: 0x06024F77 RID: 151415 RVA: 0x0094D754 File Offset: 0x0094B954
		public BP_Baked_Planet_C() : this(BuiltinUtils.AllocNativeUObject(BP_Baked_Planet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024F78 RID: 151416 RVA: 0x0094D77C File Offset: 0x0094B97C
		[NullableContext(1)]
		public BP_Baked_Planet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Baked_Planet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x06024F79 RID: 151417 RVA: 0x0094D7AF File Offset: 0x0094B9AF
		// (set) Token: 0x06024F7A RID: 151418 RVA: 0x0094D7C3 File Offset: 0x0094B9C3
		public unsafe UStaticMeshComponent Atmosphere_Simple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x06024F7B RID: 151419 RVA: 0x0094D7D8 File Offset: 0x0094B9D8
		// (set) Token: 0x06024F7C RID: 151420 RVA: 0x0094D7EC File Offset: 0x0094B9EC
		public unsafe UStaticMeshComponent Planet_Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004A14 RID: 18964
		// (get) Token: 0x06024F7D RID: 151421 RVA: 0x0094D801 File Offset: 0x0094BA01
		// (set) Token: 0x06024F7E RID: 151422 RVA: 0x0094D815 File Offset: 0x0094BA15
		public unsafe UStaticMeshComponent root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004A15 RID: 18965
		// (get) Token: 0x06024F7F RID: 151423 RVA: 0x0094D82A File Offset: 0x0094BA2A
		// (set) Token: 0x06024F80 RID: 151424 RVA: 0x0094D83A File Offset: 0x0094BA3A
		public unsafe bool UseCustomLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A16 RID: 18966
		// (get) Token: 0x06024F81 RID: 151425 RVA: 0x0094D84B File Offset: 0x0094BA4B
		// (set) Token: 0x06024F82 RID: 151426 RVA: 0x0094D85F File Offset: 0x0094BA5F
		public unsafe FRotator CustomLightDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004A17 RID: 18967
		// (get) Token: 0x06024F83 RID: 151427 RVA: 0x0094D874 File Offset: 0x0094BA74
		// (set) Token: 0x06024F84 RID: 151428 RVA: 0x0094D888 File Offset: 0x0094BA88
		public unsafe UMaterialInstanceDynamic DMI_Atmosphere_Simple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004A18 RID: 18968
		// (get) Token: 0x06024F85 RID: 151429 RVA: 0x0094D89D File Offset: 0x0094BA9D
		// (set) Token: 0x06024F86 RID: 151430 RVA: 0x0094D8B1 File Offset: 0x0094BAB1
		public unsafe UMaterialInstanceDynamic DMI_Atmosphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004A19 RID: 18969
		// (get) Token: 0x06024F87 RID: 151431 RVA: 0x0094D8C6 File Offset: 0x0094BAC6
		// (set) Token: 0x06024F88 RID: 151432 RVA: 0x0094D8DA File Offset: 0x0094BADA
		public unsafe UMaterialInstanceDynamic DMI_Planet
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004A1A RID: 18970
		// (get) Token: 0x06024F89 RID: 151433 RVA: 0x0094D8EF File Offset: 0x0094BAEF
		// (set) Token: 0x06024F8A RID: 151434 RVA: 0x0094D903 File Offset: 0x0094BB03
		public unsafe UMaterialInstanceDynamic DMI_Clouds
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004A1B RID: 18971
		// (get) Token: 0x06024F8B RID: 151435 RVA: 0x0094D918 File Offset: 0x0094BB18
		// (set) Token: 0x06024F8C RID: 151436 RVA: 0x0094D92C File Offset: 0x0094BB2C
		public unsafe UMaterialInterface Planet_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Baked_Planet_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004A1C RID: 18972
		// (get) Token: 0x06024F8D RID: 151437 RVA: 0x0094D941 File Offset: 0x0094BB41
		// (set) Token: 0x06024F8E RID: 151438 RVA: 0x0094D951 File Offset: 0x0094BB51
		public unsafe float PlanetRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004A1D RID: 18973
		// (get) Token: 0x06024F8F RID: 151439 RVA: 0x0094D962 File Offset: 0x0094BB62
		// (set) Token: 0x06024F90 RID: 151440 RVA: 0x0094D972 File Offset: 0x0094BB72
		public unsafe bool Simple_Atmosphere_Enabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A1E RID: 18974
		// (get) Token: 0x06024F91 RID: 151441 RVA: 0x0094D983 File Offset: 0x0094BB83
		// (set) Token: 0x06024F92 RID: 151442 RVA: 0x0094D993 File Offset: 0x0094BB93
		public unsafe float Direct_Atmosphere_Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004A1F RID: 18975
		// (get) Token: 0x06024F93 RID: 151443 RVA: 0x0094D9A4 File Offset: 0x0094BBA4
		// (set) Token: 0x06024F94 RID: 151444 RVA: 0x0094D9B4 File Offset: 0x0094BBB4
		public unsafe float Edge_Atmosphere_Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004A20 RID: 18976
		// (get) Token: 0x06024F95 RID: 151445 RVA: 0x0094D9C5 File Offset: 0x0094BBC5
		// (set) Token: 0x06024F96 RID: 151446 RVA: 0x0094D9D5 File Offset: 0x0094BBD5
		public unsafe float Global_Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004A21 RID: 18977
		// (get) Token: 0x06024F97 RID: 151447 RVA: 0x0094D9E6 File Offset: 0x0094BBE6
		// (set) Token: 0x06024F98 RID: 151448 RVA: 0x0094D9F6 File Offset: 0x0094BBF6
		public unsafe float Fake_Day_Night_Transition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004A22 RID: 18978
		// (get) Token: 0x06024F99 RID: 151449 RVA: 0x0094DA07 File Offset: 0x0094BC07
		// (set) Token: 0x06024F9A RID: 151450 RVA: 0x0094DA17 File Offset: 0x0094BC17
		public unsafe float Atmosphere_Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004A23 RID: 18979
		// (get) Token: 0x06024F9B RID: 151451 RVA: 0x0094DA28 File Offset: 0x0094BC28
		// (set) Token: 0x06024F9C RID: 151452 RVA: 0x0094DA38 File Offset: 0x0094BC38
		public unsafe float Fake_Scattering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004A24 RID: 18980
		// (get) Token: 0x06024F9D RID: 151453 RVA: 0x0094DA49 File Offset: 0x0094BC49
		// (set) Token: 0x06024F9E RID: 151454 RVA: 0x0094DA5D File Offset: 0x0094BC5D
		public unsafe FLinearColor Simple_Atmosphere_Day_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004A25 RID: 18981
		// (get) Token: 0x06024F9F RID: 151455 RVA: 0x0094DA72 File Offset: 0x0094BC72
		// (set) Token: 0x06024FA0 RID: 151456 RVA: 0x0094DA86 File Offset: 0x0094BC86
		public unsafe FLinearColor Simple_Atmosphere_Night_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004A26 RID: 18982
		// (get) Token: 0x06024FA1 RID: 151457 RVA: 0x0094DA9B File Offset: 0x0094BC9B
		// (set) Token: 0x06024FA2 RID: 151458 RVA: 0x0094DAAB File Offset: 0x0094BCAB
		public unsafe bool Refresh_Blueprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Baked_Planet_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024FA3 RID: 151459 RVA: 0x0094DABC File Offset: 0x0094BCBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Baked_Planet_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024FA4 RID: 151460 RVA: 0x0094DAD0 File Offset: 0x0094BCD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Baked_Planet_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024FA5 RID: 151461 RVA: 0x0094DAE5 File Offset: 0x0094BCE5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Baked_Planet_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024FA6 RID: 151462 RVA: 0x0094DAF9 File Offset: 0x0094BCF9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Baked_Planet_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024FA7 RID: 151463 RVA: 0x0094DB0E File Offset: 0x0094BD0E
		protected BP_Baked_Planet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012620 RID: 75296
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BakePlanet/BluePrint/BP_Baked_Planet.BP_Baked_Planet_C";

		// Token: 0x04012621 RID: 75297
		private static IntPtr _ClassPtr;

		// Token: 0x04012622 RID: 75298
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012623 RID: 75299
		internal static int __PropertyOffset_1;

		// Token: 0x04012624 RID: 75300
		internal static int __PropertyOffset_2;

		// Token: 0x04012625 RID: 75301
		internal static int __PropertyOffset_3;

		// Token: 0x04012626 RID: 75302
		internal static int __PropertyOffset_4;

		// Token: 0x04012627 RID: 75303
		internal static int __PropertyOffset_5;

		// Token: 0x04012628 RID: 75304
		internal static int __PropertyOffset_6;

		// Token: 0x04012629 RID: 75305
		internal static int __PropertyOffset_7;

		// Token: 0x0401262A RID: 75306
		internal static int __PropertyOffset_8;

		// Token: 0x0401262B RID: 75307
		internal static int __PropertyOffset_9;

		// Token: 0x0401262C RID: 75308
		internal static int __PropertyOffset_10;

		// Token: 0x0401262D RID: 75309
		internal static int __PropertyOffset_11;

		// Token: 0x0401262E RID: 75310
		internal static int __PropertyOffset_12;

		// Token: 0x0401262F RID: 75311
		internal static int __PropertyOffset_13;

		// Token: 0x04012630 RID: 75312
		internal static int __PropertyOffset_14;

		// Token: 0x04012631 RID: 75313
		internal static int __PropertyOffset_15;

		// Token: 0x04012632 RID: 75314
		internal static int __PropertyOffset_16;

		// Token: 0x04012633 RID: 75315
		internal static int __PropertyOffset_17;

		// Token: 0x04012634 RID: 75316
		internal static int __PropertyOffset_18;

		// Token: 0x04012635 RID: 75317
		internal static int __PropertyOffset_19;

		// Token: 0x04012636 RID: 75318
		internal static int __PropertyOffset_20;

		// Token: 0x04012637 RID: 75319
		internal static int __PropertyOffset_21;

		// Token: 0x04012638 RID: 75320
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012639 RID: 75321
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040A9 RID: 16553
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_FlashLightConfig.BP_FlashLightConfig_C")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 252)]
	public class BP_FlashLightConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AB92 RID: 174994 RVA: 0x009E9FB0 File Offset: 0x009E81B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FlashLightConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_FlashLightConfig.BP_FlashLightConfig_C");
			}
			return BP_FlashLightConfig_C._ClassPtr;
		}

		// Token: 0x0602AB93 RID: 174995 RVA: 0x009E9FD4 File Offset: 0x009E81D4
		public BP_FlashLightConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FlashLightConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AB94 RID: 174996 RVA: 0x009E9FFC File Offset: 0x009E81FC
		[NullableContext(1)]
		public BP_FlashLightConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FlashLightConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700691A RID: 26906
		// (get) Token: 0x0602AB95 RID: 174997 RVA: 0x009EA02F File Offset: 0x009E822F
		// (set) Token: 0x0602AB96 RID: 174998 RVA: 0x009EA043 File Offset: 0x009E8243
		public unsafe FTransform RelativeTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700691B RID: 26907
		// (get) Token: 0x0602AB97 RID: 174999 RVA: 0x009EA058 File Offset: 0x009E8258
		// (set) Token: 0x0602AB98 RID: 175000 RVA: 0x009EA068 File Offset: 0x009E8268
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700691C RID: 26908
		// (get) Token: 0x0602AB99 RID: 175001 RVA: 0x009EA079 File Offset: 0x009E8279
		// (set) Token: 0x0602AB9A RID: 175002 RVA: 0x009EA089 File Offset: 0x009E8289
		public unsafe float AttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700691D RID: 26909
		// (get) Token: 0x0602AB9B RID: 175003 RVA: 0x009EA09A File Offset: 0x009E829A
		// (set) Token: 0x0602AB9C RID: 175004 RVA: 0x009EA0AA File Offset: 0x009E82AA
		public unsafe float InnerConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700691E RID: 26910
		// (get) Token: 0x0602AB9D RID: 175005 RVA: 0x009EA0BB File Offset: 0x009E82BB
		// (set) Token: 0x0602AB9E RID: 175006 RVA: 0x009EA0CB File Offset: 0x009E82CB
		public unsafe float OuterConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700691F RID: 26911
		// (get) Token: 0x0602AB9F RID: 175007 RVA: 0x009EA0DC File Offset: 0x009E82DC
		// (set) Token: 0x0602ABA0 RID: 175008 RVA: 0x009EA0EC File Offset: 0x009E82EC
		public unsafe float SpecularScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006920 RID: 26912
		// (get) Token: 0x0602ABA1 RID: 175009 RVA: 0x009EA0FD File Offset: 0x009E82FD
		// (set) Token: 0x0602ABA2 RID: 175010 RVA: 0x009EA111 File Offset: 0x009E8311
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006921 RID: 26913
		// (get) Token: 0x0602ABA3 RID: 175011 RVA: 0x009EA126 File Offset: 0x009E8326
		// (set) Token: 0x0602ABA4 RID: 175012 RVA: 0x009EA136 File Offset: 0x009E8336
		public unsafe bool UseCameraPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006922 RID: 26914
		// (get) Token: 0x0602ABA5 RID: 175013 RVA: 0x009EA147 File Offset: 0x009E8347
		// (set) Token: 0x0602ABA6 RID: 175014 RVA: 0x009EA157 File Offset: 0x009E8357
		public unsafe bool UsePitchLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006923 RID: 26915
		// (get) Token: 0x0602ABA7 RID: 175015 RVA: 0x009EA168 File Offset: 0x009E8368
		// (set) Token: 0x0602ABA8 RID: 175016 RVA: 0x009EA178 File Offset: 0x009E8378
		public unsafe float MinTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006924 RID: 26916
		// (get) Token: 0x0602ABA9 RID: 175017 RVA: 0x009EA189 File Offset: 0x009E8389
		// (set) Token: 0x0602ABAA RID: 175018 RVA: 0x009EA199 File Offset: 0x009E8399
		public unsafe float MaxTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006925 RID: 26917
		// (get) Token: 0x0602ABAB RID: 175019 RVA: 0x009EA1AA File Offset: 0x009E83AA
		// (set) Token: 0x0602ABAC RID: 175020 RVA: 0x009EA1BA File Offset: 0x009E83BA
		public unsafe float LerpBeginDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006926 RID: 26918
		// (get) Token: 0x0602ABAD RID: 175021 RVA: 0x009EA1CB File Offset: 0x009E83CB
		// (set) Token: 0x0602ABAE RID: 175022 RVA: 0x009EA1DB File Offset: 0x009E83DB
		public unsafe float LerpPow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006927 RID: 26919
		// (get) Token: 0x0602ABAF RID: 175023 RVA: 0x009EA1EC File Offset: 0x009E83EC
		// (set) Token: 0x0602ABB0 RID: 175024 RVA: 0x009EA200 File Offset: 0x009E8400
		public unsafe UCurveFloat LerpCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlashLightConfig_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlashLightConfig_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006928 RID: 26920
		// (get) Token: 0x0602ABB1 RID: 175025 RVA: 0x009EA215 File Offset: 0x009E8415
		// (set) Token: 0x0602ABB2 RID: 175026 RVA: 0x009EA225 File Offset: 0x009E8425
		public unsafe float ToonIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006929 RID: 26921
		// (get) Token: 0x0602ABB3 RID: 175027 RVA: 0x009EA236 File Offset: 0x009E8436
		// (set) Token: 0x0602ABB4 RID: 175028 RVA: 0x009EA246 File Offset: 0x009E8446
		public unsafe float ToonShadowColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700692A RID: 26922
		// (get) Token: 0x0602ABB5 RID: 175029 RVA: 0x009EA257 File Offset: 0x009E8457
		// (set) Token: 0x0602ABB6 RID: 175030 RVA: 0x009EA267 File Offset: 0x009E8467
		public unsafe float ToonRealTimeShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700692B RID: 26923
		// (get) Token: 0x0602ABB7 RID: 175031 RVA: 0x009EA278 File Offset: 0x009E8478
		// (set) Token: 0x0602ABB8 RID: 175032 RVA: 0x009EA28C File Offset: 0x009E848C
		public unsafe FLinearColor LightToonColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700692C RID: 26924
		// (get) Token: 0x0602ABB9 RID: 175033 RVA: 0x009EA2A1 File Offset: 0x009E84A1
		// (set) Token: 0x0602ABBA RID: 175034 RVA: 0x009EA2B1 File Offset: 0x009E84B1
		public unsafe float ToonPointLightFallOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700692D RID: 26925
		// (get) Token: 0x0602ABBB RID: 175035 RVA: 0x009EA2C2 File Offset: 0x009E84C2
		// (set) Token: 0x0602ABBC RID: 175036 RVA: 0x009EA2D2 File Offset: 0x009E84D2
		public unsafe float ToonDistanceBlendIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700692E RID: 26926
		// (get) Token: 0x0602ABBD RID: 175037 RVA: 0x009EA2E3 File Offset: 0x009E84E3
		// (set) Token: 0x0602ABBE RID: 175038 RVA: 0x009EA2F3 File Offset: 0x009E84F3
		public unsafe int ToonLightingPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700692F RID: 26927
		// (get) Token: 0x0602ABBF RID: 175039 RVA: 0x009EA304 File Offset: 0x009E8504
		// (set) Token: 0x0602ABC0 RID: 175040 RVA: 0x009EA314 File Offset: 0x009E8514
		public unsafe float LightFalloffExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006930 RID: 26928
		// (get) Token: 0x0602ABC1 RID: 175041 RVA: 0x009EA325 File Offset: 0x009E8525
		// (set) Token: 0x0602ABC2 RID: 175042 RVA: 0x009EA339 File Offset: 0x009E8539
		public unsafe UTextureLightProfile IESTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureLightProfile>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlashLightConfig_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlashLightConfig_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17006931 RID: 26929
		// (get) Token: 0x0602ABC3 RID: 175043 RVA: 0x009EA34E File Offset: 0x009E854E
		// (set) Token: 0x0602ABC4 RID: 175044 RVA: 0x009EA35E File Offset: 0x009E855E
		public unsafe float VolumetricScatteringIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x0602ABC5 RID: 175045 RVA: 0x009EA36F File Offset: 0x009E856F
		protected BP_FlashLightConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040161C9 RID: 90569
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_FlashLightConfig.BP_FlashLightConfig_C";

		// Token: 0x040161CA RID: 90570
		private static IntPtr _ClassPtr;

		// Token: 0x040161CB RID: 90571
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040161CC RID: 90572
		internal static int __PropertyOffset_0;

		// Token: 0x040161CD RID: 90573
		internal static int __PropertyOffset_1;

		// Token: 0x040161CE RID: 90574
		internal static int __PropertyOffset_2;

		// Token: 0x040161CF RID: 90575
		internal static int __PropertyOffset_3;

		// Token: 0x040161D0 RID: 90576
		internal static int __PropertyOffset_4;

		// Token: 0x040161D1 RID: 90577
		internal static int __PropertyOffset_5;

		// Token: 0x040161D2 RID: 90578
		internal static int __PropertyOffset_6;

		// Token: 0x040161D3 RID: 90579
		internal static int __PropertyOffset_7;

		// Token: 0x040161D4 RID: 90580
		internal static int __PropertyOffset_8;

		// Token: 0x040161D5 RID: 90581
		internal static int __PropertyOffset_9;

		// Token: 0x040161D6 RID: 90582
		internal static int __PropertyOffset_10;

		// Token: 0x040161D7 RID: 90583
		internal static int __PropertyOffset_11;

		// Token: 0x040161D8 RID: 90584
		internal static int __PropertyOffset_12;

		// Token: 0x040161D9 RID: 90585
		internal static int __PropertyOffset_13;

		// Token: 0x040161DA RID: 90586
		internal static int __PropertyOffset_14;

		// Token: 0x040161DB RID: 90587
		internal static int __PropertyOffset_15;

		// Token: 0x040161DC RID: 90588
		internal static int __PropertyOffset_16;

		// Token: 0x040161DD RID: 90589
		internal static int __PropertyOffset_17;

		// Token: 0x040161DE RID: 90590
		internal static int __PropertyOffset_18;

		// Token: 0x040161DF RID: 90591
		internal static int __PropertyOffset_19;

		// Token: 0x040161E0 RID: 90592
		internal static int __PropertyOffset_20;

		// Token: 0x040161E1 RID: 90593
		internal static int __PropertyOffset_21;

		// Token: 0x040161E2 RID: 90594
		internal static int __PropertyOffset_22;

		// Token: 0x040161E3 RID: 90595
		internal static int __PropertyOffset_23;
	}
}

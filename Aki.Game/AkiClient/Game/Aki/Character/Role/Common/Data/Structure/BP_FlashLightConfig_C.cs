using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020032A0 RID: 12960
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_FlashLightConfig.BP_FlashLightConfig_C")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 252)]
	public class BP_FlashLightConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602090F RID: 133391 RVA: 0x00949F80 File Offset: 0x00948180
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FlashLightConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_FlashLightConfig.BP_FlashLightConfig_C");
			}
			return BP_FlashLightConfig_C._ClassPtr;
		}

		// Token: 0x06020910 RID: 133392 RVA: 0x00949FA4 File Offset: 0x009481A4
		public BP_FlashLightConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FlashLightConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020911 RID: 133393 RVA: 0x00949FCC File Offset: 0x009481CC
		[NullableContext(1)]
		public BP_FlashLightConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FlashLightConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x06020912 RID: 133394 RVA: 0x00949FFF File Offset: 0x009481FF
		// (set) Token: 0x06020913 RID: 133395 RVA: 0x0094A013 File Offset: 0x00948213
		public unsafe FTransform RelativeTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_RelativeTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_RelativeTrans) = value;
			}
		}

		// Token: 0x17003FBE RID: 16318
		// (get) Token: 0x06020914 RID: 133396 RVA: 0x0094A028 File Offset: 0x00948228
		// (set) Token: 0x06020915 RID: 133397 RVA: 0x0094A038 File Offset: 0x00948238
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x06020916 RID: 133398 RVA: 0x0094A049 File Offset: 0x00948249
		// (set) Token: 0x06020917 RID: 133399 RVA: 0x0094A059 File Offset: 0x00948259
		public unsafe float AttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_AttenuationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_AttenuationRadius) = value;
			}
		}

		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x06020918 RID: 133400 RVA: 0x0094A06A File Offset: 0x0094826A
		// (set) Token: 0x06020919 RID: 133401 RVA: 0x0094A07A File Offset: 0x0094827A
		public unsafe float InnerConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_InnerConeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_InnerConeAngle) = value;
			}
		}

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x0602091A RID: 133402 RVA: 0x0094A08B File Offset: 0x0094828B
		// (set) Token: 0x0602091B RID: 133403 RVA: 0x0094A09B File Offset: 0x0094829B
		public unsafe float OuterConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_OuterConeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_OuterConeAngle) = value;
			}
		}

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x0602091C RID: 133404 RVA: 0x0094A0AC File Offset: 0x009482AC
		// (set) Token: 0x0602091D RID: 133405 RVA: 0x0094A0BC File Offset: 0x009482BC
		public unsafe float SpecularScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_SpecularScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_SpecularScale) = value;
			}
		}

		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x0602091E RID: 133406 RVA: 0x0094A0CD File Offset: 0x009482CD
		// (set) Token: 0x0602091F RID: 133407 RVA: 0x0094A0E1 File Offset: 0x009482E1
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LightColor) = value;
			}
		}

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x06020920 RID: 133408 RVA: 0x0094A0F6 File Offset: 0x009482F6
		// (set) Token: 0x06020921 RID: 133409 RVA: 0x0094A106 File Offset: 0x00948306
		public unsafe bool UseCameraPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_UseCameraPitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_UseCameraPitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x06020922 RID: 133410 RVA: 0x0094A117 File Offset: 0x00948317
		// (set) Token: 0x06020923 RID: 133411 RVA: 0x0094A127 File Offset: 0x00948327
		public unsafe bool UsePitchLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_UsePitchLerp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_UsePitchLerp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x06020924 RID: 133412 RVA: 0x0094A138 File Offset: 0x00948338
		// (set) Token: 0x06020925 RID: 133413 RVA: 0x0094A148 File Offset: 0x00948348
		public unsafe float MinTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_MinTurnSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_MinTurnSpeed) = value;
			}
		}

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x06020926 RID: 133414 RVA: 0x0094A159 File Offset: 0x00948359
		// (set) Token: 0x06020927 RID: 133415 RVA: 0x0094A169 File Offset: 0x00948369
		public unsafe float MaxTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_MaxTurnSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_MaxTurnSpeed) = value;
			}
		}

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x06020928 RID: 133416 RVA: 0x0094A17A File Offset: 0x0094837A
		// (set) Token: 0x06020929 RID: 133417 RVA: 0x0094A18A File Offset: 0x0094838A
		public unsafe float LerpBeginDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LerpBeginDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LerpBeginDeg) = value;
			}
		}

		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x0602092A RID: 133418 RVA: 0x0094A19B File Offset: 0x0094839B
		// (set) Token: 0x0602092B RID: 133419 RVA: 0x0094A1AB File Offset: 0x009483AB
		public unsafe float LerpPow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LerpPow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LerpPow) = value;
			}
		}

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x0602092C RID: 133420 RVA: 0x0094A1BC File Offset: 0x009483BC
		// (set) Token: 0x0602092D RID: 133421 RVA: 0x0094A1D0 File Offset: 0x009483D0
		public unsafe UCurveFloat LerpCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlashLightConfig_C.__PropertyOffset_LerpCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlashLightConfig_C.__PropertyOffset_LerpCurve, value);
			}
		}

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x0602092E RID: 133422 RVA: 0x0094A1E5 File Offset: 0x009483E5
		// (set) Token: 0x0602092F RID: 133423 RVA: 0x0094A1F5 File Offset: 0x009483F5
		public unsafe float ToonIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonIntensity) = value;
			}
		}

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x06020930 RID: 133424 RVA: 0x0094A206 File Offset: 0x00948406
		// (set) Token: 0x06020931 RID: 133425 RVA: 0x0094A216 File Offset: 0x00948416
		public unsafe float ToonShadowColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonShadowColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonShadowColorIntensity) = value;
			}
		}

		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x06020932 RID: 133426 RVA: 0x0094A227 File Offset: 0x00948427
		// (set) Token: 0x06020933 RID: 133427 RVA: 0x0094A237 File Offset: 0x00948437
		public unsafe float ToonRealTimeShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonRealTimeShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonRealTimeShadowIntensity) = value;
			}
		}

		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x06020934 RID: 133428 RVA: 0x0094A248 File Offset: 0x00948448
		// (set) Token: 0x06020935 RID: 133429 RVA: 0x0094A25C File Offset: 0x0094845C
		public unsafe FLinearColor LightToonColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LightToonColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LightToonColor) = value;
			}
		}

		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x06020936 RID: 133430 RVA: 0x0094A271 File Offset: 0x00948471
		// (set) Token: 0x06020937 RID: 133431 RVA: 0x0094A281 File Offset: 0x00948481
		public unsafe float ToonPointLightFallOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonPointLightFallOff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonPointLightFallOff) = value;
			}
		}

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x06020938 RID: 133432 RVA: 0x0094A292 File Offset: 0x00948492
		// (set) Token: 0x06020939 RID: 133433 RVA: 0x0094A2A2 File Offset: 0x009484A2
		public unsafe float ToonDistanceBlendIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonDistanceBlendIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonDistanceBlendIntensity) = value;
			}
		}

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x0602093A RID: 133434 RVA: 0x0094A2B3 File Offset: 0x009484B3
		// (set) Token: 0x0602093B RID: 133435 RVA: 0x0094A2C3 File Offset: 0x009484C3
		public unsafe int ToonLightingPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonLightingPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_ToonLightingPriority) = value;
			}
		}

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x0602093C RID: 133436 RVA: 0x0094A2D4 File Offset: 0x009484D4
		// (set) Token: 0x0602093D RID: 133437 RVA: 0x0094A2E4 File Offset: 0x009484E4
		public unsafe float LightFalloffExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LightFalloffExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_LightFalloffExponent) = value;
			}
		}

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x0602093E RID: 133438 RVA: 0x0094A2F5 File Offset: 0x009484F5
		// (set) Token: 0x0602093F RID: 133439 RVA: 0x0094A309 File Offset: 0x00948509
		public unsafe UTextureLightProfile IESTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureLightProfile>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlashLightConfig_C.__PropertyOffset_IESTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlashLightConfig_C.__PropertyOffset_IESTexture, value);
			}
		}

		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x06020940 RID: 133440 RVA: 0x0094A31E File Offset: 0x0094851E
		// (set) Token: 0x06020941 RID: 133441 RVA: 0x0094A32E File Offset: 0x0094852E
		public unsafe float VolumetricScatteringIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_VolumetricScatteringIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlashLightConfig_C.__PropertyOffset_VolumetricScatteringIntensity) = value;
			}
		}

		// Token: 0x06020942 RID: 133442 RVA: 0x0094A33F File Offset: 0x0094853F
		protected BP_FlashLightConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119A7 RID: 72103
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_FlashLightConfig.BP_FlashLightConfig_C";

		// Token: 0x040119A8 RID: 72104
		private static IntPtr _ClassPtr;

		// Token: 0x040119A9 RID: 72105
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119AA RID: 72106
		internal static int __PropertyOffset_RelativeTrans;

		// Token: 0x040119AB RID: 72107
		internal static int __PropertyOffset_Intensity;

		// Token: 0x040119AC RID: 72108
		internal static int __PropertyOffset_AttenuationRadius;

		// Token: 0x040119AD RID: 72109
		internal static int __PropertyOffset_InnerConeAngle;

		// Token: 0x040119AE RID: 72110
		internal static int __PropertyOffset_OuterConeAngle;

		// Token: 0x040119AF RID: 72111
		internal static int __PropertyOffset_SpecularScale;

		// Token: 0x040119B0 RID: 72112
		internal static int __PropertyOffset_LightColor;

		// Token: 0x040119B1 RID: 72113
		internal static int __PropertyOffset_UseCameraPitch;

		// Token: 0x040119B2 RID: 72114
		internal static int __PropertyOffset_UsePitchLerp;

		// Token: 0x040119B3 RID: 72115
		internal static int __PropertyOffset_MinTurnSpeed;

		// Token: 0x040119B4 RID: 72116
		internal static int __PropertyOffset_MaxTurnSpeed;

		// Token: 0x040119B5 RID: 72117
		internal static int __PropertyOffset_LerpBeginDeg;

		// Token: 0x040119B6 RID: 72118
		internal static int __PropertyOffset_LerpPow;

		// Token: 0x040119B7 RID: 72119
		internal static int __PropertyOffset_LerpCurve;

		// Token: 0x040119B8 RID: 72120
		internal static int __PropertyOffset_ToonIntensity;

		// Token: 0x040119B9 RID: 72121
		internal static int __PropertyOffset_ToonShadowColorIntensity;

		// Token: 0x040119BA RID: 72122
		internal static int __PropertyOffset_ToonRealTimeShadowIntensity;

		// Token: 0x040119BB RID: 72123
		internal static int __PropertyOffset_LightToonColor;

		// Token: 0x040119BC RID: 72124
		internal static int __PropertyOffset_ToonPointLightFallOff;

		// Token: 0x040119BD RID: 72125
		internal static int __PropertyOffset_ToonDistanceBlendIntensity;

		// Token: 0x040119BE RID: 72126
		internal static int __PropertyOffset_ToonLightingPriority;

		// Token: 0x040119BF RID: 72127
		internal static int __PropertyOffset_LightFalloffExponent;

		// Token: 0x040119C0 RID: 72128
		internal static int __PropertyOffset_IESTexture;

		// Token: 0x040119C1 RID: 72129
		internal static int __PropertyOffset_VolumetricScatteringIntensity;
	}
}

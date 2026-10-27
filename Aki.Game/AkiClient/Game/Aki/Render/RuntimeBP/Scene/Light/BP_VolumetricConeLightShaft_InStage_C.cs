using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B23 RID: 15139
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaft_InStage.BP_VolumetricConeLightShaft_InStage_C")]
	[UnrealStructLayout(2880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2880)]
	public class BP_VolumetricConeLightShaft_InStage_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602147A RID: 136314 RVA: 0x008E8CE9 File Offset: 0x008E6EE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaft_InStage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaft_InStage.BP_VolumetricConeLightShaft_InStage_C");
			}
			return BP_VolumetricConeLightShaft_InStage_C._ClassPtr;
		}

		// Token: 0x0602147B RID: 136315 RVA: 0x008E8D0D File Offset: 0x008E6F0D
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_VolumetricConeLightShaft_InStage_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x0602147C RID: 136316 RVA: 0x008E8D14 File Offset: 0x008E6F14
		public BP_VolumetricConeLightShaft_InStage_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InStage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602147D RID: 136317 RVA: 0x008E8D3C File Offset: 0x008E6F3C
		[NullableContext(1)]
		public BP_VolumetricConeLightShaft_InStage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InStage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0602147E RID: 136318 RVA: 0x008E8D6F File Offset: 0x008E6F6F
		// (set) Token: 0x0602147F RID: 136319 RVA: 0x008E8D83 File Offset: 0x008E6F83
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x06021480 RID: 136320 RVA: 0x008E8D98 File Offset: 0x008E6F98
		// (set) Token: 0x06021481 RID: 136321 RVA: 0x008E8DAC File Offset: 0x008E6FAC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x06021482 RID: 136322 RVA: 0x008E8DC1 File Offset: 0x008E6FC1
		// (set) Token: 0x06021483 RID: 136323 RVA: 0x008E8DD5 File Offset: 0x008E6FD5
		public unsafe UStaticMesh StaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x06021484 RID: 136324 RVA: 0x008E8DEA File Offset: 0x008E6FEA
		// (set) Token: 0x06021485 RID: 136325 RVA: 0x008E8DFE File Offset: 0x008E6FFE
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x06021486 RID: 136326 RVA: 0x008E8E13 File Offset: 0x008E7013
		// (set) Token: 0x06021487 RID: 136327 RVA: 0x008E8E27 File Offset: 0x008E7027
		public unsafe UMaterialInstance MaterialInstanceB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x06021488 RID: 136328 RVA: 0x008E8E3C File Offset: 0x008E703C
		// (set) Token: 0x06021489 RID: 136329 RVA: 0x008E8E50 File Offset: 0x008E7050
		public unsafe FVector VolumetriConeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0602148A RID: 136330 RVA: 0x008E8E65 File Offset: 0x008E7065
		// (set) Token: 0x0602148B RID: 136331 RVA: 0x008E8E75 File Offset: 0x008E7075
		public unsafe bool EnableBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0602148C RID: 136332 RVA: 0x008E8E86 File Offset: 0x008E7086
		// (set) Token: 0x0602148D RID: 136333 RVA: 0x008E8E96 File Offset: 0x008E7096
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0602148E RID: 136334 RVA: 0x008E8EA7 File Offset: 0x008E70A7
		// (set) Token: 0x0602148F RID: 136335 RVA: 0x008E8EB7 File Offset: 0x008E70B7
		public unsafe bool EnableFlickent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x06021490 RID: 136336 RVA: 0x008E8EC8 File Offset: 0x008E70C8
		// (set) Token: 0x06021491 RID: 136337 RVA: 0x008E8ED8 File Offset: 0x008E70D8
		public unsafe float ConeSin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x06021492 RID: 136338 RVA: 0x008E8EE9 File Offset: 0x008E70E9
		// (set) Token: 0x06021493 RID: 136339 RVA: 0x008E8EF9 File Offset: 0x008E70F9
		public unsafe float RadFallOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x06021494 RID: 136340 RVA: 0x008E8F0A File Offset: 0x008E710A
		// (set) Token: 0x06021495 RID: 136341 RVA: 0x008E8F1A File Offset: 0x008E711A
		public unsafe float TopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x06021496 RID: 136342 RVA: 0x008E8F2B File Offset: 0x008E712B
		// (set) Token: 0x06021497 RID: 136343 RVA: 0x008E8F3B File Offset: 0x008E713B
		public unsafe float TopColorLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x06021498 RID: 136344 RVA: 0x008E8F4C File Offset: 0x008E714C
		// (set) Token: 0x06021499 RID: 136345 RVA: 0x008E8F60 File Offset: 0x008E7160
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0602149A RID: 136346 RVA: 0x008E8F75 File Offset: 0x008E7175
		// (set) Token: 0x0602149B RID: 136347 RVA: 0x008E8F89 File Offset: 0x008E7189
		public unsafe FLinearColor BottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0602149C RID: 136348 RVA: 0x008E8F9E File Offset: 0x008E719E
		// (set) Token: 0x0602149D RID: 136349 RVA: 0x008E8FAE File Offset: 0x008E71AE
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0602149E RID: 136350 RVA: 0x008E8FBF File Offset: 0x008E71BF
		// (set) Token: 0x0602149F RID: 136351 RVA: 0x008E8FCF File Offset: 0x008E71CF
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x060214A0 RID: 136352 RVA: 0x008E8FE0 File Offset: 0x008E71E0
		// (set) Token: 0x060214A1 RID: 136353 RVA: 0x008E8FF0 File Offset: 0x008E71F0
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x060214A2 RID: 136354 RVA: 0x008E9001 File Offset: 0x008E7201
		// (set) Token: 0x060214A3 RID: 136355 RVA: 0x008E9011 File Offset: 0x008E7211
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x060214A4 RID: 136356 RVA: 0x008E9022 File Offset: 0x008E7222
		// (set) Token: 0x060214A5 RID: 136357 RVA: 0x008E9032 File Offset: 0x008E7232
		public unsafe float DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x060214A6 RID: 136358 RVA: 0x008E9043 File Offset: 0x008E7243
		// (set) Token: 0x060214A7 RID: 136359 RVA: 0x008E9053 File Offset: 0x008E7253
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x060214A8 RID: 136360 RVA: 0x008E9064 File Offset: 0x008E7264
		// (set) Token: 0x060214A9 RID: 136361 RVA: 0x008E9078 File Offset: 0x008E7278
		public unsafe FVector LightShaftScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x060214AA RID: 136362 RVA: 0x008E908D File Offset: 0x008E728D
		// (set) Token: 0x060214AB RID: 136363 RVA: 0x008E90A1 File Offset: 0x008E72A1
		public unsafe UStaticMesh LightShaftStaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x060214AC RID: 136364 RVA: 0x008E90B6 File Offset: 0x008E72B6
		// (set) Token: 0x060214AD RID: 136365 RVA: 0x008E90CA File Offset: 0x008E72CA
		public unsafe UMaterialInstance LightShaftCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x060214AE RID: 136366 RVA: 0x008E90DF File Offset: 0x008E72DF
		// (set) Token: 0x060214AF RID: 136367 RVA: 0x008E90F3 File Offset: 0x008E72F3
		public unsafe UTexture2D Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x060214B0 RID: 136368 RVA: 0x008E9108 File Offset: 0x008E7308
		// (set) Token: 0x060214B1 RID: 136369 RVA: 0x008E911C File Offset: 0x008E731C
		public unsafe FLinearColor FallOff_ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x060214B2 RID: 136370 RVA: 0x008E9131 File Offset: 0x008E7331
		// (set) Token: 0x060214B3 RID: 136371 RVA: 0x008E9141 File Offset: 0x008E7341
		public unsafe float FallOff_DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x060214B4 RID: 136372 RVA: 0x008E9152 File Offset: 0x008E7352
		// (set) Token: 0x060214B5 RID: 136373 RVA: 0x008E9162 File Offset: 0x008E7362
		public unsafe float ScreenFadeFrom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x060214B6 RID: 136374 RVA: 0x008E9173 File Offset: 0x008E7373
		// (set) Token: 0x060214B7 RID: 136375 RVA: 0x008E9183 File Offset: 0x008E7383
		public unsafe float Opacity_CenterPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x060214B8 RID: 136376 RVA: 0x008E9194 File Offset: 0x008E7394
		// (set) Token: 0x060214B9 RID: 136377 RVA: 0x008E91A4 File Offset: 0x008E73A4
		public unsafe float ScreenFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x060214BA RID: 136378 RVA: 0x008E91B5 File Offset: 0x008E73B5
		// (set) Token: 0x060214BB RID: 136379 RVA: 0x008E91C5 File Offset: 0x008E73C5
		public unsafe float ShaftTopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x060214BC RID: 136380 RVA: 0x008E91D6 File Offset: 0x008E73D6
		// (set) Token: 0x060214BD RID: 136381 RVA: 0x008E91EA File Offset: 0x008E73EA
		public unsafe FLinearColor UVScaleAndAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x060214BE RID: 136382 RVA: 0x008E91FF File Offset: 0x008E73FF
		// (set) Token: 0x060214BF RID: 136383 RVA: 0x008E9213 File Offset: 0x008E7413
		public unsafe UStaticMesh LightMaskStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x060214C0 RID: 136384 RVA: 0x008E9228 File Offset: 0x008E7428
		// (set) Token: 0x060214C1 RID: 136385 RVA: 0x008E9238 File Offset: 0x008E7438
		public unsafe float LightMaskZaxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x060214C2 RID: 136386 RVA: 0x008E9249 File Offset: 0x008E7449
		// (set) Token: 0x060214C3 RID: 136387 RVA: 0x008E925D File Offset: 0x008E745D
		public unsafe UMaterialInstance LightMaskMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x060214C4 RID: 136388 RVA: 0x008E9272 File Offset: 0x008E7472
		// (set) Token: 0x060214C5 RID: 136389 RVA: 0x008E9286 File Offset: 0x008E7486
		public unsafe FVector LightMaskScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x060214C6 RID: 136390 RVA: 0x008E929B File Offset: 0x008E749B
		// (set) Token: 0x060214C7 RID: 136391 RVA: 0x008E92AF File Offset: 0x008E74AF
		public unsafe FLinearColor LightMaskColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x060214C8 RID: 136392 RVA: 0x008E92C4 File Offset: 0x008E74C4
		// (set) Token: 0x060214C9 RID: 136393 RVA: 0x008E92D8 File Offset: 0x008E74D8
		public unsafe UTexture2D LightMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x060214CA RID: 136394 RVA: 0x008E92ED File Offset: 0x008E74ED
		// (set) Token: 0x060214CB RID: 136395 RVA: 0x008E92FD File Offset: 0x008E74FD
		public unsafe float ColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x060214CC RID: 136396 RVA: 0x008E930E File Offset: 0x008E750E
		// (set) Token: 0x060214CD RID: 136397 RVA: 0x008E931E File Offset: 0x008E751E
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x060214CE RID: 136398 RVA: 0x008E932F File Offset: 0x008E752F
		// (set) Token: 0x060214CF RID: 136399 RVA: 0x008E933F File Offset: 0x008E753F
		public unsafe float FadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x060214D0 RID: 136400 RVA: 0x008E9350 File Offset: 0x008E7550
		// (set) Token: 0x060214D1 RID: 136401 RVA: 0x008E9360 File Offset: 0x008E7560
		public unsafe float FlankInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x060214D2 RID: 136402 RVA: 0x008E9371 File Offset: 0x008E7571
		// (set) Token: 0x060214D3 RID: 136403 RVA: 0x008E9381 File Offset: 0x008E7581
		public unsafe float Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x060214D4 RID: 136404 RVA: 0x008E9392 File Offset: 0x008E7592
		// (set) Token: 0x060214D5 RID: 136405 RVA: 0x008E93A2 File Offset: 0x008E75A2
		public unsafe float RightSideInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x060214D6 RID: 136406 RVA: 0x008E93B3 File Offset: 0x008E75B3
		// (set) Token: 0x060214D7 RID: 136407 RVA: 0x008E93C7 File Offset: 0x008E75C7
		public unsafe FVector CenterLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x060214D8 RID: 136408 RVA: 0x008E93DC File Offset: 0x008E75DC
		// (set) Token: 0x060214D9 RID: 136409 RVA: 0x008E93F0 File Offset: 0x008E75F0
		public unsafe UTexture MainNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x060214DA RID: 136410 RVA: 0x008E9405 File Offset: 0x008E7605
		// (set) Token: 0x060214DB RID: 136411 RVA: 0x008E9419 File Offset: 0x008E7619
		public unsafe UTexture SecondNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x060214DC RID: 136412 RVA: 0x008E942E File Offset: 0x008E762E
		// (set) Token: 0x060214DD RID: 136413 RVA: 0x008E9442 File Offset: 0x008E7642
		public unsafe FLinearColor MainNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x060214DE RID: 136414 RVA: 0x008E9457 File Offset: 0x008E7657
		// (set) Token: 0x060214DF RID: 136415 RVA: 0x008E946B File Offset: 0x008E766B
		public unsafe FLinearColor SecondNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x060214E0 RID: 136416 RVA: 0x008E9480 File Offset: 0x008E7680
		// (set) Token: 0x060214E1 RID: 136417 RVA: 0x008E9490 File Offset: 0x008E7690
		public unsafe float MainUVAddStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x060214E2 RID: 136418 RVA: 0x008E94A1 File Offset: 0x008E76A1
		// (set) Token: 0x060214E3 RID: 136419 RVA: 0x008E94B5 File Offset: 0x008E76B5
		public unsafe FLinearColor MainNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x060214E4 RID: 136420 RVA: 0x008E94CA File Offset: 0x008E76CA
		// (set) Token: 0x060214E5 RID: 136421 RVA: 0x008E94DE File Offset: 0x008E76DE
		public unsafe FLinearColor SecondNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x060214E6 RID: 136422 RVA: 0x008E94F4 File Offset: 0x008E76F4
		// (set) Token: 0x060214E7 RID: 136423 RVA: 0x008E952D File Offset: 0x008E772D
		[Nullable(1)]
		public TMap<FName, float> MaterialInstanceB_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._MaterialInstanceB_Scalars) == null)
				{
					result = (this._MaterialInstanceB_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_53, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceB_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x060214E8 RID: 136424 RVA: 0x008E953C File Offset: 0x008E773C
		// (set) Token: 0x060214E9 RID: 136425 RVA: 0x008E9575 File Offset: 0x008E7775
		[Nullable(1)]
		public TMap<FName, FLinearColor> MaterialInstanceB_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._MaterialInstanceB_Vectors) == null)
				{
					result = (this._MaterialInstanceB_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_54, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceB_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x060214EA RID: 136426 RVA: 0x008E9584 File Offset: 0x008E7784
		// (set) Token: 0x060214EB RID: 136427 RVA: 0x008E95BD File Offset: 0x008E77BD
		[Nullable(1)]
		public TMap<FName, UTexture> MaterialInstanceB_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._MaterialInstanceB_Textures) == null)
				{
					result = (this._MaterialInstanceB_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_55, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceB_Textures.CopyAssign(value);
			}
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x060214EC RID: 136428 RVA: 0x008E95CC File Offset: 0x008E77CC
		// (set) Token: 0x060214ED RID: 136429 RVA: 0x008E9605 File Offset: 0x008E7805
		[Nullable(1)]
		public TMap<FName, float> MaterialInstance_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._MaterialInstance_Scalars) == null)
				{
					result = (this._MaterialInstance_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_56, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstance_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x060214EE RID: 136430 RVA: 0x008E9614 File Offset: 0x008E7814
		// (set) Token: 0x060214EF RID: 136431 RVA: 0x008E964D File Offset: 0x008E784D
		[Nullable(1)]
		public TMap<FName, FLinearColor> MaterialInstance_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._MaterialInstance_Vectors) == null)
				{
					result = (this._MaterialInstance_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_57, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstance_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x060214F0 RID: 136432 RVA: 0x008E965C File Offset: 0x008E785C
		// (set) Token: 0x060214F1 RID: 136433 RVA: 0x008E9695 File Offset: 0x008E7895
		[Nullable(1)]
		public TMap<FName, UTexture> MaterialInstance_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._MaterialInstance_Textures) == null)
				{
					result = (this._MaterialInstance_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_58, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstance_Textures.CopyAssign(value);
			}
		}

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x060214F2 RID: 136434 RVA: 0x008E96A4 File Offset: 0x008E78A4
		// (set) Token: 0x060214F3 RID: 136435 RVA: 0x008E96DD File Offset: 0x008E78DD
		[Nullable(1)]
		public TMap<FName, float> LightShaftCone_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._LightShaftCone_Scalars) == null)
				{
					result = (this._LightShaftCone_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_59, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x060214F4 RID: 136436 RVA: 0x008E96EC File Offset: 0x008E78EC
		// (set) Token: 0x060214F5 RID: 136437 RVA: 0x008E9725 File Offset: 0x008E7925
		[Nullable(1)]
		public TMap<FName, FLinearColor> LightShaftCone_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._LightShaftCone_Vectors) == null)
				{
					result = (this._LightShaftCone_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_60, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x060214F6 RID: 136438 RVA: 0x008E9734 File Offset: 0x008E7934
		// (set) Token: 0x060214F7 RID: 136439 RVA: 0x008E976D File Offset: 0x008E796D
		[Nullable(1)]
		public TMap<FName, UTexture> LightShaftCone_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._LightShaftCone_Textures) == null)
				{
					result = (this._LightShaftCone_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_61, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Textures.CopyAssign(value);
			}
		}

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x060214F8 RID: 136440 RVA: 0x008E977C File Offset: 0x008E797C
		// (set) Token: 0x060214F9 RID: 136441 RVA: 0x008E97B5 File Offset: 0x008E79B5
		[Nullable(1)]
		public TMap<FName, float> LightMaskMaterial_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._LightMaskMaterial_Scalars) == null)
				{
					result = (this._LightMaskMaterial_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_62, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightMaskMaterial_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x060214FA RID: 136442 RVA: 0x008E97C4 File Offset: 0x008E79C4
		// (set) Token: 0x060214FB RID: 136443 RVA: 0x008E97FD File Offset: 0x008E79FD
		[Nullable(1)]
		public TMap<FName, FLinearColor> LightMaskMaterial_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._LightMaskMaterial_Vectors) == null)
				{
					result = (this._LightMaskMaterial_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_63, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightMaskMaterial_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x060214FC RID: 136444 RVA: 0x008E980C File Offset: 0x008E7A0C
		// (set) Token: 0x060214FD RID: 136445 RVA: 0x008E9845 File Offset: 0x008E7A45
		[Nullable(1)]
		public TMap<FName, UTexture> LightMaskMaterial_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._LightMaskMaterial_Textures) == null)
				{
					result = (this._LightMaskMaterial_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_64, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightMaskMaterial_Textures.CopyAssign(value);
			}
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x060214FE RID: 136446 RVA: 0x008E9853 File Offset: 0x008E7A53
		// (set) Token: 0x060214FF RID: 136447 RVA: 0x008E9867 File Offset: 0x008E7A67
		public unsafe UMaterialInstanceDynamic MaterialInstanceBDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x06021500 RID: 136448 RVA: 0x008E987C File Offset: 0x008E7A7C
		// (set) Token: 0x06021501 RID: 136449 RVA: 0x008E9890 File Offset: 0x008E7A90
		public unsafe UMaterialInstanceDynamic MaterialInstanceDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_66);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_66, value);
			}
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x06021502 RID: 136450 RVA: 0x008E98A5 File Offset: 0x008E7AA5
		// (set) Token: 0x06021503 RID: 136451 RVA: 0x008E98B9 File Offset: 0x008E7AB9
		public unsafe UMaterialInstanceDynamic LightShaftConeDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_67);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_67, value);
			}
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x06021504 RID: 136452 RVA: 0x008E98CE File Offset: 0x008E7ACE
		// (set) Token: 0x06021505 RID: 136453 RVA: 0x008E98E2 File Offset: 0x008E7AE2
		public unsafe UMaterialInstanceDynamic LightMaskMaterialDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_68);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_68, value);
			}
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x06021506 RID: 136454 RVA: 0x008E98F7 File Offset: 0x008E7AF7
		// (set) Token: 0x06021507 RID: 136455 RVA: 0x008E9907 File Offset: 0x008E7B07
		public unsafe bool IsTickUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_69) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_69) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x06021508 RID: 136456 RVA: 0x008E9918 File Offset: 0x008E7B18
		// (set) Token: 0x06021509 RID: 136457 RVA: 0x008E9928 File Offset: 0x008E7B28
		public unsafe bool OptimizeForMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_70) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_70) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0602150A RID: 136458 RVA: 0x008E9939 File Offset: 0x008E7B39
		// (set) Token: 0x0602150B RID: 136459 RVA: 0x008E994D File Offset: 0x008E7B4D
		public unsafe UStaticMeshComponent VolumetricCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_71);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InStage_C.__PropertyOffset_71, value);
			}
		}

		// Token: 0x0602150C RID: 136460 RVA: 0x008E9964 File Offset: 0x008E7B64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602150D RID: 136461 RVA: 0x008E99AC File Offset: 0x008E7BAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602150E RID: 136462 RVA: 0x008E99F2 File Offset: 0x008E7BF2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x0602150F RID: 136463 RVA: 0x008E9A06 File Offset: 0x008E7C06
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021510 RID: 136464 RVA: 0x008E9A1A File Offset: 0x008E7C1A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021511 RID: 136465 RVA: 0x008E9A2F File Offset: 0x008E7C2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021512 RID: 136466 RVA: 0x008E9A43 File Offset: 0x008E7C43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021513 RID: 136467 RVA: 0x008E9A58 File Offset: 0x008E7C58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021514 RID: 136468 RVA: 0x008E9AA0 File Offset: 0x008E7CA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021515 RID: 136469 RVA: 0x008E9AE8 File Offset: 0x008E7CE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021516 RID: 136470 RVA: 0x008E9B30 File Offset: 0x008E7D30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021517 RID: 136471 RVA: 0x008E9B77 File Offset: 0x008E7D77
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnGameUserSettingsChange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__OnGameUserSettingsChange_NativeFunctionPtr, null);
		}

		// Token: 0x06021518 RID: 136472 RVA: 0x008E9B8C File Offset: 0x008E7D8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021519 RID: 136473 RVA: 0x008E9BD8 File Offset: 0x008E7DD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InStage_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602151A RID: 136474 RVA: 0x008E9C24 File Offset: 0x008E7E24
		protected BP_VolumetricConeLightShaft_InStage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401033A RID: 66362
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x0401033B RID: 66363
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaft_InStage.BP_VolumetricConeLightShaft_InStage_C";

		// Token: 0x0401033C RID: 66364
		private static IntPtr _ClassPtr;

		// Token: 0x0401033D RID: 66365
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401033E RID: 66366
		internal static int __PropertyOffset_1;

		// Token: 0x0401033F RID: 66367
		internal static int __PropertyOffset_2;

		// Token: 0x04010340 RID: 66368
		internal static int __PropertyOffset_3;

		// Token: 0x04010341 RID: 66369
		internal static int __PropertyOffset_4;

		// Token: 0x04010342 RID: 66370
		internal static int __PropertyOffset_5;

		// Token: 0x04010343 RID: 66371
		internal static int __PropertyOffset_6;

		// Token: 0x04010344 RID: 66372
		internal static int __PropertyOffset_7;

		// Token: 0x04010345 RID: 66373
		internal static int __PropertyOffset_8;

		// Token: 0x04010346 RID: 66374
		internal static int __PropertyOffset_9;

		// Token: 0x04010347 RID: 66375
		internal static int __PropertyOffset_10;

		// Token: 0x04010348 RID: 66376
		internal static int __PropertyOffset_11;

		// Token: 0x04010349 RID: 66377
		internal static int __PropertyOffset_12;

		// Token: 0x0401034A RID: 66378
		internal static int __PropertyOffset_13;

		// Token: 0x0401034B RID: 66379
		internal static int __PropertyOffset_14;

		// Token: 0x0401034C RID: 66380
		internal static int __PropertyOffset_15;

		// Token: 0x0401034D RID: 66381
		internal static int __PropertyOffset_16;

		// Token: 0x0401034E RID: 66382
		internal static int __PropertyOffset_17;

		// Token: 0x0401034F RID: 66383
		internal static int __PropertyOffset_18;

		// Token: 0x04010350 RID: 66384
		internal static int __PropertyOffset_19;

		// Token: 0x04010351 RID: 66385
		internal static int __PropertyOffset_20;

		// Token: 0x04010352 RID: 66386
		internal static int __PropertyOffset_21;

		// Token: 0x04010353 RID: 66387
		internal static int __PropertyOffset_22;

		// Token: 0x04010354 RID: 66388
		internal static int __PropertyOffset_23;

		// Token: 0x04010355 RID: 66389
		internal static int __PropertyOffset_24;

		// Token: 0x04010356 RID: 66390
		internal static int __PropertyOffset_25;

		// Token: 0x04010357 RID: 66391
		internal static int __PropertyOffset_26;

		// Token: 0x04010358 RID: 66392
		internal static int __PropertyOffset_27;

		// Token: 0x04010359 RID: 66393
		internal static int __PropertyOffset_28;

		// Token: 0x0401035A RID: 66394
		internal static int __PropertyOffset_29;

		// Token: 0x0401035B RID: 66395
		internal static int __PropertyOffset_30;

		// Token: 0x0401035C RID: 66396
		internal static int __PropertyOffset_31;

		// Token: 0x0401035D RID: 66397
		internal static int __PropertyOffset_32;

		// Token: 0x0401035E RID: 66398
		internal static int __PropertyOffset_33;

		// Token: 0x0401035F RID: 66399
		internal static int __PropertyOffset_34;

		// Token: 0x04010360 RID: 66400
		internal static int __PropertyOffset_35;

		// Token: 0x04010361 RID: 66401
		internal static int __PropertyOffset_36;

		// Token: 0x04010362 RID: 66402
		internal static int __PropertyOffset_37;

		// Token: 0x04010363 RID: 66403
		internal static int __PropertyOffset_38;

		// Token: 0x04010364 RID: 66404
		internal static int __PropertyOffset_39;

		// Token: 0x04010365 RID: 66405
		internal static int __PropertyOffset_40;

		// Token: 0x04010366 RID: 66406
		internal static int __PropertyOffset_41;

		// Token: 0x04010367 RID: 66407
		internal static int __PropertyOffset_42;

		// Token: 0x04010368 RID: 66408
		internal static int __PropertyOffset_43;

		// Token: 0x04010369 RID: 66409
		internal static int __PropertyOffset_44;

		// Token: 0x0401036A RID: 66410
		internal static int __PropertyOffset_45;

		// Token: 0x0401036B RID: 66411
		internal static int __PropertyOffset_46;

		// Token: 0x0401036C RID: 66412
		internal static int __PropertyOffset_47;

		// Token: 0x0401036D RID: 66413
		internal static int __PropertyOffset_48;

		// Token: 0x0401036E RID: 66414
		internal static int __PropertyOffset_49;

		// Token: 0x0401036F RID: 66415
		internal static int __PropertyOffset_50;

		// Token: 0x04010370 RID: 66416
		internal static int __PropertyOffset_51;

		// Token: 0x04010371 RID: 66417
		internal static int __PropertyOffset_52;

		// Token: 0x04010372 RID: 66418
		internal static int __PropertyOffset_53;

		// Token: 0x04010373 RID: 66419
		private TMap<FName, float> _MaterialInstanceB_Scalars;

		// Token: 0x04010374 RID: 66420
		internal static int __PropertyOffset_54;

		// Token: 0x04010375 RID: 66421
		private TMap<FName, FLinearColor> _MaterialInstanceB_Vectors;

		// Token: 0x04010376 RID: 66422
		internal static int __PropertyOffset_55;

		// Token: 0x04010377 RID: 66423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _MaterialInstanceB_Textures;

		// Token: 0x04010378 RID: 66424
		internal static int __PropertyOffset_56;

		// Token: 0x04010379 RID: 66425
		private TMap<FName, float> _MaterialInstance_Scalars;

		// Token: 0x0401037A RID: 66426
		internal static int __PropertyOffset_57;

		// Token: 0x0401037B RID: 66427
		private TMap<FName, FLinearColor> _MaterialInstance_Vectors;

		// Token: 0x0401037C RID: 66428
		internal static int __PropertyOffset_58;

		// Token: 0x0401037D RID: 66429
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _MaterialInstance_Textures;

		// Token: 0x0401037E RID: 66430
		internal static int __PropertyOffset_59;

		// Token: 0x0401037F RID: 66431
		private TMap<FName, float> _LightShaftCone_Scalars;

		// Token: 0x04010380 RID: 66432
		internal static int __PropertyOffset_60;

		// Token: 0x04010381 RID: 66433
		private TMap<FName, FLinearColor> _LightShaftCone_Vectors;

		// Token: 0x04010382 RID: 66434
		internal static int __PropertyOffset_61;

		// Token: 0x04010383 RID: 66435
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _LightShaftCone_Textures;

		// Token: 0x04010384 RID: 66436
		internal static int __PropertyOffset_62;

		// Token: 0x04010385 RID: 66437
		private TMap<FName, float> _LightMaskMaterial_Scalars;

		// Token: 0x04010386 RID: 66438
		internal static int __PropertyOffset_63;

		// Token: 0x04010387 RID: 66439
		private TMap<FName, FLinearColor> _LightMaskMaterial_Vectors;

		// Token: 0x04010388 RID: 66440
		internal static int __PropertyOffset_64;

		// Token: 0x04010389 RID: 66441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _LightMaskMaterial_Textures;

		// Token: 0x0401038A RID: 66442
		internal static int __PropertyOffset_65;

		// Token: 0x0401038B RID: 66443
		internal static int __PropertyOffset_66;

		// Token: 0x0401038C RID: 66444
		internal static int __PropertyOffset_67;

		// Token: 0x0401038D RID: 66445
		internal static int __PropertyOffset_68;

		// Token: 0x0401038E RID: 66446
		internal static int __PropertyOffset_69;

		// Token: 0x0401038F RID: 66447
		internal static int __PropertyOffset_70;

		// Token: 0x04010390 RID: 66448
		internal static int __PropertyOffset_71;

		// Token: 0x04010391 RID: 66449
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x04010392 RID: 66450
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04010393 RID: 66451
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010394 RID: 66452
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010395 RID: 66453
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010396 RID: 66454
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010397 RID: 66455
		private static IntPtr __OnGameUserSettingsChange_NativeFunctionPtr;

		// Token: 0x04010398 RID: 66456
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009C7F RID: 40063
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x0403133D RID: 201533
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C80 RID: 40064
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403133E RID: 201534
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C81 RID: 40065
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403133F RID: 201535
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C82 RID: 40066
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031340 RID: 201536
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}

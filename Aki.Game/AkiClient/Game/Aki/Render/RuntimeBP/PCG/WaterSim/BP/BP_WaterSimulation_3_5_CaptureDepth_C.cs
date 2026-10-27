using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterSim.BP
{
	// Token: 0x02003BD6 RID: 15318
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_3_5_CaptureDepth.BP_WaterSimulation_3_5_CaptureDepth_C")]
	[UnrealStructLayout(1888, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class BP_WaterSimulation_3_5_CaptureDepth_C : AKuroBPActor, IUnrealUObject, IUnrealObject, INiagaraParticleCallbackHandler, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060226FF RID: 141055 RVA: 0x00908C9A File Offset: 0x00906E9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterSimulation_3_5_CaptureDepth_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_3_5_CaptureDepth.BP_WaterSimulation_3_5_CaptureDepth_C");
			}
			return BP_WaterSimulation_3_5_CaptureDepth_C._ClassPtr;
		}

		// Token: 0x06022700 RID: 141056 RVA: 0x00908CBE File Offset: 0x00906EBE
		int INiagaraParticleCallbackHandler.InterfaceOffset()
		{
			return BP_WaterSimulation_3_5_CaptureDepth_C.__InterfaceOffset_INiagaraParticleCallbackHandler;
		}

		// Token: 0x06022701 RID: 141057 RVA: 0x00908CC8 File Offset: 0x00906EC8
		public BP_WaterSimulation_3_5_CaptureDepth_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_3_5_CaptureDepth_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022702 RID: 141058 RVA: 0x00908CF0 File Offset: 0x00906EF0
		[NullableContext(1)]
		public BP_WaterSimulation_3_5_CaptureDepth_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_3_5_CaptureDepth_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x06022703 RID: 141059 RVA: 0x00908D23 File Offset: 0x00906F23
		// (set) Token: 0x06022704 RID: 141060 RVA: 0x00908D37 File Offset: 0x00906F37
		public unsafe UKuroCustomCaptureVolume KuroCustomCaptureVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCustomCaptureVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x06022705 RID: 141061 RVA: 0x00908D4C File Offset: 0x00906F4C
		// (set) Token: 0x06022706 RID: 141062 RVA: 0x00908D60 File Offset: 0x00906F60
		public unsafe UStaticMeshComponent WaterRender_Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x06022707 RID: 141063 RVA: 0x00908D75 File Offset: 0x00906F75
		// (set) Token: 0x06022708 RID: 141064 RVA: 0x00908D89 File Offset: 0x00906F89
		public unsafe UBoxComponent WaterInteraction_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x06022709 RID: 141065 RVA: 0x00908D9E File Offset: 0x00906F9E
		// (set) Token: 0x0602270A RID: 141066 RVA: 0x00908DB2 File Offset: 0x00906FB2
		public unsafe UStaticMeshComponent WaterInteractionCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x0602270B RID: 141067 RVA: 0x00908DC7 File Offset: 0x00906FC7
		// (set) Token: 0x0602270C RID: 141068 RVA: 0x00908DDB File Offset: 0x00906FDB
		public unsafe UStaticMeshComponent WaterSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x0602270D RID: 141069 RVA: 0x00908DF0 File Offset: 0x00906FF0
		// (set) Token: 0x0602270E RID: 141070 RVA: 0x00908E04 File Offset: 0x00907004
		public unsafe UBoxComponent Sim_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x0602270F RID: 141071 RVA: 0x00908E19 File Offset: 0x00907019
		// (set) Token: 0x06022710 RID: 141072 RVA: 0x00908E2D File Offset: 0x0090702D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x06022711 RID: 141073 RVA: 0x00908E42 File Offset: 0x00907042
		// (set) Token: 0x06022712 RID: 141074 RVA: 0x00908E52 File Offset: 0x00907052
		public unsafe bool Sim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x06022713 RID: 141075 RVA: 0x00908E63 File Offset: 0x00907063
		// (set) Token: 0x06022714 RID: 141076 RVA: 0x00908E73 File Offset: 0x00907073
		public unsafe bool SeqControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x06022715 RID: 141077 RVA: 0x00908E84 File Offset: 0x00907084
		// (set) Token: 0x06022716 RID: 141078 RVA: 0x00908E94 File Offset: 0x00907094
		public unsafe bool DAControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x06022717 RID: 141079 RVA: 0x00908EA5 File Offset: 0x009070A5
		// (set) Token: 0x06022718 RID: 141080 RVA: 0x00908EB9 File Offset: 0x009070B9
		public unsafe FVector SimBoxOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x06022719 RID: 141081 RVA: 0x00908ECE File Offset: 0x009070CE
		// (set) Token: 0x0602271A RID: 141082 RVA: 0x00908EE2 File Offset: 0x009070E2
		public unsafe FVector SimBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0602271B RID: 141083 RVA: 0x00908EF7 File Offset: 0x009070F7
		// (set) Token: 0x0602271C RID: 141084 RVA: 0x00908F07 File Offset: 0x00907107
		public unsafe int SimSize_M_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0602271D RID: 141085 RVA: 0x00908F18 File Offset: 0x00907118
		// (set) Token: 0x0602271E RID: 141086 RVA: 0x00908F2C File Offset: 0x0090712C
		public unsafe UMaterial M_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x0602271F RID: 141087 RVA: 0x00908F41 File Offset: 0x00907141
		// (set) Token: 0x06022720 RID: 141088 RVA: 0x00908F55 File Offset: 0x00907155
		public unsafe UMaterial M_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x06022721 RID: 141089 RVA: 0x00908F6A File Offset: 0x0090716A
		// (set) Token: 0x06022722 RID: 141090 RVA: 0x00908F7E File Offset: 0x0090717E
		public unsafe UMaterial M_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x06022723 RID: 141091 RVA: 0x00908F93 File Offset: 0x00907193
		// (set) Token: 0x06022724 RID: 141092 RVA: 0x00908FA7 File Offset: 0x009071A7
		public unsafe UMaterial M_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x06022725 RID: 141093 RVA: 0x00908FBC File Offset: 0x009071BC
		// (set) Token: 0x06022726 RID: 141094 RVA: 0x00908FD0 File Offset: 0x009071D0
		public unsafe UMaterial M_Water_Clear
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x06022727 RID: 141095 RVA: 0x00908FE5 File Offset: 0x009071E5
		// (set) Token: 0x06022728 RID: 141096 RVA: 0x00908FF9 File Offset: 0x009071F9
		public unsafe UMaterialInstanceDynamic MI_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x06022729 RID: 141097 RVA: 0x0090900E File Offset: 0x0090720E
		// (set) Token: 0x0602272A RID: 141098 RVA: 0x00909022 File Offset: 0x00907222
		public unsafe UMaterialInstanceDynamic MI_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0602272B RID: 141099 RVA: 0x00909037 File Offset: 0x00907237
		// (set) Token: 0x0602272C RID: 141100 RVA: 0x0090904B File Offset: 0x0090724B
		public unsafe UMaterialInstanceDynamic MI_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0602272D RID: 141101 RVA: 0x00909060 File Offset: 0x00907260
		// (set) Token: 0x0602272E RID: 141102 RVA: 0x00909074 File Offset: 0x00907274
		public unsafe UMaterialInstanceDynamic MI_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0602272F RID: 141103 RVA: 0x00909089 File Offset: 0x00907289
		// (set) Token: 0x06022730 RID: 141104 RVA: 0x0090909D File Offset: 0x0090729D
		public unsafe UTextureRenderTarget2D RT_HeightMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x06022731 RID: 141105 RVA: 0x009090B2 File Offset: 0x009072B2
		// (set) Token: 0x06022732 RID: 141106 RVA: 0x009090C6 File Offset: 0x009072C6
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x06022733 RID: 141107 RVA: 0x009090DB File Offset: 0x009072DB
		// (set) Token: 0x06022734 RID: 141108 RVA: 0x009090EF File Offset: 0x009072EF
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Temp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x06022735 RID: 141109 RVA: 0x00909104 File Offset: 0x00907304
		// (set) Token: 0x06022736 RID: 141110 RVA: 0x00909118 File Offset: 0x00907318
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x06022737 RID: 141111 RVA: 0x0090912D File Offset: 0x0090732D
		// (set) Token: 0x06022738 RID: 141112 RVA: 0x00909141 File Offset: 0x00907341
		public unsafe UStaticMeshComponent RenderActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x06022739 RID: 141113 RVA: 0x00909156 File Offset: 0x00907356
		// (set) Token: 0x0602273A RID: 141114 RVA: 0x0090916A File Offset: 0x0090736A
		public unsafe UMaterialInterface M_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0602273B RID: 141115 RVA: 0x0090917F File Offset: 0x0090737F
		// (set) Token: 0x0602273C RID: 141116 RVA: 0x00909193 File Offset: 0x00907393
		public unsafe UMaterialInstanceDynamic MI_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0602273D RID: 141117 RVA: 0x009091A8 File Offset: 0x009073A8
		// (set) Token: 0x0602273E RID: 141118 RVA: 0x009091B8 File Offset: 0x009073B8
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0602273F RID: 141119 RVA: 0x009091C9 File Offset: 0x009073C9
		// (set) Token: 0x06022740 RID: 141120 RVA: 0x009091D9 File Offset: 0x009073D9
		public unsafe float DurationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x06022741 RID: 141121 RVA: 0x009091EA File Offset: 0x009073EA
		// (set) Token: 0x06022742 RID: 141122 RVA: 0x009091FE File Offset: 0x009073FE
		public unsafe FLinearColor WaterSuorcePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x06022743 RID: 141123 RVA: 0x00909213 File Offset: 0x00907413
		// (set) Token: 0x06022744 RID: 141124 RVA: 0x00909227 File Offset: 0x00907427
		public unsafe FLinearColor WaterSuorcePos1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x06022745 RID: 141125 RVA: 0x0090923C File Offset: 0x0090743C
		// (set) Token: 0x06022746 RID: 141126 RVA: 0x0090924C File Offset: 0x0090744C
		public unsafe float WaterActorHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x06022747 RID: 141127 RVA: 0x0090925D File Offset: 0x0090745D
		// (set) Token: 0x06022748 RID: 141128 RVA: 0x0090926D File Offset: 0x0090746D
		public unsafe float PlayerWaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x06022749 RID: 141129 RVA: 0x0090927E File Offset: 0x0090747E
		// (set) Token: 0x0602274A RID: 141130 RVA: 0x0090928E File Offset: 0x0090748E
		public unsafe float CameraWaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0602274B RID: 141131 RVA: 0x0090929F File Offset: 0x0090749F
		// (set) Token: 0x0602274C RID: 141132 RVA: 0x009092B3 File Offset: 0x009074B3
		public unsafe FVector PlayerWaterNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0602274D RID: 141133 RVA: 0x009092C8 File Offset: 0x009074C8
		// (set) Token: 0x0602274E RID: 141134 RVA: 0x009092D8 File Offset: 0x009074D8
		public unsafe float PlayerWaterVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0602274F RID: 141135 RVA: 0x009092E9 File Offset: 0x009074E9
		// (set) Token: 0x06022750 RID: 141136 RVA: 0x009092F9 File Offset: 0x009074F9
		public unsafe float CameraWaterVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x06022751 RID: 141137 RVA: 0x0090930A File Offset: 0x0090750A
		// (set) Token: 0x06022752 RID: 141138 RVA: 0x0090931E File Offset: 0x0090751E
		public unsafe FVector CameraWaterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x06022753 RID: 141139 RVA: 0x00909333 File Offset: 0x00907533
		// (set) Token: 0x06022754 RID: 141140 RVA: 0x00909347 File Offset: 0x00907547
		public unsafe FVector PlayerWaterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x06022755 RID: 141141 RVA: 0x0090935C File Offset: 0x0090755C
		// (set) Token: 0x06022756 RID: 141142 RVA: 0x0090936C File Offset: 0x0090756C
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x06022757 RID: 141143 RVA: 0x0090937D File Offset: 0x0090757D
		// (set) Token: 0x06022758 RID: 141144 RVA: 0x0090938D File Offset: 0x0090758D
		public unsafe float AccelerationClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x06022759 RID: 141145 RVA: 0x0090939E File Offset: 0x0090759E
		// (set) Token: 0x0602275A RID: 141146 RVA: 0x009093AE File Offset: 0x009075AE
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x0602275B RID: 141147 RVA: 0x009093BF File Offset: 0x009075BF
		// (set) Token: 0x0602275C RID: 141148 RVA: 0x009093CF File Offset: 0x009075CF
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0602275D RID: 141149 RVA: 0x009093E0 File Offset: 0x009075E0
		// (set) Token: 0x0602275E RID: 141150 RVA: 0x009093F0 File Offset: 0x009075F0
		public unsafe float VelocityClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0602275F RID: 141151 RVA: 0x00909401 File Offset: 0x00907601
		// (set) Token: 0x06022760 RID: 141152 RVA: 0x00909411 File Offset: 0x00907611
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x06022761 RID: 141153 RVA: 0x00909422 File Offset: 0x00907622
		// (set) Token: 0x06022762 RID: 141154 RVA: 0x00909432 File Offset: 0x00907632
		public unsafe int LoopNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x06022763 RID: 141155 RVA: 0x00909443 File Offset: 0x00907643
		// (set) Token: 0x06022764 RID: 141156 RVA: 0x00909457 File Offset: 0x00907657
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x06022765 RID: 141157 RVA: 0x0090946C File Offset: 0x0090766C
		// (set) Token: 0x06022766 RID: 141158 RVA: 0x00909480 File Offset: 0x00907680
		public unsafe BP_HeightmapReadback_C BP_HeightmapReadback
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_HeightmapReadback_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x06022767 RID: 141159 RVA: 0x00909495 File Offset: 0x00907695
		// (set) Token: 0x06022768 RID: 141160 RVA: 0x009094A5 File Offset: 0x009076A5
		public unsafe int Readback_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x06022769 RID: 141161 RVA: 0x009094B6 File Offset: 0x009076B6
		// (set) Token: 0x0602276A RID: 141162 RVA: 0x009094C6 File Offset: 0x009076C6
		public unsafe int Readback_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x0602276B RID: 141163 RVA: 0x009094D7 File Offset: 0x009076D7
		// (set) Token: 0x0602276C RID: 141164 RVA: 0x009094E7 File Offset: 0x009076E7
		public unsafe float Readback_Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0602276D RID: 141165 RVA: 0x009094F8 File Offset: 0x009076F8
		// (set) Token: 0x0602276E RID: 141166 RVA: 0x0090950C File Offset: 0x0090770C
		public unsafe FVector4 CaptureRangeMax_Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0602276F RID: 141167 RVA: 0x00909521 File Offset: 0x00907721
		// (set) Token: 0x06022770 RID: 141168 RVA: 0x00909531 File Offset: 0x00907731
		public unsafe bool DynamicWaterFlow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x06022771 RID: 141169 RVA: 0x00909542 File Offset: 0x00907742
		// (set) Token: 0x06022772 RID: 141170 RVA: 0x00909552 File Offset: 0x00907752
		public unsafe bool OverlapVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x06022773 RID: 141171 RVA: 0x00909563 File Offset: 0x00907763
		// (set) Token: 0x06022774 RID: 141172 RVA: 0x00909573 File Offset: 0x00907773
		public unsafe bool Is_Simulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_57) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_57) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x06022775 RID: 141173 RVA: 0x00909584 File Offset: 0x00907784
		// (set) Token: 0x06022776 RID: 141174 RVA: 0x00909594 File Offset: 0x00907794
		public unsafe float CameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x06022777 RID: 141175 RVA: 0x009095A8 File Offset: 0x009077A8
		// (set) Token: 0x06022778 RID: 141176 RVA: 0x009095E1 File Offset: 0x009077E1
		[Nullable(1)]
		public TArray<AActor> Hidden_Actors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Hidden_Actors) == null)
				{
					result = (this._Hidden_Actors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_59, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Hidden_Actors.CopyAssign(value);
			}
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x06022779 RID: 141177 RVA: 0x009095EF File Offset: 0x009077EF
		// (set) Token: 0x0602277A RID: 141178 RVA: 0x009095FF File Offset: 0x009077FF
		public unsafe int TextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x0602277B RID: 141179 RVA: 0x00909610 File Offset: 0x00907810
		// (set) Token: 0x0602277C RID: 141180 RVA: 0x00909624 File Offset: 0x00907824
		[Nullable(1)]
		public unsafe string SavePath
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_61)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WaterSimulation_3_5_CaptureDepth_C.__PropertyOffset_61)), value);
			}
		}

		// Token: 0x0602277D RID: 141181 RVA: 0x00909639 File Offset: 0x00907839
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SaveCaptureDepthMap()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__SaveCaptureDepthMap_NativeFunctionPtr, null);
		}

		// Token: 0x0602277E RID: 141182 RVA: 0x0090964D File Offset: 0x0090784D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReStartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__ReStartSim_NativeFunctionPtr, null);
		}

		// Token: 0x0602277F RID: 141183 RVA: 0x00909664 File Offset: 0x00907864
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HideRenderWaterMesh(bool HideRenderWater)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__HideRenderWaterMesh_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__HideRenderWaterMesh_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__HideRenderWaterMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__HideRenderWaterMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HideRenderWater = HideRenderWater;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__HideRenderWaterMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022780 RID: 141184 RVA: 0x009096AA File Offset: 0x009078AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalcHeightmap()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__CalcHeightmap_NativeFunctionPtr, null);
		}

		// Token: 0x06022781 RID: 141185 RVA: 0x009096BE File Offset: 0x009078BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMPCParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__SetMPCParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06022782 RID: 141186 RVA: 0x009096D2 File Offset: 0x009078D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x06022783 RID: 141187 RVA: 0x009096E6 File Offset: 0x009078E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x06022784 RID: 141188 RVA: 0x009096FA File Offset: 0x009078FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearWater()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__ClearWater_NativeFunctionPtr, null);
		}

		// Token: 0x06022785 RID: 141189 RVA: 0x00909710 File Offset: 0x00907910
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMaterialParameter(UMaterialInterface Material, UTexture VelocityHeightFoam, ref UMaterialInstanceDynamic MaterialInstance)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__SetMaterialParameter_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__SetMaterialParameter_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__SetMaterialParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			ptr->VelocityHeightFoam = ((VelocityHeightFoam != null) ? VelocityHeightFoam.NativePtr : IntPtr.Zero);
			ref BP_WaterSimulation_3_5_CaptureDepth_C.__SetMaterialParameter_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = MaterialInstance;
			ptr2.MaterialInstance = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr);
			MaterialInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->MaterialInstance);
		}

		// Token: 0x06022786 RID: 141190 RVA: 0x009097A0 File Offset: 0x009079A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022787 RID: 141191 RVA: 0x009097B4 File Offset: 0x009079B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022788 RID: 141192 RVA: 0x009097CC File Offset: 0x009079CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022789 RID: 141193 RVA: 0x00909888 File Offset: 0x00907A88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602278A RID: 141194 RVA: 0x00909914 File Offset: 0x00907B14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602278B RID: 141195 RVA: 0x009099D0 File Offset: 0x00907BD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602278C RID: 141196 RVA: 0x00909A59 File Offset: 0x00907C59
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602278D RID: 141197 RVA: 0x00909A70 File Offset: 0x00907C70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602278E RID: 141198 RVA: 0x00909AB8 File Offset: 0x00907CB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602278F RID: 141199 RVA: 0x00909AFF File Offset: 0x00907CFF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022790 RID: 141200 RVA: 0x00909B13 File Offset: 0x00907D13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022791 RID: 141201 RVA: 0x00909B28 File Offset: 0x00907D28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReceiveParticleData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022792 RID: 141202 RVA: 0x00909BB8 File Offset: 0x00907DB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveParticleData_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_WaterSimulation_3_5_CaptureDepth_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022793 RID: 141203 RVA: 0x00909C47 File Offset: 0x00907E47
		protected BP_WaterSimulation_3_5_CaptureDepth_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E71 RID: 69233
		internal static int __InterfaceOffset_INiagaraParticleCallbackHandler;

		// Token: 0x04010E72 RID: 69234
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_3_5_CaptureDepth.BP_WaterSimulation_3_5_CaptureDepth_C";

		// Token: 0x04010E73 RID: 69235
		private static IntPtr _ClassPtr;

		// Token: 0x04010E74 RID: 69236
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E75 RID: 69237
		internal static int __PropertyOffset_1;

		// Token: 0x04010E76 RID: 69238
		internal static int __PropertyOffset_2;

		// Token: 0x04010E77 RID: 69239
		internal static int __PropertyOffset_3;

		// Token: 0x04010E78 RID: 69240
		internal static int __PropertyOffset_4;

		// Token: 0x04010E79 RID: 69241
		internal static int __PropertyOffset_5;

		// Token: 0x04010E7A RID: 69242
		internal static int __PropertyOffset_6;

		// Token: 0x04010E7B RID: 69243
		internal static int __PropertyOffset_7;

		// Token: 0x04010E7C RID: 69244
		internal static int __PropertyOffset_8;

		// Token: 0x04010E7D RID: 69245
		internal static int __PropertyOffset_9;

		// Token: 0x04010E7E RID: 69246
		internal static int __PropertyOffset_10;

		// Token: 0x04010E7F RID: 69247
		internal static int __PropertyOffset_11;

		// Token: 0x04010E80 RID: 69248
		internal static int __PropertyOffset_12;

		// Token: 0x04010E81 RID: 69249
		internal static int __PropertyOffset_13;

		// Token: 0x04010E82 RID: 69250
		internal static int __PropertyOffset_14;

		// Token: 0x04010E83 RID: 69251
		internal static int __PropertyOffset_15;

		// Token: 0x04010E84 RID: 69252
		internal static int __PropertyOffset_16;

		// Token: 0x04010E85 RID: 69253
		internal static int __PropertyOffset_17;

		// Token: 0x04010E86 RID: 69254
		internal static int __PropertyOffset_18;

		// Token: 0x04010E87 RID: 69255
		internal static int __PropertyOffset_19;

		// Token: 0x04010E88 RID: 69256
		internal static int __PropertyOffset_20;

		// Token: 0x04010E89 RID: 69257
		internal static int __PropertyOffset_21;

		// Token: 0x04010E8A RID: 69258
		internal static int __PropertyOffset_22;

		// Token: 0x04010E8B RID: 69259
		internal static int __PropertyOffset_23;

		// Token: 0x04010E8C RID: 69260
		internal static int __PropertyOffset_24;

		// Token: 0x04010E8D RID: 69261
		internal static int __PropertyOffset_25;

		// Token: 0x04010E8E RID: 69262
		internal static int __PropertyOffset_26;

		// Token: 0x04010E8F RID: 69263
		internal static int __PropertyOffset_27;

		// Token: 0x04010E90 RID: 69264
		internal static int __PropertyOffset_28;

		// Token: 0x04010E91 RID: 69265
		internal static int __PropertyOffset_29;

		// Token: 0x04010E92 RID: 69266
		internal static int __PropertyOffset_30;

		// Token: 0x04010E93 RID: 69267
		internal static int __PropertyOffset_31;

		// Token: 0x04010E94 RID: 69268
		internal static int __PropertyOffset_32;

		// Token: 0x04010E95 RID: 69269
		internal static int __PropertyOffset_33;

		// Token: 0x04010E96 RID: 69270
		internal static int __PropertyOffset_34;

		// Token: 0x04010E97 RID: 69271
		internal static int __PropertyOffset_35;

		// Token: 0x04010E98 RID: 69272
		internal static int __PropertyOffset_36;

		// Token: 0x04010E99 RID: 69273
		internal static int __PropertyOffset_37;

		// Token: 0x04010E9A RID: 69274
		internal static int __PropertyOffset_38;

		// Token: 0x04010E9B RID: 69275
		internal static int __PropertyOffset_39;

		// Token: 0x04010E9C RID: 69276
		internal static int __PropertyOffset_40;

		// Token: 0x04010E9D RID: 69277
		internal static int __PropertyOffset_41;

		// Token: 0x04010E9E RID: 69278
		internal static int __PropertyOffset_42;

		// Token: 0x04010E9F RID: 69279
		internal static int __PropertyOffset_43;

		// Token: 0x04010EA0 RID: 69280
		internal static int __PropertyOffset_44;

		// Token: 0x04010EA1 RID: 69281
		internal static int __PropertyOffset_45;

		// Token: 0x04010EA2 RID: 69282
		internal static int __PropertyOffset_46;

		// Token: 0x04010EA3 RID: 69283
		internal static int __PropertyOffset_47;

		// Token: 0x04010EA4 RID: 69284
		internal static int __PropertyOffset_48;

		// Token: 0x04010EA5 RID: 69285
		internal static int __PropertyOffset_49;

		// Token: 0x04010EA6 RID: 69286
		internal static int __PropertyOffset_50;

		// Token: 0x04010EA7 RID: 69287
		internal static int __PropertyOffset_51;

		// Token: 0x04010EA8 RID: 69288
		internal static int __PropertyOffset_52;

		// Token: 0x04010EA9 RID: 69289
		internal static int __PropertyOffset_53;

		// Token: 0x04010EAA RID: 69290
		internal static int __PropertyOffset_54;

		// Token: 0x04010EAB RID: 69291
		internal static int __PropertyOffset_55;

		// Token: 0x04010EAC RID: 69292
		internal static int __PropertyOffset_56;

		// Token: 0x04010EAD RID: 69293
		internal static int __PropertyOffset_57;

		// Token: 0x04010EAE RID: 69294
		internal static int __PropertyOffset_58;

		// Token: 0x04010EAF RID: 69295
		internal static int __PropertyOffset_59;

		// Token: 0x04010EB0 RID: 69296
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Hidden_Actors;

		// Token: 0x04010EB1 RID: 69297
		internal static int __PropertyOffset_60;

		// Token: 0x04010EB2 RID: 69298
		internal static int __PropertyOffset_61;

		// Token: 0x04010EB3 RID: 69299
		private static IntPtr __SaveCaptureDepthMap_NativeFunctionPtr;

		// Token: 0x04010EB4 RID: 69300
		private static IntPtr __ReStartSim_NativeFunctionPtr;

		// Token: 0x04010EB5 RID: 69301
		private static IntPtr __HideRenderWaterMesh_NativeFunctionPtr;

		// Token: 0x04010EB6 RID: 69302
		private static IntPtr __CalcHeightmap_NativeFunctionPtr;

		// Token: 0x04010EB7 RID: 69303
		private static IntPtr __SetMPCParameters_NativeFunctionPtr;

		// Token: 0x04010EB8 RID: 69304
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x04010EB9 RID: 69305
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04010EBA RID: 69306
		private static IntPtr __ClearWater_NativeFunctionPtr;

		// Token: 0x04010EBB RID: 69307
		private static IntPtr __SetMaterialParameter_NativeFunctionPtr;

		// Token: 0x04010EBC RID: 69308
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010EBD RID: 69309
		private static IntPtr __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010EBE RID: 69310
		private static IntPtr __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010EBF RID: 69311
		private static IntPtr __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010EC0 RID: 69312
		private static IntPtr __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010EC1 RID: 69313
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010EC2 RID: 69314
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010EC3 RID: 69315
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010EC4 RID: 69316
		private static IntPtr __ReceiveParticleData_NativeFunctionPtr;

		// Token: 0x02009D7C RID: 40316
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HideRenderWaterMesh_FunctionParams
		{
			// Token: 0x0403150F RID: 201999
			[FieldOffset(0)]
			public bool HideRenderWater;
		}

		// Token: 0x02009D7D RID: 40317
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __SetMaterialParameter_FunctionParams
		{
			// Token: 0x04031510 RID: 202000
			[FieldOffset(0)]
			public IntPtr Material;

			// Token: 0x04031511 RID: 202001
			[FieldOffset(8)]
			public IntPtr VelocityHeightFoam;

			// Token: 0x04031512 RID: 202002
			[FieldOffset(16)]
			public IntPtr MaterialInstance;
		}

		// Token: 0x02009D7E RID: 40318
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031513 RID: 202003
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031514 RID: 202004
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031515 RID: 202005
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031516 RID: 202006
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031517 RID: 202007
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031518 RID: 202008
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D7F RID: 40319
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031519 RID: 202009
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403151A RID: 202010
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403151B RID: 202011
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403151C RID: 202012
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009D80 RID: 40320
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403151D RID: 202013
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403151E RID: 202014
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403151F RID: 202015
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031520 RID: 202016
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031521 RID: 202017
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031522 RID: 202018
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D81 RID: 40321
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031523 RID: 202019
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031524 RID: 202020
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031525 RID: 202021
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031526 RID: 202022
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009D82 RID: 40322
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031527 RID: 202023
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D83 RID: 40323
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveParticleData_FunctionParams
		{
			// Token: 0x04031528 RID: 202024
			[FieldOffset(0)]
			public byte Data;

			// Token: 0x04031529 RID: 202025
			[FieldOffset(16)]
			public IntPtr NiagaraSystem;
		}
	}
}

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
	// Token: 0x02003BD7 RID: 15319
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_4.BP_WaterSimulation_4_C")]
	[UnrealStructLayout(1888, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class BP_WaterSimulation_4_C : AKuroBPActor, IUnrealUObject, IUnrealObject, INiagaraParticleCallbackHandler, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022794 RID: 141204 RVA: 0x00909C50 File Offset: 0x00907E50
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterSimulation_4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_4.BP_WaterSimulation_4_C");
			}
			return BP_WaterSimulation_4_C._ClassPtr;
		}

		// Token: 0x06022795 RID: 141205 RVA: 0x00909C74 File Offset: 0x00907E74
		int INiagaraParticleCallbackHandler.InterfaceOffset()
		{
			return BP_WaterSimulation_4_C.__InterfaceOffset_INiagaraParticleCallbackHandler;
		}

		// Token: 0x06022796 RID: 141206 RVA: 0x00909C7C File Offset: 0x00907E7C
		public BP_WaterSimulation_4_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022797 RID: 141207 RVA: 0x00909CA4 File Offset: 0x00907EA4
		[NullableContext(1)]
		public BP_WaterSimulation_4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x06022798 RID: 141208 RVA: 0x00909CD7 File Offset: 0x00907ED7
		// (set) Token: 0x06022799 RID: 141209 RVA: 0x00909CEB File Offset: 0x00907EEB
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0602279A RID: 141210 RVA: 0x00909D00 File Offset: 0x00907F00
		// (set) Token: 0x0602279B RID: 141211 RVA: 0x00909D14 File Offset: 0x00907F14
		public unsafe UBoxComponent WaterInteraction_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0602279C RID: 141212 RVA: 0x00909D29 File Offset: 0x00907F29
		// (set) Token: 0x0602279D RID: 141213 RVA: 0x00909D3D File Offset: 0x00907F3D
		public unsafe UStaticMeshComponent WaterInteractionCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0602279E RID: 141214 RVA: 0x00909D52 File Offset: 0x00907F52
		// (set) Token: 0x0602279F RID: 141215 RVA: 0x00909D66 File Offset: 0x00907F66
		public unsafe UStaticMeshComponent WaterSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x060227A0 RID: 141216 RVA: 0x00909D7B File Offset: 0x00907F7B
		// (set) Token: 0x060227A1 RID: 141217 RVA: 0x00909D8F File Offset: 0x00907F8F
		public unsafe UStaticMeshComponent PreView_Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x060227A2 RID: 141218 RVA: 0x00909DA4 File Offset: 0x00907FA4
		// (set) Token: 0x060227A3 RID: 141219 RVA: 0x00909DB8 File Offset: 0x00907FB8
		public unsafe UBoxComponent Sim_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x060227A4 RID: 141220 RVA: 0x00909DCD File Offset: 0x00907FCD
		// (set) Token: 0x060227A5 RID: 141221 RVA: 0x00909DE1 File Offset: 0x00907FE1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x060227A6 RID: 141222 RVA: 0x00909DF6 File Offset: 0x00907FF6
		// (set) Token: 0x060227A7 RID: 141223 RVA: 0x00909E06 File Offset: 0x00908006
		public unsafe bool Sim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x060227A8 RID: 141224 RVA: 0x00909E17 File Offset: 0x00908017
		// (set) Token: 0x060227A9 RID: 141225 RVA: 0x00909E27 File Offset: 0x00908027
		public unsafe bool SeqControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x060227AA RID: 141226 RVA: 0x00909E38 File Offset: 0x00908038
		// (set) Token: 0x060227AB RID: 141227 RVA: 0x00909E48 File Offset: 0x00908048
		public unsafe bool DAControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x060227AC RID: 141228 RVA: 0x00909E59 File Offset: 0x00908059
		// (set) Token: 0x060227AD RID: 141229 RVA: 0x00909E6D File Offset: 0x0090806D
		public unsafe FVector SimBoxOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x060227AE RID: 141230 RVA: 0x00909E82 File Offset: 0x00908082
		// (set) Token: 0x060227AF RID: 141231 RVA: 0x00909E96 File Offset: 0x00908096
		public unsafe FVector SimBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x060227B0 RID: 141232 RVA: 0x00909EAB File Offset: 0x009080AB
		// (set) Token: 0x060227B1 RID: 141233 RVA: 0x00909EBB File Offset: 0x009080BB
		public unsafe int SimSize_M_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x060227B2 RID: 141234 RVA: 0x00909ECC File Offset: 0x009080CC
		// (set) Token: 0x060227B3 RID: 141235 RVA: 0x00909EE0 File Offset: 0x009080E0
		public unsafe UMaterial M_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x060227B4 RID: 141236 RVA: 0x00909EF5 File Offset: 0x009080F5
		// (set) Token: 0x060227B5 RID: 141237 RVA: 0x00909F09 File Offset: 0x00908109
		public unsafe UMaterial M_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x060227B6 RID: 141238 RVA: 0x00909F1E File Offset: 0x0090811E
		// (set) Token: 0x060227B7 RID: 141239 RVA: 0x00909F32 File Offset: 0x00908132
		public unsafe UMaterial M_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x060227B8 RID: 141240 RVA: 0x00909F47 File Offset: 0x00908147
		// (set) Token: 0x060227B9 RID: 141241 RVA: 0x00909F5B File Offset: 0x0090815B
		public unsafe UMaterial M_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x060227BA RID: 141242 RVA: 0x00909F70 File Offset: 0x00908170
		// (set) Token: 0x060227BB RID: 141243 RVA: 0x00909F84 File Offset: 0x00908184
		public unsafe UMaterial M_Water_Clear
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x060227BC RID: 141244 RVA: 0x00909F99 File Offset: 0x00908199
		// (set) Token: 0x060227BD RID: 141245 RVA: 0x00909FAD File Offset: 0x009081AD
		public unsafe UMaterialInstanceDynamic MI_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x060227BE RID: 141246 RVA: 0x00909FC2 File Offset: 0x009081C2
		// (set) Token: 0x060227BF RID: 141247 RVA: 0x00909FD6 File Offset: 0x009081D6
		public unsafe UMaterialInstanceDynamic MI_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x060227C0 RID: 141248 RVA: 0x00909FEB File Offset: 0x009081EB
		// (set) Token: 0x060227C1 RID: 141249 RVA: 0x00909FFF File Offset: 0x009081FF
		public unsafe UMaterialInstanceDynamic MI_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x060227C2 RID: 141250 RVA: 0x0090A014 File Offset: 0x00908214
		// (set) Token: 0x060227C3 RID: 141251 RVA: 0x0090A028 File Offset: 0x00908228
		public unsafe UMaterialInstanceDynamic MI_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x060227C4 RID: 141252 RVA: 0x0090A03D File Offset: 0x0090823D
		// (set) Token: 0x060227C5 RID: 141253 RVA: 0x0090A051 File Offset: 0x00908251
		public unsafe UTextureRenderTarget2D RT_HeightMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x060227C6 RID: 141254 RVA: 0x0090A066 File Offset: 0x00908266
		// (set) Token: 0x060227C7 RID: 141255 RVA: 0x0090A07A File Offset: 0x0090827A
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x060227C8 RID: 141256 RVA: 0x0090A08F File Offset: 0x0090828F
		// (set) Token: 0x060227C9 RID: 141257 RVA: 0x0090A0A3 File Offset: 0x009082A3
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Temp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x060227CA RID: 141258 RVA: 0x0090A0B8 File Offset: 0x009082B8
		// (set) Token: 0x060227CB RID: 141259 RVA: 0x0090A0CC File Offset: 0x009082CC
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x060227CC RID: 141260 RVA: 0x0090A0E1 File Offset: 0x009082E1
		// (set) Token: 0x060227CD RID: 141261 RVA: 0x0090A0F5 File Offset: 0x009082F5
		public unsafe UStaticMeshComponent RenderActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x060227CE RID: 141262 RVA: 0x0090A10A File Offset: 0x0090830A
		// (set) Token: 0x060227CF RID: 141263 RVA: 0x0090A11E File Offset: 0x0090831E
		public unsafe UMaterialInterface M_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x060227D0 RID: 141264 RVA: 0x0090A133 File Offset: 0x00908333
		// (set) Token: 0x060227D1 RID: 141265 RVA: 0x0090A147 File Offset: 0x00908347
		public unsafe UMaterialInstanceDynamic MI_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x060227D2 RID: 141266 RVA: 0x0090A15C File Offset: 0x0090835C
		// (set) Token: 0x060227D3 RID: 141267 RVA: 0x0090A16C File Offset: 0x0090836C
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x060227D4 RID: 141268 RVA: 0x0090A17D File Offset: 0x0090837D
		// (set) Token: 0x060227D5 RID: 141269 RVA: 0x0090A18D File Offset: 0x0090838D
		public unsafe float DurationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x060227D6 RID: 141270 RVA: 0x0090A19E File Offset: 0x0090839E
		// (set) Token: 0x060227D7 RID: 141271 RVA: 0x0090A1B2 File Offset: 0x009083B2
		public unsafe FLinearColor WaterSuorcePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x060227D8 RID: 141272 RVA: 0x0090A1C7 File Offset: 0x009083C7
		// (set) Token: 0x060227D9 RID: 141273 RVA: 0x0090A1DB File Offset: 0x009083DB
		public unsafe FLinearColor WaterSuorcePos1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x060227DA RID: 141274 RVA: 0x0090A1F0 File Offset: 0x009083F0
		// (set) Token: 0x060227DB RID: 141275 RVA: 0x0090A200 File Offset: 0x00908400
		public unsafe float WaterActorHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x060227DC RID: 141276 RVA: 0x0090A211 File Offset: 0x00908411
		// (set) Token: 0x060227DD RID: 141277 RVA: 0x0090A221 File Offset: 0x00908421
		public unsafe float PlayerWaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x060227DE RID: 141278 RVA: 0x0090A232 File Offset: 0x00908432
		// (set) Token: 0x060227DF RID: 141279 RVA: 0x0090A242 File Offset: 0x00908442
		public unsafe float CameraWaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x060227E0 RID: 141280 RVA: 0x0090A253 File Offset: 0x00908453
		// (set) Token: 0x060227E1 RID: 141281 RVA: 0x0090A267 File Offset: 0x00908467
		public unsafe FVector PlayerWaterNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x060227E2 RID: 141282 RVA: 0x0090A27C File Offset: 0x0090847C
		// (set) Token: 0x060227E3 RID: 141283 RVA: 0x0090A28C File Offset: 0x0090848C
		public unsafe float PlayerWaterVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x060227E4 RID: 141284 RVA: 0x0090A29D File Offset: 0x0090849D
		// (set) Token: 0x060227E5 RID: 141285 RVA: 0x0090A2AD File Offset: 0x009084AD
		public unsafe float CameraWaterVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x060227E6 RID: 141286 RVA: 0x0090A2BE File Offset: 0x009084BE
		// (set) Token: 0x060227E7 RID: 141287 RVA: 0x0090A2D2 File Offset: 0x009084D2
		public unsafe FVector CameraWaterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x060227E8 RID: 141288 RVA: 0x0090A2E7 File Offset: 0x009084E7
		// (set) Token: 0x060227E9 RID: 141289 RVA: 0x0090A2FB File Offset: 0x009084FB
		public unsafe FVector PlayerWaterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x060227EA RID: 141290 RVA: 0x0090A310 File Offset: 0x00908510
		// (set) Token: 0x060227EB RID: 141291 RVA: 0x0090A320 File Offset: 0x00908520
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x060227EC RID: 141292 RVA: 0x0090A331 File Offset: 0x00908531
		// (set) Token: 0x060227ED RID: 141293 RVA: 0x0090A341 File Offset: 0x00908541
		public unsafe float AccelerationClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x060227EE RID: 141294 RVA: 0x0090A352 File Offset: 0x00908552
		// (set) Token: 0x060227EF RID: 141295 RVA: 0x0090A362 File Offset: 0x00908562
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x060227F0 RID: 141296 RVA: 0x0090A373 File Offset: 0x00908573
		// (set) Token: 0x060227F1 RID: 141297 RVA: 0x0090A383 File Offset: 0x00908583
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x060227F2 RID: 141298 RVA: 0x0090A394 File Offset: 0x00908594
		// (set) Token: 0x060227F3 RID: 141299 RVA: 0x0090A3A4 File Offset: 0x009085A4
		public unsafe float VelocityClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x060227F4 RID: 141300 RVA: 0x0090A3B5 File Offset: 0x009085B5
		// (set) Token: 0x060227F5 RID: 141301 RVA: 0x0090A3C5 File Offset: 0x009085C5
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x060227F6 RID: 141302 RVA: 0x0090A3D6 File Offset: 0x009085D6
		// (set) Token: 0x060227F7 RID: 141303 RVA: 0x0090A3E6 File Offset: 0x009085E6
		public unsafe int LoopNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x060227F8 RID: 141304 RVA: 0x0090A3F7 File Offset: 0x009085F7
		// (set) Token: 0x060227F9 RID: 141305 RVA: 0x0090A40B File Offset: 0x0090860B
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x060227FA RID: 141306 RVA: 0x0090A420 File Offset: 0x00908620
		// (set) Token: 0x060227FB RID: 141307 RVA: 0x0090A434 File Offset: 0x00908634
		public unsafe BP_HeightmapReadback_C BP_HeightmapReadback
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_HeightmapReadback_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_4_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x060227FC RID: 141308 RVA: 0x0090A449 File Offset: 0x00908649
		// (set) Token: 0x060227FD RID: 141309 RVA: 0x0090A459 File Offset: 0x00908659
		public unsafe int Readback_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x060227FE RID: 141310 RVA: 0x0090A46A File Offset: 0x0090866A
		// (set) Token: 0x060227FF RID: 141311 RVA: 0x0090A47A File Offset: 0x0090867A
		public unsafe int Readback_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x06022800 RID: 141312 RVA: 0x0090A48B File Offset: 0x0090868B
		// (set) Token: 0x06022801 RID: 141313 RVA: 0x0090A49B File Offset: 0x0090869B
		public unsafe float Readback_Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x06022802 RID: 141314 RVA: 0x0090A4AC File Offset: 0x009086AC
		// (set) Token: 0x06022803 RID: 141315 RVA: 0x0090A4C0 File Offset: 0x009086C0
		public unsafe FVector4 CaptureRangeMax_Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x06022804 RID: 141316 RVA: 0x0090A4D5 File Offset: 0x009086D5
		// (set) Token: 0x06022805 RID: 141317 RVA: 0x0090A4E5 File Offset: 0x009086E5
		public unsafe bool DynamicWaterFlow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x06022806 RID: 141318 RVA: 0x0090A4F6 File Offset: 0x009086F6
		// (set) Token: 0x06022807 RID: 141319 RVA: 0x0090A506 File Offset: 0x00908706
		public unsafe bool OverlapVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x06022808 RID: 141320 RVA: 0x0090A517 File Offset: 0x00908717
		// (set) Token: 0x06022809 RID: 141321 RVA: 0x0090A527 File Offset: 0x00908727
		public unsafe bool Is_Simulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_57) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_57) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0602280A RID: 141322 RVA: 0x0090A538 File Offset: 0x00908738
		// (set) Token: 0x0602280B RID: 141323 RVA: 0x0090A548 File Offset: 0x00908748
		public unsafe float CameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x0602280C RID: 141324 RVA: 0x0090A55C File Offset: 0x0090875C
		// (set) Token: 0x0602280D RID: 141325 RVA: 0x0090A595 File Offset: 0x00908795
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
					result = (this._Hidden_Actors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_59, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Hidden_Actors.CopyAssign(value);
			}
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0602280E RID: 141326 RVA: 0x0090A5A3 File Offset: 0x009087A3
		// (set) Token: 0x0602280F RID: 141327 RVA: 0x0090A5B7 File Offset: 0x009087B7
		public unsafe FVector WaterSourcePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x06022810 RID: 141328 RVA: 0x0090A5CC File Offset: 0x009087CC
		// (set) Token: 0x06022811 RID: 141329 RVA: 0x0090A5DC File Offset: 0x009087DC
		public unsafe float WaterSourceYield
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x06022812 RID: 141330 RVA: 0x0090A5ED File Offset: 0x009087ED
		// (set) Token: 0x06022813 RID: 141331 RVA: 0x0090A5FD File Offset: 0x009087FD
		public unsafe float WaterSouceSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x06022814 RID: 141332 RVA: 0x0090A60E File Offset: 0x0090880E
		// (set) Token: 0x06022815 RID: 141333 RVA: 0x0090A61E File Offset: 0x0090881E
		public unsafe int PixelForSimSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_63);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_4_C.__PropertyOffset_63) = value;
			}
		}

		// Token: 0x06022816 RID: 141334 RVA: 0x0090A62F File Offset: 0x0090882F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReStartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__ReStartSim_NativeFunctionPtr, null);
		}

		// Token: 0x06022817 RID: 141335 RVA: 0x0090A644 File Offset: 0x00908844
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HideRenderWaterMesh(bool HideRenderWater)
		{
			BP_WaterSimulation_4_C.__HideRenderWaterMesh_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__HideRenderWaterMesh_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__HideRenderWaterMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__HideRenderWaterMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HideRenderWater = HideRenderWater;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__HideRenderWaterMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022818 RID: 141336 RVA: 0x0090A68A File Offset: 0x0090888A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalcHeightmap()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__CalcHeightmap_NativeFunctionPtr, null);
		}

		// Token: 0x06022819 RID: 141337 RVA: 0x0090A69E File Offset: 0x0090889E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMPCParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__SetMPCParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0602281A RID: 141338 RVA: 0x0090A6B2 File Offset: 0x009088B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x0602281B RID: 141339 RVA: 0x0090A6C6 File Offset: 0x009088C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x0602281C RID: 141340 RVA: 0x0090A6DA File Offset: 0x009088DA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearWater()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__ClearWater_NativeFunctionPtr, null);
		}

		// Token: 0x0602281D RID: 141341 RVA: 0x0090A6F0 File Offset: 0x009088F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMaterialParameter(UMaterialInterface Material, UTexture VelocityHeightFoam, ref UMaterialInstanceDynamic MaterialInstance)
		{
			BP_WaterSimulation_4_C.__SetMaterialParameter_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__SetMaterialParameter_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__SetMaterialParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			ptr->VelocityHeightFoam = ((VelocityHeightFoam != null) ? VelocityHeightFoam.NativePtr : IntPtr.Zero);
			ref BP_WaterSimulation_4_C.__SetMaterialParameter_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = MaterialInstance;
			ptr2.MaterialInstance = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr);
			MaterialInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->MaterialInstance);
		}

		// Token: 0x0602281E RID: 141342 RVA: 0x0090A780 File Offset: 0x00908980
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602281F RID: 141343 RVA: 0x0090A794 File Offset: 0x00908994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_4_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022820 RID: 141344 RVA: 0x0090A7AC File Offset: 0x009089AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReceiveParticleData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_WaterSimulation_4_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_WaterSimulation_4_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022821 RID: 141345 RVA: 0x0090A83C File Offset: 0x00908A3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveParticleData_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_WaterSimulation_4_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_4_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_WaterSimulation_4_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022822 RID: 141346 RVA: 0x0090A8CB File Offset: 0x00908ACB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022823 RID: 141347 RVA: 0x0090A8DF File Offset: 0x00908ADF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_4_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022824 RID: 141348 RVA: 0x0090A8F4 File Offset: 0x00908AF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterSimulation_4_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022825 RID: 141349 RVA: 0x0090A93C File Offset: 0x00908B3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterSimulation_4_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_4_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022826 RID: 141350 RVA: 0x0090A983 File Offset: 0x00908B83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022827 RID: 141351 RVA: 0x0090A998 File Offset: 0x00908B98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022828 RID: 141352 RVA: 0x0090AA54 File Offset: 0x00908C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022829 RID: 141353 RVA: 0x0090AAE0 File Offset: 0x00908CE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602282A RID: 141354 RVA: 0x0090AB9C File Offset: 0x00908D9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_4_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602282B RID: 141355 RVA: 0x0090AC25 File Offset: 0x00908E25
		protected BP_WaterSimulation_4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010EC5 RID: 69317
		internal static int __InterfaceOffset_INiagaraParticleCallbackHandler;

		// Token: 0x04010EC6 RID: 69318
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_4.BP_WaterSimulation_4_C";

		// Token: 0x04010EC7 RID: 69319
		private static IntPtr _ClassPtr;

		// Token: 0x04010EC8 RID: 69320
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010EC9 RID: 69321
		internal static int __PropertyOffset_1;

		// Token: 0x04010ECA RID: 69322
		internal static int __PropertyOffset_2;

		// Token: 0x04010ECB RID: 69323
		internal static int __PropertyOffset_3;

		// Token: 0x04010ECC RID: 69324
		internal static int __PropertyOffset_4;

		// Token: 0x04010ECD RID: 69325
		internal static int __PropertyOffset_5;

		// Token: 0x04010ECE RID: 69326
		internal static int __PropertyOffset_6;

		// Token: 0x04010ECF RID: 69327
		internal static int __PropertyOffset_7;

		// Token: 0x04010ED0 RID: 69328
		internal static int __PropertyOffset_8;

		// Token: 0x04010ED1 RID: 69329
		internal static int __PropertyOffset_9;

		// Token: 0x04010ED2 RID: 69330
		internal static int __PropertyOffset_10;

		// Token: 0x04010ED3 RID: 69331
		internal static int __PropertyOffset_11;

		// Token: 0x04010ED4 RID: 69332
		internal static int __PropertyOffset_12;

		// Token: 0x04010ED5 RID: 69333
		internal static int __PropertyOffset_13;

		// Token: 0x04010ED6 RID: 69334
		internal static int __PropertyOffset_14;

		// Token: 0x04010ED7 RID: 69335
		internal static int __PropertyOffset_15;

		// Token: 0x04010ED8 RID: 69336
		internal static int __PropertyOffset_16;

		// Token: 0x04010ED9 RID: 69337
		internal static int __PropertyOffset_17;

		// Token: 0x04010EDA RID: 69338
		internal static int __PropertyOffset_18;

		// Token: 0x04010EDB RID: 69339
		internal static int __PropertyOffset_19;

		// Token: 0x04010EDC RID: 69340
		internal static int __PropertyOffset_20;

		// Token: 0x04010EDD RID: 69341
		internal static int __PropertyOffset_21;

		// Token: 0x04010EDE RID: 69342
		internal static int __PropertyOffset_22;

		// Token: 0x04010EDF RID: 69343
		internal static int __PropertyOffset_23;

		// Token: 0x04010EE0 RID: 69344
		internal static int __PropertyOffset_24;

		// Token: 0x04010EE1 RID: 69345
		internal static int __PropertyOffset_25;

		// Token: 0x04010EE2 RID: 69346
		internal static int __PropertyOffset_26;

		// Token: 0x04010EE3 RID: 69347
		internal static int __PropertyOffset_27;

		// Token: 0x04010EE4 RID: 69348
		internal static int __PropertyOffset_28;

		// Token: 0x04010EE5 RID: 69349
		internal static int __PropertyOffset_29;

		// Token: 0x04010EE6 RID: 69350
		internal static int __PropertyOffset_30;

		// Token: 0x04010EE7 RID: 69351
		internal static int __PropertyOffset_31;

		// Token: 0x04010EE8 RID: 69352
		internal static int __PropertyOffset_32;

		// Token: 0x04010EE9 RID: 69353
		internal static int __PropertyOffset_33;

		// Token: 0x04010EEA RID: 69354
		internal static int __PropertyOffset_34;

		// Token: 0x04010EEB RID: 69355
		internal static int __PropertyOffset_35;

		// Token: 0x04010EEC RID: 69356
		internal static int __PropertyOffset_36;

		// Token: 0x04010EED RID: 69357
		internal static int __PropertyOffset_37;

		// Token: 0x04010EEE RID: 69358
		internal static int __PropertyOffset_38;

		// Token: 0x04010EEF RID: 69359
		internal static int __PropertyOffset_39;

		// Token: 0x04010EF0 RID: 69360
		internal static int __PropertyOffset_40;

		// Token: 0x04010EF1 RID: 69361
		internal static int __PropertyOffset_41;

		// Token: 0x04010EF2 RID: 69362
		internal static int __PropertyOffset_42;

		// Token: 0x04010EF3 RID: 69363
		internal static int __PropertyOffset_43;

		// Token: 0x04010EF4 RID: 69364
		internal static int __PropertyOffset_44;

		// Token: 0x04010EF5 RID: 69365
		internal static int __PropertyOffset_45;

		// Token: 0x04010EF6 RID: 69366
		internal static int __PropertyOffset_46;

		// Token: 0x04010EF7 RID: 69367
		internal static int __PropertyOffset_47;

		// Token: 0x04010EF8 RID: 69368
		internal static int __PropertyOffset_48;

		// Token: 0x04010EF9 RID: 69369
		internal static int __PropertyOffset_49;

		// Token: 0x04010EFA RID: 69370
		internal static int __PropertyOffset_50;

		// Token: 0x04010EFB RID: 69371
		internal static int __PropertyOffset_51;

		// Token: 0x04010EFC RID: 69372
		internal static int __PropertyOffset_52;

		// Token: 0x04010EFD RID: 69373
		internal static int __PropertyOffset_53;

		// Token: 0x04010EFE RID: 69374
		internal static int __PropertyOffset_54;

		// Token: 0x04010EFF RID: 69375
		internal static int __PropertyOffset_55;

		// Token: 0x04010F00 RID: 69376
		internal static int __PropertyOffset_56;

		// Token: 0x04010F01 RID: 69377
		internal static int __PropertyOffset_57;

		// Token: 0x04010F02 RID: 69378
		internal static int __PropertyOffset_58;

		// Token: 0x04010F03 RID: 69379
		internal static int __PropertyOffset_59;

		// Token: 0x04010F04 RID: 69380
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Hidden_Actors;

		// Token: 0x04010F05 RID: 69381
		internal static int __PropertyOffset_60;

		// Token: 0x04010F06 RID: 69382
		internal static int __PropertyOffset_61;

		// Token: 0x04010F07 RID: 69383
		internal static int __PropertyOffset_62;

		// Token: 0x04010F08 RID: 69384
		internal static int __PropertyOffset_63;

		// Token: 0x04010F09 RID: 69385
		private static IntPtr __ReStartSim_NativeFunctionPtr;

		// Token: 0x04010F0A RID: 69386
		private static IntPtr __HideRenderWaterMesh_NativeFunctionPtr;

		// Token: 0x04010F0B RID: 69387
		private static IntPtr __CalcHeightmap_NativeFunctionPtr;

		// Token: 0x04010F0C RID: 69388
		private static IntPtr __SetMPCParameters_NativeFunctionPtr;

		// Token: 0x04010F0D RID: 69389
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x04010F0E RID: 69390
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04010F0F RID: 69391
		private static IntPtr __ClearWater_NativeFunctionPtr;

		// Token: 0x04010F10 RID: 69392
		private static IntPtr __SetMaterialParameter_NativeFunctionPtr;

		// Token: 0x04010F11 RID: 69393
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010F12 RID: 69394
		private static IntPtr __ReceiveParticleData_NativeFunctionPtr;

		// Token: 0x04010F13 RID: 69395
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010F14 RID: 69396
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010F15 RID: 69397
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010F16 RID: 69398
		private static IntPtr __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010F17 RID: 69399
		private static IntPtr __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010F18 RID: 69400
		private static IntPtr __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010F19 RID: 69401
		private static IntPtr __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D84 RID: 40324
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HideRenderWaterMesh_FunctionParams
		{
			// Token: 0x0403152A RID: 202026
			[FieldOffset(0)]
			public bool HideRenderWater;
		}

		// Token: 0x02009D85 RID: 40325
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetMaterialParameter_FunctionParams
		{
			// Token: 0x0403152B RID: 202027
			[FieldOffset(0)]
			public IntPtr Material;

			// Token: 0x0403152C RID: 202028
			[FieldOffset(8)]
			public IntPtr VelocityHeightFoam;

			// Token: 0x0403152D RID: 202029
			[FieldOffset(16)]
			public IntPtr MaterialInstance;
		}

		// Token: 0x02009D86 RID: 40326
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveParticleData_FunctionParams
		{
			// Token: 0x0403152E RID: 202030
			[FieldOffset(0)]
			public byte Data;

			// Token: 0x0403152F RID: 202031
			[FieldOffset(16)]
			public IntPtr NiagaraSystem;
		}

		// Token: 0x02009D87 RID: 40327
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031530 RID: 202032
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D88 RID: 40328
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031531 RID: 202033
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031532 RID: 202034
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031533 RID: 202035
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031534 RID: 202036
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031535 RID: 202037
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031536 RID: 202038
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D89 RID: 40329
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031537 RID: 202039
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031538 RID: 202040
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031539 RID: 202041
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403153A RID: 202042
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009D8A RID: 40330
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403153B RID: 202043
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403153C RID: 202044
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403153D RID: 202045
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403153E RID: 202046
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403153F RID: 202047
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031540 RID: 202048
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D8B RID: 40331
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031541 RID: 202049
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031542 RID: 202050
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031543 RID: 202051
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031544 RID: 202052
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}

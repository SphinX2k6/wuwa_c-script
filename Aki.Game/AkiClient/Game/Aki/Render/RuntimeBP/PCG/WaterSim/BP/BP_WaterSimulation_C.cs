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
	// Token: 0x02003BD8 RID: 15320
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation.BP_WaterSimulation_C")]
	[UnrealStructLayout(1856, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1848)]
	public class BP_WaterSimulation_C : AKuroBPActor, IUnrealUObject, IUnrealObject, INiagaraParticleCallbackHandler, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602282C RID: 141356 RVA: 0x0090AC2E File Offset: 0x00908E2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterSimulation_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation.BP_WaterSimulation_C");
			}
			return BP_WaterSimulation_C._ClassPtr;
		}

		// Token: 0x0602282D RID: 141357 RVA: 0x0090AC52 File Offset: 0x00908E52
		int INiagaraParticleCallbackHandler.InterfaceOffset()
		{
			return BP_WaterSimulation_C.__InterfaceOffset_INiagaraParticleCallbackHandler;
		}

		// Token: 0x0602282E RID: 141358 RVA: 0x0090AC5C File Offset: 0x00908E5C
		public BP_WaterSimulation_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602282F RID: 141359 RVA: 0x0090AC84 File Offset: 0x00908E84
		[NullableContext(1)]
		public BP_WaterSimulation_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x06022830 RID: 141360 RVA: 0x0090ACB7 File Offset: 0x00908EB7
		// (set) Token: 0x06022831 RID: 141361 RVA: 0x0090ACCB File Offset: 0x00908ECB
		public unsafe UBoxComponent WaterInteraction_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x06022832 RID: 141362 RVA: 0x0090ACE0 File Offset: 0x00908EE0
		// (set) Token: 0x06022833 RID: 141363 RVA: 0x0090ACF4 File Offset: 0x00908EF4
		public unsafe UStaticMeshComponent WaterInteractionCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x06022834 RID: 141364 RVA: 0x0090AD09 File Offset: 0x00908F09
		// (set) Token: 0x06022835 RID: 141365 RVA: 0x0090AD1D File Offset: 0x00908F1D
		public unsafe UStaticMeshComponent WaterSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x06022836 RID: 141366 RVA: 0x0090AD32 File Offset: 0x00908F32
		// (set) Token: 0x06022837 RID: 141367 RVA: 0x0090AD46 File Offset: 0x00908F46
		public unsafe UStaticMeshComponent PreView_Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x06022838 RID: 141368 RVA: 0x0090AD5B File Offset: 0x00908F5B
		// (set) Token: 0x06022839 RID: 141369 RVA: 0x0090AD6F File Offset: 0x00908F6F
		public unsafe UBoxComponent Sim_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x0602283A RID: 141370 RVA: 0x0090AD84 File Offset: 0x00908F84
		// (set) Token: 0x0602283B RID: 141371 RVA: 0x0090AD98 File Offset: 0x00908F98
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x0602283C RID: 141372 RVA: 0x0090ADAD File Offset: 0x00908FAD
		// (set) Token: 0x0602283D RID: 141373 RVA: 0x0090ADBD File Offset: 0x00908FBD
		public unsafe bool Sim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x0602283E RID: 141374 RVA: 0x0090ADCE File Offset: 0x00908FCE
		// (set) Token: 0x0602283F RID: 141375 RVA: 0x0090ADDE File Offset: 0x00908FDE
		public unsafe bool SeqControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x06022840 RID: 141376 RVA: 0x0090ADEF File Offset: 0x00908FEF
		// (set) Token: 0x06022841 RID: 141377 RVA: 0x0090ADFF File Offset: 0x00908FFF
		public unsafe bool DAControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x06022842 RID: 141378 RVA: 0x0090AE10 File Offset: 0x00909010
		// (set) Token: 0x06022843 RID: 141379 RVA: 0x0090AE24 File Offset: 0x00909024
		public unsafe FVector SimBoxOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x06022844 RID: 141380 RVA: 0x0090AE39 File Offset: 0x00909039
		// (set) Token: 0x06022845 RID: 141381 RVA: 0x0090AE4D File Offset: 0x0090904D
		public unsafe FVector SimBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x06022846 RID: 141382 RVA: 0x0090AE62 File Offset: 0x00909062
		// (set) Token: 0x06022847 RID: 141383 RVA: 0x0090AE72 File Offset: 0x00909072
		public unsafe int SimSize_M_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x06022848 RID: 141384 RVA: 0x0090AE83 File Offset: 0x00909083
		// (set) Token: 0x06022849 RID: 141385 RVA: 0x0090AE97 File Offset: 0x00909097
		public unsafe UMaterial M_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0602284A RID: 141386 RVA: 0x0090AEAC File Offset: 0x009090AC
		// (set) Token: 0x0602284B RID: 141387 RVA: 0x0090AEC0 File Offset: 0x009090C0
		public unsafe UMaterial M_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0602284C RID: 141388 RVA: 0x0090AED5 File Offset: 0x009090D5
		// (set) Token: 0x0602284D RID: 141389 RVA: 0x0090AEE9 File Offset: 0x009090E9
		public unsafe UMaterial M_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0602284E RID: 141390 RVA: 0x0090AEFE File Offset: 0x009090FE
		// (set) Token: 0x0602284F RID: 141391 RVA: 0x0090AF12 File Offset: 0x00909112
		public unsafe UMaterial M_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x06022850 RID: 141392 RVA: 0x0090AF27 File Offset: 0x00909127
		// (set) Token: 0x06022851 RID: 141393 RVA: 0x0090AF3B File Offset: 0x0090913B
		public unsafe UMaterial M_Water_Clear
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x06022852 RID: 141394 RVA: 0x0090AF50 File Offset: 0x00909150
		// (set) Token: 0x06022853 RID: 141395 RVA: 0x0090AF64 File Offset: 0x00909164
		public unsafe UMaterialInstanceDynamic MI_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x06022854 RID: 141396 RVA: 0x0090AF79 File Offset: 0x00909179
		// (set) Token: 0x06022855 RID: 141397 RVA: 0x0090AF8D File Offset: 0x0090918D
		public unsafe UMaterialInstanceDynamic MI_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x06022856 RID: 141398 RVA: 0x0090AFA2 File Offset: 0x009091A2
		// (set) Token: 0x06022857 RID: 141399 RVA: 0x0090AFB6 File Offset: 0x009091B6
		public unsafe UMaterialInstanceDynamic MI_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x06022858 RID: 141400 RVA: 0x0090AFCB File Offset: 0x009091CB
		// (set) Token: 0x06022859 RID: 141401 RVA: 0x0090AFDF File Offset: 0x009091DF
		public unsafe UMaterialInstanceDynamic MI_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x0602285A RID: 141402 RVA: 0x0090AFF4 File Offset: 0x009091F4
		// (set) Token: 0x0602285B RID: 141403 RVA: 0x0090B008 File Offset: 0x00909208
		public unsafe UTexture2D RT_HeightMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x0602285C RID: 141404 RVA: 0x0090B01D File Offset: 0x0090921D
		// (set) Token: 0x0602285D RID: 141405 RVA: 0x0090B031 File Offset: 0x00909231
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x0602285E RID: 141406 RVA: 0x0090B046 File Offset: 0x00909246
		// (set) Token: 0x0602285F RID: 141407 RVA: 0x0090B05A File Offset: 0x0090925A
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Temp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x06022860 RID: 141408 RVA: 0x0090B06F File Offset: 0x0090926F
		// (set) Token: 0x06022861 RID: 141409 RVA: 0x0090B083 File Offset: 0x00909283
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x06022862 RID: 141410 RVA: 0x0090B098 File Offset: 0x00909298
		// (set) Token: 0x06022863 RID: 141411 RVA: 0x0090B0AC File Offset: 0x009092AC
		public unsafe AStaticMeshActor RenderActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x06022864 RID: 141412 RVA: 0x0090B0C1 File Offset: 0x009092C1
		// (set) Token: 0x06022865 RID: 141413 RVA: 0x0090B0D5 File Offset: 0x009092D5
		public unsafe UMaterialInterface M_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x06022866 RID: 141414 RVA: 0x0090B0EA File Offset: 0x009092EA
		// (set) Token: 0x06022867 RID: 141415 RVA: 0x0090B0FE File Offset: 0x009092FE
		public unsafe UMaterialInstanceDynamic MI_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x06022868 RID: 141416 RVA: 0x0090B113 File Offset: 0x00909313
		// (set) Token: 0x06022869 RID: 141417 RVA: 0x0090B123 File Offset: 0x00909323
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x0602286A RID: 141418 RVA: 0x0090B134 File Offset: 0x00909334
		// (set) Token: 0x0602286B RID: 141419 RVA: 0x0090B144 File Offset: 0x00909344
		public unsafe float DurationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x0602286C RID: 141420 RVA: 0x0090B155 File Offset: 0x00909355
		// (set) Token: 0x0602286D RID: 141421 RVA: 0x0090B169 File Offset: 0x00909369
		public unsafe FLinearColor WaterSuorcePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0602286E RID: 141422 RVA: 0x0090B17E File Offset: 0x0090937E
		// (set) Token: 0x0602286F RID: 141423 RVA: 0x0090B192 File Offset: 0x00909392
		public unsafe FLinearColor WaterSuorcePos1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x06022870 RID: 141424 RVA: 0x0090B1A7 File Offset: 0x009093A7
		// (set) Token: 0x06022871 RID: 141425 RVA: 0x0090B1B7 File Offset: 0x009093B7
		public unsafe float WaterActorHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x06022872 RID: 141426 RVA: 0x0090B1C8 File Offset: 0x009093C8
		// (set) Token: 0x06022873 RID: 141427 RVA: 0x0090B1D8 File Offset: 0x009093D8
		public unsafe float PlayerWaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x06022874 RID: 141428 RVA: 0x0090B1E9 File Offset: 0x009093E9
		// (set) Token: 0x06022875 RID: 141429 RVA: 0x0090B1F9 File Offset: 0x009093F9
		public unsafe float CameraWaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x06022876 RID: 141430 RVA: 0x0090B20A File Offset: 0x0090940A
		// (set) Token: 0x06022877 RID: 141431 RVA: 0x0090B21E File Offset: 0x0090941E
		public unsafe FVector PlayerWaterNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x06022878 RID: 141432 RVA: 0x0090B233 File Offset: 0x00909433
		// (set) Token: 0x06022879 RID: 141433 RVA: 0x0090B243 File Offset: 0x00909443
		public unsafe float PlayerWaterVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x0602287A RID: 141434 RVA: 0x0090B254 File Offset: 0x00909454
		// (set) Token: 0x0602287B RID: 141435 RVA: 0x0090B264 File Offset: 0x00909464
		public unsafe float CameraWaterVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x0602287C RID: 141436 RVA: 0x0090B275 File Offset: 0x00909475
		// (set) Token: 0x0602287D RID: 141437 RVA: 0x0090B289 File Offset: 0x00909489
		public unsafe FVector CameraWaterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x0602287E RID: 141438 RVA: 0x0090B29E File Offset: 0x0090949E
		// (set) Token: 0x0602287F RID: 141439 RVA: 0x0090B2B2 File Offset: 0x009094B2
		public unsafe FVector PlayerWaterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x06022880 RID: 141440 RVA: 0x0090B2C7 File Offset: 0x009094C7
		// (set) Token: 0x06022881 RID: 141441 RVA: 0x0090B2D7 File Offset: 0x009094D7
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x06022882 RID: 141442 RVA: 0x0090B2E8 File Offset: 0x009094E8
		// (set) Token: 0x06022883 RID: 141443 RVA: 0x0090B2F8 File Offset: 0x009094F8
		public unsafe float AccelerationClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x06022884 RID: 141444 RVA: 0x0090B309 File Offset: 0x00909509
		// (set) Token: 0x06022885 RID: 141445 RVA: 0x0090B319 File Offset: 0x00909519
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x06022886 RID: 141446 RVA: 0x0090B32A File Offset: 0x0090952A
		// (set) Token: 0x06022887 RID: 141447 RVA: 0x0090B33A File Offset: 0x0090953A
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x06022888 RID: 141448 RVA: 0x0090B34B File Offset: 0x0090954B
		// (set) Token: 0x06022889 RID: 141449 RVA: 0x0090B35B File Offset: 0x0090955B
		public unsafe float VelocityClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0602288A RID: 141450 RVA: 0x0090B36C File Offset: 0x0090956C
		// (set) Token: 0x0602288B RID: 141451 RVA: 0x0090B37C File Offset: 0x0090957C
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0602288C RID: 141452 RVA: 0x0090B38D File Offset: 0x0090958D
		// (set) Token: 0x0602288D RID: 141453 RVA: 0x0090B39D File Offset: 0x0090959D
		public unsafe int LoopNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x0602288E RID: 141454 RVA: 0x0090B3AE File Offset: 0x009095AE
		// (set) Token: 0x0602288F RID: 141455 RVA: 0x0090B3C2 File Offset: 0x009095C2
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x06022890 RID: 141456 RVA: 0x0090B3D7 File Offset: 0x009095D7
		// (set) Token: 0x06022891 RID: 141457 RVA: 0x0090B3EB File Offset: 0x009095EB
		public unsafe BP_HeightmapReadback_C BP_HeightmapReadback
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_HeightmapReadback_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x06022892 RID: 141458 RVA: 0x0090B400 File Offset: 0x00909600
		// (set) Token: 0x06022893 RID: 141459 RVA: 0x0090B410 File Offset: 0x00909610
		public unsafe int Readback_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x06022894 RID: 141460 RVA: 0x0090B421 File Offset: 0x00909621
		// (set) Token: 0x06022895 RID: 141461 RVA: 0x0090B431 File Offset: 0x00909631
		public unsafe int Readback_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x06022896 RID: 141462 RVA: 0x0090B442 File Offset: 0x00909642
		// (set) Token: 0x06022897 RID: 141463 RVA: 0x0090B452 File Offset: 0x00909652
		public unsafe float Readback_Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x06022898 RID: 141464 RVA: 0x0090B463 File Offset: 0x00909663
		// (set) Token: 0x06022899 RID: 141465 RVA: 0x0090B477 File Offset: 0x00909677
		public unsafe FVector4 CaptureRangeMax_Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0602289A RID: 141466 RVA: 0x0090B48C File Offset: 0x0090968C
		// (set) Token: 0x0602289B RID: 141467 RVA: 0x0090B49C File Offset: 0x0090969C
		public unsafe bool DynamicWaterFlow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0602289C RID: 141468 RVA: 0x0090B4AD File Offset: 0x009096AD
		// (set) Token: 0x0602289D RID: 141469 RVA: 0x0090B4BD File Offset: 0x009096BD
		public unsafe bool OverlapVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0602289E RID: 141470 RVA: 0x0090B4CE File Offset: 0x009096CE
		// (set) Token: 0x0602289F RID: 141471 RVA: 0x0090B4DE File Offset: 0x009096DE
		public unsafe bool Is_Simulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x060228A0 RID: 141472 RVA: 0x0090B4EF File Offset: 0x009096EF
		// (set) Token: 0x060228A1 RID: 141473 RVA: 0x0090B4FF File Offset: 0x009096FF
		public unsafe float CameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x060228A2 RID: 141474 RVA: 0x0090B510 File Offset: 0x00909710
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HideRenderWaterMesh(bool HideRenderWater)
		{
			BP_WaterSimulation_C.__HideRenderWaterMesh_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__HideRenderWaterMesh_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WaterSimulation_C.__HideRenderWaterMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__HideRenderWaterMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HideRenderWater = HideRenderWater;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__HideRenderWaterMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060228A3 RID: 141475 RVA: 0x0090B556 File Offset: 0x00909756
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalcHeightmap()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__CalcHeightmap_NativeFunctionPtr, null);
		}

		// Token: 0x060228A4 RID: 141476 RVA: 0x0090B56A File Offset: 0x0090976A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMPCParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__SetMPCParameters_NativeFunctionPtr, null);
		}

		// Token: 0x060228A5 RID: 141477 RVA: 0x0090B57E File Offset: 0x0090977E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x060228A6 RID: 141478 RVA: 0x0090B592 File Offset: 0x00909792
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x060228A7 RID: 141479 RVA: 0x0090B5A6 File Offset: 0x009097A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearWater()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__ClearWater_NativeFunctionPtr, null);
		}

		// Token: 0x060228A8 RID: 141480 RVA: 0x0090B5BC File Offset: 0x009097BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMaterialParameter(UMaterialInterface Material, UTexture VelocityHeightFoam, ref UMaterialInstanceDynamic MaterialInstance)
		{
			BP_WaterSimulation_C.__SetMaterialParameter_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__SetMaterialParameter_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_WaterSimulation_C.__SetMaterialParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			ptr->VelocityHeightFoam = ((VelocityHeightFoam != null) ? VelocityHeightFoam.NativePtr : IntPtr.Zero);
			ref BP_WaterSimulation_C.__SetMaterialParameter_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = MaterialInstance;
			ptr2.MaterialInstance = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr);
			MaterialInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->MaterialInstance);
		}

		// Token: 0x060228A9 RID: 141481 RVA: 0x0090B64C File Offset: 0x0090984C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060228AA RID: 141482 RVA: 0x0090B660 File Offset: 0x00909860
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060228AB RID: 141483 RVA: 0x0090B678 File Offset: 0x00909878
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReceiveParticleData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_WaterSimulation_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_WaterSimulation_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_WaterSimulation_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060228AC RID: 141484 RVA: 0x0090B708 File Offset: 0x00909908
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveParticleData_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_WaterSimulation_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_WaterSimulation_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_WaterSimulation_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060228AD RID: 141485 RVA: 0x0090B797 File Offset: 0x00909997
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060228AE RID: 141486 RVA: 0x0090B7AB File Offset: 0x009099AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060228AF RID: 141487 RVA: 0x0090B7C0 File Offset: 0x009099C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterSimulation_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulation_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060228B0 RID: 141488 RVA: 0x0090B808 File Offset: 0x00909A08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterSimulation_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulation_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060228B1 RID: 141489 RVA: 0x0090B84F File Offset: 0x00909A4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060228B2 RID: 141490 RVA: 0x0090B864 File Offset: 0x00909A64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060228B3 RID: 141491 RVA: 0x0090B920 File Offset: 0x00909B20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060228B4 RID: 141492 RVA: 0x0090B9AC File Offset: 0x00909BAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060228B5 RID: 141493 RVA: 0x0090BA68 File Offset: 0x00909C68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060228B6 RID: 141494 RVA: 0x0090BAF1 File Offset: 0x00909CF1
		protected BP_WaterSimulation_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F1A RID: 69402
		internal static int __InterfaceOffset_INiagaraParticleCallbackHandler;

		// Token: 0x04010F1B RID: 69403
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation.BP_WaterSimulation_C";

		// Token: 0x04010F1C RID: 69404
		private static IntPtr _ClassPtr;

		// Token: 0x04010F1D RID: 69405
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F1E RID: 69406
		internal static int __PropertyOffset_1;

		// Token: 0x04010F1F RID: 69407
		internal static int __PropertyOffset_2;

		// Token: 0x04010F20 RID: 69408
		internal static int __PropertyOffset_3;

		// Token: 0x04010F21 RID: 69409
		internal static int __PropertyOffset_4;

		// Token: 0x04010F22 RID: 69410
		internal static int __PropertyOffset_5;

		// Token: 0x04010F23 RID: 69411
		internal static int __PropertyOffset_6;

		// Token: 0x04010F24 RID: 69412
		internal static int __PropertyOffset_7;

		// Token: 0x04010F25 RID: 69413
		internal static int __PropertyOffset_8;

		// Token: 0x04010F26 RID: 69414
		internal static int __PropertyOffset_9;

		// Token: 0x04010F27 RID: 69415
		internal static int __PropertyOffset_10;

		// Token: 0x04010F28 RID: 69416
		internal static int __PropertyOffset_11;

		// Token: 0x04010F29 RID: 69417
		internal static int __PropertyOffset_12;

		// Token: 0x04010F2A RID: 69418
		internal static int __PropertyOffset_13;

		// Token: 0x04010F2B RID: 69419
		internal static int __PropertyOffset_14;

		// Token: 0x04010F2C RID: 69420
		internal static int __PropertyOffset_15;

		// Token: 0x04010F2D RID: 69421
		internal static int __PropertyOffset_16;

		// Token: 0x04010F2E RID: 69422
		internal static int __PropertyOffset_17;

		// Token: 0x04010F2F RID: 69423
		internal static int __PropertyOffset_18;

		// Token: 0x04010F30 RID: 69424
		internal static int __PropertyOffset_19;

		// Token: 0x04010F31 RID: 69425
		internal static int __PropertyOffset_20;

		// Token: 0x04010F32 RID: 69426
		internal static int __PropertyOffset_21;

		// Token: 0x04010F33 RID: 69427
		internal static int __PropertyOffset_22;

		// Token: 0x04010F34 RID: 69428
		internal static int __PropertyOffset_23;

		// Token: 0x04010F35 RID: 69429
		internal static int __PropertyOffset_24;

		// Token: 0x04010F36 RID: 69430
		internal static int __PropertyOffset_25;

		// Token: 0x04010F37 RID: 69431
		internal static int __PropertyOffset_26;

		// Token: 0x04010F38 RID: 69432
		internal static int __PropertyOffset_27;

		// Token: 0x04010F39 RID: 69433
		internal static int __PropertyOffset_28;

		// Token: 0x04010F3A RID: 69434
		internal static int __PropertyOffset_29;

		// Token: 0x04010F3B RID: 69435
		internal static int __PropertyOffset_30;

		// Token: 0x04010F3C RID: 69436
		internal static int __PropertyOffset_31;

		// Token: 0x04010F3D RID: 69437
		internal static int __PropertyOffset_32;

		// Token: 0x04010F3E RID: 69438
		internal static int __PropertyOffset_33;

		// Token: 0x04010F3F RID: 69439
		internal static int __PropertyOffset_34;

		// Token: 0x04010F40 RID: 69440
		internal static int __PropertyOffset_35;

		// Token: 0x04010F41 RID: 69441
		internal static int __PropertyOffset_36;

		// Token: 0x04010F42 RID: 69442
		internal static int __PropertyOffset_37;

		// Token: 0x04010F43 RID: 69443
		internal static int __PropertyOffset_38;

		// Token: 0x04010F44 RID: 69444
		internal static int __PropertyOffset_39;

		// Token: 0x04010F45 RID: 69445
		internal static int __PropertyOffset_40;

		// Token: 0x04010F46 RID: 69446
		internal static int __PropertyOffset_41;

		// Token: 0x04010F47 RID: 69447
		internal static int __PropertyOffset_42;

		// Token: 0x04010F48 RID: 69448
		internal static int __PropertyOffset_43;

		// Token: 0x04010F49 RID: 69449
		internal static int __PropertyOffset_44;

		// Token: 0x04010F4A RID: 69450
		internal static int __PropertyOffset_45;

		// Token: 0x04010F4B RID: 69451
		internal static int __PropertyOffset_46;

		// Token: 0x04010F4C RID: 69452
		internal static int __PropertyOffset_47;

		// Token: 0x04010F4D RID: 69453
		internal static int __PropertyOffset_48;

		// Token: 0x04010F4E RID: 69454
		internal static int __PropertyOffset_49;

		// Token: 0x04010F4F RID: 69455
		internal static int __PropertyOffset_50;

		// Token: 0x04010F50 RID: 69456
		internal static int __PropertyOffset_51;

		// Token: 0x04010F51 RID: 69457
		internal static int __PropertyOffset_52;

		// Token: 0x04010F52 RID: 69458
		internal static int __PropertyOffset_53;

		// Token: 0x04010F53 RID: 69459
		internal static int __PropertyOffset_54;

		// Token: 0x04010F54 RID: 69460
		internal static int __PropertyOffset_55;

		// Token: 0x04010F55 RID: 69461
		internal static int __PropertyOffset_56;

		// Token: 0x04010F56 RID: 69462
		internal static int __PropertyOffset_57;

		// Token: 0x04010F57 RID: 69463
		private static IntPtr __HideRenderWaterMesh_NativeFunctionPtr;

		// Token: 0x04010F58 RID: 69464
		private static IntPtr __CalcHeightmap_NativeFunctionPtr;

		// Token: 0x04010F59 RID: 69465
		private static IntPtr __SetMPCParameters_NativeFunctionPtr;

		// Token: 0x04010F5A RID: 69466
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x04010F5B RID: 69467
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04010F5C RID: 69468
		private static IntPtr __ClearWater_NativeFunctionPtr;

		// Token: 0x04010F5D RID: 69469
		private static IntPtr __SetMaterialParameter_NativeFunctionPtr;

		// Token: 0x04010F5E RID: 69470
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010F5F RID: 69471
		private static IntPtr __ReceiveParticleData_NativeFunctionPtr;

		// Token: 0x04010F60 RID: 69472
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010F61 RID: 69473
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010F62 RID: 69474
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010F63 RID: 69475
		private static IntPtr __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010F64 RID: 69476
		private static IntPtr __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010F65 RID: 69477
		private static IntPtr __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010F66 RID: 69478
		private static IntPtr __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D8C RID: 40332
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HideRenderWaterMesh_FunctionParams
		{
			// Token: 0x04031545 RID: 202053
			[FieldOffset(0)]
			public bool HideRenderWater;
		}

		// Token: 0x02009D8D RID: 40333
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetMaterialParameter_FunctionParams
		{
			// Token: 0x04031546 RID: 202054
			[FieldOffset(0)]
			public IntPtr Material;

			// Token: 0x04031547 RID: 202055
			[FieldOffset(8)]
			public IntPtr VelocityHeightFoam;

			// Token: 0x04031548 RID: 202056
			[FieldOffset(16)]
			public IntPtr MaterialInstance;
		}

		// Token: 0x02009D8E RID: 40334
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveParticleData_FunctionParams
		{
			// Token: 0x04031549 RID: 202057
			[FieldOffset(0)]
			public byte Data;

			// Token: 0x0403154A RID: 202058
			[FieldOffset(16)]
			public IntPtr NiagaraSystem;
		}

		// Token: 0x02009D8F RID: 40335
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403154B RID: 202059
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D90 RID: 40336
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403154C RID: 202060
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403154D RID: 202061
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403154E RID: 202062
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403154F RID: 202063
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031550 RID: 202064
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031551 RID: 202065
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D91 RID: 40337
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031552 RID: 202066
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031553 RID: 202067
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031554 RID: 202068
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031555 RID: 202069
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009D92 RID: 40338
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031556 RID: 202070
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031557 RID: 202071
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031558 RID: 202072
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031559 RID: 202073
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403155A RID: 202074
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403155B RID: 202075
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D93 RID: 40339
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403155C RID: 202076
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403155D RID: 202077
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403155E RID: 202078
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403155F RID: 202079
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}

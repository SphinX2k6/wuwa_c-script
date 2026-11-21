using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Sequence.Seq_BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003124 RID: 12580
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_Cinematics_Tick.BP_Cinematics_Tick_C")]
	[UnrealStructLayout(2008, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2002)]
	public class BP_Cinematics_Tick_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EDEB RID: 126443 RVA: 0x0091FFB1 File Offset: 0x0091E1B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cinematics_Tick_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_Cinematics_Tick.BP_Cinematics_Tick_C");
			}
			return BP_Cinematics_Tick_C._ClassPtr;
		}

		// Token: 0x0601EDEC RID: 126444 RVA: 0x0091FFD8 File Offset: 0x0091E1D8
		public BP_Cinematics_Tick_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cinematics_Tick_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EDED RID: 126445 RVA: 0x00920000 File Offset: 0x0091E200
		[NullableContext(1)]
		public BP_Cinematics_Tick_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cinematics_Tick_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0601EDEE RID: 126446 RVA: 0x00920033 File Offset: 0x0091E233
		// (set) Token: 0x0601EDEF RID: 126447 RVA: 0x00920047 File Offset: 0x0091E247
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0601EDF0 RID: 126448 RVA: 0x0092005C File Offset: 0x0091E25C
		// (set) Token: 0x0601EDF1 RID: 126449 RVA: 0x0092006C File Offset: 0x0091E26C
		public unsafe int Is_Tick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Is_Tick);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Is_Tick) = value;
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0601EDF2 RID: 126450 RVA: 0x0092007D File Offset: 0x0091E27D
		// (set) Token: 0x0601EDF3 RID: 126451 RVA: 0x00920091 File Offset: 0x0091E291
		public unsafe ABaseCharacter BP_Character_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_Character_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_Character_1, value);
			}
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0601EDF4 RID: 126452 RVA: 0x009200A6 File Offset: 0x0091E2A6
		// (set) Token: 0x0601EDF5 RID: 126453 RVA: 0x009200B6 File Offset: 0x0091E2B6
		public unsafe float Character_1_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_1_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_1_LightYaw) = value;
			}
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0601EDF6 RID: 126454 RVA: 0x009200C7 File Offset: 0x0091E2C7
		// (set) Token: 0x0601EDF7 RID: 126455 RVA: 0x009200D7 File Offset: 0x0091E2D7
		public unsafe float Character_1_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_1_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_1_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0601EDF8 RID: 126456 RVA: 0x009200E8 File Offset: 0x0091E2E8
		// (set) Token: 0x0601EDF9 RID: 126457 RVA: 0x009200FC File Offset: 0x0091E2FC
		public unsafe ABaseCharacter BP_Character_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_Character_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_Character_2, value);
			}
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0601EDFA RID: 126458 RVA: 0x00920111 File Offset: 0x0091E311
		// (set) Token: 0x0601EDFB RID: 126459 RVA: 0x00920121 File Offset: 0x0091E321
		public unsafe float Character_2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_2_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_2_LightYaw) = value;
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0601EDFC RID: 126460 RVA: 0x00920132 File Offset: 0x0091E332
		// (set) Token: 0x0601EDFD RID: 126461 RVA: 0x00920142 File Offset: 0x0091E342
		public unsafe float Character_2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_2_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_2_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0601EDFE RID: 126462 RVA: 0x00920153 File Offset: 0x0091E353
		// (set) Token: 0x0601EDFF RID: 126463 RVA: 0x00920167 File Offset: 0x0091E367
		public unsafe ABaseCharacter BP_Character_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_Character_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_Character_3, value);
			}
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0601EE00 RID: 126464 RVA: 0x0092017C File Offset: 0x0091E37C
		// (set) Token: 0x0601EE01 RID: 126465 RVA: 0x0092018C File Offset: 0x0091E38C
		public unsafe float Character_3_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_3_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_3_LightYaw) = value;
			}
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0601EE02 RID: 126466 RVA: 0x0092019D File Offset: 0x0091E39D
		// (set) Token: 0x0601EE03 RID: 126467 RVA: 0x009201AD File Offset: 0x0091E3AD
		public unsafe float Character_3_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_3_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_3_FaceLightYaw) = value;
			}
		}

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0601EE04 RID: 126468 RVA: 0x009201BE File Offset: 0x0091E3BE
		// (set) Token: 0x0601EE05 RID: 126469 RVA: 0x009201D2 File Offset: 0x0091E3D2
		public unsafe ABaseCharacter BP_Character_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_Character_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_Character_4, value);
			}
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0601EE06 RID: 126470 RVA: 0x009201E7 File Offset: 0x0091E3E7
		// (set) Token: 0x0601EE07 RID: 126471 RVA: 0x009201F7 File Offset: 0x0091E3F7
		public unsafe float Character_4_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_4_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_4_LightYaw) = value;
			}
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0601EE08 RID: 126472 RVA: 0x00920208 File Offset: 0x0091E408
		// (set) Token: 0x0601EE09 RID: 126473 RVA: 0x00920218 File Offset: 0x0091E418
		public unsafe float Character_4_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_4_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Character_4_FaceLightYaw) = value;
			}
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0601EE0A RID: 126474 RVA: 0x00920229 File Offset: 0x0091E429
		// (set) Token: 0x0601EE0B RID: 126475 RVA: 0x0092023D File Offset: 0x0091E43D
		public unsafe ASkeletalMeshActor SkeletalMesh_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_1, value);
			}
		}

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0601EE0C RID: 126476 RVA: 0x00920252 File Offset: 0x0091E452
		// (set) Token: 0x0601EE0D RID: 126477 RVA: 0x00920262 File Offset: 0x0091E462
		public unsafe float SkeletalMesh_1_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_1_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_1_LightYaw) = value;
			}
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0601EE0E RID: 126478 RVA: 0x00920273 File Offset: 0x0091E473
		// (set) Token: 0x0601EE0F RID: 126479 RVA: 0x00920283 File Offset: 0x0091E483
		public unsafe float SkeletalMesh_1_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_1_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_1_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0601EE10 RID: 126480 RVA: 0x00920294 File Offset: 0x0091E494
		// (set) Token: 0x0601EE11 RID: 126481 RVA: 0x009202A8 File Offset: 0x0091E4A8
		public unsafe ASkeletalMeshActor SkeletalMesh_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_2, value);
			}
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0601EE12 RID: 126482 RVA: 0x009202BD File Offset: 0x0091E4BD
		// (set) Token: 0x0601EE13 RID: 126483 RVA: 0x009202CD File Offset: 0x0091E4CD
		public unsafe float SkeletalMesh_2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_2_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_2_LightYaw) = value;
			}
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0601EE14 RID: 126484 RVA: 0x009202DE File Offset: 0x0091E4DE
		// (set) Token: 0x0601EE15 RID: 126485 RVA: 0x009202EE File Offset: 0x0091E4EE
		public unsafe float SkeletalMesh_2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_2_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_2_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0601EE16 RID: 126486 RVA: 0x009202FF File Offset: 0x0091E4FF
		// (set) Token: 0x0601EE17 RID: 126487 RVA: 0x00920313 File Offset: 0x0091E513
		public unsafe ASkeletalMeshActor SkeletalMesh_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_3, value);
			}
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0601EE18 RID: 126488 RVA: 0x00920328 File Offset: 0x0091E528
		// (set) Token: 0x0601EE19 RID: 126489 RVA: 0x00920338 File Offset: 0x0091E538
		public unsafe float SkeletalMesh_3_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_3_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_3_LightYaw) = value;
			}
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0601EE1A RID: 126490 RVA: 0x00920349 File Offset: 0x0091E549
		// (set) Token: 0x0601EE1B RID: 126491 RVA: 0x00920359 File Offset: 0x0091E559
		public unsafe float SkeletalMesh_3_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_3_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_3_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0601EE1C RID: 126492 RVA: 0x0092036A File Offset: 0x0091E56A
		// (set) Token: 0x0601EE1D RID: 126493 RVA: 0x0092037E File Offset: 0x0091E57E
		public unsafe ASkeletalMeshActor SkeletalMesh_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_4, value);
			}
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0601EE1E RID: 126494 RVA: 0x00920393 File Offset: 0x0091E593
		// (set) Token: 0x0601EE1F RID: 126495 RVA: 0x009203A3 File Offset: 0x0091E5A3
		public unsafe float SkeletalMesh_4_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_4_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_4_LightYaw) = value;
			}
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0601EE20 RID: 126496 RVA: 0x009203B4 File Offset: 0x0091E5B4
		// (set) Token: 0x0601EE21 RID: 126497 RVA: 0x009203C4 File Offset: 0x0091E5C4
		public unsafe float SkeletalMesh_4_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_4_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_4_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0601EE22 RID: 126498 RVA: 0x009203D5 File Offset: 0x0091E5D5
		// (set) Token: 0x0601EE23 RID: 126499 RVA: 0x009203E9 File Offset: 0x0091E5E9
		public unsafe ASkeletalMeshActor SkeletalMesh_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_5, value);
			}
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0601EE24 RID: 126500 RVA: 0x009203FE File Offset: 0x0091E5FE
		// (set) Token: 0x0601EE25 RID: 126501 RVA: 0x0092040E File Offset: 0x0091E60E
		public unsafe float SkeletalMesh_5_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_5_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_5_LightYaw) = value;
			}
		}

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0601EE26 RID: 126502 RVA: 0x0092041F File Offset: 0x0091E61F
		// (set) Token: 0x0601EE27 RID: 126503 RVA: 0x0092042F File Offset: 0x0091E62F
		public unsafe float SkeletalMesh_5_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_5_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_5_FaceLightYaw) = value;
			}
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0601EE28 RID: 126504 RVA: 0x00920440 File Offset: 0x0091E640
		// (set) Token: 0x0601EE29 RID: 126505 RVA: 0x00920454 File Offset: 0x0091E654
		public unsafe ASkeletalMeshActor SkeletalMesh_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_6, value);
			}
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0601EE2A RID: 126506 RVA: 0x00920469 File Offset: 0x0091E669
		// (set) Token: 0x0601EE2B RID: 126507 RVA: 0x00920479 File Offset: 0x0091E679
		public unsafe float SkeletalMesh_6_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_6_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_6_LightYaw) = value;
			}
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0601EE2C RID: 126508 RVA: 0x0092048A File Offset: 0x0091E68A
		// (set) Token: 0x0601EE2D RID: 126509 RVA: 0x0092049A File Offset: 0x0091E69A
		public unsafe float SkeletalMesh_6_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_6_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SkeletalMesh_6_FaceLightYaw) = value;
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0601EE2E RID: 126510 RVA: 0x009204AB File Offset: 0x0091E6AB
		// (set) Token: 0x0601EE2F RID: 126511 RVA: 0x009204BF File Offset: 0x0091E6BF
		public unsafe USkeletalMeshComponent UISceneRole
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_UISceneRole);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_UISceneRole, value);
			}
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0601EE30 RID: 126512 RVA: 0x009204D4 File Offset: 0x0091E6D4
		// (set) Token: 0x0601EE31 RID: 126513 RVA: 0x009204E8 File Offset: 0x0091E6E8
		public unsafe USkeletalMeshComponent UISceneRole_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_UISceneRole_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_UISceneRole_2, value);
			}
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0601EE32 RID: 126514 RVA: 0x009204FD File Offset: 0x0091E6FD
		// (set) Token: 0x0601EE33 RID: 126515 RVA: 0x00920511 File Offset: 0x0091E711
		public unsafe AActor BP_NanzhuSeqV2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2, value);
			}
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0601EE34 RID: 126516 RVA: 0x00920526 File Offset: 0x0091E726
		// (set) Token: 0x0601EE35 RID: 126517 RVA: 0x00920536 File Offset: 0x0091E736
		public unsafe float BP_NanzhuSeqV2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2_LightYaw) = value;
			}
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0601EE36 RID: 126518 RVA: 0x00920547 File Offset: 0x0091E747
		// (set) Token: 0x0601EE37 RID: 126519 RVA: 0x00920557 File Offset: 0x0091E757
		public unsafe float BP_NanzhuSeqV2_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2_LightPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2_LightPitch) = value;
			}
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0601EE38 RID: 126520 RVA: 0x00920568 File Offset: 0x0091E768
		// (set) Token: 0x0601EE39 RID: 126521 RVA: 0x00920578 File Offset: 0x0091E778
		public unsafe float BP_NanzhuSeqV2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0601EE3A RID: 126522 RVA: 0x00920589 File Offset: 0x0091E789
		// (set) Token: 0x0601EE3B RID: 126523 RVA: 0x00920599 File Offset: 0x0091E799
		public unsafe bool BP_NanzhuSeqV2_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2_UsePointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NanzhuSeqV2_UsePointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0601EE3C RID: 126524 RVA: 0x009205AA File Offset: 0x0091E7AA
		// (set) Token: 0x0601EE3D RID: 126525 RVA: 0x009205BE File Offset: 0x0091E7BE
		public unsafe AActor BP_NvzhuSeqV2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2, value);
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0601EE3E RID: 126526 RVA: 0x009205D3 File Offset: 0x0091E7D3
		// (set) Token: 0x0601EE3F RID: 126527 RVA: 0x009205E3 File Offset: 0x0091E7E3
		public unsafe float BP_NvzhuSeqV2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2_LightYaw) = value;
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0601EE40 RID: 126528 RVA: 0x009205F4 File Offset: 0x0091E7F4
		// (set) Token: 0x0601EE41 RID: 126529 RVA: 0x00920604 File Offset: 0x0091E804
		public unsafe float BP_NvzhuSeqV2_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2_LightPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2_LightPitch) = value;
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0601EE42 RID: 126530 RVA: 0x00920615 File Offset: 0x0091E815
		// (set) Token: 0x0601EE43 RID: 126531 RVA: 0x00920625 File Offset: 0x0091E825
		public unsafe float BP_NvzhuSeqV2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2_FaceLightYaw) = value;
			}
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0601EE44 RID: 126532 RVA: 0x00920636 File Offset: 0x0091E836
		// (set) Token: 0x0601EE45 RID: 126533 RVA: 0x00920646 File Offset: 0x0091E846
		public unsafe bool BP_NvzhuSeqV2_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2_UsePointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BP_NvzhuSeqV2_UsePointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0601EE46 RID: 126534 RVA: 0x00920657 File Offset: 0x0091E857
		// (set) Token: 0x0601EE47 RID: 126535 RVA: 0x0092066B File Offset: 0x0091E86B
		public unsafe AActor Target_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_1, value);
			}
		}

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0601EE48 RID: 126536 RVA: 0x00920680 File Offset: 0x0091E880
		// (set) Token: 0x0601EE49 RID: 126537 RVA: 0x00920690 File Offset: 0x0091E890
		public unsafe float Target_1_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_1_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_1_LightYaw) = value;
			}
		}

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0601EE4A RID: 126538 RVA: 0x009206A1 File Offset: 0x0091E8A1
		// (set) Token: 0x0601EE4B RID: 126539 RVA: 0x009206B1 File Offset: 0x0091E8B1
		public unsafe float Target_1_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_1_LightPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_1_LightPitch) = value;
			}
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0601EE4C RID: 126540 RVA: 0x009206C2 File Offset: 0x0091E8C2
		// (set) Token: 0x0601EE4D RID: 126541 RVA: 0x009206D2 File Offset: 0x0091E8D2
		public unsafe float Target_1_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_1_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_1_FaceLightYaw) = value;
			}
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0601EE4E RID: 126542 RVA: 0x009206E3 File Offset: 0x0091E8E3
		// (set) Token: 0x0601EE4F RID: 126543 RVA: 0x009206F3 File Offset: 0x0091E8F3
		public unsafe bool Target_1_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_1_UsePointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_1_UsePointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0601EE50 RID: 126544 RVA: 0x00920704 File Offset: 0x0091E904
		// (set) Token: 0x0601EE51 RID: 126545 RVA: 0x00920718 File Offset: 0x0091E918
		public unsafe AActor Target_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_2, value);
			}
		}

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0601EE52 RID: 126546 RVA: 0x0092072D File Offset: 0x0091E92D
		// (set) Token: 0x0601EE53 RID: 126547 RVA: 0x0092073D File Offset: 0x0091E93D
		public unsafe float Target_2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_2_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_2_LightYaw) = value;
			}
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0601EE54 RID: 126548 RVA: 0x0092074E File Offset: 0x0091E94E
		// (set) Token: 0x0601EE55 RID: 126549 RVA: 0x0092075E File Offset: 0x0091E95E
		public unsafe float Target_2_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_2_LightPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_2_LightPitch) = value;
			}
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0601EE56 RID: 126550 RVA: 0x0092076F File Offset: 0x0091E96F
		// (set) Token: 0x0601EE57 RID: 126551 RVA: 0x0092077F File Offset: 0x0091E97F
		public unsafe float Target_2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_2_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_2_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0601EE58 RID: 126552 RVA: 0x00920790 File Offset: 0x0091E990
		// (set) Token: 0x0601EE59 RID: 126553 RVA: 0x009207A0 File Offset: 0x0091E9A0
		public unsafe bool Target_2_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_2_UsePointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_2_UsePointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0601EE5A RID: 126554 RVA: 0x009207B1 File Offset: 0x0091E9B1
		// (set) Token: 0x0601EE5B RID: 126555 RVA: 0x009207C5 File Offset: 0x0091E9C5
		public unsafe AActor Target_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_3, value);
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0601EE5C RID: 126556 RVA: 0x009207DA File Offset: 0x0091E9DA
		// (set) Token: 0x0601EE5D RID: 126557 RVA: 0x009207EA File Offset: 0x0091E9EA
		public unsafe float Target_3_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_3_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_3_LightYaw) = value;
			}
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0601EE5E RID: 126558 RVA: 0x009207FB File Offset: 0x0091E9FB
		// (set) Token: 0x0601EE5F RID: 126559 RVA: 0x0092080B File Offset: 0x0091EA0B
		public unsafe float Target_3_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_3_LightPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_3_LightPitch) = value;
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0601EE60 RID: 126560 RVA: 0x0092081C File Offset: 0x0091EA1C
		// (set) Token: 0x0601EE61 RID: 126561 RVA: 0x0092082C File Offset: 0x0091EA2C
		public unsafe float Target_3_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_3_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_3_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0601EE62 RID: 126562 RVA: 0x0092083D File Offset: 0x0091EA3D
		// (set) Token: 0x0601EE63 RID: 126563 RVA: 0x0092084D File Offset: 0x0091EA4D
		public unsafe bool Target_3_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_3_UsePointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_3_UsePointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0601EE64 RID: 126564 RVA: 0x0092085E File Offset: 0x0091EA5E
		// (set) Token: 0x0601EE65 RID: 126565 RVA: 0x00920872 File Offset: 0x0091EA72
		public unsafe AActor Target_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_4, value);
			}
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0601EE66 RID: 126566 RVA: 0x00920887 File Offset: 0x0091EA87
		// (set) Token: 0x0601EE67 RID: 126567 RVA: 0x00920897 File Offset: 0x0091EA97
		public unsafe float Target_4_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_4_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_4_LightYaw) = value;
			}
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0601EE68 RID: 126568 RVA: 0x009208A8 File Offset: 0x0091EAA8
		// (set) Token: 0x0601EE69 RID: 126569 RVA: 0x009208B8 File Offset: 0x0091EAB8
		public unsafe float Target_4_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_4_LightPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_4_LightPitch) = value;
			}
		}

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0601EE6A RID: 126570 RVA: 0x009208C9 File Offset: 0x0091EAC9
		// (set) Token: 0x0601EE6B RID: 126571 RVA: 0x009208D9 File Offset: 0x0091EAD9
		public unsafe float Target_4_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_4_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_4_FaceLightYaw) = value;
			}
		}

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0601EE6C RID: 126572 RVA: 0x009208EA File Offset: 0x0091EAEA
		// (set) Token: 0x0601EE6D RID: 126573 RVA: 0x009208FA File Offset: 0x0091EAFA
		public unsafe bool Target_4_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_4_UsePointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_4_UsePointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0601EE6E RID: 126574 RVA: 0x0092090B File Offset: 0x0091EB0B
		// (set) Token: 0x0601EE6F RID: 126575 RVA: 0x0092091F File Offset: 0x0091EB1F
		public unsafe AActor Target_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_5, value);
			}
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0601EE70 RID: 126576 RVA: 0x00920934 File Offset: 0x0091EB34
		// (set) Token: 0x0601EE71 RID: 126577 RVA: 0x00920944 File Offset: 0x0091EB44
		public unsafe float Target_5_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_5_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_5_LightYaw) = value;
			}
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0601EE72 RID: 126578 RVA: 0x00920955 File Offset: 0x0091EB55
		// (set) Token: 0x0601EE73 RID: 126579 RVA: 0x00920965 File Offset: 0x0091EB65
		public unsafe float Target_5_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_5_LightPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_5_LightPitch) = value;
			}
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0601EE74 RID: 126580 RVA: 0x00920976 File Offset: 0x0091EB76
		// (set) Token: 0x0601EE75 RID: 126581 RVA: 0x00920986 File Offset: 0x0091EB86
		public unsafe float Target_5_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_5_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_5_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0601EE76 RID: 126582 RVA: 0x00920997 File Offset: 0x0091EB97
		// (set) Token: 0x0601EE77 RID: 126583 RVA: 0x009209A7 File Offset: 0x0091EBA7
		public unsafe bool Target_5_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_5_UsePointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_5_UsePointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0601EE78 RID: 126584 RVA: 0x009209B8 File Offset: 0x0091EBB8
		// (set) Token: 0x0601EE79 RID: 126585 RVA: 0x009209CC File Offset: 0x0091EBCC
		public unsafe AActor Target_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_Target_6, value);
			}
		}

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0601EE7A RID: 126586 RVA: 0x009209E1 File Offset: 0x0091EBE1
		// (set) Token: 0x0601EE7B RID: 126587 RVA: 0x009209F1 File Offset: 0x0091EBF1
		public unsafe float Target_6_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_6_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_6_LightYaw) = value;
			}
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0601EE7C RID: 126588 RVA: 0x00920A02 File Offset: 0x0091EC02
		// (set) Token: 0x0601EE7D RID: 126589 RVA: 0x00920A12 File Offset: 0x0091EC12
		public unsafe float Target_6_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_6_LightPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_6_LightPitch) = value;
			}
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0601EE7E RID: 126590 RVA: 0x00920A23 File Offset: 0x0091EC23
		// (set) Token: 0x0601EE7F RID: 126591 RVA: 0x00920A33 File Offset: 0x0091EC33
		public unsafe float Target_6_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_6_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_6_FaceLightYaw) = value;
			}
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0601EE80 RID: 126592 RVA: 0x00920A44 File Offset: 0x0091EC44
		// (set) Token: 0x0601EE81 RID: 126593 RVA: 0x00920A54 File Offset: 0x0091EC54
		public unsafe bool IsHideMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsHideMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsHideMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0601EE82 RID: 126594 RVA: 0x00920A65 File Offset: 0x0091EC65
		// (set) Token: 0x0601EE83 RID: 126595 RVA: 0x00920A75 File Offset: 0x0091EC75
		public unsafe bool IsHideEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsHideEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsHideEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0601EE84 RID: 126596 RVA: 0x00920A86 File Offset: 0x0091EC86
		// (set) Token: 0x0601EE85 RID: 126597 RVA: 0x00920A96 File Offset: 0x0091EC96
		public unsafe float LightShakeSpeed_Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakeSpeed_Float);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakeSpeed_Float) = value;
			}
		}

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0601EE86 RID: 126598 RVA: 0x00920AA7 File Offset: 0x0091ECA7
		// (set) Token: 0x0601EE87 RID: 126599 RVA: 0x00920AB7 File Offset: 0x0091ECB7
		public unsafe float LightShakeSpeed_Float_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakeSpeed_Float_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakeSpeed_Float_Default) = value;
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0601EE88 RID: 126600 RVA: 0x00920AC8 File Offset: 0x0091ECC8
		// (set) Token: 0x0601EE89 RID: 126601 RVA: 0x00920AD8 File Offset: 0x0091ECD8
		public unsafe float LightShakePositionX_Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakePositionX_Float);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakePositionX_Float) = value;
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0601EE8A RID: 126602 RVA: 0x00920AE9 File Offset: 0x0091ECE9
		// (set) Token: 0x0601EE8B RID: 126603 RVA: 0x00920AF9 File Offset: 0x0091ECF9
		public unsafe float LightShakePositionX_Float_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakePositionX_Float_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakePositionX_Float_Default) = value;
			}
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0601EE8C RID: 126604 RVA: 0x00920B0A File Offset: 0x0091ED0A
		// (set) Token: 0x0601EE8D RID: 126605 RVA: 0x00920B1A File Offset: 0x0091ED1A
		public unsafe float LightShakePositionY_Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakePositionY_Float);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakePositionY_Float) = value;
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0601EE8E RID: 126606 RVA: 0x00920B2B File Offset: 0x0091ED2B
		// (set) Token: 0x0601EE8F RID: 126607 RVA: 0x00920B3B File Offset: 0x0091ED3B
		public unsafe float LightShakePositionY_Float_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakePositionY_Float_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakePositionY_Float_Default) = value;
			}
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0601EE90 RID: 126608 RVA: 0x00920B4C File Offset: 0x0091ED4C
		// (set) Token: 0x0601EE91 RID: 126609 RVA: 0x00920B5C File Offset: 0x0091ED5C
		public unsafe float LightShakeScale_Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakeScale_Float);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakeScale_Float) = value;
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0601EE92 RID: 126610 RVA: 0x00920B6D File Offset: 0x0091ED6D
		// (set) Token: 0x0601EE93 RID: 126611 RVA: 0x00920B7D File Offset: 0x0091ED7D
		public unsafe float LightShakeScale_Float_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakeScale_Float_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightShakeScale_Float_Default) = value;
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0601EE94 RID: 126612 RVA: 0x00920B8E File Offset: 0x0091ED8E
		// (set) Token: 0x0601EE95 RID: 126613 RVA: 0x00920BA2 File Offset: 0x0091EDA2
		public unsafe FVector MainTexColorTint_Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_MainTexColorTint_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_MainTexColorTint_Vector) = value;
			}
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0601EE96 RID: 126614 RVA: 0x00920BB7 File Offset: 0x0091EDB7
		// (set) Token: 0x0601EE97 RID: 126615 RVA: 0x00920BCB File Offset: 0x0091EDCB
		public unsafe FVector MainTexColorTint_Vector_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_MainTexColorTint_Vector_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_MainTexColorTint_Vector_Default) = value;
			}
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0601EE98 RID: 126616 RVA: 0x00920BE0 File Offset: 0x0091EDE0
		// (set) Token: 0x0601EE99 RID: 126617 RVA: 0x00920BF0 File Offset: 0x0091EDF0
		public unsafe bool MaterialControllerToggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_MaterialControllerToggle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_MaterialControllerToggle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0601EE9A RID: 126618 RVA: 0x00920C01 File Offset: 0x0091EE01
		// (set) Token: 0x0601EE9B RID: 126619 RVA: 0x00920C11 File Offset: 0x0091EE11
		public unsafe bool ReceiveRoleLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_ReceiveRoleLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_ReceiveRoleLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0601EE9C RID: 126620 RVA: 0x00920C22 File Offset: 0x0091EE22
		// (set) Token: 0x0601EE9D RID: 126621 RVA: 0x00920C32 File Offset: 0x0091EE32
		public unsafe bool IsDisableCameraCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsDisableCameraCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsDisableCameraCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0601EE9E RID: 126622 RVA: 0x00920C43 File Offset: 0x0091EE43
		// (set) Token: 0x0601EE9F RID: 126623 RVA: 0x00920C53 File Offset: 0x0091EE53
		public unsafe bool IsAutonomousHideMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsAutonomousHideMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsAutonomousHideMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0601EEA0 RID: 126624 RVA: 0x00920C64 File Offset: 0x0091EE64
		// (set) Token: 0x0601EEA1 RID: 126625 RVA: 0x00920C74 File Offset: 0x0091EE74
		public unsafe bool IsAutonomousHideEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsAutonomousHideEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsAutonomousHideEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0601EEA2 RID: 126626 RVA: 0x00920C85 File Offset: 0x0091EE85
		// (set) Token: 0x0601EEA3 RID: 126627 RVA: 0x00920C95 File Offset: 0x0091EE95
		public unsafe bool IsAutonomousHideNpcMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsAutonomousHideNpcMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsAutonomousHideNpcMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0601EEA4 RID: 126628 RVA: 0x00920CA6 File Offset: 0x0091EEA6
		// (set) Token: 0x0601EEA5 RID: 126629 RVA: 0x00920CB6 File Offset: 0x0091EEB6
		public unsafe bool IsAutonomousHideNpcEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsAutonomousHideNpcEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsAutonomousHideNpcEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0601EEA6 RID: 126630 RVA: 0x00920CC7 File Offset: 0x0091EEC7
		// (set) Token: 0x0601EEA7 RID: 126631 RVA: 0x00920CD7 File Offset: 0x0091EED7
		public unsafe bool IsHideNpcMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsHideNpcMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsHideNpcMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0601EEA8 RID: 126632 RVA: 0x00920CE8 File Offset: 0x0091EEE8
		// (set) Token: 0x0601EEA9 RID: 126633 RVA: 0x00920CF8 File Offset: 0x0091EEF8
		public unsafe bool IsHideNpcEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsHideNpcEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_IsHideNpcEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0601EEAA RID: 126634 RVA: 0x00920D09 File Offset: 0x0091EF09
		// (set) Token: 0x0601EEAB RID: 126635 RVA: 0x00920D19 File Offset: 0x0091EF19
		public unsafe float HideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_HideDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_HideDistance) = value;
			}
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0601EEAC RID: 126636 RVA: 0x00920D2A File Offset: 0x0091EF2A
		// (set) Token: 0x0601EEAD RID: 126637 RVA: 0x00920D3E File Offset: 0x0091EF3E
		[Nullable(1)]
		public unsafe string BasisBoneName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BasisBoneName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_BasisBoneName)), value);
			}
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0601EEAE RID: 126638 RVA: 0x00920D53 File Offset: 0x0091EF53
		// (set) Token: 0x0601EEAF RID: 126639 RVA: 0x00920D63 File Offset: 0x0091EF63
		public unsafe bool Target_6_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_6_UsePointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_Target_6_UsePointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x0601EEB0 RID: 126640 RVA: 0x00920D74 File Offset: 0x0091EF74
		// (set) Token: 0x0601EEB1 RID: 126641 RVA: 0x00920D84 File Offset: 0x0091EF84
		public unsafe bool LightYawNotAddRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightYawNotAddRotate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_LightYawNotAddRotate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0601EEB2 RID: 126642 RVA: 0x00920D95 File Offset: 0x0091EF95
		// (set) Token: 0x0601EEB3 RID: 126643 RVA: 0x00920DA9 File Offset: 0x0091EFA9
		public unsafe FVector2D SubCameraSize1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraSize1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraSize1) = value;
			}
		}

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x0601EEB4 RID: 126644 RVA: 0x00920DBE File Offset: 0x0091EFBE
		// (set) Token: 0x0601EEB5 RID: 126645 RVA: 0x00920DD2 File Offset: 0x0091EFD2
		[Nullable(1)]
		public unsafe string SubCameraName1
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraName1)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraName1)), value);
			}
		}

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0601EEB6 RID: 126646 RVA: 0x00920DE7 File Offset: 0x0091EFE7
		// (set) Token: 0x0601EEB7 RID: 126647 RVA: 0x00920DFB File Offset: 0x0091EFFB
		public unsafe FVector2D SubCameraLocation1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraLocation1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraLocation1) = value;
			}
		}

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0601EEB8 RID: 126648 RVA: 0x00920E10 File Offset: 0x0091F010
		// (set) Token: 0x0601EEB9 RID: 126649 RVA: 0x00920E24 File Offset: 0x0091F024
		public unsafe FVector2D SubCameraSize2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraSize2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraSize2) = value;
			}
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0601EEBA RID: 126650 RVA: 0x00920E39 File Offset: 0x0091F039
		// (set) Token: 0x0601EEBB RID: 126651 RVA: 0x00920E4D File Offset: 0x0091F04D
		[Nullable(1)]
		public unsafe string SubCameraName2
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraName2)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraName2)), value);
			}
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0601EEBC RID: 126652 RVA: 0x00920E62 File Offset: 0x0091F062
		// (set) Token: 0x0601EEBD RID: 126653 RVA: 0x00920E76 File Offset: 0x0091F076
		public unsafe FVector2D SubCameraLocation2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraLocation2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SubCameraLocation2) = value;
			}
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0601EEBE RID: 126654 RVA: 0x00920E8B File Offset: 0x0091F08B
		// (set) Token: 0x0601EEBF RID: 126655 RVA: 0x00920E9B File Offset: 0x0091F09B
		public unsafe bool SeamlessSubCamera1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SeamlessSubCamera1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SeamlessSubCamera1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0601EEC0 RID: 126656 RVA: 0x00920EAC File Offset: 0x0091F0AC
		// (set) Token: 0x0601EEC1 RID: 126657 RVA: 0x00920EBC File Offset: 0x0091F0BC
		public unsafe bool SeamlessSubCamera2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SeamlessSubCamera2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_SeamlessSubCamera2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EEC2 RID: 126658 RVA: 0x00920ECD File Offset: 0x0091F0CD
		[SkipLocalsInit]
		public virtual void UpdateSeparateCamera()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UpdateSeparateCamera_NativeFunctionPtr, null);
		}

		// Token: 0x0601EEC3 RID: 126659 RVA: 0x00920EE4 File Offset: 0x0091F0E4
		[SkipLocalsInit]
		public unsafe virtual void UpdateCameraCollision(AActor InActor, bool IsDisableCameraCollision)
		{
			BP_Cinematics_Tick_C.__UpdateCameraCollision_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__UpdateCameraCollision_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__UpdateCameraCollision_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__UpdateCameraCollision_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->IsDisableCameraCollision = IsDisableCameraCollision;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UpdateCameraCollision_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EEC4 RID: 126660 RVA: 0x00920F40 File Offset: 0x0091F140
		[SkipLocalsInit]
		public unsafe virtual FVector EulerToForward(float Pitch, float Yaw)
		{
			BP_Cinematics_Tick_C.__EulerToForward_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__EulerToForward_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__EulerToForward_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__EulerToForward_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pitch = Pitch;
			ptr->Yaw = Yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__EulerToForward_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601EEC5 RID: 126661 RVA: 0x00920F94 File Offset: 0x0091F194
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void UpdateMeshAndEffectState([Nullable(2)] AActor InActor, bool IsHideMesh, bool IsHideEffect, bool isDestroyed, bool IsHideNpcMesh, bool IsHideNpcEffect, float HideDistance, string BasisBoneName)
		{
			BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->IsHideMesh = IsHideMesh;
			ptr->IsHideEffect = IsHideEffect;
			ptr->isDestroyed = isDestroyed;
			ptr->IsHideNpcMesh = IsHideNpcMesh;
			ptr->IsHideNpcEffect = IsHideNpcEffect;
			ptr->HideDistance = HideDistance;
			FString.CopyFrom((void*)(&ptr->BasisBoneName), BasisBoneName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EEC6 RID: 126662 RVA: 0x00921038 File Offset: 0x0091F238
		[SkipLocalsInit]
		public unsafe virtual void SetActorLight(AActor InActor, float LightYaw, float LightPitch, float FaceLightYaw, bool IsRevert, bool UsePointLight)
		{
			BP_Cinematics_Tick_C.__SetActorLight_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__SetActorLight_FunctionParams[(UIntPtr)255] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__SetActorLight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__SetActorLight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->LightYaw = LightYaw;
			ptr->LightPitch = LightPitch;
			ptr->FaceLightYaw = FaceLightYaw;
			ptr->IsRevert = IsRevert;
			ptr->UsePointLight = UsePointLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__SetActorLight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EEC7 RID: 126663 RVA: 0x009210B8 File Offset: 0x0091F2B8
		[SkipLocalsInit]
		public unsafe virtual void ProcessCombinNPC(BP_SeqNPC_C Mesh, float LightYaw, float FaceLightYaw)
		{
			BP_Cinematics_Tick_C.__ProcessCombinNPC_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__ProcessCombinNPC_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__ProcessCombinNPC_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__ProcessCombinNPC_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->LightYaw = LightYaw;
			ptr->FaceLightYaw = FaceLightYaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ProcessCombinNPC_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EEC8 RID: 126664 RVA: 0x0092111C File Offset: 0x0091F31C
		[SkipLocalsInit]
		public unsafe virtual void RevertLightDirection(USkeletalMeshComponent Mesh)
		{
			BP_Cinematics_Tick_C.__RevertLightDirection_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__RevertLightDirection_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__RevertLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__RevertLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__RevertLightDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EEC9 RID: 126665 RVA: 0x00921174 File Offset: 0x0091F374
		[SkipLocalsInit]
		public unsafe virtual void SetLightDirection(USkeletalMeshComponent Mesh, float LightYaw, float LightPitch, float FaceLightYaw, bool UsePointLight)
		{
			BP_Cinematics_Tick_C.__SetLightDirection_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__SetLightDirection_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__SetLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->LightYaw = LightYaw;
			ptr->LightPitch = LightPitch;
			ptr->FaceLightYaw = FaceLightYaw;
			ptr->UsePointLight = UsePointLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EECA RID: 126666 RVA: 0x009211E7 File Offset: 0x0091F3E7
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EECB RID: 126667 RVA: 0x009211FB File Offset: 0x0091F3FB
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EECC RID: 126668 RVA: 0x00921210 File Offset: 0x0091F410
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EECD RID: 126669 RVA: 0x00921258 File Offset: 0x0091F458
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EECE RID: 126670 RVA: 0x009212A0 File Offset: 0x0091F4A0
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cinematics_Tick_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EECF RID: 126671 RVA: 0x009212E8 File Offset: 0x0091F4E8
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cinematics_Tick_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EED0 RID: 126672 RVA: 0x0092132E File Offset: 0x0091F52E
		[SkipLocalsInit]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601EED1 RID: 126673 RVA: 0x00921342 File Offset: 0x0091F542
		[SkipLocalsInit]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601EED2 RID: 126674 RVA: 0x00921356 File Offset: 0x0091F556
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EED3 RID: 126675 RVA: 0x0092136A File Offset: 0x0091F56A
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EED4 RID: 126676 RVA: 0x0092137E File Offset: 0x0091F57E
		protected BP_Cinematics_Tick_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401069D RID: 67229
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_Cinematics_Tick.BP_Cinematics_Tick_C";

		// Token: 0x0401069E RID: 67230
		private static IntPtr _ClassPtr;

		// Token: 0x0401069F RID: 67231
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106A0 RID: 67232
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040106A1 RID: 67233
		internal static int __PropertyOffset_Is_Tick;

		// Token: 0x040106A2 RID: 67234
		internal static int __PropertyOffset_BP_Character_1;

		// Token: 0x040106A3 RID: 67235
		internal static int __PropertyOffset_Character_1_LightYaw;

		// Token: 0x040106A4 RID: 67236
		internal static int __PropertyOffset_Character_1_FaceLightYaw;

		// Token: 0x040106A5 RID: 67237
		internal static int __PropertyOffset_BP_Character_2;

		// Token: 0x040106A6 RID: 67238
		internal static int __PropertyOffset_Character_2_LightYaw;

		// Token: 0x040106A7 RID: 67239
		internal static int __PropertyOffset_Character_2_FaceLightYaw;

		// Token: 0x040106A8 RID: 67240
		internal static int __PropertyOffset_BP_Character_3;

		// Token: 0x040106A9 RID: 67241
		internal static int __PropertyOffset_Character_3_LightYaw;

		// Token: 0x040106AA RID: 67242
		internal static int __PropertyOffset_Character_3_FaceLightYaw;

		// Token: 0x040106AB RID: 67243
		internal static int __PropertyOffset_BP_Character_4;

		// Token: 0x040106AC RID: 67244
		internal static int __PropertyOffset_Character_4_LightYaw;

		// Token: 0x040106AD RID: 67245
		internal static int __PropertyOffset_Character_4_FaceLightYaw;

		// Token: 0x040106AE RID: 67246
		internal static int __PropertyOffset_SkeletalMesh_1;

		// Token: 0x040106AF RID: 67247
		internal static int __PropertyOffset_SkeletalMesh_1_LightYaw;

		// Token: 0x040106B0 RID: 67248
		internal static int __PropertyOffset_SkeletalMesh_1_FaceLightYaw;

		// Token: 0x040106B1 RID: 67249
		internal static int __PropertyOffset_SkeletalMesh_2;

		// Token: 0x040106B2 RID: 67250
		internal static int __PropertyOffset_SkeletalMesh_2_LightYaw;

		// Token: 0x040106B3 RID: 67251
		internal static int __PropertyOffset_SkeletalMesh_2_FaceLightYaw;

		// Token: 0x040106B4 RID: 67252
		internal static int __PropertyOffset_SkeletalMesh_3;

		// Token: 0x040106B5 RID: 67253
		internal static int __PropertyOffset_SkeletalMesh_3_LightYaw;

		// Token: 0x040106B6 RID: 67254
		internal static int __PropertyOffset_SkeletalMesh_3_FaceLightYaw;

		// Token: 0x040106B7 RID: 67255
		internal static int __PropertyOffset_SkeletalMesh_4;

		// Token: 0x040106B8 RID: 67256
		internal static int __PropertyOffset_SkeletalMesh_4_LightYaw;

		// Token: 0x040106B9 RID: 67257
		internal static int __PropertyOffset_SkeletalMesh_4_FaceLightYaw;

		// Token: 0x040106BA RID: 67258
		internal static int __PropertyOffset_SkeletalMesh_5;

		// Token: 0x040106BB RID: 67259
		internal static int __PropertyOffset_SkeletalMesh_5_LightYaw;

		// Token: 0x040106BC RID: 67260
		internal static int __PropertyOffset_SkeletalMesh_5_FaceLightYaw;

		// Token: 0x040106BD RID: 67261
		internal static int __PropertyOffset_SkeletalMesh_6;

		// Token: 0x040106BE RID: 67262
		internal static int __PropertyOffset_SkeletalMesh_6_LightYaw;

		// Token: 0x040106BF RID: 67263
		internal static int __PropertyOffset_SkeletalMesh_6_FaceLightYaw;

		// Token: 0x040106C0 RID: 67264
		internal static int __PropertyOffset_UISceneRole;

		// Token: 0x040106C1 RID: 67265
		internal static int __PropertyOffset_UISceneRole_2;

		// Token: 0x040106C2 RID: 67266
		internal static int __PropertyOffset_BP_NanzhuSeqV2;

		// Token: 0x040106C3 RID: 67267
		internal static int __PropertyOffset_BP_NanzhuSeqV2_LightYaw;

		// Token: 0x040106C4 RID: 67268
		internal static int __PropertyOffset_BP_NanzhuSeqV2_LightPitch;

		// Token: 0x040106C5 RID: 67269
		internal static int __PropertyOffset_BP_NanzhuSeqV2_FaceLightYaw;

		// Token: 0x040106C6 RID: 67270
		internal static int __PropertyOffset_BP_NanzhuSeqV2_UsePointLight;

		// Token: 0x040106C7 RID: 67271
		internal static int __PropertyOffset_BP_NvzhuSeqV2;

		// Token: 0x040106C8 RID: 67272
		internal static int __PropertyOffset_BP_NvzhuSeqV2_LightYaw;

		// Token: 0x040106C9 RID: 67273
		internal static int __PropertyOffset_BP_NvzhuSeqV2_LightPitch;

		// Token: 0x040106CA RID: 67274
		internal static int __PropertyOffset_BP_NvzhuSeqV2_FaceLightYaw;

		// Token: 0x040106CB RID: 67275
		internal static int __PropertyOffset_BP_NvzhuSeqV2_UsePointLight;

		// Token: 0x040106CC RID: 67276
		internal static int __PropertyOffset_Target_1;

		// Token: 0x040106CD RID: 67277
		internal static int __PropertyOffset_Target_1_LightYaw;

		// Token: 0x040106CE RID: 67278
		internal static int __PropertyOffset_Target_1_LightPitch;

		// Token: 0x040106CF RID: 67279
		internal static int __PropertyOffset_Target_1_FaceLightYaw;

		// Token: 0x040106D0 RID: 67280
		internal static int __PropertyOffset_Target_1_UsePointLight;

		// Token: 0x040106D1 RID: 67281
		internal static int __PropertyOffset_Target_2;

		// Token: 0x040106D2 RID: 67282
		internal static int __PropertyOffset_Target_2_LightYaw;

		// Token: 0x040106D3 RID: 67283
		internal static int __PropertyOffset_Target_2_LightPitch;

		// Token: 0x040106D4 RID: 67284
		internal static int __PropertyOffset_Target_2_FaceLightYaw;

		// Token: 0x040106D5 RID: 67285
		internal static int __PropertyOffset_Target_2_UsePointLight;

		// Token: 0x040106D6 RID: 67286
		internal static int __PropertyOffset_Target_3;

		// Token: 0x040106D7 RID: 67287
		internal static int __PropertyOffset_Target_3_LightYaw;

		// Token: 0x040106D8 RID: 67288
		internal static int __PropertyOffset_Target_3_LightPitch;

		// Token: 0x040106D9 RID: 67289
		internal static int __PropertyOffset_Target_3_FaceLightYaw;

		// Token: 0x040106DA RID: 67290
		internal static int __PropertyOffset_Target_3_UsePointLight;

		// Token: 0x040106DB RID: 67291
		internal static int __PropertyOffset_Target_4;

		// Token: 0x040106DC RID: 67292
		internal static int __PropertyOffset_Target_4_LightYaw;

		// Token: 0x040106DD RID: 67293
		internal static int __PropertyOffset_Target_4_LightPitch;

		// Token: 0x040106DE RID: 67294
		internal static int __PropertyOffset_Target_4_FaceLightYaw;

		// Token: 0x040106DF RID: 67295
		internal static int __PropertyOffset_Target_4_UsePointLight;

		// Token: 0x040106E0 RID: 67296
		internal static int __PropertyOffset_Target_5;

		// Token: 0x040106E1 RID: 67297
		internal static int __PropertyOffset_Target_5_LightYaw;

		// Token: 0x040106E2 RID: 67298
		internal static int __PropertyOffset_Target_5_LightPitch;

		// Token: 0x040106E3 RID: 67299
		internal static int __PropertyOffset_Target_5_FaceLightYaw;

		// Token: 0x040106E4 RID: 67300
		internal static int __PropertyOffset_Target_5_UsePointLight;

		// Token: 0x040106E5 RID: 67301
		internal static int __PropertyOffset_Target_6;

		// Token: 0x040106E6 RID: 67302
		internal static int __PropertyOffset_Target_6_LightYaw;

		// Token: 0x040106E7 RID: 67303
		internal static int __PropertyOffset_Target_6_LightPitch;

		// Token: 0x040106E8 RID: 67304
		internal static int __PropertyOffset_Target_6_FaceLightYaw;

		// Token: 0x040106E9 RID: 67305
		internal static int __PropertyOffset_IsHideMesh;

		// Token: 0x040106EA RID: 67306
		internal static int __PropertyOffset_IsHideEffect;

		// Token: 0x040106EB RID: 67307
		internal static int __PropertyOffset_LightShakeSpeed_Float;

		// Token: 0x040106EC RID: 67308
		internal static int __PropertyOffset_LightShakeSpeed_Float_Default;

		// Token: 0x040106ED RID: 67309
		internal static int __PropertyOffset_LightShakePositionX_Float;

		// Token: 0x040106EE RID: 67310
		internal static int __PropertyOffset_LightShakePositionX_Float_Default;

		// Token: 0x040106EF RID: 67311
		internal static int __PropertyOffset_LightShakePositionY_Float;

		// Token: 0x040106F0 RID: 67312
		internal static int __PropertyOffset_LightShakePositionY_Float_Default;

		// Token: 0x040106F1 RID: 67313
		internal static int __PropertyOffset_LightShakeScale_Float;

		// Token: 0x040106F2 RID: 67314
		internal static int __PropertyOffset_LightShakeScale_Float_Default;

		// Token: 0x040106F3 RID: 67315
		internal static int __PropertyOffset_MainTexColorTint_Vector;

		// Token: 0x040106F4 RID: 67316
		internal static int __PropertyOffset_MainTexColorTint_Vector_Default;

		// Token: 0x040106F5 RID: 67317
		internal static int __PropertyOffset_MaterialControllerToggle;

		// Token: 0x040106F6 RID: 67318
		internal static int __PropertyOffset_ReceiveRoleLight;

		// Token: 0x040106F7 RID: 67319
		internal static int __PropertyOffset_IsDisableCameraCollision;

		// Token: 0x040106F8 RID: 67320
		internal static int __PropertyOffset_IsAutonomousHideMesh;

		// Token: 0x040106F9 RID: 67321
		internal static int __PropertyOffset_IsAutonomousHideEffect;

		// Token: 0x040106FA RID: 67322
		internal static int __PropertyOffset_IsAutonomousHideNpcMesh;

		// Token: 0x040106FB RID: 67323
		internal static int __PropertyOffset_IsAutonomousHideNpcEffect;

		// Token: 0x040106FC RID: 67324
		internal static int __PropertyOffset_IsHideNpcMesh;

		// Token: 0x040106FD RID: 67325
		internal static int __PropertyOffset_IsHideNpcEffect;

		// Token: 0x040106FE RID: 67326
		internal static int __PropertyOffset_HideDistance;

		// Token: 0x040106FF RID: 67327
		internal static int __PropertyOffset_BasisBoneName;

		// Token: 0x04010700 RID: 67328
		internal static int __PropertyOffset_Target_6_UsePointLight;

		// Token: 0x04010701 RID: 67329
		internal static int __PropertyOffset_LightYawNotAddRotate;

		// Token: 0x04010702 RID: 67330
		internal static int __PropertyOffset_SubCameraSize1;

		// Token: 0x04010703 RID: 67331
		internal static int __PropertyOffset_SubCameraName1;

		// Token: 0x04010704 RID: 67332
		internal static int __PropertyOffset_SubCameraLocation1;

		// Token: 0x04010705 RID: 67333
		internal static int __PropertyOffset_SubCameraSize2;

		// Token: 0x04010706 RID: 67334
		internal static int __PropertyOffset_SubCameraName2;

		// Token: 0x04010707 RID: 67335
		internal static int __PropertyOffset_SubCameraLocation2;

		// Token: 0x04010708 RID: 67336
		internal static int __PropertyOffset_SeamlessSubCamera1;

		// Token: 0x04010709 RID: 67337
		internal static int __PropertyOffset_SeamlessSubCamera2;

		// Token: 0x0401070A RID: 67338
		private static IntPtr __UpdateSeparateCamera_NativeFunctionPtr;

		// Token: 0x0401070B RID: 67339
		private static IntPtr __UpdateCameraCollision_NativeFunctionPtr;

		// Token: 0x0401070C RID: 67340
		private static IntPtr __EulerToForward_NativeFunctionPtr;

		// Token: 0x0401070D RID: 67341
		private static IntPtr __UpdateMeshAndEffectState_NativeFunctionPtr;

		// Token: 0x0401070E RID: 67342
		private static IntPtr __SetActorLight_NativeFunctionPtr;

		// Token: 0x0401070F RID: 67343
		private static IntPtr __ProcessCombinNPC_NativeFunctionPtr;

		// Token: 0x04010710 RID: 67344
		private static IntPtr __RevertLightDirection_NativeFunctionPtr;

		// Token: 0x04010711 RID: 67345
		private static IntPtr __SetLightDirection_NativeFunctionPtr;

		// Token: 0x04010712 RID: 67346
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010713 RID: 67347
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010714 RID: 67348
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010715 RID: 67349
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x04010716 RID: 67350
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02008EF6 RID: 36598
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateCameraCollision_FunctionParams
		{
			// Token: 0x0402CBE2 RID: 183266
			[FieldOffset(0)]
			public IntPtr InActor;

			// Token: 0x0402CBE3 RID: 183267
			[FieldOffset(8)]
			public bool IsDisableCameraCollision;
		}

		// Token: 0x02008EF7 RID: 36599
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __EulerToForward_FunctionParams
		{
			// Token: 0x0402CBE4 RID: 183268
			[FieldOffset(0)]
			public float Pitch;

			// Token: 0x0402CBE5 RID: 183269
			[FieldOffset(4)]
			public float Yaw;

			// Token: 0x0402CBE6 RID: 183270
			[FieldOffset(8)]
			public FVector __Result;
		}

		// Token: 0x02008EF8 RID: 36600
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __UpdateMeshAndEffectState_FunctionParams
		{
			// Token: 0x0402CBE7 RID: 183271
			[FieldOffset(0)]
			public IntPtr InActor;

			// Token: 0x0402CBE8 RID: 183272
			[FieldOffset(8)]
			public bool IsHideMesh;

			// Token: 0x0402CBE9 RID: 183273
			[FieldOffset(9)]
			public bool IsHideEffect;

			// Token: 0x0402CBEA RID: 183274
			[FieldOffset(10)]
			public bool isDestroyed;

			// Token: 0x0402CBEB RID: 183275
			[FieldOffset(11)]
			public bool IsHideNpcMesh;

			// Token: 0x0402CBEC RID: 183276
			[FieldOffset(12)]
			public bool IsHideNpcEffect;

			// Token: 0x0402CBED RID: 183277
			[FieldOffset(16)]
			public float HideDistance;

			// Token: 0x0402CBEE RID: 183278
			[FieldOffset(24)]
			public FString BasisBoneName;
		}

		// Token: 0x02008EF9 RID: 36601
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __SetActorLight_FunctionParams
		{
			// Token: 0x0402CBEF RID: 183279
			[FieldOffset(0)]
			public IntPtr InActor;

			// Token: 0x0402CBF0 RID: 183280
			[FieldOffset(8)]
			public float LightYaw;

			// Token: 0x0402CBF1 RID: 183281
			[FieldOffset(12)]
			public float LightPitch;

			// Token: 0x0402CBF2 RID: 183282
			[FieldOffset(16)]
			public float FaceLightYaw;

			// Token: 0x0402CBF3 RID: 183283
			[FieldOffset(20)]
			public bool IsRevert;

			// Token: 0x0402CBF4 RID: 183284
			[FieldOffset(21)]
			public bool UsePointLight;
		}

		// Token: 0x02008EFA RID: 36602
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __ProcessCombinNPC_FunctionParams
		{
			// Token: 0x0402CBF5 RID: 183285
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x0402CBF6 RID: 183286
			[FieldOffset(8)]
			public float LightYaw;

			// Token: 0x0402CBF7 RID: 183287
			[FieldOffset(12)]
			public float FaceLightYaw;
		}

		// Token: 0x02008EFB RID: 36603
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RevertLightDirection_FunctionParams
		{
			// Token: 0x0402CBF8 RID: 183288
			[FieldOffset(0)]
			public IntPtr Mesh;
		}

		// Token: 0x02008EFC RID: 36604
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __SetLightDirection_FunctionParams
		{
			// Token: 0x0402CBF9 RID: 183289
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x0402CBFA RID: 183290
			[FieldOffset(8)]
			public float LightYaw;

			// Token: 0x0402CBFB RID: 183291
			[FieldOffset(12)]
			public float LightPitch;

			// Token: 0x0402CBFC RID: 183292
			[FieldOffset(16)]
			public float FaceLightYaw;

			// Token: 0x0402CBFD RID: 183293
			[FieldOffset(20)]
			public bool UsePointLight;
		}

		// Token: 0x02008EFD RID: 36605
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CBFE RID: 183294
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008EFE RID: 36606
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CBFF RID: 183295
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

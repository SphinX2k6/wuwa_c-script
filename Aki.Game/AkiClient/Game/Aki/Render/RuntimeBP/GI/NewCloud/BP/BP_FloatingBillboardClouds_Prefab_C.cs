using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D5E RID: 15710
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_FloatingBillboardClouds_Prefab.BP_FloatingBillboardClouds_Prefab_C")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1684)]
	public class BP_FloatingBillboardClouds_Prefab_C : AKuroFloatingBillboardCloudPrefabActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060266F8 RID: 157432 RVA: 0x00975145 File Offset: 0x00973345
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloatingBillboardClouds_Prefab_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_FloatingBillboardClouds_Prefab.BP_FloatingBillboardClouds_Prefab_C");
			}
			return BP_FloatingBillboardClouds_Prefab_C._ClassPtr;
		}

		// Token: 0x060266F9 RID: 157433 RVA: 0x0097516C File Offset: 0x0097336C
		public BP_FloatingBillboardClouds_Prefab_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloatingBillboardClouds_Prefab_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060266FA RID: 157434 RVA: 0x00975194 File Offset: 0x00973394
		[NullableContext(1)]
		public BP_FloatingBillboardClouds_Prefab_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloatingBillboardClouds_Prefab_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005221 RID: 21025
		// (get) Token: 0x060266FB RID: 157435 RVA: 0x009751C7 File Offset: 0x009733C7
		// (set) Token: 0x060266FC RID: 157436 RVA: 0x009751DB File Offset: 0x009733DB
		public unsafe UStaticMeshComponent Cloud
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005222 RID: 21026
		// (get) Token: 0x060266FD RID: 157437 RVA: 0x009751F0 File Offset: 0x009733F0
		// (set) Token: 0x060266FE RID: 157438 RVA: 0x00975204 File Offset: 0x00973404
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005223 RID: 21027
		// (get) Token: 0x060266FF RID: 157439 RVA: 0x00975219 File Offset: 0x00973419
		// (set) Token: 0x06026700 RID: 157440 RVA: 0x0097522D File Offset: 0x0097342D
		public unsafe UMaterialInstance CloudMatrerial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005224 RID: 21028
		// (get) Token: 0x06026701 RID: 157441 RVA: 0x00975242 File Offset: 0x00973442
		// (set) Token: 0x06026702 RID: 157442 RVA: 0x00975256 File Offset: 0x00973456
		public unsafe UMaterialInstanceDynamic CloudDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005225 RID: 21029
		// (get) Token: 0x06026703 RID: 157443 RVA: 0x0097526B File Offset: 0x0097346B
		// (set) Token: 0x06026704 RID: 157444 RVA: 0x0097527F File Offset: 0x0097347F
		public unsafe UKuroPDFloatingBillboardCloudPrefab CloudPD
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPDFloatingBillboardCloudPrefab>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005226 RID: 21030
		// (get) Token: 0x06026705 RID: 157445 RVA: 0x00975294 File Offset: 0x00973494
		// (set) Token: 0x06026706 RID: 157446 RVA: 0x009752A4 File Offset: 0x009734A4
		public unsafe int Number
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005227 RID: 21031
		// (get) Token: 0x06026707 RID: 157447 RVA: 0x009752B5 File Offset: 0x009734B5
		// (set) Token: 0x06026708 RID: 157448 RVA: 0x009752C5 File Offset: 0x009734C5
		public unsafe int Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005228 RID: 21032
		// (get) Token: 0x06026709 RID: 157449 RVA: 0x009752D8 File Offset: 0x009734D8
		// (set) Token: 0x0602670A RID: 157450 RVA: 0x00975311 File Offset: 0x00973511
		[Nullable(1)]
		public TArray<UStaticMeshComponent> Childs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._Childs) == null)
				{
					result = (this._Childs = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Childs.CopyAssign(value);
			}
		}

		// Token: 0x17005229 RID: 21033
		// (get) Token: 0x0602670B RID: 157451 RVA: 0x0097531F File Offset: 0x0097351F
		// (set) Token: 0x0602670C RID: 157452 RVA: 0x0097532F File Offset: 0x0097352F
		public unsafe bool First
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700522A RID: 21034
		// (get) Token: 0x0602670D RID: 157453 RVA: 0x00975340 File Offset: 0x00973540
		// (set) Token: 0x0602670E RID: 157454 RVA: 0x00975350 File Offset: 0x00973550
		public unsafe int Trans_Sort_Number
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700522B RID: 21035
		// (get) Token: 0x0602670F RID: 157455 RVA: 0x00975361 File Offset: 0x00973561
		// (set) Token: 0x06026710 RID: 157456 RVA: 0x00975371 File Offset: 0x00973571
		public unsafe int RelativeHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700522C RID: 21036
		// (get) Token: 0x06026711 RID: 157457 RVA: 0x00975382 File Offset: 0x00973582
		// (set) Token: 0x06026712 RID: 157458 RVA: 0x00975392 File Offset: 0x00973592
		public unsafe float Height_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700522D RID: 21037
		// (get) Token: 0x06026713 RID: 157459 RVA: 0x009753A3 File Offset: 0x009735A3
		// (set) Token: 0x06026714 RID: 157460 RVA: 0x009753B7 File Offset: 0x009735B7
		public unsafe FVector CloudScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700522E RID: 21038
		// (get) Token: 0x06026715 RID: 157461 RVA: 0x009753CC File Offset: 0x009735CC
		// (set) Token: 0x06026716 RID: 157462 RVA: 0x009753E0 File Offset: 0x009735E0
		public unsafe FVector Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700522F RID: 21039
		// (get) Token: 0x06026717 RID: 157463 RVA: 0x009753F5 File Offset: 0x009735F5
		// (set) Token: 0x06026718 RID: 157464 RVA: 0x00975405 File Offset: 0x00973605
		public unsafe float OpacityForSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005230 RID: 21040
		// (get) Token: 0x06026719 RID: 157465 RVA: 0x00975416 File Offset: 0x00973616
		// (set) Token: 0x0602671A RID: 157466 RVA: 0x00975426 File Offset: 0x00973626
		public unsafe float ChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005231 RID: 21041
		// (get) Token: 0x0602671B RID: 157467 RVA: 0x00975437 File Offset: 0x00973637
		// (set) Token: 0x0602671C RID: 157468 RVA: 0x00975447 File Offset: 0x00973647
		public unsafe bool Forward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005232 RID: 21042
		// (get) Token: 0x0602671D RID: 157469 RVA: 0x00975458 File Offset: 0x00973658
		// (set) Token: 0x0602671E RID: 157470 RVA: 0x00975468 File Offset: 0x00973668
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005233 RID: 21043
		// (get) Token: 0x0602671F RID: 157471 RVA: 0x00975479 File Offset: 0x00973679
		// (set) Token: 0x06026720 RID: 157472 RVA: 0x00975489 File Offset: 0x00973689
		public unsafe bool TimeIni
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005234 RID: 21044
		// (get) Token: 0x06026721 RID: 157473 RVA: 0x0097549A File Offset: 0x0097369A
		// (set) Token: 0x06026722 RID: 157474 RVA: 0x009754AA File Offset: 0x009736AA
		public unsafe bool Stop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005235 RID: 21045
		// (get) Token: 0x06026723 RID: 157475 RVA: 0x009754BB File Offset: 0x009736BB
		// (set) Token: 0x06026724 RID: 157476 RVA: 0x009754CF File Offset: 0x009736CF
		public unsafe FVector2D CloudDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005236 RID: 21046
		// (get) Token: 0x06026725 RID: 157477 RVA: 0x009754E4 File Offset: 0x009736E4
		// (set) Token: 0x06026726 RID: 157478 RVA: 0x009754F8 File Offset: 0x009736F8
		public unsafe FVectorDouble CenterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005237 RID: 21047
		// (get) Token: 0x06026727 RID: 157479 RVA: 0x0097550D File Offset: 0x0097370D
		// (set) Token: 0x06026728 RID: 157480 RVA: 0x0097551D File Offset: 0x0097371D
		public unsafe float StepDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005238 RID: 21048
		// (get) Token: 0x06026729 RID: 157481 RVA: 0x0097552E File Offset: 0x0097372E
		// (set) Token: 0x0602672A RID: 157482 RVA: 0x0097553E File Offset: 0x0097373E
		public unsafe int CloudRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005239 RID: 21049
		// (get) Token: 0x0602672B RID: 157483 RVA: 0x0097554F File Offset: 0x0097374F
		// (set) Token: 0x0602672C RID: 157484 RVA: 0x0097555F File Offset: 0x0097375F
		public unsafe bool initDone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700523A RID: 21050
		// (get) Token: 0x0602672D RID: 157485 RVA: 0x00975570 File Offset: 0x00973770
		// (set) Token: 0x0602672E RID: 157486 RVA: 0x00975580 File Offset: 0x00973780
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700523B RID: 21051
		// (get) Token: 0x0602672F RID: 157487 RVA: 0x00975591 File Offset: 0x00973791
		// (set) Token: 0x06026730 RID: 157488 RVA: 0x009755A5 File Offset: 0x009737A5
		public unsafe FVectorDouble CloudPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700523C RID: 21052
		// (get) Token: 0x06026731 RID: 157489 RVA: 0x009755BA File Offset: 0x009737BA
		// (set) Token: 0x06026732 RID: 157490 RVA: 0x009755CA File Offset: 0x009737CA
		public unsafe int CloudDissolveDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_Prefab_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x06026733 RID: 157491 RVA: 0x009755DC File Offset: 0x009737DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCameraLocation(ref FVectorDouble CameraPosition)
		{
			BP_FloatingBillboardClouds_Prefab_C.__GetCameraLocation_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_Prefab_C.__GetCameraLocation_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(BP_FloatingBillboardClouds_Prefab_C.__GetCameraLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_Prefab_C.__GetCameraLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CameraPosition = CameraPosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__GetCameraLocation_NativeFunctionPtr, (void*)ptr);
			CameraPosition = ptr->CameraPosition;
		}

		// Token: 0x06026734 RID: 157492 RVA: 0x00975638 File Offset: 0x00973838
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CloudDisappear(FVectorDouble CameraPosition)
		{
			BP_FloatingBillboardClouds_Prefab_C.__CloudDisappear_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_Prefab_C.__CloudDisappear_FunctionParams[(UIntPtr)527] + 15L / (long)sizeof(BP_FloatingBillboardClouds_Prefab_C.__CloudDisappear_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_Prefab_C.__CloudDisappear_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CameraPosition = CameraPosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__CloudDisappear_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026735 RID: 157493 RVA: 0x00975684 File Offset: 0x00973884
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CloudChange(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_Prefab_C.__CloudChange_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_Prefab_C.__CloudChange_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_FloatingBillboardClouds_Prefab_C.__CloudChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_Prefab_C.__CloudChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__CloudChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026736 RID: 157494 RVA: 0x009756CA File Offset: 0x009738CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Active()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__Active_NativeFunctionPtr, null);
		}

		// Token: 0x06026737 RID: 157495 RVA: 0x009756E0 File Offset: 0x009738E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(float DeltaSeconds, float Speed, bool forward, ref float Progress)
		{
			BP_FloatingBillboardClouds_Prefab_C.__Timer_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_Prefab_C.__Timer_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FloatingBillboardClouds_Prefab_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_Prefab_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->Speed = Speed;
			ptr->forward = forward;
			ptr->Progress = Progress;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__Timer_NativeFunctionPtr, (void*)ptr);
			Progress = ptr->Progress;
		}

		// Token: 0x06026738 RID: 157496 RVA: 0x00975746 File Offset: 0x00973946
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloudInitial()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__CloudInitial_NativeFunctionPtr, null);
		}

		// Token: 0x06026739 RID: 157497 RVA: 0x0097575C File Offset: 0x0097395C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CloudMove(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_Prefab_C.__CloudMove_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_Prefab_C.__CloudMove_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_FloatingBillboardClouds_Prefab_C.__CloudMove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_Prefab_C.__CloudMove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__CloudMove_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602673A RID: 157498 RVA: 0x009757A5 File Offset: 0x009739A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602673B RID: 157499 RVA: 0x009757B9 File Offset: 0x009739B9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602673C RID: 157500 RVA: 0x009757CE File Offset: 0x009739CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602673D RID: 157501 RVA: 0x009757E2 File Offset: 0x009739E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602673E RID: 157502 RVA: 0x009757F8 File Offset: 0x009739F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602673F RID: 157503 RVA: 0x00975840 File Offset: 0x00973A40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026740 RID: 157504 RVA: 0x00975888 File Offset: 0x00973A88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_Prefab_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_Prefab_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingBillboardClouds_Prefab_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_Prefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026741 RID: 157505 RVA: 0x009758D0 File Offset: 0x00973AD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_Prefab_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_Prefab_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingBillboardClouds_Prefab_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_Prefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingBillboardClouds_Prefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026742 RID: 157506 RVA: 0x00975917 File Offset: 0x00973B17
		protected BP_FloatingBillboardClouds_Prefab_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013483 RID: 78979
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_FloatingBillboardClouds_Prefab.BP_FloatingBillboardClouds_Prefab_C";

		// Token: 0x04013484 RID: 78980
		private static IntPtr _ClassPtr;

		// Token: 0x04013485 RID: 78981
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013486 RID: 78982
		internal static int __PropertyOffset_1;

		// Token: 0x04013487 RID: 78983
		internal static int __PropertyOffset_2;

		// Token: 0x04013488 RID: 78984
		internal static int __PropertyOffset_3;

		// Token: 0x04013489 RID: 78985
		internal static int __PropertyOffset_4;

		// Token: 0x0401348A RID: 78986
		internal static int __PropertyOffset_5;

		// Token: 0x0401348B RID: 78987
		internal static int __PropertyOffset_6;

		// Token: 0x0401348C RID: 78988
		internal static int __PropertyOffset_7;

		// Token: 0x0401348D RID: 78989
		internal static int __PropertyOffset_8;

		// Token: 0x0401348E RID: 78990
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _Childs;

		// Token: 0x0401348F RID: 78991
		internal static int __PropertyOffset_9;

		// Token: 0x04013490 RID: 78992
		internal static int __PropertyOffset_10;

		// Token: 0x04013491 RID: 78993
		internal static int __PropertyOffset_11;

		// Token: 0x04013492 RID: 78994
		internal static int __PropertyOffset_12;

		// Token: 0x04013493 RID: 78995
		internal static int __PropertyOffset_13;

		// Token: 0x04013494 RID: 78996
		internal static int __PropertyOffset_14;

		// Token: 0x04013495 RID: 78997
		internal static int __PropertyOffset_15;

		// Token: 0x04013496 RID: 78998
		internal static int __PropertyOffset_16;

		// Token: 0x04013497 RID: 78999
		internal static int __PropertyOffset_17;

		// Token: 0x04013498 RID: 79000
		internal static int __PropertyOffset_18;

		// Token: 0x04013499 RID: 79001
		internal static int __PropertyOffset_19;

		// Token: 0x0401349A RID: 79002
		internal static int __PropertyOffset_20;

		// Token: 0x0401349B RID: 79003
		internal static int __PropertyOffset_21;

		// Token: 0x0401349C RID: 79004
		internal static int __PropertyOffset_22;

		// Token: 0x0401349D RID: 79005
		internal static int __PropertyOffset_23;

		// Token: 0x0401349E RID: 79006
		internal static int __PropertyOffset_24;

		// Token: 0x0401349F RID: 79007
		internal static int __PropertyOffset_25;

		// Token: 0x040134A0 RID: 79008
		internal static int __PropertyOffset_26;

		// Token: 0x040134A1 RID: 79009
		internal static int __PropertyOffset_27;

		// Token: 0x040134A2 RID: 79010
		internal static int __PropertyOffset_28;

		// Token: 0x040134A3 RID: 79011
		private static IntPtr __GetCameraLocation_NativeFunctionPtr;

		// Token: 0x040134A4 RID: 79012
		private static IntPtr __CloudDisappear_NativeFunctionPtr;

		// Token: 0x040134A5 RID: 79013
		private static IntPtr __CloudChange_NativeFunctionPtr;

		// Token: 0x040134A6 RID: 79014
		private static IntPtr __Active_NativeFunctionPtr;

		// Token: 0x040134A7 RID: 79015
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x040134A8 RID: 79016
		private static IntPtr __CloudInitial_NativeFunctionPtr;

		// Token: 0x040134A9 RID: 79017
		private static IntPtr __CloudMove_NativeFunctionPtr;

		// Token: 0x040134AA RID: 79018
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040134AB RID: 79019
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040134AC RID: 79020
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040134AD RID: 79021
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A110 RID: 41232
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __GetCameraLocation_FunctionParams
		{
			// Token: 0x04031C83 RID: 203907
			[FieldOffset(0)]
			public FVectorDouble CameraPosition;
		}

		// Token: 0x0200A111 RID: 41233
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 512)]
		protected ref struct __CloudDisappear_FunctionParams
		{
			// Token: 0x04031C84 RID: 203908
			[FieldOffset(0)]
			public FVectorDouble CameraPosition;
		}

		// Token: 0x0200A112 RID: 41234
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __CloudChange_FunctionParams
		{
			// Token: 0x04031C85 RID: 203909
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A113 RID: 41235
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x04031C86 RID: 203910
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04031C87 RID: 203911
			[FieldOffset(4)]
			public float Speed;

			// Token: 0x04031C88 RID: 203912
			[FieldOffset(8)]
			public bool forward;

			// Token: 0x04031C89 RID: 203913
			[FieldOffset(12)]
			public float Progress;
		}

		// Token: 0x0200A114 RID: 41236
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __CloudMove_FunctionParams
		{
			// Token: 0x04031C8A RID: 203914
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A115 RID: 41237
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031C8B RID: 203915
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A116 RID: 41238
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031C8C RID: 203916
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

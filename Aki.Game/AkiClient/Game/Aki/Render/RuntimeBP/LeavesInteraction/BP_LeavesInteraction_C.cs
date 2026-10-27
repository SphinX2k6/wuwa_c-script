using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LeavesInteraction
{
	// Token: 0x02003CF7 RID: 15607
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesInteraction.BP_LeavesInteraction_C")]
	[UnrealStructLayout(1768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1764)]
	public class BP_LeavesInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602536E RID: 152430 RVA: 0x00954450 File Offset: 0x00952650
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LeavesInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesInteraction.BP_LeavesInteraction_C");
			}
			return BP_LeavesInteraction_C._ClassPtr;
		}

		// Token: 0x0602536F RID: 152431 RVA: 0x00954474 File Offset: 0x00952674
		public BP_LeavesInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_LeavesInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025370 RID: 152432 RVA: 0x0095449C File Offset: 0x0095269C
		[NullableContext(1)]
		public BP_LeavesInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LeavesInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B65 RID: 19301
		// (get) Token: 0x06025371 RID: 152433 RVA: 0x009544CF File Offset: 0x009526CF
		// (set) Token: 0x06025372 RID: 152434 RVA: 0x009544E3 File Offset: 0x009526E3
		public unsafe UBoxComponent AreaBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004B66 RID: 19302
		// (get) Token: 0x06025373 RID: 152435 RVA: 0x009544F8 File Offset: 0x009526F8
		// (set) Token: 0x06025374 RID: 152436 RVA: 0x0095450C File Offset: 0x0095270C
		public unsafe UNiagaraComponent NS_FX_LeavesInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004B67 RID: 19303
		// (get) Token: 0x06025375 RID: 152437 RVA: 0x00954521 File Offset: 0x00952721
		// (set) Token: 0x06025376 RID: 152438 RVA: 0x00954535 File Offset: 0x00952735
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004B68 RID: 19304
		// (get) Token: 0x06025377 RID: 152439 RVA: 0x0095454A File Offset: 0x0095274A
		// (set) Token: 0x06025378 RID: 152440 RVA: 0x0095455E File Offset: 0x0095275E
		public unsafe FVector FieldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004B69 RID: 19305
		// (get) Token: 0x06025379 RID: 152441 RVA: 0x00954573 File Offset: 0x00952773
		// (set) Token: 0x0602537A RID: 152442 RVA: 0x00954583 File Offset: 0x00952783
		public unsafe int Resolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004B6A RID: 19306
		// (get) Token: 0x0602537B RID: 152443 RVA: 0x00954594 File Offset: 0x00952794
		// (set) Token: 0x0602537C RID: 152444 RVA: 0x009545A8 File Offset: 0x009527A8
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004B6B RID: 19307
		// (get) Token: 0x0602537D RID: 152445 RVA: 0x009545BD File Offset: 0x009527BD
		// (set) Token: 0x0602537E RID: 152446 RVA: 0x009545D1 File Offset: 0x009527D1
		public unsafe USkeletalMeshComponent Weapon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004B6C RID: 19308
		// (get) Token: 0x0602537F RID: 152447 RVA: 0x009545E6 File Offset: 0x009527E6
		// (set) Token: 0x06025380 RID: 152448 RVA: 0x009545FA File Offset: 0x009527FA
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004B6D RID: 19309
		// (get) Token: 0x06025381 RID: 152449 RVA: 0x0095460F File Offset: 0x0095280F
		// (set) Token: 0x06025382 RID: 152450 RVA: 0x00954623 File Offset: 0x00952823
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004B6E RID: 19310
		// (get) Token: 0x06025383 RID: 152451 RVA: 0x00954638 File Offset: 0x00952838
		// (set) Token: 0x06025384 RID: 152452 RVA: 0x0095464C File Offset: 0x0095284C
		public unsafe FVector WeaponVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004B6F RID: 19311
		// (get) Token: 0x06025385 RID: 152453 RVA: 0x00954661 File Offset: 0x00952861
		// (set) Token: 0x06025386 RID: 152454 RVA: 0x00954675 File Offset: 0x00952875
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004B70 RID: 19312
		// (get) Token: 0x06025387 RID: 152455 RVA: 0x0095468A File Offset: 0x0095288A
		// (set) Token: 0x06025388 RID: 152456 RVA: 0x0095469A File Offset: 0x0095289A
		public unsafe bool isClear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B71 RID: 19313
		// (get) Token: 0x06025389 RID: 152457 RVA: 0x009546AB File Offset: 0x009528AB
		// (set) Token: 0x0602538A RID: 152458 RVA: 0x009546BF File Offset: 0x009528BF
		public unsafe FLinearColor GlobalWorldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004B72 RID: 19314
		// (get) Token: 0x0602538B RID: 152459 RVA: 0x009546D4 File Offset: 0x009528D4
		// (set) Token: 0x0602538C RID: 152460 RVA: 0x009546E4 File Offset: 0x009528E4
		public unsafe float PlayerSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004B73 RID: 19315
		// (get) Token: 0x0602538D RID: 152461 RVA: 0x009546F5 File Offset: 0x009528F5
		// (set) Token: 0x0602538E RID: 152462 RVA: 0x00954705 File Offset: 0x00952905
		public unsafe float WeaponSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004B74 RID: 19316
		// (get) Token: 0x0602538F RID: 152463 RVA: 0x00954716 File Offset: 0x00952916
		// (set) Token: 0x06025390 RID: 152464 RVA: 0x0095472A File Offset: 0x0095292A
		public unsafe FVector DepthCapturePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004B75 RID: 19317
		// (get) Token: 0x06025391 RID: 152465 RVA: 0x0095473F File Offset: 0x0095293F
		// (set) Token: 0x06025392 RID: 152466 RVA: 0x00954753 File Offset: 0x00952953
		public unsafe UTexture DepthTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004B76 RID: 19318
		// (get) Token: 0x06025393 RID: 152467 RVA: 0x00954768 File Offset: 0x00952968
		// (set) Token: 0x06025394 RID: 152468 RVA: 0x00954778 File Offset: 0x00952978
		public unsafe int LeavesIDStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004B77 RID: 19319
		// (get) Token: 0x06025395 RID: 152469 RVA: 0x00954789 File Offset: 0x00952989
		// (set) Token: 0x06025396 RID: 152470 RVA: 0x00954799 File Offset: 0x00952999
		public unsafe int LeavesIDEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004B78 RID: 19320
		// (get) Token: 0x06025397 RID: 152471 RVA: 0x009547AA File Offset: 0x009529AA
		// (set) Token: 0x06025398 RID: 152472 RVA: 0x009547BA File Offset: 0x009529BA
		public unsafe int LeavesNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004B79 RID: 19321
		// (get) Token: 0x06025399 RID: 152473 RVA: 0x009547CB File Offset: 0x009529CB
		// (set) Token: 0x0602539A RID: 152474 RVA: 0x009547DB File Offset: 0x009529DB
		public unsafe float BoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004B7A RID: 19322
		// (get) Token: 0x0602539B RID: 152475 RVA: 0x009547EC File Offset: 0x009529EC
		// (set) Token: 0x0602539C RID: 152476 RVA: 0x009547FC File Offset: 0x009529FC
		public unsafe float LeavesScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004B7B RID: 19323
		// (get) Token: 0x0602539D RID: 152477 RVA: 0x0095480D File Offset: 0x00952A0D
		// (set) Token: 0x0602539E RID: 152478 RVA: 0x0095481D File Offset: 0x00952A1D
		public unsafe int LUTIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004B7C RID: 19324
		// (get) Token: 0x0602539F RID: 152479 RVA: 0x0095482E File Offset: 0x00952A2E
		// (set) Token: 0x060253A0 RID: 152480 RVA: 0x0095483E File Offset: 0x00952A3E
		public unsafe float LeavesRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004B7D RID: 19325
		// (get) Token: 0x060253A1 RID: 152481 RVA: 0x0095484F File Offset: 0x00952A4F
		// (set) Token: 0x060253A2 RID: 152482 RVA: 0x0095485F File Offset: 0x00952A5F
		public unsafe float LeavesAO
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004B7E RID: 19326
		// (get) Token: 0x060253A3 RID: 152483 RVA: 0x00954870 File Offset: 0x00952A70
		// (set) Token: 0x060253A4 RID: 152484 RVA: 0x00954880 File Offset: 0x00952A80
		public unsafe float LutProbabilityPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004B7F RID: 19327
		// (get) Token: 0x060253A5 RID: 152485 RVA: 0x00954891 File Offset: 0x00952A91
		// (set) Token: 0x060253A6 RID: 152486 RVA: 0x009548A5 File Offset: 0x00952AA5
		public unsafe UTexture LeavesMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17004B80 RID: 19328
		// (get) Token: 0x060253A7 RID: 152487 RVA: 0x009548BA File Offset: 0x00952ABA
		// (set) Token: 0x060253A8 RID: 152488 RVA: 0x009548CA File Offset: 0x00952ACA
		public unsafe bool UseLUT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B81 RID: 19329
		// (get) Token: 0x060253A9 RID: 152489 RVA: 0x009548DB File Offset: 0x00952ADB
		// (set) Token: 0x060253AA RID: 152490 RVA: 0x009548EB File Offset: 0x00952AEB
		public unsafe float OffsetDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004B82 RID: 19330
		// (get) Token: 0x060253AB RID: 152491 RVA: 0x009548FC File Offset: 0x00952AFC
		// (set) Token: 0x060253AC RID: 152492 RVA: 0x00954910 File Offset: 0x00952B10
		public unsafe FVector BPPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004B83 RID: 19331
		// (get) Token: 0x060253AD RID: 152493 RVA: 0x00954925 File Offset: 0x00952B25
		// (set) Token: 0x060253AE RID: 152494 RVA: 0x00954935 File Offset: 0x00952B35
		public unsafe float CullingHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004B84 RID: 19332
		// (get) Token: 0x060253AF RID: 152495 RVA: 0x00954946 File Offset: 0x00952B46
		// (set) Token: 0x060253B0 RID: 152496 RVA: 0x0095495A File Offset: 0x00952B5A
		public unsafe FVector RuntimeDepthCapturePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004B85 RID: 19333
		// (get) Token: 0x060253B1 RID: 152497 RVA: 0x0095496F File Offset: 0x00952B6F
		// (set) Token: 0x060253B2 RID: 152498 RVA: 0x00954983 File Offset: 0x00952B83
		public unsafe UTexture RuntimeDepthTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17004B86 RID: 19334
		// (get) Token: 0x060253B3 RID: 152499 RVA: 0x00954998 File Offset: 0x00952B98
		// (set) Token: 0x060253B4 RID: 152500 RVA: 0x009549AC File Offset: 0x00952BAC
		public unsafe FVector RuntimeDepthCaptureBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004B87 RID: 19335
		// (get) Token: 0x060253B5 RID: 152501 RVA: 0x009549C1 File Offset: 0x00952BC1
		// (set) Token: 0x060253B6 RID: 152502 RVA: 0x009549D1 File Offset: 0x00952BD1
		public unsafe bool UseRuntimeCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B88 RID: 19336
		// (get) Token: 0x060253B7 RID: 152503 RVA: 0x009549E2 File Offset: 0x00952BE2
		// (set) Token: 0x060253B8 RID: 152504 RVA: 0x009549F2 File Offset: 0x00952BF2
		public unsafe bool bHideInLowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B89 RID: 19337
		// (get) Token: 0x060253B9 RID: 152505 RVA: 0x00954A03 File Offset: 0x00952C03
		// (set) Token: 0x060253BA RID: 152506 RVA: 0x00954A17 File Offset: 0x00952C17
		public unsafe UMaterialInterface LeavesMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x17004B8A RID: 19338
		// (get) Token: 0x060253BB RID: 152507 RVA: 0x00954A2C File Offset: 0x00952C2C
		// (set) Token: 0x060253BC RID: 152508 RVA: 0x00954A40 File Offset: 0x00952C40
		public unsafe UTexture LeavesIDBaseColorMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x17004B8B RID: 19339
		// (get) Token: 0x060253BD RID: 152509 RVA: 0x00954A55 File Offset: 0x00952C55
		// (set) Token: 0x060253BE RID: 152510 RVA: 0x00954A69 File Offset: 0x00952C69
		public unsafe UTexture LeavesIDNormalMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x17004B8C RID: 19340
		// (get) Token: 0x060253BF RID: 152511 RVA: 0x00954A7E File Offset: 0x00952C7E
		// (set) Token: 0x060253C0 RID: 152512 RVA: 0x00954A8E File Offset: 0x00952C8E
		public unsafe float WindIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17004B8D RID: 19341
		// (get) Token: 0x060253C1 RID: 152513 RVA: 0x00954A9F File Offset: 0x00952C9F
		// (set) Token: 0x060253C2 RID: 152514 RVA: 0x00954AAF File Offset: 0x00952CAF
		public unsafe bool UseWindBlown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B8E RID: 19342
		// (get) Token: 0x060253C3 RID: 152515 RVA: 0x00954AC0 File Offset: 0x00952CC0
		// (set) Token: 0x060253C4 RID: 152516 RVA: 0x00954AD0 File Offset: 0x00952CD0
		public unsafe float WindBlownIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17004B8F RID: 19343
		// (get) Token: 0x060253C5 RID: 152517 RVA: 0x00954AE1 File Offset: 0x00952CE1
		// (set) Token: 0x060253C6 RID: 152518 RVA: 0x00954AF1 File Offset: 0x00952CF1
		public unsafe float WindBlownNoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17004B90 RID: 19344
		// (get) Token: 0x060253C7 RID: 152519 RVA: 0x00954B02 File Offset: 0x00952D02
		// (set) Token: 0x060253C8 RID: 152520 RVA: 0x00954B12 File Offset: 0x00952D12
		public unsafe float WindBlownHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x060253C9 RID: 152521 RVA: 0x00954B23 File Offset: 0x00952D23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMaterialParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__SetMaterialParam_NativeFunctionPtr, null);
		}

		// Token: 0x060253CA RID: 152522 RVA: 0x00954B37 File Offset: 0x00952D37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetLeavesParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__SetLeavesParameters_NativeFunctionPtr, null);
		}

		// Token: 0x060253CB RID: 152523 RVA: 0x00954B4B File Offset: 0x00952D4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__Debug_NativeFunctionPtr, null);
		}

		// Token: 0x060253CC RID: 152524 RVA: 0x00954B60 File Offset: 0x00952D60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Choose_Available_Point(FVectorDouble CollisionPoint, FVectorDouble WeaponPoint, BP_SceneBattleInteract_C ConfigDA, ref FVectorDouble AvailblePoint)
		{
			BP_LeavesInteraction_C.__Choose_Available_Point_FunctionParams* ptr = stackalloc BP_LeavesInteraction_C.__Choose_Available_Point_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_LeavesInteraction_C.__Choose_Available_Point_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CollisionPoint = CollisionPoint;
			ptr->WeaponPoint = WeaponPoint;
			ptr->ConfigDA = ((ConfigDA != null) ? ConfigDA.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr);
			AvailblePoint = ptr->AvailblePoint;
		}

		// Token: 0x060253CD RID: 152525 RVA: 0x00954BDD File Offset: 0x00952DDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WeaponData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__WeaponData_NativeFunctionPtr, null);
		}

		// Token: 0x060253CE RID: 152526 RVA: 0x00954BF4 File Offset: 0x00952DF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateParam(float dt)
		{
			BP_LeavesInteraction_C.__UpdateParam_FunctionParams* ptr = stackalloc BP_LeavesInteraction_C.__UpdateParam_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LeavesInteraction_C.__UpdateParam_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_C.__UpdateParam_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__UpdateParam_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060253CF RID: 152527 RVA: 0x00954C3A File Offset: 0x00952E3A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__InitParam_NativeFunctionPtr, null);
		}

		// Token: 0x060253D0 RID: 152528 RVA: 0x00954C4E File Offset: 0x00952E4E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060253D1 RID: 152529 RVA: 0x00954C62 File Offset: 0x00952E62
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060253D2 RID: 152530 RVA: 0x00954C78 File Offset: 0x00952E78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LeavesInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LeavesInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LeavesInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060253D3 RID: 152531 RVA: 0x00954CC0 File Offset: 0x00952EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LeavesInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LeavesInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LeavesInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060253D4 RID: 152532 RVA: 0x00954D07 File Offset: 0x00952F07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060253D5 RID: 152533 RVA: 0x00954D1B File Offset: 0x00952F1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060253D6 RID: 152534 RVA: 0x00954D30 File Offset: 0x00952F30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_LeavesInteraction_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_LeavesInteraction_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_LeavesInteraction_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060253D7 RID: 152535 RVA: 0x00954D93 File Offset: 0x00952F93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x060253D8 RID: 152536 RVA: 0x00954DA7 File Offset: 0x00952FA7
		protected BP_LeavesInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040128C0 RID: 75968
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesInteraction.BP_LeavesInteraction_C";

		// Token: 0x040128C1 RID: 75969
		private static IntPtr _ClassPtr;

		// Token: 0x040128C2 RID: 75970
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040128C3 RID: 75971
		internal static int __PropertyOffset_1;

		// Token: 0x040128C4 RID: 75972
		internal static int __PropertyOffset_2;

		// Token: 0x040128C5 RID: 75973
		internal static int __PropertyOffset_3;

		// Token: 0x040128C6 RID: 75974
		internal static int __PropertyOffset_4;

		// Token: 0x040128C7 RID: 75975
		internal static int __PropertyOffset_5;

		// Token: 0x040128C8 RID: 75976
		internal static int __PropertyOffset_6;

		// Token: 0x040128C9 RID: 75977
		internal static int __PropertyOffset_7;

		// Token: 0x040128CA RID: 75978
		internal static int __PropertyOffset_8;

		// Token: 0x040128CB RID: 75979
		internal static int __PropertyOffset_9;

		// Token: 0x040128CC RID: 75980
		internal static int __PropertyOffset_10;

		// Token: 0x040128CD RID: 75981
		internal static int __PropertyOffset_11;

		// Token: 0x040128CE RID: 75982
		internal static int __PropertyOffset_12;

		// Token: 0x040128CF RID: 75983
		internal static int __PropertyOffset_13;

		// Token: 0x040128D0 RID: 75984
		internal static int __PropertyOffset_14;

		// Token: 0x040128D1 RID: 75985
		internal static int __PropertyOffset_15;

		// Token: 0x040128D2 RID: 75986
		internal static int __PropertyOffset_16;

		// Token: 0x040128D3 RID: 75987
		internal static int __PropertyOffset_17;

		// Token: 0x040128D4 RID: 75988
		internal static int __PropertyOffset_18;

		// Token: 0x040128D5 RID: 75989
		internal static int __PropertyOffset_19;

		// Token: 0x040128D6 RID: 75990
		internal static int __PropertyOffset_20;

		// Token: 0x040128D7 RID: 75991
		internal static int __PropertyOffset_21;

		// Token: 0x040128D8 RID: 75992
		internal static int __PropertyOffset_22;

		// Token: 0x040128D9 RID: 75993
		internal static int __PropertyOffset_23;

		// Token: 0x040128DA RID: 75994
		internal static int __PropertyOffset_24;

		// Token: 0x040128DB RID: 75995
		internal static int __PropertyOffset_25;

		// Token: 0x040128DC RID: 75996
		internal static int __PropertyOffset_26;

		// Token: 0x040128DD RID: 75997
		internal static int __PropertyOffset_27;

		// Token: 0x040128DE RID: 75998
		internal static int __PropertyOffset_28;

		// Token: 0x040128DF RID: 75999
		internal static int __PropertyOffset_29;

		// Token: 0x040128E0 RID: 76000
		internal static int __PropertyOffset_30;

		// Token: 0x040128E1 RID: 76001
		internal static int __PropertyOffset_31;

		// Token: 0x040128E2 RID: 76002
		internal static int __PropertyOffset_32;

		// Token: 0x040128E3 RID: 76003
		internal static int __PropertyOffset_33;

		// Token: 0x040128E4 RID: 76004
		internal static int __PropertyOffset_34;

		// Token: 0x040128E5 RID: 76005
		internal static int __PropertyOffset_35;

		// Token: 0x040128E6 RID: 76006
		internal static int __PropertyOffset_36;

		// Token: 0x040128E7 RID: 76007
		internal static int __PropertyOffset_37;

		// Token: 0x040128E8 RID: 76008
		internal static int __PropertyOffset_38;

		// Token: 0x040128E9 RID: 76009
		internal static int __PropertyOffset_39;

		// Token: 0x040128EA RID: 76010
		internal static int __PropertyOffset_40;

		// Token: 0x040128EB RID: 76011
		internal static int __PropertyOffset_41;

		// Token: 0x040128EC RID: 76012
		internal static int __PropertyOffset_42;

		// Token: 0x040128ED RID: 76013
		internal static int __PropertyOffset_43;

		// Token: 0x040128EE RID: 76014
		internal static int __PropertyOffset_44;

		// Token: 0x040128EF RID: 76015
		private static IntPtr __SetMaterialParam_NativeFunctionPtr;

		// Token: 0x040128F0 RID: 76016
		private static IntPtr __SetLeavesParameters_NativeFunctionPtr;

		// Token: 0x040128F1 RID: 76017
		private static IntPtr __Debug_NativeFunctionPtr;

		// Token: 0x040128F2 RID: 76018
		private static IntPtr __Choose_Available_Point_NativeFunctionPtr;

		// Token: 0x040128F3 RID: 76019
		private static IntPtr __WeaponData_NativeFunctionPtr;

		// Token: 0x040128F4 RID: 76020
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x040128F5 RID: 76021
		private static IntPtr __InitParam_NativeFunctionPtr;

		// Token: 0x040128F6 RID: 76022
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040128F7 RID: 76023
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040128F8 RID: 76024
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040128F9 RID: 76025
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x040128FA RID: 76026
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x02009FD0 RID: 40912
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Choose_Available_Point_FunctionParams
		{
			// Token: 0x04031A48 RID: 203336
			[FieldOffset(0)]
			public FVectorDouble CollisionPoint;

			// Token: 0x04031A49 RID: 203337
			[FieldOffset(24)]
			public FVectorDouble WeaponPoint;

			// Token: 0x04031A4A RID: 203338
			[FieldOffset(48)]
			public IntPtr ConfigDA;

			// Token: 0x04031A4B RID: 203339
			[FieldOffset(56)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02009FD1 RID: 40913
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __UpdateParam_FunctionParams
		{
			// Token: 0x04031A4C RID: 203340
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x02009FD2 RID: 40914
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A4D RID: 203341
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FD3 RID: 40915
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031A4E RID: 203342
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031A4F RID: 203343
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031A50 RID: 203344
			[FieldOffset(32)]
			public int Id;
		}
	}
}

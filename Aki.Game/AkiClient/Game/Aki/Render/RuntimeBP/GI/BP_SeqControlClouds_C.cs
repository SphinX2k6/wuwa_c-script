using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D32 RID: 15666
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_SeqControlClouds.BP_SeqControlClouds_C")]
	[UnrealStructLayout(1848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1848)]
	public class BP_SeqControlClouds_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F64 RID: 155492 RVA: 0x009679C3 File Offset: 0x00965BC3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqControlClouds_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_SeqControlClouds.BP_SeqControlClouds_C");
			}
			return BP_SeqControlClouds_C._ClassPtr;
		}

		// Token: 0x06025F65 RID: 155493 RVA: 0x009679E8 File Offset: 0x00965BE8
		public BP_SeqControlClouds_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqControlClouds_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F66 RID: 155494 RVA: 0x00967A10 File Offset: 0x00965C10
		[NullableContext(1)]
		public BP_SeqControlClouds_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqControlClouds_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004FB9 RID: 20409
		// (get) Token: 0x06025F67 RID: 155495 RVA: 0x00967A43 File Offset: 0x00965C43
		// (set) Token: 0x06025F68 RID: 155496 RVA: 0x00967A57 File Offset: 0x00965C57
		public unsafe UStaticMeshComponent BackgroundHighFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004FBA RID: 20410
		// (get) Token: 0x06025F69 RID: 155497 RVA: 0x00967A6C File Offset: 0x00965C6C
		// (set) Token: 0x06025F6A RID: 155498 RVA: 0x00967A80 File Offset: 0x00965C80
		public unsafe UChildActorComponent Cloud02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004FBB RID: 20411
		// (get) Token: 0x06025F6B RID: 155499 RVA: 0x00967A95 File Offset: 0x00965C95
		// (set) Token: 0x06025F6C RID: 155500 RVA: 0x00967AA9 File Offset: 0x00965CA9
		public unsafe UChildActorComponent Cloud01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004FBC RID: 20412
		// (get) Token: 0x06025F6D RID: 155501 RVA: 0x00967ABE File Offset: 0x00965CBE
		// (set) Token: 0x06025F6E RID: 155502 RVA: 0x00967AD2 File Offset: 0x00965CD2
		public unsafe USceneComponent BaseScale
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004FBD RID: 20413
		// (get) Token: 0x06025F6F RID: 155503 RVA: 0x00967AE7 File Offset: 0x00965CE7
		// (set) Token: 0x06025F70 RID: 155504 RVA: 0x00967AFB File Offset: 0x00965CFB
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004FBE RID: 20414
		// (get) Token: 0x06025F71 RID: 155505 RVA: 0x00967B10 File Offset: 0x00965D10
		// (set) Token: 0x06025F72 RID: 155506 RVA: 0x00967B25 File Offset: 0x00965D25
		[Nullable(1)]
		public TSoftObjectPtr<PD_CloudPrefab_C> CloudAssetInSeq1
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_6, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004FBF RID: 20415
		// (get) Token: 0x06025F73 RID: 155507 RVA: 0x00967B4A File Offset: 0x00965D4A
		// (set) Token: 0x06025F74 RID: 155508 RVA: 0x00967B5F File Offset: 0x00965D5F
		[Nullable(1)]
		public TSoftObjectPtr<PD_CloudPrefab_C> CloudAssetInSeq2
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_7, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004FC0 RID: 20416
		// (get) Token: 0x06025F75 RID: 155509 RVA: 0x00967B84 File Offset: 0x00965D84
		// (set) Token: 0x06025F76 RID: 155510 RVA: 0x00967B94 File Offset: 0x00965D94
		public unsafe bool GIControlSeqClouds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FC1 RID: 20417
		// (get) Token: 0x06025F77 RID: 155511 RVA: 0x00967BA5 File Offset: 0x00965DA5
		// (set) Token: 0x06025F78 RID: 155512 RVA: 0x00967BB5 File Offset: 0x00965DB5
		public unsafe int Cloud01TransSortPriorityAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004FC2 RID: 20418
		// (get) Token: 0x06025F79 RID: 155513 RVA: 0x00967BC6 File Offset: 0x00965DC6
		// (set) Token: 0x06025F7A RID: 155514 RVA: 0x00967BD6 File Offset: 0x00965DD6
		public unsafe float ChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004FC3 RID: 20419
		// (get) Token: 0x06025F7B RID: 155515 RVA: 0x00967BE7 File Offset: 0x00965DE7
		// (set) Token: 0x06025F7C RID: 155516 RVA: 0x00967BF7 File Offset: 0x00965DF7
		public unsafe bool Override_Cloud_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FC4 RID: 20420
		// (get) Token: 0x06025F7D RID: 155517 RVA: 0x00967C08 File Offset: 0x00965E08
		// (set) Token: 0x06025F7E RID: 155518 RVA: 0x00967C18 File Offset: 0x00965E18
		public unsafe float Cloud_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004FC5 RID: 20421
		// (get) Token: 0x06025F7F RID: 155519 RVA: 0x00967C29 File Offset: 0x00965E29
		// (set) Token: 0x06025F80 RID: 155520 RVA: 0x00967C39 File Offset: 0x00965E39
		public unsafe float Cloud_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004FC6 RID: 20422
		// (get) Token: 0x06025F81 RID: 155521 RVA: 0x00967C4A File Offset: 0x00965E4A
		// (set) Token: 0x06025F82 RID: 155522 RVA: 0x00967C5F File Offset: 0x00965E5F
		[Nullable(1)]
		public TSoftObjectPtr<PD_CloudPrefab_C> CloudAssetInSeq1_Temp
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_14, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004FC7 RID: 20423
		// (get) Token: 0x06025F83 RID: 155523 RVA: 0x00967C84 File Offset: 0x00965E84
		// (set) Token: 0x06025F84 RID: 155524 RVA: 0x00967C99 File Offset: 0x00965E99
		[Nullable(1)]
		public TSoftObjectPtr<PD_CloudPrefab_C> CloudAssetInSeq2_Temp
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_15, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_15, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004FC8 RID: 20424
		// (get) Token: 0x06025F85 RID: 155525 RVA: 0x00967CBE File Offset: 0x00965EBE
		// (set) Token: 0x06025F86 RID: 155526 RVA: 0x00967CCE File Offset: 0x00965ECE
		public unsafe int Cloud01TransSortPriorityAdd_Temp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004FC9 RID: 20425
		// (get) Token: 0x06025F87 RID: 155527 RVA: 0x00967CDF File Offset: 0x00965EDF
		// (set) Token: 0x06025F88 RID: 155528 RVA: 0x00967CEF File Offset: 0x00965EEF
		public unsafe float Cloud1Opacity_Temp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004FCA RID: 20426
		// (get) Token: 0x06025F89 RID: 155529 RVA: 0x00967D00 File Offset: 0x00965F00
		// (set) Token: 0x06025F8A RID: 155530 RVA: 0x00967D10 File Offset: 0x00965F10
		public unsafe float Cloud2Opacity_Temp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004FCB RID: 20427
		// (get) Token: 0x06025F8B RID: 155531 RVA: 0x00967D21 File Offset: 0x00965F21
		// (set) Token: 0x06025F8C RID: 155532 RVA: 0x00967D31 File Offset: 0x00965F31
		public unsafe bool IsReversed_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FCC RID: 20428
		// (get) Token: 0x06025F8D RID: 155533 RVA: 0x00967D42 File Offset: 0x00965F42
		// (set) Token: 0x06025F8E RID: 155534 RVA: 0x00967D52 File Offset: 0x00965F52
		public unsafe float ReversedZHeightBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004FCD RID: 20429
		// (get) Token: 0x06025F8F RID: 155535 RVA: 0x00967D63 File Offset: 0x00965F63
		// (set) Token: 0x06025F90 RID: 155536 RVA: 0x00967D73 File Offset: 0x00965F73
		public unsafe bool IsHiddenClouds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FCE RID: 20430
		// (get) Token: 0x06025F91 RID: 155537 RVA: 0x00967D84 File Offset: 0x00965F84
		// (set) Token: 0x06025F92 RID: 155538 RVA: 0x00967D94 File Offset: 0x00965F94
		public unsafe bool DoOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FCF RID: 20431
		// (get) Token: 0x06025F93 RID: 155539 RVA: 0x00967DA5 File Offset: 0x00965FA5
		// (set) Token: 0x06025F94 RID: 155540 RVA: 0x00967DB9 File Offset: 0x00965FB9
		public unsafe FLinearColor BG_TopColor_Temp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004FD0 RID: 20432
		// (get) Token: 0x06025F95 RID: 155541 RVA: 0x00967DCE File Offset: 0x00965FCE
		// (set) Token: 0x06025F96 RID: 155542 RVA: 0x00967DE2 File Offset: 0x00965FE2
		public unsafe FLinearColor BG_DownColor_Temp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004FD1 RID: 20433
		// (get) Token: 0x06025F97 RID: 155543 RVA: 0x00967DF7 File Offset: 0x00965FF7
		// (set) Token: 0x06025F98 RID: 155544 RVA: 0x00967E07 File Offset: 0x00966007
		public unsafe float BG_HighFade_Temp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004FD2 RID: 20434
		// (get) Token: 0x06025F99 RID: 155545 RVA: 0x00967E18 File Offset: 0x00966018
		// (set) Token: 0x06025F9A RID: 155546 RVA: 0x00967E28 File Offset: 0x00966028
		public unsafe float BG_HighPos_Temp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004FD3 RID: 20435
		// (get) Token: 0x06025F9B RID: 155547 RVA: 0x00967E39 File Offset: 0x00966039
		// (set) Token: 0x06025F9C RID: 155548 RVA: 0x00967E49 File Offset: 0x00966049
		public unsafe float BG_Opacity_Temp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004FD4 RID: 20436
		// (get) Token: 0x06025F9D RID: 155549 RVA: 0x00967E5A File Offset: 0x0096605A
		// (set) Token: 0x06025F9E RID: 155550 RVA: 0x00967E6A File Offset: 0x0096606A
		public unsafe bool IsCloudsChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FD5 RID: 20437
		// (get) Token: 0x06025F9F RID: 155551 RVA: 0x00967E7B File Offset: 0x0096607B
		// (set) Token: 0x06025FA0 RID: 155552 RVA: 0x00967E8B File Offset: 0x0096608B
		public unsafe bool IsBGChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FD6 RID: 20438
		// (get) Token: 0x06025FA1 RID: 155553 RVA: 0x00967E9C File Offset: 0x0096609C
		// (set) Token: 0x06025FA2 RID: 155554 RVA: 0x00967EAC File Offset: 0x009660AC
		public unsafe bool IsSetDA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FD7 RID: 20439
		// (get) Token: 0x06025FA3 RID: 155555 RVA: 0x00967EBD File Offset: 0x009660BD
		// (set) Token: 0x06025FA4 RID: 155556 RVA: 0x00967ECD File Offset: 0x009660CD
		public unsafe float Cloud1Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004FD8 RID: 20440
		// (get) Token: 0x06025FA5 RID: 155557 RVA: 0x00967EDE File Offset: 0x009660DE
		// (set) Token: 0x06025FA6 RID: 155558 RVA: 0x00967EEE File Offset: 0x009660EE
		public unsafe float Cloud2Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004FD9 RID: 20441
		// (get) Token: 0x06025FA7 RID: 155559 RVA: 0x00967EFF File Offset: 0x009660FF
		// (set) Token: 0x06025FA8 RID: 155560 RVA: 0x00967F13 File Offset: 0x00966113
		public unsafe FLinearColor BG_TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17004FDA RID: 20442
		// (get) Token: 0x06025FA9 RID: 155561 RVA: 0x00967F28 File Offset: 0x00966128
		// (set) Token: 0x06025FAA RID: 155562 RVA: 0x00967F3C File Offset: 0x0096613C
		public unsafe FLinearColor BG_DownColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004FDB RID: 20443
		// (get) Token: 0x06025FAB RID: 155563 RVA: 0x00967F51 File Offset: 0x00966151
		// (set) Token: 0x06025FAC RID: 155564 RVA: 0x00967F61 File Offset: 0x00966161
		public unsafe float BG_HighFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17004FDC RID: 20444
		// (get) Token: 0x06025FAD RID: 155565 RVA: 0x00967F72 File Offset: 0x00966172
		// (set) Token: 0x06025FAE RID: 155566 RVA: 0x00967F82 File Offset: 0x00966182
		public unsafe float BG_HighPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17004FDD RID: 20445
		// (get) Token: 0x06025FAF RID: 155567 RVA: 0x00967F93 File Offset: 0x00966193
		// (set) Token: 0x06025FB0 RID: 155568 RVA: 0x00967FA3 File Offset: 0x009661A3
		public unsafe float BG_Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqControlClouds_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17004FDE RID: 20446
		// (get) Token: 0x06025FB1 RID: 155569 RVA: 0x00967FB4 File Offset: 0x009661B4
		// (set) Token: 0x06025FB2 RID: 155570 RVA: 0x00967FC8 File Offset: 0x009661C8
		public unsafe UMaterialInstanceDynamic BG_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqControlClouds_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x06025FB3 RID: 155571 RVA: 0x00967FDD File Offset: 0x009661DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloudMainParamsUpdate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__CloudMainParamsUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x06025FB4 RID: 155572 RVA: 0x00967FF4 File Offset: 0x009661F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetCloudParameters(PD_CloudPrefab_C CloudPrefeb, UChildActorComponent CloudActorComponent)
		{
			BP_SeqControlClouds_C.__SetCloudParameters_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__SetCloudParameters_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_SeqControlClouds_C.__SetCloudParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__SetCloudParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPrefeb = ((CloudPrefeb != null) ? CloudPrefeb.NativePtr : IntPtr.Zero);
			ptr->CloudActorComponent = ((CloudActorComponent != null) ? CloudActorComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__SetCloudParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FB5 RID: 155573 RVA: 0x0096805F File Offset: 0x0096625F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void IsChangeDataAsset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__IsChangeDataAsset_NativeFunctionPtr, null);
		}

		// Token: 0x06025FB6 RID: 155574 RVA: 0x00968073 File Offset: 0x00966273
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__EndPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025FB7 RID: 155575 RVA: 0x00968088 File Offset: 0x00966288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Update(bool IsEditor)
		{
			BP_SeqControlClouds_C.__Update_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__Update_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_SeqControlClouds_C.__Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__Update_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FB8 RID: 155576 RVA: 0x009680CE File Offset: 0x009662CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitTemp()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__InitTemp_NativeFunctionPtr, null);
		}

		// Token: 0x06025FB9 RID: 155577 RVA: 0x009680E2 File Offset: 0x009662E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025FBA RID: 155578 RVA: 0x009680F6 File Offset: 0x009662F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqControlClouds_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025FBB RID: 155579 RVA: 0x0096810C File Offset: 0x0096630C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnLoaded_07220899417863CFE3A4D6848578EF8B(UObject Loaded)
		{
			BP_SeqControlClouds_C.__OnLoaded_07220899417863CFE3A4D6848578EF8B_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__OnLoaded_07220899417863CFE3A4D6848578EF8B_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqControlClouds_C.__OnLoaded_07220899417863CFE3A4D6848578EF8B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__OnLoaded_07220899417863CFE3A4D6848578EF8B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__OnLoaded_07220899417863CFE3A4D6848578EF8B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FBC RID: 155580 RVA: 0x00968164 File Offset: 0x00966364
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnLoaded_7C9A4D6E488C90912903E68A1CA2EF4E(UObject Loaded)
		{
			BP_SeqControlClouds_C.__OnLoaded_7C9A4D6E488C90912903E68A1CA2EF4E_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__OnLoaded_7C9A4D6E488C90912903E68A1CA2EF4E_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqControlClouds_C.__OnLoaded_7C9A4D6E488C90912903E68A1CA2EF4E_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__OnLoaded_7C9A4D6E488C90912903E68A1CA2EF4E_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__OnLoaded_7C9A4D6E488C90912903E68A1CA2EF4E_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FBD RID: 155581 RVA: 0x009681BC File Offset: 0x009663BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SeqControlClouds_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqControlClouds_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FBE RID: 155582 RVA: 0x00968208 File Offset: 0x00966408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SeqControlClouds_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SeqControlClouds_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqControlClouds_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025FBF RID: 155583 RVA: 0x00968254 File Offset: 0x00966454
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LoadAndSwitch(bool IsInEditor, bool IsReversed, float ReversedZHeightBias)
		{
			BP_SeqControlClouds_C.__LoadAndSwitch_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__LoadAndSwitch_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SeqControlClouds_C.__LoadAndSwitch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsInEditor = IsInEditor;
			ptr->IsReversed = IsReversed;
			ptr->ReversedZHeightBias = ReversedZHeightBias;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FC0 RID: 155584 RVA: 0x009682A8 File Offset: 0x009664A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SeqControlClouds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqControlClouds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FC1 RID: 155585 RVA: 0x009682F0 File Offset: 0x009664F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SeqControlClouds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqControlClouds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqControlClouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025FC2 RID: 155586 RVA: 0x00968337 File Offset: 0x00966537
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025FC3 RID: 155587 RVA: 0x0096834B File Offset: 0x0096654B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqControlClouds_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025FC4 RID: 155588 RVA: 0x00968360 File Offset: 0x00966560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SeqControlClouds_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqControlClouds_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqControlClouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FC5 RID: 155589 RVA: 0x009683A8 File Offset: 0x009665A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SeqControlClouds_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeqControlClouds_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqControlClouds_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqControlClouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqControlClouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025FC6 RID: 155590 RVA: 0x009683EF File Offset: 0x009665EF
		protected BP_SeqControlClouds_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012FDB RID: 77787
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_SeqControlClouds.BP_SeqControlClouds_C";

		// Token: 0x04012FDC RID: 77788
		private static IntPtr _ClassPtr;

		// Token: 0x04012FDD RID: 77789
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012FDE RID: 77790
		internal static int __PropertyOffset_1;

		// Token: 0x04012FDF RID: 77791
		internal static int __PropertyOffset_2;

		// Token: 0x04012FE0 RID: 77792
		internal static int __PropertyOffset_3;

		// Token: 0x04012FE1 RID: 77793
		internal static int __PropertyOffset_4;

		// Token: 0x04012FE2 RID: 77794
		internal static int __PropertyOffset_5;

		// Token: 0x04012FE3 RID: 77795
		internal static int __PropertyOffset_6;

		// Token: 0x04012FE4 RID: 77796
		internal static int __PropertyOffset_7;

		// Token: 0x04012FE5 RID: 77797
		internal static int __PropertyOffset_8;

		// Token: 0x04012FE6 RID: 77798
		internal static int __PropertyOffset_9;

		// Token: 0x04012FE7 RID: 77799
		internal static int __PropertyOffset_10;

		// Token: 0x04012FE8 RID: 77800
		internal static int __PropertyOffset_11;

		// Token: 0x04012FE9 RID: 77801
		internal static int __PropertyOffset_12;

		// Token: 0x04012FEA RID: 77802
		internal static int __PropertyOffset_13;

		// Token: 0x04012FEB RID: 77803
		internal static int __PropertyOffset_14;

		// Token: 0x04012FEC RID: 77804
		internal static int __PropertyOffset_15;

		// Token: 0x04012FED RID: 77805
		internal static int __PropertyOffset_16;

		// Token: 0x04012FEE RID: 77806
		internal static int __PropertyOffset_17;

		// Token: 0x04012FEF RID: 77807
		internal static int __PropertyOffset_18;

		// Token: 0x04012FF0 RID: 77808
		internal static int __PropertyOffset_19;

		// Token: 0x04012FF1 RID: 77809
		internal static int __PropertyOffset_20;

		// Token: 0x04012FF2 RID: 77810
		internal static int __PropertyOffset_21;

		// Token: 0x04012FF3 RID: 77811
		internal static int __PropertyOffset_22;

		// Token: 0x04012FF4 RID: 77812
		internal static int __PropertyOffset_23;

		// Token: 0x04012FF5 RID: 77813
		internal static int __PropertyOffset_24;

		// Token: 0x04012FF6 RID: 77814
		internal static int __PropertyOffset_25;

		// Token: 0x04012FF7 RID: 77815
		internal static int __PropertyOffset_26;

		// Token: 0x04012FF8 RID: 77816
		internal static int __PropertyOffset_27;

		// Token: 0x04012FF9 RID: 77817
		internal static int __PropertyOffset_28;

		// Token: 0x04012FFA RID: 77818
		internal static int __PropertyOffset_29;

		// Token: 0x04012FFB RID: 77819
		internal static int __PropertyOffset_30;

		// Token: 0x04012FFC RID: 77820
		internal static int __PropertyOffset_31;

		// Token: 0x04012FFD RID: 77821
		internal static int __PropertyOffset_32;

		// Token: 0x04012FFE RID: 77822
		internal static int __PropertyOffset_33;

		// Token: 0x04012FFF RID: 77823
		internal static int __PropertyOffset_34;

		// Token: 0x04013000 RID: 77824
		internal static int __PropertyOffset_35;

		// Token: 0x04013001 RID: 77825
		internal static int __PropertyOffset_36;

		// Token: 0x04013002 RID: 77826
		internal static int __PropertyOffset_37;

		// Token: 0x04013003 RID: 77827
		internal static int __PropertyOffset_38;

		// Token: 0x04013004 RID: 77828
		private static IntPtr __CloudMainParamsUpdate_NativeFunctionPtr;

		// Token: 0x04013005 RID: 77829
		private static IntPtr __SetCloudParameters_NativeFunctionPtr;

		// Token: 0x04013006 RID: 77830
		private static IntPtr __IsChangeDataAsset_NativeFunctionPtr;

		// Token: 0x04013007 RID: 77831
		private static IntPtr __EndPlay_NativeFunctionPtr;

		// Token: 0x04013008 RID: 77832
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04013009 RID: 77833
		private static IntPtr __InitTemp_NativeFunctionPtr;

		// Token: 0x0401300A RID: 77834
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401300B RID: 77835
		private static IntPtr __OnLoaded_07220899417863CFE3A4D6848578EF8B_NativeFunctionPtr;

		// Token: 0x0401300C RID: 77836
		private static IntPtr __OnLoaded_7C9A4D6E488C90912903E68A1CA2EF4E_NativeFunctionPtr;

		// Token: 0x0401300D RID: 77837
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0401300E RID: 77838
		private static IntPtr __LoadAndSwitch_NativeFunctionPtr;

		// Token: 0x0401300F RID: 77839
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013010 RID: 77840
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013011 RID: 77841
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A077 RID: 41079
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetCloudParameters_FunctionParams
		{
			// Token: 0x04031B6A RID: 203626
			[FieldOffset(0)]
			public IntPtr CloudPrefeb;

			// Token: 0x04031B6B RID: 203627
			[FieldOffset(8)]
			public IntPtr CloudActorComponent;
		}

		// Token: 0x0200A078 RID: 41080
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __Update_FunctionParams
		{
			// Token: 0x04031B6C RID: 203628
			[FieldOffset(0)]
			public bool IsEditor;
		}

		// Token: 0x0200A079 RID: 41081
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_07220899417863CFE3A4D6848578EF8B_FunctionParams
		{
			// Token: 0x04031B6D RID: 203629
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x0200A07A RID: 41082
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_7C9A4D6E488C90912903E68A1CA2EF4E_FunctionParams
		{
			// Token: 0x04031B6E RID: 203630
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x0200A07B RID: 41083
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031B6F RID: 203631
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x0200A07C RID: 41084
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __LoadAndSwitch_FunctionParams
		{
			// Token: 0x04031B70 RID: 203632
			[FieldOffset(0)]
			public bool IsInEditor;

			// Token: 0x04031B71 RID: 203633
			[FieldOffset(1)]
			public bool IsReversed;

			// Token: 0x04031B72 RID: 203634
			[FieldOffset(4)]
			public float ReversedZHeightBias;
		}

		// Token: 0x0200A07D RID: 41085
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031B73 RID: 203635
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A07E RID: 41086
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031B74 RID: 203636
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}

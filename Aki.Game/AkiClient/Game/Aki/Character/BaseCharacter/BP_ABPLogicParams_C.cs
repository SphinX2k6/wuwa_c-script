using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004278 RID: 17016
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_ABPLogicParams.BP_ABPLogicParams_C")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 361)]
	public class BP_ABPLogicParams_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C226 RID: 180774 RVA: 0x00A18070 File Offset: 0x00A16270
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ABPLogicParams_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_ABPLogicParams.BP_ABPLogicParams_C");
			}
			return BP_ABPLogicParams_C._ClassPtr;
		}

		// Token: 0x0602C227 RID: 180775 RVA: 0x00A18094 File Offset: 0x00A16294
		public BP_ABPLogicParams_C() : this(BuiltinUtils.AllocNativeUObject(BP_ABPLogicParams_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C228 RID: 180776 RVA: 0x00A180BC File Offset: 0x00A162BC
		[NullableContext(1)]
		public BP_ABPLogicParams_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ABPLogicParams_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DB2 RID: 28082
		// (get) Token: 0x0602C229 RID: 180777 RVA: 0x00A180EF File Offset: 0x00A162EF
		// (set) Token: 0x0602C22A RID: 180778 RVA: 0x00A180FF File Offset: 0x00A162FF
		public unsafe bool AcceptedNewBeHitRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DB3 RID: 28083
		// (get) Token: 0x0602C22B RID: 180779 RVA: 0x00A18110 File Offset: 0x00A16310
		// (set) Token: 0x0602C22C RID: 180780 RVA: 0x00A18124 File Offset: 0x00A16324
		public unsafe TEnumAsByte<EHitAnim> BeHitAnimRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006DB4 RID: 28084
		// (get) Token: 0x0602C22D RID: 180781 RVA: 0x00A18139 File Offset: 0x00A16339
		// (set) Token: 0x0602C22E RID: 180782 RVA: 0x00A18149 File Offset: 0x00A16349
		public unsafe bool EnterFkRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DB5 RID: 28085
		// (get) Token: 0x0602C22F RID: 180783 RVA: 0x00A1815A File Offset: 0x00A1635A
		// (set) Token: 0x0602C230 RID: 180784 RVA: 0x00A1816A File Offset: 0x00A1636A
		public unsafe bool DoubleHitInAirRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DB6 RID: 28086
		// (get) Token: 0x0602C231 RID: 180785 RVA: 0x00A1817B File Offset: 0x00A1637B
		// (set) Token: 0x0602C232 RID: 180786 RVA: 0x00A1818F File Offset: 0x00A1638F
		public unsafe FVector BeHitDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006DB7 RID: 28087
		// (get) Token: 0x0602C233 RID: 180787 RVA: 0x00A181A4 File Offset: 0x00A163A4
		// (set) Token: 0x0602C234 RID: 180788 RVA: 0x00A181B8 File Offset: 0x00A163B8
		public unsafe FVector BeHitLocationRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006DB8 RID: 28088
		// (get) Token: 0x0602C235 RID: 180789 RVA: 0x00A181CD File Offset: 0x00A163CD
		// (set) Token: 0x0602C236 RID: 180790 RVA: 0x00A181E1 File Offset: 0x00A163E1
		public unsafe TEnumAsByte<ECharState> CharMoveStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006DB9 RID: 28089
		// (get) Token: 0x0602C237 RID: 180791 RVA: 0x00A181F6 File Offset: 0x00A163F6
		// (set) Token: 0x0602C238 RID: 180792 RVA: 0x00A1820A File Offset: 0x00A1640A
		public unsafe TEnumAsByte<ECharParentMoveState> CharPositionStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006DBA RID: 28090
		// (get) Token: 0x0602C239 RID: 180793 RVA: 0x00A1821F File Offset: 0x00A1641F
		// (set) Token: 0x0602C23A RID: 180794 RVA: 0x00A18233 File Offset: 0x00A16433
		public unsafe TEnumAsByte<ECharViewDirectionState> CharCameraStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006DBB RID: 28091
		// (get) Token: 0x0602C23B RID: 180795 RVA: 0x00A18248 File Offset: 0x00A16448
		// (set) Token: 0x0602C23C RID: 180796 RVA: 0x00A18258 File Offset: 0x00A16458
		public unsafe float BattleIdleTimeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006DBC RID: 28092
		// (get) Token: 0x0602C23D RID: 180797 RVA: 0x00A18269 File Offset: 0x00A16469
		// (set) Token: 0x0602C23E RID: 180798 RVA: 0x00A18279 File Offset: 0x00A16479
		public unsafe float DegMovementSlopeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006DBD RID: 28093
		// (get) Token: 0x0602C23F RID: 180799 RVA: 0x00A1828A File Offset: 0x00A1648A
		// (set) Token: 0x0602C240 RID: 180800 RVA: 0x00A1829E File Offset: 0x00A1649E
		public unsafe FVector SightDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006DBE RID: 28094
		// (get) Token: 0x0602C241 RID: 180801 RVA: 0x00A182B3 File Offset: 0x00A164B3
		// (set) Token: 0x0602C242 RID: 180802 RVA: 0x00A182C3 File Offset: 0x00A164C3
		public unsafe bool RagQuitStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DBF RID: 28095
		// (get) Token: 0x0602C243 RID: 180803 RVA: 0x00A182D4 File Offset: 0x00A164D4
		// (set) Token: 0x0602C244 RID: 180804 RVA: 0x00A182E4 File Offset: 0x00A164E4
		public unsafe bool IsJumpRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DC0 RID: 28096
		// (get) Token: 0x0602C245 RID: 180805 RVA: 0x00A182F5 File Offset: 0x00A164F5
		// (set) Token: 0x0602C246 RID: 180806 RVA: 0x00A18309 File Offset: 0x00A16509
		public unsafe FVector AccelerationRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006DC1 RID: 28097
		// (get) Token: 0x0602C247 RID: 180807 RVA: 0x00A1831E File Offset: 0x00A1651E
		// (set) Token: 0x0602C248 RID: 180808 RVA: 0x00A1832E File Offset: 0x00A1652E
		public unsafe bool IsMovingRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DC2 RID: 28098
		// (get) Token: 0x0602C249 RID: 180809 RVA: 0x00A1833F File Offset: 0x00A1653F
		// (set) Token: 0x0602C24A RID: 180810 RVA: 0x00A1834F File Offset: 0x00A1654F
		public unsafe float SpeedRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006DC3 RID: 28099
		// (get) Token: 0x0602C24B RID: 180811 RVA: 0x00A18360 File Offset: 0x00A16560
		// (set) Token: 0x0602C24C RID: 180812 RVA: 0x00A18374 File Offset: 0x00A16574
		public unsafe FVector InputDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006DC4 RID: 28100
		// (get) Token: 0x0602C24D RID: 180813 RVA: 0x00A18389 File Offset: 0x00A16589
		// (set) Token: 0x0602C24E RID: 180814 RVA: 0x00A18399 File Offset: 0x00A16599
		public unsafe bool IsFallingIntoWaterRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DC5 RID: 28101
		// (get) Token: 0x0602C24F RID: 180815 RVA: 0x00A183AA File Offset: 0x00A165AA
		// (set) Token: 0x0602C250 RID: 180816 RVA: 0x00A183BA File Offset: 0x00A165BA
		public unsafe float GroundedTimeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006DC6 RID: 28102
		// (get) Token: 0x0602C251 RID: 180817 RVA: 0x00A183CB File Offset: 0x00A165CB
		// (set) Token: 0x0602C252 RID: 180818 RVA: 0x00A183DB File Offset: 0x00A165DB
		public unsafe bool HasMoveInputRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DC7 RID: 28103
		// (get) Token: 0x0602C253 RID: 180819 RVA: 0x00A183EC File Offset: 0x00A165EC
		// (set) Token: 0x0602C254 RID: 180820 RVA: 0x00A18400 File Offset: 0x00A16600
		public unsafe SClimbInfo ClimbInfoRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006DC8 RID: 28104
		// (get) Token: 0x0602C255 RID: 180821 RVA: 0x00A18415 File Offset: 0x00A16615
		// (set) Token: 0x0602C256 RID: 180822 RVA: 0x00A18429 File Offset: 0x00A16629
		public unsafe SClimbState ClimbStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006DC9 RID: 28105
		// (get) Token: 0x0602C257 RID: 180823 RVA: 0x00A1843E File Offset: 0x00A1663E
		// (set) Token: 0x0602C258 RID: 180824 RVA: 0x00A1844E File Offset: 0x00A1664E
		public unsafe float ClimbRadiusRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17006DCA RID: 28106
		// (get) Token: 0x0602C259 RID: 180825 RVA: 0x00A1845F File Offset: 0x00A1665F
		// (set) Token: 0x0602C25A RID: 180826 RVA: 0x00A18473 File Offset: 0x00A16673
		public unsafe FRotator InputRotatorRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17006DCB RID: 28107
		// (get) Token: 0x0602C25B RID: 180827 RVA: 0x00A18488 File Offset: 0x00A16688
		// (set) Token: 0x0602C25C RID: 180828 RVA: 0x00A18498 File Offset: 0x00A16698
		public unsafe float ClimbOnWallAngleRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17006DCC RID: 28108
		// (get) Token: 0x0602C25D RID: 180829 RVA: 0x00A184A9 File Offset: 0x00A166A9
		// (set) Token: 0x0602C25E RID: 180830 RVA: 0x00A184B9 File Offset: 0x00A166B9
		public unsafe float SprintSwimOffsetRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17006DCD RID: 28109
		// (get) Token: 0x0602C25F RID: 180831 RVA: 0x00A184CA File Offset: 0x00A166CA
		// (set) Token: 0x0602C260 RID: 180832 RVA: 0x00A184DA File Offset: 0x00A166DA
		public unsafe float SprintSwimOffsetLerpSpeedRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17006DCE RID: 28110
		// (get) Token: 0x0602C261 RID: 180833 RVA: 0x00A184EB File Offset: 0x00A166EB
		// (set) Token: 0x0602C262 RID: 180834 RVA: 0x00A184FF File Offset: 0x00A166FF
		public unsafe FVector SlideForwardRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17006DCF RID: 28111
		// (get) Token: 0x0602C263 RID: 180835 RVA: 0x00A18514 File Offset: 0x00A16714
		// (set) Token: 0x0602C264 RID: 180836 RVA: 0x00A18524 File Offset: 0x00A16724
		public unsafe bool SlideSwitchThisFrameRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DD0 RID: 28112
		// (get) Token: 0x0602C265 RID: 180837 RVA: 0x00A18535 File Offset: 0x00A16735
		// (set) Token: 0x0602C266 RID: 180838 RVA: 0x00A18545 File Offset: 0x00A16745
		public unsafe bool SlideStandModeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DD1 RID: 28113
		// (get) Token: 0x0602C267 RID: 180839 RVA: 0x00A18556 File Offset: 0x00A16756
		// (set) Token: 0x0602C268 RID: 180840 RVA: 0x00A18566 File Offset: 0x00A16766
		public unsafe float JumpUpRateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17006DD2 RID: 28114
		// (get) Token: 0x0602C269 RID: 180841 RVA: 0x00A18577 File Offset: 0x00A16777
		// (set) Token: 0x0602C26A RID: 180842 RVA: 0x00A1858B File Offset: 0x00A1678B
		public unsafe FVector2D LookAtRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17006DD3 RID: 28115
		// (get) Token: 0x0602C26B RID: 180843 RVA: 0x00A185A0 File Offset: 0x00A167A0
		// (set) Token: 0x0602C26C RID: 180844 RVA: 0x00A185B0 File Offset: 0x00A167B0
		public unsafe bool EnableBlendSpaceLookAtRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DD4 RID: 28116
		// (get) Token: 0x0602C26D RID: 180845 RVA: 0x00A185C1 File Offset: 0x00A167C1
		// (set) Token: 0x0602C26E RID: 180846 RVA: 0x00A185D1 File Offset: 0x00A167D1
		public unsafe bool IsDriver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DD5 RID: 28117
		// (get) Token: 0x0602C26F RID: 180847 RVA: 0x00A185E2 File Offset: 0x00A167E2
		// (set) Token: 0x0602C270 RID: 180848 RVA: 0x00A185F2 File Offset: 0x00A167F2
		public unsafe bool IsOnVehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DD6 RID: 28118
		// (get) Token: 0x0602C271 RID: 180849 RVA: 0x00A18604 File Offset: 0x00A16804
		// (set) Token: 0x0602C272 RID: 180850 RVA: 0x00A1863D File Offset: 0x00A1683D
		[Nullable(1)]
		public FIKTarget LeftHandIKTargetCS
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._LeftHandIKTargetCS) == null)
				{
					result = (this._LeftHandIKTargetCS = new FIKTarget(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_36, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_36, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006DD7 RID: 28119
		// (get) Token: 0x0602C273 RID: 180851 RVA: 0x00A18660 File Offset: 0x00A16860
		// (set) Token: 0x0602C274 RID: 180852 RVA: 0x00A18699 File Offset: 0x00A16899
		[Nullable(1)]
		public FIKTarget RightHandIKTargetCS
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._RightHandIKTargetCS) == null)
				{
					result = (this._RightHandIKTargetCS = new FIKTarget(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_37, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_37, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006DD8 RID: 28120
		// (get) Token: 0x0602C275 RID: 180853 RVA: 0x00A186BA File Offset: 0x00A168BA
		// (set) Token: 0x0602C276 RID: 180854 RVA: 0x00A186CA File Offset: 0x00A168CA
		public unsafe bool StateLowerBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DD9 RID: 28121
		// (get) Token: 0x0602C277 RID: 180855 RVA: 0x00A186DB File Offset: 0x00A168DB
		// (set) Token: 0x0602C278 RID: 180856 RVA: 0x00A186EB File Offset: 0x00A168EB
		public unsafe bool StateLeftArmBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DDA RID: 28122
		// (get) Token: 0x0602C279 RID: 180857 RVA: 0x00A186FC File Offset: 0x00A168FC
		// (set) Token: 0x0602C27A RID: 180858 RVA: 0x00A1870C File Offset: 0x00A1690C
		public unsafe bool StateRightArmBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DDB RID: 28123
		// (get) Token: 0x0602C27B RID: 180859 RVA: 0x00A1871D File Offset: 0x00A1691D
		// (set) Token: 0x0602C27C RID: 180860 RVA: 0x00A1872D File Offset: 0x00A1692D
		public unsafe bool IsHoldingHands
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DDC RID: 28124
		// (get) Token: 0x0602C27D RID: 180861 RVA: 0x00A1873E File Offset: 0x00A1693E
		// (set) Token: 0x0602C27E RID: 180862 RVA: 0x00A1874E File Offset: 0x00A1694E
		public unsafe bool IsBeHoldingHands
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DDD RID: 28125
		// (get) Token: 0x0602C27F RID: 180863 RVA: 0x00A1875F File Offset: 0x00A1695F
		// (set) Token: 0x0602C280 RID: 180864 RVA: 0x00A1876F File Offset: 0x00A1696F
		public unsafe bool IsHoldingHandsReachable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DDE RID: 28126
		// (get) Token: 0x0602C281 RID: 180865 RVA: 0x00A18780 File Offset: 0x00A16980
		// (set) Token: 0x0602C282 RID: 180866 RVA: 0x00A18790 File Offset: 0x00A16990
		public unsafe bool IsAcceptingInvitation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DDF RID: 28127
		// (get) Token: 0x0602C283 RID: 180867 RVA: 0x00A187A1 File Offset: 0x00A169A1
		// (set) Token: 0x0602C284 RID: 180868 RVA: 0x00A187B1 File Offset: 0x00A169B1
		public unsafe bool DisableBlinkRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DE0 RID: 28128
		// (get) Token: 0x0602C285 RID: 180869 RVA: 0x00A187C2 File Offset: 0x00A169C2
		// (set) Token: 0x0602C286 RID: 180870 RVA: 0x00A187D2 File Offset: 0x00A169D2
		public unsafe bool IsOnVehicleWithOther
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DE1 RID: 28129
		// (get) Token: 0x0602C287 RID: 180871 RVA: 0x00A187E3 File Offset: 0x00A169E3
		// (set) Token: 0x0602C288 RID: 180872 RVA: 0x00A187F3 File Offset: 0x00A169F3
		public unsafe int VehicleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17006DE2 RID: 28130
		// (get) Token: 0x0602C289 RID: 180873 RVA: 0x00A18804 File Offset: 0x00A16A04
		// (set) Token: 0x0602C28A RID: 180874 RVA: 0x00A18814 File Offset: 0x00A16A14
		public unsafe bool IgnoreMontageBlinkCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DE3 RID: 28131
		// (get) Token: 0x0602C28B RID: 180875 RVA: 0x00A18825 File Offset: 0x00A16A25
		// (set) Token: 0x0602C28C RID: 180876 RVA: 0x00A18835 File Offset: 0x00A16A35
		public unsafe bool IsRegionMoveModeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DE4 RID: 28132
		// (get) Token: 0x0602C28D RID: 180877 RVA: 0x00A18846 File Offset: 0x00A16A46
		// (set) Token: 0x0602C28E RID: 180878 RVA: 0x00A18856 File Offset: 0x00A16A56
		public unsafe bool DisableHumanIkRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DE5 RID: 28133
		// (get) Token: 0x0602C28F RID: 180879 RVA: 0x00A18867 File Offset: 0x00A16A67
		// (set) Token: 0x0602C290 RID: 180880 RVA: 0x00A18877 File Offset: 0x00A16A77
		public unsafe float TurnYawRateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17006DE6 RID: 28134
		// (get) Token: 0x0602C291 RID: 180881 RVA: 0x00A18888 File Offset: 0x00A16A88
		// (set) Token: 0x0602C292 RID: 180882 RVA: 0x00A18898 File Offset: 0x00A16A98
		public unsafe bool EnableAdditiveTurnRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_52) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_52) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C293 RID: 180883 RVA: 0x00A188A9 File Offset: 0x00A16AA9
		protected BP_ABPLogicParams_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401717E RID: 94590
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_ABPLogicParams.BP_ABPLogicParams_C";

		// Token: 0x0401717F RID: 94591
		private static IntPtr _ClassPtr;

		// Token: 0x04017180 RID: 94592
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017181 RID: 94593
		internal static int __PropertyOffset_0;

		// Token: 0x04017182 RID: 94594
		internal static int __PropertyOffset_1;

		// Token: 0x04017183 RID: 94595
		internal static int __PropertyOffset_2;

		// Token: 0x04017184 RID: 94596
		internal static int __PropertyOffset_3;

		// Token: 0x04017185 RID: 94597
		internal static int __PropertyOffset_4;

		// Token: 0x04017186 RID: 94598
		internal static int __PropertyOffset_5;

		// Token: 0x04017187 RID: 94599
		internal static int __PropertyOffset_6;

		// Token: 0x04017188 RID: 94600
		internal static int __PropertyOffset_7;

		// Token: 0x04017189 RID: 94601
		internal static int __PropertyOffset_8;

		// Token: 0x0401718A RID: 94602
		internal static int __PropertyOffset_9;

		// Token: 0x0401718B RID: 94603
		internal static int __PropertyOffset_10;

		// Token: 0x0401718C RID: 94604
		internal static int __PropertyOffset_11;

		// Token: 0x0401718D RID: 94605
		internal static int __PropertyOffset_12;

		// Token: 0x0401718E RID: 94606
		internal static int __PropertyOffset_13;

		// Token: 0x0401718F RID: 94607
		internal static int __PropertyOffset_14;

		// Token: 0x04017190 RID: 94608
		internal static int __PropertyOffset_15;

		// Token: 0x04017191 RID: 94609
		internal static int __PropertyOffset_16;

		// Token: 0x04017192 RID: 94610
		internal static int __PropertyOffset_17;

		// Token: 0x04017193 RID: 94611
		internal static int __PropertyOffset_18;

		// Token: 0x04017194 RID: 94612
		internal static int __PropertyOffset_19;

		// Token: 0x04017195 RID: 94613
		internal static int __PropertyOffset_20;

		// Token: 0x04017196 RID: 94614
		internal static int __PropertyOffset_21;

		// Token: 0x04017197 RID: 94615
		internal static int __PropertyOffset_22;

		// Token: 0x04017198 RID: 94616
		internal static int __PropertyOffset_23;

		// Token: 0x04017199 RID: 94617
		internal static int __PropertyOffset_24;

		// Token: 0x0401719A RID: 94618
		internal static int __PropertyOffset_25;

		// Token: 0x0401719B RID: 94619
		internal static int __PropertyOffset_26;

		// Token: 0x0401719C RID: 94620
		internal static int __PropertyOffset_27;

		// Token: 0x0401719D RID: 94621
		internal static int __PropertyOffset_28;

		// Token: 0x0401719E RID: 94622
		internal static int __PropertyOffset_29;

		// Token: 0x0401719F RID: 94623
		internal static int __PropertyOffset_30;

		// Token: 0x040171A0 RID: 94624
		internal static int __PropertyOffset_31;

		// Token: 0x040171A1 RID: 94625
		internal static int __PropertyOffset_32;

		// Token: 0x040171A2 RID: 94626
		internal static int __PropertyOffset_33;

		// Token: 0x040171A3 RID: 94627
		internal static int __PropertyOffset_34;

		// Token: 0x040171A4 RID: 94628
		internal static int __PropertyOffset_35;

		// Token: 0x040171A5 RID: 94629
		internal static int __PropertyOffset_36;

		// Token: 0x040171A6 RID: 94630
		[Nullable(2)]
		private FIKTarget _LeftHandIKTargetCS;

		// Token: 0x040171A7 RID: 94631
		internal static int __PropertyOffset_37;

		// Token: 0x040171A8 RID: 94632
		[Nullable(2)]
		private FIKTarget _RightHandIKTargetCS;

		// Token: 0x040171A9 RID: 94633
		internal static int __PropertyOffset_38;

		// Token: 0x040171AA RID: 94634
		internal static int __PropertyOffset_39;

		// Token: 0x040171AB RID: 94635
		internal static int __PropertyOffset_40;

		// Token: 0x040171AC RID: 94636
		internal static int __PropertyOffset_41;

		// Token: 0x040171AD RID: 94637
		internal static int __PropertyOffset_42;

		// Token: 0x040171AE RID: 94638
		internal static int __PropertyOffset_43;

		// Token: 0x040171AF RID: 94639
		internal static int __PropertyOffset_44;

		// Token: 0x040171B0 RID: 94640
		internal static int __PropertyOffset_45;

		// Token: 0x040171B1 RID: 94641
		internal static int __PropertyOffset_46;

		// Token: 0x040171B2 RID: 94642
		internal static int __PropertyOffset_47;

		// Token: 0x040171B3 RID: 94643
		internal static int __PropertyOffset_48;

		// Token: 0x040171B4 RID: 94644
		internal static int __PropertyOffset_49;

		// Token: 0x040171B5 RID: 94645
		internal static int __PropertyOffset_50;

		// Token: 0x040171B6 RID: 94646
		internal static int __PropertyOffset_51;

		// Token: 0x040171B7 RID: 94647
		internal static int __PropertyOffset_52;
	}
}

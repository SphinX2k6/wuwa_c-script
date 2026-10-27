using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Follower.Chair
{
	// Token: 0x02003F4E RID: 16206
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Follower/Chair/BP_PlayerFollowerChairConfig.BP_PlayerFollowerChairConfig_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class BP_PlayerFollowerChairConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029422 RID: 168994 RVA: 0x009BFA07 File Offset: 0x009BDC07
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlayerFollowerChairConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Follower/Chair/BP_PlayerFollowerChairConfig.BP_PlayerFollowerChairConfig_C");
			}
			return BP_PlayerFollowerChairConfig_C._ClassPtr;
		}

		// Token: 0x06029423 RID: 168995 RVA: 0x009BFA2C File Offset: 0x009BDC2C
		public BP_PlayerFollowerChairConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlayerFollowerChairConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029424 RID: 168996 RVA: 0x009BFA54 File Offset: 0x009BDC54
		public BP_PlayerFollowerChairConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlayerFollowerChairConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700624E RID: 25166
		// (get) Token: 0x06029425 RID: 168997 RVA: 0x009BFA87 File Offset: 0x009BDC87
		// (set) Token: 0x06029426 RID: 168998 RVA: 0x009BFA97 File Offset: 0x009BDC97
		public unsafe float AutoHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700624F RID: 25167
		// (get) Token: 0x06029427 RID: 168999 RVA: 0x009BFAA8 File Offset: 0x009BDCA8
		// (set) Token: 0x06029428 RID: 169000 RVA: 0x009BFAB8 File Offset: 0x009BDCB8
		public unsafe float AutoHideDelayMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006250 RID: 25168
		// (get) Token: 0x06029429 RID: 169001 RVA: 0x009BFAC9 File Offset: 0x009BDCC9
		// (set) Token: 0x0602942A RID: 169002 RVA: 0x009BFAD9 File Offset: 0x009BDCD9
		public unsafe float MaxSummonHeightUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006251 RID: 25169
		// (get) Token: 0x0602942B RID: 169003 RVA: 0x009BFAEA File Offset: 0x009BDCEA
		// (set) Token: 0x0602942C RID: 169004 RVA: 0x009BFAFA File Offset: 0x009BDCFA
		public unsafe float MaxSummonHeightDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006252 RID: 25170
		// (get) Token: 0x0602942D RID: 169005 RVA: 0x009BFB0B File Offset: 0x009BDD0B
		// (set) Token: 0x0602942E RID: 169006 RVA: 0x009BFB1B File Offset: 0x009BDD1B
		public unsafe float GroundProbeDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006253 RID: 25171
		// (get) Token: 0x0602942F RID: 169007 RVA: 0x009BFB2C File Offset: 0x009BDD2C
		// (set) Token: 0x06029430 RID: 169008 RVA: 0x009BFB3C File Offset: 0x009BDD3C
		public unsafe float SummonHeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006254 RID: 25172
		// (get) Token: 0x06029431 RID: 169009 RVA: 0x009BFB4D File Offset: 0x009BDD4D
		// (set) Token: 0x06029432 RID: 169010 RVA: 0x009BFB5D File Offset: 0x009BDD5D
		public unsafe float GroundFlatTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006255 RID: 25173
		// (get) Token: 0x06029433 RID: 169011 RVA: 0x009BFB6E File Offset: 0x009BDD6E
		// (set) Token: 0x06029434 RID: 169012 RVA: 0x009BFB82 File Offset: 0x009BDD82
		public unsafe FVector FrontDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006256 RID: 25174
		// (get) Token: 0x06029435 RID: 169013 RVA: 0x009BFB97 File Offset: 0x009BDD97
		// (set) Token: 0x06029436 RID: 169014 RVA: 0x009BFBA7 File Offset: 0x009BDDA7
		public unsafe float ReSummonBlockDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006257 RID: 25175
		// (get) Token: 0x06029437 RID: 169015 RVA: 0x009BFBB8 File Offset: 0x009BDDB8
		// (set) Token: 0x06029438 RID: 169016 RVA: 0x009BFBC8 File Offset: 0x009BDDC8
		public unsafe float MinDistanceToOtherChair
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006258 RID: 25176
		// (get) Token: 0x06029439 RID: 169017 RVA: 0x009BFBD9 File Offset: 0x009BDDD9
		// (set) Token: 0x0602943A RID: 169018 RVA: 0x009BFBE9 File Offset: 0x009BDDE9
		public unsafe float MaxWaterDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006259 RID: 25177
		// (get) Token: 0x0602943B RID: 169019 RVA: 0x009BFBFA File Offset: 0x009BDDFA
		// (set) Token: 0x0602943C RID: 169020 RVA: 0x009BFC0A File Offset: 0x009BDE0A
		public unsafe bool EnableBlockTraceCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700625A RID: 25178
		// (get) Token: 0x0602943D RID: 169021 RVA: 0x009BFC1B File Offset: 0x009BDE1B
		// (set) Token: 0x0602943E RID: 169022 RVA: 0x009BFC2F File Offset: 0x009BDE2F
		[Nullable(0)]
		public unsafe TEnumAsByte<ETraceTypeQuery> BlockCheckTraceType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_12);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700625B RID: 25179
		// (get) Token: 0x0602943F RID: 169023 RVA: 0x009BFC44 File Offset: 0x009BDE44
		// (set) Token: 0x06029440 RID: 169024 RVA: 0x009BFC54 File Offset: 0x009BDE54
		public unsafe bool EnableBlockObjectCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700625C RID: 25180
		// (get) Token: 0x06029441 RID: 169025 RVA: 0x009BFC68 File Offset: 0x009BDE68
		// (set) Token: 0x06029442 RID: 169026 RVA: 0x009BFCA1 File Offset: 0x009BDEA1
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> BlockCheckObjectTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._BlockCheckObjectTypes) == null)
				{
					result = (this._BlockCheckObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.BlockCheckObjectTypes.CopyAssign(value);
			}
		}

		// Token: 0x1700625D RID: 25181
		// (get) Token: 0x06029443 RID: 169027 RVA: 0x009BFCAF File Offset: 0x009BDEAF
		// (set) Token: 0x06029444 RID: 169028 RVA: 0x009BFCBF File Offset: 0x009BDEBF
		public unsafe bool EnableBlockProfileCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700625E RID: 25182
		// (get) Token: 0x06029445 RID: 169029 RVA: 0x009BFCD0 File Offset: 0x009BDED0
		// (set) Token: 0x06029446 RID: 169030 RVA: 0x009BFD09 File Offset: 0x009BDF09
		public FCollisionProfileName BlockCheckProfileName
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._BlockCheckProfileName) == null)
				{
					result = (this._BlockCheckProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_16, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700625F RID: 25183
		// (get) Token: 0x06029447 RID: 169031 RVA: 0x009BFD2A File Offset: 0x009BDF2A
		// (set) Token: 0x06029448 RID: 169032 RVA: 0x009BFD3A File Offset: 0x009BDF3A
		public unsafe bool EnableOverlapCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006260 RID: 25184
		// (get) Token: 0x06029449 RID: 169033 RVA: 0x009BFD4C File Offset: 0x009BDF4C
		// (set) Token: 0x0602944A RID: 169034 RVA: 0x009BFD85 File Offset: 0x009BDF85
		public FCollisionProfileName OverlapProfileName
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._OverlapProfileName) == null)
				{
					result = (this._OverlapProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_18, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006261 RID: 25185
		// (get) Token: 0x0602944B RID: 169035 RVA: 0x009BFDA6 File Offset: 0x009BDFA6
		// (set) Token: 0x0602944C RID: 169036 RVA: 0x009BFDB6 File Offset: 0x009BDFB6
		public unsafe bool EnableTickGroundCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006262 RID: 25186
		// (get) Token: 0x0602944D RID: 169037 RVA: 0x009BFDC7 File Offset: 0x009BDFC7
		// (set) Token: 0x0602944E RID: 169038 RVA: 0x009BFDD7 File Offset: 0x009BDFD7
		public unsafe float TickGroundCheckIntervalMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006263 RID: 25187
		// (get) Token: 0x0602944F RID: 169039 RVA: 0x009BFDE8 File Offset: 0x009BDFE8
		// (set) Token: 0x06029450 RID: 169040 RVA: 0x009BFDF8 File Offset: 0x009BDFF8
		public unsafe float OverlapDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006264 RID: 25188
		// (get) Token: 0x06029451 RID: 169041 RVA: 0x009BFE09 File Offset: 0x009BE009
		// (set) Token: 0x06029452 RID: 169042 RVA: 0x009BFE19 File Offset: 0x009BE019
		public unsafe bool CheckGroundMobility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006265 RID: 25189
		// (get) Token: 0x06029453 RID: 169043 RVA: 0x009BFE2A File Offset: 0x009BE02A
		// (set) Token: 0x06029454 RID: 169044 RVA: 0x009BFE3A File Offset: 0x009BE03A
		public unsafe bool EnableTickCheckPlayerMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006266 RID: 25190
		// (get) Token: 0x06029455 RID: 169045 RVA: 0x009BFE4B File Offset: 0x009BE04B
		// (set) Token: 0x06029456 RID: 169046 RVA: 0x009BFE5B File Offset: 0x009BE05B
		public unsafe float TickCheckPlayerMovementLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17006267 RID: 25191
		// (get) Token: 0x06029457 RID: 169047 RVA: 0x009BFE6C File Offset: 0x009BE06C
		// (set) Token: 0x06029458 RID: 169048 RVA: 0x009BFE7C File Offset: 0x009BE07C
		public unsafe float TickPlayerMoveCheckIntervalMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x06029459 RID: 169049 RVA: 0x009BFE8D File Offset: 0x009BE08D
		protected BP_PlayerFollowerChairConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015217 RID: 86551
		public new const string __ObjectPath = "/Game/Aki/Data/Follower/Chair/BP_PlayerFollowerChairConfig.BP_PlayerFollowerChairConfig_C";

		// Token: 0x04015218 RID: 86552
		private static IntPtr _ClassPtr;

		// Token: 0x04015219 RID: 86553
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401521A RID: 86554
		internal static int __PropertyOffset_0;

		// Token: 0x0401521B RID: 86555
		internal static int __PropertyOffset_1;

		// Token: 0x0401521C RID: 86556
		internal static int __PropertyOffset_2;

		// Token: 0x0401521D RID: 86557
		internal static int __PropertyOffset_3;

		// Token: 0x0401521E RID: 86558
		internal static int __PropertyOffset_4;

		// Token: 0x0401521F RID: 86559
		internal static int __PropertyOffset_5;

		// Token: 0x04015220 RID: 86560
		internal static int __PropertyOffset_6;

		// Token: 0x04015221 RID: 86561
		internal static int __PropertyOffset_7;

		// Token: 0x04015222 RID: 86562
		internal static int __PropertyOffset_8;

		// Token: 0x04015223 RID: 86563
		internal static int __PropertyOffset_9;

		// Token: 0x04015224 RID: 86564
		internal static int __PropertyOffset_10;

		// Token: 0x04015225 RID: 86565
		internal static int __PropertyOffset_11;

		// Token: 0x04015226 RID: 86566
		internal static int __PropertyOffset_12;

		// Token: 0x04015227 RID: 86567
		internal static int __PropertyOffset_13;

		// Token: 0x04015228 RID: 86568
		internal static int __PropertyOffset_14;

		// Token: 0x04015229 RID: 86569
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _BlockCheckObjectTypes;

		// Token: 0x0401522A RID: 86570
		internal static int __PropertyOffset_15;

		// Token: 0x0401522B RID: 86571
		internal static int __PropertyOffset_16;

		// Token: 0x0401522C RID: 86572
		[Nullable(2)]
		private FCollisionProfileName _BlockCheckProfileName;

		// Token: 0x0401522D RID: 86573
		internal static int __PropertyOffset_17;

		// Token: 0x0401522E RID: 86574
		internal static int __PropertyOffset_18;

		// Token: 0x0401522F RID: 86575
		[Nullable(2)]
		private FCollisionProfileName _OverlapProfileName;

		// Token: 0x04015230 RID: 86576
		internal static int __PropertyOffset_19;

		// Token: 0x04015231 RID: 86577
		internal static int __PropertyOffset_20;

		// Token: 0x04015232 RID: 86578
		internal static int __PropertyOffset_21;

		// Token: 0x04015233 RID: 86579
		internal static int __PropertyOffset_22;

		// Token: 0x04015234 RID: 86580
		internal static int __PropertyOffset_23;

		// Token: 0x04015235 RID: 86581
		internal static int __PropertyOffset_24;

		// Token: 0x04015236 RID: 86582
		internal static int __PropertyOffset_25;
	}
}

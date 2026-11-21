using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Follower.Chair
{
	// Token: 0x020031F4 RID: 12788
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Follower/Chair/BP_PlayerFollowerChairConfig.BP_PlayerFollowerChairConfig_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class BP_PlayerFollowerChairConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FCF9 RID: 130297 RVA: 0x00936518 File Offset: 0x00934718
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlayerFollowerChairConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Follower/Chair/BP_PlayerFollowerChairConfig.BP_PlayerFollowerChairConfig_C");
			}
			return BP_PlayerFollowerChairConfig_C._ClassPtr;
		}

		// Token: 0x0601FCFA RID: 130298 RVA: 0x0093653C File Offset: 0x0093473C
		public BP_PlayerFollowerChairConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlayerFollowerChairConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FCFB RID: 130299 RVA: 0x00936564 File Offset: 0x00934764
		public BP_PlayerFollowerChairConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlayerFollowerChairConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x0601FCFC RID: 130300 RVA: 0x00936597 File Offset: 0x00934797
		// (set) Token: 0x0601FCFD RID: 130301 RVA: 0x009365A7 File Offset: 0x009347A7
		public unsafe float AutoHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_AutoHideDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_AutoHideDistance) = value;
			}
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x0601FCFE RID: 130302 RVA: 0x009365B8 File Offset: 0x009347B8
		// (set) Token: 0x0601FCFF RID: 130303 RVA: 0x009365C8 File Offset: 0x009347C8
		public unsafe float AutoHideDelayMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_AutoHideDelayMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_AutoHideDelayMs) = value;
			}
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x0601FD00 RID: 130304 RVA: 0x009365D9 File Offset: 0x009347D9
		// (set) Token: 0x0601FD01 RID: 130305 RVA: 0x009365E9 File Offset: 0x009347E9
		public unsafe float MaxSummonHeightUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_MaxSummonHeightUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_MaxSummonHeightUp) = value;
			}
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x0601FD02 RID: 130306 RVA: 0x009365FA File Offset: 0x009347FA
		// (set) Token: 0x0601FD03 RID: 130307 RVA: 0x0093660A File Offset: 0x0093480A
		public unsafe float MaxSummonHeightDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_MaxSummonHeightDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_MaxSummonHeightDown) = value;
			}
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x0601FD04 RID: 130308 RVA: 0x0093661B File Offset: 0x0093481B
		// (set) Token: 0x0601FD05 RID: 130309 RVA: 0x0093662B File Offset: 0x0093482B
		public unsafe float GroundProbeDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_GroundProbeDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_GroundProbeDepth) = value;
			}
		}

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x0601FD06 RID: 130310 RVA: 0x0093663C File Offset: 0x0093483C
		// (set) Token: 0x0601FD07 RID: 130311 RVA: 0x0093664C File Offset: 0x0093484C
		public unsafe float SummonHeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_SummonHeightOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_SummonHeightOffset) = value;
			}
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x0601FD08 RID: 130312 RVA: 0x0093665D File Offset: 0x0093485D
		// (set) Token: 0x0601FD09 RID: 130313 RVA: 0x0093666D File Offset: 0x0093486D
		public unsafe float GroundFlatTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_GroundFlatTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_GroundFlatTolerance) = value;
			}
		}

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x0601FD0A RID: 130314 RVA: 0x0093667E File Offset: 0x0093487E
		// (set) Token: 0x0601FD0B RID: 130315 RVA: 0x00936692 File Offset: 0x00934892
		public unsafe FVector FrontDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_FrontDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_FrontDirection) = value;
			}
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x0601FD0C RID: 130316 RVA: 0x009366A7 File Offset: 0x009348A7
		// (set) Token: 0x0601FD0D RID: 130317 RVA: 0x009366B7 File Offset: 0x009348B7
		public unsafe float ReSummonBlockDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_ReSummonBlockDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_ReSummonBlockDistance) = value;
			}
		}

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x0601FD0E RID: 130318 RVA: 0x009366C8 File Offset: 0x009348C8
		// (set) Token: 0x0601FD0F RID: 130319 RVA: 0x009366D8 File Offset: 0x009348D8
		public unsafe float MinDistanceToOtherChair
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_MinDistanceToOtherChair);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_MinDistanceToOtherChair) = value;
			}
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x0601FD10 RID: 130320 RVA: 0x009366E9 File Offset: 0x009348E9
		// (set) Token: 0x0601FD11 RID: 130321 RVA: 0x009366F9 File Offset: 0x009348F9
		public unsafe float MaxWaterDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_MaxWaterDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_MaxWaterDepth) = value;
			}
		}

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x0601FD12 RID: 130322 RVA: 0x0093670A File Offset: 0x0093490A
		// (set) Token: 0x0601FD13 RID: 130323 RVA: 0x0093671A File Offset: 0x0093491A
		public unsafe bool EnableBlockTraceCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableBlockTraceCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableBlockTraceCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x0601FD14 RID: 130324 RVA: 0x0093672B File Offset: 0x0093492B
		// (set) Token: 0x0601FD15 RID: 130325 RVA: 0x0093673F File Offset: 0x0093493F
		[Nullable(0)]
		public unsafe TEnumAsByte<ETraceTypeQuery> BlockCheckTraceType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_BlockCheckTraceType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_BlockCheckTraceType) = value;
			}
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x0601FD16 RID: 130326 RVA: 0x00936754 File Offset: 0x00934954
		// (set) Token: 0x0601FD17 RID: 130327 RVA: 0x00936764 File Offset: 0x00934964
		public unsafe bool EnableBlockObjectCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableBlockObjectCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableBlockObjectCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x0601FD18 RID: 130328 RVA: 0x00936778 File Offset: 0x00934978
		// (set) Token: 0x0601FD19 RID: 130329 RVA: 0x009367B1 File Offset: 0x009349B1
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
					result = (this._BlockCheckObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_BlockCheckObjectTypes, this));
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

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x0601FD1A RID: 130330 RVA: 0x009367BF File Offset: 0x009349BF
		// (set) Token: 0x0601FD1B RID: 130331 RVA: 0x009367CF File Offset: 0x009349CF
		public unsafe bool EnableBlockProfileCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableBlockProfileCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableBlockProfileCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0601FD1C RID: 130332 RVA: 0x009367E0 File Offset: 0x009349E0
		// (set) Token: 0x0601FD1D RID: 130333 RVA: 0x00936819 File Offset: 0x00934A19
		public FCollisionProfileName BlockCheckProfileName
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._BlockCheckProfileName) == null)
				{
					result = (this._BlockCheckProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_BlockCheckProfileName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_BlockCheckProfileName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0601FD1E RID: 130334 RVA: 0x0093683A File Offset: 0x00934A3A
		// (set) Token: 0x0601FD1F RID: 130335 RVA: 0x0093684A File Offset: 0x00934A4A
		public unsafe bool EnableOverlapCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableOverlapCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableOverlapCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x0601FD20 RID: 130336 RVA: 0x0093685C File Offset: 0x00934A5C
		// (set) Token: 0x0601FD21 RID: 130337 RVA: 0x00936895 File Offset: 0x00934A95
		public FCollisionProfileName OverlapProfileName
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._OverlapProfileName) == null)
				{
					result = (this._OverlapProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_OverlapProfileName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_OverlapProfileName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x0601FD22 RID: 130338 RVA: 0x009368B6 File Offset: 0x00934AB6
		// (set) Token: 0x0601FD23 RID: 130339 RVA: 0x009368C6 File Offset: 0x00934AC6
		public unsafe bool EnableTickGroundCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableTickGroundCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableTickGroundCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x0601FD24 RID: 130340 RVA: 0x009368D7 File Offset: 0x00934AD7
		// (set) Token: 0x0601FD25 RID: 130341 RVA: 0x009368E7 File Offset: 0x00934AE7
		public unsafe float TickGroundCheckIntervalMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_TickGroundCheckIntervalMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_TickGroundCheckIntervalMs) = value;
			}
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x0601FD26 RID: 130342 RVA: 0x009368F8 File Offset: 0x00934AF8
		// (set) Token: 0x0601FD27 RID: 130343 RVA: 0x00936908 File Offset: 0x00934B08
		public unsafe float OverlapDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_OverlapDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_OverlapDuration) = value;
			}
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x0601FD28 RID: 130344 RVA: 0x00936919 File Offset: 0x00934B19
		// (set) Token: 0x0601FD29 RID: 130345 RVA: 0x00936929 File Offset: 0x00934B29
		public unsafe bool CheckGroundMobility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_CheckGroundMobility) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_CheckGroundMobility) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x0601FD2A RID: 130346 RVA: 0x0093693A File Offset: 0x00934B3A
		// (set) Token: 0x0601FD2B RID: 130347 RVA: 0x0093694A File Offset: 0x00934B4A
		public unsafe bool EnableTickCheckPlayerMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableTickCheckPlayerMovement) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_EnableTickCheckPlayerMovement) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0601FD2C RID: 130348 RVA: 0x0093695B File Offset: 0x00934B5B
		// (set) Token: 0x0601FD2D RID: 130349 RVA: 0x0093696B File Offset: 0x00934B6B
		public unsafe float TickCheckPlayerMovementLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_TickCheckPlayerMovementLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_TickCheckPlayerMovementLength) = value;
			}
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0601FD2E RID: 130350 RVA: 0x0093697C File Offset: 0x00934B7C
		// (set) Token: 0x0601FD2F RID: 130351 RVA: 0x0093698C File Offset: 0x00934B8C
		public unsafe float TickPlayerMoveCheckIntervalMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_TickPlayerMoveCheckIntervalMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerFollowerChairConfig_C.__PropertyOffset_TickPlayerMoveCheckIntervalMs) = value;
			}
		}

		// Token: 0x0601FD30 RID: 130352 RVA: 0x0093699D File Offset: 0x00934B9D
		protected BP_PlayerFollowerChairConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401112F RID: 69935
		public new const string __ObjectPath = "/Game/Aki/Data/Follower/Chair/BP_PlayerFollowerChairConfig.BP_PlayerFollowerChairConfig_C";

		// Token: 0x04011130 RID: 69936
		private static IntPtr _ClassPtr;

		// Token: 0x04011131 RID: 69937
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011132 RID: 69938
		internal static int __PropertyOffset_AutoHideDistance;

		// Token: 0x04011133 RID: 69939
		internal static int __PropertyOffset_AutoHideDelayMs;

		// Token: 0x04011134 RID: 69940
		internal static int __PropertyOffset_MaxSummonHeightUp;

		// Token: 0x04011135 RID: 69941
		internal static int __PropertyOffset_MaxSummonHeightDown;

		// Token: 0x04011136 RID: 69942
		internal static int __PropertyOffset_GroundProbeDepth;

		// Token: 0x04011137 RID: 69943
		internal static int __PropertyOffset_SummonHeightOffset;

		// Token: 0x04011138 RID: 69944
		internal static int __PropertyOffset_GroundFlatTolerance;

		// Token: 0x04011139 RID: 69945
		internal static int __PropertyOffset_FrontDirection;

		// Token: 0x0401113A RID: 69946
		internal static int __PropertyOffset_ReSummonBlockDistance;

		// Token: 0x0401113B RID: 69947
		internal static int __PropertyOffset_MinDistanceToOtherChair;

		// Token: 0x0401113C RID: 69948
		internal static int __PropertyOffset_MaxWaterDepth;

		// Token: 0x0401113D RID: 69949
		internal static int __PropertyOffset_EnableBlockTraceCheck;

		// Token: 0x0401113E RID: 69950
		internal static int __PropertyOffset_BlockCheckTraceType;

		// Token: 0x0401113F RID: 69951
		internal static int __PropertyOffset_EnableBlockObjectCheck;

		// Token: 0x04011140 RID: 69952
		internal static int __PropertyOffset_BlockCheckObjectTypes;

		// Token: 0x04011141 RID: 69953
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _BlockCheckObjectTypes;

		// Token: 0x04011142 RID: 69954
		internal static int __PropertyOffset_EnableBlockProfileCheck;

		// Token: 0x04011143 RID: 69955
		internal static int __PropertyOffset_BlockCheckProfileName;

		// Token: 0x04011144 RID: 69956
		[Nullable(2)]
		private FCollisionProfileName _BlockCheckProfileName;

		// Token: 0x04011145 RID: 69957
		internal static int __PropertyOffset_EnableOverlapCheck;

		// Token: 0x04011146 RID: 69958
		internal static int __PropertyOffset_OverlapProfileName;

		// Token: 0x04011147 RID: 69959
		[Nullable(2)]
		private FCollisionProfileName _OverlapProfileName;

		// Token: 0x04011148 RID: 69960
		internal static int __PropertyOffset_EnableTickGroundCheck;

		// Token: 0x04011149 RID: 69961
		internal static int __PropertyOffset_TickGroundCheckIntervalMs;

		// Token: 0x0401114A RID: 69962
		internal static int __PropertyOffset_OverlapDuration;

		// Token: 0x0401114B RID: 69963
		internal static int __PropertyOffset_CheckGroundMobility;

		// Token: 0x0401114C RID: 69964
		internal static int __PropertyOffset_EnableTickCheckPlayerMovement;

		// Token: 0x0401114D RID: 69965
		internal static int __PropertyOffset_TickCheckPlayerMovementLength;

		// Token: 0x0401114E RID: 69966
		internal static int __PropertyOffset_TickPlayerMoveCheckIntervalMs;
	}
}

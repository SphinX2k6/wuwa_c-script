using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200427D RID: 17021
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_FloatingMovementConfig.BP_FloatingMovementConfig_C")]
	[UnrealStructLayout(904, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 904)]
	public class BP_FloatingMovementConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C2C2 RID: 180930 RVA: 0x00A18F4B File Offset: 0x00A1714B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloatingMovementConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_FloatingMovementConfig.BP_FloatingMovementConfig_C");
			}
			return BP_FloatingMovementConfig_C._ClassPtr;
		}

		// Token: 0x0602C2C3 RID: 180931 RVA: 0x00A18F70 File Offset: 0x00A17170
		public BP_FloatingMovementConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloatingMovementConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C2C4 RID: 180932 RVA: 0x00A18F98 File Offset: 0x00A17198
		public BP_FloatingMovementConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloatingMovementConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DF2 RID: 28146
		// (get) Token: 0x0602C2C5 RID: 180933 RVA: 0x00A18FCB File Offset: 0x00A171CB
		// (set) Token: 0x0602C2C6 RID: 180934 RVA: 0x00A18FDB File Offset: 0x00A171DB
		public unsafe int MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006DF3 RID: 28147
		// (get) Token: 0x0602C2C7 RID: 180935 RVA: 0x00A18FEC File Offset: 0x00A171EC
		// (set) Token: 0x0602C2C8 RID: 180936 RVA: 0x00A18FFC File Offset: 0x00A171FC
		public unsafe int SprintSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006DF4 RID: 28148
		// (get) Token: 0x0602C2C9 RID: 180937 RVA: 0x00A1900D File Offset: 0x00A1720D
		// (set) Token: 0x0602C2CA RID: 180938 RVA: 0x00A1901D File Offset: 0x00A1721D
		public unsafe int TurnSpeedDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006DF5 RID: 28149
		// (get) Token: 0x0602C2CB RID: 180939 RVA: 0x00A1902E File Offset: 0x00A1722E
		// (set) Token: 0x0602C2CC RID: 180940 RVA: 0x00A1903E File Offset: 0x00A1723E
		public unsafe int AirEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006DF6 RID: 28150
		// (get) Token: 0x0602C2CD RID: 180941 RVA: 0x00A1904F File Offset: 0x00A1724F
		// (set) Token: 0x0602C2CE RID: 180942 RVA: 0x00A1905F File Offset: 0x00A1725F
		public unsafe int RiseEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006DF7 RID: 28151
		// (get) Token: 0x0602C2CF RID: 180943 RVA: 0x00A19070 File Offset: 0x00A17270
		// (set) Token: 0x0602C2D0 RID: 180944 RVA: 0x00A19080 File Offset: 0x00A17280
		public unsafe int DropEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006DF8 RID: 28152
		// (get) Token: 0x0602C2D1 RID: 180945 RVA: 0x00A19091 File Offset: 0x00A17291
		// (set) Token: 0x0602C2D2 RID: 180946 RVA: 0x00A190A1 File Offset: 0x00A172A1
		public unsafe int DodgeEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006DF9 RID: 28153
		// (get) Token: 0x0602C2D3 RID: 180947 RVA: 0x00A190B2 File Offset: 0x00A172B2
		// (set) Token: 0x0602C2D4 RID: 180948 RVA: 0x00A190C2 File Offset: 0x00A172C2
		public unsafe int MoveEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006DFA RID: 28154
		// (get) Token: 0x0602C2D5 RID: 180949 RVA: 0x00A190D3 File Offset: 0x00A172D3
		// (set) Token: 0x0602C2D6 RID: 180950 RVA: 0x00A190E3 File Offset: 0x00A172E3
		public unsafe int FastMoveEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006DFB RID: 28155
		// (get) Token: 0x0602C2D7 RID: 180951 RVA: 0x00A190F4 File Offset: 0x00A172F4
		// (set) Token: 0x0602C2D8 RID: 180952 RVA: 0x00A19104 File Offset: 0x00A17304
		public unsafe int SprintEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006DFC RID: 28156
		// (get) Token: 0x0602C2D9 RID: 180953 RVA: 0x00A19115 File Offset: 0x00A17315
		// (set) Token: 0x0602C2DA RID: 180954 RVA: 0x00A19125 File Offset: 0x00A17325
		public unsafe int EnergyRecoverSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006DFD RID: 28157
		// (get) Token: 0x0602C2DB RID: 180955 RVA: 0x00A19136 File Offset: 0x00A17336
		// (set) Token: 0x0602C2DC RID: 180956 RVA: 0x00A19146 File Offset: 0x00A17346
		public unsafe int EnergyRecoverCoolDownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006DFE RID: 28158
		// (get) Token: 0x0602C2DD RID: 180957 RVA: 0x00A19157 File Offset: 0x00A17357
		// (set) Token: 0x0602C2DE RID: 180958 RVA: 0x00A19167 File Offset: 0x00A17367
		public unsafe int AirCriticalHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006DFF RID: 28159
		// (get) Token: 0x0602C2DF RID: 180959 RVA: 0x00A19178 File Offset: 0x00A17378
		// (set) Token: 0x0602C2E0 RID: 180960 RVA: 0x00A19188 File Offset: 0x00A17388
		public unsafe int CloseToGroundHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006E00 RID: 28160
		// (get) Token: 0x0602C2E1 RID: 180961 RVA: 0x00A19199 File Offset: 0x00A17399
		// (set) Token: 0x0602C2E2 RID: 180962 RVA: 0x00A191A9 File Offset: 0x00A173A9
		public unsafe int RiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006E01 RID: 28161
		// (get) Token: 0x0602C2E3 RID: 180963 RVA: 0x00A191BA File Offset: 0x00A173BA
		// (set) Token: 0x0602C2E4 RID: 180964 RVA: 0x00A191CA File Offset: 0x00A173CA
		public unsafe int DropSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006E02 RID: 28162
		// (get) Token: 0x0602C2E5 RID: 180965 RVA: 0x00A191DB File Offset: 0x00A173DB
		// (set) Token: 0x0602C2E6 RID: 180966 RVA: 0x00A191EB File Offset: 0x00A173EB
		public unsafe float AnimLerpAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006E03 RID: 28163
		// (get) Token: 0x0602C2E7 RID: 180967 RVA: 0x00A191FC File Offset: 0x00A173FC
		// (set) Token: 0x0602C2E8 RID: 180968 RVA: 0x00A1920C File Offset: 0x00A1740C
		public unsafe float SpeedAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006E04 RID: 28164
		// (get) Token: 0x0602C2E9 RID: 180969 RVA: 0x00A1921D File Offset: 0x00A1741D
		// (set) Token: 0x0602C2EA RID: 180970 RVA: 0x00A1922D File Offset: 0x00A1742D
		public unsafe float DirectionLerpAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006E05 RID: 28165
		// (get) Token: 0x0602C2EB RID: 180971 RVA: 0x00A19240 File Offset: 0x00A17440
		// (set) Token: 0x0602C2EC RID: 180972 RVA: 0x00A19279 File Offset: 0x00A17479
		public FGameplayTagContainer ForbidRotationTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidRotationTagList) == null)
				{
					result = (this._ForbidRotationTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_19, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E06 RID: 28166
		// (get) Token: 0x0602C2ED RID: 180973 RVA: 0x00A1929C File Offset: 0x00A1749C
		// (set) Token: 0x0602C2EE RID: 180974 RVA: 0x00A192D5 File Offset: 0x00A174D5
		public SFloatingMovementState DefaultMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._DefaultMode) == null)
				{
					result = (this._DefaultMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_20, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E07 RID: 28167
		// (get) Token: 0x0602C2EF RID: 180975 RVA: 0x00A192F8 File Offset: 0x00A174F8
		// (set) Token: 0x0602C2F0 RID: 180976 RVA: 0x00A19331 File Offset: 0x00A17531
		public SFloatingMovementState FloatingMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._FloatingMode) == null)
				{
					result = (this._FloatingMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_21, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E08 RID: 28168
		// (get) Token: 0x0602C2F1 RID: 180977 RVA: 0x00A19354 File Offset: 0x00A17554
		// (set) Token: 0x0602C2F2 RID: 180978 RVA: 0x00A1938D File Offset: 0x00A1758D
		public SFloatingMovementState RiseMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._RiseMode) == null)
				{
					result = (this._RiseMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_22, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_22, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E09 RID: 28169
		// (get) Token: 0x0602C2F3 RID: 180979 RVA: 0x00A193B0 File Offset: 0x00A175B0
		// (set) Token: 0x0602C2F4 RID: 180980 RVA: 0x00A193E9 File Offset: 0x00A175E9
		public SFloatingMovementState DropMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._DropMode) == null)
				{
					result = (this._DropMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_23, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E0A RID: 28170
		// (get) Token: 0x0602C2F5 RID: 180981 RVA: 0x00A1940C File Offset: 0x00A1760C
		// (set) Token: 0x0602C2F6 RID: 180982 RVA: 0x00A19445 File Offset: 0x00A17645
		public SFloatingMovementState WalkMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._WalkMode) == null)
				{
					result = (this._WalkMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_24, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_24, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E0B RID: 28171
		// (get) Token: 0x0602C2F7 RID: 180983 RVA: 0x00A19468 File Offset: 0x00A17668
		// (set) Token: 0x0602C2F8 RID: 180984 RVA: 0x00A194A1 File Offset: 0x00A176A1
		public FGameplayTagContainer ForbidCloseToGrounTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidCloseToGrounTagList) == null)
				{
					result = (this._ForbidCloseToGrounTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_25, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C2F9 RID: 180985 RVA: 0x00A194C2 File Offset: 0x00A176C2
		protected BP_FloatingMovementConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040171D6 RID: 94678
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_FloatingMovementConfig.BP_FloatingMovementConfig_C";

		// Token: 0x040171D7 RID: 94679
		private static IntPtr _ClassPtr;

		// Token: 0x040171D8 RID: 94680
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040171D9 RID: 94681
		internal static int __PropertyOffset_0;

		// Token: 0x040171DA RID: 94682
		internal static int __PropertyOffset_1;

		// Token: 0x040171DB RID: 94683
		internal static int __PropertyOffset_2;

		// Token: 0x040171DC RID: 94684
		internal static int __PropertyOffset_3;

		// Token: 0x040171DD RID: 94685
		internal static int __PropertyOffset_4;

		// Token: 0x040171DE RID: 94686
		internal static int __PropertyOffset_5;

		// Token: 0x040171DF RID: 94687
		internal static int __PropertyOffset_6;

		// Token: 0x040171E0 RID: 94688
		internal static int __PropertyOffset_7;

		// Token: 0x040171E1 RID: 94689
		internal static int __PropertyOffset_8;

		// Token: 0x040171E2 RID: 94690
		internal static int __PropertyOffset_9;

		// Token: 0x040171E3 RID: 94691
		internal static int __PropertyOffset_10;

		// Token: 0x040171E4 RID: 94692
		internal static int __PropertyOffset_11;

		// Token: 0x040171E5 RID: 94693
		internal static int __PropertyOffset_12;

		// Token: 0x040171E6 RID: 94694
		internal static int __PropertyOffset_13;

		// Token: 0x040171E7 RID: 94695
		internal static int __PropertyOffset_14;

		// Token: 0x040171E8 RID: 94696
		internal static int __PropertyOffset_15;

		// Token: 0x040171E9 RID: 94697
		internal static int __PropertyOffset_16;

		// Token: 0x040171EA RID: 94698
		internal static int __PropertyOffset_17;

		// Token: 0x040171EB RID: 94699
		internal static int __PropertyOffset_18;

		// Token: 0x040171EC RID: 94700
		internal static int __PropertyOffset_19;

		// Token: 0x040171ED RID: 94701
		[Nullable(2)]
		private FGameplayTagContainer _ForbidRotationTagList;

		// Token: 0x040171EE RID: 94702
		internal static int __PropertyOffset_20;

		// Token: 0x040171EF RID: 94703
		[Nullable(2)]
		private SFloatingMovementState _DefaultMode;

		// Token: 0x040171F0 RID: 94704
		internal static int __PropertyOffset_21;

		// Token: 0x040171F1 RID: 94705
		[Nullable(2)]
		private SFloatingMovementState _FloatingMode;

		// Token: 0x040171F2 RID: 94706
		internal static int __PropertyOffset_22;

		// Token: 0x040171F3 RID: 94707
		[Nullable(2)]
		private SFloatingMovementState _RiseMode;

		// Token: 0x040171F4 RID: 94708
		internal static int __PropertyOffset_23;

		// Token: 0x040171F5 RID: 94709
		[Nullable(2)]
		private SFloatingMovementState _DropMode;

		// Token: 0x040171F6 RID: 94710
		internal static int __PropertyOffset_24;

		// Token: 0x040171F7 RID: 94711
		[Nullable(2)]
		private SFloatingMovementState _WalkMode;

		// Token: 0x040171F8 RID: 94712
		internal static int __PropertyOffset_25;

		// Token: 0x040171F9 RID: 94713
		[Nullable(2)]
		private FGameplayTagContainer _ForbidCloseToGrounTagList;
	}
}

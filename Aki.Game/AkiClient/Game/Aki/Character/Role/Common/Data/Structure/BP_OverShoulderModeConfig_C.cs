using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040AB RID: 16555
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_OverShoulderModeConfig.BP_OverShoulderModeConfig_C")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class BP_OverShoulderModeConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AC1A RID: 175130 RVA: 0x009EAA53 File Offset: 0x009E8C53
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_OverShoulderModeConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_OverShoulderModeConfig.BP_OverShoulderModeConfig_C");
			}
			return BP_OverShoulderModeConfig_C._ClassPtr;
		}

		// Token: 0x0602AC1B RID: 175131 RVA: 0x009EAA78 File Offset: 0x009E8C78
		public BP_OverShoulderModeConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_OverShoulderModeConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AC1C RID: 175132 RVA: 0x009EAAA0 File Offset: 0x009E8CA0
		public BP_OverShoulderModeConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_OverShoulderModeConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700695A RID: 26970
		// (get) Token: 0x0602AC1D RID: 175133 RVA: 0x009EAAD3 File Offset: 0x009E8CD3
		// (set) Token: 0x0602AC1E RID: 175134 RVA: 0x009EAAE3 File Offset: 0x009E8CE3
		public unsafe float MinTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700695B RID: 26971
		// (get) Token: 0x0602AC1F RID: 175135 RVA: 0x009EAAF4 File Offset: 0x009E8CF4
		// (set) Token: 0x0602AC20 RID: 175136 RVA: 0x009EAB04 File Offset: 0x009E8D04
		public unsafe float MaxTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700695C RID: 26972
		// (get) Token: 0x0602AC21 RID: 175137 RVA: 0x009EAB15 File Offset: 0x009E8D15
		// (set) Token: 0x0602AC22 RID: 175138 RVA: 0x009EAB25 File Offset: 0x009E8D25
		public unsafe float LerpBeginDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700695D RID: 26973
		// (get) Token: 0x0602AC23 RID: 175139 RVA: 0x009EAB36 File Offset: 0x009E8D36
		// (set) Token: 0x0602AC24 RID: 175140 RVA: 0x009EAB4A File Offset: 0x009E8D4A
		[Nullable(2)]
		public unsafe UCurveFloat LerpCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OverShoulderModeConfig_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OverShoulderModeConfig_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700695E RID: 26974
		// (get) Token: 0x0602AC25 RID: 175141 RVA: 0x009EAB5F File Offset: 0x009E8D5F
		// (set) Token: 0x0602AC26 RID: 175142 RVA: 0x009EAB6F File Offset: 0x009E8D6F
		public unsafe float LerpPow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700695F RID: 26975
		// (get) Token: 0x0602AC27 RID: 175143 RVA: 0x009EAB80 File Offset: 0x009E8D80
		// (set) Token: 0x0602AC28 RID: 175144 RVA: 0x009EAB90 File Offset: 0x009E8D90
		public unsafe float SprintExitInputDegAbs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006960 RID: 26976
		// (get) Token: 0x0602AC29 RID: 175145 RVA: 0x009EABA4 File Offset: 0x009E8DA4
		// (set) Token: 0x0602AC2A RID: 175146 RVA: 0x009EABDD File Offset: 0x009E8DDD
		public FGameplayTagContainer TagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TagList) == null)
				{
					result = (this._TagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602AC2B RID: 175147 RVA: 0x009EABFE File Offset: 0x009E8DFE
		protected BP_OverShoulderModeConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016213 RID: 90643
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_OverShoulderModeConfig.BP_OverShoulderModeConfig_C";

		// Token: 0x04016214 RID: 90644
		private static IntPtr _ClassPtr;

		// Token: 0x04016215 RID: 90645
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016216 RID: 90646
		internal static int __PropertyOffset_0;

		// Token: 0x04016217 RID: 90647
		internal static int __PropertyOffset_1;

		// Token: 0x04016218 RID: 90648
		internal static int __PropertyOffset_2;

		// Token: 0x04016219 RID: 90649
		internal static int __PropertyOffset_3;

		// Token: 0x0401621A RID: 90650
		internal static int __PropertyOffset_4;

		// Token: 0x0401621B RID: 90651
		internal static int __PropertyOffset_5;

		// Token: 0x0401621C RID: 90652
		internal static int __PropertyOffset_6;

		// Token: 0x0401621D RID: 90653
		[Nullable(2)]
		private FGameplayTagContainer _TagList;
	}
}

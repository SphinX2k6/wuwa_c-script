using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003247 RID: 12871
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/BP_AIRaceStrategy.BP_AIRaceStrategy_C")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 185)]
	public class BP_AIRaceStrategy_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602029D RID: 131741 RVA: 0x0093EB95 File Offset: 0x0093CD95
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AIRaceStrategy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/BP_AIRaceStrategy.BP_AIRaceStrategy_C");
			}
			return BP_AIRaceStrategy_C._ClassPtr;
		}

		// Token: 0x0602029E RID: 131742 RVA: 0x0093EBBC File Offset: 0x0093CDBC
		public BP_AIRaceStrategy_C() : this(BuiltinUtils.AllocNativeUObject(BP_AIRaceStrategy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602029F RID: 131743 RVA: 0x0093EBE4 File Offset: 0x0093CDE4
		public BP_AIRaceStrategy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AIRaceStrategy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x060202A0 RID: 131744 RVA: 0x0093EC17 File Offset: 0x0093CE17
		// (set) Token: 0x060202A1 RID: 131745 RVA: 0x0093EC27 File Offset: 0x0093CE27
		public unsafe float DefaultSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_DefaultSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_DefaultSpeed) = value;
			}
		}

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x060202A2 RID: 131746 RVA: 0x0093EC38 File Offset: 0x0093CE38
		// (set) Token: 0x060202A3 RID: 131747 RVA: 0x0093EC48 File Offset: 0x0093CE48
		public unsafe float DefaultAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_DefaultAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_DefaultAcceleration) = value;
			}
		}

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x060202A4 RID: 131748 RVA: 0x0093EC59 File Offset: 0x0093CE59
		// (set) Token: 0x060202A5 RID: 131749 RVA: 0x0093EC69 File Offset: 0x0093CE69
		public unsafe float DefaultDeceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_DefaultDeceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_DefaultDeceleration) = value;
			}
		}

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x060202A6 RID: 131750 RVA: 0x0093EC7C File Offset: 0x0093CE7C
		// (set) Token: 0x060202A7 RID: 131751 RVA: 0x0093ECB5 File Offset: 0x0093CEB5
		public SAiRaceStrategyCorrectionByDistance CorrectionByDistanceConfig
		{
			get
			{
				base.FastCheckIsValid();
				SAiRaceStrategyCorrectionByDistance result;
				if ((result = this._CorrectionByDistanceConfig) == null)
				{
					result = (this._CorrectionByDistanceConfig = new SAiRaceStrategyCorrectionByDistance(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_CorrectionByDistanceConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiRaceStrategyCorrectionByDistance.StaticStruct(), base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_CorrectionByDistanceConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x060202A8 RID: 131752 RVA: 0x0093ECD8 File Offset: 0x0093CED8
		// (set) Token: 0x060202A9 RID: 131753 RVA: 0x0093ED11 File Offset: 0x0093CF11
		public SAiRaceStrategyCorrectionBySpeed CorrectionBySpeedConfig
		{
			get
			{
				base.FastCheckIsValid();
				SAiRaceStrategyCorrectionBySpeed result;
				if ((result = this._CorrectionBySpeedConfig) == null)
				{
					result = (this._CorrectionBySpeedConfig = new SAiRaceStrategyCorrectionBySpeed(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_CorrectionBySpeedConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiRaceStrategyCorrectionBySpeed.StaticStruct(), base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_CorrectionBySpeedConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x060202AA RID: 131754 RVA: 0x0093ED34 File Offset: 0x0093CF34
		// (set) Token: 0x060202AB RID: 131755 RVA: 0x0093ED6D File Offset: 0x0093CF6D
		public SAiRaceStrategyCorrectionByTime CorrectionByTimeConfig
		{
			get
			{
				base.FastCheckIsValid();
				SAiRaceStrategyCorrectionByTime result;
				if ((result = this._CorrectionByTimeConfig) == null)
				{
					result = (this._CorrectionByTimeConfig = new SAiRaceStrategyCorrectionByTime(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_CorrectionByTimeConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiRaceStrategyCorrectionByTime.StaticStruct(), base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_CorrectionByTimeConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x060202AC RID: 131756 RVA: 0x0093ED8E File Offset: 0x0093CF8E
		// (set) Token: 0x060202AD RID: 131757 RVA: 0x0093EDA2 File Offset: 0x0093CFA2
		public unsafe SAiRaceStrategyMultiParamFunction CalcTargetSpeedConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_CalcTargetSpeedConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_CalcTargetSpeedConfig) = value;
			}
		}

		// Token: 0x060202AE RID: 131758 RVA: 0x0093EDB7 File Offset: 0x0093CFB7
		protected BP_AIRaceStrategy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114EF RID: 70895
		public new const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/BP_AIRaceStrategy.BP_AIRaceStrategy_C";

		// Token: 0x040114F0 RID: 70896
		private static IntPtr _ClassPtr;

		// Token: 0x040114F1 RID: 70897
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114F2 RID: 70898
		internal static int __PropertyOffset_DefaultSpeed;

		// Token: 0x040114F3 RID: 70899
		internal static int __PropertyOffset_DefaultAcceleration;

		// Token: 0x040114F4 RID: 70900
		internal static int __PropertyOffset_DefaultDeceleration;

		// Token: 0x040114F5 RID: 70901
		internal static int __PropertyOffset_CorrectionByDistanceConfig;

		// Token: 0x040114F6 RID: 70902
		[Nullable(2)]
		private SAiRaceStrategyCorrectionByDistance _CorrectionByDistanceConfig;

		// Token: 0x040114F7 RID: 70903
		internal static int __PropertyOffset_CorrectionBySpeedConfig;

		// Token: 0x040114F8 RID: 70904
		[Nullable(2)]
		private SAiRaceStrategyCorrectionBySpeed _CorrectionBySpeedConfig;

		// Token: 0x040114F9 RID: 70905
		internal static int __PropertyOffset_CorrectionByTimeConfig;

		// Token: 0x040114FA RID: 70906
		[Nullable(2)]
		private SAiRaceStrategyCorrectionByTime _CorrectionByTimeConfig;

		// Token: 0x040114FB RID: 70907
		internal static int __PropertyOffset_CalcTargetSpeedConfig;
	}
}

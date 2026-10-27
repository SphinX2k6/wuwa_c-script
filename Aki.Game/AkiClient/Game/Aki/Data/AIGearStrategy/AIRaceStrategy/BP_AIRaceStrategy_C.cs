using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003FC2 RID: 16322
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/BP_AIRaceStrategy.BP_AIRaceStrategy_C")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 185)]
	public class BP_AIRaceStrategy_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029CAF RID: 171183 RVA: 0x009CC931 File Offset: 0x009CAB31
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AIRaceStrategy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/BP_AIRaceStrategy.BP_AIRaceStrategy_C");
			}
			return BP_AIRaceStrategy_C._ClassPtr;
		}

		// Token: 0x06029CB0 RID: 171184 RVA: 0x009CC958 File Offset: 0x009CAB58
		public BP_AIRaceStrategy_C() : this(BuiltinUtils.AllocNativeUObject(BP_AIRaceStrategy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029CB1 RID: 171185 RVA: 0x009CC980 File Offset: 0x009CAB80
		public BP_AIRaceStrategy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AIRaceStrategy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700654C RID: 25932
		// (get) Token: 0x06029CB2 RID: 171186 RVA: 0x009CC9B3 File Offset: 0x009CABB3
		// (set) Token: 0x06029CB3 RID: 171187 RVA: 0x009CC9C3 File Offset: 0x009CABC3
		public unsafe float DefaultSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700654D RID: 25933
		// (get) Token: 0x06029CB4 RID: 171188 RVA: 0x009CC9D4 File Offset: 0x009CABD4
		// (set) Token: 0x06029CB5 RID: 171189 RVA: 0x009CC9E4 File Offset: 0x009CABE4
		public unsafe float DefaultAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700654E RID: 25934
		// (get) Token: 0x06029CB6 RID: 171190 RVA: 0x009CC9F5 File Offset: 0x009CABF5
		// (set) Token: 0x06029CB7 RID: 171191 RVA: 0x009CCA05 File Offset: 0x009CAC05
		public unsafe float DefaultDeceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700654F RID: 25935
		// (get) Token: 0x06029CB8 RID: 171192 RVA: 0x009CCA18 File Offset: 0x009CAC18
		// (set) Token: 0x06029CB9 RID: 171193 RVA: 0x009CCA51 File Offset: 0x009CAC51
		public SAiRaceStrategyCorrectionByDistance CorrectionByDistanceConfig
		{
			get
			{
				base.FastCheckIsValid();
				SAiRaceStrategyCorrectionByDistance result;
				if ((result = this._CorrectionByDistanceConfig) == null)
				{
					result = (this._CorrectionByDistanceConfig = new SAiRaceStrategyCorrectionByDistance(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiRaceStrategyCorrectionByDistance.StaticStruct(), base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006550 RID: 25936
		// (get) Token: 0x06029CBA RID: 171194 RVA: 0x009CCA74 File Offset: 0x009CAC74
		// (set) Token: 0x06029CBB RID: 171195 RVA: 0x009CCAAD File Offset: 0x009CACAD
		public SAiRaceStrategyCorrectionBySpeed CorrectionBySpeedConfig
		{
			get
			{
				base.FastCheckIsValid();
				SAiRaceStrategyCorrectionBySpeed result;
				if ((result = this._CorrectionBySpeedConfig) == null)
				{
					result = (this._CorrectionBySpeedConfig = new SAiRaceStrategyCorrectionBySpeed(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiRaceStrategyCorrectionBySpeed.StaticStruct(), base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006551 RID: 25937
		// (get) Token: 0x06029CBC RID: 171196 RVA: 0x009CCAD0 File Offset: 0x009CACD0
		// (set) Token: 0x06029CBD RID: 171197 RVA: 0x009CCB09 File Offset: 0x009CAD09
		public SAiRaceStrategyCorrectionByTime CorrectionByTimeConfig
		{
			get
			{
				base.FastCheckIsValid();
				SAiRaceStrategyCorrectionByTime result;
				if ((result = this._CorrectionByTimeConfig) == null)
				{
					result = (this._CorrectionByTimeConfig = new SAiRaceStrategyCorrectionByTime(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiRaceStrategyCorrectionByTime.StaticStruct(), base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006552 RID: 25938
		// (get) Token: 0x06029CBE RID: 171198 RVA: 0x009CCB2A File Offset: 0x009CAD2A
		// (set) Token: 0x06029CBF RID: 171199 RVA: 0x009CCB3E File Offset: 0x009CAD3E
		public unsafe SAiRaceStrategyMultiParamFunction CalcTargetSpeedConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIRaceStrategy_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06029CC0 RID: 171200 RVA: 0x009CCB53 File Offset: 0x009CAD53
		protected BP_AIRaceStrategy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401575E RID: 87902
		public new const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/BP_AIRaceStrategy.BP_AIRaceStrategy_C";

		// Token: 0x0401575F RID: 87903
		private static IntPtr _ClassPtr;

		// Token: 0x04015760 RID: 87904
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015761 RID: 87905
		internal static int __PropertyOffset_0;

		// Token: 0x04015762 RID: 87906
		internal static int __PropertyOffset_1;

		// Token: 0x04015763 RID: 87907
		internal static int __PropertyOffset_2;

		// Token: 0x04015764 RID: 87908
		internal static int __PropertyOffset_3;

		// Token: 0x04015765 RID: 87909
		[Nullable(2)]
		private SAiRaceStrategyCorrectionByDistance _CorrectionByDistanceConfig;

		// Token: 0x04015766 RID: 87910
		internal static int __PropertyOffset_4;

		// Token: 0x04015767 RID: 87911
		[Nullable(2)]
		private SAiRaceStrategyCorrectionBySpeed _CorrectionBySpeedConfig;

		// Token: 0x04015768 RID: 87912
		internal static int __PropertyOffset_5;

		// Token: 0x04015769 RID: 87913
		[Nullable(2)]
		private SAiRaceStrategyCorrectionByTime _CorrectionByTimeConfig;

		// Token: 0x0401576A RID: 87914
		internal static int __PropertyOffset_6;
	}
}

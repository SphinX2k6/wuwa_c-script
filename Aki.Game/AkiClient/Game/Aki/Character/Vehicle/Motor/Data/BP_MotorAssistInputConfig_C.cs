using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data
{
	// Token: 0x02003290 RID: 12944
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/BP_MotorAssistInputConfig.BP_MotorAssistInputConfig_C")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 195)]
	public class BP_MotorAssistInputConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060206B4 RID: 132788 RVA: 0x00946109 File Offset: 0x00944309
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MotorAssistInputConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/BP_MotorAssistInputConfig.BP_MotorAssistInputConfig_C");
			}
			return BP_MotorAssistInputConfig_C._ClassPtr;
		}

		// Token: 0x060206B5 RID: 132789 RVA: 0x00946130 File Offset: 0x00944330
		public BP_MotorAssistInputConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_MotorAssistInputConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060206B6 RID: 132790 RVA: 0x00946158 File Offset: 0x00944358
		public BP_MotorAssistInputConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MotorAssistInputConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x060206B7 RID: 132791 RVA: 0x0094618B File Offset: 0x0094438B
		// (set) Token: 0x060206B8 RID: 132792 RVA: 0x0094619B File Offset: 0x0094439B
		public unsafe int HoldThrottleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_HoldThrottleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_HoldThrottleTime) = value;
			}
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x060206B9 RID: 132793 RVA: 0x009461AC File Offset: 0x009443AC
		// (set) Token: 0x060206BA RID: 132794 RVA: 0x009461E5 File Offset: 0x009443E5
		public FGameplayTagContainer ForbidHoldThrottleTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidHoldThrottleTag) == null)
				{
					result = (this._ForbidHoldThrottleTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_ForbidHoldThrottleTag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_ForbidHoldThrottleTag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x060206BB RID: 132795 RVA: 0x00946208 File Offset: 0x00944408
		// (set) Token: 0x060206BC RID: 132796 RVA: 0x00946241 File Offset: 0x00944441
		public TArray<int> HoldThrottleSkill
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._HoldThrottleSkill) == null)
				{
					result = (this._HoldThrottleSkill = new TArray<int>(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_HoldThrottleSkill, this));
				}
				return result;
			}
			set
			{
				this.HoldThrottleSkill.CopyAssign(value);
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x060206BD RID: 132797 RVA: 0x0094624F File Offset: 0x0094444F
		// (set) Token: 0x060206BE RID: 132798 RVA: 0x0094625F File Offset: 0x0094445F
		public unsafe int NitroBoostTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_NitroBoostTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_NitroBoostTime) = value;
			}
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x060206BF RID: 132799 RVA: 0x00946270 File Offset: 0x00944470
		// (set) Token: 0x060206C0 RID: 132800 RVA: 0x009462A9 File Offset: 0x009444A9
		public FGameplayTagContainer ForbidNitroBoostTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidNitroBoostTag) == null)
				{
					result = (this._ForbidNitroBoostTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_ForbidNitroBoostTag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_ForbidNitroBoostTag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x060206C1 RID: 132801 RVA: 0x009462CC File Offset: 0x009444CC
		// (set) Token: 0x060206C2 RID: 132802 RVA: 0x00946305 File Offset: 0x00944505
		public TArray<int> NitroBoostSkill
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._NitroBoostSkill) == null)
				{
					result = (this._NitroBoostSkill = new TArray<int>(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_NitroBoostSkill, this));
				}
				return result;
			}
			set
			{
				this.NitroBoostSkill.CopyAssign(value);
			}
		}

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x060206C3 RID: 132803 RVA: 0x00946313 File Offset: 0x00944513
		// (set) Token: 0x060206C4 RID: 132804 RVA: 0x00946323 File Offset: 0x00944523
		public unsafe bool DebugHoldThrottle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_DebugHoldThrottle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_DebugHoldThrottle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x060206C5 RID: 132805 RVA: 0x00946334 File Offset: 0x00944534
		// (set) Token: 0x060206C6 RID: 132806 RVA: 0x00946344 File Offset: 0x00944544
		public unsafe bool DebugNitroBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_DebugNitroBoost) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_DebugNitroBoost) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x060206C7 RID: 132807 RVA: 0x00946355 File Offset: 0x00944555
		// (set) Token: 0x060206C8 RID: 132808 RVA: 0x00946365 File Offset: 0x00944565
		public unsafe bool DebugAssistDrift
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_DebugAssistDrift) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_DebugAssistDrift) = (value ? 1 : 0);
			}
		}

		// Token: 0x060206C9 RID: 132809 RVA: 0x00946376 File Offset: 0x00944576
		protected BP_MotorAssistInputConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401182C RID: 71724
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/BP_MotorAssistInputConfig.BP_MotorAssistInputConfig_C";

		// Token: 0x0401182D RID: 71725
		private static IntPtr _ClassPtr;

		// Token: 0x0401182E RID: 71726
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401182F RID: 71727
		internal static int __PropertyOffset_HoldThrottleTime;

		// Token: 0x04011830 RID: 71728
		internal static int __PropertyOffset_ForbidHoldThrottleTag;

		// Token: 0x04011831 RID: 71729
		[Nullable(2)]
		private FGameplayTagContainer _ForbidHoldThrottleTag;

		// Token: 0x04011832 RID: 71730
		internal static int __PropertyOffset_HoldThrottleSkill;

		// Token: 0x04011833 RID: 71731
		[Nullable(2)]
		private TArray<int> _HoldThrottleSkill;

		// Token: 0x04011834 RID: 71732
		internal static int __PropertyOffset_NitroBoostTime;

		// Token: 0x04011835 RID: 71733
		internal static int __PropertyOffset_ForbidNitroBoostTag;

		// Token: 0x04011836 RID: 71734
		[Nullable(2)]
		private FGameplayTagContainer _ForbidNitroBoostTag;

		// Token: 0x04011837 RID: 71735
		internal static int __PropertyOffset_NitroBoostSkill;

		// Token: 0x04011838 RID: 71736
		[Nullable(2)]
		private TArray<int> _NitroBoostSkill;

		// Token: 0x04011839 RID: 71737
		internal static int __PropertyOffset_DebugHoldThrottle;

		// Token: 0x0401183A RID: 71738
		internal static int __PropertyOffset_DebugNitroBoost;

		// Token: 0x0401183B RID: 71739
		internal static int __PropertyOffset_DebugAssistDrift;
	}
}

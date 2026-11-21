using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.RhythmGame
{
	// Token: 0x020031DE RID: 12766
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RhythmGame/BP_RhythmGameConfig.BP_RhythmGameConfig_C")]
	[UnrealStructLayout(520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 520)]
	public class BP_RhythmGameConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB6C RID: 129900 RVA: 0x00933FAE File Offset: 0x009321AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RhythmGameConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/RhythmGame/BP_RhythmGameConfig.BP_RhythmGameConfig_C");
			}
			return BP_RhythmGameConfig_C._ClassPtr;
		}

		// Token: 0x0601FB6D RID: 129901 RVA: 0x00933FD4 File Offset: 0x009321D4
		public BP_RhythmGameConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_RhythmGameConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB6E RID: 129902 RVA: 0x00933FFC File Offset: 0x009321FC
		public BP_RhythmGameConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RhythmGameConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x0601FB6F RID: 129903 RVA: 0x00934030 File Offset: 0x00932230
		// (set) Token: 0x0601FB70 RID: 129904 RVA: 0x00934069 File Offset: 0x00932269
		public FKuroRhythmGameConfig Config
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameConfig result;
				if ((result = this._Config) == null)
				{
					result = (this._Config = new FKuroRhythmGameConfig(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_Config, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_Config, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x0601FB71 RID: 129905 RVA: 0x0093408C File Offset: 0x0093228C
		// (set) Token: 0x0601FB72 RID: 129906 RVA: 0x009340C5 File Offset: 0x009322C5
		public TArray<RhythmGameSpeedLevelConfig> SpeedLevelConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<RhythmGameSpeedLevelConfig> result;
				if ((result = this._SpeedLevelConfig) == null)
				{
					result = (this._SpeedLevelConfig = new TArray<RhythmGameSpeedLevelConfig>(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_SpeedLevelConfig, this));
				}
				return result;
			}
			set
			{
				this.SpeedLevelConfig.CopyAssign(value);
			}
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x0601FB73 RID: 129907 RVA: 0x009340D3 File Offset: 0x009322D3
		// (set) Token: 0x0601FB74 RID: 129908 RVA: 0x009340E7 File Offset: 0x009322E7
		public unsafe RhythmGamePerformanceCameraConfig StartCameraConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_StartCameraConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_StartCameraConfig) = value;
			}
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x0601FB75 RID: 129909 RVA: 0x009340FC File Offset: 0x009322FC
		// (set) Token: 0x0601FB76 RID: 129910 RVA: 0x00934110 File Offset: 0x00932310
		public unsafe RhythmGamePerformanceCameraConfig EndCameraConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_EndCameraConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_EndCameraConfig) = value;
			}
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x0601FB77 RID: 129911 RVA: 0x00934128 File Offset: 0x00932328
		// (set) Token: 0x0601FB78 RID: 129912 RVA: 0x00934161 File Offset: 0x00932361
		public RhythmGameFreeFlyCameraConfig FreeFlyCameraConfig
		{
			get
			{
				base.FastCheckIsValid();
				RhythmGameFreeFlyCameraConfig result;
				if ((result = this._FreeFlyCameraConfig) == null)
				{
					result = (this._FreeFlyCameraConfig = new RhythmGameFreeFlyCameraConfig(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_FreeFlyCameraConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(RhythmGameFreeFlyCameraConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_FreeFlyCameraConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601FB79 RID: 129913 RVA: 0x00934182 File Offset: 0x00932382
		protected BP_RhythmGameConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011044 RID: 69700
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/RhythmGame/BP_RhythmGameConfig.BP_RhythmGameConfig_C";

		// Token: 0x04011045 RID: 69701
		private static IntPtr _ClassPtr;

		// Token: 0x04011046 RID: 69702
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011047 RID: 69703
		internal static int __PropertyOffset_Config;

		// Token: 0x04011048 RID: 69704
		[Nullable(2)]
		private FKuroRhythmGameConfig _Config;

		// Token: 0x04011049 RID: 69705
		internal static int __PropertyOffset_SpeedLevelConfig;

		// Token: 0x0401104A RID: 69706
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<RhythmGameSpeedLevelConfig> _SpeedLevelConfig;

		// Token: 0x0401104B RID: 69707
		internal static int __PropertyOffset_StartCameraConfig;

		// Token: 0x0401104C RID: 69708
		internal static int __PropertyOffset_EndCameraConfig;

		// Token: 0x0401104D RID: 69709
		internal static int __PropertyOffset_FreeFlyCameraConfig;

		// Token: 0x0401104E RID: 69710
		[Nullable(2)]
		private RhythmGameFreeFlyCameraConfig _FreeFlyCameraConfig;
	}
}

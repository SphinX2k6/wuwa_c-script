using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.RhythmGame
{
	// Token: 0x02003F32 RID: 16178
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RhythmGame/BP_RhythmGameConfig.BP_RhythmGameConfig_C")]
	[UnrealStructLayout(520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 520)]
	public class BP_RhythmGameConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602925A RID: 168538 RVA: 0x009BCE4E File Offset: 0x009BB04E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RhythmGameConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/RhythmGame/BP_RhythmGameConfig.BP_RhythmGameConfig_C");
			}
			return BP_RhythmGameConfig_C._ClassPtr;
		}

		// Token: 0x0602925B RID: 168539 RVA: 0x009BCE74 File Offset: 0x009BB074
		public BP_RhythmGameConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_RhythmGameConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602925C RID: 168540 RVA: 0x009BCE9C File Offset: 0x009BB09C
		public BP_RhythmGameConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RhythmGameConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061C9 RID: 25033
		// (get) Token: 0x0602925D RID: 168541 RVA: 0x009BCED0 File Offset: 0x009BB0D0
		// (set) Token: 0x0602925E RID: 168542 RVA: 0x009BCF09 File Offset: 0x009BB109
		public FKuroRhythmGameConfig Config
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameConfig result;
				if ((result = this._Config) == null)
				{
					result = (this._Config = new FKuroRhythmGameConfig(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061CA RID: 25034
		// (get) Token: 0x0602925F RID: 168543 RVA: 0x009BCF2C File Offset: 0x009BB12C
		// (set) Token: 0x06029260 RID: 168544 RVA: 0x009BCF65 File Offset: 0x009BB165
		public TArray<RhythmGameSpeedLevelConfig> SpeedLevelConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<RhythmGameSpeedLevelConfig> result;
				if ((result = this._SpeedLevelConfig) == null)
				{
					result = (this._SpeedLevelConfig = new TArray<RhythmGameSpeedLevelConfig>(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.SpeedLevelConfig.CopyAssign(value);
			}
		}

		// Token: 0x170061CB RID: 25035
		// (get) Token: 0x06029261 RID: 168545 RVA: 0x009BCF73 File Offset: 0x009BB173
		// (set) Token: 0x06029262 RID: 168546 RVA: 0x009BCF87 File Offset: 0x009BB187
		public unsafe RhythmGamePerformanceCameraConfig StartCameraConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170061CC RID: 25036
		// (get) Token: 0x06029263 RID: 168547 RVA: 0x009BCF9C File Offset: 0x009BB19C
		// (set) Token: 0x06029264 RID: 168548 RVA: 0x009BCFB0 File Offset: 0x009BB1B0
		public unsafe RhythmGamePerformanceCameraConfig EndCameraConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170061CD RID: 25037
		// (get) Token: 0x06029265 RID: 168549 RVA: 0x009BCFC8 File Offset: 0x009BB1C8
		// (set) Token: 0x06029266 RID: 168550 RVA: 0x009BD001 File Offset: 0x009BB201
		public RhythmGameFreeFlyCameraConfig FreeFlyCameraConfig
		{
			get
			{
				base.FastCheckIsValid();
				RhythmGameFreeFlyCameraConfig result;
				if ((result = this._FreeFlyCameraConfig) == null)
				{
					result = (this._FreeFlyCameraConfig = new RhythmGameFreeFlyCameraConfig(base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(RhythmGameFreeFlyCameraConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_RhythmGameConfig_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06029267 RID: 168551 RVA: 0x009BD022 File Offset: 0x009BB222
		protected BP_RhythmGameConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015114 RID: 86292
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/RhythmGame/BP_RhythmGameConfig.BP_RhythmGameConfig_C";

		// Token: 0x04015115 RID: 86293
		private static IntPtr _ClassPtr;

		// Token: 0x04015116 RID: 86294
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015117 RID: 86295
		internal static int __PropertyOffset_0;

		// Token: 0x04015118 RID: 86296
		[Nullable(2)]
		private FKuroRhythmGameConfig _Config;

		// Token: 0x04015119 RID: 86297
		internal static int __PropertyOffset_1;

		// Token: 0x0401511A RID: 86298
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<RhythmGameSpeedLevelConfig> _SpeedLevelConfig;

		// Token: 0x0401511B RID: 86299
		internal static int __PropertyOffset_2;

		// Token: 0x0401511C RID: 86300
		internal static int __PropertyOffset_3;

		// Token: 0x0401511D RID: 86301
		internal static int __PropertyOffset_4;

		// Token: 0x0401511E RID: 86302
		[Nullable(2)]
		private RhythmGameFreeFlyCameraConfig _FreeFlyCameraConfig;
	}
}

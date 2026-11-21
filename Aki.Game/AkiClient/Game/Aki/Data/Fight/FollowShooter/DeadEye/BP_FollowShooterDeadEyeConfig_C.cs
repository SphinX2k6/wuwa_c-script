using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.FollowShooter.DeadEye
{
	// Token: 0x02003215 RID: 12821
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/FollowShooter/DeadEye/BP_FollowShooterDeadEyeConfig.BP_FollowShooterDeadEyeConfig_C")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 164)]
	public class BP_FollowShooterDeadEyeConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FFCC RID: 131020 RVA: 0x0093A6A8 File Offset: 0x009388A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FollowShooterDeadEyeConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/FollowShooter/DeadEye/BP_FollowShooterDeadEyeConfig.BP_FollowShooterDeadEyeConfig_C");
			}
			return BP_FollowShooterDeadEyeConfig_C._ClassPtr;
		}

		// Token: 0x0601FFCD RID: 131021 RVA: 0x0093A6CC File Offset: 0x009388CC
		public BP_FollowShooterDeadEyeConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FollowShooterDeadEyeConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FFCE RID: 131022 RVA: 0x0093A6F4 File Offset: 0x009388F4
		public BP_FollowShooterDeadEyeConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FollowShooterDeadEyeConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x0601FFCF RID: 131023 RVA: 0x0093A728 File Offset: 0x00938928
		// (set) Token: 0x0601FFD0 RID: 131024 RVA: 0x0093A761 File Offset: 0x00938961
		public TMap<FName, SDeadEyeConfig> DeadEyeConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, SDeadEyeConfig> result;
				if ((result = this._DeadEyeConfig) == null)
				{
					result = (this._DeadEyeConfig = new TMap<FName, SDeadEyeConfig>(base.NativePtr + (IntPtr)BP_FollowShooterDeadEyeConfig_C.__PropertyOffset_DeadEyeConfig, this));
				}
				return result;
			}
			set
			{
				this.DeadEyeConfig.CopyAssign(value);
			}
		}

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x0601FFD1 RID: 131025 RVA: 0x0093A76F File Offset: 0x0093896F
		// (set) Token: 0x0601FFD2 RID: 131026 RVA: 0x0093A77F File Offset: 0x0093897F
		public unsafe float FinishDelayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterDeadEyeConfig_C.__PropertyOffset_FinishDelayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterDeadEyeConfig_C.__PropertyOffset_FinishDelayTime) = value;
			}
		}

		// Token: 0x0601FFD3 RID: 131027 RVA: 0x0093A790 File Offset: 0x00938990
		protected BP_FollowShooterDeadEyeConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112D8 RID: 70360
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/FollowShooter/DeadEye/BP_FollowShooterDeadEyeConfig.BP_FollowShooterDeadEyeConfig_C";

		// Token: 0x040112D9 RID: 70361
		private static IntPtr _ClassPtr;

		// Token: 0x040112DA RID: 70362
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112DB RID: 70363
		internal static int __PropertyOffset_DeadEyeConfig;

		// Token: 0x040112DC RID: 70364
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, SDeadEyeConfig> _DeadEyeConfig;

		// Token: 0x040112DD RID: 70365
		internal static int __PropertyOffset_FinishDelayTime;
	}
}

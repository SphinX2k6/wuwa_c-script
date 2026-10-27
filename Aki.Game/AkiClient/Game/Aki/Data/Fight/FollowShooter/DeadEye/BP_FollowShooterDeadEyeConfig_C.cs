using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.FollowShooter.DeadEye
{
	// Token: 0x02003F78 RID: 16248
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/FollowShooter/DeadEye/BP_FollowShooterDeadEyeConfig.BP_FollowShooterDeadEyeConfig_C")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 164)]
	public class BP_FollowShooterDeadEyeConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060297E4 RID: 169956 RVA: 0x009C584C File Offset: 0x009C3A4C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FollowShooterDeadEyeConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/FollowShooter/DeadEye/BP_FollowShooterDeadEyeConfig.BP_FollowShooterDeadEyeConfig_C");
			}
			return BP_FollowShooterDeadEyeConfig_C._ClassPtr;
		}

		// Token: 0x060297E5 RID: 169957 RVA: 0x009C5870 File Offset: 0x009C3A70
		public BP_FollowShooterDeadEyeConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FollowShooterDeadEyeConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060297E6 RID: 169958 RVA: 0x009C5898 File Offset: 0x009C3A98
		public BP_FollowShooterDeadEyeConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FollowShooterDeadEyeConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700639C RID: 25500
		// (get) Token: 0x060297E7 RID: 169959 RVA: 0x009C58CC File Offset: 0x009C3ACC
		// (set) Token: 0x060297E8 RID: 169960 RVA: 0x009C5905 File Offset: 0x009C3B05
		public TMap<FName, SDeadEyeConfig> DeadEyeConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, SDeadEyeConfig> result;
				if ((result = this._DeadEyeConfig) == null)
				{
					result = (this._DeadEyeConfig = new TMap<FName, SDeadEyeConfig>(base.NativePtr + (IntPtr)BP_FollowShooterDeadEyeConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.DeadEyeConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700639D RID: 25501
		// (get) Token: 0x060297E9 RID: 169961 RVA: 0x009C5913 File Offset: 0x009C3B13
		// (set) Token: 0x060297EA RID: 169962 RVA: 0x009C5923 File Offset: 0x009C3B23
		public unsafe float FinishDelayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterDeadEyeConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterDeadEyeConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x060297EB RID: 169963 RVA: 0x009C5934 File Offset: 0x009C3B34
		protected BP_FollowShooterDeadEyeConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015435 RID: 87093
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/FollowShooter/DeadEye/BP_FollowShooterDeadEyeConfig.BP_FollowShooterDeadEyeConfig_C";

		// Token: 0x04015436 RID: 87094
		private static IntPtr _ClassPtr;

		// Token: 0x04015437 RID: 87095
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015438 RID: 87096
		internal static int __PropertyOffset_0;

		// Token: 0x04015439 RID: 87097
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, SDeadEyeConfig> _DeadEyeConfig;

		// Token: 0x0401543A RID: 87098
		internal static int __PropertyOffset_1;
	}
}

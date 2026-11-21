using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E4 RID: 13028
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_PartHitEffect.BP_PartHitEffect_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class BP_PartHitEffect_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021197 RID: 135575 RVA: 0x00959199 File Offset: 0x00957399
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PartHitEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_PartHitEffect.BP_PartHitEffect_C");
			}
			return BP_PartHitEffect_C._ClassPtr;
		}

		// Token: 0x06021198 RID: 135576 RVA: 0x009591C0 File Offset: 0x009573C0
		public BP_PartHitEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_PartHitEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021199 RID: 135577 RVA: 0x009591E8 File Offset: 0x009573E8
		public BP_PartHitEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PartHitEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x0602119A RID: 135578 RVA: 0x0095921C File Offset: 0x0095741C
		// (set) Token: 0x0602119B RID: 135579 RVA: 0x00959255 File Offset: 0x00957455
		public TArray<SPartHitEffect> PartCollision
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPartHitEffect> result;
				if ((result = this._PartCollision) == null)
				{
					result = (this._PartCollision = new TArray<SPartHitEffect>(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_PartCollision, this));
				}
				return result;
			}
			set
			{
				this.PartCollision.CopyAssign(value);
			}
		}

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x0602119C RID: 135580 RVA: 0x00959264 File Offset: 0x00957464
		// (set) Token: 0x0602119D RID: 135581 RVA: 0x0095929D File Offset: 0x0095749D
		public TArray<SAimPart> AimParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAimPart> result;
				if ((result = this._AimParts) == null)
				{
					result = (this._AimParts = new TArray<SAimPart>(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_AimParts, this));
				}
				return result;
			}
			set
			{
				this.AimParts.CopyAssign(value);
			}
		}

		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x0602119E RID: 135582 RVA: 0x009592AC File Offset: 0x009574AC
		// (set) Token: 0x0602119F RID: 135583 RVA: 0x009592E5 File Offset: 0x009574E5
		public TArray<SLockOnPart> LockOnParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SLockOnPart> result;
				if ((result = this._LockOnParts) == null)
				{
					result = (this._LockOnParts = new TArray<SLockOnPart>(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_LockOnParts, this));
				}
				return result;
			}
			set
			{
				this.LockOnParts.CopyAssign(value);
			}
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x060211A0 RID: 135584 RVA: 0x009592F3 File Offset: 0x009574F3
		// (set) Token: 0x060211A1 RID: 135585 RVA: 0x00959303 File Offset: 0x00957503
		public unsafe float StartHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_StartHideDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_StartHideDistance) = value;
			}
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x060211A2 RID: 135586 RVA: 0x00959314 File Offset: 0x00957514
		// (set) Token: 0x060211A3 RID: 135587 RVA: 0x00959324 File Offset: 0x00957524
		public unsafe float CompleteHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_CompleteHideDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_CompleteHideDistance) = value;
			}
		}

		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x060211A4 RID: 135588 RVA: 0x00959335 File Offset: 0x00957535
		// (set) Token: 0x060211A5 RID: 135589 RVA: 0x00959345 File Offset: 0x00957545
		public unsafe float StartDitherValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_StartDitherValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_StartDitherValue) = value;
			}
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x060211A6 RID: 135590 RVA: 0x00959358 File Offset: 0x00957558
		// (set) Token: 0x060211A7 RID: 135591 RVA: 0x00959391 File Offset: 0x00957591
		public SLockOnConfig LockOnConfig
		{
			get
			{
				base.FastCheckIsValid();
				SLockOnConfig result;
				if ((result = this._LockOnConfig) == null)
				{
					result = (this._LockOnConfig = new SLockOnConfig(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_LockOnConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SLockOnConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_LockOnConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x060211A8 RID: 135592 RVA: 0x009593B4 File Offset: 0x009575B4
		// (set) Token: 0x060211A9 RID: 135593 RVA: 0x009593ED File Offset: 0x009575ED
		public SCameraLockOnConfig CameraLockOnConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCameraLockOnConfig result;
				if ((result = this._CameraLockOnConfig) == null)
				{
					result = (this._CameraLockOnConfig = new SCameraLockOnConfig(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_CameraLockOnConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraLockOnConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_CameraLockOnConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x060211AA RID: 135594 RVA: 0x00959410 File Offset: 0x00957610
		// (set) Token: 0x060211AB RID: 135595 RVA: 0x00959449 File Offset: 0x00957649
		public SOcclusionDitherConfig OcclusionDitherConfig
		{
			get
			{
				base.FastCheckIsValid();
				SOcclusionDitherConfig result;
				if ((result = this._OcclusionDitherConfig) == null)
				{
					result = (this._OcclusionDitherConfig = new SOcclusionDitherConfig(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_OcclusionDitherConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SOcclusionDitherConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_OcclusionDitherConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060211AC RID: 135596 RVA: 0x0095946A File Offset: 0x0095766A
		protected BP_PartHitEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F5B RID: 73563
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_PartHitEffect.BP_PartHitEffect_C";

		// Token: 0x04011F5C RID: 73564
		private static IntPtr _ClassPtr;

		// Token: 0x04011F5D RID: 73565
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F5E RID: 73566
		internal static int __PropertyOffset_PartCollision;

		// Token: 0x04011F5F RID: 73567
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPartHitEffect> _PartCollision;

		// Token: 0x04011F60 RID: 73568
		internal static int __PropertyOffset_AimParts;

		// Token: 0x04011F61 RID: 73569
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAimPart> _AimParts;

		// Token: 0x04011F62 RID: 73570
		internal static int __PropertyOffset_LockOnParts;

		// Token: 0x04011F63 RID: 73571
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SLockOnPart> _LockOnParts;

		// Token: 0x04011F64 RID: 73572
		internal static int __PropertyOffset_StartHideDistance;

		// Token: 0x04011F65 RID: 73573
		internal static int __PropertyOffset_CompleteHideDistance;

		// Token: 0x04011F66 RID: 73574
		internal static int __PropertyOffset_StartDitherValue;

		// Token: 0x04011F67 RID: 73575
		internal static int __PropertyOffset_LockOnConfig;

		// Token: 0x04011F68 RID: 73576
		[Nullable(2)]
		private SLockOnConfig _LockOnConfig;

		// Token: 0x04011F69 RID: 73577
		internal static int __PropertyOffset_CameraLockOnConfig;

		// Token: 0x04011F6A RID: 73578
		[Nullable(2)]
		private SCameraLockOnConfig _CameraLockOnConfig;

		// Token: 0x04011F6B RID: 73579
		internal static int __PropertyOffset_OcclusionDitherConfig;

		// Token: 0x04011F6C RID: 73580
		[Nullable(2)]
		private SOcclusionDitherConfig _OcclusionDitherConfig;
	}
}

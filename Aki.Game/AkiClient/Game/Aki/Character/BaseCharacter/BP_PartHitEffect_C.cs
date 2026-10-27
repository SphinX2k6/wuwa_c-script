using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004282 RID: 17026
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_PartHitEffect.BP_PartHitEffect_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class BP_PartHitEffect_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C34A RID: 181066 RVA: 0x00A19EB4 File Offset: 0x00A180B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PartHitEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_PartHitEffect.BP_PartHitEffect_C");
			}
			return BP_PartHitEffect_C._ClassPtr;
		}

		// Token: 0x0602C34B RID: 181067 RVA: 0x00A19ED8 File Offset: 0x00A180D8
		public BP_PartHitEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_PartHitEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C34C RID: 181068 RVA: 0x00A19F00 File Offset: 0x00A18100
		public BP_PartHitEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PartHitEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E25 RID: 28197
		// (get) Token: 0x0602C34D RID: 181069 RVA: 0x00A19F34 File Offset: 0x00A18134
		// (set) Token: 0x0602C34E RID: 181070 RVA: 0x00A19F6D File Offset: 0x00A1816D
		public TArray<SPartHitEffect> PartCollision
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPartHitEffect> result;
				if ((result = this._PartCollision) == null)
				{
					result = (this._PartCollision = new TArray<SPartHitEffect>(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.PartCollision.CopyAssign(value);
			}
		}

		// Token: 0x17006E26 RID: 28198
		// (get) Token: 0x0602C34F RID: 181071 RVA: 0x00A19F7C File Offset: 0x00A1817C
		// (set) Token: 0x0602C350 RID: 181072 RVA: 0x00A19FB5 File Offset: 0x00A181B5
		public TArray<SAimPart> AimParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAimPart> result;
				if ((result = this._AimParts) == null)
				{
					result = (this._AimParts = new TArray<SAimPart>(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.AimParts.CopyAssign(value);
			}
		}

		// Token: 0x17006E27 RID: 28199
		// (get) Token: 0x0602C351 RID: 181073 RVA: 0x00A19FC4 File Offset: 0x00A181C4
		// (set) Token: 0x0602C352 RID: 181074 RVA: 0x00A19FFD File Offset: 0x00A181FD
		public TArray<SLockOnPart> LockOnParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SLockOnPart> result;
				if ((result = this._LockOnParts) == null)
				{
					result = (this._LockOnParts = new TArray<SLockOnPart>(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.LockOnParts.CopyAssign(value);
			}
		}

		// Token: 0x17006E28 RID: 28200
		// (get) Token: 0x0602C353 RID: 181075 RVA: 0x00A1A00B File Offset: 0x00A1820B
		// (set) Token: 0x0602C354 RID: 181076 RVA: 0x00A1A01B File Offset: 0x00A1821B
		public unsafe float StartHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006E29 RID: 28201
		// (get) Token: 0x0602C355 RID: 181077 RVA: 0x00A1A02C File Offset: 0x00A1822C
		// (set) Token: 0x0602C356 RID: 181078 RVA: 0x00A1A03C File Offset: 0x00A1823C
		public unsafe float CompleteHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006E2A RID: 28202
		// (get) Token: 0x0602C357 RID: 181079 RVA: 0x00A1A04D File Offset: 0x00A1824D
		// (set) Token: 0x0602C358 RID: 181080 RVA: 0x00A1A05D File Offset: 0x00A1825D
		public unsafe float StartDitherValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006E2B RID: 28203
		// (get) Token: 0x0602C359 RID: 181081 RVA: 0x00A1A070 File Offset: 0x00A18270
		// (set) Token: 0x0602C35A RID: 181082 RVA: 0x00A1A0A9 File Offset: 0x00A182A9
		public SLockOnConfig LockOnConfig
		{
			get
			{
				base.FastCheckIsValid();
				SLockOnConfig result;
				if ((result = this._LockOnConfig) == null)
				{
					result = (this._LockOnConfig = new SLockOnConfig(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SLockOnConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E2C RID: 28204
		// (get) Token: 0x0602C35B RID: 181083 RVA: 0x00A1A0CC File Offset: 0x00A182CC
		// (set) Token: 0x0602C35C RID: 181084 RVA: 0x00A1A105 File Offset: 0x00A18305
		public SCameraLockOnConfig CameraLockOnConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCameraLockOnConfig result;
				if ((result = this._CameraLockOnConfig) == null)
				{
					result = (this._CameraLockOnConfig = new SCameraLockOnConfig(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraLockOnConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E2D RID: 28205
		// (get) Token: 0x0602C35D RID: 181085 RVA: 0x00A1A128 File Offset: 0x00A18328
		// (set) Token: 0x0602C35E RID: 181086 RVA: 0x00A1A161 File Offset: 0x00A18361
		public SOcclusionDitherConfig OcclusionDitherConfig
		{
			get
			{
				base.FastCheckIsValid();
				SOcclusionDitherConfig result;
				if ((result = this._OcclusionDitherConfig) == null)
				{
					result = (this._OcclusionDitherConfig = new SOcclusionDitherConfig(base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SOcclusionDitherConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PartHitEffect_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C35F RID: 181087 RVA: 0x00A1A182 File Offset: 0x00A18382
		protected BP_PartHitEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017234 RID: 94772
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_PartHitEffect.BP_PartHitEffect_C";

		// Token: 0x04017235 RID: 94773
		private static IntPtr _ClassPtr;

		// Token: 0x04017236 RID: 94774
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017237 RID: 94775
		internal static int __PropertyOffset_0;

		// Token: 0x04017238 RID: 94776
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPartHitEffect> _PartCollision;

		// Token: 0x04017239 RID: 94777
		internal static int __PropertyOffset_1;

		// Token: 0x0401723A RID: 94778
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SAimPart> _AimParts;

		// Token: 0x0401723B RID: 94779
		internal static int __PropertyOffset_2;

		// Token: 0x0401723C RID: 94780
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SLockOnPart> _LockOnParts;

		// Token: 0x0401723D RID: 94781
		internal static int __PropertyOffset_3;

		// Token: 0x0401723E RID: 94782
		internal static int __PropertyOffset_4;

		// Token: 0x0401723F RID: 94783
		internal static int __PropertyOffset_5;

		// Token: 0x04017240 RID: 94784
		internal static int __PropertyOffset_6;

		// Token: 0x04017241 RID: 94785
		[Nullable(2)]
		private SLockOnConfig _LockOnConfig;

		// Token: 0x04017242 RID: 94786
		internal static int __PropertyOffset_7;

		// Token: 0x04017243 RID: 94787
		[Nullable(2)]
		private SCameraLockOnConfig _CameraLockOnConfig;

		// Token: 0x04017244 RID: 94788
		internal static int __PropertyOffset_8;

		// Token: 0x04017245 RID: 94789
		[Nullable(2)]
		private SOcclusionDitherConfig _OcclusionDitherConfig;
	}
}

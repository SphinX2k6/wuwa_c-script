using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E07 RID: 7687
	public class IMotorcycleTrack : ISplineMovePattern
	{
		// Token: 0x0600A369 RID: 41833 RVA: 0x00175BB0 File Offset: 0x00173DB0
		private IMotorcycleTrack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorcycleTrack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorcycleTrack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorcycleTrack_SetValue());
			}
			return result;
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x00175BE8 File Offset: 0x00173DE8
		public static IMotorcycleTrack Create([Nullable(2)] IMotorcycleTrack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorcycleTrack
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x00175BFB File Offset: 0x00173DFB
		public static IMotorcycleTrack CreateFromSetValue([Nullable(2)] IMotorcycleTrack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorcycleTrack
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x00175C10 File Offset: 0x00173E10
		public new IMotorcycleTrack_SetValue ToSetValue()
		{
			return new IMotorcycleTrack_SetValue
			{
				Type = this.Type,
				MaxOffsetDistance = this.MaxOffsetDistance,
				IsOneWay = this.IsOneWay,
				LayerVerticalLimit = this.LayerVerticalLimit,
				DynamicGravity = this.DynamicGravity,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity,
				AutoExitDistance = this.AutoExitDistance,
				DisableAutoForward = this.DisableAutoForward,
				LongitudinalAngleLimit = this.LongitudinalAngleLimit,
				ForwardAngleLimit = this.ForwardAngleLimit,
				ForwardAngleLimitCurve = this.ForwardAngleLimitCurve,
				InputCorrectionCurve = this.InputCorrectionCurve,
				InputCorrectionBaseAngle = this.InputCorrectionBaseAngle,
				CorrectionPredictionDistance = this.CorrectionPredictionDistance,
				AccelerationCorrectionCurve = this.AccelerationCorrectionCurve,
				AutomaticDrive = this.AutomaticDrive
			};
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600A36D RID: 41837 RVA: 0x00175CE2 File Offset: 0x00173EE2
		// (set) Token: 0x0600A36E RID: 41838 RVA: 0x00175D0D File Offset: 0x00173F0D
		public override ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600A36F RID: 41839 RVA: 0x00175D1C File Offset: 0x00173F1C
		// (set) Token: 0x0600A370 RID: 41840 RVA: 0x00175D56 File Offset: 0x00173F56
		public override float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxOffsetDistance = value;
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600A371 RID: 41841 RVA: 0x00175D64 File Offset: 0x00173F64
		// (set) Token: 0x0600A372 RID: 41842 RVA: 0x00175D9E File Offset: 0x00173F9E
		public override bool? IsOneWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOneWay;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOneWay;
			}
			set
			{
				this.GetOrCreatePoco().IsOneWay = value;
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600A373 RID: 41843 RVA: 0x00175DAC File Offset: 0x00173FAC
		// (set) Token: 0x0600A374 RID: 41844 RVA: 0x00175DE6 File Offset: 0x00173FE6
		public override float? LayerVerticalLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LayerVerticalLimit;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LayerVerticalLimit;
			}
			set
			{
				this.GetOrCreatePoco().LayerVerticalLimit = value;
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600A375 RID: 41845 RVA: 0x00175DF4 File Offset: 0x00173FF4
		// (set) Token: 0x0600A376 RID: 41846 RVA: 0x00175E2E File Offset: 0x0017402E
		public override bool? DynamicGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicGravity;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DynamicGravity;
			}
			set
			{
				this.GetOrCreatePoco().DynamicGravity = value;
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600A377 RID: 41847 RVA: 0x00175E3C File Offset: 0x0017403C
		// (set) Token: 0x0600A378 RID: 41848 RVA: 0x00175E76 File Offset: 0x00174076
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600A379 RID: 41849 RVA: 0x00175E84 File Offset: 0x00174084
		// (set) Token: 0x0600A37A RID: 41850 RVA: 0x00175EBE File Offset: 0x001740BE
		public override int? AutoExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitDistance;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoExitDistance;
			}
			set
			{
				this.GetOrCreatePoco().AutoExitDistance = value;
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600A37B RID: 41851 RVA: 0x00175ECC File Offset: 0x001740CC
		// (set) Token: 0x0600A37C RID: 41852 RVA: 0x00175F06 File Offset: 0x00174106
		public virtual bool? DisableAutoForward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableAutoForward;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableAutoForward;
			}
			set
			{
				this.GetOrCreatePoco().DisableAutoForward = value;
			}
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600A37D RID: 41853 RVA: 0x00175F14 File Offset: 0x00174114
		// (set) Token: 0x0600A37E RID: 41854 RVA: 0x00175F4E File Offset: 0x0017414E
		public virtual float? LongitudinalAngleLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LongitudinalAngleLimit;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LongitudinalAngleLimit;
			}
			set
			{
				this.GetOrCreatePoco().LongitudinalAngleLimit = value;
			}
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600A37F RID: 41855 RVA: 0x00175F5C File Offset: 0x0017415C
		// (set) Token: 0x0600A380 RID: 41856 RVA: 0x00175F8B File Offset: 0x0017418B
		public virtual float ForwardAngleLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardAngleLimit;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ForwardAngleLimit;
			}
			set
			{
				this.GetOrCreatePoco().ForwardAngleLimit = value;
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600A381 RID: 41857 RVA: 0x00175F99 File Offset: 0x00174199
		// (set) Token: 0x0600A382 RID: 41858 RVA: 0x00175FC0 File Offset: 0x001741C0
		[Nullable(2)]
		public virtual string ForwardAngleLimitCurve
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardAngleLimitCurve;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForwardAngleLimitCurve;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ForwardAngleLimitCurve = value;
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600A383 RID: 41859 RVA: 0x00175FCE File Offset: 0x001741CE
		// (set) Token: 0x0600A384 RID: 41860 RVA: 0x00175FF9 File Offset: 0x001741F9
		public virtual string InputCorrectionCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InputCorrectionCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.InputCorrectionCurve;
			}
			set
			{
				this.GetOrCreatePoco().InputCorrectionCurve = value;
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600A385 RID: 41861 RVA: 0x00176008 File Offset: 0x00174208
		// (set) Token: 0x0600A386 RID: 41862 RVA: 0x00176042 File Offset: 0x00174242
		public virtual float? InputCorrectionBaseAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InputCorrectionBaseAngle;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InputCorrectionBaseAngle;
			}
			set
			{
				this.GetOrCreatePoco().InputCorrectionBaseAngle = value;
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600A387 RID: 41863 RVA: 0x00176050 File Offset: 0x00174250
		// (set) Token: 0x0600A388 RID: 41864 RVA: 0x0017608A File Offset: 0x0017428A
		public virtual float? CorrectionPredictionDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CorrectionPredictionDistance;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CorrectionPredictionDistance;
			}
			set
			{
				this.GetOrCreatePoco().CorrectionPredictionDistance = value;
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600A389 RID: 41865 RVA: 0x00176098 File Offset: 0x00174298
		// (set) Token: 0x0600A38A RID: 41866 RVA: 0x001760C3 File Offset: 0x001742C3
		public virtual string AccelerationCorrectionCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AccelerationCorrectionCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AccelerationCorrectionCurve;
			}
			set
			{
				this.GetOrCreatePoco().AccelerationCorrectionCurve = value;
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600A38B RID: 41867 RVA: 0x001760D4 File Offset: 0x001742D4
		// (set) Token: 0x0600A38C RID: 41868 RVA: 0x00176135 File Offset: 0x00174335
		[Nullable(2)]
		public virtual IAutomaticDrive AutomaticDrive
		{
			[NullableContext(2)]
			get
			{
				if (this._AutomaticDriveInited)
				{
					return this._AutomaticDriveCache;
				}
				this._AutomaticDriveInited = true;
				if (this.FbInstance != null)
				{
					this._AutomaticDriveCache = IAutomaticDrive.Create(this.FbInstance.AutomaticDrive);
				}
				else
				{
					IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
					this._AutomaticDriveCache = ((pocoInterface != null) ? pocoInterface.AutomaticDrive : null);
				}
				return this._AutomaticDriveCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AutomaticDrive = value;
				this._AutomaticDriveInited = false;
			}
		}

		// Token: 0x040062FD RID: 25341
		[Nullable(2)]
		protected new IMotorcycleTrack FbInstance;

		// Token: 0x040062FE RID: 25342
		[Nullable(2)]
		protected new IMotorcycleTrack_SetValue PocoInterface;

		// Token: 0x040062FF RID: 25343
		private IAutomaticDrive _AutomaticDriveCache;

		// Token: 0x04006300 RID: 25344
		private bool _AutomaticDriveInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB9 RID: 11193
	public class IMotorcycleTrack : ISplineMovePattern
	{
		// Token: 0x0600F6BD RID: 63165 RVA: 0x0023F08B File Offset: 0x0023D28B
		public static IMotorcycleTrack Create(IMotorcycleTrack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorcycleTrack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x0600F6BE RID: 63166 RVA: 0x0023F0AA File Offset: 0x0023D2AA
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x0600F6BF RID: 63167 RVA: 0x0023F0B8 File Offset: 0x0023D2B8
		public override float? MaxOffsetDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MaxOffsetDistance);
			}
		}

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x0600F6C0 RID: 63168 RVA: 0x0023F0F0 File Offset: 0x0023D2F0
		public override bool? IsOneWay
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOneWay);
			}
		}

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x0600F6C1 RID: 63169 RVA: 0x0023F128 File Offset: 0x0023D328
		public override float? LayerVerticalLimit
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LayerVerticalLimit);
			}
		}

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x0600F6C2 RID: 63170 RVA: 0x0023F160 File Offset: 0x0023D360
		public override bool? DynamicGravity
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DynamicGravity);
			}
		}

		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x0600F6C3 RID: 63171 RVA: 0x0023F198 File Offset: 0x0023D398
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new float?(this.Instance.GravitySwitchAngularVelocity);
			}
		}

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x0600F6C4 RID: 63172 RVA: 0x0023F1D0 File Offset: 0x0023D3D0
		public override int? AutoExitDistance
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AutoExitDistance);
			}
		}

		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x0600F6C5 RID: 63173 RVA: 0x0023F208 File Offset: 0x0023D408
		public virtual bool? DisableAutoForward
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableAutoForward);
			}
		}

		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x0600F6C6 RID: 63174 RVA: 0x0023F240 File Offset: 0x0023D440
		public virtual float? LongitudinalAngleLimit
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LongitudinalAngleLimit);
			}
		}

		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x0600F6C7 RID: 63175 RVA: 0x0023F27A File Offset: 0x0023D47A
		public virtual float ForwardAngleLimit
		{
			get
			{
				return this.Instance.ForwardAngleLimit;
			}
		}

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x0600F6C8 RID: 63176 RVA: 0x0023F287 File Offset: 0x0023D487
		[Nullable(2)]
		public virtual string ForwardAngleLimitCurve
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ForwardAngleLimitCurve;
			}
		}

		// Token: 0x17004C04 RID: 19460
		// (get) Token: 0x0600F6C9 RID: 63177 RVA: 0x0023F294 File Offset: 0x0023D494
		public virtual string InputCorrectionCurve
		{
			get
			{
				return this.Instance.InputCorrectionCurve;
			}
		}

		// Token: 0x17004C05 RID: 19461
		// (get) Token: 0x0600F6CA RID: 63178 RVA: 0x0023F2A4 File Offset: 0x0023D4A4
		public virtual float? InputCorrectionBaseAngle
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new float?(this.Instance.InputCorrectionBaseAngle);
			}
		}

		// Token: 0x17004C06 RID: 19462
		// (get) Token: 0x0600F6CB RID: 63179 RVA: 0x0023F2E0 File Offset: 0x0023D4E0
		public virtual float? CorrectionPredictionDistance
		{
			get
			{
				if ((this.Instance.NullMask & 512) == 0)
				{
					return null;
				}
				return new float?(this.Instance.CorrectionPredictionDistance);
			}
		}

		// Token: 0x17004C07 RID: 19463
		// (get) Token: 0x0600F6CC RID: 63180 RVA: 0x0023F31A File Offset: 0x0023D51A
		public virtual string AccelerationCorrectionCurve
		{
			get
			{
				return this.Instance.AccelerationCorrectionCurve;
			}
		}

		// Token: 0x17004C08 RID: 19464
		// (get) Token: 0x0600F6CD RID: 63181 RVA: 0x0023F327 File Offset: 0x0023D527
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
				this._AutomaticDriveCache = IAutomaticDrive.Create(this.Instance.AutomaticDrive);
				return this._AutomaticDriveCache;
			}
		}

		// Token: 0x04008727 RID: 34599
		private IMotorcycleTrack Instance;

		// Token: 0x04008728 RID: 34600
		[Nullable(2)]
		private IAutomaticDrive _AutomaticDriveCache;

		// Token: 0x04008729 RID: 34601
		private bool _AutomaticDriveInited;
	}
}

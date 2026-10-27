using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E1 RID: 10465
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorcycleTrack : ISplineMovePattern
	{
		// Token: 0x0600E87C RID: 59516 RVA: 0x00221ED2 File Offset: 0x002200D2
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

		// Token: 0x1700487C RID: 18556
		// (get) Token: 0x0600E87D RID: 59517 RVA: 0x00221EF1 File Offset: 0x002200F1
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x0600E87E RID: 59518 RVA: 0x00221F00 File Offset: 0x00220100
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

		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x0600E87F RID: 59519 RVA: 0x00221F38 File Offset: 0x00220138
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

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x0600E880 RID: 59520 RVA: 0x00221F70 File Offset: 0x00220170
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

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x0600E881 RID: 59521 RVA: 0x00221FA8 File Offset: 0x002201A8
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

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x0600E882 RID: 59522 RVA: 0x00221FE0 File Offset: 0x002201E0
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

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x0600E883 RID: 59523 RVA: 0x00222018 File Offset: 0x00220218
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

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x0600E884 RID: 59524 RVA: 0x00222050 File Offset: 0x00220250
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

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x0600E885 RID: 59525 RVA: 0x00222088 File Offset: 0x00220288
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

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x0600E886 RID: 59526 RVA: 0x002220C2 File Offset: 0x002202C2
		public virtual float ForwardAngleLimit
		{
			get
			{
				return this.Instance.ForwardAngleLimit;
			}
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x0600E887 RID: 59527 RVA: 0x002220CF File Offset: 0x002202CF
		[Nullable(2)]
		public virtual string ForwardAngleLimitCurve
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ForwardAngleLimitCurve;
			}
		}

		// Token: 0x17004887 RID: 18567
		// (get) Token: 0x0600E888 RID: 59528 RVA: 0x002220DC File Offset: 0x002202DC
		public virtual string InputCorrectionCurve
		{
			get
			{
				return this.Instance.InputCorrectionCurve;
			}
		}

		// Token: 0x17004888 RID: 18568
		// (get) Token: 0x0600E889 RID: 59529 RVA: 0x002220EC File Offset: 0x002202EC
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

		// Token: 0x17004889 RID: 18569
		// (get) Token: 0x0600E88A RID: 59530 RVA: 0x00222128 File Offset: 0x00220328
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

		// Token: 0x1700488A RID: 18570
		// (get) Token: 0x0600E88B RID: 59531 RVA: 0x00222162 File Offset: 0x00220362
		public virtual string AccelerationCorrectionCurve
		{
			get
			{
				return this.Instance.AccelerationCorrectionCurve;
			}
		}

		// Token: 0x1700488B RID: 18571
		// (get) Token: 0x0600E88C RID: 59532 RVA: 0x0022216F File Offset: 0x0022036F
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

		// Token: 0x04008063 RID: 32867
		private IMotorcycleTrack Instance;

		// Token: 0x04008064 RID: 32868
		[Nullable(2)]
		private IAutomaticDrive _AutomaticDriveCache;

		// Token: 0x04008065 RID: 32869
		private bool _AutomaticDriveInited;
	}
}

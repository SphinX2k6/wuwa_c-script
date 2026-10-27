using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DF RID: 10463
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechaAirPassageMove : ISplineMovePattern
	{
		// Token: 0x0600E86B RID: 59499 RVA: 0x00221C7F File Offset: 0x0021FE7F
		public static IMechaAirPassageMove Create(IMechaAirPassageMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaAirPassageMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700486F RID: 18543
		// (get) Token: 0x0600E86C RID: 59500 RVA: 0x00221C9E File Offset: 0x0021FE9E
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004870 RID: 18544
		// (get) Token: 0x0600E86D RID: 59501 RVA: 0x00221CAC File Offset: 0x0021FEAC
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

		// Token: 0x17004871 RID: 18545
		// (get) Token: 0x0600E86E RID: 59502 RVA: 0x00221CE4 File Offset: 0x0021FEE4
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

		// Token: 0x17004872 RID: 18546
		// (get) Token: 0x0600E86F RID: 59503 RVA: 0x00221D1C File Offset: 0x0021FF1C
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

		// Token: 0x17004873 RID: 18547
		// (get) Token: 0x0600E870 RID: 59504 RVA: 0x00221D54 File Offset: 0x0021FF54
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

		// Token: 0x17004874 RID: 18548
		// (get) Token: 0x0600E871 RID: 59505 RVA: 0x00221D8C File Offset: 0x0021FF8C
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

		// Token: 0x17004875 RID: 18549
		// (get) Token: 0x0600E872 RID: 59506 RVA: 0x00221DC4 File Offset: 0x0021FFC4
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

		// Token: 0x17004876 RID: 18550
		// (get) Token: 0x0600E873 RID: 59507 RVA: 0x00221DFB File Offset: 0x0021FFFB
		public virtual float ForwardAngleLimit
		{
			get
			{
				return this.Instance.ForwardAngleLimit;
			}
		}

		// Token: 0x17004877 RID: 18551
		// (get) Token: 0x0600E874 RID: 59508 RVA: 0x00221E08 File Offset: 0x00220008
		[Nullable(2)]
		public virtual string ForwardAngleLimitCurve
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ForwardAngleLimitCurve;
			}
		}

		// Token: 0x17004878 RID: 18552
		// (get) Token: 0x0600E875 RID: 59509 RVA: 0x00221E15 File Offset: 0x00220015
		public virtual string InputCorrectionCurve
		{
			get
			{
				return this.Instance.InputCorrectionCurve;
			}
		}

		// Token: 0x17004879 RID: 18553
		// (get) Token: 0x0600E876 RID: 59510 RVA: 0x00221E24 File Offset: 0x00220024
		public virtual float? InputCorrectionBaseAngle
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new float?(this.Instance.InputCorrectionBaseAngle);
			}
		}

		// Token: 0x1700487A RID: 18554
		// (get) Token: 0x0600E877 RID: 59511 RVA: 0x00221E5C File Offset: 0x0022005C
		public virtual float? CorrectionPredictionDistance
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new float?(this.Instance.CorrectionPredictionDistance);
			}
		}

		// Token: 0x04008061 RID: 32865
		private IMechaAirPassageMove Instance;
	}
}

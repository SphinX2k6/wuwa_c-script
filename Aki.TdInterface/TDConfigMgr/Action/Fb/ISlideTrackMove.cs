using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB1 RID: 11185
	public class ISlideTrackMove : ISplineMovePattern
	{
		// Token: 0x0600F681 RID: 63105 RVA: 0x0023E868 File Offset: 0x0023CA68
		public static ISlideTrackMove Create(ISlideTrackMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideTrackMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BCD RID: 19405
		// (get) Token: 0x0600F682 RID: 63106 RVA: 0x0023E887 File Offset: 0x0023CA87
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004BCE RID: 19406
		// (get) Token: 0x0600F683 RID: 63107 RVA: 0x0023E894 File Offset: 0x0023CA94
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

		// Token: 0x17004BCF RID: 19407
		// (get) Token: 0x0600F684 RID: 63108 RVA: 0x0023E8CC File Offset: 0x0023CACC
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

		// Token: 0x17004BD0 RID: 19408
		// (get) Token: 0x0600F685 RID: 63109 RVA: 0x0023E904 File Offset: 0x0023CB04
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

		// Token: 0x17004BD1 RID: 19409
		// (get) Token: 0x0600F686 RID: 63110 RVA: 0x0023E93C File Offset: 0x0023CB3C
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

		// Token: 0x17004BD2 RID: 19410
		// (get) Token: 0x0600F687 RID: 63111 RVA: 0x0023E974 File Offset: 0x0023CB74
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

		// Token: 0x17004BD3 RID: 19411
		// (get) Token: 0x0600F688 RID: 63112 RVA: 0x0023E9AC File Offset: 0x0023CBAC
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

		// Token: 0x17004BD4 RID: 19412
		// (get) Token: 0x0600F689 RID: 63113 RVA: 0x0023E9E3 File Offset: 0x0023CBE3
		public virtual float DirectionAngleLimit
		{
			get
			{
				return this.Instance.DirectionAngleLimit;
			}
		}

		// Token: 0x17004BD5 RID: 19413
		// (get) Token: 0x0600F68A RID: 63114 RVA: 0x0023E9F0 File Offset: 0x0023CBF0
		public virtual float EdgeLimitCurveFactor
		{
			get
			{
				return this.Instance.EdgeLimitCurveFactor;
			}
		}

		// Token: 0x0400871B RID: 34587
		private ISlideTrackMove Instance;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB0 RID: 11184
	public class IRacingTrackMove : ISplineMovePattern
	{
		// Token: 0x0600F677 RID: 63095 RVA: 0x0023E6D6 File Offset: 0x0023C8D6
		public static IRacingTrackMove Create(IRacingTrackMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRacingTrackMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BC5 RID: 19397
		// (get) Token: 0x0600F678 RID: 63096 RVA: 0x0023E6F5 File Offset: 0x0023C8F5
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004BC6 RID: 19398
		// (get) Token: 0x0600F679 RID: 63097 RVA: 0x0023E704 File Offset: 0x0023C904
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

		// Token: 0x17004BC7 RID: 19399
		// (get) Token: 0x0600F67A RID: 63098 RVA: 0x0023E73C File Offset: 0x0023C93C
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

		// Token: 0x17004BC8 RID: 19400
		// (get) Token: 0x0600F67B RID: 63099 RVA: 0x0023E774 File Offset: 0x0023C974
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

		// Token: 0x17004BC9 RID: 19401
		// (get) Token: 0x0600F67C RID: 63100 RVA: 0x0023E7AC File Offset: 0x0023C9AC
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

		// Token: 0x17004BCA RID: 19402
		// (get) Token: 0x0600F67D RID: 63101 RVA: 0x0023E7E4 File Offset: 0x0023C9E4
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

		// Token: 0x17004BCB RID: 19403
		// (get) Token: 0x0600F67E RID: 63102 RVA: 0x0023E81C File Offset: 0x0023CA1C
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

		// Token: 0x17004BCC RID: 19404
		// (get) Token: 0x0600F67F RID: 63103 RVA: 0x0023E853 File Offset: 0x0023CA53
		public virtual float DirectionAngleLimit
		{
			get
			{
				return this.Instance.DirectionAngleLimit;
			}
		}

		// Token: 0x0400871A RID: 34586
		private IRacingTrackMove Instance;
	}
}

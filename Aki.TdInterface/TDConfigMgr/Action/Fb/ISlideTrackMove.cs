using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DC RID: 10460
	public class ISlideTrackMove : ISplineMovePattern
	{
		// Token: 0x0600E852 RID: 59474 RVA: 0x002218E8 File Offset: 0x0021FAE8
		[NullableContext(1)]
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

		// Token: 0x1700485C RID: 18524
		// (get) Token: 0x0600E853 RID: 59475 RVA: 0x00221907 File Offset: 0x0021FB07
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x1700485D RID: 18525
		// (get) Token: 0x0600E854 RID: 59476 RVA: 0x00221914 File Offset: 0x0021FB14
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

		// Token: 0x1700485E RID: 18526
		// (get) Token: 0x0600E855 RID: 59477 RVA: 0x0022194C File Offset: 0x0021FB4C
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

		// Token: 0x1700485F RID: 18527
		// (get) Token: 0x0600E856 RID: 59478 RVA: 0x00221984 File Offset: 0x0021FB84
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

		// Token: 0x17004860 RID: 18528
		// (get) Token: 0x0600E857 RID: 59479 RVA: 0x002219BC File Offset: 0x0021FBBC
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

		// Token: 0x17004861 RID: 18529
		// (get) Token: 0x0600E858 RID: 59480 RVA: 0x002219F4 File Offset: 0x0021FBF4
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

		// Token: 0x17004862 RID: 18530
		// (get) Token: 0x0600E859 RID: 59481 RVA: 0x00221A2C File Offset: 0x0021FC2C
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

		// Token: 0x17004863 RID: 18531
		// (get) Token: 0x0600E85A RID: 59482 RVA: 0x00221A63 File Offset: 0x0021FC63
		public virtual float DirectionAngleLimit
		{
			get
			{
				return this.Instance.DirectionAngleLimit;
			}
		}

		// Token: 0x17004864 RID: 18532
		// (get) Token: 0x0600E85B RID: 59483 RVA: 0x00221A70 File Offset: 0x0021FC70
		public virtual float EdgeLimitCurveFactor
		{
			get
			{
				return this.Instance.EdgeLimitCurveFactor;
			}
		}

		// Token: 0x0400805C RID: 32860
		private ISlideTrackMove Instance;
	}
}

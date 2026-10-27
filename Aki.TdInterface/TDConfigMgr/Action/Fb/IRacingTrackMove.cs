using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DB RID: 10459
	public class IRacingTrackMove : ISplineMovePattern
	{
		// Token: 0x0600E848 RID: 59464 RVA: 0x00221756 File Offset: 0x0021F956
		[NullableContext(1)]
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

		// Token: 0x17004854 RID: 18516
		// (get) Token: 0x0600E849 RID: 59465 RVA: 0x00221775 File Offset: 0x0021F975
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004855 RID: 18517
		// (get) Token: 0x0600E84A RID: 59466 RVA: 0x00221784 File Offset: 0x0021F984
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

		// Token: 0x17004856 RID: 18518
		// (get) Token: 0x0600E84B RID: 59467 RVA: 0x002217BC File Offset: 0x0021F9BC
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

		// Token: 0x17004857 RID: 18519
		// (get) Token: 0x0600E84C RID: 59468 RVA: 0x002217F4 File Offset: 0x0021F9F4
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

		// Token: 0x17004858 RID: 18520
		// (get) Token: 0x0600E84D RID: 59469 RVA: 0x0022182C File Offset: 0x0021FA2C
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

		// Token: 0x17004859 RID: 18521
		// (get) Token: 0x0600E84E RID: 59470 RVA: 0x00221864 File Offset: 0x0021FA64
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

		// Token: 0x1700485A RID: 18522
		// (get) Token: 0x0600E84F RID: 59471 RVA: 0x0022189C File Offset: 0x0021FA9C
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

		// Token: 0x1700485B RID: 18523
		// (get) Token: 0x0600E850 RID: 59472 RVA: 0x002218D3 File Offset: 0x0021FAD3
		public virtual float DirectionAngleLimit
		{
			get
			{
				return this.Instance.DirectionAngleLimit;
			}
		}

		// Token: 0x0400805B RID: 32859
		private IRacingTrackMove Instance;
	}
}

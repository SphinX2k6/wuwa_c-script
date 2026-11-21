using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C2 RID: 8386
	public class ISlideTrackMove : ISplineMovePattern
	{
		// Token: 0x0600B208 RID: 45576 RVA: 0x00190010 File Offset: 0x0018E210
		private ISlideTrackMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlideTrackMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlideTrackMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlideTrackMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x00190048 File Offset: 0x0018E248
		public static ISlideTrackMove Create([Nullable(2)] ISlideTrackMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideTrackMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B20A RID: 45578 RVA: 0x0019005B File Offset: 0x0018E25B
		public static ISlideTrackMove CreateFromSetValue([Nullable(2)] ISlideTrackMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlideTrackMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B20B RID: 45579 RVA: 0x00190070 File Offset: 0x0018E270
		public new ISlideTrackMove_SetValue ToSetValue()
		{
			return new ISlideTrackMove_SetValue
			{
				Type = this.Type,
				MaxOffsetDistance = this.MaxOffsetDistance,
				IsOneWay = this.IsOneWay,
				LayerVerticalLimit = this.LayerVerticalLimit,
				DynamicGravity = this.DynamicGravity,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity,
				AutoExitDistance = this.AutoExitDistance,
				DirectionAngleLimit = this.DirectionAngleLimit,
				EdgeLimitCurveFactor = this.EdgeLimitCurveFactor
			};
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600B20C RID: 45580 RVA: 0x001900EE File Offset: 0x0018E2EE
		// (set) Token: 0x0600B20D RID: 45581 RVA: 0x00190119 File Offset: 0x0018E319
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

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600B20E RID: 45582 RVA: 0x00190128 File Offset: 0x0018E328
		// (set) Token: 0x0600B20F RID: 45583 RVA: 0x00190162 File Offset: 0x0018E362
		public override float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				ISlideTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600B210 RID: 45584 RVA: 0x00190170 File Offset: 0x0018E370
		// (set) Token: 0x0600B211 RID: 45585 RVA: 0x001901AA File Offset: 0x0018E3AA
		public override bool? IsOneWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOneWay;
				}
				ISlideTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600B212 RID: 45586 RVA: 0x001901B8 File Offset: 0x0018E3B8
		// (set) Token: 0x0600B213 RID: 45587 RVA: 0x001901F2 File Offset: 0x0018E3F2
		public override float? LayerVerticalLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LayerVerticalLimit;
				}
				ISlideTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600B214 RID: 45588 RVA: 0x00190200 File Offset: 0x0018E400
		// (set) Token: 0x0600B215 RID: 45589 RVA: 0x0019023A File Offset: 0x0018E43A
		public override bool? DynamicGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicGravity;
				}
				ISlideTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600B216 RID: 45590 RVA: 0x00190248 File Offset: 0x0018E448
		// (set) Token: 0x0600B217 RID: 45591 RVA: 0x00190282 File Offset: 0x0018E482
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ISlideTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600B218 RID: 45592 RVA: 0x00190290 File Offset: 0x0018E490
		// (set) Token: 0x0600B219 RID: 45593 RVA: 0x001902CA File Offset: 0x0018E4CA
		public override int? AutoExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitDistance;
				}
				ISlideTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600B21A RID: 45594 RVA: 0x001902D8 File Offset: 0x0018E4D8
		// (set) Token: 0x0600B21B RID: 45595 RVA: 0x00190307 File Offset: 0x0018E507
		public virtual float DirectionAngleLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DirectionAngleLimit;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DirectionAngleLimit;
			}
			set
			{
				this.GetOrCreatePoco().DirectionAngleLimit = value;
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600B21C RID: 45596 RVA: 0x00190315 File Offset: 0x0018E515
		// (set) Token: 0x0600B21D RID: 45597 RVA: 0x00190344 File Offset: 0x0018E544
		public virtual float EdgeLimitCurveFactor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EdgeLimitCurveFactor;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.EdgeLimitCurveFactor;
			}
			set
			{
				this.GetOrCreatePoco().EdgeLimitCurveFactor = value;
			}
		}

		// Token: 0x040069B5 RID: 27061
		[Nullable(2)]
		protected new ISlideTrackMove FbInstance;

		// Token: 0x040069B6 RID: 27062
		[Nullable(2)]
		protected new ISlideTrackMove_SetValue PocoInterface;
	}
}

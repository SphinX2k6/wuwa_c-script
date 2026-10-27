using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E8D RID: 7821
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlideTrackMove : ISplineMovePattern
	{
		// Token: 0x0600A750 RID: 42832 RVA: 0x0017A310 File Offset: 0x00178510
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

		// Token: 0x0600A751 RID: 42833 RVA: 0x0017A348 File Offset: 0x00178548
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

		// Token: 0x0600A752 RID: 42834 RVA: 0x0017A35B File Offset: 0x0017855B
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

		// Token: 0x0600A753 RID: 42835 RVA: 0x0017A370 File Offset: 0x00178570
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

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600A754 RID: 42836 RVA: 0x0017A3EE File Offset: 0x001785EE
		// (set) Token: 0x0600A755 RID: 42837 RVA: 0x0017A419 File Offset: 0x00178619
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

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600A756 RID: 42838 RVA: 0x0017A428 File Offset: 0x00178628
		// (set) Token: 0x0600A757 RID: 42839 RVA: 0x0017A462 File Offset: 0x00178662
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

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600A758 RID: 42840 RVA: 0x0017A470 File Offset: 0x00178670
		// (set) Token: 0x0600A759 RID: 42841 RVA: 0x0017A4AA File Offset: 0x001786AA
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

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600A75A RID: 42842 RVA: 0x0017A4B8 File Offset: 0x001786B8
		// (set) Token: 0x0600A75B RID: 42843 RVA: 0x0017A4F2 File Offset: 0x001786F2
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

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600A75C RID: 42844 RVA: 0x0017A500 File Offset: 0x00178700
		// (set) Token: 0x0600A75D RID: 42845 RVA: 0x0017A53A File Offset: 0x0017873A
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

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600A75E RID: 42846 RVA: 0x0017A548 File Offset: 0x00178748
		// (set) Token: 0x0600A75F RID: 42847 RVA: 0x0017A582 File Offset: 0x00178782
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

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600A760 RID: 42848 RVA: 0x0017A590 File Offset: 0x00178790
		// (set) Token: 0x0600A761 RID: 42849 RVA: 0x0017A5CA File Offset: 0x001787CA
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

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600A762 RID: 42850 RVA: 0x0017A5D8 File Offset: 0x001787D8
		// (set) Token: 0x0600A763 RID: 42851 RVA: 0x0017A607 File Offset: 0x00178807
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

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600A764 RID: 42852 RVA: 0x0017A615 File Offset: 0x00178815
		// (set) Token: 0x0600A765 RID: 42853 RVA: 0x0017A644 File Offset: 0x00178844
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

		// Token: 0x040063D1 RID: 25553
		[Nullable(2)]
		protected new ISlideTrackMove FbInstance;

		// Token: 0x040063D2 RID: 25554
		[Nullable(2)]
		protected new ISlideTrackMove_SetValue PocoInterface;
	}
}

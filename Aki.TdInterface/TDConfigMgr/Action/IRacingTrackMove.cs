using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D84 RID: 7556
	[NullableContext(1)]
	[Nullable(0)]
	public class IRacingTrackMove : ISplineMovePattern
	{
		// Token: 0x0600A1EF RID: 41455 RVA: 0x001708D0 File Offset: 0x0016EAD0
		private IRacingTrackMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRacingTrackMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRacingTrackMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRacingTrackMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x00170908 File Offset: 0x0016EB08
		public static IRacingTrackMove Create([Nullable(2)] IRacingTrackMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRacingTrackMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x0017091B File Offset: 0x0016EB1B
		public static IRacingTrackMove CreateFromSetValue([Nullable(2)] IRacingTrackMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRacingTrackMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x00170930 File Offset: 0x0016EB30
		public new IRacingTrackMove_SetValue ToSetValue()
		{
			return new IRacingTrackMove_SetValue
			{
				Type = this.Type,
				MaxOffsetDistance = this.MaxOffsetDistance,
				IsOneWay = this.IsOneWay,
				LayerVerticalLimit = this.LayerVerticalLimit,
				DynamicGravity = this.DynamicGravity,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity,
				AutoExitDistance = this.AutoExitDistance,
				DirectionAngleLimit = this.DirectionAngleLimit
			};
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600A1F3 RID: 41459 RVA: 0x001709A2 File Offset: 0x0016EBA2
		// (set) Token: 0x0600A1F4 RID: 41460 RVA: 0x001709CD File Offset: 0x0016EBCD
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

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600A1F5 RID: 41461 RVA: 0x001709DC File Offset: 0x0016EBDC
		// (set) Token: 0x0600A1F6 RID: 41462 RVA: 0x00170A16 File Offset: 0x0016EC16
		public override float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				IRacingTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600A1F7 RID: 41463 RVA: 0x00170A24 File Offset: 0x0016EC24
		// (set) Token: 0x0600A1F8 RID: 41464 RVA: 0x00170A5E File Offset: 0x0016EC5E
		public override bool? IsOneWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOneWay;
				}
				IRacingTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600A1F9 RID: 41465 RVA: 0x00170A6C File Offset: 0x0016EC6C
		// (set) Token: 0x0600A1FA RID: 41466 RVA: 0x00170AA6 File Offset: 0x0016ECA6
		public override float? LayerVerticalLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LayerVerticalLimit;
				}
				IRacingTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600A1FB RID: 41467 RVA: 0x00170AB4 File Offset: 0x0016ECB4
		// (set) Token: 0x0600A1FC RID: 41468 RVA: 0x00170AEE File Offset: 0x0016ECEE
		public override bool? DynamicGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicGravity;
				}
				IRacingTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600A1FD RID: 41469 RVA: 0x00170AFC File Offset: 0x0016ECFC
		// (set) Token: 0x0600A1FE RID: 41470 RVA: 0x00170B36 File Offset: 0x0016ED36
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				IRacingTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600A1FF RID: 41471 RVA: 0x00170B44 File Offset: 0x0016ED44
		// (set) Token: 0x0600A200 RID: 41472 RVA: 0x00170B7E File Offset: 0x0016ED7E
		public override int? AutoExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitDistance;
				}
				IRacingTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600A201 RID: 41473 RVA: 0x00170B8C File Offset: 0x0016ED8C
		// (set) Token: 0x0600A202 RID: 41474 RVA: 0x00170BBB File Offset: 0x0016EDBB
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

		// Token: 0x04006157 RID: 24919
		[Nullable(2)]
		protected new IRacingTrackMove FbInstance;

		// Token: 0x04006158 RID: 24920
		[Nullable(2)]
		protected new IRacingTrackMove_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F95 RID: 8085
	public class IRacingTrackMove : ISplineMovePattern
	{
		// Token: 0x0600ABDB RID: 43995 RVA: 0x00184CF4 File Offset: 0x00182EF4
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

		// Token: 0x0600ABDC RID: 43996 RVA: 0x00184D2C File Offset: 0x00182F2C
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

		// Token: 0x0600ABDD RID: 43997 RVA: 0x00184D3F File Offset: 0x00182F3F
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

		// Token: 0x0600ABDE RID: 43998 RVA: 0x00184D54 File Offset: 0x00182F54
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

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x0600ABDF RID: 43999 RVA: 0x00184DC6 File Offset: 0x00182FC6
		// (set) Token: 0x0600ABE0 RID: 44000 RVA: 0x00184DF1 File Offset: 0x00182FF1
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

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0600ABE1 RID: 44001 RVA: 0x00184E00 File Offset: 0x00183000
		// (set) Token: 0x0600ABE2 RID: 44002 RVA: 0x00184E3A File Offset: 0x0018303A
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

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0600ABE3 RID: 44003 RVA: 0x00184E48 File Offset: 0x00183048
		// (set) Token: 0x0600ABE4 RID: 44004 RVA: 0x00184E82 File Offset: 0x00183082
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

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x0600ABE5 RID: 44005 RVA: 0x00184E90 File Offset: 0x00183090
		// (set) Token: 0x0600ABE6 RID: 44006 RVA: 0x00184ECA File Offset: 0x001830CA
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

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0600ABE7 RID: 44007 RVA: 0x00184ED8 File Offset: 0x001830D8
		// (set) Token: 0x0600ABE8 RID: 44008 RVA: 0x00184F12 File Offset: 0x00183112
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

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600ABE9 RID: 44009 RVA: 0x00184F20 File Offset: 0x00183120
		// (set) Token: 0x0600ABEA RID: 44010 RVA: 0x00184F5A File Offset: 0x0018315A
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

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600ABEB RID: 44011 RVA: 0x00184F68 File Offset: 0x00183168
		// (set) Token: 0x0600ABEC RID: 44012 RVA: 0x00184FA2 File Offset: 0x001831A2
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

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0600ABED RID: 44013 RVA: 0x00184FB0 File Offset: 0x001831B0
		// (set) Token: 0x0600ABEE RID: 44014 RVA: 0x00184FDF File Offset: 0x001831DF
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

		// Token: 0x040066D3 RID: 26323
		[Nullable(2)]
		protected new IRacingTrackMove FbInstance;

		// Token: 0x040066D4 RID: 26324
		[Nullable(2)]
		protected new IRacingTrackMove_SetValue PocoInterface;
	}
}

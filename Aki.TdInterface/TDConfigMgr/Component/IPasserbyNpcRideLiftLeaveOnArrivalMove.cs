using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000653 RID: 1619
	public class IPasserbyNpcRideLiftLeaveOnArrivalMove : IPasserbyNpcLiftMoveBase
	{
		// Token: 0x06002204 RID: 8708 RVA: 0x0005E378 File Offset: 0x0005C578
		private IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcRideLiftLeaveOnArrivalMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue());
			}
			return result;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0005E3B0 File Offset: 0x0005C5B0
		public static IPasserbyNpcRideLiftLeaveOnArrivalMove Create([Nullable(2)] IPasserbyNpcRideLiftLeaveOnArrivalMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcRideLiftLeaveOnArrivalMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x0005E3C3 File Offset: 0x0005C5C3
		public static IPasserbyNpcRideLiftLeaveOnArrivalMove CreateFromSetValue([Nullable(2)] IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcRideLiftLeaveOnArrivalMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x0005E3D6 File Offset: 0x0005C5D6
		public new IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue ToSetValue()
		{
			return new IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue
			{
				Type = this.Type,
				LiftEntityId = this.LiftEntityId,
				ExitTiming = this.ExitTiming,
				FloorSplines = this.FloorSplines
			};
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002208 RID: 8712 RVA: 0x0005E40D File Offset: 0x0005C60D
		// (set) Token: 0x06002209 RID: 8713 RVA: 0x0005E438 File Offset: 0x0005C638
		public override EPasserbyNpcLiftMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x0005E446 File Offset: 0x0005C646
		// (set) Token: 0x0600220B RID: 8715 RVA: 0x0005E471 File Offset: 0x0005C671
		public virtual int LiftEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LiftEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LiftEntityId;
			}
			set
			{
				this.GetOrCreatePoco().LiftEntityId = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x0005E480 File Offset: 0x0005C680
		// (set) Token: 0x0600220D RID: 8717 RVA: 0x0005E4E1 File Offset: 0x0005C6E1
		public virtual IPasserbyNpcLiftStopExitTiming ExitTiming
		{
			get
			{
				if (this._ExitTimingInited)
				{
					return this._ExitTimingCache;
				}
				this._ExitTimingInited = true;
				if (this.FbInstance != null)
				{
					this._ExitTimingCache = IPasserbyNpcLiftStopExitTiming.Create(this.FbInstance.ExitTiming);
				}
				else
				{
					IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue pocoInterface = this.PocoInterface;
					this._ExitTimingCache = ((pocoInterface != null) ? pocoInterface.ExitTiming : null);
				}
				return this._ExitTimingCache;
			}
			set
			{
				this.GetOrCreatePoco().ExitTiming = value;
				this._ExitTimingInited = false;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x0005E4F8 File Offset: 0x0005C6F8
		// (set) Token: 0x0600220F RID: 8719 RVA: 0x0005E58B File Offset: 0x0005C78B
		public virtual List<IPasserbyNpcFloorSpline> FloorSplines
		{
			get
			{
				if (this._FloorSplinesInited)
				{
					return this._FloorSplinesCache;
				}
				this._FloorSplinesInited = true;
				if (this.FbInstance != null)
				{
					List<IPasserbyNpcFloorSpline> floorSplines = this.FbInstance.FloorSplines;
					if (floorSplines != null)
					{
						this._FloorSplinesCache = new List<IPasserbyNpcFloorSpline>(floorSplines.Count);
						for (int i = 0; i < floorSplines.Count; i++)
						{
							this._FloorSplinesCache.Add(IPasserbyNpcFloorSpline.Create(floorSplines[i]));
						}
					}
				}
				else
				{
					IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue pocoInterface = this.PocoInterface;
					this._FloorSplinesCache = ((pocoInterface != null) ? pocoInterface.FloorSplines : null);
				}
				return this._FloorSplinesCache;
			}
			set
			{
				this.GetOrCreatePoco().FloorSplines = value;
				this._FloorSplinesInited = false;
			}
		}

		// Token: 0x040017F3 RID: 6131
		[Nullable(2)]
		protected new IPasserbyNpcRideLiftLeaveOnArrivalMove FbInstance;

		// Token: 0x040017F4 RID: 6132
		[Nullable(2)]
		protected new IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue PocoInterface;

		// Token: 0x040017F5 RID: 6133
		private IPasserbyNpcLiftStopExitTiming _ExitTimingCache;

		// Token: 0x040017F6 RID: 6134
		private bool _ExitTimingInited;

		// Token: 0x040017F7 RID: 6135
		private List<IPasserbyNpcFloorSpline> _FloorSplinesCache;

		// Token: 0x040017F8 RID: 6136
		private bool _FloorSplinesInited;
	}
}

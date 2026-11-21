using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007A2 RID: 1954
	public class ISplineWayPointWithWeight : ISplineWayPoint
	{
		// Token: 0x060029B5 RID: 10677 RVA: 0x0006E334 File Offset: 0x0006C534
		private ISplineWayPointWithWeight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineWayPointWithWeight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineWayPointWithWeight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineWayPointWithWeight_SetValue());
			}
			return result;
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x0006E36C File Offset: 0x0006C56C
		public static ISplineWayPointWithWeight Create([Nullable(2)] ISplineWayPointWithWeight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineWayPointWithWeight
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x0006E37F File Offset: 0x0006C57F
		public static ISplineWayPointWithWeight CreateFromSetValue([Nullable(2)] ISplineWayPointWithWeight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineWayPointWithWeight
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x0006E392 File Offset: 0x0006C592
		public new ISplineWayPointWithWeight_SetValue ToSetValue()
		{
			return new ISplineWayPointWithWeight_SetValue
			{
				Spline = this.Spline,
				PointId = this.PointId,
				Weight = this.Weight
			};
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x0006E3BD File Offset: 0x0006C5BD
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x0006E3E8 File Offset: 0x0006C5E8
		public override int Spline
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Spline;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Spline;
			}
			set
			{
				this.GetOrCreatePoco().Spline = value;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x0006E3F6 File Offset: 0x0006C5F6
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x0006E421 File Offset: 0x0006C621
		public override int PointId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PointId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PointId;
			}
			set
			{
				this.GetOrCreatePoco().PointId = value;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x0006E42F File Offset: 0x0006C62F
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x0006E45A File Offset: 0x0006C65A
		public virtual int Weight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Weight;
			}
			set
			{
				this.GetOrCreatePoco().Weight = value;
			}
		}

		// Token: 0x04001C24 RID: 7204
		[Nullable(2)]
		protected new ISplineWayPointWithWeight FbInstance;

		// Token: 0x04001C25 RID: 7205
		[Nullable(2)]
		protected new ISplineWayPointWithWeight_SetValue PocoInterface;
	}
}

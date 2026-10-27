using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000701 RID: 1793
	[NullableContext(1)]
	[Nullable(0)]
	public class ISplineWayPointWithWeight : ISplineWayPoint
	{
		// Token: 0x06002695 RID: 9877 RVA: 0x000672C4 File Offset: 0x000654C4
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

		// Token: 0x06002696 RID: 9878 RVA: 0x000672FC File Offset: 0x000654FC
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

		// Token: 0x06002697 RID: 9879 RVA: 0x0006730F File Offset: 0x0006550F
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

		// Token: 0x06002698 RID: 9880 RVA: 0x00067322 File Offset: 0x00065522
		public new ISplineWayPointWithWeight_SetValue ToSetValue()
		{
			return new ISplineWayPointWithWeight_SetValue
			{
				Spline = this.Spline,
				PointId = this.PointId,
				Weight = this.Weight
			};
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x0006734D File Offset: 0x0006554D
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x00067378 File Offset: 0x00065578
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

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x00067386 File Offset: 0x00065586
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x000673B1 File Offset: 0x000655B1
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

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x000673BF File Offset: 0x000655BF
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x000673EA File Offset: 0x000655EA
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

		// Token: 0x04001A25 RID: 6693
		[Nullable(2)]
		protected new ISplineWayPointWithWeight FbInstance;

		// Token: 0x04001A26 RID: 6694
		[Nullable(2)]
		protected new ISplineWayPointWithWeight_SetValue PocoInterface;
	}
}

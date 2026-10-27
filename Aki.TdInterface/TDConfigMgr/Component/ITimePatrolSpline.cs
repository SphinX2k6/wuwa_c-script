using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200077B RID: 1915
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimePatrolSpline : ISplineType
	{
		// Token: 0x06002982 RID: 10626 RVA: 0x0006D7A4 File Offset: 0x0006B9A4
		private ITimePatrolSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimePatrolSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimePatrolSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimePatrolSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x0006D7DC File Offset: 0x0006B9DC
		public static ITimePatrolSpline Create([Nullable(2)] ITimePatrolSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimePatrolSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x0006D7EF File Offset: 0x0006B9EF
		public static ITimePatrolSpline CreateFromSetValue([Nullable(2)] ITimePatrolSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimePatrolSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x0006D802 File Offset: 0x0006BA02
		public new ITimePatrolSpline_SetValue ToSetValue()
		{
			return new ITimePatrolSpline_SetValue
			{
				Type = this.Type,
				Points = this.Points
			};
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x0006D821 File Offset: 0x0006BA21
		// (set) Token: 0x06002987 RID: 10631 RVA: 0x0006D84C File Offset: 0x0006BA4C
		public override ESplineType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x0006D85C File Offset: 0x0006BA5C
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x0006D8EF File Offset: 0x0006BAEF
		public virtual List<ITimePatrolSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				if (this.FbInstance != null)
				{
					List<ITimePatrolSplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<ITimePatrolSplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(ITimePatrolSplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					ITimePatrolSpline_SetValue pocoInterface = this.PocoInterface;
					this._PointsCache = ((pocoInterface != null) ? pocoInterface.Points : null);
				}
				return this._PointsCache;
			}
			set
			{
				this.GetOrCreatePoco().Points = value;
				this._PointsInited = false;
			}
		}

		// Token: 0x04001BD3 RID: 7123
		[Nullable(2)]
		protected new ITimePatrolSpline FbInstance;

		// Token: 0x04001BD4 RID: 7124
		[Nullable(2)]
		protected new ITimePatrolSpline_SetValue PocoInterface;

		// Token: 0x04001BD5 RID: 7125
		private List<ITimePatrolSplinePoint> _PointsCache;

		// Token: 0x04001BD6 RID: 7126
		private bool _PointsInited;
	}
}

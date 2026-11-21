using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200081C RID: 2076
	public class ITimePatrolSpline : ISplineType
	{
		// Token: 0x06002CA6 RID: 11430 RVA: 0x0007494C File Offset: 0x00072B4C
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

		// Token: 0x06002CA7 RID: 11431 RVA: 0x00074984 File Offset: 0x00072B84
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

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00074997 File Offset: 0x00072B97
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

		// Token: 0x06002CA9 RID: 11433 RVA: 0x000749AA File Offset: 0x00072BAA
		public new ITimePatrolSpline_SetValue ToSetValue()
		{
			return new ITimePatrolSpline_SetValue
			{
				Type = this.Type,
				Points = this.Points
			};
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x000749C9 File Offset: 0x00072BC9
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x000749F4 File Offset: 0x00072BF4
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x00074A04 File Offset: 0x00072C04
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x00074A97 File Offset: 0x00072C97
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

		// Token: 0x04001DD8 RID: 7640
		[Nullable(2)]
		protected new ITimePatrolSpline FbInstance;

		// Token: 0x04001DD9 RID: 7641
		[Nullable(2)]
		protected new ITimePatrolSpline_SetValue PocoInterface;

		// Token: 0x04001DDA RID: 7642
		private List<ITimePatrolSplinePoint> _PointsCache;

		// Token: 0x04001DDB RID: 7643
		private bool _PointsInited;
	}
}

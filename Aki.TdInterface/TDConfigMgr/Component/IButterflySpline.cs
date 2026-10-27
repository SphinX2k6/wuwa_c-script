using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200020D RID: 525
	[NullableContext(1)]
	[Nullable(0)]
	public class IButterflySpline : ISplineType
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x000275F8 File Offset: 0x000257F8
		private IButterflySpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IButterflySpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IButterflySpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IButterflySpline_SetValue());
			}
			return result;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00027630 File Offset: 0x00025830
		public static IButterflySpline Create([Nullable(2)] IButterflySpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IButterflySpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00027643 File Offset: 0x00025843
		public static IButterflySpline CreateFromSetValue([Nullable(2)] IButterflySpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IButterflySpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00027656 File Offset: 0x00025856
		public new IButterflySpline_SetValue ToSetValue()
		{
			return new IButterflySpline_SetValue
			{
				Type = this.Type,
				Points = this.Points
			};
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00027675 File Offset: 0x00025875
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x000276A0 File Offset: 0x000258A0
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

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x000276B0 File Offset: 0x000258B0
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00027743 File Offset: 0x00025943
		public virtual List<IButterflySplinePoint> Points
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
					List<IButterflySplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<IButterflySplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(IButterflySplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					IButterflySpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400094B RID: 2379
		[Nullable(2)]
		protected new IButterflySpline FbInstance;

		// Token: 0x0400094C RID: 2380
		[Nullable(2)]
		protected new IButterflySpline_SetValue PocoInterface;

		// Token: 0x0400094D RID: 2381
		private List<IButterflySplinePoint> _PointsCache;

		// Token: 0x0400094E RID: 2382
		private bool _PointsInited;
	}
}

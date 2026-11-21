using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000234 RID: 564
	public class IButterflySpline : ISplineType
	{
		// Token: 0x0600092E RID: 2350 RVA: 0x00028DB8 File Offset: 0x00026FB8
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

		// Token: 0x0600092F RID: 2351 RVA: 0x00028DF0 File Offset: 0x00026FF0
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

		// Token: 0x06000930 RID: 2352 RVA: 0x00028E03 File Offset: 0x00027003
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

		// Token: 0x06000931 RID: 2353 RVA: 0x00028E16 File Offset: 0x00027016
		public new IButterflySpline_SetValue ToSetValue()
		{
			return new IButterflySpline_SetValue
			{
				Type = this.Type,
				Points = this.Points
			};
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00028E35 File Offset: 0x00027035
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00028E60 File Offset: 0x00027060
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00028E70 File Offset: 0x00027070
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00028F03 File Offset: 0x00027103
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

		// Token: 0x040009D5 RID: 2517
		[Nullable(2)]
		protected new IButterflySpline FbInstance;

		// Token: 0x040009D6 RID: 2518
		[Nullable(2)]
		protected new IButterflySpline_SetValue PocoInterface;

		// Token: 0x040009D7 RID: 2519
		private List<IButterflySplinePoint> _PointsCache;

		// Token: 0x040009D8 RID: 2520
		private bool _PointsInited;
	}
}

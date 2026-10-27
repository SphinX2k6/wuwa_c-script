using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000744 RID: 1860
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwordRiderRailSpline : ISplineType
	{
		// Token: 0x0600281F RID: 10271 RVA: 0x0006A6EC File Offset: 0x000688EC
		private ISwordRiderRailSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwordRiderRailSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwordRiderRailSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwordRiderRailSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0006A724 File Offset: 0x00068924
		public static ISwordRiderRailSpline Create([Nullable(2)] ISwordRiderRailSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwordRiderRailSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0006A737 File Offset: 0x00068937
		public static ISwordRiderRailSpline CreateFromSetValue([Nullable(2)] ISwordRiderRailSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwordRiderRailSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0006A74A File Offset: 0x0006894A
		public new ISwordRiderRailSpline_SetValue ToSetValue()
		{
			return new ISwordRiderRailSpline_SetValue
			{
				Type = this.Type,
				WallType = this.WallType,
				PathEffect = this.PathEffect,
				Points = this.Points
			};
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x0006A781 File Offset: 0x00068981
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x0006A7AC File Offset: 0x000689AC
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

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x0006A7BA File Offset: 0x000689BA
		// (set) Token: 0x06002826 RID: 10278 RVA: 0x0006A7E5 File Offset: 0x000689E5
		public virtual ESwordRiderRailWall WallType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WallType;
				}
				if (this.PocoInterface == null)
				{
					return ESwordRiderRailWall.Inner;
				}
				return this.PocoInterface.WallType;
			}
			set
			{
				this.GetOrCreatePoco().WallType = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x0006A7F3 File Offset: 0x000689F3
		// (set) Token: 0x06002828 RID: 10280 RVA: 0x0006A81A File Offset: 0x00068A1A
		[Nullable(2)]
		public virtual string PathEffect
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PathEffect;
				}
				ISwordRiderRailSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PathEffect;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PathEffect = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x0006A828 File Offset: 0x00068A28
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x0006A8BB File Offset: 0x00068ABB
		public virtual List<ISwordRiderRailSplinePoint> Points
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
					List<ISwordRiderRailSplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<ISwordRiderRailSplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(ISwordRiderRailSplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					ISwordRiderRailSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001B05 RID: 6917
		[Nullable(2)]
		protected new ISwordRiderRailSpline FbInstance;

		// Token: 0x04001B06 RID: 6918
		[Nullable(2)]
		protected new ISwordRiderRailSpline_SetValue PocoInterface;

		// Token: 0x04001B07 RID: 6919
		private List<ISwordRiderRailSplinePoint> _PointsCache;

		// Token: 0x04001B08 RID: 6920
		private bool _PointsInited;
	}
}

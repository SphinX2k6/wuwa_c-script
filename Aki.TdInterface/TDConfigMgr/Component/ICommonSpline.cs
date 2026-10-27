using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000253 RID: 595
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonSpline : ISplineType
	{
		// Token: 0x06000ABE RID: 2750 RVA: 0x0002C148 File Offset: 0x0002A348
		private ICommonSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0002C180 File Offset: 0x0002A380
		public static ICommonSpline Create([Nullable(2)] ICommonSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0002C193 File Offset: 0x0002A393
		public static ICommonSpline CreateFromSetValue([Nullable(2)] ICommonSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0002C1A6 File Offset: 0x0002A3A6
		public new ICommonSpline_SetValue ToSetValue()
		{
			return new ICommonSpline_SetValue
			{
				Type = this.Type,
				Points = this.Points
			};
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0002C1C5 File Offset: 0x0002A3C5
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x0002C1F0 File Offset: 0x0002A3F0
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

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002C200 File Offset: 0x0002A400
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x0002C293 File Offset: 0x0002A493
		public virtual List<ICommonSplinePoint> Points
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
					List<ICommonSplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<ICommonSplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(ICommonSplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					ICommonSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000A92 RID: 2706
		[Nullable(2)]
		protected new ICommonSpline FbInstance;

		// Token: 0x04000A93 RID: 2707
		[Nullable(2)]
		protected new ICommonSpline_SetValue PocoInterface;

		// Token: 0x04000A94 RID: 2708
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04000A95 RID: 2709
		private bool _PointsInited;
	}
}

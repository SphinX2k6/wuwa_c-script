using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000662 RID: 1634
	[NullableContext(1)]
	[Nullable(0)]
	public class IRangeSpline : ISplineType
	{
		// Token: 0x060022F6 RID: 8950 RVA: 0x0005FDE4 File Offset: 0x0005DFE4
		private IRangeSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRangeSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRangeSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRangeSpline_SetValue());
			}
			return result;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x0005FE1C File Offset: 0x0005E01C
		public static IRangeSpline Create([Nullable(2)] IRangeSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0005FE2F File Offset: 0x0005E02F
		public static IRangeSpline CreateFromSetValue([Nullable(2)] IRangeSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRangeSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0005FE42 File Offset: 0x0005E042
		public new IRangeSpline_SetValue ToSetValue()
		{
			return new IRangeSpline_SetValue
			{
				Type = this.Type,
				Height = this.Height,
				Points = this.Points
			};
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x0005FE6D File Offset: 0x0005E06D
		// (set) Token: 0x060022FB RID: 8955 RVA: 0x0005FE98 File Offset: 0x0005E098
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

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x0005FEA6 File Offset: 0x0005E0A6
		// (set) Token: 0x060022FD RID: 8957 RVA: 0x0005FED5 File Offset: 0x0005E0D5
		public virtual float Height
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Height;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Height;
			}
			set
			{
				this.GetOrCreatePoco().Height = value;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x0005FEE4 File Offset: 0x0005E0E4
		// (set) Token: 0x060022FF RID: 8959 RVA: 0x0005FF77 File Offset: 0x0005E177
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
					IRangeSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400183F RID: 6207
		[Nullable(2)]
		protected new IRangeSpline FbInstance;

		// Token: 0x04001840 RID: 6208
		[Nullable(2)]
		protected new IRangeSpline_SetValue PocoInterface;

		// Token: 0x04001841 RID: 6209
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04001842 RID: 6210
		private bool _PointsInited;
	}
}

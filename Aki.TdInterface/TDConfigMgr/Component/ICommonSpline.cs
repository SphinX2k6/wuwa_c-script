using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000296 RID: 662
	public class ICommonSpline : ISplineType
	{
		// Token: 0x06000BD8 RID: 3032 RVA: 0x0002EE38 File Offset: 0x0002D038
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

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0002EE70 File Offset: 0x0002D070
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

		// Token: 0x06000BDA RID: 3034 RVA: 0x0002EE83 File Offset: 0x0002D083
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

		// Token: 0x06000BDB RID: 3035 RVA: 0x0002EE96 File Offset: 0x0002D096
		public new ICommonSpline_SetValue ToSetValue()
		{
			return new ICommonSpline_SetValue
			{
				Type = this.Type,
				Points = this.Points
			};
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0002EEB5 File Offset: 0x0002D0B5
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x0002EEE0 File Offset: 0x0002D0E0
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

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x0002EF83 File Offset: 0x0002D183
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

		// Token: 0x04000B73 RID: 2931
		[Nullable(2)]
		protected new ICommonSpline FbInstance;

		// Token: 0x04000B74 RID: 2932
		[Nullable(2)]
		protected new ICommonSpline_SetValue PocoInterface;

		// Token: 0x04000B75 RID: 2933
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04000B76 RID: 2934
		private bool _PointsInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006FF RID: 1791
	public class IRangeSpline : ISplineType
	{
		// Token: 0x060025FC RID: 9724 RVA: 0x00066AF8 File Offset: 0x00064CF8
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

		// Token: 0x060025FD RID: 9725 RVA: 0x00066B30 File Offset: 0x00064D30
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

		// Token: 0x060025FE RID: 9726 RVA: 0x00066B43 File Offset: 0x00064D43
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

		// Token: 0x060025FF RID: 9727 RVA: 0x00066B56 File Offset: 0x00064D56
		public new IRangeSpline_SetValue ToSetValue()
		{
			return new IRangeSpline_SetValue
			{
				Type = this.Type,
				Height = this.Height,
				Points = this.Points
			};
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x00066B81 File Offset: 0x00064D81
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x00066BAC File Offset: 0x00064DAC
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

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x00066BBA File Offset: 0x00064DBA
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x00066BE9 File Offset: 0x00064DE9
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x00066BF8 File Offset: 0x00064DF8
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x00066C8B File Offset: 0x00064E8B
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

		// Token: 0x04001A31 RID: 6705
		[Nullable(2)]
		protected new IRangeSpline FbInstance;

		// Token: 0x04001A32 RID: 6706
		[Nullable(2)]
		protected new IRangeSpline_SetValue PocoInterface;

		// Token: 0x04001A33 RID: 6707
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04001A34 RID: 6708
		private bool _PointsInited;
	}
}

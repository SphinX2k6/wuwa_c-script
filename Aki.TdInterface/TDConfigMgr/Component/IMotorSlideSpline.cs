using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000530 RID: 1328
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorSlideSpline : ISplineType
	{
		// Token: 0x06001B0E RID: 6926 RVA: 0x0004E6F4 File Offset: 0x0004C8F4
		private IMotorSlideSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorSlideSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorSlideSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorSlideSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0004E72C File Offset: 0x0004C92C
		public static IMotorSlideSpline Create([Nullable(2)] IMotorSlideSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSlideSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0004E73F File Offset: 0x0004C93F
		public static IMotorSlideSpline CreateFromSetValue([Nullable(2)] IMotorSlideSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorSlideSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0004E752 File Offset: 0x0004C952
		public new IMotorSlideSpline_SetValue ToSetValue()
		{
			return new IMotorSlideSpline_SetValue
			{
				Type = this.Type,
				RangeRadius = this.RangeRadius,
				Points = this.Points
			};
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0004E77D File Offset: 0x0004C97D
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0004E7A8 File Offset: 0x0004C9A8
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

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0004E7B6 File Offset: 0x0004C9B6
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0004E7E5 File Offset: 0x0004C9E5
		public virtual float RangeRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RangeRadius;
			}
			set
			{
				this.GetOrCreatePoco().RangeRadius = value;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0004E7F4 File Offset: 0x0004C9F4
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0004E887 File Offset: 0x0004CA87
		public virtual List<IMotorSlideSplinePoint> Points
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
					List<IMotorSlideSplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<IMotorSlideSplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(IMotorSlideSplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					IMotorSlideSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001384 RID: 4996
		[Nullable(2)]
		protected new IMotorSlideSpline FbInstance;

		// Token: 0x04001385 RID: 4997
		[Nullable(2)]
		protected new IMotorSlideSpline_SetValue PocoInterface;

		// Token: 0x04001386 RID: 4998
		private List<IMotorSlideSplinePoint> _PointsCache;

		// Token: 0x04001387 RID: 4999
		private bool _PointsInited;
	}
}

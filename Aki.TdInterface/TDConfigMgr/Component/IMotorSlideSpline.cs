using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000597 RID: 1431
	public class IMotorSlideSpline : ISplineType
	{
		// Token: 0x06001D0A RID: 7434 RVA: 0x000534B0 File Offset: 0x000516B0
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

		// Token: 0x06001D0B RID: 7435 RVA: 0x000534E8 File Offset: 0x000516E8
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

		// Token: 0x06001D0C RID: 7436 RVA: 0x000534FB File Offset: 0x000516FB
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

		// Token: 0x06001D0D RID: 7437 RVA: 0x0005350E File Offset: 0x0005170E
		public new IMotorSlideSpline_SetValue ToSetValue()
		{
			return new IMotorSlideSpline_SetValue
			{
				Type = this.Type,
				RangeRadius = this.RangeRadius,
				Points = this.Points
			};
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x00053539 File Offset: 0x00051739
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x00053564 File Offset: 0x00051764
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

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00053572 File Offset: 0x00051772
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x000535A1 File Offset: 0x000517A1
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

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x000535B0 File Offset: 0x000517B0
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00053643 File Offset: 0x00051843
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

		// Token: 0x040014EE RID: 5358
		[Nullable(2)]
		protected new IMotorSlideSpline FbInstance;

		// Token: 0x040014EF RID: 5359
		[Nullable(2)]
		protected new IMotorSlideSpline_SetValue PocoInterface;

		// Token: 0x040014F0 RID: 5360
		private List<IMotorSlideSplinePoint> _PointsCache;

		// Token: 0x040014F1 RID: 5361
		private bool _PointsInited;
	}
}

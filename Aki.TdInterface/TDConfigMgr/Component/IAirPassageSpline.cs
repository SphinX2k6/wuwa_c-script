using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001CE RID: 462
	public class IAirPassageSpline : ISplineType
	{
		// Token: 0x060006F0 RID: 1776 RVA: 0x00024934 File Offset: 0x00022B34
		private IAirPassageSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAirPassageSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAirPassageSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAirPassageSpline_SetValue());
			}
			return result;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0002496C File Offset: 0x00022B6C
		public static IAirPassageSpline Create([Nullable(2)] IAirPassageSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirPassageSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0002497F File Offset: 0x00022B7F
		public static IAirPassageSpline CreateFromSetValue([Nullable(2)] IAirPassageSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAirPassageSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00024994 File Offset: 0x00022B94
		public new IAirPassageSpline_SetValue ToSetValue()
		{
			return new IAirPassageSpline_SetValue
			{
				Type = this.Type,
				MiddleLineEffect = this.MiddleLineEffect,
				TailCircleEffect = this.TailCircleEffect,
				MiddleCircleEffect = this.MiddleCircleEffect,
				MiddleCircleOverlyingEffect = this.MiddleCircleOverlyingEffect,
				MiddleCircleSpace = this.MiddleCircleSpace,
				MiddleCircleRadius = this.MiddleCircleRadius,
				MovableRadius = this.MovableRadius,
				Resistance = this.Resistance,
				SpeedLimit = this.SpeedLimit,
				SprintSpeedLimit = this.SprintSpeedLimit,
				Points = this.Points
			};
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00024A36 File Offset: 0x00022C36
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00024A61 File Offset: 0x00022C61
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

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00024A6F File Offset: 0x00022C6F
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00024A9A File Offset: 0x00022C9A
		public virtual string MiddleLineEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MiddleLineEffect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MiddleLineEffect;
			}
			set
			{
				this.GetOrCreatePoco().MiddleLineEffect = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00024AA8 File Offset: 0x00022CA8
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00024AD3 File Offset: 0x00022CD3
		public virtual string TailCircleEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TailCircleEffect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TailCircleEffect;
			}
			set
			{
				this.GetOrCreatePoco().TailCircleEffect = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00024AE1 File Offset: 0x00022CE1
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x00024B0C File Offset: 0x00022D0C
		public virtual string MiddleCircleEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MiddleCircleEffect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MiddleCircleEffect;
			}
			set
			{
				this.GetOrCreatePoco().MiddleCircleEffect = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00024B1A File Offset: 0x00022D1A
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x00024B45 File Offset: 0x00022D45
		public virtual string MiddleCircleOverlyingEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MiddleCircleOverlyingEffect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MiddleCircleOverlyingEffect;
			}
			set
			{
				this.GetOrCreatePoco().MiddleCircleOverlyingEffect = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00024B53 File Offset: 0x00022D53
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x00024B82 File Offset: 0x00022D82
		public virtual float MiddleCircleSpace
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MiddleCircleSpace;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MiddleCircleSpace;
			}
			set
			{
				this.GetOrCreatePoco().MiddleCircleSpace = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00024B90 File Offset: 0x00022D90
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x00024BBF File Offset: 0x00022DBF
		public virtual float MiddleCircleRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MiddleCircleRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MiddleCircleRadius;
			}
			set
			{
				this.GetOrCreatePoco().MiddleCircleRadius = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00024BCD File Offset: 0x00022DCD
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x00024BFC File Offset: 0x00022DFC
		public virtual float MovableRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MovableRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MovableRadius;
			}
			set
			{
				this.GetOrCreatePoco().MovableRadius = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00024C0A File Offset: 0x00022E0A
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00024C39 File Offset: 0x00022E39
		public virtual float Resistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Resistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Resistance;
			}
			set
			{
				this.GetOrCreatePoco().Resistance = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00024C47 File Offset: 0x00022E47
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00024C76 File Offset: 0x00022E76
		public virtual float SpeedLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpeedLimit;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.SpeedLimit;
			}
			set
			{
				this.GetOrCreatePoco().SpeedLimit = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00024C84 File Offset: 0x00022E84
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00024CB3 File Offset: 0x00022EB3
		public virtual float SprintSpeedLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SprintSpeedLimit;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.SprintSpeedLimit;
			}
			set
			{
				this.GetOrCreatePoco().SprintSpeedLimit = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00024CC4 File Offset: 0x00022EC4
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00024D57 File Offset: 0x00022F57
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
					IAirPassageSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040008AD RID: 2221
		[Nullable(2)]
		protected new IAirPassageSpline FbInstance;

		// Token: 0x040008AE RID: 2222
		[Nullable(2)]
		protected new IAirPassageSpline_SetValue PocoInterface;

		// Token: 0x040008AF RID: 2223
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x040008B0 RID: 2224
		private bool _PointsInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001B7 RID: 439
	[NullableContext(1)]
	[Nullable(0)]
	public class IAirPassageSpline : ISplineType
	{
		// Token: 0x060006DA RID: 1754 RVA: 0x00023CD4 File Offset: 0x00021ED4
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

		// Token: 0x060006DB RID: 1755 RVA: 0x00023D0C File Offset: 0x00021F0C
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

		// Token: 0x060006DC RID: 1756 RVA: 0x00023D1F File Offset: 0x00021F1F
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

		// Token: 0x060006DD RID: 1757 RVA: 0x00023D34 File Offset: 0x00021F34
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

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00023DD6 File Offset: 0x00021FD6
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00023E01 File Offset: 0x00022001
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00023E0F File Offset: 0x0002200F
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00023E3A File Offset: 0x0002203A
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00023E48 File Offset: 0x00022048
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00023E73 File Offset: 0x00022073
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00023E81 File Offset: 0x00022081
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00023EAC File Offset: 0x000220AC
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

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00023EBA File Offset: 0x000220BA
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00023EE5 File Offset: 0x000220E5
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00023EF3 File Offset: 0x000220F3
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00023F22 File Offset: 0x00022122
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00023F30 File Offset: 0x00022130
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00023F5F File Offset: 0x0002215F
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

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00023F6D File Offset: 0x0002216D
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00023F9C File Offset: 0x0002219C
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

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00023FAA File Offset: 0x000221AA
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00023FD9 File Offset: 0x000221D9
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

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00023FE7 File Offset: 0x000221E7
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00024016 File Offset: 0x00022216
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

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00024024 File Offset: 0x00022224
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00024053 File Offset: 0x00022253
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

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00024064 File Offset: 0x00022264
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x000240F7 File Offset: 0x000222F7
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

		// Token: 0x04000854 RID: 2132
		[Nullable(2)]
		protected new IAirPassageSpline FbInstance;

		// Token: 0x04000855 RID: 2133
		[Nullable(2)]
		protected new IAirPassageSpline_SetValue PocoInterface;

		// Token: 0x04000856 RID: 2134
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04000857 RID: 2135
		private bool _PointsInited;
	}
}

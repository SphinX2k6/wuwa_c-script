using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005EA RID: 1514
	[NullableContext(1)]
	[Nullable(0)]
	public class IPatrolSpline : ISplineType
	{
		// Token: 0x06002010 RID: 8208 RVA: 0x000596F8 File Offset: 0x000578F8
		private IPatrolSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00059730 File Offset: 0x00057930
		public static IPatrolSpline Create([Nullable(2)] IPatrolSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00059743 File Offset: 0x00057943
		public static IPatrolSpline CreateFromSetValue([Nullable(2)] IPatrolSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00059758 File Offset: 0x00057958
		public new IPatrolSpline_SetValue ToSetValue()
		{
			return new IPatrolSpline_SetValue
			{
				Type = this.Type,
				CycleOption = this.CycleOption,
				IsNavigation = this.IsNavigation,
				TurnSpeed = this.TurnSpeed,
				IsFloating = this.IsFloating,
				Points = this.Points,
				PatrolRange = this.PatrolRange
			};
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x000597BE File Offset: 0x000579BE
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x000597E9 File Offset: 0x000579E9
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

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x000597F7 File Offset: 0x000579F7
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x0005981E File Offset: 0x00057A1E
		[Nullable(2)]
		public virtual ICycleModeType CycleOption
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CycleOption;
				}
				IPatrolSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CycleOption;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CycleOption = value;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x0005982C File Offset: 0x00057A2C
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x00059866 File Offset: 0x00057A66
		public virtual bool? IsNavigation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNavigation;
				}
				IPatrolSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNavigation;
			}
			set
			{
				this.GetOrCreatePoco().IsNavigation = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x00059874 File Offset: 0x00057A74
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x000598AE File Offset: 0x00057AAE
		public virtual float? TurnSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TurnSpeed;
				}
				IPatrolSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TurnSpeed;
			}
			set
			{
				this.GetOrCreatePoco().TurnSpeed = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x000598BC File Offset: 0x00057ABC
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x000598F6 File Offset: 0x00057AF6
		public virtual bool? IsFloating
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFloating;
				}
				IPatrolSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFloating;
			}
			set
			{
				this.GetOrCreatePoco().IsFloating = value;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x00059904 File Offset: 0x00057B04
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x00059997 File Offset: 0x00057B97
		public virtual List<IPatrolSplinePoint> Points
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
					List<IPatrolSplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<IPatrolSplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(IPatrolSplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					IPatrolSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x000599AC File Offset: 0x00057BAC
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x00059A0D File Offset: 0x00057C0D
		[Nullable(2)]
		public virtual IPatrolRange PatrolRange
		{
			[NullableContext(2)]
			get
			{
				if (this._PatrolRangeInited)
				{
					return this._PatrolRangeCache;
				}
				this._PatrolRangeInited = true;
				if (this.FbInstance != null)
				{
					this._PatrolRangeCache = IPatrolRange.Create(this.FbInstance.PatrolRange);
				}
				else
				{
					IPatrolSpline_SetValue pocoInterface = this.PocoInterface;
					this._PatrolRangeCache = ((pocoInterface != null) ? pocoInterface.PatrolRange : null);
				}
				return this._PatrolRangeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PatrolRange = value;
				this._PatrolRangeInited = false;
			}
		}

		// Token: 0x04001686 RID: 5766
		[Nullable(2)]
		protected new IPatrolSpline FbInstance;

		// Token: 0x04001687 RID: 5767
		[Nullable(2)]
		protected new IPatrolSpline_SetValue PocoInterface;

		// Token: 0x04001688 RID: 5768
		private List<IPatrolSplinePoint> _PointsCache;

		// Token: 0x04001689 RID: 5769
		private bool _PointsInited;

		// Token: 0x0400168A RID: 5770
		private IPatrolRange _PatrolRangeCache;

		// Token: 0x0400168B RID: 5771
		private bool _PatrolRangeInited;
	}
}

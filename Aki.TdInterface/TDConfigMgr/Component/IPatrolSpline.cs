using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000687 RID: 1671
	public class IPatrolSpline : ISplineType
	{
		// Token: 0x0600230E RID: 8974 RVA: 0x0006026C File Offset: 0x0005E46C
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

		// Token: 0x0600230F RID: 8975 RVA: 0x000602A4 File Offset: 0x0005E4A4
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

		// Token: 0x06002310 RID: 8976 RVA: 0x000602B7 File Offset: 0x0005E4B7
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

		// Token: 0x06002311 RID: 8977 RVA: 0x000602CC File Offset: 0x0005E4CC
		public new IPatrolSpline_SetValue ToSetValue()
		{
			return new IPatrolSpline_SetValue
			{
				Type = this.Type,
				CycleOption = this.CycleOption,
				IsNavigation = this.IsNavigation,
				TurnSpeed = this.TurnSpeed,
				IsFloating = this.IsFloating,
				PositionRefreshConfigs = this.PositionRefreshConfigs,
				Points = this.Points,
				PatrolRange = this.PatrolRange
			};
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x0006033E File Offset: 0x0005E53E
		// (set) Token: 0x06002313 RID: 8979 RVA: 0x00060369 File Offset: 0x0005E569
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

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x00060377 File Offset: 0x0005E577
		// (set) Token: 0x06002315 RID: 8981 RVA: 0x0006039E File Offset: 0x0005E59E
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

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x000603AC File Offset: 0x0005E5AC
		// (set) Token: 0x06002317 RID: 8983 RVA: 0x000603E6 File Offset: 0x0005E5E6
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

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x000603F4 File Offset: 0x0005E5F4
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x0006042E File Offset: 0x0005E62E
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

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x0006043C File Offset: 0x0005E63C
		// (set) Token: 0x0600231B RID: 8987 RVA: 0x00060476 File Offset: 0x0005E676
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

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x00060484 File Offset: 0x0005E684
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x00060517 File Offset: 0x0005E717
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IPatrolPositionRefreshConfig> PositionRefreshConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._PositionRefreshConfigsInited)
				{
					return this._PositionRefreshConfigsCache;
				}
				this._PositionRefreshConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IPatrolPositionRefreshConfig> positionRefreshConfigs = this.FbInstance.PositionRefreshConfigs;
					if (positionRefreshConfigs != null)
					{
						this._PositionRefreshConfigsCache = new List<IPatrolPositionRefreshConfig>(positionRefreshConfigs.Count);
						for (int i = 0; i < positionRefreshConfigs.Count; i++)
						{
							this._PositionRefreshConfigsCache.Add(IPatrolPositionRefreshConfig.Create(positionRefreshConfigs[i]));
						}
					}
				}
				else
				{
					IPatrolSpline_SetValue pocoInterface = this.PocoInterface;
					this._PositionRefreshConfigsCache = ((pocoInterface != null) ? pocoInterface.PositionRefreshConfigs : null);
				}
				return this._PositionRefreshConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().PositionRefreshConfigs = value;
				this._PositionRefreshConfigsInited = false;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x0006052C File Offset: 0x0005E72C
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x000605BF File Offset: 0x0005E7BF
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

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000605D4 File Offset: 0x0005E7D4
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x00060635 File Offset: 0x0005E835
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

		// Token: 0x04001872 RID: 6258
		[Nullable(2)]
		protected new IPatrolSpline FbInstance;

		// Token: 0x04001873 RID: 6259
		[Nullable(2)]
		protected new IPatrolSpline_SetValue PocoInterface;

		// Token: 0x04001874 RID: 6260
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPatrolPositionRefreshConfig> _PositionRefreshConfigsCache;

		// Token: 0x04001875 RID: 6261
		private bool _PositionRefreshConfigsInited;

		// Token: 0x04001876 RID: 6262
		private List<IPatrolSplinePoint> _PointsCache;

		// Token: 0x04001877 RID: 6263
		private bool _PointsInited;

		// Token: 0x04001878 RID: 6264
		private IPatrolRange _PatrolRangeCache;

		// Token: 0x04001879 RID: 6265
		private bool _PatrolRangeInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000281 RID: 641
	[NullableContext(1)]
	[Nullable(0)]
	public class IContinuesVariableSpeedMovementSpline : ISplineType
	{
		// Token: 0x06000BDB RID: 3035 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		private IContinuesVariableSpeedMovementSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IContinuesVariableSpeedMovementSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IContinuesVariableSpeedMovementSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IContinuesVariableSpeedMovementSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0002EDF0 File Offset: 0x0002CFF0
		public static IContinuesVariableSpeedMovementSpline Create([Nullable(2)] IContinuesVariableSpeedMovementSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IContinuesVariableSpeedMovementSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0002EE03 File Offset: 0x0002D003
		public static IContinuesVariableSpeedMovementSpline CreateFromSetValue([Nullable(2)] IContinuesVariableSpeedMovementSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IContinuesVariableSpeedMovementSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0002EE18 File Offset: 0x0002D018
		public new IContinuesVariableSpeedMovementSpline_SetValue ToSetValue()
		{
			return new IContinuesVariableSpeedMovementSpline_SetValue
			{
				Type = this.Type,
				TransitionSpeed = this.TransitionSpeed,
				EntireTimePathConfig = this.EntireTimePathConfig,
				CircleMode = this.CircleMode,
				Points = this.Points
			};
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0002EE66 File Offset: 0x0002D066
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0002EE91 File Offset: 0x0002D091
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

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0002EEA0 File Offset: 0x0002D0A0
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x0002EEDA File Offset: 0x0002D0DA
		public virtual int? TransitionSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionSpeed;
				}
				IContinuesVariableSpeedMovementSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionSpeed;
			}
			set
			{
				this.GetOrCreatePoco().TransitionSpeed = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0002EEE8 File Offset: 0x0002D0E8
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x0002EF49 File Offset: 0x0002D149
		[Nullable(2)]
		public virtual ITimePathConfig EntireTimePathConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._EntireTimePathConfigInited)
				{
					return this._EntireTimePathConfigCache;
				}
				this._EntireTimePathConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EntireTimePathConfigCache = ITimePathConfig.Create(this.FbInstance.EntireTimePathConfig);
				}
				else
				{
					IContinuesVariableSpeedMovementSpline_SetValue pocoInterface = this.PocoInterface;
					this._EntireTimePathConfigCache = ((pocoInterface != null) ? pocoInterface.EntireTimePathConfig : null);
				}
				return this._EntireTimePathConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EntireTimePathConfig = value;
				this._EntireTimePathConfigInited = false;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0002EF60 File Offset: 0x0002D160
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x0002EF9A File Offset: 0x0002D19A
		public virtual EMoveCircleMode? CircleMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CircleMode;
				}
				IContinuesVariableSpeedMovementSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CircleMode;
			}
			set
			{
				this.GetOrCreatePoco().CircleMode = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0002EFA8 File Offset: 0x0002D1A8
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x0002F03B File Offset: 0x0002D23B
		public virtual List<IContinuesVariableSpeedSplinePoint> Points
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
					List<IContinuesVariableSpeedSplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<IContinuesVariableSpeedSplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(IContinuesVariableSpeedSplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					IContinuesVariableSpeedMovementSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000B50 RID: 2896
		[Nullable(2)]
		protected new IContinuesVariableSpeedMovementSpline FbInstance;

		// Token: 0x04000B51 RID: 2897
		[Nullable(2)]
		protected new IContinuesVariableSpeedMovementSpline_SetValue PocoInterface;

		// Token: 0x04000B52 RID: 2898
		private ITimePathConfig _EntireTimePathConfigCache;

		// Token: 0x04000B53 RID: 2899
		private bool _EntireTimePathConfigInited;

		// Token: 0x04000B54 RID: 2900
		private List<IContinuesVariableSpeedSplinePoint> _PointsCache;

		// Token: 0x04000B55 RID: 2901
		private bool _PointsInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C4 RID: 708
	public class IContinuesVariableSpeedMovementSpline : ISplineType
	{
		// Token: 0x06000CF5 RID: 3317 RVA: 0x00031AA8 File Offset: 0x0002FCA8
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

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00031AE0 File Offset: 0x0002FCE0
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

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00031AF3 File Offset: 0x0002FCF3
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

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00031B08 File Offset: 0x0002FD08
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

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00031B56 File Offset: 0x0002FD56
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00031B81 File Offset: 0x0002FD81
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

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x00031B90 File Offset: 0x0002FD90
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00031BCA File Offset: 0x0002FDCA
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

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x00031BD8 File Offset: 0x0002FDD8
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00031C39 File Offset: 0x0002FE39
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

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00031C50 File Offset: 0x0002FE50
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00031C8A File Offset: 0x0002FE8A
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00031C98 File Offset: 0x0002FE98
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00031D2B File Offset: 0x0002FF2B
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

		// Token: 0x04000C31 RID: 3121
		[Nullable(2)]
		protected new IContinuesVariableSpeedMovementSpline FbInstance;

		// Token: 0x04000C32 RID: 3122
		[Nullable(2)]
		protected new IContinuesVariableSpeedMovementSpline_SetValue PocoInterface;

		// Token: 0x04000C33 RID: 3123
		private ITimePathConfig _EntireTimePathConfigCache;

		// Token: 0x04000C34 RID: 3124
		private bool _EntireTimePathConfigInited;

		// Token: 0x04000C35 RID: 3125
		private List<IContinuesVariableSpeedSplinePoint> _PointsCache;

		// Token: 0x04000C36 RID: 3126
		private bool _PointsInited;
	}
}

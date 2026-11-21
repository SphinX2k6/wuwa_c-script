using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E5 RID: 2021
	public class ISwordRiderRailSpline : ISplineType
	{
		// Token: 0x06002B43 RID: 11075 RVA: 0x00071894 File Offset: 0x0006FA94
		private ISwordRiderRailSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwordRiderRailSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwordRiderRailSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwordRiderRailSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000718CC File Offset: 0x0006FACC
		public static ISwordRiderRailSpline Create([Nullable(2)] ISwordRiderRailSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwordRiderRailSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000718DF File Offset: 0x0006FADF
		public static ISwordRiderRailSpline CreateFromSetValue([Nullable(2)] ISwordRiderRailSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwordRiderRailSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000718F2 File Offset: 0x0006FAF2
		public new ISwordRiderRailSpline_SetValue ToSetValue()
		{
			return new ISwordRiderRailSpline_SetValue
			{
				Type = this.Type,
				WallType = this.WallType,
				PathEffect = this.PathEffect,
				Points = this.Points
			};
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x00071929 File Offset: 0x0006FB29
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x00071954 File Offset: 0x0006FB54
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

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x00071962 File Offset: 0x0006FB62
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x0007198D File Offset: 0x0006FB8D
		public virtual ESwordRiderRailWall WallType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WallType;
				}
				if (this.PocoInterface == null)
				{
					return ESwordRiderRailWall.Inner;
				}
				return this.PocoInterface.WallType;
			}
			set
			{
				this.GetOrCreatePoco().WallType = value;
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x0007199B File Offset: 0x0006FB9B
		// (set) Token: 0x06002B4C RID: 11084 RVA: 0x000719C2 File Offset: 0x0006FBC2
		[Nullable(2)]
		public virtual string PathEffect
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PathEffect;
				}
				ISwordRiderRailSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PathEffect;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PathEffect = value;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x000719D0 File Offset: 0x0006FBD0
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x00071A63 File Offset: 0x0006FC63
		public virtual List<ISwordRiderRailSplinePoint> Points
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
					List<ISwordRiderRailSplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<ISwordRiderRailSplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(ISwordRiderRailSplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					ISwordRiderRailSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001D0A RID: 7434
		[Nullable(2)]
		protected new ISwordRiderRailSpline FbInstance;

		// Token: 0x04001D0B RID: 7435
		[Nullable(2)]
		protected new ISwordRiderRailSpline_SetValue PocoInterface;

		// Token: 0x04001D0C RID: 7436
		private List<ISwordRiderRailSplinePoint> _PointsCache;

		// Token: 0x04001D0D RID: 7437
		private bool _PointsInited;
	}
}

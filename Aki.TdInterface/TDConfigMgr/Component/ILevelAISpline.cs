using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000513 RID: 1299
	public class ILevelAISpline : ISplineType
	{
		// Token: 0x06001A04 RID: 6660 RVA: 0x0004CD3C File Offset: 0x0004AF3C
		private ILevelAISpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelAISpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelAISpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelAISpline_SetValue());
			}
			return result;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0004CD74 File Offset: 0x0004AF74
		public static ILevelAISpline Create([Nullable(2)] ILevelAISpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAISpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0004CD87 File Offset: 0x0004AF87
		public static ILevelAISpline CreateFromSetValue([Nullable(2)] ILevelAISpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelAISpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0004CD9C File Offset: 0x0004AF9C
		public new ILevelAISpline_SetValue ToSetValue()
		{
			return new ILevelAISpline_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				CycleOption = this.CycleOption,
				UsePathFinding = this.UsePathFinding,
				IsPassEveryKeyPoint = this.IsPassEveryKeyPoint,
				Points = this.Points
			};
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x0004CDF6 File Offset: 0x0004AFF6
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x0004CE21 File Offset: 0x0004B021
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

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x0004CE2F File Offset: 0x0004B02F
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x0004CE5A File Offset: 0x0004B05A
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x0004CE68 File Offset: 0x0004B068
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x0004CEC9 File Offset: 0x0004B0C9
		[Nullable(2)]
		public virtual ILevelAiCycleLooply CycleOption
		{
			[NullableContext(2)]
			get
			{
				if (this._CycleOptionInited)
				{
					return this._CycleOptionCache;
				}
				this._CycleOptionInited = true;
				if (this.FbInstance != null)
				{
					this._CycleOptionCache = ILevelAiCycleLooply.Create(this.FbInstance.CycleOption);
				}
				else
				{
					ILevelAISpline_SetValue pocoInterface = this.PocoInterface;
					this._CycleOptionCache = ((pocoInterface != null) ? pocoInterface.CycleOption : null);
				}
				return this._CycleOptionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CycleOption = value;
				this._CycleOptionInited = false;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0004CEE0 File Offset: 0x0004B0E0
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x0004CF1A File Offset: 0x0004B11A
		public virtual bool? UsePathFinding
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UsePathFinding;
				}
				ILevelAISpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UsePathFinding;
			}
			set
			{
				this.GetOrCreatePoco().UsePathFinding = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x0004CF28 File Offset: 0x0004B128
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x0004CF62 File Offset: 0x0004B162
		public virtual bool? IsPassEveryKeyPoint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPassEveryKeyPoint;
				}
				ILevelAISpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsPassEveryKeyPoint;
			}
			set
			{
				this.GetOrCreatePoco().IsPassEveryKeyPoint = value;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x0004CF70 File Offset: 0x0004B170
		// (set) Token: 0x06001A13 RID: 6675 RVA: 0x0004D003 File Offset: 0x0004B203
		public virtual List<ILevelAISplinePoint> Points
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
					List<ILevelAISplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<ILevelAISplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(ILevelAISplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					ILevelAISpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001339 RID: 4921
		[Nullable(2)]
		protected new ILevelAISpline FbInstance;

		// Token: 0x0400133A RID: 4922
		[Nullable(2)]
		protected new ILevelAISpline_SetValue PocoInterface;

		// Token: 0x0400133B RID: 4923
		private ILevelAiCycleLooply _CycleOptionCache;

		// Token: 0x0400133C RID: 4924
		private bool _CycleOptionInited;

		// Token: 0x0400133D RID: 4925
		private List<ILevelAISplinePoint> _PointsCache;

		// Token: 0x0400133E RID: 4926
		private bool _PointsInited;
	}
}

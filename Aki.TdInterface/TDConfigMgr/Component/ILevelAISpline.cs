using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004BA RID: 1210
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelAISpline : ISplineType
	{
		// Token: 0x0600186A RID: 6250 RVA: 0x00048FF4 File Offset: 0x000471F4
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

		// Token: 0x0600186B RID: 6251 RVA: 0x0004902C File Offset: 0x0004722C
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

		// Token: 0x0600186C RID: 6252 RVA: 0x0004903F File Offset: 0x0004723F
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

		// Token: 0x0600186D RID: 6253 RVA: 0x00049054 File Offset: 0x00047254
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

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x000490AE File Offset: 0x000472AE
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x000490D9 File Offset: 0x000472D9
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

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x000490E7 File Offset: 0x000472E7
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x00049112 File Offset: 0x00047312
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00049120 File Offset: 0x00047320
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x00049181 File Offset: 0x00047381
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

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00049198 File Offset: 0x00047398
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x000491D2 File Offset: 0x000473D2
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

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x000491E0 File Offset: 0x000473E0
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x0004921A File Offset: 0x0004741A
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

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x00049228 File Offset: 0x00047428
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x000492BB File Offset: 0x000474BB
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

		// Token: 0x04001217 RID: 4631
		[Nullable(2)]
		protected new ILevelAISpline FbInstance;

		// Token: 0x04001218 RID: 4632
		[Nullable(2)]
		protected new ILevelAISpline_SetValue PocoInterface;

		// Token: 0x04001219 RID: 4633
		private ILevelAiCycleLooply _CycleOptionCache;

		// Token: 0x0400121A RID: 4634
		private bool _CycleOptionInited;

		// Token: 0x0400121B RID: 4635
		private List<ILevelAISplinePoint> _PointsCache;

		// Token: 0x0400121C RID: 4636
		private bool _PointsInited;
	}
}

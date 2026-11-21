using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000625 RID: 1573
	public class IParkourSpline : ISplineType
	{
		// Token: 0x06002100 RID: 8448 RVA: 0x0005C2B4 File Offset: 0x0005A4B4
		private IParkourSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IParkourSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IParkourSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IParkourSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x0005C2EC File Offset: 0x0005A4EC
		public static IParkourSpline Create([Nullable(2)] IParkourSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IParkourSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x0005C2FF File Offset: 0x0005A4FF
		public static IParkourSpline CreateFromSetValue([Nullable(2)] IParkourSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IParkourSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0005C314 File Offset: 0x0005A514
		public new IParkourSpline_SetValue ToSetValue()
		{
			return new IParkourSpline_SetValue
			{
				Type = this.Type,
				IsRequireToEnd = this.IsRequireToEnd,
				CheckPointsRequire = this.CheckPointsRequire,
				CheckPointResource = this.CheckPointResource,
				CheckPointsDestroyRes = this.CheckPointsDestroyRes,
				StartResource = this.StartResource,
				EndResource = this.EndResource,
				Points = this.Points
			};
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x0005C386 File Offset: 0x0005A586
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x0005C3B1 File Offset: 0x0005A5B1
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

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x0005C3BF File Offset: 0x0005A5BF
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x0005C3EA File Offset: 0x0005A5EA
		public virtual bool IsRequireToEnd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRequireToEnd;
				}
				return this.PocoInterface != null && this.PocoInterface.IsRequireToEnd;
			}
			set
			{
				this.GetOrCreatePoco().IsRequireToEnd = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x0005C3F8 File Offset: 0x0005A5F8
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x0005C423 File Offset: 0x0005A623
		public virtual int CheckPointsRequire
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CheckPointsRequire;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CheckPointsRequire;
			}
			set
			{
				this.GetOrCreatePoco().CheckPointsRequire = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x0005C431 File Offset: 0x0005A631
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x0005C45C File Offset: 0x0005A65C
		public virtual string CheckPointResource
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CheckPointResource;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CheckPointResource;
			}
			set
			{
				this.GetOrCreatePoco().CheckPointResource = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x0005C46A File Offset: 0x0005A66A
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x0005C491 File Offset: 0x0005A691
		[Nullable(2)]
		public virtual string CheckPointsDestroyRes
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CheckPointsDestroyRes;
				}
				IParkourSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CheckPointsDestroyRes;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CheckPointsDestroyRes = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x0005C49F File Offset: 0x0005A69F
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x0005C4C6 File Offset: 0x0005A6C6
		[Nullable(2)]
		public virtual string StartResource
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartResource;
				}
				IParkourSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartResource;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().StartResource = value;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x0005C4D4 File Offset: 0x0005A6D4
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x0005C4FB File Offset: 0x0005A6FB
		[Nullable(2)]
		public virtual string EndResource
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndResource;
				}
				IParkourSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndResource;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EndResource = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x0005C50C File Offset: 0x0005A70C
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x0005C59F File Offset: 0x0005A79F
		public virtual List<IParkourSplinePoint> Points
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
					List<IParkourSplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<IParkourSplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(IParkourSplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					IParkourSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001764 RID: 5988
		[Nullable(2)]
		protected new IParkourSpline FbInstance;

		// Token: 0x04001765 RID: 5989
		[Nullable(2)]
		protected new IParkourSpline_SetValue PocoInterface;

		// Token: 0x04001766 RID: 5990
		private List<IParkourSplinePoint> _PointsCache;

		// Token: 0x04001767 RID: 5991
		private bool _PointsInited;
	}
}

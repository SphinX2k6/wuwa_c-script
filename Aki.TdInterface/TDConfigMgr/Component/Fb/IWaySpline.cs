using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C62 RID: 3170
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaySpline : ISplineType
	{
		// Token: 0x06004898 RID: 18584 RVA: 0x000B6460 File Offset: 0x000B4660
		[NullableContext(1)]
		public static IWaySpline Create(IWaySpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaySpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x000B647F File Offset: 0x000B467F
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x0600489A RID: 18586 RVA: 0x000B648C File Offset: 0x000B468C
		public virtual int RoadZoneId
		{
			get
			{
				return this.Instance.RoadZoneId;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x000B6499 File Offset: 0x000B4699
		public virtual string PcgRoadPathName
		{
			get
			{
				return this.Instance.PcgRoadPathName;
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x000B64A8 File Offset: 0x000B46A8
		public virtual bool? NoEntry
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.NoEntry);
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x000B64DE File Offset: 0x000B46DE
		public virtual IPavedWayConfig PavedWayConfig
		{
			get
			{
				if (this._PavedWayConfigInited)
				{
					return this._PavedWayConfigCache;
				}
				this._PavedWayConfigInited = true;
				this._PavedWayConfigCache = IPavedWayConfig.Create(this.Instance.PavedWayConfig);
				return this._PavedWayConfigCache;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x000B6514 File Offset: 0x000B4714
		[Nullable(1)]
		public virtual List<IWaySplinePoint> Points
		{
			[NullableContext(1)]
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<IWaySplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(IWaySplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x0600489F RID: 18591 RVA: 0x000B6580 File Offset: 0x000B4780
		public virtual List<int> Last
		{
			get
			{
				if (this._LastInited)
				{
					return this._LastCache;
				}
				this._LastInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int lastLength = this.Instance.LastLength;
				this._LastCache = new List<int>(lastLength);
				for (int i = 0; i < lastLength; i++)
				{
					this._LastCache.Add(this.Instance.Last(i));
				}
				return this._LastCache;
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x060048A0 RID: 18592 RVA: 0x000B65F8 File Offset: 0x000B47F8
		public virtual List<int> Next
		{
			get
			{
				if (this._NextInited)
				{
					return this._NextCache;
				}
				this._NextInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int nextLength = this.Instance.NextLength;
				this._NextCache = new List<int>(nextLength);
				for (int i = 0; i < nextLength; i++)
				{
					this._NextCache.Add(this.Instance.Next(i));
				}
				return this._NextCache;
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x000B6670 File Offset: 0x000B4870
		public virtual int? Opposite
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Opposite);
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x000B66A6 File Offset: 0x000B48A6
		public virtual float Width
		{
			get
			{
				return this.Instance.Width;
			}
		}

		// Token: 0x0400295F RID: 10591
		private IWaySpline Instance;

		// Token: 0x04002960 RID: 10592
		private IPavedWayConfig _PavedWayConfigCache;

		// Token: 0x04002961 RID: 10593
		private bool _PavedWayConfigInited;

		// Token: 0x04002962 RID: 10594
		[Nullable(1)]
		private List<IWaySplinePoint> _PointsCache;

		// Token: 0x04002963 RID: 10595
		private bool _PointsInited;

		// Token: 0x04002964 RID: 10596
		private List<int> _LastCache;

		// Token: 0x04002965 RID: 10597
		private bool _LastInited;

		// Token: 0x04002966 RID: 10598
		private List<int> _NextCache;

		// Token: 0x04002967 RID: 10599
		private bool _NextInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D3B RID: 3387
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaySpline : ISplineType
	{
		// Token: 0x06004D1D RID: 19741 RVA: 0x000C0A54 File Offset: 0x000BEC54
		[NullableContext(0)]
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

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06004D1E RID: 19742 RVA: 0x000C0A73 File Offset: 0x000BEC73
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06004D1F RID: 19743 RVA: 0x000C0A80 File Offset: 0x000BEC80
		public virtual int RoadZoneId
		{
			get
			{
				return this.Instance.RoadZoneId;
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06004D20 RID: 19744 RVA: 0x000C0A8D File Offset: 0x000BEC8D
		public virtual string PcgRoadPathName
		{
			get
			{
				return this.Instance.PcgRoadPathName;
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x000C0A9C File Offset: 0x000BEC9C
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

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06004D22 RID: 19746 RVA: 0x000C0AD2 File Offset: 0x000BECD2
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

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06004D23 RID: 19747 RVA: 0x000C0B08 File Offset: 0x000BED08
		[Nullable(0)]
		public virtual List<IWaySplinePoint> Points
		{
			[NullableContext(0)]
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

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06004D24 RID: 19748 RVA: 0x000C0B74 File Offset: 0x000BED74
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

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06004D25 RID: 19749 RVA: 0x000C0BEC File Offset: 0x000BEDEC
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

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06004D26 RID: 19750 RVA: 0x000C0C64 File Offset: 0x000BEE64
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

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06004D27 RID: 19751 RVA: 0x000C0C9A File Offset: 0x000BEE9A
		public virtual float Width
		{
			get
			{
				return this.Instance.Width;
			}
		}

		// Token: 0x04002BC0 RID: 11200
		private IWaySpline Instance;

		// Token: 0x04002BC1 RID: 11201
		private IPavedWayConfig _PavedWayConfigCache;

		// Token: 0x04002BC2 RID: 11202
		private bool _PavedWayConfigInited;

		// Token: 0x04002BC3 RID: 11203
		[Nullable(0)]
		private List<IWaySplinePoint> _PointsCache;

		// Token: 0x04002BC4 RID: 11204
		private bool _PointsInited;

		// Token: 0x04002BC5 RID: 11205
		private List<int> _LastCache;

		// Token: 0x04002BC6 RID: 11206
		private bool _LastInited;

		// Token: 0x04002BC7 RID: 11207
		private List<int> _NextCache;

		// Token: 0x04002BC8 RID: 11208
		private bool _NextInited;
	}
}

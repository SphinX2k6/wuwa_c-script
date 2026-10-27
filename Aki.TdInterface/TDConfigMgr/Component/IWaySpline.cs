using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D1 RID: 2001
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaySpline : ISplineType
	{
		// Token: 0x06002B61 RID: 11105 RVA: 0x00071288 File Offset: 0x0006F488
		[NullableContext(1)]
		private IWaySpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaySpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaySpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaySpline_SetValue());
			}
			return result;
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000712C0 File Offset: 0x0006F4C0
		[NullableContext(1)]
		public static IWaySpline Create([Nullable(2)] IWaySpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaySpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000712D3 File Offset: 0x0006F4D3
		[NullableContext(1)]
		public static IWaySpline CreateFromSetValue([Nullable(2)] IWaySpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaySpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000712E8 File Offset: 0x0006F4E8
		[NullableContext(1)]
		public new IWaySpline_SetValue ToSetValue()
		{
			return new IWaySpline_SetValue
			{
				Type = this.Type,
				RoadZoneId = this.RoadZoneId,
				PcgRoadPathName = this.PcgRoadPathName,
				NoEntry = this.NoEntry,
				PavedWayConfig = this.PavedWayConfig,
				Points = this.Points,
				Last = this.Last,
				Next = this.Next,
				Opposite = this.Opposite,
				Width = this.Width
			};
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x00071372 File Offset: 0x0006F572
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x0007139D File Offset: 0x0006F59D
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

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x000713AB File Offset: 0x0006F5AB
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x000713D6 File Offset: 0x0006F5D6
		public virtual int RoadZoneId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RoadZoneId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RoadZoneId;
			}
			set
			{
				this.GetOrCreatePoco().RoadZoneId = value;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000713E4 File Offset: 0x0006F5E4
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x0007140B File Offset: 0x0006F60B
		public virtual string PcgRoadPathName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PcgRoadPathName;
				}
				IWaySpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PcgRoadPathName;
			}
			set
			{
				this.GetOrCreatePoco().PcgRoadPathName = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x0007141C File Offset: 0x0006F61C
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x00071456 File Offset: 0x0006F656
		public virtual bool? NoEntry
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NoEntry;
				}
				IWaySpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NoEntry;
			}
			set
			{
				this.GetOrCreatePoco().NoEntry = value;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x00071464 File Offset: 0x0006F664
		// (set) Token: 0x06002B6E RID: 11118 RVA: 0x000714C5 File Offset: 0x0006F6C5
		public virtual IPavedWayConfig PavedWayConfig
		{
			get
			{
				if (this._PavedWayConfigInited)
				{
					return this._PavedWayConfigCache;
				}
				this._PavedWayConfigInited = true;
				if (this.FbInstance != null)
				{
					this._PavedWayConfigCache = IPavedWayConfig.Create(this.FbInstance.PavedWayConfig);
				}
				else
				{
					IWaySpline_SetValue pocoInterface = this.PocoInterface;
					this._PavedWayConfigCache = ((pocoInterface != null) ? pocoInterface.PavedWayConfig : null);
				}
				return this._PavedWayConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().PavedWayConfig = value;
				this._PavedWayConfigInited = false;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x000714DC File Offset: 0x0006F6DC
		// (set) Token: 0x06002B70 RID: 11120 RVA: 0x0007156F File Offset: 0x0006F76F
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
				if (this.FbInstance != null)
				{
					List<IWaySplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<IWaySplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(IWaySplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					IWaySpline_SetValue pocoInterface = this.PocoInterface;
					this._PointsCache = ((pocoInterface != null) ? pocoInterface.Points : null);
				}
				return this._PointsCache;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().Points = value;
				this._PointsInited = false;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x00071584 File Offset: 0x0006F784
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x000715AB File Offset: 0x0006F7AB
		public virtual List<int> Last
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Last;
				}
				IWaySpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Last;
			}
			set
			{
				this.GetOrCreatePoco().Last = value;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x000715B9 File Offset: 0x0006F7B9
		// (set) Token: 0x06002B74 RID: 11124 RVA: 0x000715E0 File Offset: 0x0006F7E0
		public virtual List<int> Next
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Next;
				}
				IWaySpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Next;
			}
			set
			{
				this.GetOrCreatePoco().Next = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x000715F0 File Offset: 0x0006F7F0
		// (set) Token: 0x06002B76 RID: 11126 RVA: 0x0007162A File Offset: 0x0006F82A
		public virtual int? Opposite
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Opposite;
				}
				IWaySpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Opposite;
			}
			set
			{
				this.GetOrCreatePoco().Opposite = value;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x00071638 File Offset: 0x0006F838
		// (set) Token: 0x06002B78 RID: 11128 RVA: 0x00071667 File Offset: 0x0006F867
		public virtual float Width
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Width;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Width;
			}
			set
			{
				this.GetOrCreatePoco().Width = value;
			}
		}

		// Token: 0x04001CCC RID: 7372
		protected new IWaySpline FbInstance;

		// Token: 0x04001CCD RID: 7373
		protected new IWaySpline_SetValue PocoInterface;

		// Token: 0x04001CCE RID: 7374
		[Nullable(1)]
		private IPavedWayConfig _PavedWayConfigCache;

		// Token: 0x04001CCF RID: 7375
		private bool _PavedWayConfigInited;

		// Token: 0x04001CD0 RID: 7376
		[Nullable(1)]
		private List<IWaySplinePoint> _PointsCache;

		// Token: 0x04001CD1 RID: 7377
		private bool _PointsInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000874 RID: 2164
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaySpline : ISplineType
	{
		// Token: 0x06002E91 RID: 11921 RVA: 0x000785EC File Offset: 0x000767EC
		[NullableContext(0)]
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

		// Token: 0x06002E92 RID: 11922 RVA: 0x00078624 File Offset: 0x00076824
		[NullableContext(0)]
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

		// Token: 0x06002E93 RID: 11923 RVA: 0x00078637 File Offset: 0x00076837
		[NullableContext(0)]
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

		// Token: 0x06002E94 RID: 11924 RVA: 0x0007864C File Offset: 0x0007684C
		[NullableContext(0)]
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

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x000786D6 File Offset: 0x000768D6
		// (set) Token: 0x06002E96 RID: 11926 RVA: 0x00078701 File Offset: 0x00076901
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

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x0007870F File Offset: 0x0007690F
		// (set) Token: 0x06002E98 RID: 11928 RVA: 0x0007873A File Offset: 0x0007693A
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

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x00078748 File Offset: 0x00076948
		// (set) Token: 0x06002E9A RID: 11930 RVA: 0x0007876F File Offset: 0x0007696F
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

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x00078780 File Offset: 0x00076980
		// (set) Token: 0x06002E9C RID: 11932 RVA: 0x000787BA File Offset: 0x000769BA
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

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x000787C8 File Offset: 0x000769C8
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x00078829 File Offset: 0x00076A29
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

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x00078840 File Offset: 0x00076A40
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x000788D3 File Offset: 0x00076AD3
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().Points = value;
				this._PointsInited = false;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x000788E8 File Offset: 0x00076AE8
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x0007890F File Offset: 0x00076B0F
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

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x0007891D File Offset: 0x00076B1D
		// (set) Token: 0x06002EA4 RID: 11940 RVA: 0x00078944 File Offset: 0x00076B44
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

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x00078954 File Offset: 0x00076B54
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x0007898E File Offset: 0x00076B8E
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

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x0007899C File Offset: 0x00076B9C
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x000789CB File Offset: 0x00076BCB
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

		// Token: 0x04001ED8 RID: 7896
		protected new IWaySpline FbInstance;

		// Token: 0x04001ED9 RID: 7897
		protected new IWaySpline_SetValue PocoInterface;

		// Token: 0x04001EDA RID: 7898
		[Nullable(0)]
		private IPavedWayConfig _PavedWayConfigCache;

		// Token: 0x04001EDB RID: 7899
		private bool _PavedWayConfigInited;

		// Token: 0x04001EDC RID: 7900
		[Nullable(0)]
		private List<IWaySplinePoint> _PointsCache;

		// Token: 0x04001EDD RID: 7901
		private bool _PointsInited;
	}
}

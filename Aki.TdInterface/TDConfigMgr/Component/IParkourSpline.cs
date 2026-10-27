using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005BA RID: 1466
	[NullableContext(1)]
	[Nullable(0)]
	public class IParkourSpline : ISplineType
	{
		// Token: 0x06001EF0 RID: 7920 RVA: 0x00057288 File Offset: 0x00055488
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

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000572C0 File Offset: 0x000554C0
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

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000572D3 File Offset: 0x000554D3
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

		// Token: 0x06001EF3 RID: 7923 RVA: 0x000572E8 File Offset: 0x000554E8
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

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0005735A File Offset: 0x0005555A
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x00057385 File Offset: 0x00055585
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

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00057393 File Offset: 0x00055593
		// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x000573BE File Offset: 0x000555BE
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

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x000573CC File Offset: 0x000555CC
		// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x000573F7 File Offset: 0x000555F7
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

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00057405 File Offset: 0x00055605
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x00057430 File Offset: 0x00055630
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

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x0005743E File Offset: 0x0005563E
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x00057465 File Offset: 0x00055665
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

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00057473 File Offset: 0x00055673
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x0005749A File Offset: 0x0005569A
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

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x000574A8 File Offset: 0x000556A8
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x000574CF File Offset: 0x000556CF
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

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x000574E0 File Offset: 0x000556E0
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x00057573 File Offset: 0x00055773
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

		// Token: 0x040015F0 RID: 5616
		[Nullable(2)]
		protected new IParkourSpline FbInstance;

		// Token: 0x040015F1 RID: 5617
		[Nullable(2)]
		protected new IParkourSpline_SetValue PocoInterface;

		// Token: 0x040015F2 RID: 5618
		private List<IParkourSplinePoint> _PointsCache;

		// Token: 0x040015F3 RID: 5619
		private bool _PointsInited;
	}
}

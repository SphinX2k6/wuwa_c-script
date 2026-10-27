using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C3F RID: 3135
	[NullableContext(1)]
	[Nullable(0)]
	public class IParkourSpline : ISplineType
	{
		// Token: 0x060047C5 RID: 18373 RVA: 0x000B4AAF File Offset: 0x000B2CAF
		public static IParkourSpline Create(IParkourSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IParkourSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060047C6 RID: 18374 RVA: 0x000B4ACE File Offset: 0x000B2CCE
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x000B4ADB File Offset: 0x000B2CDB
		public virtual bool IsRequireToEnd
		{
			get
			{
				return this.Instance.IsRequireToEnd;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x000B4AE8 File Offset: 0x000B2CE8
		public virtual int CheckPointsRequire
		{
			get
			{
				return this.Instance.CheckPointsRequire;
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x060047C9 RID: 18377 RVA: 0x000B4AF5 File Offset: 0x000B2CF5
		public virtual string CheckPointResource
		{
			get
			{
				return this.Instance.CheckPointResource;
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x000B4B02 File Offset: 0x000B2D02
		[Nullable(2)]
		public virtual string CheckPointsDestroyRes
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.CheckPointsDestroyRes;
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x000B4B0F File Offset: 0x000B2D0F
		[Nullable(2)]
		public virtual string StartResource
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.StartResource;
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x000B4B1C File Offset: 0x000B2D1C
		[Nullable(2)]
		public virtual string EndResource
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.EndResource;
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x000B4B2C File Offset: 0x000B2D2C
		public virtual List<IParkourSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<IParkourSplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(IParkourSplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x040028D8 RID: 10456
		private IParkourSpline Instance;

		// Token: 0x040028D9 RID: 10457
		private List<IParkourSplinePoint> _PointsCache;

		// Token: 0x040028DA RID: 10458
		private bool _PointsInited;
	}
}

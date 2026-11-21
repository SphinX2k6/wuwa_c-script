using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D12 RID: 3346
	public class IParkourSpline : ISplineType
	{
		// Token: 0x06004C35 RID: 19509 RVA: 0x000BEE5F File Offset: 0x000BD05F
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

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06004C36 RID: 19510 RVA: 0x000BEE7E File Offset: 0x000BD07E
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06004C37 RID: 19511 RVA: 0x000BEE8B File Offset: 0x000BD08B
		public virtual bool IsRequireToEnd
		{
			get
			{
				return this.Instance.IsRequireToEnd;
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06004C38 RID: 19512 RVA: 0x000BEE98 File Offset: 0x000BD098
		public virtual int CheckPointsRequire
		{
			get
			{
				return this.Instance.CheckPointsRequire;
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06004C39 RID: 19513 RVA: 0x000BEEA5 File Offset: 0x000BD0A5
		public virtual string CheckPointResource
		{
			get
			{
				return this.Instance.CheckPointResource;
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06004C3A RID: 19514 RVA: 0x000BEEB2 File Offset: 0x000BD0B2
		[Nullable(2)]
		public virtual string CheckPointsDestroyRes
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.CheckPointsDestroyRes;
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x000BEEBF File Offset: 0x000BD0BF
		[Nullable(2)]
		public virtual string StartResource
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.StartResource;
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x000BEECC File Offset: 0x000BD0CC
		[Nullable(2)]
		public virtual string EndResource
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.EndResource;
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x000BEEDC File Offset: 0x000BD0DC
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

		// Token: 0x04002B2D RID: 11053
		private IParkourSpline Instance;

		// Token: 0x04002B2E RID: 11054
		private List<IParkourSplinePoint> _PointsCache;

		// Token: 0x04002B2F RID: 11055
		private bool _PointsInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C45 RID: 3141
	[NullableContext(1)]
	[Nullable(0)]
	public class IEffectSpline : ISplineType
	{
		// Token: 0x060047E6 RID: 18406 RVA: 0x000B4E02 File Offset: 0x000B3002
		public static IEffectSpline Create(IEffectSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x000B4E21 File Offset: 0x000B3021
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060047E8 RID: 18408 RVA: 0x000B4E2E File Offset: 0x000B302E
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x000B4E3B File Offset: 0x000B303B
		public virtual IEffectSplineCreationMode CreateOption
		{
			get
			{
				if (this._CreateOptionInited)
				{
					return this._CreateOptionCache;
				}
				this._CreateOptionInited = true;
				this._CreateOptionCache = ComponentReadHelper.ReadIEffectSpline_CreateOption(this.Instance);
				return this._CreateOptionCache;
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060047EA RID: 18410 RVA: 0x000B4E6C File Offset: 0x000B306C
		public virtual List<ICommonSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<ICommonSplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(ICommonSplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x040028EA RID: 10474
		private IEffectSpline Instance;

		// Token: 0x040028EB RID: 10475
		private IEffectSplineCreationMode _CreateOptionCache;

		// Token: 0x040028EC RID: 10476
		private bool _CreateOptionInited;

		// Token: 0x040028ED RID: 10477
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x040028EE RID: 10478
		private bool _PointsInited;
	}
}

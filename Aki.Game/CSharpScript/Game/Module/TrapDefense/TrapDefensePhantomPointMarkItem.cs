using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039E2 RID: 14818
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePhantomPointMarkItem : TrapDefenseMarkItem
	{
		// Token: 0x17004DF0 RID: 19952
		// (get) Token: 0x060262EB RID: 156395 RVA: 0x00AB53E6 File Offset: 0x00AB35E6
		public global::Vector PhantomPoint
		{
			get
			{
				if (this.Points.Count <= 0)
				{
					return global::Vector.ZeroVectorProxy;
				}
				return this.Points[0];
			}
		}

		// Token: 0x17004DF1 RID: 19953
		// (get) Token: 0x060262EC RID: 156396 RVA: 0x00AB5408 File Offset: 0x00AB3608
		public List<global::Vector> PhantomRoutePoints
		{
			get
			{
				return this.Points;
			}
		}

		// Token: 0x17004DF2 RID: 19954
		// (get) Token: 0x060262ED RID: 156397 RVA: 0x00AB5410 File Offset: 0x00AB3610
		public int SplineId
		{
			get
			{
				return this.SplineIdInner;
			}
		}

		// Token: 0x060262EE RID: 156398 RVA: 0x00AB5418 File Offset: 0x00AB3618
		[NullableContext(2)]
		public TrapDefensePhantomPointMarkItem(int markId, object extraParam = null) : base(markId, extraParam)
		{
			object[] array = extraParam as object[];
			if (array != null && array.Length == 2)
			{
				object obj = array[0];
				if (obj is int)
				{
					int splineIdInner = (int)obj;
					this.SplineIdInner = splineIdInner;
				}
				List<global::Vector> list = array[1] as List<global::Vector>;
				if (list != null)
				{
					this.Points = list;
				}
			}
		}

		// Token: 0x17004DF3 RID: 19955
		// (get) Token: 0x060262EF RID: 156399 RVA: 0x00AB5475 File Offset: 0x00AB3675
		public override TrapDefenseDefine.ETrapDefenseMarkType MarkType
		{
			get
			{
				return TrapDefenseDefine.ETrapDefenseMarkType.PhantomPoint;
			}
		}

		// Token: 0x060262F0 RID: 156400 RVA: 0x00AB5478 File Offset: 0x00AB3678
		protected override void OnInitialize()
		{
			this.EnableCachePosition = true;
		}

		// Token: 0x17004DF4 RID: 19956
		// (get) Token: 0x060262F1 RID: 156401 RVA: 0x00AB5481 File Offset: 0x00AB3681
		public override global::Vector WorldPosition
		{
			get
			{
				return this.PhantomPoint;
			}
		}

		// Token: 0x060262F2 RID: 156402 RVA: 0x00AB548C File Offset: 0x00AB368C
		public bool IsActivated()
		{
			TrapDefenseWave? currentBatchData = TrapDefenseModel.Instance.GetCurrentBatchData();
			return currentBatchData != null && Array.IndexOf<int>(currentBatchData.Value.SplineList(), this.SplineId) >= 0;
		}

		// Token: 0x04014F20 RID: 85792
		private List<global::Vector> Points = new List<global::Vector>();

		// Token: 0x04014F21 RID: 85793
		private int SplineIdInner;
	}
}

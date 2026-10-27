using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A3A RID: 19002
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePhantomPointMarkItem : TrapDefenseMarkItem
	{
		// Token: 0x17007A43 RID: 31299
		// (get) Token: 0x0603155B RID: 202075 RVA: 0x00B71472 File Offset: 0x00B6F672
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

		// Token: 0x17007A44 RID: 31300
		// (get) Token: 0x0603155C RID: 202076 RVA: 0x00B71494 File Offset: 0x00B6F694
		public List<global::Vector> PhantomRoutePoints
		{
			get
			{
				return this.Points;
			}
		}

		// Token: 0x17007A45 RID: 31301
		// (get) Token: 0x0603155D RID: 202077 RVA: 0x00B7149C File Offset: 0x00B6F69C
		public int SplineId
		{
			get
			{
				return this.SplineIdInner;
			}
		}

		// Token: 0x0603155E RID: 202078 RVA: 0x00B714A4 File Offset: 0x00B6F6A4
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

		// Token: 0x17007A46 RID: 31302
		// (get) Token: 0x0603155F RID: 202079 RVA: 0x00B71501 File Offset: 0x00B6F701
		public override TrapDefenseDefine.ETrapDefenseMarkType MarkType
		{
			get
			{
				return TrapDefenseDefine.ETrapDefenseMarkType.PhantomPoint;
			}
		}

		// Token: 0x06031560 RID: 202080 RVA: 0x00B71504 File Offset: 0x00B6F704
		protected override void OnInitialize()
		{
			this.EnableCachePosition = true;
		}

		// Token: 0x17007A47 RID: 31303
		// (get) Token: 0x06031561 RID: 202081 RVA: 0x00B7150D File Offset: 0x00B6F70D
		public override global::Vector WorldPosition
		{
			get
			{
				return this.PhantomPoint;
			}
		}

		// Token: 0x06031562 RID: 202082 RVA: 0x00B71518 File Offset: 0x00B6F718
		public bool IsActivated()
		{
			TrapDefenseWave? currentBatchData = TrapDefenseModel.Instance.GetCurrentBatchData();
			return currentBatchData != null && currentBatchData.Value.SplineList().Contains(this.SplineId);
		}

		// Token: 0x0401A5CE RID: 107982
		private List<global::Vector> Points = new List<global::Vector>();

		// Token: 0x0401A5CF RID: 107983
		private int SplineIdInner;
	}
}

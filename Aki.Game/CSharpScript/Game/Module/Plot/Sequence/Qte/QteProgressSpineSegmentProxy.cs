using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02005021 RID: 20513
	[NullableContext(1)]
	[Nullable(0)]
	public class QteProgressSpineSegmentProxy
	{
		// Token: 0x060347E0 RID: 215008 RVA: 0x00C5D9AE File Offset: 0x00C5BBAE
		public static QteProgressSpineSegmentProxy CreateLegacyProgressSegment(List<SpineDataProxy> spines)
		{
			return new QteProgressSpineSegmentProxy
			{
				Spines = spines
			};
		}

		// Token: 0x060347E1 RID: 215009 RVA: 0x00C5D9BC File Offset: 0x00C5BBBC
		public bool IsActive(float qteProgress)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)this.QteStartProgress, (double)this.QteEndProgress, null))
			{
				return MathUtils.Instance.IsNearlyEqual((double)qteProgress, (double)this.QteEndProgress, null);
			}
			float rangePct = MathUtils.Instance.GetRangePct(this.QteStartProgress, this.QteEndProgress, qteProgress);
			return rangePct > 0f && rangePct <= 1f;
		}

		// Token: 0x060347E2 RID: 215010 RVA: 0x00C5DA38 File Offset: 0x00C5BC38
		public float GetSpineProgress(float qteProgress)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)this.QteStartProgress, (double)this.QteEndProgress, null))
			{
				return this.SpineEndProgress;
			}
			return MathUtils.Instance.RangeClamp(qteProgress, this.QteStartProgress, this.QteEndProgress, this.SpineStartProgress, this.SpineEndProgress);
		}

		// Token: 0x0401BFA1 RID: 114593
		public List<SpineDataProxy> Spines = new List<SpineDataProxy>();

		// Token: 0x0401BFA2 RID: 114594
		public float QteStartProgress;

		// Token: 0x0401BFA3 RID: 114595
		public float QteEndProgress = 1f;

		// Token: 0x0401BFA4 RID: 114596
		public float SpineStartProgress;

		// Token: 0x0401BFA5 RID: 114597
		public float SpineEndProgress = 1f;

		// Token: 0x0401BFA6 RID: 114598
		public float BlendInTime = 0.5f;

		// Token: 0x0401BFA7 RID: 114599
		public float BlendOutTime;
	}
}

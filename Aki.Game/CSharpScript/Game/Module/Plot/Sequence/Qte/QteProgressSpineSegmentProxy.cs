using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FEB RID: 16363
	[NullableContext(1)]
	[Nullable(0)]
	public class QteProgressSpineSegmentProxy
	{
		// Token: 0x06029683 RID: 169603 RVA: 0x00BA8EFA File Offset: 0x00BA70FA
		public static QteProgressSpineSegmentProxy CreateLegacyProgressSegment(List<SpineDataProxy> spines)
		{
			return new QteProgressSpineSegmentProxy
			{
				Spines = spines
			};
		}

		// Token: 0x06029684 RID: 169604 RVA: 0x00BA8F08 File Offset: 0x00BA7108
		public bool IsActive(float qteProgress)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)this.QteStartProgress, (double)this.QteEndProgress, null))
			{
				return MathUtils.Instance.IsNearlyEqual((double)qteProgress, (double)this.QteEndProgress, null);
			}
			float rangePct = MathUtils.Instance.GetRangePct(this.QteStartProgress, this.QteEndProgress, qteProgress);
			return rangePct > 0f && rangePct <= 1f;
		}

		// Token: 0x06029685 RID: 169605 RVA: 0x00BA8F84 File Offset: 0x00BA7184
		public float GetSpineProgress(float qteProgress)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)this.QteStartProgress, (double)this.QteEndProgress, null))
			{
				return this.SpineEndProgress;
			}
			return MathUtils.Instance.RangeClamp(qteProgress, this.QteStartProgress, this.QteEndProgress, this.SpineStartProgress, this.SpineEndProgress);
		}

		// Token: 0x0401698C RID: 92556
		public List<SpineDataProxy> Spines = new List<SpineDataProxy>();

		// Token: 0x0401698D RID: 92557
		public float QteStartProgress;

		// Token: 0x0401698E RID: 92558
		public float QteEndProgress = 1f;

		// Token: 0x0401698F RID: 92559
		public float SpineStartProgress;

		// Token: 0x04016990 RID: 92560
		public float SpineEndProgress = 1f;

		// Token: 0x04016991 RID: 92561
		public float BlendInTime = 0.5f;

		// Token: 0x04016992 RID: 92562
		public float BlendOutTime;
	}
}

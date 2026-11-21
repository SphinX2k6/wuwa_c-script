using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A4F RID: 23119
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolChooseEndingViewParam
	{
		// Token: 0x17006C90 RID: 27792
		// (get) Token: 0x06038F88 RID: 233352 RVA: 0x00FF6107 File Offset: 0x00FF4307
		public int ActivityId { get; }

		// Token: 0x17006C91 RID: 27793
		// (get) Token: 0x06038F89 RID: 233353 RVA: 0x00FF610F File Offset: 0x00FF430F
		public ESolarSchoolEndingType EndingType { get; }

		// Token: 0x17006C92 RID: 27794
		// (get) Token: 0x06038F8A RID: 233354 RVA: 0x00FF6117 File Offset: 0x00FF4317
		public IReadOnlyCollection<int> CandidateIds { get; }

		// Token: 0x17006C93 RID: 27795
		// (get) Token: 0x06038F8B RID: 233355 RVA: 0x00FF611F File Offset: 0x00FF431F
		public Action<int> OnConfirm { get; }

		// Token: 0x17006C94 RID: 27796
		// (get) Token: 0x06038F8C RID: 233356 RVA: 0x00FF6127 File Offset: 0x00FF4327
		public Action OnCancel { get; }

		// Token: 0x06038F8D RID: 233357 RVA: 0x00FF612F File Offset: 0x00FF432F
		public SolarSchoolChooseEndingViewParam(int activityId, ESolarSchoolEndingType endingType, IReadOnlyCollection<int> candidateIds, Action<int> onConfirm, Action onCancel = null)
		{
			this.ActivityId = activityId;
			this.EndingType = endingType;
			this.CandidateIds = candidateIds;
			this.OnConfirm = onConfirm;
			this.OnCancel = onCancel;
		}
	}
}

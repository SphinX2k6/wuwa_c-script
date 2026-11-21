using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A45 RID: 23109
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolEndingSummaryViewParam
	{
		// Token: 0x17006C83 RID: 27779
		// (get) Token: 0x06038F68 RID: 233320 RVA: 0x00FF5E66 File Offset: 0x00FF4066
		public int ActivityId { get; }

		// Token: 0x17006C84 RID: 27780
		// (get) Token: 0x06038F69 RID: 233321 RVA: 0x00FF5E6E File Offset: 0x00FF406E
		public Action OnPresentFinished { get; }

		// Token: 0x06038F6A RID: 233322 RVA: 0x00FF5E76 File Offset: 0x00FF4076
		public SolarSchoolEndingSummaryViewParam(int activityId, Action onPresentFinished)
		{
			this.ActivityId = activityId;
			this.OnPresentFinished = onPresentFinished;
		}
	}
}

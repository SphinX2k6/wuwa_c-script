using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200671F RID: 26399
	public class IActorFxEmoteStopSubTypeT
	{
		// Token: 0x1700BFF0 RID: 49136
		// (get) Token: 0x0602CB77 RID: 183159 RVA: 0x0061E21A File Offset: 0x0061C41A
		// (set) Token: 0x0602CB78 RID: 183160 RVA: 0x0061E222 File Offset: 0x0061C422
		public EActorFxEmoteStopSubType Type { get; set; }

		// Token: 0x0602CB79 RID: 183161 RVA: 0x0061E22B File Offset: 0x0061C42B
		public IActorFxEmoteStopSubTypeT()
		{
			this.Type = EActorFxEmoteStopSubType.StopAll;
		}
	}
}

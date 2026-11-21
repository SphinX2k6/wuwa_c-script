using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E70 RID: 20080
	public class ICheckDangoBrawlChallengeCompleteT
	{
		// Token: 0x17008F38 RID: 36664
		// (get) Token: 0x0601F1A1 RID: 127393 RVA: 0x00457034 File Offset: 0x00455234
		// (set) Token: 0x0601F1A2 RID: 127394 RVA: 0x0045703C File Offset: 0x0045523C
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008F39 RID: 36665
		// (get) Token: 0x0601F1A3 RID: 127395 RVA: 0x00457045 File Offset: 0x00455245
		// (set) Token: 0x0601F1A4 RID: 127396 RVA: 0x0045704D File Offset: 0x0045524D
		public int ChallengeId { get; set; }

		// Token: 0x0601F1A5 RID: 127397 RVA: 0x00457056 File Offset: 0x00455256
		public ICheckDangoBrawlChallengeCompleteT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.ChallengeId = 0;
		}
	}
}

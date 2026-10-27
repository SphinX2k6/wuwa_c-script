using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EB4 RID: 20148
	public class IAnsEventT
	{
		// Token: 0x1700908D RID: 37005
		// (get) Token: 0x0601FBAC RID: 129964 RVA: 0x0046ADC3 File Offset: 0x00468FC3
		// (set) Token: 0x0601FBAD RID: 129965 RVA: 0x0046ADCB File Offset: 0x00468FCB
		public ESceneItemSeqEventCbType Type { get; set; }

		// Token: 0x1700908E RID: 37006
		// (get) Token: 0x0601FBAE RID: 129966 RVA: 0x0046ADD4 File Offset: 0x00468FD4
		// (set) Token: 0x0601FBAF RID: 129967 RVA: 0x0046ADDC File Offset: 0x00468FDC
		public string EventName { get; set; }

		// Token: 0x1700908F RID: 37007
		// (get) Token: 0x0601FBB0 RID: 129968 RVA: 0x0046ADE5 File Offset: 0x00468FE5
		// (set) Token: 0x0601FBB1 RID: 129969 RVA: 0x0046ADED File Offset: 0x00468FED
		public IActionInfoT Action { get; set; }

		// Token: 0x17009090 RID: 37008
		// (get) Token: 0x0601FBB2 RID: 129970 RVA: 0x0046ADF6 File Offset: 0x00468FF6
		// (set) Token: 0x0601FBB3 RID: 129971 RVA: 0x0046ADFE File Offset: 0x00468FFE
		public float Duration { get; set; }

		// Token: 0x0601FBB4 RID: 129972 RVA: 0x0046AE07 File Offset: 0x00469007
		public IAnsEventT()
		{
			this.Type = ESceneItemSeqEventCbType.ANS;
			this.EventName = null;
			this.Action = null;
			this.Duration = 0f;
		}
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004368 RID: 17256
	public class IMechaTrackScoreMechanismStateTypeT
	{
		// Token: 0x1700765D RID: 30301
		// (get) Token: 0x060185C8 RID: 99784 RVA: 0x003795ED File Offset: 0x003777ED
		// (set) Token: 0x060185C9 RID: 99785 RVA: 0x003795F5 File Offset: 0x003777F5
		public IStaticEntitiyMatchT EntitiyMatch { get; set; }

		// Token: 0x1700765E RID: 30302
		// (get) Token: 0x060185CA RID: 99786 RVA: 0x003795FE File Offset: 0x003777FE
		// (set) Token: 0x060185CB RID: 99787 RVA: 0x00379606 File Offset: 0x00377806
		public string State { get; set; }

		// Token: 0x1700765F RID: 30303
		// (get) Token: 0x060185CC RID: 99788 RVA: 0x0037960F File Offset: 0x0037780F
		// (set) Token: 0x060185CD RID: 99789 RVA: 0x00379617 File Offset: 0x00377817
		public int ScoreId { get; set; }

		// Token: 0x060185CE RID: 99790 RVA: 0x00379620 File Offset: 0x00377820
		public IMechaTrackScoreMechanismStateTypeT()
		{
			this.EntitiyMatch = null;
			this.State = null;
			this.ScoreId = 0;
		}
	}
}

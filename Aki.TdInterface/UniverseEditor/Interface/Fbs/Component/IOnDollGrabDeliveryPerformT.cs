using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C3A RID: 23610
	public class IOnDollGrabDeliveryPerformT
	{
		// Token: 0x1700AD6C RID: 44396
		// (get) Token: 0x06027231 RID: 160305 RVA: 0x0055CE72 File Offset: 0x0055B072
		// (set) Token: 0x06027232 RID: 160306 RVA: 0x0055CE7A File Offset: 0x0055B07A
		public string EventMontage { get; set; }

		// Token: 0x1700AD6D RID: 44397
		// (get) Token: 0x06027233 RID: 160307 RVA: 0x0055CE83 File Offset: 0x0055B083
		// (set) Token: 0x06027234 RID: 160308 RVA: 0x0055CE8B File Offset: 0x0055B08B
		public string StandByMontage { get; set; }

		// Token: 0x1700AD6E RID: 44398
		// (get) Token: 0x06027235 RID: 160309 RVA: 0x0055CE94 File Offset: 0x0055B094
		// (set) Token: 0x06027236 RID: 160310 RVA: 0x0055CE9C File Offset: 0x0055B09C
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700AD6F RID: 44399
		// (get) Token: 0x06027237 RID: 160311 RVA: 0x0055CEA5 File Offset: 0x0055B0A5
		// (set) Token: 0x06027238 RID: 160312 RVA: 0x0055CEAD File Offset: 0x0055B0AD
		public float PerformDuration { get; set; }

		// Token: 0x1700AD70 RID: 44400
		// (get) Token: 0x06027239 RID: 160313 RVA: 0x0055CEB6 File Offset: 0x0055B0B6
		// (set) Token: 0x0602723A RID: 160314 RVA: 0x0055CEBE File Offset: 0x0055B0BE
		public byte NullMask { get; set; }

		// Token: 0x0602723B RID: 160315 RVA: 0x0055CEC7 File Offset: 0x0055B0C7
		public IOnDollGrabDeliveryPerformT()
		{
			this.EventMontage = null;
			this.StandByMontage = null;
			this.Flow = null;
			this.PerformDuration = 0f;
			this.NullMask = 0;
		}
	}
}

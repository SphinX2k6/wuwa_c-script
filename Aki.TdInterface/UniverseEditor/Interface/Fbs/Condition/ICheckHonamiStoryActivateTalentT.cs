using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A52 RID: 19026
	public class ICheckHonamiStoryActivateTalentT
	{
		// Token: 0x170089B9 RID: 35257
		// (get) Token: 0x0601DCBA RID: 122042 RVA: 0x0043034A File Offset: 0x0042E54A
		// (set) Token: 0x0601DCBB RID: 122043 RVA: 0x00430352 File Offset: 0x0042E552
		public ECondition Type { get; set; }

		// Token: 0x170089BA RID: 35258
		// (get) Token: 0x0601DCBC RID: 122044 RVA: 0x0043035B File Offset: 0x0042E55B
		// (set) Token: 0x0601DCBD RID: 122045 RVA: 0x00430363 File Offset: 0x0042E563
		public int TalentId { get; set; }

		// Token: 0x170089BB RID: 35259
		// (get) Token: 0x0601DCBE RID: 122046 RVA: 0x0043036C File Offset: 0x0042E56C
		// (set) Token: 0x0601DCBF RID: 122047 RVA: 0x00430374 File Offset: 0x0042E574
		public bool IsActivated { get; set; }

		// Token: 0x0601DCC0 RID: 122048 RVA: 0x0043037D File Offset: 0x0042E57D
		public ICheckHonamiStoryActivateTalentT()
		{
			this.Type = ECondition.CompareVar;
			this.TalentId = 0;
			this.IsActivated = false;
		}
	}
}

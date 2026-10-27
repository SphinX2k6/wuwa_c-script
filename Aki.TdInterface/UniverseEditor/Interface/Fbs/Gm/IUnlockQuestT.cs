using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046D3 RID: 18131
	public class IUnlockQuestT
	{
		// Token: 0x170080D2 RID: 32978
		// (get) Token: 0x0601B91B RID: 112923 RVA: 0x003E91F4 File Offset: 0x003E73F4
		// (set) Token: 0x0601B91C RID: 112924 RVA: 0x003E91FC File Offset: 0x003E73FC
		public EGmCommand Type { get; set; }

		// Token: 0x170080D3 RID: 32979
		// (get) Token: 0x0601B91D RID: 112925 RVA: 0x003E9205 File Offset: 0x003E7405
		// (set) Token: 0x0601B91E RID: 112926 RVA: 0x003E920D File Offset: 0x003E740D
		public int QuestId { get; set; }

		// Token: 0x0601B91F RID: 112927 RVA: 0x003E9216 File Offset: 0x003E7416
		public IUnlockQuestT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.QuestId = 0;
		}
	}
}

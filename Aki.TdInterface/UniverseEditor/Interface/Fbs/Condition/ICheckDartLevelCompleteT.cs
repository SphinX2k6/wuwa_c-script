using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E7C RID: 20092
	public class ICheckDartLevelCompleteT
	{
		// Token: 0x17008F48 RID: 36680
		// (get) Token: 0x0601F1ED RID: 127469 RVA: 0x00457796 File Offset: 0x00455996
		// (set) Token: 0x0601F1EE RID: 127470 RVA: 0x0045779E File Offset: 0x0045599E
		public ECondition Type { get; set; }

		// Token: 0x17008F49 RID: 36681
		// (get) Token: 0x0601F1EF RID: 127471 RVA: 0x004577A7 File Offset: 0x004559A7
		// (set) Token: 0x0601F1F0 RID: 127472 RVA: 0x004577AF File Offset: 0x004559AF
		public bool IsCompleted { get; set; }

		// Token: 0x17008F4A RID: 36682
		// (get) Token: 0x0601F1F1 RID: 127473 RVA: 0x004577B8 File Offset: 0x004559B8
		// (set) Token: 0x0601F1F2 RID: 127474 RVA: 0x004577C0 File Offset: 0x004559C0
		public int LevelId { get; set; }

		// Token: 0x0601F1F3 RID: 127475 RVA: 0x004577C9 File Offset: 0x004559C9
		public ICheckDartLevelCompleteT()
		{
			this.Type = ECondition.CompareVar;
			this.IsCompleted = false;
			this.LevelId = 0;
		}
	}
}

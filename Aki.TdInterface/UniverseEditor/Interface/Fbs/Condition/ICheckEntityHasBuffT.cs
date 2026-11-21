using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EC4 RID: 20164
	public class ICheckEntityHasBuffT
	{
		// Token: 0x17008FEE RID: 36846
		// (get) Token: 0x0601F485 RID: 128133 RVA: 0x0045C5AF File Offset: 0x0045A7AF
		// (set) Token: 0x0601F486 RID: 128134 RVA: 0x0045C5B7 File Offset: 0x0045A7B7
		public ECondition Type { get; set; }

		// Token: 0x17008FEF RID: 36847
		// (get) Token: 0x0601F487 RID: 128135 RVA: 0x0045C5C0 File Offset: 0x0045A7C0
		// (set) Token: 0x0601F488 RID: 128136 RVA: 0x0045C5C8 File Offset: 0x0045A7C8
		public IMonsterBuffContainerT Target { get; set; }

		// Token: 0x17008FF0 RID: 36848
		// (get) Token: 0x0601F489 RID: 128137 RVA: 0x0045C5D1 File Offset: 0x0045A7D1
		// (set) Token: 0x0601F48A RID: 128138 RVA: 0x0045C5D9 File Offset: 0x0045A7D9
		public long BuffId { get; set; }

		// Token: 0x17008FF1 RID: 36849
		// (get) Token: 0x0601F48B RID: 128139 RVA: 0x0045C5E2 File Offset: 0x0045A7E2
		// (set) Token: 0x0601F48C RID: 128140 RVA: 0x0045C5EA File Offset: 0x0045A7EA
		public bool HasBuff { get; set; }

		// Token: 0x0601F48D RID: 128141 RVA: 0x0045C5F3 File Offset: 0x0045A7F3
		public ICheckEntityHasBuffT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.BuffId = 0L;
			this.HasBuff = false;
		}
	}
}

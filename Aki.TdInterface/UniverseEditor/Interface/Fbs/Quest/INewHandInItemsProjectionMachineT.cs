using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004398 RID: 17304
	public class INewHandInItemsProjectionMachineT
	{
		// Token: 0x170076B8 RID: 30392
		// (get) Token: 0x0601876C RID: 100204 RVA: 0x0037C7E2 File Offset: 0x0037A9E2
		// (set) Token: 0x0601876D RID: 100205 RVA: 0x0037C7EA File Offset: 0x0037A9EA
		public ENewHandInItemsType Type { get; set; }

		// Token: 0x170076B9 RID: 30393
		// (get) Token: 0x0601876E RID: 100206 RVA: 0x0037C7F3 File Offset: 0x0037A9F3
		// (set) Token: 0x0601876F RID: 100207 RVA: 0x0037C7FB File Offset: 0x0037A9FB
		public int EntityId { get; set; }

		// Token: 0x170076BA RID: 30394
		// (get) Token: 0x06018770 RID: 100208 RVA: 0x0037C804 File Offset: 0x0037AA04
		// (set) Token: 0x06018771 RID: 100209 RVA: 0x0037C80C File Offset: 0x0037AA0C
		public int ItemId { get; set; }

		// Token: 0x06018772 RID: 100210 RVA: 0x0037C815 File Offset: 0x0037AA15
		public INewHandInItemsProjectionMachineT()
		{
			this.Type = ENewHandInItemsType.ProjectionMachine;
			this.EntityId = 0;
			this.ItemId = 0;
		}
	}
}

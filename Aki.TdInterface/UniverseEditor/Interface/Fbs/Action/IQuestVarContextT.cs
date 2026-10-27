using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFF RID: 28159
	public class IQuestVarContextT
	{
		// Token: 0x1700D1E1 RID: 53729
		// (get) Token: 0x06031BEB RID: 203755 RVA: 0x006BC2A0 File Offset: 0x006BA4A0
		// (set) Token: 0x06031BEC RID: 203756 RVA: 0x006BC2A8 File Offset: 0x006BA4A8
		public EVarContext Type { get; set; }

		// Token: 0x1700D1E2 RID: 53730
		// (get) Token: 0x06031BED RID: 203757 RVA: 0x006BC2B1 File Offset: 0x006BA4B1
		// (set) Token: 0x06031BEE RID: 203758 RVA: 0x006BC2B9 File Offset: 0x006BA4B9
		public int Id { get; set; }

		// Token: 0x06031BEF RID: 203759 RVA: 0x006BC2C2 File Offset: 0x006BA4C2
		public IQuestVarContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
		}
	}
}

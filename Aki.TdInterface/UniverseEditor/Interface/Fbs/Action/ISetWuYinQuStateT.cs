using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007882 RID: 30850
	public class ISetWuYinQuStateT
	{
		// Token: 0x1700E23C RID: 57916
		// (get) Token: 0x06036445 RID: 222277 RVA: 0x00744A7F File Offset: 0x00742C7F
		// (set) Token: 0x06036446 RID: 222278 RVA: 0x00744A87 File Offset: 0x00742C87
		public string WuYinQuName { get; set; }

		// Token: 0x1700E23D RID: 57917
		// (get) Token: 0x06036447 RID: 222279 RVA: 0x00744A90 File Offset: 0x00742C90
		// (set) Token: 0x06036448 RID: 222280 RVA: 0x00744A98 File Offset: 0x00742C98
		public EWuYinQuState State { get; set; }

		// Token: 0x06036449 RID: 222281 RVA: 0x00744AA1 File Offset: 0x00742CA1
		public ISetWuYinQuStateT()
		{
			this.WuYinQuName = null;
			this.State = EWuYinQuState.End;
		}
	}
}

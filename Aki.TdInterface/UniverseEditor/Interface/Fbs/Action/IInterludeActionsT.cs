using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AF RID: 27055
	public class IInterludeActionsT
	{
		// Token: 0x1700C8B0 RID: 51376
		// (get) Token: 0x0602F45D RID: 193629 RVA: 0x006705C8 File Offset: 0x0066E7C8
		// (set) Token: 0x0602F45E RID: 193630 RVA: 0x006705D0 File Offset: 0x0066E7D0
		public List<IActionInfoT> InterludeActionList { get; set; }

		// Token: 0x1700C8B1 RID: 51377
		// (get) Token: 0x0602F45F RID: 193631 RVA: 0x006705D9 File Offset: 0x0066E7D9
		// (set) Token: 0x0602F460 RID: 193632 RVA: 0x006705E1 File Offset: 0x0066E7E1
		public List<int> DestroyEntityIds { get; set; }

		// Token: 0x1700C8B2 RID: 51378
		// (get) Token: 0x0602F461 RID: 193633 RVA: 0x006705EA File Offset: 0x0066E7EA
		// (set) Token: 0x0602F462 RID: 193634 RVA: 0x006705F2 File Offset: 0x0066E7F2
		public bool IsFadeIn { get; set; }

		// Token: 0x1700C8B3 RID: 51379
		// (get) Token: 0x0602F463 RID: 193635 RVA: 0x006705FB File Offset: 0x0066E7FB
		// (set) Token: 0x0602F464 RID: 193636 RVA: 0x00670603 File Offset: 0x0066E803
		public bool IsFadeOut { get; set; }

		// Token: 0x1700C8B4 RID: 51380
		// (get) Token: 0x0602F465 RID: 193637 RVA: 0x0067060C File Offset: 0x0066E80C
		// (set) Token: 0x0602F466 RID: 193638 RVA: 0x00670614 File Offset: 0x0066E814
		public byte NullMask { get; set; }

		// Token: 0x0602F467 RID: 193639 RVA: 0x0067061D File Offset: 0x0066E81D
		public IInterludeActionsT()
		{
			this.InterludeActionList = null;
			this.DestroyEntityIds = null;
			this.IsFadeIn = false;
			this.IsFadeOut = false;
			this.NullMask = 0;
		}
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A36 RID: 23094
	public class IJigsawItemMatchedConfigT
	{
		// Token: 0x1700A7EC RID: 42988
		// (get) Token: 0x06025C10 RID: 154640 RVA: 0x0052D0E7 File Offset: 0x0052B2E7
		// (set) Token: 0x06025C11 RID: 154641 RVA: 0x0052D0EF File Offset: 0x0052B2EF
		public IPieceIndexT TargetIndex { get; set; }

		// Token: 0x1700A7ED RID: 42989
		// (get) Token: 0x06025C12 RID: 154642 RVA: 0x0052D0F8 File Offset: 0x0052B2F8
		// (set) Token: 0x06025C13 RID: 154643 RVA: 0x0052D100 File Offset: 0x0052B300
		public List<int> JigsawItemIds { get; set; }

		// Token: 0x1700A7EE RID: 42990
		// (get) Token: 0x06025C14 RID: 154644 RVA: 0x0052D109 File Offset: 0x0052B309
		// (set) Token: 0x06025C15 RID: 154645 RVA: 0x0052D111 File Offset: 0x0052B311
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A7EF RID: 42991
		// (get) Token: 0x06025C16 RID: 154646 RVA: 0x0052D11A File Offset: 0x0052B31A
		// (set) Token: 0x06025C17 RID: 154647 RVA: 0x0052D122 File Offset: 0x0052B322
		public List<IConditionActionT> ConditionActions { get; set; }

		// Token: 0x1700A7F0 RID: 42992
		// (get) Token: 0x06025C18 RID: 154648 RVA: 0x0052D12B File Offset: 0x0052B32B
		// (set) Token: 0x06025C19 RID: 154649 RVA: 0x0052D133 File Offset: 0x0052B333
		public List<IActionInfoT> UnmatchedActions { get; set; }

		// Token: 0x1700A7F1 RID: 42993
		// (get) Token: 0x06025C1A RID: 154650 RVA: 0x0052D13C File Offset: 0x0052B33C
		// (set) Token: 0x06025C1B RID: 154651 RVA: 0x0052D144 File Offset: 0x0052B344
		public byte NullMask { get; set; }

		// Token: 0x06025C1C RID: 154652 RVA: 0x0052D14D File Offset: 0x0052B34D
		public IJigsawItemMatchedConfigT()
		{
			this.TargetIndex = null;
			this.JigsawItemIds = null;
			this.Actions = null;
			this.ConditionActions = null;
			this.UnmatchedActions = null;
			this.NullMask = 0;
		}
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D2C RID: 15660
	public class IBehaviorTreeT
	{
		// Token: 0x17006B6E RID: 27502
		// (get) Token: 0x06015A03 RID: 88579 RVA: 0x0031F45E File Offset: 0x0031D65E
		// (set) Token: 0x06015A04 RID: 88580 RVA: 0x0031F466 File Offset: 0x0031D666
		public List<IVarDefineT> Vars { get; set; }

		// Token: 0x17006B6F RID: 27503
		// (get) Token: 0x06015A05 RID: 88581 RVA: 0x0031F46F File Offset: 0x0031D66F
		// (set) Token: 0x06015A06 RID: 88582 RVA: 0x0031F477 File Offset: 0x0031D677
		public IStartBtNodeT Root { get; set; }

		// Token: 0x17006B70 RID: 27504
		// (get) Token: 0x06015A07 RID: 88583 RVA: 0x0031F480 File Offset: 0x0031D680
		// (set) Token: 0x06015A08 RID: 88584 RVA: 0x0031F488 File Offset: 0x0031D688
		public List<int> _SelectedNodeIds { get; set; }

		// Token: 0x17006B71 RID: 27505
		// (get) Token: 0x06015A09 RID: 88585 RVA: 0x0031F491 File Offset: 0x0031D691
		// (set) Token: 0x06015A0A RID: 88586 RVA: 0x0031F499 File Offset: 0x0031D699
		public List<IFavoriteBtNodeInfoT> _FavoriteNodes { get; set; }

		// Token: 0x17006B72 RID: 27506
		// (get) Token: 0x06015A0B RID: 88587 RVA: 0x0031F4A2 File Offset: 0x0031D6A2
		// (set) Token: 0x06015A0C RID: 88588 RVA: 0x0031F4AA File Offset: 0x0031D6AA
		public byte NullMask { get; set; }

		// Token: 0x06015A0D RID: 88589 RVA: 0x0031F4B3 File Offset: 0x0031D6B3
		public IBehaviorTreeT()
		{
			this.Vars = null;
			this.Root = null;
			this._SelectedNodeIds = null;
			this._FavoriteNodes = null;
			this.NullMask = 0;
		}
	}
}

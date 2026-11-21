using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004143 RID: 16707
	public class IBehaviorTreeT
	{
		// Token: 0x17007128 RID: 28968
		// (get) Token: 0x06016F3B RID: 94011 RVA: 0x003466D6 File Offset: 0x003448D6
		// (set) Token: 0x06016F3C RID: 94012 RVA: 0x003466DE File Offset: 0x003448DE
		public List<IVarDefineT> Vars { get; set; }

		// Token: 0x17007129 RID: 28969
		// (get) Token: 0x06016F3D RID: 94013 RVA: 0x003466E7 File Offset: 0x003448E7
		// (set) Token: 0x06016F3E RID: 94014 RVA: 0x003466EF File Offset: 0x003448EF
		public IStartBtNodeT Root { get; set; }

		// Token: 0x1700712A RID: 28970
		// (get) Token: 0x06016F3F RID: 94015 RVA: 0x003466F8 File Offset: 0x003448F8
		// (set) Token: 0x06016F40 RID: 94016 RVA: 0x00346700 File Offset: 0x00344900
		public List<int> _SelectedNodeIds { get; set; }

		// Token: 0x1700712B RID: 28971
		// (get) Token: 0x06016F41 RID: 94017 RVA: 0x00346709 File Offset: 0x00344909
		// (set) Token: 0x06016F42 RID: 94018 RVA: 0x00346711 File Offset: 0x00344911
		public List<IFavoriteBtNodeInfoT> _FavoriteNodes { get; set; }

		// Token: 0x1700712C RID: 28972
		// (get) Token: 0x06016F43 RID: 94019 RVA: 0x0034671A File Offset: 0x0034491A
		// (set) Token: 0x06016F44 RID: 94020 RVA: 0x00346722 File Offset: 0x00344922
		public byte NullMask { get; set; }

		// Token: 0x06016F45 RID: 94021 RVA: 0x0034672B File Offset: 0x0034492B
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

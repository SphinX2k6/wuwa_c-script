using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FED RID: 16365
	public class IQuestListT
	{
		// Token: 0x170072D9 RID: 29401
		// (get) Token: 0x06017901 RID: 96513 RVA: 0x00365E10 File Offset: 0x00364010
		// (set) Token: 0x06017902 RID: 96514 RVA: 0x00365E18 File Offset: 0x00364018
		public List<IQuestT> Quests { get; set; }

		// Token: 0x170072DA RID: 29402
		// (get) Token: 0x06017903 RID: 96515 RVA: 0x00365E21 File Offset: 0x00364021
		// (set) Token: 0x06017904 RID: 96516 RVA: 0x00365E29 File Offset: 0x00364029
		public int _Selected { get; set; }

		// Token: 0x170072DB RID: 29403
		// (get) Token: 0x06017905 RID: 96517 RVA: 0x00365E32 File Offset: 0x00364032
		// (set) Token: 0x06017906 RID: 96518 RVA: 0x00365E3A File Offset: 0x0036403A
		public bool _IsSelectBt { get; set; }

		// Token: 0x170072DC RID: 29404
		// (get) Token: 0x06017907 RID: 96519 RVA: 0x00365E43 File Offset: 0x00364043
		// (set) Token: 0x06017908 RID: 96520 RVA: 0x00365E4B File Offset: 0x0036404B
		public List<ISyncBlockGroupT> _SyncBlockGroups { get; set; }

		// Token: 0x170072DD RID: 29405
		// (get) Token: 0x06017909 RID: 96521 RVA: 0x00365E54 File Offset: 0x00364054
		// (set) Token: 0x0601790A RID: 96522 RVA: 0x00365E5C File Offset: 0x0036405C
		public byte NullMask { get; set; }

		// Token: 0x0601790B RID: 96523 RVA: 0x00365E65 File Offset: 0x00364065
		public IQuestListT()
		{
			this.Quests = null;
			this._Selected = 0;
			this._IsSelectBt = false;
			this._SyncBlockGroups = null;
			this.NullMask = 0;
		}
	}
}

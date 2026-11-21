using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200442E RID: 17454
	public class IQuestListT
	{
		// Token: 0x170078DB RID: 30939
		// (get) Token: 0x06018F9A RID: 102298 RVA: 0x0038FC04 File Offset: 0x0038DE04
		// (set) Token: 0x06018F9B RID: 102299 RVA: 0x0038FC0C File Offset: 0x0038DE0C
		public List<IQuestT> Quests { get; set; }

		// Token: 0x170078DC RID: 30940
		// (get) Token: 0x06018F9C RID: 102300 RVA: 0x0038FC15 File Offset: 0x0038DE15
		// (set) Token: 0x06018F9D RID: 102301 RVA: 0x0038FC1D File Offset: 0x0038DE1D
		public int _Selected { get; set; }

		// Token: 0x170078DD RID: 30941
		// (get) Token: 0x06018F9E RID: 102302 RVA: 0x0038FC26 File Offset: 0x0038DE26
		// (set) Token: 0x06018F9F RID: 102303 RVA: 0x0038FC2E File Offset: 0x0038DE2E
		public bool _IsSelectBt { get; set; }

		// Token: 0x170078DE RID: 30942
		// (get) Token: 0x06018FA0 RID: 102304 RVA: 0x0038FC37 File Offset: 0x0038DE37
		// (set) Token: 0x06018FA1 RID: 102305 RVA: 0x0038FC3F File Offset: 0x0038DE3F
		public List<ISyncBlockGroupT> _SyncBlockGroups { get; set; }

		// Token: 0x170078DF RID: 30943
		// (get) Token: 0x06018FA2 RID: 102306 RVA: 0x0038FC48 File Offset: 0x0038DE48
		// (set) Token: 0x06018FA3 RID: 102307 RVA: 0x0038FC50 File Offset: 0x0038DE50
		public byte NullMask { get; set; }

		// Token: 0x06018FA4 RID: 102308 RVA: 0x0038FC59 File Offset: 0x0038DE59
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

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200611D RID: 24861
	public class IAddBuffToEntityT
	{
		// Token: 0x1700B736 RID: 46902
		// (get) Token: 0x0602A7C3 RID: 174019 RVA: 0x005D9F9D File Offset: 0x005D819D
		// (set) Token: 0x0602A7C4 RID: 174020 RVA: 0x005D9FA5 File Offset: 0x005D81A5
		public int EntityId { get; set; }

		// Token: 0x1700B737 RID: 46903
		// (get) Token: 0x0602A7C5 RID: 174021 RVA: 0x005D9FAE File Offset: 0x005D81AE
		// (set) Token: 0x0602A7C6 RID: 174022 RVA: 0x005D9FB6 File Offset: 0x005D81B6
		public List<int> EntityIds { get; set; }

		// Token: 0x1700B738 RID: 46904
		// (get) Token: 0x0602A7C7 RID: 174023 RVA: 0x005D9FBF File Offset: 0x005D81BF
		// (set) Token: 0x0602A7C8 RID: 174024 RVA: 0x005D9FC7 File Offset: 0x005D81C7
		public List<long> BuffIds { get; set; }

		// Token: 0x1700B739 RID: 46905
		// (get) Token: 0x0602A7C9 RID: 174025 RVA: 0x005D9FD0 File Offset: 0x005D81D0
		// (set) Token: 0x0602A7CA RID: 174026 RVA: 0x005D9FD8 File Offset: 0x005D81D8
		public List<long> PersistOnOfflineBuffIds { get; set; }

		// Token: 0x1700B73A RID: 46906
		// (get) Token: 0x0602A7CB RID: 174027 RVA: 0x005D9FE1 File Offset: 0x005D81E1
		// (set) Token: 0x0602A7CC RID: 174028 RVA: 0x005D9FE9 File Offset: 0x005D81E9
		public byte NullMask { get; set; }

		// Token: 0x0602A7CD RID: 174029 RVA: 0x005D9FF2 File Offset: 0x005D81F2
		public IAddBuffToEntityT()
		{
			this.EntityId = 0;
			this.EntityIds = null;
			this.BuffIds = null;
			this.PersistOnOfflineBuffIds = null;
			this.NullMask = 0;
		}
	}
}

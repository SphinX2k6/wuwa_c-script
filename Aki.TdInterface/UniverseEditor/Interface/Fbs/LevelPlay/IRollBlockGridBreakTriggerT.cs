using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049CC RID: 18892
	public class IRollBlockGridBreakTriggerT
	{
		// Token: 0x1700844C RID: 33868
		// (get) Token: 0x0601C40E RID: 115726 RVA: 0x003FD775 File Offset: 0x003FB975
		// (set) Token: 0x0601C40F RID: 115727 RVA: 0x003FD77D File Offset: 0x003FB97D
		public ERollBlockGridType Type { get; set; }

		// Token: 0x1700844D RID: 33869
		// (get) Token: 0x0601C410 RID: 115728 RVA: 0x003FD786 File Offset: 0x003FB986
		// (set) Token: 0x0601C411 RID: 115729 RVA: 0x003FD78E File Offset: 0x003FB98E
		public TRollBlockUnion Block { get; set; }

		// Token: 0x1700844E RID: 33870
		// (get) Token: 0x0601C412 RID: 115730 RVA: 0x003FD797 File Offset: 0x003FB997
		// (set) Token: 0x0601C413 RID: 115731 RVA: 0x003FD79F File Offset: 0x003FB99F
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x1700844F RID: 33871
		// (get) Token: 0x0601C414 RID: 115732 RVA: 0x003FD7A8 File Offset: 0x003FB9A8
		// (set) Token: 0x0601C415 RID: 115733 RVA: 0x003FD7B0 File Offset: 0x003FB9B0
		public int Key { get; set; }

		// Token: 0x17008450 RID: 33872
		// (get) Token: 0x0601C416 RID: 115734 RVA: 0x003FD7B9 File Offset: 0x003FB9B9
		// (set) Token: 0x0601C417 RID: 115735 RVA: 0x003FD7C1 File Offset: 0x003FB9C1
		public byte NullMask { get; set; }

		// Token: 0x0601C418 RID: 115736 RVA: 0x003FD7CA File Offset: 0x003FB9CA
		public IRollBlockGridBreakTriggerT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.Key = 0;
			this.NullMask = 0;
		}
	}
}

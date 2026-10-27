using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007602 RID: 30210
	public class IWaitUntilLevelSequenceReachMarkT
	{
		// Token: 0x1700E57D RID: 58749
		// (get) Token: 0x06037084 RID: 225412 RVA: 0x007775B7 File Offset: 0x007757B7
		// (set) Token: 0x06037085 RID: 225413 RVA: 0x007775BF File Offset: 0x007757BF
		public int EntityId { get; set; }

		// Token: 0x1700E57E RID: 58750
		// (get) Token: 0x06037086 RID: 225414 RVA: 0x007775C8 File Offset: 0x007757C8
		// (set) Token: 0x06037087 RID: 225415 RVA: 0x007775D0 File Offset: 0x007757D0
		public string Mark { get; set; }

		// Token: 0x06037088 RID: 225416 RVA: 0x007775D9 File Offset: 0x007757D9
		public IWaitUntilLevelSequenceReachMarkT()
		{
			this.EntityId = 0;
			this.Mark = null;
		}
	}
}

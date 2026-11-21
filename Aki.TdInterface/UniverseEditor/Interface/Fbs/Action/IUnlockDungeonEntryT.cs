using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CCC RID: 31948
	public class IUnlockDungeonEntryT
	{
		// Token: 0x1700EF24 RID: 61220
		// (get) Token: 0x06039A18 RID: 236056 RVA: 0x007C682A File Offset: 0x007C4A2A
		// (set) Token: 0x06039A19 RID: 236057 RVA: 0x007C6832 File Offset: 0x007C4A32
		public int DungeonEntryId { get; set; }

		// Token: 0x06039A1A RID: 236058 RVA: 0x007C683B File Offset: 0x007C4A3B
		public IUnlockDungeonEntryT()
		{
			this.DungeonEntryId = 0;
		}
	}
}

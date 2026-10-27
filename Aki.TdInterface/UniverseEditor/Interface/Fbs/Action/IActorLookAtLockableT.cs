using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060E1 RID: 24801
	public class IActorLookAtLockableT
	{
		// Token: 0x1700B6C6 RID: 46790
		// (get) Token: 0x0602A5D2 RID: 173522 RVA: 0x005D695A File Offset: 0x005D4B5A
		// (set) Token: 0x0602A5D3 RID: 173523 RVA: 0x005D6962 File Offset: 0x005D4B62
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700B6C7 RID: 46791
		// (get) Token: 0x0602A5D4 RID: 173524 RVA: 0x005D696B File Offset: 0x005D4B6B
		// (set) Token: 0x0602A5D5 RID: 173525 RVA: 0x005D6973 File Offset: 0x005D4B73
		public bool Lock { get; set; }

		// Token: 0x1700B6C8 RID: 46792
		// (get) Token: 0x0602A5D6 RID: 173526 RVA: 0x005D697C File Offset: 0x005D4B7C
		// (set) Token: 0x0602A5D7 RID: 173527 RVA: 0x005D6984 File Offset: 0x005D4B84
		public byte NullMask { get; set; }

		// Token: 0x0602A5D8 RID: 173528 RVA: 0x005D698D File Offset: 0x005D4B8D
		public IActorLookAtLockableT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.NullMask = 0;
		}
	}
}

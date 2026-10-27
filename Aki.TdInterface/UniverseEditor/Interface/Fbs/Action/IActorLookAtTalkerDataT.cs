using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060ED RID: 24813
	public class IActorLookAtTalkerDataT
	{
		// Token: 0x1700B6E6 RID: 46822
		// (get) Token: 0x0602A642 RID: 173634 RVA: 0x005D7542 File Offset: 0x005D5742
		// (set) Token: 0x0602A643 RID: 173635 RVA: 0x005D754A File Offset: 0x005D574A
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700B6E7 RID: 46823
		// (get) Token: 0x0602A644 RID: 173636 RVA: 0x005D7553 File Offset: 0x005D5753
		// (set) Token: 0x0602A645 RID: 173637 RVA: 0x005D755B File Offset: 0x005D575B
		public bool Lock { get; set; }

		// Token: 0x1700B6E8 RID: 46824
		// (get) Token: 0x0602A646 RID: 173638 RVA: 0x005D7564 File Offset: 0x005D5764
		// (set) Token: 0x0602A647 RID: 173639 RVA: 0x005D756C File Offset: 0x005D576C
		public byte NullMask { get; set; }

		// Token: 0x0602A648 RID: 173640 RVA: 0x005D7575 File Offset: 0x005D5775
		public IActorLookAtTalkerDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.NullMask = 0;
		}
	}
}

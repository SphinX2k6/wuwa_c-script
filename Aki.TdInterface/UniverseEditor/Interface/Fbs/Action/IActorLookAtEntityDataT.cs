using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060DE RID: 24798
	public class IActorLookAtEntityDataT
	{
		// Token: 0x1700B6BE RID: 46782
		// (get) Token: 0x0602A5B6 RID: 173494 RVA: 0x005D66A0 File Offset: 0x005D48A0
		// (set) Token: 0x0602A5B7 RID: 173495 RVA: 0x005D66A8 File Offset: 0x005D48A8
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700B6BF RID: 46783
		// (get) Token: 0x0602A5B8 RID: 173496 RVA: 0x005D66B1 File Offset: 0x005D48B1
		// (set) Token: 0x0602A5B9 RID: 173497 RVA: 0x005D66B9 File Offset: 0x005D48B9
		public bool Lock { get; set; }

		// Token: 0x1700B6C0 RID: 46784
		// (get) Token: 0x0602A5BA RID: 173498 RVA: 0x005D66C2 File Offset: 0x005D48C2
		// (set) Token: 0x0602A5BB RID: 173499 RVA: 0x005D66CA File Offset: 0x005D48CA
		public int EntityId { get; set; }

		// Token: 0x1700B6C1 RID: 46785
		// (get) Token: 0x0602A5BC RID: 173500 RVA: 0x005D66D3 File Offset: 0x005D48D3
		// (set) Token: 0x0602A5BD RID: 173501 RVA: 0x005D66DB File Offset: 0x005D48DB
		public byte NullMask { get; set; }

		// Token: 0x0602A5BE RID: 173502 RVA: 0x005D66E4 File Offset: 0x005D48E4
		public IActorLookAtEntityDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}

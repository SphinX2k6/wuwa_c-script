using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060E4 RID: 24804
	public class IActorLookAtOtherActorT
	{
		// Token: 0x1700B6CE RID: 46798
		// (get) Token: 0x0602A5EE RID: 173550 RVA: 0x005D6C50 File Offset: 0x005D4E50
		// (set) Token: 0x0602A5EF RID: 173551 RVA: 0x005D6C58 File Offset: 0x005D4E58
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700B6CF RID: 46799
		// (get) Token: 0x0602A5F0 RID: 173552 RVA: 0x005D6C61 File Offset: 0x005D4E61
		// (set) Token: 0x0602A5F1 RID: 173553 RVA: 0x005D6C69 File Offset: 0x005D4E69
		public bool Lock { get; set; }

		// Token: 0x1700B6D0 RID: 46800
		// (get) Token: 0x0602A5F2 RID: 173554 RVA: 0x005D6C72 File Offset: 0x005D4E72
		// (set) Token: 0x0602A5F3 RID: 173555 RVA: 0x005D6C7A File Offset: 0x005D4E7A
		public int ActorIndex { get; set; }

		// Token: 0x1700B6D1 RID: 46801
		// (get) Token: 0x0602A5F4 RID: 173556 RVA: 0x005D6C83 File Offset: 0x005D4E83
		// (set) Token: 0x0602A5F5 RID: 173557 RVA: 0x005D6C8B File Offset: 0x005D4E8B
		public byte NullMask { get; set; }

		// Token: 0x0602A5F6 RID: 173558 RVA: 0x005D6C94 File Offset: 0x005D4E94
		public IActorLookAtOtherActorT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.ActorIndex = 0;
			this.NullMask = 0;
		}
	}
}

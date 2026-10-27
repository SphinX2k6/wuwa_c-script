using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F0 RID: 24816
	public class IActorLookAtUnLockT
	{
		// Token: 0x1700B6EB RID: 46827
		// (get) Token: 0x0602A658 RID: 173656 RVA: 0x005D7712 File Offset: 0x005D5912
		// (set) Token: 0x0602A659 RID: 173657 RVA: 0x005D771A File Offset: 0x005D591A
		public EActorLookAtMode Type { get; set; }

		// Token: 0x0602A65A RID: 173658 RVA: 0x005D7723 File Offset: 0x005D5923
		public IActorLookAtUnLockT()
		{
			this.Type = EActorLookAtMode.Talker;
		}
	}
}

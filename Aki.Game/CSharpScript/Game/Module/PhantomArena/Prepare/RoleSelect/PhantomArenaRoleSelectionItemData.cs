using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.RoleSelect
{
	// Token: 0x02004121 RID: 16673
	public class PhantomArenaRoleSelectionItemData : IPhantomArenaRoleSelectionItemData
	{
		// Token: 0x170054C5 RID: 21701
		// (get) Token: 0x0602A27E RID: 172670 RVA: 0x00BE6ED2 File Offset: 0x00BE50D2
		// (set) Token: 0x0602A27F RID: 172671 RVA: 0x00BE6EDA File Offset: 0x00BE50DA
		public int CardRoleId { get; set; }

		// Token: 0x170054C6 RID: 21702
		// (get) Token: 0x0602A280 RID: 172672 RVA: 0x00BE6EE3 File Offset: 0x00BE50E3
		// (set) Token: 0x0602A281 RID: 172673 RVA: 0x00BE6EEB File Offset: 0x00BE50EB
		public bool CanReceived { get; set; }

		// Token: 0x170054C7 RID: 21703
		// (get) Token: 0x0602A282 RID: 172674 RVA: 0x00BE6EF4 File Offset: 0x00BE50F4
		// (set) Token: 0x0602A283 RID: 172675 RVA: 0x00BE6EFC File Offset: 0x00BE50FC
		public bool IsLocked { get; set; }

		// Token: 0x170054C8 RID: 21704
		// (get) Token: 0x0602A284 RID: 172676 RVA: 0x00BE6F05 File Offset: 0x00BE5105
		// (set) Token: 0x0602A285 RID: 172677 RVA: 0x00BE6F0D File Offset: 0x00BE510D
		public bool CanSelect { get; set; }
	}
}

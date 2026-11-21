using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.RoleSelect
{
	// Token: 0x02004120 RID: 16672
	public interface IPhantomArenaRoleSelectionItemData
	{
		// Token: 0x170054C1 RID: 21697
		// (get) Token: 0x0602A276 RID: 172662
		// (set) Token: 0x0602A277 RID: 172663
		int CardRoleId { get; set; }

		// Token: 0x170054C2 RID: 21698
		// (get) Token: 0x0602A278 RID: 172664
		// (set) Token: 0x0602A279 RID: 172665
		bool CanReceived { get; set; }

		// Token: 0x170054C3 RID: 21699
		// (get) Token: 0x0602A27A RID: 172666
		// (set) Token: 0x0602A27B RID: 172667
		bool IsLocked { get; set; }

		// Token: 0x170054C4 RID: 21700
		// (get) Token: 0x0602A27C RID: 172668
		// (set) Token: 0x0602A27D RID: 172669
		bool CanSelect { get; set; }
	}
}

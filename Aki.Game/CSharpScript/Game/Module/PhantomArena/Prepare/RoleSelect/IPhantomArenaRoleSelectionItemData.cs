using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.RoleSelect
{
	// Token: 0x02005150 RID: 20816
	public interface IPhantomArenaRoleSelectionItemData
	{
		// Token: 0x17008101 RID: 33025
		// (get) Token: 0x0603537A RID: 217978
		// (set) Token: 0x0603537B RID: 217979
		int CardRoleId { get; set; }

		// Token: 0x17008102 RID: 33026
		// (get) Token: 0x0603537C RID: 217980
		// (set) Token: 0x0603537D RID: 217981
		bool CanReceived { get; set; }

		// Token: 0x17008103 RID: 33027
		// (get) Token: 0x0603537E RID: 217982
		// (set) Token: 0x0603537F RID: 217983
		bool IsLocked { get; set; }

		// Token: 0x17008104 RID: 33028
		// (get) Token: 0x06035380 RID: 217984
		// (set) Token: 0x06035381 RID: 217985
		bool CanSelect { get; set; }
	}
}

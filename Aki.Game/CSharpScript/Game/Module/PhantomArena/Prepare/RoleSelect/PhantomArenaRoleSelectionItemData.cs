using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.RoleSelect
{
	// Token: 0x02005151 RID: 20817
	public class PhantomArenaRoleSelectionItemData : IPhantomArenaRoleSelectionItemData
	{
		// Token: 0x17008105 RID: 33029
		// (get) Token: 0x06035382 RID: 217986 RVA: 0x00C999D2 File Offset: 0x00C97BD2
		// (set) Token: 0x06035383 RID: 217987 RVA: 0x00C999DA File Offset: 0x00C97BDA
		public int CardRoleId { get; set; }

		// Token: 0x17008106 RID: 33030
		// (get) Token: 0x06035384 RID: 217988 RVA: 0x00C999E3 File Offset: 0x00C97BE3
		// (set) Token: 0x06035385 RID: 217989 RVA: 0x00C999EB File Offset: 0x00C97BEB
		public bool CanReceived { get; set; }

		// Token: 0x17008107 RID: 33031
		// (get) Token: 0x06035386 RID: 217990 RVA: 0x00C999F4 File Offset: 0x00C97BF4
		// (set) Token: 0x06035387 RID: 217991 RVA: 0x00C999FC File Offset: 0x00C97BFC
		public bool IsLocked { get; set; }

		// Token: 0x17008108 RID: 33032
		// (get) Token: 0x06035388 RID: 217992 RVA: 0x00C99A05 File Offset: 0x00C97C05
		// (set) Token: 0x06035389 RID: 217993 RVA: 0x00C99A0D File Offset: 0x00C97C0D
		public bool CanSelect { get; set; }
	}
}

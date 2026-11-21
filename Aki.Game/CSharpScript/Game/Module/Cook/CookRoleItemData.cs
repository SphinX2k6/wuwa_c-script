using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AEB RID: 19179
	[NullableContext(1)]
	[Nullable(0)]
	public class CookRoleItemData : ICookRoleItemData
	{
		// Token: 0x1700605A RID: 24666
		// (get) Token: 0x0602FF95 RID: 196501 RVA: 0x00D61E89 File Offset: 0x00D60089
		// (set) Token: 0x0602FF96 RID: 196502 RVA: 0x00D61E91 File Offset: 0x00D60091
		public int RoleId { get; set; }

		// Token: 0x1700605B RID: 24667
		// (get) Token: 0x0602FF97 RID: 196503 RVA: 0x00D61E9A File Offset: 0x00D6009A
		// (set) Token: 0x0602FF98 RID: 196504 RVA: 0x00D61EA2 File Offset: 0x00D600A2
		public string RoleName { get; set; }

		// Token: 0x1700605C RID: 24668
		// (get) Token: 0x0602FF99 RID: 196505 RVA: 0x00D61EAB File Offset: 0x00D600AB
		// (set) Token: 0x0602FF9A RID: 196506 RVA: 0x00D61EB3 File Offset: 0x00D600B3
		public string RoleIcon { get; set; }

		// Token: 0x1700605D RID: 24669
		// (get) Token: 0x0602FF9B RID: 196507 RVA: 0x00D61EBC File Offset: 0x00D600BC
		// (set) Token: 0x0602FF9C RID: 196508 RVA: 0x00D61EC4 File Offset: 0x00D600C4
		public bool IsBuff { get; set; }

		// Token: 0x1700605E RID: 24670
		// (get) Token: 0x0602FF9D RID: 196509 RVA: 0x00D61ECD File Offset: 0x00D600CD
		// (set) Token: 0x0602FF9E RID: 196510 RVA: 0x00D61ED5 File Offset: 0x00D600D5
		public int ItemId { get; set; }
	}
}

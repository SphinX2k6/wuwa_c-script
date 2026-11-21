using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004664 RID: 18020
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonRoleItemData
	{
		// Token: 0x17005B45 RID: 23365
		// (get) Token: 0x0602D51C RID: 185628 RVA: 0x00CB0B66 File Offset: 0x00CAED66
		// (set) Token: 0x0602D51D RID: 185629 RVA: 0x00CB0B6E File Offset: 0x00CAED6E
		public int RoleId { get; set; }

		// Token: 0x17005B46 RID: 23366
		// (get) Token: 0x0602D51E RID: 185630 RVA: 0x00CB0B77 File Offset: 0x00CAED77
		// (set) Token: 0x0602D51F RID: 185631 RVA: 0x00CB0B7F File Offset: 0x00CAED7F
		public string RoleName { get; set; } = string.Empty;

		// Token: 0x17005B47 RID: 23367
		// (get) Token: 0x0602D520 RID: 185632 RVA: 0x00CB0B88 File Offset: 0x00CAED88
		// (set) Token: 0x0602D521 RID: 185633 RVA: 0x00CB0B90 File Offset: 0x00CAED90
		public string RoleIcon { get; set; } = string.Empty;

		// Token: 0x17005B48 RID: 23368
		// (get) Token: 0x0602D522 RID: 185634 RVA: 0x00CB0B99 File Offset: 0x00CAED99
		// (set) Token: 0x0602D523 RID: 185635 RVA: 0x00CB0BA1 File Offset: 0x00CAEDA1
		public bool IsBuff { get; set; }

		// Token: 0x17005B49 RID: 23369
		// (get) Token: 0x0602D524 RID: 185636 RVA: 0x00CB0BAA File Offset: 0x00CAEDAA
		// (set) Token: 0x0602D525 RID: 185637 RVA: 0x00CB0BB2 File Offset: 0x00CAEDB2
		public int ItemId { get; set; }
	}
}

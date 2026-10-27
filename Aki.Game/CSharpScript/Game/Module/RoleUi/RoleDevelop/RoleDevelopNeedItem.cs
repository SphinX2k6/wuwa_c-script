using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D0F RID: 19727
	public class RoleDevelopNeedItem : IRoleDevelopNeedItem
	{
		// Token: 0x17007DE8 RID: 32232
		// (get) Token: 0x06032FD0 RID: 208848 RVA: 0x00BE1AA6 File Offset: 0x00BDFCA6
		// (set) Token: 0x06032FD1 RID: 208849 RVA: 0x00BE1AAE File Offset: 0x00BDFCAE
		public int ItemId { get; set; }

		// Token: 0x17007DE9 RID: 32233
		// (get) Token: 0x06032FD2 RID: 208850 RVA: 0x00BE1AB7 File Offset: 0x00BDFCB7
		// (set) Token: 0x06032FD3 RID: 208851 RVA: 0x00BE1ABF File Offset: 0x00BDFCBF
		public int Count { get; set; }

		// Token: 0x17007DEA RID: 32234
		// (get) Token: 0x06032FD4 RID: 208852 RVA: 0x00BE1AC8 File Offset: 0x00BDFCC8
		// (set) Token: 0x06032FD5 RID: 208853 RVA: 0x00BE1AD0 File Offset: 0x00BDFCD0
		public EItemMaterialType? Type { get; set; }
	}
}

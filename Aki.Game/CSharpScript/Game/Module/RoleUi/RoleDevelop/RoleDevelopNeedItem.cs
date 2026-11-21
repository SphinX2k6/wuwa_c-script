using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CC6 RID: 15558
	public class RoleDevelopNeedItem : IRoleDevelopNeedItem
	{
		// Token: 0x17005192 RID: 20882
		// (get) Token: 0x06027DAE RID: 163246 RVA: 0x00B273DC File Offset: 0x00B255DC
		// (set) Token: 0x06027DAF RID: 163247 RVA: 0x00B273E4 File Offset: 0x00B255E4
		public int ItemId { get; set; }

		// Token: 0x17005193 RID: 20883
		// (get) Token: 0x06027DB0 RID: 163248 RVA: 0x00B273ED File Offset: 0x00B255ED
		// (set) Token: 0x06027DB1 RID: 163249 RVA: 0x00B273F5 File Offset: 0x00B255F5
		public int Count { get; set; }

		// Token: 0x17005194 RID: 20884
		// (get) Token: 0x06027DB2 RID: 163250 RVA: 0x00B273FE File Offset: 0x00B255FE
		// (set) Token: 0x06027DB3 RID: 163251 RVA: 0x00B27406 File Offset: 0x00B25606
		public EItemMaterialType? Type { get; set; }
	}
}

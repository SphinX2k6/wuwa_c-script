using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B0A RID: 23306
	[NullableContext(1)]
	[Nullable(0)]
	public class CookRoleItemData : ICookRoleItemData
	{
		// Token: 0x17008C80 RID: 35968
		// (get) Token: 0x0603B023 RID: 241699 RVA: 0x00E11171 File Offset: 0x00E0F371
		// (set) Token: 0x0603B024 RID: 241700 RVA: 0x00E11179 File Offset: 0x00E0F379
		public int RoleId { get; set; }

		// Token: 0x17008C81 RID: 35969
		// (get) Token: 0x0603B025 RID: 241701 RVA: 0x00E11182 File Offset: 0x00E0F382
		// (set) Token: 0x0603B026 RID: 241702 RVA: 0x00E1118A File Offset: 0x00E0F38A
		public string RoleName { get; set; }

		// Token: 0x17008C82 RID: 35970
		// (get) Token: 0x0603B027 RID: 241703 RVA: 0x00E11193 File Offset: 0x00E0F393
		// (set) Token: 0x0603B028 RID: 241704 RVA: 0x00E1119B File Offset: 0x00E0F39B
		public string RoleIcon { get; set; }

		// Token: 0x17008C83 RID: 35971
		// (get) Token: 0x0603B029 RID: 241705 RVA: 0x00E111A4 File Offset: 0x00E0F3A4
		// (set) Token: 0x0603B02A RID: 241706 RVA: 0x00E111AC File Offset: 0x00E0F3AC
		public bool IsBuff { get; set; }

		// Token: 0x17008C84 RID: 35972
		// (get) Token: 0x0603B02B RID: 241707 RVA: 0x00E111B5 File Offset: 0x00E0F3B5
		// (set) Token: 0x0603B02C RID: 241708 RVA: 0x00E111BD File Offset: 0x00E0F3BD
		public int ItemId { get; set; }
	}
}

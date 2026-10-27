using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D03 RID: 19715
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevProsConfig : IRoleDevProsConfig
	{
		// Token: 0x17007DD6 RID: 32214
		// (get) Token: 0x06032FA9 RID: 208809 RVA: 0x00BE19BA File Offset: 0x00BDFBBA
		// (set) Token: 0x06032FAA RID: 208810 RVA: 0x00BE19C2 File Offset: 0x00BDFBC2
		public int Id { get; set; }

		// Token: 0x17007DD7 RID: 32215
		// (get) Token: 0x06032FAB RID: 208811 RVA: 0x00BE19CB File Offset: 0x00BDFBCB
		// (set) Token: 0x06032FAC RID: 208812 RVA: 0x00BE19D3 File Offset: 0x00BDFBD3
		public long ProspectBeginTime { get; set; }

		// Token: 0x17007DD8 RID: 32216
		// (get) Token: 0x06032FAD RID: 208813 RVA: 0x00BE19DC File Offset: 0x00BDFBDC
		// (set) Token: 0x06032FAE RID: 208814 RVA: 0x00BE19E4 File Offset: 0x00BDFBE4
		public long ProspectEndTime { get; set; }

		// Token: 0x17007DD9 RID: 32217
		// (get) Token: 0x06032FAF RID: 208815 RVA: 0x00BE19ED File Offset: 0x00BDFBED
		// (set) Token: 0x06032FB0 RID: 208816 RVA: 0x00BE19F5 File Offset: 0x00BDFBF5
		public int TypeId { get; set; }

		// Token: 0x17007DDA RID: 32218
		// (get) Token: 0x06032FB1 RID: 208817 RVA: 0x00BE19FE File Offset: 0x00BDFBFE
		// (set) Token: 0x06032FB2 RID: 208818 RVA: 0x00BE1A06 File Offset: 0x00BDFC06
		public int GachaId { get; set; }

		// Token: 0x17007DDB RID: 32219
		// (get) Token: 0x06032FB3 RID: 208819 RVA: 0x00BE1A0F File Offset: 0x00BDFC0F
		// (set) Token: 0x06032FB4 RID: 208820 RVA: 0x00BE1A17 File Offset: 0x00BDFC17
		public List<IRoleDevProsSpecialGachaConfig> SpecialGachaId { get; set; } = new List<IRoleDevProsSpecialGachaConfig>();

		// Token: 0x17007DDC RID: 32220
		// (get) Token: 0x06032FB5 RID: 208821 RVA: 0x00BE1A20 File Offset: 0x00BDFC20
		// (set) Token: 0x06032FB6 RID: 208822 RVA: 0x00BE1A28 File Offset: 0x00BDFC28
		public int SortId { get; set; }
	}
}

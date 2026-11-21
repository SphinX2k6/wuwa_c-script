using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CB4 RID: 15540
	[NullableContext(1)]
	public interface IRoleDevProsConfig
	{
		// Token: 0x17005179 RID: 20857
		// (get) Token: 0x06027D76 RID: 163190
		// (set) Token: 0x06027D77 RID: 163191
		int Id { get; set; }

		// Token: 0x1700517A RID: 20858
		// (get) Token: 0x06027D78 RID: 163192
		// (set) Token: 0x06027D79 RID: 163193
		long ProspectBeginTime { get; set; }

		// Token: 0x1700517B RID: 20859
		// (get) Token: 0x06027D7A RID: 163194
		// (set) Token: 0x06027D7B RID: 163195
		long ProspectEndTime { get; set; }

		// Token: 0x1700517C RID: 20860
		// (get) Token: 0x06027D7C RID: 163196
		// (set) Token: 0x06027D7D RID: 163197
		int TypeId { get; set; }

		// Token: 0x1700517D RID: 20861
		// (get) Token: 0x06027D7E RID: 163198
		// (set) Token: 0x06027D7F RID: 163199
		int GachaId { get; set; }

		// Token: 0x1700517E RID: 20862
		// (get) Token: 0x06027D80 RID: 163200
		// (set) Token: 0x06027D81 RID: 163201
		List<IRoleDevProsSpecialGachaConfig> SpecialGachaId { get; set; }

		// Token: 0x1700517F RID: 20863
		// (get) Token: 0x06027D82 RID: 163202
		// (set) Token: 0x06027D83 RID: 163203
		int SortId { get; set; }
	}
}

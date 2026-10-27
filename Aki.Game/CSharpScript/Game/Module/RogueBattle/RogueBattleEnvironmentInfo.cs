using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ED7 RID: 20183
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleEnvironmentInfo : IRogueBattleEnvironmentInfo
	{
		// Token: 0x17007F22 RID: 32546
		// (get) Token: 0x06033CDC RID: 212188 RVA: 0x00C210B8 File Offset: 0x00C1F2B8
		// (set) Token: 0x06033CDD RID: 212189 RVA: 0x00C210C0 File Offset: 0x00C1F2C0
		public string Icon { get; set; } = string.Empty;

		// Token: 0x17007F23 RID: 32547
		// (get) Token: 0x06033CDE RID: 212190 RVA: 0x00C210C9 File Offset: 0x00C1F2C9
		// (set) Token: 0x06033CDF RID: 212191 RVA: 0x00C210D1 File Offset: 0x00C1F2D1
		public string TextId { get; set; } = string.Empty;

		// Token: 0x17007F24 RID: 32548
		// (get) Token: 0x06033CE0 RID: 212192 RVA: 0x00C210DA File Offset: 0x00C1F2DA
		// (set) Token: 0x06033CE1 RID: 212193 RVA: 0x00C210E2 File Offset: 0x00C1F2E2
		public List<string> Param { get; set; } = new List<string>();
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A0 RID: 18336
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreTargetReachedData : IRewardExploreTargetReached
	{
		// Token: 0x17005D67 RID: 23911
		// (get) Token: 0x0602E156 RID: 188758 RVA: 0x00CDEEB2 File Offset: 0x00CDD0B2
		// (set) Token: 0x0602E157 RID: 188759 RVA: 0x00CDEEBA File Offset: 0x00CDD0BA
		public List<string> Target { get; set; }

		// Token: 0x17005D68 RID: 23912
		// (get) Token: 0x0602E158 RID: 188760 RVA: 0x00CDEEC3 File Offset: 0x00CDD0C3
		// (set) Token: 0x0602E159 RID: 188761 RVA: 0x00CDEECB File Offset: 0x00CDD0CB
		public string DescriptionTextId { get; set; }

		// Token: 0x17005D69 RID: 23913
		// (get) Token: 0x0602E15A RID: 188762 RVA: 0x00CDEED4 File Offset: 0x00CDD0D4
		// (set) Token: 0x0602E15B RID: 188763 RVA: 0x00CDEEDC File Offset: 0x00CDD0DC
		public bool IsReached { get; set; }
	}
}

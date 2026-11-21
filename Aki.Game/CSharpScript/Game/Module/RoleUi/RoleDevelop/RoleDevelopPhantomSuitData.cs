using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CD1 RID: 15569
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopPhantomSuitData : IRoleDevelopPhantomSuitData
	{
		// Token: 0x170051B2 RID: 20914
		// (get) Token: 0x06027DF3 RID: 163315 RVA: 0x00B27503 File Offset: 0x00B25703
		// (set) Token: 0x06027DF4 RID: 163316 RVA: 0x00B2750B File Offset: 0x00B2570B
		public int DevelopRoleId { get; set; }

		// Token: 0x170051B3 RID: 20915
		// (get) Token: 0x06027DF5 RID: 163317 RVA: 0x00B27514 File Offset: 0x00B25714
		// (set) Token: 0x06027DF6 RID: 163318 RVA: 0x00B2751C File Offset: 0x00B2571C
		public int FetterGroupId { get; set; }

		// Token: 0x170051B4 RID: 20916
		// (get) Token: 0x06027DF7 RID: 163319 RVA: 0x00B27525 File Offset: 0x00B25725
		// (set) Token: 0x06027DF8 RID: 163320 RVA: 0x00B2752D File Offset: 0x00B2572D
		public VisionFetterRecommendInfo VisionFetterRecommendInfo { get; set; }

		// Token: 0x170051B5 RID: 20917
		// (get) Token: 0x06027DF9 RID: 163321 RVA: 0x00B27536 File Offset: 0x00B25736
		// (set) Token: 0x06027DFA RID: 163322 RVA: 0x00B2753E File Offset: 0x00B2573E
		public int? FirstVisionMonsterId { get; set; }

		// Token: 0x170051B6 RID: 20918
		// (get) Token: 0x06027DFB RID: 163323 RVA: 0x00B27547 File Offset: 0x00B25747
		// (set) Token: 0x06027DFC RID: 163324 RVA: 0x00B2754F File Offset: 0x00B2574F
		public bool? IsNeedFetterButton { get; set; }
	}
}

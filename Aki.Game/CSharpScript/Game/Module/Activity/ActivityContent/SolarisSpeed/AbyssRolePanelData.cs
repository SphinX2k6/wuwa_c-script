using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005043 RID: 20547
	[NullableContext(1)]
	[Nullable(0)]
	public class AbyssRolePanelData : SolarSpeedRolePanelData, IAbyssRolePanelData, ISolarSpeedRolePanelData
	{
		// Token: 0x17006481 RID: 25729
		// (get) Token: 0x060336EA RID: 210666 RVA: 0x00E67522 File Offset: 0x00E65722
		// (set) Token: 0x060336EB RID: 210667 RVA: 0x00E6752A File Offset: 0x00E6572A
		public List<IAbyssDescData> MainDescData { get; set; }

		// Token: 0x17006482 RID: 25730
		// (get) Token: 0x060336EC RID: 210668 RVA: 0x00E67533 File Offset: 0x00E65733
		// (set) Token: 0x060336ED RID: 210669 RVA: 0x00E6753B File Offset: 0x00E6573B
		public List<IAbyssDescData> SubDescData { get; set; }

		// Token: 0x17006483 RID: 25731
		// (get) Token: 0x060336EE RID: 210670 RVA: 0x00E67544 File Offset: 0x00E65744
		// (set) Token: 0x060336EF RID: 210671 RVA: 0x00E6754C File Offset: 0x00E6574C
		public int LikeCount { get; set; }

		// Token: 0x17006484 RID: 25732
		// (get) Token: 0x060336F0 RID: 210672 RVA: 0x00E67555 File Offset: 0x00E65755
		// (set) Token: 0x060336F1 RID: 210673 RVA: 0x00E6755D File Offset: 0x00E6575D
		public int? PlayerTitle { get; set; }

		// Token: 0x17006485 RID: 25733
		// (get) Token: 0x060336F2 RID: 210674 RVA: 0x00E67566 File Offset: 0x00E65766
		// (set) Token: 0x060336F3 RID: 210675 RVA: 0x00E6756E File Offset: 0x00E6576E
		public int? PlayerTitleStarLevel { get; set; }

		// Token: 0x17006486 RID: 25734
		// (get) Token: 0x060336F4 RID: 210676 RVA: 0x00E67577 File Offset: 0x00E65777
		// (set) Token: 0x060336F5 RID: 210677 RVA: 0x00E6757F File Offset: 0x00E6577F
		public int Sex { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005037 RID: 20535
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedResultViewData : ISolarSpeedResultViewData
	{
		// Token: 0x17006449 RID: 25673
		// (get) Token: 0x06033674 RID: 210548 RVA: 0x00E67327 File Offset: 0x00E65527
		// (set) Token: 0x06033675 RID: 210549 RVA: 0x00E6732F File Offset: 0x00E6552F
		[Nullable(2)]
		public string TitleId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700644A RID: 25674
		// (get) Token: 0x06033676 RID: 210550 RVA: 0x00E67338 File Offset: 0x00E65538
		// (set) Token: 0x06033677 RID: 210551 RVA: 0x00E67340 File Offset: 0x00E65540
		public List<ISolarSpeedRolePanelData> RoleDataList { get; set; }

		// Token: 0x1700644B RID: 25675
		// (get) Token: 0x06033678 RID: 210552 RVA: 0x00E67349 File Offset: 0x00E65549
		// (set) Token: 0x06033679 RID: 210553 RVA: 0x00E67351 File Offset: 0x00E65551
		public Func<SolarSpeedRolePanelBase> PanelType { get; set; }

		// Token: 0x1700644C RID: 25676
		// (get) Token: 0x0603367A RID: 210554 RVA: 0x00E6735A File Offset: 0x00E6555A
		// (set) Token: 0x0603367B RID: 210555 RVA: 0x00E67362 File Offset: 0x00E65562
		public Action ConfirmClick { get; set; }
	}
}

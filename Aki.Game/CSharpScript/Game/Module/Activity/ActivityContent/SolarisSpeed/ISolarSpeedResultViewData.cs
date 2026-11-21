using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005036 RID: 20534
	[NullableContext(1)]
	public interface ISolarSpeedResultViewData
	{
		// Token: 0x17006445 RID: 25669
		// (get) Token: 0x0603366C RID: 210540
		// (set) Token: 0x0603366D RID: 210541
		[Nullable(2)]
		string TitleId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006446 RID: 25670
		// (get) Token: 0x0603366E RID: 210542
		// (set) Token: 0x0603366F RID: 210543
		List<ISolarSpeedRolePanelData> RoleDataList { get; set; }

		// Token: 0x17006447 RID: 25671
		// (get) Token: 0x06033670 RID: 210544
		// (set) Token: 0x06033671 RID: 210545
		Func<SolarSpeedRolePanelBase> PanelType { get; set; }

		// Token: 0x17006448 RID: 25672
		// (get) Token: 0x06033672 RID: 210546
		// (set) Token: 0x06033673 RID: 210547
		Action ConfirmClick { get; set; }
	}
}

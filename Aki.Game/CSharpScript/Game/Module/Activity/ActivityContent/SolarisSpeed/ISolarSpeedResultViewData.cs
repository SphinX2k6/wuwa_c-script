using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B8 RID: 24760
	[NullableContext(1)]
	public interface ISolarSpeedResultViewData
	{
		// Token: 0x170090E3 RID: 37091
		// (get) Token: 0x0603E9A8 RID: 256424
		// (set) Token: 0x0603E9A9 RID: 256425
		[Nullable(2)]
		string TitleId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170090E4 RID: 37092
		// (get) Token: 0x0603E9AA RID: 256426
		// (set) Token: 0x0603E9AB RID: 256427
		List<ISolarSpeedRolePanelData> RoleDataList { get; set; }

		// Token: 0x170090E5 RID: 37093
		// (get) Token: 0x0603E9AC RID: 256428
		// (set) Token: 0x0603E9AD RID: 256429
		Func<SolarSpeedRolePanelBase> PanelType { get; set; }

		// Token: 0x170090E6 RID: 37094
		// (get) Token: 0x0603E9AE RID: 256430
		// (set) Token: 0x0603E9AF RID: 256431
		Action ConfirmClick { get; set; }
	}
}

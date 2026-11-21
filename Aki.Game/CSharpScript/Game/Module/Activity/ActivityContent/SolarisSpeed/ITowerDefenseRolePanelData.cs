using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x0200503A RID: 20538
	[NullableContext(1)]
	public interface ITowerDefenseRolePanelData : ISolarSpeedRolePanelData
	{
		// Token: 0x1700646D RID: 25709
		// (get) Token: 0x060336BE RID: 210622
		// (set) Token: 0x060336BF RID: 210623
		int BestTitle { get; set; }

		// Token: 0x1700646E RID: 25710
		// (get) Token: 0x060336C0 RID: 210624
		// (set) Token: 0x060336C1 RID: 210625
		List<ITowerDefenseRoleDescData> DescDataList { get; set; }
	}
}

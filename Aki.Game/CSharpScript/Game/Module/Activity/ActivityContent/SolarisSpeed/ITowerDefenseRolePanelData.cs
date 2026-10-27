using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060BC RID: 24764
	[NullableContext(1)]
	public interface ITowerDefenseRolePanelData : ISolarSpeedRolePanelData
	{
		// Token: 0x1700910B RID: 37131
		// (get) Token: 0x0603E9FA RID: 256506
		// (set) Token: 0x0603E9FB RID: 256507
		int BestTitle { get; set; }

		// Token: 0x1700910C RID: 37132
		// (get) Token: 0x0603E9FC RID: 256508
		// (set) Token: 0x0603E9FD RID: 256509
		List<ITowerDefenseRoleDescData> DescDataList { get; set; }
	}
}

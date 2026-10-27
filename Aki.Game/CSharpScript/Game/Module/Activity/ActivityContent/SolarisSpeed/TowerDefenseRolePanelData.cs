using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060BD RID: 24765
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRolePanelData : SolarSpeedRolePanelData, ITowerDefenseRolePanelData, ISolarSpeedRolePanelData
	{
		// Token: 0x1700910D RID: 37133
		// (get) Token: 0x0603E9FE RID: 256510 RVA: 0x00F206C7 File Offset: 0x00F1E8C7
		// (set) Token: 0x0603E9FF RID: 256511 RVA: 0x00F206CF File Offset: 0x00F1E8CF
		public int BestTitle { get; set; }

		// Token: 0x1700910E RID: 37134
		// (get) Token: 0x0603EA00 RID: 256512 RVA: 0x00F206D8 File Offset: 0x00F1E8D8
		// (set) Token: 0x0603EA01 RID: 256513 RVA: 0x00F206E0 File Offset: 0x00F1E8E0
		public List<ITowerDefenseRoleDescData> DescDataList { get; set; }
	}
}

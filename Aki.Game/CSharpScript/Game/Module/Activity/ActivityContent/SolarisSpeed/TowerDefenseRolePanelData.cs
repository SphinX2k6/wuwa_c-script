using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x0200503B RID: 20539
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRolePanelData : SolarSpeedRolePanelData, ITowerDefenseRolePanelData, ISolarSpeedRolePanelData
	{
		// Token: 0x1700646F RID: 25711
		// (get) Token: 0x060336C2 RID: 210626 RVA: 0x00E6748B File Offset: 0x00E6568B
		// (set) Token: 0x060336C3 RID: 210627 RVA: 0x00E67493 File Offset: 0x00E65693
		public int BestTitle { get; set; }

		// Token: 0x17006470 RID: 25712
		// (get) Token: 0x060336C4 RID: 210628 RVA: 0x00E6749C File Offset: 0x00E6569C
		// (set) Token: 0x060336C5 RID: 210629 RVA: 0x00E674A4 File Offset: 0x00E656A4
		public List<ITowerDefenseRoleDescData> DescDataList { get; set; }
	}
}

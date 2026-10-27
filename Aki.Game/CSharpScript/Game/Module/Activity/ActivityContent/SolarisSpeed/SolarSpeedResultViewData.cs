using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B9 RID: 24761
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedResultViewData : ISolarSpeedResultViewData
	{
		// Token: 0x170090E7 RID: 37095
		// (get) Token: 0x0603E9B0 RID: 256432 RVA: 0x00F20563 File Offset: 0x00F1E763
		// (set) Token: 0x0603E9B1 RID: 256433 RVA: 0x00F2056B File Offset: 0x00F1E76B
		[Nullable(2)]
		public string TitleId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170090E8 RID: 37096
		// (get) Token: 0x0603E9B2 RID: 256434 RVA: 0x00F20574 File Offset: 0x00F1E774
		// (set) Token: 0x0603E9B3 RID: 256435 RVA: 0x00F2057C File Offset: 0x00F1E77C
		public List<ISolarSpeedRolePanelData> RoleDataList { get; set; }

		// Token: 0x170090E9 RID: 37097
		// (get) Token: 0x0603E9B4 RID: 256436 RVA: 0x00F20585 File Offset: 0x00F1E785
		// (set) Token: 0x0603E9B5 RID: 256437 RVA: 0x00F2058D File Offset: 0x00F1E78D
		public Func<SolarSpeedRolePanelBase> PanelType { get; set; }

		// Token: 0x170090EA RID: 37098
		// (get) Token: 0x0603E9B6 RID: 256438 RVA: 0x00F20596 File Offset: 0x00F1E796
		// (set) Token: 0x0603E9B7 RID: 256439 RVA: 0x00F2059E File Offset: 0x00F1E79E
		public Action ConfirmClick { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005580 RID: 21888
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingHandBookDesData : IFishingHandBookDesData
	{
		// Token: 0x1700694C RID: 26956
		// (get) Token: 0x060363F1 RID: 222193 RVA: 0x00F20BEB File Offset: 0x00F1EDEB
		// (set) Token: 0x060363F2 RID: 222194 RVA: 0x00F20BF3 File Offset: 0x00F1EDF3
		public string DesText { get; set; }

		// Token: 0x1700694D RID: 26957
		// (get) Token: 0x060363F3 RID: 222195 RVA: 0x00F20BFC File Offset: 0x00F1EDFC
		// (set) Token: 0x060363F4 RID: 222196 RVA: 0x00F20C04 File Offset: 0x00F1EE04
		public string DataText { get; set; }

		// Token: 0x1700694E RID: 26958
		// (get) Token: 0x060363F5 RID: 222197 RVA: 0x00F20C0D File Offset: 0x00F1EE0D
		// (set) Token: 0x060363F6 RID: 222198 RVA: 0x00F20C15 File Offset: 0x00F1EE15
		public bool? IsGolden { get; set; }

		// Token: 0x1700694F RID: 26959
		// (get) Token: 0x060363F7 RID: 222199 RVA: 0x00F20C1E File Offset: 0x00F1EE1E
		// (set) Token: 0x060363F8 RID: 222200 RVA: 0x00F20C26 File Offset: 0x00F1EE26
		public bool? IsSliver { get; set; }

		// Token: 0x060363F9 RID: 222201 RVA: 0x00F20C2F File Offset: 0x00F1EE2F
		public FishingHandBookDesData()
		{
			this.DesText = "";
			this.DataText = "";
		}
	}
}

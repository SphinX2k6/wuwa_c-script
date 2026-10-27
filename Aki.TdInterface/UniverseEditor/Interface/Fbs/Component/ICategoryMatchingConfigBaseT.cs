using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F68 RID: 20328
	public class ICategoryMatchingConfigBaseT
	{
		// Token: 0x170092C7 RID: 37575
		// (get) Token: 0x060203E1 RID: 132065 RVA: 0x0047C922 File Offset: 0x0047AB22
		// (set) Token: 0x060203E2 RID: 132066 RVA: 0x0047C92A File Offset: 0x0047AB2A
		public ICategoryMatchingConditionT Condition { get; set; }

		// Token: 0x170092C8 RID: 37576
		// (get) Token: 0x060203E3 RID: 132067 RVA: 0x0047C933 File Offset: 0x0047AB33
		// (set) Token: 0x060203E4 RID: 132068 RVA: 0x0047C93B File Offset: 0x0047AB3B
		public ICategoryMatchingAnimationBaseT Animation { get; set; }

		// Token: 0x170092C9 RID: 37577
		// (get) Token: 0x060203E5 RID: 132069 RVA: 0x0047C944 File Offset: 0x0047AB44
		// (set) Token: 0x060203E6 RID: 132070 RVA: 0x0047C94C File Offset: 0x0047AB4C
		public ICategoryMatchingSucceedBaseT Callback { get; set; }

		// Token: 0x060203E7 RID: 132071 RVA: 0x0047C955 File Offset: 0x0047AB55
		public ICategoryMatchingConfigBaseT()
		{
			this.Condition = null;
			this.Animation = null;
			this.Callback = null;
		}
	}
}

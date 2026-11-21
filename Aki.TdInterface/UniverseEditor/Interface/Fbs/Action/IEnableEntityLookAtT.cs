using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCC RID: 27852
	public class IEnableEntityLookAtT
	{
		// Token: 0x1700CC47 RID: 52295
		// (get) Token: 0x06030018 RID: 196632 RVA: 0x00688663 File Offset: 0x00686863
		// (set) Token: 0x06030019 RID: 196633 RVA: 0x0068866B File Offset: 0x0068686B
		public string Key { get; set; }

		// Token: 0x1700CC48 RID: 52296
		// (get) Token: 0x0603001A RID: 196634 RVA: 0x00688674 File Offset: 0x00686874
		// (set) Token: 0x0603001B RID: 196635 RVA: 0x0068867C File Offset: 0x0068687C
		public TDefaultLookAtTypeUnion DefaultLookAtType { get; set; }

		// Token: 0x1700CC49 RID: 52297
		// (get) Token: 0x0603001C RID: 196636 RVA: 0x00688685 File Offset: 0x00686885
		// (set) Token: 0x0603001D RID: 196637 RVA: 0x0068868D File Offset: 0x0068688D
		public ICheckFlowLookAtT OverrideLookAtType { get; set; }

		// Token: 0x1700CC4A RID: 52298
		// (get) Token: 0x0603001E RID: 196638 RVA: 0x00688696 File Offset: 0x00686896
		// (set) Token: 0x0603001F RID: 196639 RVA: 0x0068869E File Offset: 0x0068689E
		public List<int> EntityIds { get; set; }

		// Token: 0x06030020 RID: 196640 RVA: 0x006886A7 File Offset: 0x006868A7
		public IEnableEntityLookAtT()
		{
			this.Key = null;
			this.DefaultLookAtType = null;
			this.OverrideLookAtType = null;
			this.EntityIds = null;
		}
	}
}

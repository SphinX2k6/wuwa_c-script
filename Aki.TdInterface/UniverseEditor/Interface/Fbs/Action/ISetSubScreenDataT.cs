using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007080 RID: 28800
	public class ISetSubScreenDataT
	{
		// Token: 0x1700D606 RID: 54790
		// (get) Token: 0x06032FE7 RID: 208871 RVA: 0x006E0E6A File Offset: 0x006DF06A
		// (set) Token: 0x06032FE8 RID: 208872 RVA: 0x006E0E72 File Offset: 0x006DF072
		public TScreenUnion TargetScreen { get; set; }

		// Token: 0x1700D607 RID: 54791
		// (get) Token: 0x06032FE9 RID: 208873 RVA: 0x006E0E7B File Offset: 0x006DF07B
		// (set) Token: 0x06032FEA RID: 208874 RVA: 0x006E0E83 File Offset: 0x006DF083
		public ISubScreenConfigT TargetSubScreenConfig { get; set; }

		// Token: 0x1700D608 RID: 54792
		// (get) Token: 0x06032FEB RID: 208875 RVA: 0x006E0E8C File Offset: 0x006DF08C
		// (set) Token: 0x06032FEC RID: 208876 RVA: 0x006E0E94 File Offset: 0x006DF094
		public ISubScreenTransitionT Transition { get; set; }

		// Token: 0x06032FED RID: 208877 RVA: 0x006E0E9D File Offset: 0x006DF09D
		public ISetSubScreenDataT()
		{
			this.TargetScreen = null;
			this.TargetSubScreenConfig = null;
			this.Transition = null;
		}
	}
}

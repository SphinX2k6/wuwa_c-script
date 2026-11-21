using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200456F RID: 17775
	public class IShowUiSyntheticT
	{
		// Token: 0x17007C3E RID: 31806
		// (get) Token: 0x06019E1F RID: 106015 RVA: 0x003B13C0 File Offset: 0x003AF5C0
		// (set) Token: 0x06019E20 RID: 106016 RVA: 0x003B13C8 File Offset: 0x003AF5C8
		public EShowUiType Type { get; set; }

		// Token: 0x17007C3F RID: 31807
		// (get) Token: 0x06019E21 RID: 106017 RVA: 0x003B13D1 File Offset: 0x003AF5D1
		// (set) Token: 0x06019E22 RID: 106018 RVA: 0x003B13D9 File Offset: 0x003AF5D9
		public List<int> EntityIds { get; set; }

		// Token: 0x17007C40 RID: 31808
		// (get) Token: 0x06019E23 RID: 106019 RVA: 0x003B13E2 File Offset: 0x003AF5E2
		// (set) Token: 0x06019E24 RID: 106020 RVA: 0x003B13EA File Offset: 0x003AF5EA
		public List<int> ProductIds { get; set; }

		// Token: 0x17007C41 RID: 31809
		// (get) Token: 0x06019E25 RID: 106021 RVA: 0x003B13F3 File Offset: 0x003AF5F3
		// (set) Token: 0x06019E26 RID: 106022 RVA: 0x003B13FB File Offset: 0x003AF5FB
		public byte NullMask { get; set; }

		// Token: 0x06019E27 RID: 106023 RVA: 0x003B1404 File Offset: 0x003AF604
		public IShowUiSyntheticT()
		{
			this.Type = EShowUiType.All;
			this.EntityIds = null;
			this.ProductIds = null;
			this.NullMask = 0;
		}
	}
}

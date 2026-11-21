using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061ED RID: 25069
	public class IWuWaGoSaveGridT
	{
		// Token: 0x1700BAF4 RID: 47860
		// (get) Token: 0x0602AA6D RID: 174701 RVA: 0x005D0F4F File Offset: 0x005CF14F
		// (set) Token: 0x0602AA6E RID: 174702 RVA: 0x005D0F57 File Offset: 0x005CF157
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700BAF5 RID: 47861
		// (get) Token: 0x0602AA6F RID: 174703 RVA: 0x005D0F60 File Offset: 0x005CF160
		// (set) Token: 0x0602AA70 RID: 174704 RVA: 0x005D0F68 File Offset: 0x005CF168
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x1700BAF6 RID: 47862
		// (get) Token: 0x0602AA71 RID: 174705 RVA: 0x005D0F71 File Offset: 0x005CF171
		// (set) Token: 0x0602AA72 RID: 174706 RVA: 0x005D0F79 File Offset: 0x005CF179
		public List<TWuWaGoHintStepUnion> HintSteps { get; set; }

		// Token: 0x1700BAF7 RID: 47863
		// (get) Token: 0x0602AA73 RID: 174707 RVA: 0x005D0F82 File Offset: 0x005CF182
		// (set) Token: 0x0602AA74 RID: 174708 RVA: 0x005D0F8A File Offset: 0x005CF18A
		public byte NullMask { get; set; }

		// Token: 0x0602AA75 RID: 174709 RVA: 0x005D0F93 File Offset: 0x005CF193
		public IWuWaGoSaveGridT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
			this.HintSteps = null;
			this.NullMask = 0;
		}
	}
}

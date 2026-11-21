using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061F3 RID: 25075
	public class IWuWaGoStartGridT
	{
		// Token: 0x1700BB03 RID: 47875
		// (get) Token: 0x0602AAB1 RID: 174769 RVA: 0x005D18C7 File Offset: 0x005CFAC7
		// (set) Token: 0x0602AAB2 RID: 174770 RVA: 0x005D18CF File Offset: 0x005CFACF
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700BB04 RID: 47876
		// (get) Token: 0x0602AAB3 RID: 174771 RVA: 0x005D18D8 File Offset: 0x005CFAD8
		// (set) Token: 0x0602AAB4 RID: 174772 RVA: 0x005D18E0 File Offset: 0x005CFAE0
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x1700BB05 RID: 47877
		// (get) Token: 0x0602AAB5 RID: 174773 RVA: 0x005D18E9 File Offset: 0x005CFAE9
		// (set) Token: 0x0602AAB6 RID: 174774 RVA: 0x005D18F1 File Offset: 0x005CFAF1
		public List<TWuWaGoHintStepUnion> HintSteps { get; set; }

		// Token: 0x1700BB06 RID: 47878
		// (get) Token: 0x0602AAB7 RID: 174775 RVA: 0x005D18FA File Offset: 0x005CFAFA
		// (set) Token: 0x0602AAB8 RID: 174776 RVA: 0x005D1902 File Offset: 0x005CFB02
		public byte NullMask { get; set; }

		// Token: 0x0602AAB9 RID: 174777 RVA: 0x005D190B File Offset: 0x005CFB0B
		public IWuWaGoStartGridT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
			this.HintSteps = null;
			this.NullMask = 0;
		}
	}
}

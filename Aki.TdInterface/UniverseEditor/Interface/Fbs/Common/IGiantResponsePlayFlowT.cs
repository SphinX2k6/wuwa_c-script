using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006402 RID: 25602
	public class IGiantResponsePlayFlowT
	{
		// Token: 0x1700BD20 RID: 48416
		// (get) Token: 0x0602B7F4 RID: 178164 RVA: 0x005ECBA7 File Offset: 0x005EADA7
		// (set) Token: 0x0602B7F5 RID: 178165 RVA: 0x005ECBAF File Offset: 0x005EADAF
		public EGiantResponseType Type { get; set; }

		// Token: 0x1700BD21 RID: 48417
		// (get) Token: 0x0602B7F6 RID: 178166 RVA: 0x005ECBB8 File Offset: 0x005EADB8
		// (set) Token: 0x0602B7F7 RID: 178167 RVA: 0x005ECBC0 File Offset: 0x005EADC0
		public IGiantFlowConfigT FlowConfig { get; set; }

		// Token: 0x0602B7F8 RID: 178168 RVA: 0x005ECBC9 File Offset: 0x005EADC9
		public IGiantResponsePlayFlowT()
		{
			this.Type = EGiantResponseType.PlayAnimation;
			this.FlowConfig = null;
		}
	}
}

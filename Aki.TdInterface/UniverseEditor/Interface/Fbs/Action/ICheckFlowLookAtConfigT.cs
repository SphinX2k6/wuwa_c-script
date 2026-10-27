using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200635F RID: 25439
	public class ICheckFlowLookAtConfigT
	{
		// Token: 0x1700BDCE RID: 48590
		// (get) Token: 0x0602C02F RID: 180271 RVA: 0x0060C4EE File Offset: 0x0060A6EE
		// (set) Token: 0x0602C030 RID: 180272 RVA: 0x0060C4F6 File Offset: 0x0060A6F6
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700BDCF RID: 48591
		// (get) Token: 0x0602C031 RID: 180273 RVA: 0x0060C4FF File Offset: 0x0060A6FF
		// (set) Token: 0x0602C032 RID: 180274 RVA: 0x0060C507 File Offset: 0x0060A707
		public TCheckFlowLookAtTargetUnion Target { get; set; }

		// Token: 0x1700BDD0 RID: 48592
		// (get) Token: 0x0602C033 RID: 180275 RVA: 0x0060C510 File Offset: 0x0060A710
		// (set) Token: 0x0602C034 RID: 180276 RVA: 0x0060C518 File Offset: 0x0060A718
		public IEntityLookAtPerformT EntityLookAtPerform { get; set; }

		// Token: 0x0602C035 RID: 180277 RVA: 0x0060C521 File Offset: 0x0060A721
		public ICheckFlowLookAtConfigT()
		{
			this.Flow = null;
			this.Target = null;
			this.EntityLookAtPerform = null;
		}
	}
}

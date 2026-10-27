using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006365 RID: 25445
	public class ICheckFlowLookAtPlayerT
	{
		// Token: 0x1700BDD8 RID: 48600
		// (get) Token: 0x0602C05B RID: 180315 RVA: 0x0060C91A File Offset: 0x0060AB1A
		// (set) Token: 0x0602C05C RID: 180316 RVA: 0x0060C922 File Offset: 0x0060AB22
		public ECheckFlowLookAtTargetType Type { get; set; }

		// Token: 0x0602C05D RID: 180317 RVA: 0x0060C92B File Offset: 0x0060AB2B
		public ICheckFlowLookAtPlayerT()
		{
			this.Type = ECheckFlowLookAtTargetType.Entity;
		}
	}
}

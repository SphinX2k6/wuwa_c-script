using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006368 RID: 25448
	public class ICheckFlowLookAtTargetT
	{
		// Token: 0x1700BDDB RID: 48603
		// (get) Token: 0x0602C06D RID: 180333 RVA: 0x0060CA92 File Offset: 0x0060AC92
		// (set) Token: 0x0602C06E RID: 180334 RVA: 0x0060CA9A File Offset: 0x0060AC9A
		public ECheckFlowLookAtTargetType Type { get; set; }

		// Token: 0x0602C06F RID: 180335 RVA: 0x0060CAA3 File Offset: 0x0060ACA3
		public ICheckFlowLookAtTargetT()
		{
			this.Type = ECheckFlowLookAtTargetType.Entity;
		}
	}
}

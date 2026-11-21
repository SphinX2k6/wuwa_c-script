using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A5 RID: 25509
	public class IBvbWaitForGameBeginDataT
	{
		// Token: 0x1700BC85 RID: 48261
		// (get) Token: 0x0602B512 RID: 177426 RVA: 0x005E7792 File Offset: 0x005E5992
		// (set) Token: 0x0602B513 RID: 177427 RVA: 0x005E779A File Offset: 0x005E599A
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B514 RID: 177428 RVA: 0x005E77A3 File Offset: 0x005E59A3
		public IBvbWaitForGameBeginDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}

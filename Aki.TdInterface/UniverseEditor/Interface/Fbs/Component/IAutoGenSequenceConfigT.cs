using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EE4 RID: 20196
	public class IAutoGenSequenceConfigT
	{
		// Token: 0x170090F7 RID: 37111
		// (get) Token: 0x0601FD5F RID: 130399 RVA: 0x0046DFA1 File Offset: 0x0046C1A1
		// (set) Token: 0x0601FD60 RID: 130400 RVA: 0x0046DFA9 File Offset: 0x0046C1A9
		public string SequencePath { get; set; }

		// Token: 0x170090F8 RID: 37112
		// (get) Token: 0x0601FD61 RID: 130401 RVA: 0x0046DFB2 File Offset: 0x0046C1B2
		// (set) Token: 0x0601FD62 RID: 130402 RVA: 0x0046DFBA File Offset: 0x0046C1BA
		public IPlayLevelSequenceT SequenceConfig { get; set; }

		// Token: 0x170090F9 RID: 37113
		// (get) Token: 0x0601FD63 RID: 130403 RVA: 0x0046DFC3 File Offset: 0x0046C1C3
		// (set) Token: 0x0601FD64 RID: 130404 RVA: 0x0046DFCB File Offset: 0x0046C1CB
		public int Count { get; set; }

		// Token: 0x0601FD65 RID: 130405 RVA: 0x0046DFD4 File Offset: 0x0046C1D4
		public IAutoGenSequenceConfigT()
		{
			this.SequencePath = null;
			this.SequenceConfig = null;
			this.Count = 0;
		}
	}
}

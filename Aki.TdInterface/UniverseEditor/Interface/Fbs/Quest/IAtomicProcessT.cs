using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D17 RID: 15639
	public class IAtomicProcessT
	{
		// Token: 0x17006B4B RID: 27467
		// (get) Token: 0x0601594D RID: 88397 RVA: 0x0031DEA1 File Offset: 0x0031C0A1
		// (set) Token: 0x0601594E RID: 88398 RVA: 0x0031DEA9 File Offset: 0x0031C0A9
		public EChildQuest Type { get; set; }

		// Token: 0x17006B4C RID: 27468
		// (get) Token: 0x0601594F RID: 88399 RVA: 0x0031DEB2 File Offset: 0x0031C0B2
		// (set) Token: 0x06015950 RID: 88400 RVA: 0x0031DEBA File Offset: 0x0031C0BA
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006B4D RID: 27469
		// (get) Token: 0x06015951 RID: 88401 RVA: 0x0031DEC3 File Offset: 0x0031C0C3
		// (set) Token: 0x06015952 RID: 88402 RVA: 0x0031DECB File Offset: 0x0031C0CB
		public IAtomicProcessStoveCoreFallT AtomicProcessType { get; set; }

		// Token: 0x06015953 RID: 88403 RVA: 0x0031DED4 File Offset: 0x0031C0D4
		public IAtomicProcessT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.AtomicProcessType = null;
		}
	}
}

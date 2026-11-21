using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A75 RID: 23157
	public class ILevelSequenceFrameEventComponentT
	{
		// Token: 0x1700A8A1 RID: 43169
		// (get) Token: 0x06025ED3 RID: 155347 RVA: 0x0053326A File Offset: 0x0053146A
		// (set) Token: 0x06025ED4 RID: 155348 RVA: 0x00533272 File Offset: 0x00531472
		public bool Disabled { get; set; }

		// Token: 0x1700A8A2 RID: 43170
		// (get) Token: 0x06025ED5 RID: 155349 RVA: 0x0053327B File Offset: 0x0053147B
		// (set) Token: 0x06025ED6 RID: 155350 RVA: 0x00533283 File Offset: 0x00531483
		public List<ILevelSequenceSectionInfoT> ForwardSections { get; set; }

		// Token: 0x1700A8A3 RID: 43171
		// (get) Token: 0x06025ED7 RID: 155351 RVA: 0x0053328C File Offset: 0x0053148C
		// (set) Token: 0x06025ED8 RID: 155352 RVA: 0x00533294 File Offset: 0x00531494
		public List<ILevelSequenceSectionInfoT> BackWardSections { get; set; }

		// Token: 0x1700A8A4 RID: 43172
		// (get) Token: 0x06025ED9 RID: 155353 RVA: 0x0053329D File Offset: 0x0053149D
		// (set) Token: 0x06025EDA RID: 155354 RVA: 0x005332A5 File Offset: 0x005314A5
		public byte NullMask { get; set; }

		// Token: 0x06025EDB RID: 155355 RVA: 0x005332AE File Offset: 0x005314AE
		public ILevelSequenceFrameEventComponentT()
		{
			this.Disabled = false;
			this.ForwardSections = null;
			this.BackWardSections = null;
			this.NullMask = 0;
		}
	}
}

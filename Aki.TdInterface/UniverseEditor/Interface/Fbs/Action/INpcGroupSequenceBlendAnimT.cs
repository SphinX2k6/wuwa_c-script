using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007311 RID: 29457
	public class INpcGroupSequenceBlendAnimT
	{
		// Token: 0x1700D7F0 RID: 55280
		// (get) Token: 0x060335DF RID: 210399 RVA: 0x006ED3B3 File Offset: 0x006EB5B3
		// (set) Token: 0x060335E0 RID: 210400 RVA: 0x006ED3BB File Offset: 0x006EB5BB
		public int Target { get; set; }

		// Token: 0x1700D7F1 RID: 55281
		// (get) Token: 0x060335E1 RID: 210401 RVA: 0x006ED3C4 File Offset: 0x006EB5C4
		// (set) Token: 0x060335E2 RID: 210402 RVA: 0x006ED3CC File Offset: 0x006EB5CC
		public INpcGroupSequenceMontageBlendAnimTypeT BlendType { get; set; }

		// Token: 0x060335E3 RID: 210403 RVA: 0x006ED3D5 File Offset: 0x006EB5D5
		public INpcGroupSequenceBlendAnimT()
		{
			this.Target = 0;
			this.BlendType = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007314 RID: 29460
	public class INpcGroupSequenceBlendAnimTypeBaseT
	{
		// Token: 0x1700D7F4 RID: 55284
		// (get) Token: 0x060335F3 RID: 210419 RVA: 0x006ED572 File Offset: 0x006EB772
		// (set) Token: 0x060335F4 RID: 210420 RVA: 0x006ED57A File Offset: 0x006EB77A
		public ENpcGroupSequenceBlendAnimType Type { get; set; }

		// Token: 0x060335F5 RID: 210421 RVA: 0x006ED583 File Offset: 0x006EB783
		public INpcGroupSequenceBlendAnimTypeBaseT()
		{
			this.Type = ENpcGroupSequenceBlendAnimType.AnimSequence;
		}
	}
}

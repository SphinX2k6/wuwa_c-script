using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007798 RID: 30616
	public class ISetBlendAnimT
	{
		// Token: 0x1700E052 RID: 57426
		// (get) Token: 0x06035BDD RID: 220125 RVA: 0x00733573 File Offset: 0x00731773
		// (set) Token: 0x06035BDE RID: 220126 RVA: 0x0073357B File Offset: 0x0073177B
		public IPlayerBlendAnimTargetT Target { get; set; }

		// Token: 0x1700E053 RID: 57427
		// (get) Token: 0x06035BDF RID: 220127 RVA: 0x00733584 File Offset: 0x00731784
		// (set) Token: 0x06035BE0 RID: 220128 RVA: 0x0073358C File Offset: 0x0073178C
		public TBlendAnimTypeUnion BlendType { get; set; }

		// Token: 0x06035BE1 RID: 220129 RVA: 0x00733595 File Offset: 0x00731795
		public ISetBlendAnimT()
		{
			this.Target = null;
			this.BlendType = null;
		}
	}
}

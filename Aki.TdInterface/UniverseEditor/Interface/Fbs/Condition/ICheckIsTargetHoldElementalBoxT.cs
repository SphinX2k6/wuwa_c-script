using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AA0 RID: 19104
	public class ICheckIsTargetHoldElementalBoxT
	{
		// Token: 0x17008A70 RID: 35440
		// (get) Token: 0x0601DF98 RID: 122776 RVA: 0x00435657 File Offset: 0x00433857
		// (set) Token: 0x0601DF99 RID: 122777 RVA: 0x0043565F File Offset: 0x0043385F
		public ECondition Type { get; set; }

		// Token: 0x17008A71 RID: 35441
		// (get) Token: 0x0601DF9A RID: 122778 RVA: 0x00435668 File Offset: 0x00433868
		// (set) Token: 0x0601DF9B RID: 122779 RVA: 0x00435670 File Offset: 0x00433870
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x17008A72 RID: 35442
		// (get) Token: 0x0601DF9C RID: 122780 RVA: 0x00435679 File Offset: 0x00433879
		// (set) Token: 0x0601DF9D RID: 122781 RVA: 0x00435681 File Offset: 0x00433881
		public bool IsHolding { get; set; }

		// Token: 0x17008A73 RID: 35443
		// (get) Token: 0x0601DF9E RID: 122782 RVA: 0x0043568A File Offset: 0x0043388A
		// (set) Token: 0x0601DF9F RID: 122783 RVA: 0x00435692 File Offset: 0x00433892
		public EElementalType TargetElementalType { get; set; }

		// Token: 0x17008A74 RID: 35444
		// (get) Token: 0x0601DFA0 RID: 122784 RVA: 0x0043569B File Offset: 0x0043389B
		// (set) Token: 0x0601DFA1 RID: 122785 RVA: 0x004356A3 File Offset: 0x004338A3
		public int ElementalBoxId { get; set; }

		// Token: 0x17008A75 RID: 35445
		// (get) Token: 0x0601DFA2 RID: 122786 RVA: 0x004356AC File Offset: 0x004338AC
		// (set) Token: 0x0601DFA3 RID: 122787 RVA: 0x004356B4 File Offset: 0x004338B4
		public byte NullMask { get; set; }

		// Token: 0x0601DFA4 RID: 122788 RVA: 0x004356BD File Offset: 0x004338BD
		public ICheckIsTargetHoldElementalBoxT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.IsHolding = false;
			this.TargetElementalType = EElementalType.Fire;
			this.ElementalBoxId = 0;
			this.NullMask = 0;
		}
	}
}

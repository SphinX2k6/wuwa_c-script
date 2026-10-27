using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200662E RID: 26158
	public class IEffectPlayerPos2T
	{
		// Token: 0x1700C259 RID: 49753
		// (get) Token: 0x0602D6D7 RID: 186071 RVA: 0x00639301 File Offset: 0x00637501
		// (set) Token: 0x0602D6D8 RID: 186072 RVA: 0x00639309 File Offset: 0x00637509
		public EPos2 Type { get; set; }

		// Token: 0x1700C25A RID: 49754
		// (get) Token: 0x0602D6D9 RID: 186073 RVA: 0x00639312 File Offset: 0x00637512
		// (set) Token: 0x0602D6DA RID: 186074 RVA: 0x0063931A File Offset: 0x0063751A
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C25B RID: 49755
		// (get) Token: 0x0602D6DB RID: 186075 RVA: 0x00639323 File Offset: 0x00637523
		// (set) Token: 0x0602D6DC RID: 186076 RVA: 0x0063932B File Offset: 0x0063752B
		public string AttachSocket { get; set; }

		// Token: 0x0602D6DD RID: 186077 RVA: 0x00639334 File Offset: 0x00637534
		public IEffectPlayerPos2T()
		{
			this.Type = EPos2.Player;
			this.Offset = null;
			this.AttachSocket = null;
		}
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C9C RID: 27804
	public class IEffectEntityPos2T
	{
		// Token: 0x1700CBEF RID: 52207
		// (get) Token: 0x0602FE8A RID: 196234 RVA: 0x00685AF3 File Offset: 0x00683CF3
		// (set) Token: 0x0602FE8B RID: 196235 RVA: 0x00685AFB File Offset: 0x00683CFB
		public EPos2 Type { get; set; }

		// Token: 0x1700CBF0 RID: 52208
		// (get) Token: 0x0602FE8C RID: 196236 RVA: 0x00685B04 File Offset: 0x00683D04
		// (set) Token: 0x0602FE8D RID: 196237 RVA: 0x00685B0C File Offset: 0x00683D0C
		public int EntityId { get; set; }

		// Token: 0x1700CBF1 RID: 52209
		// (get) Token: 0x0602FE8E RID: 196238 RVA: 0x00685B15 File Offset: 0x00683D15
		// (set) Token: 0x0602FE8F RID: 196239 RVA: 0x00685B1D File Offset: 0x00683D1D
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700CBF2 RID: 52210
		// (get) Token: 0x0602FE90 RID: 196240 RVA: 0x00685B26 File Offset: 0x00683D26
		// (set) Token: 0x0602FE91 RID: 196241 RVA: 0x00685B2E File Offset: 0x00683D2E
		public string AttachSocket { get; set; }

		// Token: 0x0602FE92 RID: 196242 RVA: 0x00685B37 File Offset: 0x00683D37
		public IEffectEntityPos2T()
		{
			this.Type = EPos2.Player;
			this.EntityId = 0;
			this.Offset = null;
			this.AttachSocket = null;
		}
	}
}

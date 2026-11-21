using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049BD RID: 18877
	public class IRollBlockBlockTemplateT
	{
		// Token: 0x17008428 RID: 33832
		// (get) Token: 0x0601C344 RID: 115524 RVA: 0x003FB640 File Offset: 0x003F9840
		// (set) Token: 0x0601C345 RID: 115525 RVA: 0x003FB648 File Offset: 0x003F9848
		public ERollBlockBlockType BlockType { get; set; }

		// Token: 0x17008429 RID: 33833
		// (get) Token: 0x0601C346 RID: 115526 RVA: 0x003FB651 File Offset: 0x003F9851
		// (set) Token: 0x0601C347 RID: 115527 RVA: 0x003FB659 File Offset: 0x003F9859
		public string TemplateId { get; set; }

		// Token: 0x1700842A RID: 33834
		// (get) Token: 0x0601C348 RID: 115528 RVA: 0x003FB662 File Offset: 0x003F9862
		// (set) Token: 0x0601C349 RID: 115529 RVA: 0x003FB66A File Offset: 0x003F986A
		public string PhantomTemplateId { get; set; }

		// Token: 0x1700842B RID: 33835
		// (get) Token: 0x0601C34A RID: 115530 RVA: 0x003FB673 File Offset: 0x003F9873
		// (set) Token: 0x0601C34B RID: 115531 RVA: 0x003FB67B File Offset: 0x003F987B
		public IVectorInfoT Size { get; set; }

		// Token: 0x0601C34C RID: 115532 RVA: 0x003FB684 File Offset: 0x003F9884
		public IRollBlockBlockTemplateT()
		{
			this.BlockType = ERollBlockBlockType.Block1;
			this.TemplateId = null;
			this.PhantomTemplateId = null;
			this.Size = null;
		}
	}
}

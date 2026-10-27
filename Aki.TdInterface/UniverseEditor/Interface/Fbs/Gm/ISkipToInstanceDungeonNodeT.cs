using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046A0 RID: 18080
	public class ISkipToInstanceDungeonNodeT
	{
		// Token: 0x17008065 RID: 32869
		// (get) Token: 0x0601B769 RID: 112489 RVA: 0x003E6638 File Offset: 0x003E4838
		// (set) Token: 0x0601B76A RID: 112490 RVA: 0x003E6640 File Offset: 0x003E4840
		public EGmCommand Type { get; set; }

		// Token: 0x17008066 RID: 32870
		// (get) Token: 0x0601B76B RID: 112491 RVA: 0x003E6649 File Offset: 0x003E4849
		// (set) Token: 0x0601B76C RID: 112492 RVA: 0x003E6651 File Offset: 0x003E4851
		public int ChildQuestId { get; set; }

		// Token: 0x17008067 RID: 32871
		// (get) Token: 0x0601B76D RID: 112493 RVA: 0x003E665A File Offset: 0x003E485A
		// (set) Token: 0x0601B76E RID: 112494 RVA: 0x003E6662 File Offset: 0x003E4862
		public bool IsTeleport { get; set; }

		// Token: 0x17008068 RID: 32872
		// (get) Token: 0x0601B76F RID: 112495 RVA: 0x003E666B File Offset: 0x003E486B
		// (set) Token: 0x0601B770 RID: 112496 RVA: 0x003E6673 File Offset: 0x003E4873
		public bool IsFastMode { get; set; }

		// Token: 0x0601B771 RID: 112497 RVA: 0x003E667C File Offset: 0x003E487C
		public ISkipToInstanceDungeonNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.ChildQuestId = 0;
			this.IsTeleport = false;
			this.IsFastMode = false;
		}
	}
}

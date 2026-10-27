using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200464F RID: 17999
	public class IFinishCurrentTrackQuestNodeT
	{
		// Token: 0x17007FBC RID: 32700
		// (get) Token: 0x0601B45D RID: 111709 RVA: 0x003E1642 File Offset: 0x003DF842
		// (set) Token: 0x0601B45E RID: 111710 RVA: 0x003E164A File Offset: 0x003DF84A
		public EGmCommand Type { get; set; }

		// Token: 0x17007FBD RID: 32701
		// (get) Token: 0x0601B45F RID: 111711 RVA: 0x003E1653 File Offset: 0x003DF853
		// (set) Token: 0x0601B460 RID: 111712 RVA: 0x003E165B File Offset: 0x003DF85B
		public int NodeId { get; set; }

		// Token: 0x17007FBE RID: 32702
		// (get) Token: 0x0601B461 RID: 111713 RVA: 0x003E1664 File Offset: 0x003DF864
		// (set) Token: 0x0601B462 RID: 111714 RVA: 0x003E166C File Offset: 0x003DF86C
		public int NodeIndex { get; set; }

		// Token: 0x17007FBF RID: 32703
		// (get) Token: 0x0601B463 RID: 111715 RVA: 0x003E1675 File Offset: 0x003DF875
		// (set) Token: 0x0601B464 RID: 111716 RVA: 0x003E167D File Offset: 0x003DF87D
		public bool IsComplete { get; set; }

		// Token: 0x17007FC0 RID: 32704
		// (get) Token: 0x0601B465 RID: 111717 RVA: 0x003E1686 File Offset: 0x003DF886
		// (set) Token: 0x0601B466 RID: 111718 RVA: 0x003E168E File Offset: 0x003DF88E
		public byte NullMask { get; set; }

		// Token: 0x0601B467 RID: 111719 RVA: 0x003E1697 File Offset: 0x003DF897
		public IFinishCurrentTrackQuestNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.IsComplete = false;
			this.NullMask = 0;
		}
	}
}

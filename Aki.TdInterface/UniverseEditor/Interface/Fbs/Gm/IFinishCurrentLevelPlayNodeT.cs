using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200464C RID: 17996
	public class IFinishCurrentLevelPlayNodeT
	{
		// Token: 0x17007FB0 RID: 32688
		// (get) Token: 0x0601B439 RID: 111673 RVA: 0x003E1274 File Offset: 0x003DF474
		// (set) Token: 0x0601B43A RID: 111674 RVA: 0x003E127C File Offset: 0x003DF47C
		public EGmCommand Type { get; set; }

		// Token: 0x17007FB1 RID: 32689
		// (get) Token: 0x0601B43B RID: 111675 RVA: 0x003E1285 File Offset: 0x003DF485
		// (set) Token: 0x0601B43C RID: 111676 RVA: 0x003E128D File Offset: 0x003DF48D
		public int LevelPlayId { get; set; }

		// Token: 0x17007FB2 RID: 32690
		// (get) Token: 0x0601B43D RID: 111677 RVA: 0x003E1296 File Offset: 0x003DF496
		// (set) Token: 0x0601B43E RID: 111678 RVA: 0x003E129E File Offset: 0x003DF49E
		public int NodeId { get; set; }

		// Token: 0x17007FB3 RID: 32691
		// (get) Token: 0x0601B43F RID: 111679 RVA: 0x003E12A7 File Offset: 0x003DF4A7
		// (set) Token: 0x0601B440 RID: 111680 RVA: 0x003E12AF File Offset: 0x003DF4AF
		public int NodeIndex { get; set; }

		// Token: 0x17007FB4 RID: 32692
		// (get) Token: 0x0601B441 RID: 111681 RVA: 0x003E12B8 File Offset: 0x003DF4B8
		// (set) Token: 0x0601B442 RID: 111682 RVA: 0x003E12C0 File Offset: 0x003DF4C0
		public bool IsComplete { get; set; }

		// Token: 0x17007FB5 RID: 32693
		// (get) Token: 0x0601B443 RID: 111683 RVA: 0x003E12C9 File Offset: 0x003DF4C9
		// (set) Token: 0x0601B444 RID: 111684 RVA: 0x003E12D1 File Offset: 0x003DF4D1
		public byte NullMask { get; set; }

		// Token: 0x0601B445 RID: 111685 RVA: 0x003E12DA File Offset: 0x003DF4DA
		public IFinishCurrentLevelPlayNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.IsComplete = false;
			this.NullMask = 0;
		}
	}
}

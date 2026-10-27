using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007044 RID: 28740
	public class ISetNpcTwoPersonPerformT
	{
		// Token: 0x1700D575 RID: 54645
		// (get) Token: 0x06032DA2 RID: 208290 RVA: 0x006DBF4D File Offset: 0x006DA14D
		// (set) Token: 0x06032DA3 RID: 208291 RVA: 0x006DBF55 File Offset: 0x006DA155
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700D576 RID: 54646
		// (get) Token: 0x06032DA4 RID: 208292 RVA: 0x006DBF5E File Offset: 0x006DA15E
		// (set) Token: 0x06032DA5 RID: 208293 RVA: 0x006DBF66 File Offset: 0x006DA166
		public IPlayerInitiatorT Initiator { get; set; }

		// Token: 0x1700D577 RID: 54647
		// (get) Token: 0x06032DA6 RID: 208294 RVA: 0x006DBF6F File Offset: 0x006DA16F
		// (set) Token: 0x06032DA7 RID: 208295 RVA: 0x006DBF77 File Offset: 0x006DA177
		public int Target { get; set; }

		// Token: 0x1700D578 RID: 54648
		// (get) Token: 0x06032DA8 RID: 208296 RVA: 0x006DBF80 File Offset: 0x006DA180
		// (set) Token: 0x06032DA9 RID: 208297 RVA: 0x006DBF88 File Offset: 0x006DA188
		public string GroupPerformMark { get; set; }

		// Token: 0x1700D579 RID: 54649
		// (get) Token: 0x06032DAA RID: 208298 RVA: 0x006DBF91 File Offset: 0x006DA191
		// (set) Token: 0x06032DAB RID: 208299 RVA: 0x006DBF99 File Offset: 0x006DA199
		public ENpcGroupPerformNpcType NpcType { get; set; }

		// Token: 0x1700D57A RID: 54650
		// (get) Token: 0x06032DAC RID: 208300 RVA: 0x006DBFA2 File Offset: 0x006DA1A2
		// (set) Token: 0x06032DAD RID: 208301 RVA: 0x006DBFAA File Offset: 0x006DA1AA
		public EWaitInteractNpcMontageWaitType WaitInteractNpcType { get; set; }

		// Token: 0x1700D57B RID: 54651
		// (get) Token: 0x06032DAE RID: 208302 RVA: 0x006DBFB3 File Offset: 0x006DA1B3
		// (set) Token: 0x06032DAF RID: 208303 RVA: 0x006DBFBB File Offset: 0x006DA1BB
		public byte NullMask { get; set; }

		// Token: 0x06032DB0 RID: 208304 RVA: 0x006DBFC4 File Offset: 0x006DA1C4
		public ISetNpcTwoPersonPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Target = 0;
			this.GroupPerformMark = null;
			this.NpcType = ENpcGroupPerformNpcType.LevelBCommonMale;
			this.WaitInteractNpcType = EWaitInteractNpcMontageWaitType.WaitForMontage;
			this.NullMask = 0;
		}
	}
}

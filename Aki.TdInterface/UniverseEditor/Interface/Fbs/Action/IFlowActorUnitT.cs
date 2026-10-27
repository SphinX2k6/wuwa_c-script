using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F3 RID: 26611
	public class IFlowActorUnitT
	{
		// Token: 0x1700C588 RID: 50568
		// (get) Token: 0x0602E561 RID: 189793 RVA: 0x00653547 File Offset: 0x00651747
		// (set) Token: 0x0602E562 RID: 189794 RVA: 0x0065354F File Offset: 0x0065174F
		public int EntityId { get; set; }

		// Token: 0x1700C589 RID: 50569
		// (get) Token: 0x0602E563 RID: 189795 RVA: 0x00653558 File Offset: 0x00651758
		// (set) Token: 0x0602E564 RID: 189796 RVA: 0x00653560 File Offset: 0x00651760
		public int TalkerId { get; set; }

		// Token: 0x1700C58A RID: 50570
		// (get) Token: 0x0602E565 RID: 189797 RVA: 0x00653569 File Offset: 0x00651769
		// (set) Token: 0x0602E566 RID: 189798 RVA: 0x00653571 File Offset: 0x00651771
		public bool IsPlayer { get; set; }

		// Token: 0x1700C58B RID: 50571
		// (get) Token: 0x0602E567 RID: 189799 RVA: 0x0065357A File Offset: 0x0065177A
		// (set) Token: 0x0602E568 RID: 189800 RVA: 0x00653582 File Offset: 0x00651782
		public bool IsResetPosition { get; set; }

		// Token: 0x1700C58C RID: 50572
		// (get) Token: 0x0602E569 RID: 189801 RVA: 0x0065358B File Offset: 0x0065178B
		// (set) Token: 0x0602E56A RID: 189802 RVA: 0x00653593 File Offset: 0x00651793
		public string SeqFacePath { get; set; }

		// Token: 0x1700C58D RID: 50573
		// (get) Token: 0x0602E56B RID: 189803 RVA: 0x0065359C File Offset: 0x0065179C
		// (set) Token: 0x0602E56C RID: 189804 RVA: 0x006535A4 File Offset: 0x006517A4
		public IActorInitialStateT InitialState { get; set; }

		// Token: 0x0602E56D RID: 189805 RVA: 0x006535AD File Offset: 0x006517AD
		public IFlowActorUnitT()
		{
			this.EntityId = 0;
			this.TalkerId = 0;
			this.IsPlayer = false;
			this.IsResetPosition = false;
			this.SeqFacePath = null;
			this.InitialState = null;
		}
	}
}

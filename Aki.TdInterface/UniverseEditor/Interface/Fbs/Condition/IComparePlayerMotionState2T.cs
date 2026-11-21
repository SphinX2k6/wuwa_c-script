using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050AA RID: 20650
	public class IComparePlayerMotionState2T
	{
		// Token: 0x170093EC RID: 37868
		// (get) Token: 0x0602053E RID: 132414 RVA: 0x0047A39F File Offset: 0x0047859F
		// (set) Token: 0x0602053F RID: 132415 RVA: 0x0047A3A7 File Offset: 0x004785A7
		public ECondition Type { get; set; }

		// Token: 0x170093ED RID: 37869
		// (get) Token: 0x06020540 RID: 132416 RVA: 0x0047A3B0 File Offset: 0x004785B0
		// (set) Token: 0x06020541 RID: 132417 RVA: 0x0047A3B8 File Offset: 0x004785B8
		public EPlayerMotionState MotionState { get; set; }

		// Token: 0x170093EE RID: 37870
		// (get) Token: 0x06020542 RID: 132418 RVA: 0x0047A3C1 File Offset: 0x004785C1
		// (set) Token: 0x06020543 RID: 132419 RVA: 0x0047A3C9 File Offset: 0x004785C9
		public ECompare Compare { get; set; }

		// Token: 0x170093EF RID: 37871
		// (get) Token: 0x06020544 RID: 132420 RVA: 0x0047A3D2 File Offset: 0x004785D2
		// (set) Token: 0x06020545 RID: 132421 RVA: 0x0047A3DA File Offset: 0x004785DA
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x06020546 RID: 132422 RVA: 0x0047A3E3 File Offset: 0x004785E3
		public IComparePlayerMotionState2T()
		{
			this.Type = ECondition.CompareVar;
			this.MotionState = EPlayerMotionState.Ground;
			this.Compare = ECompare.Eq;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}

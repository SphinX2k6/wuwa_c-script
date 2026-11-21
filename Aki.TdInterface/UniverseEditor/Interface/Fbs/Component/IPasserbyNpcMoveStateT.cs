using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C9A RID: 23706
	public class IPasserbyNpcMoveStateT
	{
		// Token: 0x1700AE1E RID: 44574
		// (get) Token: 0x0602752B RID: 161067 RVA: 0x00562406 File Offset: 0x00560606
		// (set) Token: 0x0602752C RID: 161068 RVA: 0x0056240E File Offset: 0x0056060E
		public EPatrolMoveState MoveState { get; set; }

		// Token: 0x1700AE1F RID: 44575
		// (get) Token: 0x0602752D RID: 161069 RVA: 0x00562417 File Offset: 0x00560617
		// (set) Token: 0x0602752E RID: 161070 RVA: 0x0056241F File Offset: 0x0056061F
		public ECharPositionStateType CharPositionState { get; set; }

		// Token: 0x1700AE20 RID: 44576
		// (get) Token: 0x0602752F RID: 161071 RVA: 0x00562428 File Offset: 0x00560628
		// (set) Token: 0x06027530 RID: 161072 RVA: 0x00562430 File Offset: 0x00560630
		public int MoveSpeed { get; set; }

		// Token: 0x1700AE21 RID: 44577
		// (get) Token: 0x06027531 RID: 161073 RVA: 0x00562439 File Offset: 0x00560639
		// (set) Token: 0x06027532 RID: 161074 RVA: 0x00562441 File Offset: 0x00560641
		public bool UseAbpMappingSpeed { get; set; }

		// Token: 0x1700AE22 RID: 44578
		// (get) Token: 0x06027533 RID: 161075 RVA: 0x0056244A File Offset: 0x0056064A
		// (set) Token: 0x06027534 RID: 161076 RVA: 0x00562452 File Offset: 0x00560652
		public byte NullMask { get; set; }

		// Token: 0x06027535 RID: 161077 RVA: 0x0056245B File Offset: 0x0056065B
		public IPasserbyNpcMoveStateT()
		{
			this.MoveState = EPatrolMoveState.None;
			this.CharPositionState = ECharPositionStateType.Ground;
			this.MoveSpeed = 0;
			this.UseAbpMappingSpeed = false;
			this.NullMask = 0;
		}
	}
}

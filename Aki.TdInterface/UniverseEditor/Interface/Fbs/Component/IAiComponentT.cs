using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005389 RID: 21385
	public class IAiComponentT
	{
		// Token: 0x1700971E RID: 38686
		// (get) Token: 0x06021581 RID: 136577 RVA: 0x0049A122 File Offset: 0x00498322
		// (set) Token: 0x06021582 RID: 136578 RVA: 0x0049A12A File Offset: 0x0049832A
		public bool Disabled { get; set; }

		// Token: 0x1700971F RID: 38687
		// (get) Token: 0x06021583 RID: 136579 RVA: 0x0049A133 File Offset: 0x00498333
		// (set) Token: 0x06021584 RID: 136580 RVA: 0x0049A13B File Offset: 0x0049833B
		public int AiId { get; set; }

		// Token: 0x17009720 RID: 38688
		// (get) Token: 0x06021585 RID: 136581 RVA: 0x0049A144 File Offset: 0x00498344
		// (set) Token: 0x06021586 RID: 136582 RVA: 0x0049A14C File Offset: 0x0049834C
		public IPatrolT Patrol { get; set; }

		// Token: 0x17009721 RID: 38689
		// (get) Token: 0x06021587 RID: 136583 RVA: 0x0049A155 File Offset: 0x00498355
		// (set) Token: 0x06021588 RID: 136584 RVA: 0x0049A15D File Offset: 0x0049835D
		public TInitStateUnion InitState { get; set; }

		// Token: 0x17009722 RID: 38690
		// (get) Token: 0x06021589 RID: 136585 RVA: 0x0049A166 File Offset: 0x00498366
		// (set) Token: 0x0602158A RID: 136586 RVA: 0x0049A16E File Offset: 0x0049836E
		public int CenterPoint { get; set; }

		// Token: 0x17009723 RID: 38691
		// (get) Token: 0x0602158B RID: 136587 RVA: 0x0049A177 File Offset: 0x00498377
		// (set) Token: 0x0602158C RID: 136588 RVA: 0x0049A17F File Offset: 0x0049837F
		public List<TBlackBoardUnion> InitBlackBoard { get; set; }

		// Token: 0x17009724 RID: 38692
		// (get) Token: 0x0602158D RID: 136589 RVA: 0x0049A188 File Offset: 0x00498388
		// (set) Token: 0x0602158E RID: 136590 RVA: 0x0049A190 File Offset: 0x00498390
		public string WeaponId { get; set; }

		// Token: 0x17009725 RID: 38693
		// (get) Token: 0x0602158F RID: 136591 RVA: 0x0049A199 File Offset: 0x00498399
		// (set) Token: 0x06021590 RID: 136592 RVA: 0x0049A1A1 File Offset: 0x004983A1
		public int AiTeamLevelId { get; set; }

		// Token: 0x17009726 RID: 38694
		// (get) Token: 0x06021591 RID: 136593 RVA: 0x0049A1AA File Offset: 0x004983AA
		// (set) Token: 0x06021592 RID: 136594 RVA: 0x0049A1B2 File Offset: 0x004983B2
		public List<IStateRepPerfItemT> StateRepPerfList { get; set; }

		// Token: 0x17009727 RID: 38695
		// (get) Token: 0x06021593 RID: 136595 RVA: 0x0049A1BB File Offset: 0x004983BB
		// (set) Token: 0x06021594 RID: 136596 RVA: 0x0049A1C3 File Offset: 0x004983C3
		public IAiAlertSystemConfigT AlertSystemConfig { get; set; }

		// Token: 0x17009728 RID: 38696
		// (get) Token: 0x06021595 RID: 136597 RVA: 0x0049A1CC File Offset: 0x004983CC
		// (set) Token: 0x06021596 RID: 136598 RVA: 0x0049A1D4 File Offset: 0x004983D4
		public byte NullMask { get; set; }

		// Token: 0x06021597 RID: 136599 RVA: 0x0049A1E0 File Offset: 0x004983E0
		public IAiComponentT()
		{
			this.Disabled = false;
			this.AiId = 0;
			this.Patrol = null;
			this.InitState = null;
			this.CenterPoint = 0;
			this.InitBlackBoard = null;
			this.WeaponId = null;
			this.AiTeamLevelId = 0;
			this.StateRepPerfList = null;
			this.AlertSystemConfig = null;
			this.NullMask = 0;
		}
	}
}

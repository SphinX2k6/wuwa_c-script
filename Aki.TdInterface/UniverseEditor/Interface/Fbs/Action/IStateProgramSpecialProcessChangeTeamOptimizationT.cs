using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C7 RID: 29127
	public class IStateProgramSpecialProcessChangeTeamOptimizationT
	{
		// Token: 0x1700D86E RID: 55406
		// (get) Token: 0x06033AC4 RID: 211652 RVA: 0x006F55AA File Offset: 0x006F37AA
		// (set) Token: 0x06033AC5 RID: 211653 RVA: 0x006F55B2 File Offset: 0x006F37B2
		public ELogicProgramSpecialProcess Type { get; set; }

		// Token: 0x1700D86F RID: 55407
		// (get) Token: 0x06033AC6 RID: 211654 RVA: 0x006F55BB File Offset: 0x006F37BB
		// (set) Token: 0x06033AC7 RID: 211655 RVA: 0x006F55C3 File Offset: 0x006F37C3
		public bool IsOpenBlackScreen { get; set; }

		// Token: 0x1700D870 RID: 55408
		// (get) Token: 0x06033AC8 RID: 211656 RVA: 0x006F55CC File Offset: 0x006F37CC
		// (set) Token: 0x06033AC9 RID: 211657 RVA: 0x006F55D4 File Offset: 0x006F37D4
		public byte NullMask { get; set; }

		// Token: 0x06033ACA RID: 211658 RVA: 0x006F55DD File Offset: 0x006F37DD
		public IStateProgramSpecialProcessChangeTeamOptimizationT()
		{
			this.Type = ELogicProgramSpecialProcess.ChangeTeamOptimization;
			this.IsOpenBlackScreen = false;
			this.NullMask = 0;
		}
	}
}

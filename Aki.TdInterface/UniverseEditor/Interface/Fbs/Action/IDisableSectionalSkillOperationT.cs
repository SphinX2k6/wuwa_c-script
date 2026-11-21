using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C63 RID: 27747
	public class IDisableSectionalSkillOperationT
	{
		// Token: 0x1700CB80 RID: 52096
		// (get) Token: 0x0602FCA4 RID: 195748 RVA: 0x0068240F File Offset: 0x0068060F
		// (set) Token: 0x0602FCA5 RID: 195749 RVA: 0x00682417 File Offset: 0x00680617
		public ESkillOperationType Type { get; set; }

		// Token: 0x1700CB81 RID: 52097
		// (get) Token: 0x0602FCA6 RID: 195750 RVA: 0x00682420 File Offset: 0x00680620
		// (set) Token: 0x0602FCA7 RID: 195751 RVA: 0x00682428 File Offset: 0x00680628
		public EDisplayModeInSkillOp DisplayMode { get; set; }

		// Token: 0x1700CB82 RID: 52098
		// (get) Token: 0x0602FCA8 RID: 195752 RVA: 0x00682431 File Offset: 0x00680631
		// (set) Token: 0x0602FCA9 RID: 195753 RVA: 0x00682439 File Offset: 0x00680639
		public IDisableExploreSkillT DisableExploreSkill { get; set; }

		// Token: 0x1700CB83 RID: 52099
		// (get) Token: 0x0602FCAA RID: 195754 RVA: 0x00682442 File Offset: 0x00680642
		// (set) Token: 0x0602FCAB RID: 195755 RVA: 0x0068244A File Offset: 0x0068064A
		public bool DisableSkillWheel { get; set; }

		// Token: 0x1700CB84 RID: 52100
		// (get) Token: 0x0602FCAC RID: 195756 RVA: 0x00682453 File Offset: 0x00680653
		// (set) Token: 0x0602FCAD RID: 195757 RVA: 0x0068245B File Offset: 0x0068065B
		public IDisableBattleSkillOptionsT DisableBattleSkill { get; set; }

		// Token: 0x1700CB85 RID: 52101
		// (get) Token: 0x0602FCAE RID: 195758 RVA: 0x00682464 File Offset: 0x00680664
		// (set) Token: 0x0602FCAF RID: 195759 RVA: 0x0068246C File Offset: 0x0068066C
		public bool DisableSwitchRole { get; set; }

		// Token: 0x1700CB86 RID: 52102
		// (get) Token: 0x0602FCB0 RID: 195760 RVA: 0x00682475 File Offset: 0x00680675
		// (set) Token: 0x0602FCB1 RID: 195761 RVA: 0x0068247D File Offset: 0x0068067D
		public ETeamDisplayModeInSkillOp TeamDisplayMode { get; set; }

		// Token: 0x1700CB87 RID: 52103
		// (get) Token: 0x0602FCB2 RID: 195762 RVA: 0x00682486 File Offset: 0x00680686
		// (set) Token: 0x0602FCB3 RID: 195763 RVA: 0x0068248E File Offset: 0x0068068E
		public byte NullMask { get; set; }

		// Token: 0x0602FCB4 RID: 195764 RVA: 0x00682497 File Offset: 0x00680697
		public IDisableSectionalSkillOperationT()
		{
			this.Type = ESkillOperationType.Enable;
			this.DisplayMode = EDisplayModeInSkillOp.Ashen;
			this.DisableExploreSkill = null;
			this.DisableSkillWheel = false;
			this.DisableBattleSkill = null;
			this.DisableSwitchRole = false;
			this.TeamDisplayMode = ETeamDisplayModeInSkillOp.Normal;
			this.NullMask = 0;
		}
	}
}

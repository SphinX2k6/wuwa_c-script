using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410A RID: 16650
	public class ISelectBtNodeT
	{
		// Token: 0x17007588 RID: 30088
		// (get) Token: 0x06018509 RID: 99593 RVA: 0x003812B2 File Offset: 0x0037F4B2
		// (set) Token: 0x0601850A RID: 99594 RVA: 0x003812BA File Offset: 0x0037F4BA
		public EBtNode Type { get; set; }

		// Token: 0x17007589 RID: 30089
		// (get) Token: 0x0601850B RID: 99595 RVA: 0x003812C3 File Offset: 0x0037F4C3
		// (set) Token: 0x0601850C RID: 99596 RVA: 0x003812CB File Offset: 0x0037F4CB
		public int Id { get; set; }

		// Token: 0x1700758A RID: 30090
		// (get) Token: 0x0601850D RID: 99597 RVA: 0x003812D4 File Offset: 0x0037F4D4
		// (set) Token: 0x0601850E RID: 99598 RVA: 0x003812DC File Offset: 0x0037F4DC
		public string Desc { get; set; }

		// Token: 0x1700758B RID: 30091
		// (get) Token: 0x0601850F RID: 99599 RVA: 0x003812E5 File Offset: 0x0037F4E5
		// (set) Token: 0x06018510 RID: 99600 RVA: 0x003812ED File Offset: 0x0037F4ED
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x1700758C RID: 30092
		// (get) Token: 0x06018511 RID: 99601 RVA: 0x003812F6 File Offset: 0x0037F4F6
		// (set) Token: 0x06018512 RID: 99602 RVA: 0x003812FE File Offset: 0x0037F4FE
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700758D RID: 30093
		// (get) Token: 0x06018513 RID: 99603 RVA: 0x00381307 File Offset: 0x0037F507
		// (set) Token: 0x06018514 RID: 99604 RVA: 0x0038130F File Offset: 0x0037F50F
		public bool Disabled { get; set; }

		// Token: 0x1700758E RID: 30094
		// (get) Token: 0x06018515 RID: 99605 RVA: 0x00381318 File Offset: 0x0037F518
		// (set) Token: 0x06018516 RID: 99606 RVA: 0x00381320 File Offset: 0x0037F520
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x1700758F RID: 30095
		// (get) Token: 0x06018517 RID: 99607 RVA: 0x00381329 File Offset: 0x0037F529
		// (set) Token: 0x06018518 RID: 99608 RVA: 0x00381331 File Offset: 0x0037F531
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x17007590 RID: 30096
		// (get) Token: 0x06018519 RID: 99609 RVA: 0x0038133A File Offset: 0x0037F53A
		// (set) Token: 0x0601851A RID: 99610 RVA: 0x00381342 File Offset: 0x0037F542
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x17007591 RID: 30097
		// (get) Token: 0x0601851B RID: 99611 RVA: 0x0038134B File Offset: 0x0037F54B
		// (set) Token: 0x0601851C RID: 99612 RVA: 0x00381353 File Offset: 0x0037F553
		public string TidQuestAliasName { get; set; }

		// Token: 0x17007592 RID: 30098
		// (get) Token: 0x0601851D RID: 99613 RVA: 0x0038135C File Offset: 0x0037F55C
		// (set) Token: 0x0601851E RID: 99614 RVA: 0x00381364 File Offset: 0x0037F564
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x17007593 RID: 30099
		// (get) Token: 0x0601851F RID: 99615 RVA: 0x0038136D File Offset: 0x0037F56D
		// (set) Token: 0x06018520 RID: 99616 RVA: 0x00381375 File Offset: 0x0037F575
		public int DungeonId { get; set; }

		// Token: 0x17007594 RID: 30100
		// (get) Token: 0x06018521 RID: 99617 RVA: 0x0038137E File Offset: 0x0037F57E
		// (set) Token: 0x06018522 RID: 99618 RVA: 0x00381386 File Offset: 0x0037F586
		public bool DisableOnline { get; set; }

		// Token: 0x17007595 RID: 30101
		// (get) Token: 0x06018523 RID: 99619 RVA: 0x0038138F File Offset: 0x0037F58F
		// (set) Token: 0x06018524 RID: 99620 RVA: 0x00381397 File Offset: 0x0037F597
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x17007596 RID: 30102
		// (get) Token: 0x06018525 RID: 99621 RVA: 0x003813A0 File Offset: 0x0037F5A0
		// (set) Token: 0x06018526 RID: 99622 RVA: 0x003813A8 File Offset: 0x0037F5A8
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x17007597 RID: 30103
		// (get) Token: 0x06018527 RID: 99623 RVA: 0x003813B1 File Offset: 0x0037F5B1
		// (set) Token: 0x06018528 RID: 99624 RVA: 0x003813B9 File Offset: 0x0037F5B9
		public List<string> Occupations { get; set; }

		// Token: 0x17007598 RID: 30104
		// (get) Token: 0x06018529 RID: 99625 RVA: 0x003813C2 File Offset: 0x0037F5C2
		// (set) Token: 0x0601852A RID: 99626 RVA: 0x003813CA File Offset: 0x0037F5CA
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x17007599 RID: 30105
		// (get) Token: 0x0601852B RID: 99627 RVA: 0x003813D3 File Offset: 0x0037F5D3
		// (set) Token: 0x0601852C RID: 99628 RVA: 0x003813DB File Offset: 0x0037F5DB
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x1700759A RID: 30106
		// (get) Token: 0x0601852D RID: 99629 RVA: 0x003813E4 File Offset: 0x0037F5E4
		// (set) Token: 0x0601852E RID: 99630 RVA: 0x003813EC File Offset: 0x0037F5EC
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x1700759B RID: 30107
		// (get) Token: 0x0601852F RID: 99631 RVA: 0x003813F5 File Offset: 0x0037F5F5
		// (set) Token: 0x06018530 RID: 99632 RVA: 0x003813FD File Offset: 0x0037F5FD
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x1700759C RID: 30108
		// (get) Token: 0x06018531 RID: 99633 RVA: 0x00381406 File Offset: 0x0037F606
		// (set) Token: 0x06018532 RID: 99634 RVA: 0x0038140E File Offset: 0x0037F60E
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x1700759D RID: 30109
		// (get) Token: 0x06018533 RID: 99635 RVA: 0x00381417 File Offset: 0x0037F617
		// (set) Token: 0x06018534 RID: 99636 RVA: 0x0038141F File Offset: 0x0037F61F
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x1700759E RID: 30110
		// (get) Token: 0x06018535 RID: 99637 RVA: 0x00381428 File Offset: 0x0037F628
		// (set) Token: 0x06018536 RID: 99638 RVA: 0x00381430 File Offset: 0x0037F630
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x1700759F RID: 30111
		// (get) Token: 0x06018537 RID: 99639 RVA: 0x00381439 File Offset: 0x0037F639
		// (set) Token: 0x06018538 RID: 99640 RVA: 0x00381441 File Offset: 0x0037F641
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x170075A0 RID: 30112
		// (get) Token: 0x06018539 RID: 99641 RVA: 0x0038144A File Offset: 0x0037F64A
		// (set) Token: 0x0601853A RID: 99642 RVA: 0x00381452 File Offset: 0x0037F652
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x170075A1 RID: 30113
		// (get) Token: 0x0601853B RID: 99643 RVA: 0x0038145B File Offset: 0x0037F65B
		// (set) Token: 0x0601853C RID: 99644 RVA: 0x00381463 File Offset: 0x0037F663
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x170075A2 RID: 30114
		// (get) Token: 0x0601853D RID: 99645 RVA: 0x0038146C File Offset: 0x0037F66C
		// (set) Token: 0x0601853E RID: 99646 RVA: 0x00381474 File Offset: 0x0037F674
		public bool DisableSwitchGender { get; set; }

		// Token: 0x170075A3 RID: 30115
		// (get) Token: 0x0601853F RID: 99647 RVA: 0x0038147D File Offset: 0x0037F67D
		// (set) Token: 0x06018540 RID: 99648 RVA: 0x00381485 File Offset: 0x0037F685
		public bool DisableFocusMode { get; set; }

		// Token: 0x170075A4 RID: 30116
		// (get) Token: 0x06018541 RID: 99649 RVA: 0x0038148E File Offset: 0x0037F68E
		// (set) Token: 0x06018542 RID: 99650 RVA: 0x00381496 File Offset: 0x0037F696
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x170075A5 RID: 30117
		// (get) Token: 0x06018543 RID: 99651 RVA: 0x0038149F File Offset: 0x0037F69F
		// (set) Token: 0x06018544 RID: 99652 RVA: 0x003814A7 File Offset: 0x0037F6A7
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x170075A6 RID: 30118
		// (get) Token: 0x06018545 RID: 99653 RVA: 0x003814B0 File Offset: 0x0037F6B0
		// (set) Token: 0x06018546 RID: 99654 RVA: 0x003814B8 File Offset: 0x0037F6B8
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x170075A7 RID: 30119
		// (get) Token: 0x06018547 RID: 99655 RVA: 0x003814C1 File Offset: 0x0037F6C1
		// (set) Token: 0x06018548 RID: 99656 RVA: 0x003814C9 File Offset: 0x0037F6C9
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x170075A8 RID: 30120
		// (get) Token: 0x06018549 RID: 99657 RVA: 0x003814D2 File Offset: 0x0037F6D2
		// (set) Token: 0x0601854A RID: 99658 RVA: 0x003814DA File Offset: 0x0037F6DA
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x170075A9 RID: 30121
		// (get) Token: 0x0601854B RID: 99659 RVA: 0x003814E3 File Offset: 0x0037F6E3
		// (set) Token: 0x0601854C RID: 99660 RVA: 0x003814EB File Offset: 0x0037F6EB
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x170075AA RID: 30122
		// (get) Token: 0x0601854D RID: 99661 RVA: 0x003814F4 File Offset: 0x0037F6F4
		// (set) Token: 0x0601854E RID: 99662 RVA: 0x003814FC File Offset: 0x0037F6FC
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x170075AB RID: 30123
		// (get) Token: 0x0601854F RID: 99663 RVA: 0x00381505 File Offset: 0x0037F705
		// (set) Token: 0x06018550 RID: 99664 RVA: 0x0038150D File Offset: 0x0037F70D
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x170075AC RID: 30124
		// (get) Token: 0x06018551 RID: 99665 RVA: 0x00381516 File Offset: 0x0037F716
		// (set) Token: 0x06018552 RID: 99666 RVA: 0x0038151E File Offset: 0x0037F71E
		public List<TBtNodeUnion> Children { get; set; }

		// Token: 0x170075AD RID: 30125
		// (get) Token: 0x06018553 RID: 99667 RVA: 0x00381527 File Offset: 0x0037F727
		// (set) Token: 0x06018554 RID: 99668 RVA: 0x0038152F File Offset: 0x0037F72F
		public IPerformanceSettingT PerformanceSetting { get; set; }

		// Token: 0x170075AE RID: 30126
		// (get) Token: 0x06018555 RID: 99669 RVA: 0x00381538 File Offset: 0x0037F738
		// (set) Token: 0x06018556 RID: 99670 RVA: 0x00381540 File Offset: 0x0037F740
		public ushort NullMask { get; set; }

		// Token: 0x06018557 RID: 99671 RVA: 0x0038154C File Offset: 0x0037F74C
		public ISelectBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.UIConfig = null;
			this.InformationView = null;
			this.InformationBoard = null;
			this.TidQuestAliasName = null;
			this.TidQuestAliasDesc = null;
			this.DungeonId = 0;
			this.DisableOnline = false;
			this.SaveConfig = null;
			this.ForceClosedRestriction = null;
			this.Occupations = null;
			this.OccupationConfig = null;
			this.DisableSwitchOccupation = false;
			this.BudgetCameraType = EBudgetCameraType.Role;
			this.Statistics = null;
			this.CompositeTrackViewMode = ETrackViewMode.All;
			this.RewardConfig = null;
			this.SpecialGamePlayConfig = null;
			this.EnableSystem = null;
			this.StartWave = null;
			this.DisableTrackAnim = null;
			this.DisableSwitchGender = false;
			this.DisableFocusMode = false;
			this.DisableSkeletalAnimationCheck = false;
			this.LogicProgramSpecialProcess = null;
			this.QuestBuffActiveRange = null;
			this.SunSpiritProcess = null;
			this.ModifyTrackAreaText = null;
			this.DisableGlobalTraffic = false;
			this.DisableSystemPrompt = null;
			this.TrackCustomBoard = null;
			this.Children = null;
			this.PerformanceSetting = null;
			this.NullMask = 0;
		}
	}
}

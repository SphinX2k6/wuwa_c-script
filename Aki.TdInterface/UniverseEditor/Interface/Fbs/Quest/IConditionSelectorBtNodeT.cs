using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041CA RID: 16842
	public class IConditionSelectorBtNodeT
	{
		// Token: 0x17007298 RID: 29336
		// (get) Token: 0x0601754D RID: 95565 RVA: 0x00355B4C File Offset: 0x00353D4C
		// (set) Token: 0x0601754E RID: 95566 RVA: 0x00355B54 File Offset: 0x00353D54
		public EBtNode Type { get; set; }

		// Token: 0x17007299 RID: 29337
		// (get) Token: 0x0601754F RID: 95567 RVA: 0x00355B5D File Offset: 0x00353D5D
		// (set) Token: 0x06017550 RID: 95568 RVA: 0x00355B65 File Offset: 0x00353D65
		public int Id { get; set; }

		// Token: 0x1700729A RID: 29338
		// (get) Token: 0x06017551 RID: 95569 RVA: 0x00355B6E File Offset: 0x00353D6E
		// (set) Token: 0x06017552 RID: 95570 RVA: 0x00355B76 File Offset: 0x00353D76
		public string Desc { get; set; }

		// Token: 0x1700729B RID: 29339
		// (get) Token: 0x06017553 RID: 95571 RVA: 0x00355B7F File Offset: 0x00353D7F
		// (set) Token: 0x06017554 RID: 95572 RVA: 0x00355B87 File Offset: 0x00353D87
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x1700729C RID: 29340
		// (get) Token: 0x06017555 RID: 95573 RVA: 0x00355B90 File Offset: 0x00353D90
		// (set) Token: 0x06017556 RID: 95574 RVA: 0x00355B98 File Offset: 0x00353D98
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700729D RID: 29341
		// (get) Token: 0x06017557 RID: 95575 RVA: 0x00355BA1 File Offset: 0x00353DA1
		// (set) Token: 0x06017558 RID: 95576 RVA: 0x00355BA9 File Offset: 0x00353DA9
		public bool Disabled { get; set; }

		// Token: 0x1700729E RID: 29342
		// (get) Token: 0x06017559 RID: 95577 RVA: 0x00355BB2 File Offset: 0x00353DB2
		// (set) Token: 0x0601755A RID: 95578 RVA: 0x00355BBA File Offset: 0x00353DBA
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x1700729F RID: 29343
		// (get) Token: 0x0601755B RID: 95579 RVA: 0x00355BC3 File Offset: 0x00353DC3
		// (set) Token: 0x0601755C RID: 95580 RVA: 0x00355BCB File Offset: 0x00353DCB
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x170072A0 RID: 29344
		// (get) Token: 0x0601755D RID: 95581 RVA: 0x00355BD4 File Offset: 0x00353DD4
		// (set) Token: 0x0601755E RID: 95582 RVA: 0x00355BDC File Offset: 0x00353DDC
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x170072A1 RID: 29345
		// (get) Token: 0x0601755F RID: 95583 RVA: 0x00355BE5 File Offset: 0x00353DE5
		// (set) Token: 0x06017560 RID: 95584 RVA: 0x00355BED File Offset: 0x00353DED
		public string TidQuestAliasName { get; set; }

		// Token: 0x170072A2 RID: 29346
		// (get) Token: 0x06017561 RID: 95585 RVA: 0x00355BF6 File Offset: 0x00353DF6
		// (set) Token: 0x06017562 RID: 95586 RVA: 0x00355BFE File Offset: 0x00353DFE
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x170072A3 RID: 29347
		// (get) Token: 0x06017563 RID: 95587 RVA: 0x00355C07 File Offset: 0x00353E07
		// (set) Token: 0x06017564 RID: 95588 RVA: 0x00355C0F File Offset: 0x00353E0F
		public int DungeonId { get; set; }

		// Token: 0x170072A4 RID: 29348
		// (get) Token: 0x06017565 RID: 95589 RVA: 0x00355C18 File Offset: 0x00353E18
		// (set) Token: 0x06017566 RID: 95590 RVA: 0x00355C20 File Offset: 0x00353E20
		public bool DisableOnline { get; set; }

		// Token: 0x170072A5 RID: 29349
		// (get) Token: 0x06017567 RID: 95591 RVA: 0x00355C29 File Offset: 0x00353E29
		// (set) Token: 0x06017568 RID: 95592 RVA: 0x00355C31 File Offset: 0x00353E31
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x170072A6 RID: 29350
		// (get) Token: 0x06017569 RID: 95593 RVA: 0x00355C3A File Offset: 0x00353E3A
		// (set) Token: 0x0601756A RID: 95594 RVA: 0x00355C42 File Offset: 0x00353E42
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x170072A7 RID: 29351
		// (get) Token: 0x0601756B RID: 95595 RVA: 0x00355C4B File Offset: 0x00353E4B
		// (set) Token: 0x0601756C RID: 95596 RVA: 0x00355C53 File Offset: 0x00353E53
		public List<string> Occupations { get; set; }

		// Token: 0x170072A8 RID: 29352
		// (get) Token: 0x0601756D RID: 95597 RVA: 0x00355C5C File Offset: 0x00353E5C
		// (set) Token: 0x0601756E RID: 95598 RVA: 0x00355C64 File Offset: 0x00353E64
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x170072A9 RID: 29353
		// (get) Token: 0x0601756F RID: 95599 RVA: 0x00355C6D File Offset: 0x00353E6D
		// (set) Token: 0x06017570 RID: 95600 RVA: 0x00355C75 File Offset: 0x00353E75
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x170072AA RID: 29354
		// (get) Token: 0x06017571 RID: 95601 RVA: 0x00355C7E File Offset: 0x00353E7E
		// (set) Token: 0x06017572 RID: 95602 RVA: 0x00355C86 File Offset: 0x00353E86
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x170072AB RID: 29355
		// (get) Token: 0x06017573 RID: 95603 RVA: 0x00355C8F File Offset: 0x00353E8F
		// (set) Token: 0x06017574 RID: 95604 RVA: 0x00355C97 File Offset: 0x00353E97
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x170072AC RID: 29356
		// (get) Token: 0x06017575 RID: 95605 RVA: 0x00355CA0 File Offset: 0x00353EA0
		// (set) Token: 0x06017576 RID: 95606 RVA: 0x00355CA8 File Offset: 0x00353EA8
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x170072AD RID: 29357
		// (get) Token: 0x06017577 RID: 95607 RVA: 0x00355CB1 File Offset: 0x00353EB1
		// (set) Token: 0x06017578 RID: 95608 RVA: 0x00355CB9 File Offset: 0x00353EB9
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x170072AE RID: 29358
		// (get) Token: 0x06017579 RID: 95609 RVA: 0x00355CC2 File Offset: 0x00353EC2
		// (set) Token: 0x0601757A RID: 95610 RVA: 0x00355CCA File Offset: 0x00353ECA
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x170072AF RID: 29359
		// (get) Token: 0x0601757B RID: 95611 RVA: 0x00355CD3 File Offset: 0x00353ED3
		// (set) Token: 0x0601757C RID: 95612 RVA: 0x00355CDB File Offset: 0x00353EDB
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x170072B0 RID: 29360
		// (get) Token: 0x0601757D RID: 95613 RVA: 0x00355CE4 File Offset: 0x00353EE4
		// (set) Token: 0x0601757E RID: 95614 RVA: 0x00355CEC File Offset: 0x00353EEC
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x170072B1 RID: 29361
		// (get) Token: 0x0601757F RID: 95615 RVA: 0x00355CF5 File Offset: 0x00353EF5
		// (set) Token: 0x06017580 RID: 95616 RVA: 0x00355CFD File Offset: 0x00353EFD
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x170072B2 RID: 29362
		// (get) Token: 0x06017581 RID: 95617 RVA: 0x00355D06 File Offset: 0x00353F06
		// (set) Token: 0x06017582 RID: 95618 RVA: 0x00355D0E File Offset: 0x00353F0E
		public bool DisableSwitchGender { get; set; }

		// Token: 0x170072B3 RID: 29363
		// (get) Token: 0x06017583 RID: 95619 RVA: 0x00355D17 File Offset: 0x00353F17
		// (set) Token: 0x06017584 RID: 95620 RVA: 0x00355D1F File Offset: 0x00353F1F
		public bool DisableFocusMode { get; set; }

		// Token: 0x170072B4 RID: 29364
		// (get) Token: 0x06017585 RID: 95621 RVA: 0x00355D28 File Offset: 0x00353F28
		// (set) Token: 0x06017586 RID: 95622 RVA: 0x00355D30 File Offset: 0x00353F30
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x170072B5 RID: 29365
		// (get) Token: 0x06017587 RID: 95623 RVA: 0x00355D39 File Offset: 0x00353F39
		// (set) Token: 0x06017588 RID: 95624 RVA: 0x00355D41 File Offset: 0x00353F41
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x170072B6 RID: 29366
		// (get) Token: 0x06017589 RID: 95625 RVA: 0x00355D4A File Offset: 0x00353F4A
		// (set) Token: 0x0601758A RID: 95626 RVA: 0x00355D52 File Offset: 0x00353F52
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x170072B7 RID: 29367
		// (get) Token: 0x0601758B RID: 95627 RVA: 0x00355D5B File Offset: 0x00353F5B
		// (set) Token: 0x0601758C RID: 95628 RVA: 0x00355D63 File Offset: 0x00353F63
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x170072B8 RID: 29368
		// (get) Token: 0x0601758D RID: 95629 RVA: 0x00355D6C File Offset: 0x00353F6C
		// (set) Token: 0x0601758E RID: 95630 RVA: 0x00355D74 File Offset: 0x00353F74
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x170072B9 RID: 29369
		// (get) Token: 0x0601758F RID: 95631 RVA: 0x00355D7D File Offset: 0x00353F7D
		// (set) Token: 0x06017590 RID: 95632 RVA: 0x00355D85 File Offset: 0x00353F85
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x170072BA RID: 29370
		// (get) Token: 0x06017591 RID: 95633 RVA: 0x00355D8E File Offset: 0x00353F8E
		// (set) Token: 0x06017592 RID: 95634 RVA: 0x00355D96 File Offset: 0x00353F96
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x170072BB RID: 29371
		// (get) Token: 0x06017593 RID: 95635 RVA: 0x00355D9F File Offset: 0x00353F9F
		// (set) Token: 0x06017594 RID: 95636 RVA: 0x00355DA7 File Offset: 0x00353FA7
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x170072BC RID: 29372
		// (get) Token: 0x06017595 RID: 95637 RVA: 0x00355DB0 File Offset: 0x00353FB0
		// (set) Token: 0x06017596 RID: 95638 RVA: 0x00355DB8 File Offset: 0x00353FB8
		public bool PendingClientResults { get; set; }

		// Token: 0x170072BD RID: 29373
		// (get) Token: 0x06017597 RID: 95639 RVA: 0x00355DC1 File Offset: 0x00353FC1
		// (set) Token: 0x06017598 RID: 95640 RVA: 0x00355DC9 File Offset: 0x00353FC9
		public List<IConditionSelectorBtNodeSlotT> Slots { get; set; }

		// Token: 0x170072BE RID: 29374
		// (get) Token: 0x06017599 RID: 95641 RVA: 0x00355DD2 File Offset: 0x00353FD2
		// (set) Token: 0x0601759A RID: 95642 RVA: 0x00355DDA File Offset: 0x00353FDA
		public ushort NullMask { get; set; }

		// Token: 0x0601759B RID: 95643 RVA: 0x00355DE4 File Offset: 0x00353FE4
		public IConditionSelectorBtNodeT()
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
			this.PendingClientResults = false;
			this.Slots = null;
			this.NullMask = 0;
		}
	}
}

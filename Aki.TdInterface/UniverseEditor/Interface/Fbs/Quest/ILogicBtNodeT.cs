using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200434D RID: 17229
	public class ILogicBtNodeT
	{
		// Token: 0x1700760D RID: 30221
		// (get) Token: 0x06018488 RID: 99464 RVA: 0x00376E55 File Offset: 0x00375055
		// (set) Token: 0x06018489 RID: 99465 RVA: 0x00376E5D File Offset: 0x0037505D
		public EBtNode Type { get; set; }

		// Token: 0x1700760E RID: 30222
		// (get) Token: 0x0601848A RID: 99466 RVA: 0x00376E66 File Offset: 0x00375066
		// (set) Token: 0x0601848B RID: 99467 RVA: 0x00376E6E File Offset: 0x0037506E
		public int Id { get; set; }

		// Token: 0x1700760F RID: 30223
		// (get) Token: 0x0601848C RID: 99468 RVA: 0x00376E77 File Offset: 0x00375077
		// (set) Token: 0x0601848D RID: 99469 RVA: 0x00376E7F File Offset: 0x0037507F
		public string Desc { get; set; }

		// Token: 0x17007610 RID: 30224
		// (get) Token: 0x0601848E RID: 99470 RVA: 0x00376E88 File Offset: 0x00375088
		// (set) Token: 0x0601848F RID: 99471 RVA: 0x00376E90 File Offset: 0x00375090
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007611 RID: 30225
		// (get) Token: 0x06018490 RID: 99472 RVA: 0x00376E99 File Offset: 0x00375099
		// (set) Token: 0x06018491 RID: 99473 RVA: 0x00376EA1 File Offset: 0x003750A1
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007612 RID: 30226
		// (get) Token: 0x06018492 RID: 99474 RVA: 0x00376EAA File Offset: 0x003750AA
		// (set) Token: 0x06018493 RID: 99475 RVA: 0x00376EB2 File Offset: 0x003750B2
		public bool Disabled { get; set; }

		// Token: 0x17007613 RID: 30227
		// (get) Token: 0x06018494 RID: 99476 RVA: 0x00376EBB File Offset: 0x003750BB
		// (set) Token: 0x06018495 RID: 99477 RVA: 0x00376EC3 File Offset: 0x003750C3
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x17007614 RID: 30228
		// (get) Token: 0x06018496 RID: 99478 RVA: 0x00376ECC File Offset: 0x003750CC
		// (set) Token: 0x06018497 RID: 99479 RVA: 0x00376ED4 File Offset: 0x003750D4
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x17007615 RID: 30229
		// (get) Token: 0x06018498 RID: 99480 RVA: 0x00376EDD File Offset: 0x003750DD
		// (set) Token: 0x06018499 RID: 99481 RVA: 0x00376EE5 File Offset: 0x003750E5
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x17007616 RID: 30230
		// (get) Token: 0x0601849A RID: 99482 RVA: 0x00376EEE File Offset: 0x003750EE
		// (set) Token: 0x0601849B RID: 99483 RVA: 0x00376EF6 File Offset: 0x003750F6
		public string TidQuestAliasName { get; set; }

		// Token: 0x17007617 RID: 30231
		// (get) Token: 0x0601849C RID: 99484 RVA: 0x00376EFF File Offset: 0x003750FF
		// (set) Token: 0x0601849D RID: 99485 RVA: 0x00376F07 File Offset: 0x00375107
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x17007618 RID: 30232
		// (get) Token: 0x0601849E RID: 99486 RVA: 0x00376F10 File Offset: 0x00375110
		// (set) Token: 0x0601849F RID: 99487 RVA: 0x00376F18 File Offset: 0x00375118
		public int DungeonId { get; set; }

		// Token: 0x17007619 RID: 30233
		// (get) Token: 0x060184A0 RID: 99488 RVA: 0x00376F21 File Offset: 0x00375121
		// (set) Token: 0x060184A1 RID: 99489 RVA: 0x00376F29 File Offset: 0x00375129
		public bool DisableOnline { get; set; }

		// Token: 0x1700761A RID: 30234
		// (get) Token: 0x060184A2 RID: 99490 RVA: 0x00376F32 File Offset: 0x00375132
		// (set) Token: 0x060184A3 RID: 99491 RVA: 0x00376F3A File Offset: 0x0037513A
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x1700761B RID: 30235
		// (get) Token: 0x060184A4 RID: 99492 RVA: 0x00376F43 File Offset: 0x00375143
		// (set) Token: 0x060184A5 RID: 99493 RVA: 0x00376F4B File Offset: 0x0037514B
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x1700761C RID: 30236
		// (get) Token: 0x060184A6 RID: 99494 RVA: 0x00376F54 File Offset: 0x00375154
		// (set) Token: 0x060184A7 RID: 99495 RVA: 0x00376F5C File Offset: 0x0037515C
		public List<string> Occupations { get; set; }

		// Token: 0x1700761D RID: 30237
		// (get) Token: 0x060184A8 RID: 99496 RVA: 0x00376F65 File Offset: 0x00375165
		// (set) Token: 0x060184A9 RID: 99497 RVA: 0x00376F6D File Offset: 0x0037516D
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x1700761E RID: 30238
		// (get) Token: 0x060184AA RID: 99498 RVA: 0x00376F76 File Offset: 0x00375176
		// (set) Token: 0x060184AB RID: 99499 RVA: 0x00376F7E File Offset: 0x0037517E
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x1700761F RID: 30239
		// (get) Token: 0x060184AC RID: 99500 RVA: 0x00376F87 File Offset: 0x00375187
		// (set) Token: 0x060184AD RID: 99501 RVA: 0x00376F8F File Offset: 0x0037518F
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x17007620 RID: 30240
		// (get) Token: 0x060184AE RID: 99502 RVA: 0x00376F98 File Offset: 0x00375198
		// (set) Token: 0x060184AF RID: 99503 RVA: 0x00376FA0 File Offset: 0x003751A0
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x17007621 RID: 30241
		// (get) Token: 0x060184B0 RID: 99504 RVA: 0x00376FA9 File Offset: 0x003751A9
		// (set) Token: 0x060184B1 RID: 99505 RVA: 0x00376FB1 File Offset: 0x003751B1
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x17007622 RID: 30242
		// (get) Token: 0x060184B2 RID: 99506 RVA: 0x00376FBA File Offset: 0x003751BA
		// (set) Token: 0x060184B3 RID: 99507 RVA: 0x00376FC2 File Offset: 0x003751C2
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x17007623 RID: 30243
		// (get) Token: 0x060184B4 RID: 99508 RVA: 0x00376FCB File Offset: 0x003751CB
		// (set) Token: 0x060184B5 RID: 99509 RVA: 0x00376FD3 File Offset: 0x003751D3
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x17007624 RID: 30244
		// (get) Token: 0x060184B6 RID: 99510 RVA: 0x00376FDC File Offset: 0x003751DC
		// (set) Token: 0x060184B7 RID: 99511 RVA: 0x00376FE4 File Offset: 0x003751E4
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x17007625 RID: 30245
		// (get) Token: 0x060184B8 RID: 99512 RVA: 0x00376FED File Offset: 0x003751ED
		// (set) Token: 0x060184B9 RID: 99513 RVA: 0x00376FF5 File Offset: 0x003751F5
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x17007626 RID: 30246
		// (get) Token: 0x060184BA RID: 99514 RVA: 0x00376FFE File Offset: 0x003751FE
		// (set) Token: 0x060184BB RID: 99515 RVA: 0x00377006 File Offset: 0x00375206
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x17007627 RID: 30247
		// (get) Token: 0x060184BC RID: 99516 RVA: 0x0037700F File Offset: 0x0037520F
		// (set) Token: 0x060184BD RID: 99517 RVA: 0x00377017 File Offset: 0x00375217
		public bool DisableSwitchGender { get; set; }

		// Token: 0x17007628 RID: 30248
		// (get) Token: 0x060184BE RID: 99518 RVA: 0x00377020 File Offset: 0x00375220
		// (set) Token: 0x060184BF RID: 99519 RVA: 0x00377028 File Offset: 0x00375228
		public bool DisableFocusMode { get; set; }

		// Token: 0x17007629 RID: 30249
		// (get) Token: 0x060184C0 RID: 99520 RVA: 0x00377031 File Offset: 0x00375231
		// (set) Token: 0x060184C1 RID: 99521 RVA: 0x00377039 File Offset: 0x00375239
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x1700762A RID: 30250
		// (get) Token: 0x060184C2 RID: 99522 RVA: 0x00377042 File Offset: 0x00375242
		// (set) Token: 0x060184C3 RID: 99523 RVA: 0x0037704A File Offset: 0x0037524A
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x1700762B RID: 30251
		// (get) Token: 0x060184C4 RID: 99524 RVA: 0x00377053 File Offset: 0x00375253
		// (set) Token: 0x060184C5 RID: 99525 RVA: 0x0037705B File Offset: 0x0037525B
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x1700762C RID: 30252
		// (get) Token: 0x060184C6 RID: 99526 RVA: 0x00377064 File Offset: 0x00375264
		// (set) Token: 0x060184C7 RID: 99527 RVA: 0x0037706C File Offset: 0x0037526C
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x1700762D RID: 30253
		// (get) Token: 0x060184C8 RID: 99528 RVA: 0x00377075 File Offset: 0x00375275
		// (set) Token: 0x060184C9 RID: 99529 RVA: 0x0037707D File Offset: 0x0037527D
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x1700762E RID: 30254
		// (get) Token: 0x060184CA RID: 99530 RVA: 0x00377086 File Offset: 0x00375286
		// (set) Token: 0x060184CB RID: 99531 RVA: 0x0037708E File Offset: 0x0037528E
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x1700762F RID: 30255
		// (get) Token: 0x060184CC RID: 99532 RVA: 0x00377097 File Offset: 0x00375297
		// (set) Token: 0x060184CD RID: 99533 RVA: 0x0037709F File Offset: 0x0037529F
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x17007630 RID: 30256
		// (get) Token: 0x060184CE RID: 99534 RVA: 0x003770A8 File Offset: 0x003752A8
		// (set) Token: 0x060184CF RID: 99535 RVA: 0x003770B0 File Offset: 0x003752B0
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x17007631 RID: 30257
		// (get) Token: 0x060184D0 RID: 99536 RVA: 0x003770B9 File Offset: 0x003752B9
		// (set) Token: 0x060184D1 RID: 99537 RVA: 0x003770C1 File Offset: 0x003752C1
		public ushort NullMask { get; set; }

		// Token: 0x060184D2 RID: 99538 RVA: 0x003770CC File Offset: 0x003752CC
		public ILogicBtNodeT()
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
			this.NullMask = 0;
		}
	}
}

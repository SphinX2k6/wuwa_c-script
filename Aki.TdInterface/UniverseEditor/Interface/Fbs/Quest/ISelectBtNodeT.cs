using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200454B RID: 17739
	public class ISelectBtNodeT
	{
		// Token: 0x17007B8E RID: 31630
		// (get) Token: 0x06019BAB RID: 105387 RVA: 0x003AB25E File Offset: 0x003A945E
		// (set) Token: 0x06019BAC RID: 105388 RVA: 0x003AB266 File Offset: 0x003A9466
		public EBtNode Type { get; set; }

		// Token: 0x17007B8F RID: 31631
		// (get) Token: 0x06019BAD RID: 105389 RVA: 0x003AB26F File Offset: 0x003A946F
		// (set) Token: 0x06019BAE RID: 105390 RVA: 0x003AB277 File Offset: 0x003A9477
		public int Id { get; set; }

		// Token: 0x17007B90 RID: 31632
		// (get) Token: 0x06019BAF RID: 105391 RVA: 0x003AB280 File Offset: 0x003A9480
		// (set) Token: 0x06019BB0 RID: 105392 RVA: 0x003AB288 File Offset: 0x003A9488
		public string Desc { get; set; }

		// Token: 0x17007B91 RID: 31633
		// (get) Token: 0x06019BB1 RID: 105393 RVA: 0x003AB291 File Offset: 0x003A9491
		// (set) Token: 0x06019BB2 RID: 105394 RVA: 0x003AB299 File Offset: 0x003A9499
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007B92 RID: 31634
		// (get) Token: 0x06019BB3 RID: 105395 RVA: 0x003AB2A2 File Offset: 0x003A94A2
		// (set) Token: 0x06019BB4 RID: 105396 RVA: 0x003AB2AA File Offset: 0x003A94AA
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007B93 RID: 31635
		// (get) Token: 0x06019BB5 RID: 105397 RVA: 0x003AB2B3 File Offset: 0x003A94B3
		// (set) Token: 0x06019BB6 RID: 105398 RVA: 0x003AB2BB File Offset: 0x003A94BB
		public bool Disabled { get; set; }

		// Token: 0x17007B94 RID: 31636
		// (get) Token: 0x06019BB7 RID: 105399 RVA: 0x003AB2C4 File Offset: 0x003A94C4
		// (set) Token: 0x06019BB8 RID: 105400 RVA: 0x003AB2CC File Offset: 0x003A94CC
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x17007B95 RID: 31637
		// (get) Token: 0x06019BB9 RID: 105401 RVA: 0x003AB2D5 File Offset: 0x003A94D5
		// (set) Token: 0x06019BBA RID: 105402 RVA: 0x003AB2DD File Offset: 0x003A94DD
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x17007B96 RID: 31638
		// (get) Token: 0x06019BBB RID: 105403 RVA: 0x003AB2E6 File Offset: 0x003A94E6
		// (set) Token: 0x06019BBC RID: 105404 RVA: 0x003AB2EE File Offset: 0x003A94EE
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x17007B97 RID: 31639
		// (get) Token: 0x06019BBD RID: 105405 RVA: 0x003AB2F7 File Offset: 0x003A94F7
		// (set) Token: 0x06019BBE RID: 105406 RVA: 0x003AB2FF File Offset: 0x003A94FF
		public string TidQuestAliasName { get; set; }

		// Token: 0x17007B98 RID: 31640
		// (get) Token: 0x06019BBF RID: 105407 RVA: 0x003AB308 File Offset: 0x003A9508
		// (set) Token: 0x06019BC0 RID: 105408 RVA: 0x003AB310 File Offset: 0x003A9510
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x17007B99 RID: 31641
		// (get) Token: 0x06019BC1 RID: 105409 RVA: 0x003AB319 File Offset: 0x003A9519
		// (set) Token: 0x06019BC2 RID: 105410 RVA: 0x003AB321 File Offset: 0x003A9521
		public int DungeonId { get; set; }

		// Token: 0x17007B9A RID: 31642
		// (get) Token: 0x06019BC3 RID: 105411 RVA: 0x003AB32A File Offset: 0x003A952A
		// (set) Token: 0x06019BC4 RID: 105412 RVA: 0x003AB332 File Offset: 0x003A9532
		public bool DisableOnline { get; set; }

		// Token: 0x17007B9B RID: 31643
		// (get) Token: 0x06019BC5 RID: 105413 RVA: 0x003AB33B File Offset: 0x003A953B
		// (set) Token: 0x06019BC6 RID: 105414 RVA: 0x003AB343 File Offset: 0x003A9543
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x17007B9C RID: 31644
		// (get) Token: 0x06019BC7 RID: 105415 RVA: 0x003AB34C File Offset: 0x003A954C
		// (set) Token: 0x06019BC8 RID: 105416 RVA: 0x003AB354 File Offset: 0x003A9554
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x17007B9D RID: 31645
		// (get) Token: 0x06019BC9 RID: 105417 RVA: 0x003AB35D File Offset: 0x003A955D
		// (set) Token: 0x06019BCA RID: 105418 RVA: 0x003AB365 File Offset: 0x003A9565
		public List<string> Occupations { get; set; }

		// Token: 0x17007B9E RID: 31646
		// (get) Token: 0x06019BCB RID: 105419 RVA: 0x003AB36E File Offset: 0x003A956E
		// (set) Token: 0x06019BCC RID: 105420 RVA: 0x003AB376 File Offset: 0x003A9576
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x17007B9F RID: 31647
		// (get) Token: 0x06019BCD RID: 105421 RVA: 0x003AB37F File Offset: 0x003A957F
		// (set) Token: 0x06019BCE RID: 105422 RVA: 0x003AB387 File Offset: 0x003A9587
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x17007BA0 RID: 31648
		// (get) Token: 0x06019BCF RID: 105423 RVA: 0x003AB390 File Offset: 0x003A9590
		// (set) Token: 0x06019BD0 RID: 105424 RVA: 0x003AB398 File Offset: 0x003A9598
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x17007BA1 RID: 31649
		// (get) Token: 0x06019BD1 RID: 105425 RVA: 0x003AB3A1 File Offset: 0x003A95A1
		// (set) Token: 0x06019BD2 RID: 105426 RVA: 0x003AB3A9 File Offset: 0x003A95A9
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x17007BA2 RID: 31650
		// (get) Token: 0x06019BD3 RID: 105427 RVA: 0x003AB3B2 File Offset: 0x003A95B2
		// (set) Token: 0x06019BD4 RID: 105428 RVA: 0x003AB3BA File Offset: 0x003A95BA
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x17007BA3 RID: 31651
		// (get) Token: 0x06019BD5 RID: 105429 RVA: 0x003AB3C3 File Offset: 0x003A95C3
		// (set) Token: 0x06019BD6 RID: 105430 RVA: 0x003AB3CB File Offset: 0x003A95CB
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x17007BA4 RID: 31652
		// (get) Token: 0x06019BD7 RID: 105431 RVA: 0x003AB3D4 File Offset: 0x003A95D4
		// (set) Token: 0x06019BD8 RID: 105432 RVA: 0x003AB3DC File Offset: 0x003A95DC
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x17007BA5 RID: 31653
		// (get) Token: 0x06019BD9 RID: 105433 RVA: 0x003AB3E5 File Offset: 0x003A95E5
		// (set) Token: 0x06019BDA RID: 105434 RVA: 0x003AB3ED File Offset: 0x003A95ED
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x17007BA6 RID: 31654
		// (get) Token: 0x06019BDB RID: 105435 RVA: 0x003AB3F6 File Offset: 0x003A95F6
		// (set) Token: 0x06019BDC RID: 105436 RVA: 0x003AB3FE File Offset: 0x003A95FE
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x17007BA7 RID: 31655
		// (get) Token: 0x06019BDD RID: 105437 RVA: 0x003AB407 File Offset: 0x003A9607
		// (set) Token: 0x06019BDE RID: 105438 RVA: 0x003AB40F File Offset: 0x003A960F
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x17007BA8 RID: 31656
		// (get) Token: 0x06019BDF RID: 105439 RVA: 0x003AB418 File Offset: 0x003A9618
		// (set) Token: 0x06019BE0 RID: 105440 RVA: 0x003AB420 File Offset: 0x003A9620
		public bool DisableSwitchGender { get; set; }

		// Token: 0x17007BA9 RID: 31657
		// (get) Token: 0x06019BE1 RID: 105441 RVA: 0x003AB429 File Offset: 0x003A9629
		// (set) Token: 0x06019BE2 RID: 105442 RVA: 0x003AB431 File Offset: 0x003A9631
		public bool DisableFocusMode { get; set; }

		// Token: 0x17007BAA RID: 31658
		// (get) Token: 0x06019BE3 RID: 105443 RVA: 0x003AB43A File Offset: 0x003A963A
		// (set) Token: 0x06019BE4 RID: 105444 RVA: 0x003AB442 File Offset: 0x003A9642
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x17007BAB RID: 31659
		// (get) Token: 0x06019BE5 RID: 105445 RVA: 0x003AB44B File Offset: 0x003A964B
		// (set) Token: 0x06019BE6 RID: 105446 RVA: 0x003AB453 File Offset: 0x003A9653
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x17007BAC RID: 31660
		// (get) Token: 0x06019BE7 RID: 105447 RVA: 0x003AB45C File Offset: 0x003A965C
		// (set) Token: 0x06019BE8 RID: 105448 RVA: 0x003AB464 File Offset: 0x003A9664
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x17007BAD RID: 31661
		// (get) Token: 0x06019BE9 RID: 105449 RVA: 0x003AB46D File Offset: 0x003A966D
		// (set) Token: 0x06019BEA RID: 105450 RVA: 0x003AB475 File Offset: 0x003A9675
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x17007BAE RID: 31662
		// (get) Token: 0x06019BEB RID: 105451 RVA: 0x003AB47E File Offset: 0x003A967E
		// (set) Token: 0x06019BEC RID: 105452 RVA: 0x003AB486 File Offset: 0x003A9686
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x17007BAF RID: 31663
		// (get) Token: 0x06019BED RID: 105453 RVA: 0x003AB48F File Offset: 0x003A968F
		// (set) Token: 0x06019BEE RID: 105454 RVA: 0x003AB497 File Offset: 0x003A9697
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x17007BB0 RID: 31664
		// (get) Token: 0x06019BEF RID: 105455 RVA: 0x003AB4A0 File Offset: 0x003A96A0
		// (set) Token: 0x06019BF0 RID: 105456 RVA: 0x003AB4A8 File Offset: 0x003A96A8
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x17007BB1 RID: 31665
		// (get) Token: 0x06019BF1 RID: 105457 RVA: 0x003AB4B1 File Offset: 0x003A96B1
		// (set) Token: 0x06019BF2 RID: 105458 RVA: 0x003AB4B9 File Offset: 0x003A96B9
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x17007BB2 RID: 31666
		// (get) Token: 0x06019BF3 RID: 105459 RVA: 0x003AB4C2 File Offset: 0x003A96C2
		// (set) Token: 0x06019BF4 RID: 105460 RVA: 0x003AB4CA File Offset: 0x003A96CA
		public List<TBtNodeUnion> Children { get; set; }

		// Token: 0x17007BB3 RID: 31667
		// (get) Token: 0x06019BF5 RID: 105461 RVA: 0x003AB4D3 File Offset: 0x003A96D3
		// (set) Token: 0x06019BF6 RID: 105462 RVA: 0x003AB4DB File Offset: 0x003A96DB
		public IPerformanceSettingT PerformanceSetting { get; set; }

		// Token: 0x17007BB4 RID: 31668
		// (get) Token: 0x06019BF7 RID: 105463 RVA: 0x003AB4E4 File Offset: 0x003A96E4
		// (set) Token: 0x06019BF8 RID: 105464 RVA: 0x003AB4EC File Offset: 0x003A96EC
		public ushort NullMask { get; set; }

		// Token: 0x06019BF9 RID: 105465 RVA: 0x003AB4F8 File Offset: 0x003A96F8
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

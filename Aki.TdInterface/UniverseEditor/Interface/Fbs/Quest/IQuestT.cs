using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004407 RID: 17415
	public class IQuestT
	{
		// Token: 0x1700782C RID: 30764
		// (get) Token: 0x06018CDE RID: 101598 RVA: 0x00389E3F File Offset: 0x0038803F
		// (set) Token: 0x06018CDF RID: 101599 RVA: 0x00389E47 File Offset: 0x00388047
		public string ObjType { get; set; }

		// Token: 0x1700782D RID: 30765
		// (get) Token: 0x06018CE0 RID: 101600 RVA: 0x00389E50 File Offset: 0x00388050
		// (set) Token: 0x06018CE1 RID: 101601 RVA: 0x00389E58 File Offset: 0x00388058
		public List<string> Children { get; set; }

		// Token: 0x1700782E RID: 30766
		// (get) Token: 0x06018CE2 RID: 101602 RVA: 0x00389E61 File Offset: 0x00388061
		// (set) Token: 0x06018CE3 RID: 101603 RVA: 0x00389E69 File Offset: 0x00388069
		public List<string> Reference { get; set; }

		// Token: 0x1700782F RID: 30767
		// (get) Token: 0x06018CE4 RID: 101604 RVA: 0x00389E72 File Offset: 0x00388072
		// (set) Token: 0x06018CE5 RID: 101605 RVA: 0x00389E7A File Offset: 0x0038807A
		public List<string> WeakReference { get; set; }

		// Token: 0x17007830 RID: 30768
		// (get) Token: 0x06018CE6 RID: 101606 RVA: 0x00389E83 File Offset: 0x00388083
		// (set) Token: 0x06018CE7 RID: 101607 RVA: 0x00389E8B File Offset: 0x0038808B
		public EQuest Type { get; set; }

		// Token: 0x17007831 RID: 30769
		// (get) Token: 0x06018CE8 RID: 101608 RVA: 0x00389E94 File Offset: 0x00388094
		// (set) Token: 0x06018CE9 RID: 101609 RVA: 0x00389E9C File Offset: 0x0038809C
		public EQuestSubType SubType { get; set; }

		// Token: 0x17007832 RID: 30770
		// (get) Token: 0x06018CEA RID: 101610 RVA: 0x00389EA5 File Offset: 0x003880A5
		// (set) Token: 0x06018CEB RID: 101611 RVA: 0x00389EAD File Offset: 0x003880AD
		public int Id { get; set; }

		// Token: 0x17007833 RID: 30771
		// (get) Token: 0x06018CEC RID: 101612 RVA: 0x00389EB6 File Offset: 0x003880B6
		// (set) Token: 0x06018CED RID: 101613 RVA: 0x00389EBE File Offset: 0x003880BE
		public int DungeonId { get; set; }

		// Token: 0x17007834 RID: 30772
		// (get) Token: 0x06018CEE RID: 101614 RVA: 0x00389EC7 File Offset: 0x003880C7
		// (set) Token: 0x06018CEF RID: 101615 RVA: 0x00389ECF File Offset: 0x003880CF
		public List<ESystemModuleName> BindSystems { get; set; }

		// Token: 0x17007835 RID: 30773
		// (get) Token: 0x06018CF0 RID: 101616 RVA: 0x00389ED8 File Offset: 0x003880D8
		// (set) Token: 0x06018CF1 RID: 101617 RVA: 0x00389EE0 File Offset: 0x003880E0
		public string TidName { get; set; }

		// Token: 0x17007836 RID: 30774
		// (get) Token: 0x06018CF2 RID: 101618 RVA: 0x00389EE9 File Offset: 0x003880E9
		// (set) Token: 0x06018CF3 RID: 101619 RVA: 0x00389EF1 File Offset: 0x003880F1
		public string Key { get; set; }

		// Token: 0x17007837 RID: 30775
		// (get) Token: 0x06018CF4 RID: 101620 RVA: 0x00389EFA File Offset: 0x003880FA
		// (set) Token: 0x06018CF5 RID: 101621 RVA: 0x00389F02 File Offset: 0x00388102
		public string TidDesc { get; set; }

		// Token: 0x17007838 RID: 30776
		// (get) Token: 0x06018CF6 RID: 101622 RVA: 0x00389F0B File Offset: 0x0038810B
		// (set) Token: 0x06018CF7 RID: 101623 RVA: 0x00389F13 File Offset: 0x00388113
		public EQuestOnlineType OnlineType { get; set; }

		// Token: 0x17007839 RID: 30777
		// (get) Token: 0x06018CF8 RID: 101624 RVA: 0x00389F1C File Offset: 0x0038811C
		// (set) Token: 0x06018CF9 RID: 101625 RVA: 0x00389F24 File Offset: 0x00388124
		public bool IsAutoTrack { get; set; }

		// Token: 0x1700783A RID: 30778
		// (get) Token: 0x06018CFA RID: 101626 RVA: 0x00389F2D File Offset: 0x0038812D
		// (set) Token: 0x06018CFB RID: 101627 RVA: 0x00389F35 File Offset: 0x00388135
		public bool IsAutoCoverCurTrack { get; set; }

		// Token: 0x1700783B RID: 30779
		// (get) Token: 0x06018CFC RID: 101628 RVA: 0x00389F3E File Offset: 0x0038813E
		// (set) Token: 0x06018CFD RID: 101629 RVA: 0x00389F46 File Offset: 0x00388146
		public int RewardId { get; set; }

		// Token: 0x1700783C RID: 30780
		// (get) Token: 0x06018CFE RID: 101630 RVA: 0x00389F4F File Offset: 0x0038814F
		// (set) Token: 0x06018CFF RID: 101631 RVA: 0x00389F57 File Offset: 0x00388157
		public EQuestRegion RegionId { get; set; }

		// Token: 0x1700783D RID: 30781
		// (get) Token: 0x06018D00 RID: 101632 RVA: 0x00389F60 File Offset: 0x00388160
		// (set) Token: 0x06018D01 RID: 101633 RVA: 0x00389F68 File Offset: 0x00388168
		public int ChapterId { get; set; }

		// Token: 0x1700783E RID: 30782
		// (get) Token: 0x06018D02 RID: 101634 RVA: 0x00389F71 File Offset: 0x00388171
		// (set) Token: 0x06018D03 RID: 101635 RVA: 0x00389F79 File Offset: 0x00388179
		public int TagId { get; set; }

		// Token: 0x1700783F RID: 30783
		// (get) Token: 0x06018D04 RID: 101636 RVA: 0x00389F82 File Offset: 0x00388182
		// (set) Token: 0x06018D05 RID: 101637 RVA: 0x00389F8A File Offset: 0x0038818A
		public int FunctionId { get; set; }

		// Token: 0x17007840 RID: 30784
		// (get) Token: 0x06018D06 RID: 101638 RVA: 0x00389F93 File Offset: 0x00388193
		// (set) Token: 0x06018D07 RID: 101639 RVA: 0x00389F9B File Offset: 0x0038819B
		public string RoleId { get; set; }

		// Token: 0x17007841 RID: 30785
		// (get) Token: 0x06018D08 RID: 101640 RVA: 0x00389FA4 File Offset: 0x003881A4
		// (set) Token: 0x06018D09 RID: 101641 RVA: 0x00389FAC File Offset: 0x003881AC
		public EDistrubuteType DistributeType { get; set; }

		// Token: 0x17007842 RID: 30786
		// (get) Token: 0x06018D0A RID: 101642 RVA: 0x00389FB5 File Offset: 0x003881B5
		// (set) Token: 0x06018D0B RID: 101643 RVA: 0x00389FBD File Offset: 0x003881BD
		public IDistributeParamsT DistributeParams { get; set; }

		// Token: 0x17007843 RID: 30787
		// (get) Token: 0x06018D0C RID: 101644 RVA: 0x00389FC6 File Offset: 0x003881C6
		// (set) Token: 0x06018D0D RID: 101645 RVA: 0x00389FCE File Offset: 0x003881CE
		public bool IsHideAcceptMarkOnNpc { get; set; }

		// Token: 0x17007844 RID: 30788
		// (get) Token: 0x06018D0E RID: 101646 RVA: 0x00389FD7 File Offset: 0x003881D7
		// (set) Token: 0x06018D0F RID: 101647 RVA: 0x00389FDF File Offset: 0x003881DF
		public bool IsHideInTaskList { get; set; }

		// Token: 0x17007845 RID: 30789
		// (get) Token: 0x06018D10 RID: 101648 RVA: 0x00389FE8 File Offset: 0x003881E8
		// (set) Token: 0x06018D11 RID: 101649 RVA: 0x00389FF0 File Offset: 0x003881F0
		public IAccessQuestConditionT ProvideType { get; set; }

		// Token: 0x17007846 RID: 30790
		// (get) Token: 0x06018D12 RID: 101650 RVA: 0x00389FF9 File Offset: 0x003881F9
		// (set) Token: 0x06018D13 RID: 101651 RVA: 0x0038A001 File Offset: 0x00388201
		public IAccessQuestConditionT AutoTrackConditions { get; set; }

		// Token: 0x17007847 RID: 30791
		// (get) Token: 0x06018D14 RID: 101652 RVA: 0x0038A00A File Offset: 0x0038820A
		// (set) Token: 0x06018D15 RID: 101653 RVA: 0x0038A012 File Offset: 0x00388212
		public List<int> RecommendPreQuest { get; set; }

		// Token: 0x17007848 RID: 30792
		// (get) Token: 0x06018D16 RID: 101654 RVA: 0x0038A01B File Offset: 0x0038821B
		// (set) Token: 0x06018D17 RID: 101655 RVA: 0x0038A023 File Offset: 0x00388223
		public int RecommendationPriority { get; set; }

		// Token: 0x17007849 RID: 30793
		// (get) Token: 0x06018D18 RID: 101656 RVA: 0x0038A02C File Offset: 0x0038822C
		// (set) Token: 0x06018D19 RID: 101657 RVA: 0x0038A034 File Offset: 0x00388234
		public IQuestUnlockDelayTimeT UnlockDelayTime { get; set; }

		// Token: 0x1700784A RID: 30794
		// (get) Token: 0x06018D1A RID: 101658 RVA: 0x0038A03D File Offset: 0x0038823D
		// (set) Token: 0x06018D1B RID: 101659 RVA: 0x0038A045 File Offset: 0x00388245
		public IPreShowInfoT PreShowInfo { get; set; }

		// Token: 0x1700784B RID: 30795
		// (get) Token: 0x06018D1C RID: 101660 RVA: 0x0038A04E File Offset: 0x0038824E
		// (set) Token: 0x06018D1D RID: 101661 RVA: 0x0038A056 File Offset: 0x00388256
		public IAddInteractOptionT AddInteractOption { get; set; }

		// Token: 0x1700784C RID: 30796
		// (get) Token: 0x06018D1E RID: 101662 RVA: 0x0038A05F File Offset: 0x0038825F
		// (set) Token: 0x06018D1F RID: 101663 RVA: 0x0038A067 File Offset: 0x00388267
		public List<IActionInfoT> ActiveActions { get; set; }

		// Token: 0x1700784D RID: 30797
		// (get) Token: 0x06018D20 RID: 101664 RVA: 0x0038A070 File Offset: 0x00388270
		// (set) Token: 0x06018D21 RID: 101665 RVA: 0x0038A078 File Offset: 0x00388278
		public List<IActionInfoT> AcceptActions { get; set; }

		// Token: 0x1700784E RID: 30798
		// (get) Token: 0x06018D22 RID: 101666 RVA: 0x0038A081 File Offset: 0x00388281
		// (set) Token: 0x06018D23 RID: 101667 RVA: 0x0038A089 File Offset: 0x00388289
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700784F RID: 30799
		// (get) Token: 0x06018D24 RID: 101668 RVA: 0x0038A092 File Offset: 0x00388292
		// (set) Token: 0x06018D25 RID: 101669 RVA: 0x0038A09A File Offset: 0x0038829A
		public List<IActionInfoT> TerminateActions { get; set; }

		// Token: 0x17007850 RID: 30800
		// (get) Token: 0x06018D26 RID: 101670 RVA: 0x0038A0A3 File Offset: 0x003882A3
		// (set) Token: 0x06018D27 RID: 101671 RVA: 0x0038A0AB File Offset: 0x003882AB
		public List<IActionInfoT> TerminateActions2 { get; set; }

		// Token: 0x17007851 RID: 30801
		// (get) Token: 0x06018D28 RID: 101672 RVA: 0x0038A0B4 File Offset: 0x003882B4
		// (set) Token: 0x06018D29 RID: 101673 RVA: 0x0038A0BC File Offset: 0x003882BC
		public List<int> ReferenceAllEntity { get; set; }

		// Token: 0x17007852 RID: 30802
		// (get) Token: 0x06018D2A RID: 101674 RVA: 0x0038A0C5 File Offset: 0x003882C5
		// (set) Token: 0x06018D2B RID: 101675 RVA: 0x0038A0CD File Offset: 0x003882CD
		public int ActivityId { get; set; }

		// Token: 0x17007853 RID: 30803
		// (get) Token: 0x06018D2C RID: 101676 RVA: 0x0038A0D6 File Offset: 0x003882D6
		// (set) Token: 0x06018D2D RID: 101677 RVA: 0x0038A0DE File Offset: 0x003882DE
		public IFocusModeSettingT FocusModeSetting { get; set; }

		// Token: 0x17007854 RID: 30804
		// (get) Token: 0x06018D2E RID: 101678 RVA: 0x0038A0E7 File Offset: 0x003882E7
		// (set) Token: 0x06018D2F RID: 101679 RVA: 0x0038A0EF File Offset: 0x003882EF
		public IHardBattleModeSettingT HardBattleModeSetting { get; set; }

		// Token: 0x17007855 RID: 30805
		// (get) Token: 0x06018D30 RID: 101680 RVA: 0x0038A0F8 File Offset: 0x003882F8
		// (set) Token: 0x06018D31 RID: 101681 RVA: 0x0038A100 File Offset: 0x00388300
		public bool DelayDestroy { get; set; }

		// Token: 0x17007856 RID: 30806
		// (get) Token: 0x06018D32 RID: 101682 RVA: 0x0038A109 File Offset: 0x00388309
		// (set) Token: 0x06018D33 RID: 101683 RVA: 0x0038A111 File Offset: 0x00388311
		public IBehaviorTreeT Tree { get; set; }

		// Token: 0x17007857 RID: 30807
		// (get) Token: 0x06018D34 RID: 101684 RVA: 0x0038A11A File Offset: 0x0038831A
		// (set) Token: 0x06018D35 RID: 101685 RVA: 0x0038A122 File Offset: 0x00388322
		public IQuestRecallConfigT RecallConfig { get; set; }

		// Token: 0x17007858 RID: 30808
		// (get) Token: 0x06018D36 RID: 101686 RVA: 0x0038A12B File Offset: 0x0038832B
		// (set) Token: 0x06018D37 RID: 101687 RVA: 0x0038A133 File Offset: 0x00388333
		public IEntityRefSearchPropT _EntityRefSearch { get; set; }

		// Token: 0x17007859 RID: 30809
		// (get) Token: 0x06018D38 RID: 101688 RVA: 0x0038A13C File Offset: 0x0038833C
		// (set) Token: 0x06018D39 RID: 101689 RVA: 0x0038A144 File Offset: 0x00388344
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x1700785A RID: 30810
		// (get) Token: 0x06018D3A RID: 101690 RVA: 0x0038A14D File Offset: 0x0038834D
		// (set) Token: 0x06018D3B RID: 101691 RVA: 0x0038A155 File Offset: 0x00388355
		public string _FocusDataPath { get; set; }

		// Token: 0x1700785B RID: 30811
		// (get) Token: 0x06018D3C RID: 101692 RVA: 0x0038A15E File Offset: 0x0038835E
		// (set) Token: 0x06018D3D RID: 101693 RVA: 0x0038A166 File Offset: 0x00388366
		public uint NullMask { get; set; }

		// Token: 0x06018D3E RID: 101694 RVA: 0x0038A170 File Offset: 0x00388370
		public IQuestT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Type = EQuest.None;
			this.SubType = EQuestSubType.None;
			this.Id = 0;
			this.DungeonId = 0;
			this.BindSystems = null;
			this.TidName = null;
			this.Key = null;
			this.TidDesc = null;
			this.OnlineType = EQuestOnlineType.SingleHangUpOnline;
			this.IsAutoTrack = false;
			this.IsAutoCoverCurTrack = false;
			this.RewardId = 0;
			this.RegionId = EQuestRegion.None;
			this.ChapterId = 0;
			this.TagId = 0;
			this.FunctionId = 0;
			this.RoleId = null;
			this.DistributeType = EDistrubuteType.Interact;
			this.DistributeParams = null;
			this.IsHideAcceptMarkOnNpc = false;
			this.IsHideInTaskList = false;
			this.ProvideType = null;
			this.AutoTrackConditions = null;
			this.RecommendPreQuest = null;
			this.RecommendationPriority = 0;
			this.UnlockDelayTime = null;
			this.PreShowInfo = null;
			this.AddInteractOption = null;
			this.ActiveActions = null;
			this.AcceptActions = null;
			this.FinishActions = null;
			this.TerminateActions = null;
			this.TerminateActions2 = null;
			this.ReferenceAllEntity = null;
			this.ActivityId = 0;
			this.FocusModeSetting = null;
			this.HardBattleModeSetting = null;
			this.DelayDestroy = false;
			this.Tree = null;
			this.RecallConfig = null;
			this._EntityRefSearch = null;
			this._HighlightDataPaths = null;
			this._FocusDataPath = null;
			this.NullMask = 0U;
		}
	}
}

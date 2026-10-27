using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E9 RID: 17641
	public class ILevelPlayT
	{
		// Token: 0x17007CCE RID: 31950
		// (get) Token: 0x0601A723 RID: 108323 RVA: 0x003C78CE File Offset: 0x003C5ACE
		// (set) Token: 0x0601A724 RID: 108324 RVA: 0x003C78D6 File Offset: 0x003C5AD6
		public string ObjType { get; set; }

		// Token: 0x17007CCF RID: 31951
		// (get) Token: 0x0601A725 RID: 108325 RVA: 0x003C78DF File Offset: 0x003C5ADF
		// (set) Token: 0x0601A726 RID: 108326 RVA: 0x003C78E7 File Offset: 0x003C5AE7
		public List<string> Children { get; set; }

		// Token: 0x17007CD0 RID: 31952
		// (get) Token: 0x0601A727 RID: 108327 RVA: 0x003C78F0 File Offset: 0x003C5AF0
		// (set) Token: 0x0601A728 RID: 108328 RVA: 0x003C78F8 File Offset: 0x003C5AF8
		public List<string> Reference { get; set; }

		// Token: 0x17007CD1 RID: 31953
		// (get) Token: 0x0601A729 RID: 108329 RVA: 0x003C7901 File Offset: 0x003C5B01
		// (set) Token: 0x0601A72A RID: 108330 RVA: 0x003C7909 File Offset: 0x003C5B09
		public List<string> WeakReference { get; set; }

		// Token: 0x17007CD2 RID: 31954
		// (get) Token: 0x0601A72B RID: 108331 RVA: 0x003C7912 File Offset: 0x003C5B12
		// (set) Token: 0x0601A72C RID: 108332 RVA: 0x003C791A File Offset: 0x003C5B1A
		public int Id { get; set; }

		// Token: 0x17007CD3 RID: 31955
		// (get) Token: 0x0601A72D RID: 108333 RVA: 0x003C7923 File Offset: 0x003C5B23
		// (set) Token: 0x0601A72E RID: 108334 RVA: 0x003C792B File Offset: 0x003C5B2B
		public string Key { get; set; }

		// Token: 0x17007CD4 RID: 31956
		// (get) Token: 0x0601A72F RID: 108335 RVA: 0x003C7934 File Offset: 0x003C5B34
		// (set) Token: 0x0601A730 RID: 108336 RVA: 0x003C793C File Offset: 0x003C5B3C
		public ELevelPlayType Type { get; set; }

		// Token: 0x17007CD5 RID: 31957
		// (get) Token: 0x0601A731 RID: 108337 RVA: 0x003C7945 File Offset: 0x003C5B45
		// (set) Token: 0x0601A732 RID: 108338 RVA: 0x003C794D File Offset: 0x003C5B4D
		public EDecisionBtType DecisionBtType { get; set; }

		// Token: 0x17007CD6 RID: 31958
		// (get) Token: 0x0601A733 RID: 108339 RVA: 0x003C7956 File Offset: 0x003C5B56
		// (set) Token: 0x0601A734 RID: 108340 RVA: 0x003C795E File Offset: 0x003C5B5E
		public List<ESystemModuleName> BindSystems { get; set; }

		// Token: 0x17007CD7 RID: 31959
		// (get) Token: 0x0601A735 RID: 108341 RVA: 0x003C7967 File Offset: 0x003C5B67
		// (set) Token: 0x0601A736 RID: 108342 RVA: 0x003C796F File Offset: 0x003C5B6F
		public string TidName { get; set; }

		// Token: 0x17007CD8 RID: 31960
		// (get) Token: 0x0601A737 RID: 108343 RVA: 0x003C7978 File Offset: 0x003C5B78
		// (set) Token: 0x0601A738 RID: 108344 RVA: 0x003C7980 File Offset: 0x003C5B80
		public int LevelId { get; set; }

		// Token: 0x17007CD9 RID: 31961
		// (get) Token: 0x0601A739 RID: 108345 RVA: 0x003C7989 File Offset: 0x003C5B89
		// (set) Token: 0x0601A73A RID: 108346 RVA: 0x003C7991 File Offset: 0x003C5B91
		public int PackId { get; set; }

		// Token: 0x17007CDA RID: 31962
		// (get) Token: 0x0601A73B RID: 108347 RVA: 0x003C799A File Offset: 0x003C5B9A
		// (set) Token: 0x0601A73C RID: 108348 RVA: 0x003C79A2 File Offset: 0x003C5BA2
		public int InstanceId { get; set; }

		// Token: 0x17007CDB RID: 31963
		// (get) Token: 0x0601A73D RID: 108349 RVA: 0x003C79AB File Offset: 0x003C5BAB
		// (set) Token: 0x0601A73E RID: 108350 RVA: 0x003C79B3 File Offset: 0x003C5BB3
		public bool IsOnlineStandalone { get; set; }

		// Token: 0x17007CDC RID: 31964
		// (get) Token: 0x0601A73F RID: 108351 RVA: 0x003C79BC File Offset: 0x003C5BBC
		// (set) Token: 0x0601A740 RID: 108352 RVA: 0x003C79C4 File Offset: 0x003C5BC4
		public List<string> SpecifiedOnlineStandaloneParentUids { get; set; }

		// Token: 0x17007CDD RID: 31965
		// (get) Token: 0x0601A741 RID: 108353 RVA: 0x003C79CD File Offset: 0x003C5BCD
		// (set) Token: 0x0601A742 RID: 108354 RVA: 0x003C79D5 File Offset: 0x003C5BD5
		public ELevelPlayOnlineType OnlineType { get; set; }

		// Token: 0x17007CDE RID: 31966
		// (get) Token: 0x0601A743 RID: 108355 RVA: 0x003C79DE File Offset: 0x003C5BDE
		// (set) Token: 0x0601A744 RID: 108356 RVA: 0x003C79E6 File Offset: 0x003C5BE6
		public string InternalDest { get; set; }

		// Token: 0x17007CDF RID: 31967
		// (get) Token: 0x0601A745 RID: 108357 RVA: 0x003C79EF File Offset: 0x003C5BEF
		// (set) Token: 0x0601A746 RID: 108358 RVA: 0x003C79F7 File Offset: 0x003C5BF7
		public int LevelAdditiveId { get; set; }

		// Token: 0x17007CE0 RID: 31968
		// (get) Token: 0x0601A747 RID: 108359 RVA: 0x003C7A00 File Offset: 0x003C5C00
		// (set) Token: 0x0601A748 RID: 108360 RVA: 0x003C7A08 File Offset: 0x003C5C08
		public int LevelAiTeamLevelId { get; set; }

		// Token: 0x17007CE1 RID: 31969
		// (get) Token: 0x0601A749 RID: 108361 RVA: 0x003C7A11 File Offset: 0x003C5C11
		// (set) Token: 0x0601A74A RID: 108362 RVA: 0x003C7A19 File Offset: 0x003C5C19
		public ILevelPlayZaxisT LevelPlayZaxis { get; set; }

		// Token: 0x17007CE2 RID: 31970
		// (get) Token: 0x0601A74B RID: 108363 RVA: 0x003C7A22 File Offset: 0x003C5C22
		// (set) Token: 0x0601A74C RID: 108364 RVA: 0x003C7A2A File Offset: 0x003C5C2A
		public int LevelPlayEntityId { get; set; }

		// Token: 0x17007CE3 RID: 31971
		// (get) Token: 0x0601A74D RID: 108365 RVA: 0x003C7A33 File Offset: 0x003C5C33
		// (set) Token: 0x0601A74E RID: 108366 RVA: 0x003C7A3B File Offset: 0x003C5C3B
		public int EnterRadius { get; set; }

		// Token: 0x17007CE4 RID: 31972
		// (get) Token: 0x0601A74F RID: 108367 RVA: 0x003C7A44 File Offset: 0x003C5C44
		// (set) Token: 0x0601A750 RID: 108368 RVA: 0x003C7A4C File Offset: 0x003C5C4C
		public int LeaveRadius { get; set; }

		// Token: 0x17007CE5 RID: 31973
		// (get) Token: 0x0601A751 RID: 108369 RVA: 0x003C7A55 File Offset: 0x003C5C55
		// (set) Token: 0x0601A752 RID: 108370 RVA: 0x003C7A5D File Offset: 0x003C5C5D
		public bool DelayRefresh { get; set; }

		// Token: 0x17007CE6 RID: 31974
		// (get) Token: 0x0601A753 RID: 108371 RVA: 0x003C7A66 File Offset: 0x003C5C66
		// (set) Token: 0x0601A754 RID: 108372 RVA: 0x003C7A6E File Offset: 0x003C5C6E
		public bool DelayDestroy { get; set; }

		// Token: 0x17007CE7 RID: 31975
		// (get) Token: 0x0601A755 RID: 108373 RVA: 0x003C7A77 File Offset: 0x003C5C77
		// (set) Token: 0x0601A756 RID: 108374 RVA: 0x003C7A7F File Offset: 0x003C5C7F
		public bool NotAllowHidedByGroup { get; set; }

		// Token: 0x17007CE8 RID: 31976
		// (get) Token: 0x0601A757 RID: 108375 RVA: 0x003C7A88 File Offset: 0x003C5C88
		// (set) Token: 0x0601A758 RID: 108376 RVA: 0x003C7A90 File Offset: 0x003C5C90
		public bool AutoRestoreTreeAddedPlayerBuff { get; set; }

		// Token: 0x17007CE9 RID: 31977
		// (get) Token: 0x0601A759 RID: 108377 RVA: 0x003C7A99 File Offset: 0x003C5C99
		// (set) Token: 0x0601A75A RID: 108378 RVA: 0x003C7AA1 File Offset: 0x003C5CA1
		public List<IActionInfoT> EnterInRangeActions { get; set; }

		// Token: 0x17007CEA RID: 31978
		// (get) Token: 0x0601A75B RID: 108379 RVA: 0x003C7AAA File Offset: 0x003C5CAA
		// (set) Token: 0x0601A75C RID: 108380 RVA: 0x003C7AB2 File Offset: 0x003C5CB2
		public List<IActionInfoT> LevelPlayCloseActions { get; set; }

		// Token: 0x17007CEB RID: 31979
		// (get) Token: 0x0601A75D RID: 108381 RVA: 0x003C7ABB File Offset: 0x003C5CBB
		// (set) Token: 0x0601A75E RID: 108382 RVA: 0x003C7AC3 File Offset: 0x003C5CC3
		public ILevelPlayMarkT LevelPlayMark { get; set; }

		// Token: 0x17007CEC RID: 31980
		// (get) Token: 0x0601A75F RID: 108383 RVA: 0x003C7ACC File Offset: 0x003C5CCC
		// (set) Token: 0x0601A760 RID: 108384 RVA: 0x003C7AD4 File Offset: 0x003C5CD4
		public ILevelPlayTrackT LevelPlayTrack { get; set; }

		// Token: 0x17007CED RID: 31981
		// (get) Token: 0x0601A761 RID: 108385 RVA: 0x003C7ADD File Offset: 0x003C5CDD
		// (set) Token: 0x0601A762 RID: 108386 RVA: 0x003C7AE5 File Offset: 0x003C5CE5
		public TLevelPlayRewardUnion LevelPlayRewardConfig { get; set; }

		// Token: 0x17007CEE RID: 31982
		// (get) Token: 0x0601A763 RID: 108387 RVA: 0x003C7AEE File Offset: 0x003C5CEE
		// (set) Token: 0x0601A764 RID: 108388 RVA: 0x003C7AF6 File Offset: 0x003C5CF6
		public TLevelPlayRefreshUnion LevelPlayRefreshConfig { get; set; }

		// Token: 0x17007CEF RID: 31983
		// (get) Token: 0x0601A765 RID: 108389 RVA: 0x003C7AFF File Offset: 0x003C5CFF
		// (set) Token: 0x0601A766 RID: 108390 RVA: 0x003C7B07 File Offset: 0x003C5D07
		public ILevelPlayOpenConditionT LevelPlayOpenCondition { get; set; }

		// Token: 0x17007CF0 RID: 31984
		// (get) Token: 0x0601A767 RID: 108391 RVA: 0x003C7B10 File Offset: 0x003C5D10
		// (set) Token: 0x0601A768 RID: 108392 RVA: 0x003C7B18 File Offset: 0x003C5D18
		public ILevelPlayActiveT LevelPlayActive { get; set; }

		// Token: 0x17007CF1 RID: 31985
		// (get) Token: 0x0601A769 RID: 108393 RVA: 0x003C7B21 File Offset: 0x003C5D21
		// (set) Token: 0x0601A76A RID: 108394 RVA: 0x003C7B29 File Offset: 0x003C5D29
		public List<IActionInfoT> LevelPlayOpenActions { get; set; }

		// Token: 0x17007CF2 RID: 31986
		// (get) Token: 0x0601A76B RID: 108395 RVA: 0x003C7B32 File Offset: 0x003C5D32
		// (set) Token: 0x0601A76C RID: 108396 RVA: 0x003C7B3A File Offset: 0x003C5D3A
		public List<IActionInfoT> EscActionsAfterDungeonCompletion { get; set; }

		// Token: 0x17007CF3 RID: 31987
		// (get) Token: 0x0601A76D RID: 108397 RVA: 0x003C7B43 File Offset: 0x003C5D43
		// (set) Token: 0x0601A76E RID: 108398 RVA: 0x003C7B4B File Offset: 0x003C5D4B
		public int ExploratoryDegree { get; set; }

		// Token: 0x17007CF4 RID: 31988
		// (get) Token: 0x0601A76F RID: 108399 RVA: 0x003C7B54 File Offset: 0x003C5D54
		// (set) Token: 0x0601A770 RID: 108400 RVA: 0x003C7B5C File Offset: 0x003C5D5C
		public ILevelPlayExploratoryConfigT ExploratoryConfig { get; set; }

		// Token: 0x17007CF5 RID: 31989
		// (get) Token: 0x0601A771 RID: 108401 RVA: 0x003C7B65 File Offset: 0x003C5D65
		// (set) Token: 0x0601A772 RID: 108402 RVA: 0x003C7B6D File Offset: 0x003C5D6D
		public List<int> ReferenceAllEntity { get; set; }

		// Token: 0x17007CF6 RID: 31990
		// (get) Token: 0x0601A773 RID: 108403 RVA: 0x003C7B76 File Offset: 0x003C5D76
		// (set) Token: 0x0601A774 RID: 108404 RVA: 0x003C7B7E File Offset: 0x003C5D7E
		public IBehaviorTreeT Tree { get; set; }

		// Token: 0x17007CF7 RID: 31991
		// (get) Token: 0x0601A775 RID: 108405 RVA: 0x003C7B87 File Offset: 0x003C5D87
		// (set) Token: 0x0601A776 RID: 108406 RVA: 0x003C7B8F File Offset: 0x003C5D8F
		public ILevelPlayFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007CF8 RID: 31992
		// (get) Token: 0x0601A777 RID: 108407 RVA: 0x003C7B98 File Offset: 0x003C5D98
		// (set) Token: 0x0601A778 RID: 108408 RVA: 0x003C7BA0 File Offset: 0x003C5DA0
		public int CustomIcon { get; set; }

		// Token: 0x17007CF9 RID: 31993
		// (get) Token: 0x0601A779 RID: 108409 RVA: 0x003C7BA9 File Offset: 0x003C5DA9
		// (set) Token: 0x0601A77A RID: 108410 RVA: 0x003C7BB1 File Offset: 0x003C5DB1
		public int CustomTrackUiIcon { get; set; }

		// Token: 0x17007CFA RID: 31994
		// (get) Token: 0x0601A77B RID: 108411 RVA: 0x003C7BBA File Offset: 0x003C5DBA
		// (set) Token: 0x0601A77C RID: 108412 RVA: 0x003C7BC2 File Offset: 0x003C5DC2
		public IRangeAbsorbPhantomT RangeAbsorbPhantom { get; set; }

		// Token: 0x17007CFB RID: 31995
		// (get) Token: 0x0601A77D RID: 108413 RVA: 0x003C7BCB File Offset: 0x003C5DCB
		// (set) Token: 0x0601A77E RID: 108414 RVA: 0x003C7BD3 File Offset: 0x003C5DD3
		public IRewardConfigT RewardConfig { get; set; }

		// Token: 0x17007CFC RID: 31996
		// (get) Token: 0x0601A77F RID: 108415 RVA: 0x003C7BDC File Offset: 0x003C5DDC
		// (set) Token: 0x0601A780 RID: 108416 RVA: 0x003C7BE4 File Offset: 0x003C5DE4
		public bool IsTrackOnlyWhenQuestBind { get; set; }

		// Token: 0x17007CFD RID: 31997
		// (get) Token: 0x0601A781 RID: 108417 RVA: 0x003C7BED File Offset: 0x003C5DED
		// (set) Token: 0x0601A782 RID: 108418 RVA: 0x003C7BF5 File Offset: 0x003C5DF5
		public ILevelPlayRecallConfigT RecallConfig { get; set; }

		// Token: 0x17007CFE RID: 31998
		// (get) Token: 0x0601A783 RID: 108419 RVA: 0x003C7BFE File Offset: 0x003C5DFE
		// (set) Token: 0x0601A784 RID: 108420 RVA: 0x003C7C06 File Offset: 0x003C5E06
		public IEntityRefSearchPropT _EntityRefSearch { get; set; }

		// Token: 0x17007CFF RID: 31999
		// (get) Token: 0x0601A785 RID: 108421 RVA: 0x003C7C0F File Offset: 0x003C5E0F
		// (set) Token: 0x0601A786 RID: 108422 RVA: 0x003C7C17 File Offset: 0x003C5E17
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x17007D00 RID: 32000
		// (get) Token: 0x0601A787 RID: 108423 RVA: 0x003C7C20 File Offset: 0x003C5E20
		// (set) Token: 0x0601A788 RID: 108424 RVA: 0x003C7C28 File Offset: 0x003C5E28
		public string _FocusDataPath { get; set; }

		// Token: 0x17007D01 RID: 32001
		// (get) Token: 0x0601A789 RID: 108425 RVA: 0x003C7C31 File Offset: 0x003C5E31
		// (set) Token: 0x0601A78A RID: 108426 RVA: 0x003C7C39 File Offset: 0x003C5E39
		public uint NullMask { get; set; }

		// Token: 0x0601A78B RID: 108427 RVA: 0x003C7C44 File Offset: 0x003C5E44
		public ILevelPlayT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Id = 0;
			this.Key = null;
			this.Type = ELevelPlayType.SilentArea;
			this.DecisionBtType = EDecisionBtType.Bvb;
			this.BindSystems = null;
			this.TidName = null;
			this.LevelId = 0;
			this.PackId = 0;
			this.InstanceId = 0;
			this.IsOnlineStandalone = false;
			this.SpecifiedOnlineStandaloneParentUids = null;
			this.OnlineType = ELevelPlayOnlineType.Local;
			this.InternalDest = null;
			this.LevelAdditiveId = 0;
			this.LevelAiTeamLevelId = 0;
			this.LevelPlayZaxis = null;
			this.LevelPlayEntityId = 0;
			this.EnterRadius = 0;
			this.LeaveRadius = 0;
			this.DelayRefresh = false;
			this.DelayDestroy = false;
			this.NotAllowHidedByGroup = false;
			this.AutoRestoreTreeAddedPlayerBuff = false;
			this.EnterInRangeActions = null;
			this.LevelPlayCloseActions = null;
			this.LevelPlayMark = null;
			this.LevelPlayTrack = null;
			this.LevelPlayRewardConfig = null;
			this.LevelPlayRefreshConfig = null;
			this.LevelPlayOpenCondition = null;
			this.LevelPlayActive = null;
			this.LevelPlayOpenActions = null;
			this.EscActionsAfterDungeonCompletion = null;
			this.ExploratoryDegree = 0;
			this.ExploratoryConfig = null;
			this.ReferenceAllEntity = null;
			this.Tree = null;
			this.FixProcessor = null;
			this.CustomIcon = 0;
			this.CustomTrackUiIcon = 0;
			this.RangeAbsorbPhantom = null;
			this.RewardConfig = null;
			this.IsTrackOnlyWhenQuestBind = false;
			this.RecallConfig = null;
			this._EntityRefSearch = null;
			this._HighlightDataPaths = null;
			this._FocusDataPath = null;
			this.NullMask = 0U;
		}
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004951 RID: 18769
	public class ILevelPlayT
	{
		// Token: 0x1700830E RID: 33550
		// (get) Token: 0x0601BEF6 RID: 114422 RVA: 0x003F3B40 File Offset: 0x003F1D40
		// (set) Token: 0x0601BEF7 RID: 114423 RVA: 0x003F3B48 File Offset: 0x003F1D48
		public string ObjType { get; set; }

		// Token: 0x1700830F RID: 33551
		// (get) Token: 0x0601BEF8 RID: 114424 RVA: 0x003F3B51 File Offset: 0x003F1D51
		// (set) Token: 0x0601BEF9 RID: 114425 RVA: 0x003F3B59 File Offset: 0x003F1D59
		public List<string> Children { get; set; }

		// Token: 0x17008310 RID: 33552
		// (get) Token: 0x0601BEFA RID: 114426 RVA: 0x003F3B62 File Offset: 0x003F1D62
		// (set) Token: 0x0601BEFB RID: 114427 RVA: 0x003F3B6A File Offset: 0x003F1D6A
		public List<string> Reference { get; set; }

		// Token: 0x17008311 RID: 33553
		// (get) Token: 0x0601BEFC RID: 114428 RVA: 0x003F3B73 File Offset: 0x003F1D73
		// (set) Token: 0x0601BEFD RID: 114429 RVA: 0x003F3B7B File Offset: 0x003F1D7B
		public List<string> WeakReference { get; set; }

		// Token: 0x17008312 RID: 33554
		// (get) Token: 0x0601BEFE RID: 114430 RVA: 0x003F3B84 File Offset: 0x003F1D84
		// (set) Token: 0x0601BEFF RID: 114431 RVA: 0x003F3B8C File Offset: 0x003F1D8C
		public int Id { get; set; }

		// Token: 0x17008313 RID: 33555
		// (get) Token: 0x0601BF00 RID: 114432 RVA: 0x003F3B95 File Offset: 0x003F1D95
		// (set) Token: 0x0601BF01 RID: 114433 RVA: 0x003F3B9D File Offset: 0x003F1D9D
		public string Key { get; set; }

		// Token: 0x17008314 RID: 33556
		// (get) Token: 0x0601BF02 RID: 114434 RVA: 0x003F3BA6 File Offset: 0x003F1DA6
		// (set) Token: 0x0601BF03 RID: 114435 RVA: 0x003F3BAE File Offset: 0x003F1DAE
		public ELevelPlayType Type { get; set; }

		// Token: 0x17008315 RID: 33557
		// (get) Token: 0x0601BF04 RID: 114436 RVA: 0x003F3BB7 File Offset: 0x003F1DB7
		// (set) Token: 0x0601BF05 RID: 114437 RVA: 0x003F3BBF File Offset: 0x003F1DBF
		public EDecisionBtType DecisionBtType { get; set; }

		// Token: 0x17008316 RID: 33558
		// (get) Token: 0x0601BF06 RID: 114438 RVA: 0x003F3BC8 File Offset: 0x003F1DC8
		// (set) Token: 0x0601BF07 RID: 114439 RVA: 0x003F3BD0 File Offset: 0x003F1DD0
		public int PrefabId { get; set; }

		// Token: 0x17008317 RID: 33559
		// (get) Token: 0x0601BF08 RID: 114440 RVA: 0x003F3BD9 File Offset: 0x003F1DD9
		// (set) Token: 0x0601BF09 RID: 114441 RVA: 0x003F3BE1 File Offset: 0x003F1DE1
		public List<ESystemModuleName> BindSystems { get; set; }

		// Token: 0x17008318 RID: 33560
		// (get) Token: 0x0601BF0A RID: 114442 RVA: 0x003F3BEA File Offset: 0x003F1DEA
		// (set) Token: 0x0601BF0B RID: 114443 RVA: 0x003F3BF2 File Offset: 0x003F1DF2
		public string TidName { get; set; }

		// Token: 0x17008319 RID: 33561
		// (get) Token: 0x0601BF0C RID: 114444 RVA: 0x003F3BFB File Offset: 0x003F1DFB
		// (set) Token: 0x0601BF0D RID: 114445 RVA: 0x003F3C03 File Offset: 0x003F1E03
		public int LevelId { get; set; }

		// Token: 0x1700831A RID: 33562
		// (get) Token: 0x0601BF0E RID: 114446 RVA: 0x003F3C0C File Offset: 0x003F1E0C
		// (set) Token: 0x0601BF0F RID: 114447 RVA: 0x003F3C14 File Offset: 0x003F1E14
		public int PackId { get; set; }

		// Token: 0x1700831B RID: 33563
		// (get) Token: 0x0601BF10 RID: 114448 RVA: 0x003F3C1D File Offset: 0x003F1E1D
		// (set) Token: 0x0601BF11 RID: 114449 RVA: 0x003F3C25 File Offset: 0x003F1E25
		public int InstanceId { get; set; }

		// Token: 0x1700831C RID: 33564
		// (get) Token: 0x0601BF12 RID: 114450 RVA: 0x003F3C2E File Offset: 0x003F1E2E
		// (set) Token: 0x0601BF13 RID: 114451 RVA: 0x003F3C36 File Offset: 0x003F1E36
		public bool IsOnlineStandalone { get; set; }

		// Token: 0x1700831D RID: 33565
		// (get) Token: 0x0601BF14 RID: 114452 RVA: 0x003F3C3F File Offset: 0x003F1E3F
		// (set) Token: 0x0601BF15 RID: 114453 RVA: 0x003F3C47 File Offset: 0x003F1E47
		public List<string> SpecifiedOnlineStandaloneParentUids { get; set; }

		// Token: 0x1700831E RID: 33566
		// (get) Token: 0x0601BF16 RID: 114454 RVA: 0x003F3C50 File Offset: 0x003F1E50
		// (set) Token: 0x0601BF17 RID: 114455 RVA: 0x003F3C58 File Offset: 0x003F1E58
		public ELevelPlayOnlineType OnlineType { get; set; }

		// Token: 0x1700831F RID: 33567
		// (get) Token: 0x0601BF18 RID: 114456 RVA: 0x003F3C61 File Offset: 0x003F1E61
		// (set) Token: 0x0601BF19 RID: 114457 RVA: 0x003F3C69 File Offset: 0x003F1E69
		public string InternalDest { get; set; }

		// Token: 0x17008320 RID: 33568
		// (get) Token: 0x0601BF1A RID: 114458 RVA: 0x003F3C72 File Offset: 0x003F1E72
		// (set) Token: 0x0601BF1B RID: 114459 RVA: 0x003F3C7A File Offset: 0x003F1E7A
		public int LevelAdditiveId { get; set; }

		// Token: 0x17008321 RID: 33569
		// (get) Token: 0x0601BF1C RID: 114460 RVA: 0x003F3C83 File Offset: 0x003F1E83
		// (set) Token: 0x0601BF1D RID: 114461 RVA: 0x003F3C8B File Offset: 0x003F1E8B
		public int LevelAiTeamLevelId { get; set; }

		// Token: 0x17008322 RID: 33570
		// (get) Token: 0x0601BF1E RID: 114462 RVA: 0x003F3C94 File Offset: 0x003F1E94
		// (set) Token: 0x0601BF1F RID: 114463 RVA: 0x003F3C9C File Offset: 0x003F1E9C
		public ILevelPlayZaxisT LevelPlayZaxis { get; set; }

		// Token: 0x17008323 RID: 33571
		// (get) Token: 0x0601BF20 RID: 114464 RVA: 0x003F3CA5 File Offset: 0x003F1EA5
		// (set) Token: 0x0601BF21 RID: 114465 RVA: 0x003F3CAD File Offset: 0x003F1EAD
		public int LevelPlayEntityId { get; set; }

		// Token: 0x17008324 RID: 33572
		// (get) Token: 0x0601BF22 RID: 114466 RVA: 0x003F3CB6 File Offset: 0x003F1EB6
		// (set) Token: 0x0601BF23 RID: 114467 RVA: 0x003F3CBE File Offset: 0x003F1EBE
		public int EnterRadius { get; set; }

		// Token: 0x17008325 RID: 33573
		// (get) Token: 0x0601BF24 RID: 114468 RVA: 0x003F3CC7 File Offset: 0x003F1EC7
		// (set) Token: 0x0601BF25 RID: 114469 RVA: 0x003F3CCF File Offset: 0x003F1ECF
		public int LeaveRadius { get; set; }

		// Token: 0x17008326 RID: 33574
		// (get) Token: 0x0601BF26 RID: 114470 RVA: 0x003F3CD8 File Offset: 0x003F1ED8
		// (set) Token: 0x0601BF27 RID: 114471 RVA: 0x003F3CE0 File Offset: 0x003F1EE0
		public bool DelayRefresh { get; set; }

		// Token: 0x17008327 RID: 33575
		// (get) Token: 0x0601BF28 RID: 114472 RVA: 0x003F3CE9 File Offset: 0x003F1EE9
		// (set) Token: 0x0601BF29 RID: 114473 RVA: 0x003F3CF1 File Offset: 0x003F1EF1
		public bool DelayDestroy { get; set; }

		// Token: 0x17008328 RID: 33576
		// (get) Token: 0x0601BF2A RID: 114474 RVA: 0x003F3CFA File Offset: 0x003F1EFA
		// (set) Token: 0x0601BF2B RID: 114475 RVA: 0x003F3D02 File Offset: 0x003F1F02
		public bool NotAllowHidedByGroup { get; set; }

		// Token: 0x17008329 RID: 33577
		// (get) Token: 0x0601BF2C RID: 114476 RVA: 0x003F3D0B File Offset: 0x003F1F0B
		// (set) Token: 0x0601BF2D RID: 114477 RVA: 0x003F3D13 File Offset: 0x003F1F13
		public bool AutoRestoreTreeAddedPlayerBuff { get; set; }

		// Token: 0x1700832A RID: 33578
		// (get) Token: 0x0601BF2E RID: 114478 RVA: 0x003F3D1C File Offset: 0x003F1F1C
		// (set) Token: 0x0601BF2F RID: 114479 RVA: 0x003F3D24 File Offset: 0x003F1F24
		public List<IActionInfoT> EnterInRangeActions { get; set; }

		// Token: 0x1700832B RID: 33579
		// (get) Token: 0x0601BF30 RID: 114480 RVA: 0x003F3D2D File Offset: 0x003F1F2D
		// (set) Token: 0x0601BF31 RID: 114481 RVA: 0x003F3D35 File Offset: 0x003F1F35
		public List<IActionInfoT> LevelPlayCloseActions { get; set; }

		// Token: 0x1700832C RID: 33580
		// (get) Token: 0x0601BF32 RID: 114482 RVA: 0x003F3D3E File Offset: 0x003F1F3E
		// (set) Token: 0x0601BF33 RID: 114483 RVA: 0x003F3D46 File Offset: 0x003F1F46
		public ILevelPlayMarkT LevelPlayMark { get; set; }

		// Token: 0x1700832D RID: 33581
		// (get) Token: 0x0601BF34 RID: 114484 RVA: 0x003F3D4F File Offset: 0x003F1F4F
		// (set) Token: 0x0601BF35 RID: 114485 RVA: 0x003F3D57 File Offset: 0x003F1F57
		public ILevelPlayTrackT LevelPlayTrack { get; set; }

		// Token: 0x1700832E RID: 33582
		// (get) Token: 0x0601BF36 RID: 114486 RVA: 0x003F3D60 File Offset: 0x003F1F60
		// (set) Token: 0x0601BF37 RID: 114487 RVA: 0x003F3D68 File Offset: 0x003F1F68
		public TLevelPlayRewardUnion LevelPlayRewardConfig { get; set; }

		// Token: 0x1700832F RID: 33583
		// (get) Token: 0x0601BF38 RID: 114488 RVA: 0x003F3D71 File Offset: 0x003F1F71
		// (set) Token: 0x0601BF39 RID: 114489 RVA: 0x003F3D79 File Offset: 0x003F1F79
		public TLevelPlayRefreshUnion LevelPlayRefreshConfig { get; set; }

		// Token: 0x17008330 RID: 33584
		// (get) Token: 0x0601BF3A RID: 114490 RVA: 0x003F3D82 File Offset: 0x003F1F82
		// (set) Token: 0x0601BF3B RID: 114491 RVA: 0x003F3D8A File Offset: 0x003F1F8A
		public ILevelPlayOpenConditionT LevelPlayOpenCondition { get; set; }

		// Token: 0x17008331 RID: 33585
		// (get) Token: 0x0601BF3C RID: 114492 RVA: 0x003F3D93 File Offset: 0x003F1F93
		// (set) Token: 0x0601BF3D RID: 114493 RVA: 0x003F3D9B File Offset: 0x003F1F9B
		public ILevelPlayActiveT LevelPlayActive { get; set; }

		// Token: 0x17008332 RID: 33586
		// (get) Token: 0x0601BF3E RID: 114494 RVA: 0x003F3DA4 File Offset: 0x003F1FA4
		// (set) Token: 0x0601BF3F RID: 114495 RVA: 0x003F3DAC File Offset: 0x003F1FAC
		public List<IActionInfoT> LevelPlayOpenActions { get; set; }

		// Token: 0x17008333 RID: 33587
		// (get) Token: 0x0601BF40 RID: 114496 RVA: 0x003F3DB5 File Offset: 0x003F1FB5
		// (set) Token: 0x0601BF41 RID: 114497 RVA: 0x003F3DBD File Offset: 0x003F1FBD
		public List<IActionInfoT> EscActionsAfterDungeonCompletion { get; set; }

		// Token: 0x17008334 RID: 33588
		// (get) Token: 0x0601BF42 RID: 114498 RVA: 0x003F3DC6 File Offset: 0x003F1FC6
		// (set) Token: 0x0601BF43 RID: 114499 RVA: 0x003F3DCE File Offset: 0x003F1FCE
		public int ExploratoryDegree { get; set; }

		// Token: 0x17008335 RID: 33589
		// (get) Token: 0x0601BF44 RID: 114500 RVA: 0x003F3DD7 File Offset: 0x003F1FD7
		// (set) Token: 0x0601BF45 RID: 114501 RVA: 0x003F3DDF File Offset: 0x003F1FDF
		public ILevelPlayExploratoryConfigT ExploratoryConfig { get; set; }

		// Token: 0x17008336 RID: 33590
		// (get) Token: 0x0601BF46 RID: 114502 RVA: 0x003F3DE8 File Offset: 0x003F1FE8
		// (set) Token: 0x0601BF47 RID: 114503 RVA: 0x003F3DF0 File Offset: 0x003F1FF0
		public List<int> ReferenceAllEntity { get; set; }

		// Token: 0x17008337 RID: 33591
		// (get) Token: 0x0601BF48 RID: 114504 RVA: 0x003F3DF9 File Offset: 0x003F1FF9
		// (set) Token: 0x0601BF49 RID: 114505 RVA: 0x003F3E01 File Offset: 0x003F2001
		public IBehaviorTreeT Tree { get; set; }

		// Token: 0x17008338 RID: 33592
		// (get) Token: 0x0601BF4A RID: 114506 RVA: 0x003F3E0A File Offset: 0x003F200A
		// (set) Token: 0x0601BF4B RID: 114507 RVA: 0x003F3E12 File Offset: 0x003F2012
		public ILevelPlayFixProcessorT FixProcessor { get; set; }

		// Token: 0x17008339 RID: 33593
		// (get) Token: 0x0601BF4C RID: 114508 RVA: 0x003F3E1B File Offset: 0x003F201B
		// (set) Token: 0x0601BF4D RID: 114509 RVA: 0x003F3E23 File Offset: 0x003F2023
		public int CustomIcon { get; set; }

		// Token: 0x1700833A RID: 33594
		// (get) Token: 0x0601BF4E RID: 114510 RVA: 0x003F3E2C File Offset: 0x003F202C
		// (set) Token: 0x0601BF4F RID: 114511 RVA: 0x003F3E34 File Offset: 0x003F2034
		public int CustomTrackUiIcon { get; set; }

		// Token: 0x1700833B RID: 33595
		// (get) Token: 0x0601BF50 RID: 114512 RVA: 0x003F3E3D File Offset: 0x003F203D
		// (set) Token: 0x0601BF51 RID: 114513 RVA: 0x003F3E45 File Offset: 0x003F2045
		public IRangeAbsorbPhantomT RangeAbsorbPhantom { get; set; }

		// Token: 0x1700833C RID: 33596
		// (get) Token: 0x0601BF52 RID: 114514 RVA: 0x003F3E4E File Offset: 0x003F204E
		// (set) Token: 0x0601BF53 RID: 114515 RVA: 0x003F3E56 File Offset: 0x003F2056
		public IRewardConfigT RewardConfig { get; set; }

		// Token: 0x1700833D RID: 33597
		// (get) Token: 0x0601BF54 RID: 114516 RVA: 0x003F3E5F File Offset: 0x003F205F
		// (set) Token: 0x0601BF55 RID: 114517 RVA: 0x003F3E67 File Offset: 0x003F2067
		public bool IsTrackOnlyWhenQuestBind { get; set; }

		// Token: 0x1700833E RID: 33598
		// (get) Token: 0x0601BF56 RID: 114518 RVA: 0x003F3E70 File Offset: 0x003F2070
		// (set) Token: 0x0601BF57 RID: 114519 RVA: 0x003F3E78 File Offset: 0x003F2078
		public ILevelPlayRecallConfigT RecallConfig { get; set; }

		// Token: 0x1700833F RID: 33599
		// (get) Token: 0x0601BF58 RID: 114520 RVA: 0x003F3E81 File Offset: 0x003F2081
		// (set) Token: 0x0601BF59 RID: 114521 RVA: 0x003F3E89 File Offset: 0x003F2089
		public IEntityRefSearchPropT _EntityRefSearch { get; set; }

		// Token: 0x17008340 RID: 33600
		// (get) Token: 0x0601BF5A RID: 114522 RVA: 0x003F3E92 File Offset: 0x003F2092
		// (set) Token: 0x0601BF5B RID: 114523 RVA: 0x003F3E9A File Offset: 0x003F209A
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x17008341 RID: 33601
		// (get) Token: 0x0601BF5C RID: 114524 RVA: 0x003F3EA3 File Offset: 0x003F20A3
		// (set) Token: 0x0601BF5D RID: 114525 RVA: 0x003F3EAB File Offset: 0x003F20AB
		public string _FocusDataPath { get; set; }

		// Token: 0x17008342 RID: 33602
		// (get) Token: 0x0601BF5E RID: 114526 RVA: 0x003F3EB4 File Offset: 0x003F20B4
		// (set) Token: 0x0601BF5F RID: 114527 RVA: 0x003F3EBC File Offset: 0x003F20BC
		public uint NullMask { get; set; }

		// Token: 0x0601BF60 RID: 114528 RVA: 0x003F3EC8 File Offset: 0x003F20C8
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
			this.PrefabId = 0;
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

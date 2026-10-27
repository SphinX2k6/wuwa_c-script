using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048E8 RID: 18664
	[NullableContext(1)]
	[Nullable(0)]
	public class HotKeyViewDefine
	{
		// Token: 0x0401A352 RID: 107346
		public const string SPECIAL_TEXT = "Hide";

		// Token: 0x0401A353 RID: 107347
		public const string ANY_KEY = "AnyKey";

		// Token: 0x0401A354 RID: 107348
		public const string EXIT_TAG = "tag1";

		// Token: 0x0401A355 RID: 107349
		public const string HOME_TAG = "tag_home";

		// Token: 0x0401A356 RID: 107350
		public const int ID_SEGMENT = 10000;

		// Token: 0x0401A357 RID: 107351
		public static readonly IReadOnlyDictionary<HotKeyViewDefine.ELogicMode, string> LogicModeLogString = new Dictionary<HotKeyViewDefine.ELogicMode, string>
		{
			{
				HotKeyViewDefine.ELogicMode.Min,
				"None"
			},
			{
				HotKeyViewDefine.ELogicMode.SelfActive,
				"自身显隐状态"
			},
			{
				HotKeyViewDefine.ELogicMode.ListenerActive,
				"监听组件控制显隐"
			},
			{
				HotKeyViewDefine.ELogicMode.BlockView,
				"界面阻挡/切换"
			},
			{
				HotKeyViewDefine.ELogicMode.ListenerNotifyShield,
				"被监听组件通知屏蔽"
			},
			{
				HotKeyViewDefine.ELogicMode.LogicByNoController,
				"控制器屏蔽"
			},
			{
				HotKeyViewDefine.ELogicMode.NoText,
				"文本屏蔽"
			},
			{
				HotKeyViewDefine.ELogicMode.ConfigShield,
				"表格配置操作类型屏蔽"
			},
			{
				HotKeyViewDefine.ELogicMode.CustomShield,
				"业务自定义屏蔽"
			},
			{
				HotKeyViewDefine.ELogicMode.ShowMouseShield,
				"呼出鼠标屏蔽"
			},
			{
				HotKeyViewDefine.ELogicMode.Max,
				"None"
			}
		};

		// Token: 0x0200AB9A RID: 43930
		[NullableContext(0)]
		[Flags]
		public enum ELogicMode
		{
			// Token: 0x0403421E RID: 213534
			Min = 0,
			// Token: 0x0403421F RID: 213535
			SelfActive = 1,
			// Token: 0x04034220 RID: 213536
			ListenerActive = 2,
			// Token: 0x04034221 RID: 213537
			BlockView = 4,
			// Token: 0x04034222 RID: 213538
			ListenerNotifyShield = 8,
			// Token: 0x04034223 RID: 213539
			LogicByNoController = 16,
			// Token: 0x04034224 RID: 213540
			NoText = 32,
			// Token: 0x04034225 RID: 213541
			ConfigShield = 64,
			// Token: 0x04034226 RID: 213542
			CustomShield = 128,
			// Token: 0x04034227 RID: 213543
			ShowMouseShield = 256,
			// Token: 0x04034228 RID: 213544
			Max = 257
		}

		// Token: 0x0200AB9B RID: 43931
		[NullableContext(0)]
		public enum EHotKeyApplicableType
		{
			// Token: 0x0403422A RID: 213546
			KeyboardAndHandle,
			// Token: 0x0403422B RID: 213547
			OnlyKeyboard,
			// Token: 0x0403422C RID: 213548
			OnlyHandle,
			// Token: 0x0403422D RID: 213549
			OnlyKeyboardTransparent,
			// Token: 0x0403422E RID: 213550
			OnlyHandleTransparent,
			// Token: 0x0403422F RID: 213551
			KeyboardAndHandleTransparent,
			// Token: 0x04034230 RID: 213552
			OnlyKeyboardTransparentExceptLongPress
		}

		// Token: 0x0200AB9C RID: 43932
		[Nullable(0)]
		public class EHotKeyModeDefine
		{
			// Token: 0x04034231 RID: 213553
			public const string SingleHotKey = "SingleHotKey";

			// Token: 0x04034232 RID: 213554
			public const string MultipleHotKey = "MultipleHotKey";
		}

		// Token: 0x0200AB9D RID: 43933
		[NullableContext(0)]
		public enum EHotKeyAxisDirectionType
		{
			// Token: 0x04034234 RID: 213556
			All,
			// Token: 0x04034235 RID: 213557
			Reverse,
			// Token: 0x04034236 RID: 213558
			Positive
		}

		// Token: 0x0200AB9E RID: 43934
		[Nullable(0)]
		public class EHotKeyFunctionType
		{
			// Token: 0x04034237 RID: 213559
			public const string MarkBookNext = "MarkBookNext";

			// Token: 0x04034238 RID: 213560
			public const string MarkBookPrev = "MarkBookPrev";

			// Token: 0x04034239 RID: 213561
			public const string NavigationNext = "NavigationNext";

			// Token: 0x0403423A RID: 213562
			public const string NavigationUpNext = "NavigationUpNext";

			// Token: 0x0403423B RID: 213563
			public const string NavigationDownNext = "NavigationDownNext";

			// Token: 0x0403423C RID: 213564
			public const string NavigationLeftNext = "NavigationLeftNext";

			// Token: 0x0403423D RID: 213565
			public const string NavigationPrev = "NavigationPrev";

			// Token: 0x0403423E RID: 213566
			public const string NavigationRightPrev = "NavigationRightPrev";

			// Token: 0x0403423F RID: 213567
			public const string NavigationRightPrevLink = "NavigationRightPrevLink";

			// Token: 0x04034240 RID: 213568
			public const string NavigationInside = "NavigationInside";

			// Token: 0x04034241 RID: 213569
			public const string Back = "Back";

			// Token: 0x04034242 RID: 213570
			public const string Interact = "Interact";

			// Token: 0x04034243 RID: 213571
			public const string ClickButton = "ClickButton";

			// Token: 0x04034244 RID: 213572
			public const string ClickButtonInScroll = "ClickButtonInScroll";

			// Token: 0x04034245 RID: 213573
			public const string ClickButtonInside = "ClickButtonInside";

			// Token: 0x04034246 RID: 213574
			public const string ScrollBar = "ScrollBar";

			// Token: 0x04034247 RID: 213575
			public const string ScrollBarInside = "ScrollBarInside";

			// Token: 0x04034248 RID: 213576
			public const string ScrollSwitch = "ScrollSwitch";

			// Token: 0x04034249 RID: 213577
			public const string HorizontalScrollBar = "HorizontalScrollBar";

			// Token: 0x0403424A RID: 213578
			public const string VerticalScrollBar = "VerticalScrollBar";

			// Token: 0x0403424B RID: 213579
			public const string InteractRelease = "InteractRelease";

			// Token: 0x0403424C RID: 213580
			public const string InteractReleaseWithoutInterrupt = "InteractReleaseWithoutInterrupt";

			// Token: 0x0403424D RID: 213581
			public const string ClickButtonRelease = "ClickButtonRelease";

			// Token: 0x0403424E RID: 213582
			public const string ClickButtonInsideRelease = "ClickButtonInsideRelease";

			// Token: 0x0403424F RID: 213583
			public const string MarkBookNextRelease = "MarkBookNextRelease";

			// Token: 0x04034250 RID: 213584
			public const string MarkBookPrevRelease = "MarkBookPrevRelease";

			// Token: 0x04034251 RID: 213585
			public const string LongPress = "LongPress";

			// Token: 0x04034252 RID: 213586
			public const string LongPressInside = "LongPressInside";

			// Token: 0x04034253 RID: 213587
			public const string InteractWheel = "InteractWheel";

			// Token: 0x04034254 RID: 213588
			public const string SliderIncrease = "SliderIncrease";

			// Token: 0x04034255 RID: 213589
			public const string SliderIncreaseInside = "SliderIncreaseInside";

			// Token: 0x04034256 RID: 213590
			public const string SliderReduce = "SliderReduce";

			// Token: 0x04034257 RID: 213591
			public const string SliderReduceInside = "SliderReduceInside";

			// Token: 0x04034258 RID: 213592
			public const string SliderIncreaseReverse = "SliderIncreaseReverse";

			// Token: 0x04034259 RID: 213593
			public const string SliderReduceReverse = "SliderReduceReverse";

			// Token: 0x0403425A RID: 213594
			public const string LongTimeToTrigger = "LongTimeToTrigger";

			// Token: 0x0403425B RID: 213595
			public const string TextInput = "TextInput";

			// Token: 0x0403425C RID: 213596
			public const string TextInputInside = "TextInputInside";

			// Token: 0x0403425D RID: 213597
			public const string DraggablePrev = "DraggablePrev";

			// Token: 0x0403425E RID: 213598
			public const string DraggableNext = "DraggableNext";

			// Token: 0x0403425F RID: 213599
			public const string DraggablePrevInside = "DraggablePrevInside";

			// Token: 0x04034260 RID: 213600
			public const string DraggableNextInside = "DraggableNextInside";

			// Token: 0x04034261 RID: 213601
			public const string StaticJoyStickLeft = "StaticJoyStickLeft";

			// Token: 0x04034262 RID: 213602
			public const string StaticJoyStickRight = "StaticJoyStickRight";

			// Token: 0x04034263 RID: 213603
			public const string Mask = "Mask";

			// Token: 0x04034264 RID: 213604
			public const string ShowOnly = "ShowOnly";

			// Token: 0x04034265 RID: 213605
			public const string WorldMapShowOnly = "WorldMapShowOnly";

			// Token: 0x04034266 RID: 213606
			public const string ShowOnlyLink = "ShowOnlyLink";

			// Token: 0x04034267 RID: 213607
			public const string FollowItem = "FollowItem";

			// Token: 0x04034268 RID: 213608
			public const string BagTagNavigationNext = "BagTagNavigationNext";

			// Token: 0x04034269 RID: 213609
			public const string CommonConsumeNavigationNext = "CommonConsumeNavigationNext";

			// Token: 0x0403426A RID: 213610
			public const string CommonConsumeNavigationInsideNext = "CommonConsumeNavigationInsideNext";

			// Token: 0x0403426B RID: 213611
			public const string NavigationNextLatest = "NavigationNextLatest";

			// Token: 0x0403426C RID: 213612
			public const string BattleViewCamera = "BattleViewCamera";

			// Token: 0x0403426D RID: 213613
			public const string RouletteNavigation = "RouletteNavigation";

			// Token: 0x0403426E RID: 213614
			public const string SettingSliderIncreaseInside = "SettingSliderIncreaseInside";

			// Token: 0x0403426F RID: 213615
			public const string SettingSliderReduceInside = "SettingSliderReduceInside";

			// Token: 0x04034270 RID: 213616
			public const string SettingSliderIncreaseReverseInside = "SettingSliderIncreaseReverseInside";

			// Token: 0x04034271 RID: 213617
			public const string SettingSliderReduceReverseInside = "SettingSliderReduceReverseInside";

			// Token: 0x04034272 RID: 213618
			public const string SettingSliderIncrease = "SettingSliderIncrease";

			// Token: 0x04034273 RID: 213619
			public const string SettingSliderReduce = "SettingSliderReduce";

			// Token: 0x04034274 RID: 213620
			public const string SettingSliderIncreaseReverse = "SettingSliderIncreaseReverse";

			// Token: 0x04034275 RID: 213621
			public const string SettingSliderReduceReverse = "SettingSliderReduceReverse";

			// Token: 0x04034276 RID: 213622
			public const string RewardTake = "RewardTake";

			// Token: 0x04034277 RID: 213623
			public const string CommonFilterReset = "CommonFilterReset";

			// Token: 0x04034278 RID: 213624
			public const string MapCheck = "MapCheck";

			// Token: 0x04034279 RID: 213625
			public const string MapFocusPlayer = "MapFocusPlayer";

			// Token: 0x0403427A RID: 213626
			public const string MapMoveForward = "MapMoveForward";

			// Token: 0x0403427B RID: 213627
			public const string MapMoveRight = "MapMoveRight";

			// Token: 0x0403427C RID: 213628
			public const string MapZoom = "MapZoom";

			// Token: 0x0403427D RID: 213629
			public const string RoleLookUp = "RoleLookUp";

			// Token: 0x0403427E RID: 213630
			public const string RoleTurn = "RoleTurn";

			// Token: 0x0403427F RID: 213631
			public const string RoleZoom = "RoleZoom";

			// Token: 0x04034280 RID: 213632
			public const string RoleReset = "RoleReset";

			// Token: 0x04034281 RID: 213633
			public const string GamepadMoveForward = "GamepadMoveForward";

			// Token: 0x04034282 RID: 213634
			public const string GamepadMoveRight = "GamepadMoveRight";

			// Token: 0x04034283 RID: 213635
			public const string GamepadCheck = "GamepadCheck";

			// Token: 0x04034284 RID: 213636
			public const string GamepadCheckDrag = "GamepadCheckDrag";

			// Token: 0x04034285 RID: 213637
			public const string GamepadWheel = "GamepadWheel";

			// Token: 0x04034286 RID: 213638
			public const string GamepadClick = "GamepadClick";

			// Token: 0x04034287 RID: 213639
			public const string PlotMoveForward = "PlotMoveForward";

			// Token: 0x04034288 RID: 213640
			public const string PlotMoveRight = "PlotMoveRight";

			// Token: 0x04034289 RID: 213641
			public const string PlotZoom = "PlotZoom";

			// Token: 0x0403428A RID: 213642
			public const string PlotNextPage = "PlotNextPage";

			// Token: 0x0403428B RID: 213643
			public const string OpenRouletteSetView = "OpenRouletteSetView";

			// Token: 0x0403428C RID: 213644
			public const string RouletteSwitchToggle = "RouletteSwitchToggle";

			// Token: 0x0403428D RID: 213645
			public const string PhotographSetVisible = "PhotographSetVisible";

			// Token: 0x0403428E RID: 213646
			public const string PhotoMenu = "PhotoMenu";

			// Token: 0x0403428F RID: 213647
			public const string SelectPhotoStickerItem = "SelectPhotoStickerItem";

			// Token: 0x04034290 RID: 213648
			public const string DeselectPhotoStickerItem = "DeselectPhotoStickerItem";

			// Token: 0x04034291 RID: 213649
			public const string PhotoStickerItemScaleIncrease = "PhotoStickerItemScaleIncrease";

			// Token: 0x04034292 RID: 213650
			public const string PhotoStickerItemScaleReduce = "PhotoStickerItemScaleReduce";

			// Token: 0x04034293 RID: 213651
			public const string MapTravelTaskNavigationNext = "MapTravelTaskNavigationNext";

			// Token: 0x04034294 RID: 213652
			public const string ShipTowerSwitchRightTeam = "ShipTowerSwitchRightTeam";

			// Token: 0x04034295 RID: 213653
			public const string ShipTowerAutoLeftTeam = "ShipTowerAutoLeftTeam";

			// Token: 0x04034296 RID: 213654
			public const string OpenTermExplanationView = "OpenTermExplanationView";

			// Token: 0x04034297 RID: 213655
			public const string MapRogueQuicklyMove = "MapRogueQuicklyMove";

			// Token: 0x04034298 RID: 213656
			public const string MapDragForward = "MapDragForward";

			// Token: 0x04034299 RID: 213657
			public const string MapDragRight = "MapDragRight";

			// Token: 0x0403429A RID: 213658
			public const string DangoLevelUp = "DangoLevelUp";

			// Token: 0x0403429B RID: 213659
			public const string DangoShop = "DangoShop";

			// Token: 0x0403429C RID: 213660
			public const string PhantomArenaBattleCardTips = "PhantomArenaBattleCardTips";

			// Token: 0x0403429D RID: 213661
			public const string PhantomArenaBattleCardCancel = "PhantomArenaBattleCardCancel";

			// Token: 0x0403429E RID: 213662
			public const string PhantomArenaBattleCardSelect = "PhantomArenaBattleCardSelect";

			// Token: 0x0403429F RID: 213663
			public const string PhantomArenaBattleLayoutHoist = "PhantomArenaBattleLayoutHoist";

			// Token: 0x040342A0 RID: 213664
			public const string PhantomArenaBattleCardRecycle = "PhantomArenaBattleCardRecycle";

			// Token: 0x040342A1 RID: 213665
			public const string PhantomArenaCardInfo = "PhantomArenaCardInfo";

			// Token: 0x040342A2 RID: 213666
			public const string PhantomArenaBattleNavigationNext = "PhantomArenaBattleNavigationNext";

			// Token: 0x040342A3 RID: 213667
			public const string PhonePetInteract = "PhonePetInteract";

			// Token: 0x040342A4 RID: 213668
			public const string SeekTraceMoveUp = "SeekTraceMoveUp";

			// Token: 0x040342A5 RID: 213669
			public const string SeekTraceMoveDown = "SeekTraceMoveDown";

			// Token: 0x040342A6 RID: 213670
			public const string SeekTraceMoveLeft = "SeekTraceMoveLeft";

			// Token: 0x040342A7 RID: 213671
			public const string SeekTraceMoveRight = "SeekTraceMoveRight";

			// Token: 0x040342A8 RID: 213672
			public const string SeekTraceSelectItem = "SeekTraceSelectItem";

			// Token: 0x040342A9 RID: 213673
			public const string SeekTraceResetItem = "SeekTraceResetItem";

			// Token: 0x040342AA RID: 213674
			public const string HonamiStoryMoveLeft = "HonamiStoryMoveLeft";

			// Token: 0x040342AB RID: 213675
			public const string HonamiStoryMoveRight = "HonamiStoryMoveRight";

			// Token: 0x040342AC RID: 213676
			public const string HonamiStoryPickUpDown = "HonamiStoryPickUpDown";

			// Token: 0x040342AD RID: 213677
			public const string HonamiStoryQuickEquip = "HonamiStoryQuickEquip";

			// Token: 0x040342AE RID: 213678
			public const string HonamiStoryQuickEquipOff = "HonamiStoryQuickEquipOff";

			// Token: 0x040342AF RID: 213679
			public const string HonamiStoryDiscard = "HonamiStoryDiscard";

			// Token: 0x040342B0 RID: 213680
			public const string HonamiStoryLock = "HonamiStoryLock";

			// Token: 0x040342B1 RID: 213681
			public const string HonamiStoryCancel = "HonamiStoryCancel";

			// Token: 0x040342B2 RID: 213682
			public const string HonamiStoryLook = "HonamiStoryLook";

			// Token: 0x040342B3 RID: 213683
			public const string HonamiStoryCollect = "HonamiStoryCollect";

			// Token: 0x040342B4 RID: 213684
			public const string HonamiStorySell = "HonamiStorySell";

			// Token: 0x040342B5 RID: 213685
			public const string HonamiStoryCancelShowOnly = "HonamiStoryCancelShowOnly";

			// Token: 0x040342B6 RID: 213686
			public const string TeachScrollMove = "TeachScrollMove";

			// Token: 0x040342B7 RID: 213687
			public const string CloseButton = "CloseButton";

			// Token: 0x040342B8 RID: 213688
			public const string KujiLongTimeToTrigger = "KujiLongTimeToTrigger";

			// Token: 0x040342B9 RID: 213689
			public const string AutoPilotRideShareBtn = "AutoPilotRideShareBtn";

			// Token: 0x040342BA RID: 213690
			public const string MotorMusicSortDragCancel = "MotorMusicSortDragCancel";

			// Token: 0x040342BB RID: 213691
			public const string FormationChoseRole = "FormationChoseRole";

			// Token: 0x040342BC RID: 213692
			public const string FormationCancelChoseRole = "FormationCancelChoseRole";

			// Token: 0x040342BD RID: 213693
			public const string FormationEditSort = "FormationEditSort";

			// Token: 0x040342BE RID: 213694
			public const string FormationEditSortMove = "FormationEditSortMove";

			// Token: 0x040342BF RID: 213695
			public const string FormationEditSortConfirm = "FormationEditSortConfirm";

			// Token: 0x040342C0 RID: 213696
			public const string FormationEditSortCancel = "FormationEditSortCancel";

			// Token: 0x040342C1 RID: 213697
			public const string ProjectionPhotoItemDragCancel = "ProjectionPhotoItemDragCancel";

			// Token: 0x040342C2 RID: 213698
			public const string ZitherHighPitch = "ZitherHighPitch";

			// Token: 0x040342C3 RID: 213699
			public const string ZitherCameraZoom = "ZitherCameraZoom";

			// Token: 0x040342C4 RID: 213700
			public const string ZitherLowPitch = "ZitherLowPitch";

			// Token: 0x040342C5 RID: 213701
			public const string MatchThreeSwapPiece = "MatchThreeSwapPiece";

			// Token: 0x040342C6 RID: 213702
			public const string DangobrawlJumpBackpack = "DangobrawlJumpBackpack";

			// Token: 0x040342C7 RID: 213703
			public const string DangobrawlJumpShop = "DangobrawlJumpShop";

			// Token: 0x040342C8 RID: 213704
			public const string DangobrawlJumpBench = "DangobrawlJumpBench";

			// Token: 0x040342C9 RID: 213705
			public const string DangobrawlJumpQucikCombine = "DangobrawlJumpQucikCombine";

			// Token: 0x040342CA RID: 213706
			public const string DangobrawlMoveRotate = "DangobrawlMoveRotate";

			// Token: 0x040342CB RID: 213707
			public const string DangobrawlLockShopGoods = "DangobrawlLockShopGoods";

			// Token: 0x040342CC RID: 213708
			public const string DangobrawlOpenCombineTips = "DangobrawlOpenCombineTips";

			// Token: 0x040342CD RID: 213709
			public const string DangobrawlCancel = "DangobrawlCancel";

			// Token: 0x040342CE RID: 213710
			public const string DangobrawlReplace = "DangobrawlReplace";

			// Token: 0x040342CF RID: 213711
			public const string DangobrawlStartFight = "DangobrawlStartFight";

			// Token: 0x040342D0 RID: 213712
			public const string DangobrawlOpenItemTips = "DangobrawlOpenItemTips";
		}

		// Token: 0x0200AB9F RID: 43935
		[NullableContext(0)]
		public enum EHotKeyType
		{
			// Token: 0x040342D2 RID: 213714
			Multiple
		}
	}
}

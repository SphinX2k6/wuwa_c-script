using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200385F RID: 14431
	[NullableContext(1)]
	[Nullable(0)]
	public class HotKeyViewDefine
	{
		// Token: 0x04014BC5 RID: 84933
		public const string SPECIAL_TEXT = "Hide";

		// Token: 0x04014BC6 RID: 84934
		public const string ANY_KEY = "AnyKey";

		// Token: 0x04014BC7 RID: 84935
		public const string EXIT_TAG = "tag1";

		// Token: 0x04014BC8 RID: 84936
		public const string HOME_TAG = "tag_home";

		// Token: 0x04014BC9 RID: 84937
		public const int ID_SEGMENT = 10000;

		// Token: 0x04014BCA RID: 84938
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

		// Token: 0x020095A9 RID: 38313
		[NullableContext(0)]
		[Flags]
		public enum ELogicMode
		{
			// Token: 0x0402EB9C RID: 191388
			Min = 0,
			// Token: 0x0402EB9D RID: 191389
			SelfActive = 1,
			// Token: 0x0402EB9E RID: 191390
			ListenerActive = 2,
			// Token: 0x0402EB9F RID: 191391
			BlockView = 4,
			// Token: 0x0402EBA0 RID: 191392
			ListenerNotifyShield = 8,
			// Token: 0x0402EBA1 RID: 191393
			LogicByNoController = 16,
			// Token: 0x0402EBA2 RID: 191394
			NoText = 32,
			// Token: 0x0402EBA3 RID: 191395
			ConfigShield = 64,
			// Token: 0x0402EBA4 RID: 191396
			CustomShield = 128,
			// Token: 0x0402EBA5 RID: 191397
			ShowMouseShield = 256,
			// Token: 0x0402EBA6 RID: 191398
			Max = 257
		}

		// Token: 0x020095AA RID: 38314
		[NullableContext(0)]
		public enum EHotKeyApplicableType
		{
			// Token: 0x0402EBA8 RID: 191400
			KeyboardAndHandle,
			// Token: 0x0402EBA9 RID: 191401
			OnlyKeyboard,
			// Token: 0x0402EBAA RID: 191402
			OnlyHandle,
			// Token: 0x0402EBAB RID: 191403
			OnlyKeyboardTransparent,
			// Token: 0x0402EBAC RID: 191404
			OnlyHandleTransparent,
			// Token: 0x0402EBAD RID: 191405
			KeyboardAndHandleTransparent,
			// Token: 0x0402EBAE RID: 191406
			OnlyKeyboardTransparentExceptLongPress
		}

		// Token: 0x020095AB RID: 38315
		[Nullable(0)]
		public class EHotKeyModeDefine
		{
			// Token: 0x0402EBAF RID: 191407
			public const string SingleHotKey = "SingleHotKey";

			// Token: 0x0402EBB0 RID: 191408
			public const string MultipleHotKey = "MultipleHotKey";
		}

		// Token: 0x020095AC RID: 38316
		[NullableContext(0)]
		public enum EHotKeyAxisDirectionType
		{
			// Token: 0x0402EBB2 RID: 191410
			All,
			// Token: 0x0402EBB3 RID: 191411
			Reverse,
			// Token: 0x0402EBB4 RID: 191412
			Positive
		}

		// Token: 0x020095AD RID: 38317
		[Nullable(0)]
		public class EHotKeyFunctionType
		{
			// Token: 0x0402EBB5 RID: 191413
			public const string MarkBookNext = "MarkBookNext";

			// Token: 0x0402EBB6 RID: 191414
			public const string MarkBookPrev = "MarkBookPrev";

			// Token: 0x0402EBB7 RID: 191415
			public const string NavigationNext = "NavigationNext";

			// Token: 0x0402EBB8 RID: 191416
			public const string NavigationUpNext = "NavigationUpNext";

			// Token: 0x0402EBB9 RID: 191417
			public const string NavigationDownNext = "NavigationDownNext";

			// Token: 0x0402EBBA RID: 191418
			public const string NavigationLeftNext = "NavigationLeftNext";

			// Token: 0x0402EBBB RID: 191419
			public const string NavigationPrev = "NavigationPrev";

			// Token: 0x0402EBBC RID: 191420
			public const string NavigationRightPrev = "NavigationRightPrev";

			// Token: 0x0402EBBD RID: 191421
			public const string NavigationRightPrevLink = "NavigationRightPrevLink";

			// Token: 0x0402EBBE RID: 191422
			public const string NavigationInside = "NavigationInside";

			// Token: 0x0402EBBF RID: 191423
			public const string Back = "Back";

			// Token: 0x0402EBC0 RID: 191424
			public const string Interact = "Interact";

			// Token: 0x0402EBC1 RID: 191425
			public const string ClickButton = "ClickButton";

			// Token: 0x0402EBC2 RID: 191426
			public const string ClickButtonInScroll = "ClickButtonInScroll";

			// Token: 0x0402EBC3 RID: 191427
			public const string ClickButtonInside = "ClickButtonInside";

			// Token: 0x0402EBC4 RID: 191428
			public const string ScrollBar = "ScrollBar";

			// Token: 0x0402EBC5 RID: 191429
			public const string ScrollBarInside = "ScrollBarInside";

			// Token: 0x0402EBC6 RID: 191430
			public const string ScrollSwitch = "ScrollSwitch";

			// Token: 0x0402EBC7 RID: 191431
			public const string HorizontalScrollBar = "HorizontalScrollBar";

			// Token: 0x0402EBC8 RID: 191432
			public const string VerticalScrollBar = "VerticalScrollBar";

			// Token: 0x0402EBC9 RID: 191433
			public const string InteractRelease = "InteractRelease";

			// Token: 0x0402EBCA RID: 191434
			public const string InteractReleaseWithoutInterrupt = "InteractReleaseWithoutInterrupt";

			// Token: 0x0402EBCB RID: 191435
			public const string ClickButtonRelease = "ClickButtonRelease";

			// Token: 0x0402EBCC RID: 191436
			public const string ClickButtonInScrollRelease = "ClickButtonInScrollRelease";

			// Token: 0x0402EBCD RID: 191437
			public const string ClickButtonInsideRelease = "ClickButtonInsideRelease";

			// Token: 0x0402EBCE RID: 191438
			public const string MarkBookNextRelease = "MarkBookNextRelease";

			// Token: 0x0402EBCF RID: 191439
			public const string MarkBookPrevRelease = "MarkBookPrevRelease";

			// Token: 0x0402EBD0 RID: 191440
			public const string LongPress = "LongPress";

			// Token: 0x0402EBD1 RID: 191441
			public const string LongPressInside = "LongPressInside";

			// Token: 0x0402EBD2 RID: 191442
			public const string InteractWheel = "InteractWheel";

			// Token: 0x0402EBD3 RID: 191443
			public const string SliderIncrease = "SliderIncrease";

			// Token: 0x0402EBD4 RID: 191444
			public const string SliderIncreaseInside = "SliderIncreaseInside";

			// Token: 0x0402EBD5 RID: 191445
			public const string SliderReduce = "SliderReduce";

			// Token: 0x0402EBD6 RID: 191446
			public const string SliderReduceInside = "SliderReduceInside";

			// Token: 0x0402EBD7 RID: 191447
			public const string SliderIncreaseReverse = "SliderIncreaseReverse";

			// Token: 0x0402EBD8 RID: 191448
			public const string SliderReduceReverse = "SliderReduceReverse";

			// Token: 0x0402EBD9 RID: 191449
			public const string LongTimeToTrigger = "LongTimeToTrigger";

			// Token: 0x0402EBDA RID: 191450
			public const string LongTimeToTriggerInScroll = "LongTimeToTriggerInScroll";

			// Token: 0x0402EBDB RID: 191451
			public const string TextInput = "TextInput";

			// Token: 0x0402EBDC RID: 191452
			public const string TextInputInside = "TextInputInside";

			// Token: 0x0402EBDD RID: 191453
			public const string FreeDrag2D = "FreeDrag2D";

			// Token: 0x0402EBDE RID: 191454
			public const string DraggablePrev = "DraggablePrev";

			// Token: 0x0402EBDF RID: 191455
			public const string DraggableNext = "DraggableNext";

			// Token: 0x0402EBE0 RID: 191456
			public const string DraggablePrevInside = "DraggablePrevInside";

			// Token: 0x0402EBE1 RID: 191457
			public const string DraggableNextInside = "DraggableNextInside";

			// Token: 0x0402EBE2 RID: 191458
			public const string StaticJoyStickLeft = "StaticJoyStickLeft";

			// Token: 0x0402EBE3 RID: 191459
			public const string StaticJoyStickRight = "StaticJoyStickRight";

			// Token: 0x0402EBE4 RID: 191460
			public const string Mask = "Mask";

			// Token: 0x0402EBE5 RID: 191461
			public const string ShowOnly = "ShowOnly";

			// Token: 0x0402EBE6 RID: 191462
			public const string WorldMapShowOnly = "WorldMapShowOnly";

			// Token: 0x0402EBE7 RID: 191463
			public const string ShowOnlyLink = "ShowOnlyLink";

			// Token: 0x0402EBE8 RID: 191464
			public const string FollowItem = "FollowItem";

			// Token: 0x0402EBE9 RID: 191465
			public const string BagTagNavigationNext = "BagTagNavigationNext";

			// Token: 0x0402EBEA RID: 191466
			public const string CommonConsumeNavigationNext = "CommonConsumeNavigationNext";

			// Token: 0x0402EBEB RID: 191467
			public const string CommonConsumeNavigationInsideNext = "CommonConsumeNavigationInsideNext";

			// Token: 0x0402EBEC RID: 191468
			public const string NavigationNextLatest = "NavigationNextLatest";

			// Token: 0x0402EBED RID: 191469
			public const string BattleViewCamera = "BattleViewCamera";

			// Token: 0x0402EBEE RID: 191470
			public const string RouletteNavigation = "RouletteNavigation";

			// Token: 0x0402EBEF RID: 191471
			public const string SettingSliderIncreaseInside = "SettingSliderIncreaseInside";

			// Token: 0x0402EBF0 RID: 191472
			public const string SettingSliderReduceInside = "SettingSliderReduceInside";

			// Token: 0x0402EBF1 RID: 191473
			public const string SettingSliderIncreaseReverseInside = "SettingSliderIncreaseReverseInside";

			// Token: 0x0402EBF2 RID: 191474
			public const string SettingSliderReduceReverseInside = "SettingSliderReduceReverseInside";

			// Token: 0x0402EBF3 RID: 191475
			public const string SettingSliderIncrease = "SettingSliderIncrease";

			// Token: 0x0402EBF4 RID: 191476
			public const string SettingSliderReduce = "SettingSliderReduce";

			// Token: 0x0402EBF5 RID: 191477
			public const string SettingSliderIncreaseReverse = "SettingSliderIncreaseReverse";

			// Token: 0x0402EBF6 RID: 191478
			public const string SettingSliderReduceReverse = "SettingSliderReduceReverse";

			// Token: 0x0402EBF7 RID: 191479
			public const string RewardTake = "RewardTake";

			// Token: 0x0402EBF8 RID: 191480
			public const string CommonFilterReset = "CommonFilterReset";

			// Token: 0x0402EBF9 RID: 191481
			public const string MapCheck = "MapCheck";

			// Token: 0x0402EBFA RID: 191482
			public const string MapFocusPlayer = "MapFocusPlayer";

			// Token: 0x0402EBFB RID: 191483
			public const string MapMoveForward = "MapMoveForward";

			// Token: 0x0402EBFC RID: 191484
			public const string MapMoveRight = "MapMoveRight";

			// Token: 0x0402EBFD RID: 191485
			public const string MapZoom = "MapZoom";

			// Token: 0x0402EBFE RID: 191486
			public const string RoleLookUp = "RoleLookUp";

			// Token: 0x0402EBFF RID: 191487
			public const string RoleTurn = "RoleTurn";

			// Token: 0x0402EC00 RID: 191488
			public const string RoleZoom = "RoleZoom";

			// Token: 0x0402EC01 RID: 191489
			public const string RoleReset = "RoleReset";

			// Token: 0x0402EC02 RID: 191490
			public const string GamepadMoveForward = "GamepadMoveForward";

			// Token: 0x0402EC03 RID: 191491
			public const string GamepadMoveRight = "GamepadMoveRight";

			// Token: 0x0402EC04 RID: 191492
			public const string GamepadCheck = "GamepadCheck";

			// Token: 0x0402EC05 RID: 191493
			public const string GamepadCheckDrag = "GamepadCheckDrag";

			// Token: 0x0402EC06 RID: 191494
			public const string GamepadWheel = "GamepadWheel";

			// Token: 0x0402EC07 RID: 191495
			public const string GamepadClick = "GamepadClick";

			// Token: 0x0402EC08 RID: 191496
			public const string PlotMoveForward = "PlotMoveForward";

			// Token: 0x0402EC09 RID: 191497
			public const string PlotMoveRight = "PlotMoveRight";

			// Token: 0x0402EC0A RID: 191498
			public const string PlotZoom = "PlotZoom";

			// Token: 0x0402EC0B RID: 191499
			public const string PlotNextPage = "PlotNextPage";

			// Token: 0x0402EC0C RID: 191500
			public const string OpenRouletteSetView = "OpenRouletteSetView";

			// Token: 0x0402EC0D RID: 191501
			public const string RouletteSwitchToggle = "RouletteSwitchToggle";

			// Token: 0x0402EC0E RID: 191502
			public const string PhotographSetVisible = "PhotographSetVisible";

			// Token: 0x0402EC0F RID: 191503
			public const string PhotoMenu = "PhotoMenu";

			// Token: 0x0402EC10 RID: 191504
			public const string SelectPhotoStickerItem = "SelectPhotoStickerItem";

			// Token: 0x0402EC11 RID: 191505
			public const string DeselectPhotoStickerItem = "DeselectPhotoStickerItem";

			// Token: 0x0402EC12 RID: 191506
			public const string PhotoStickerItemScaleIncrease = "PhotoStickerItemScaleIncrease";

			// Token: 0x0402EC13 RID: 191507
			public const string PhotoStickerItemScaleReduce = "PhotoStickerItemScaleReduce";

			// Token: 0x0402EC14 RID: 191508
			public const string MapTravelTaskNavigationNext = "MapTravelTaskNavigationNext";

			// Token: 0x0402EC15 RID: 191509
			public const string ShipTowerSwitchRightTeam = "ShipTowerSwitchRightTeam";

			// Token: 0x0402EC16 RID: 191510
			public const string ShipTowerAutoLeftTeam = "ShipTowerAutoLeftTeam";

			// Token: 0x0402EC17 RID: 191511
			public const string OpenTermExplanationView = "OpenTermExplanationView";

			// Token: 0x0402EC18 RID: 191512
			public const string MapRogueQuicklyMove = "MapRogueQuicklyMove";

			// Token: 0x0402EC19 RID: 191513
			public const string MapDragForward = "MapDragForward";

			// Token: 0x0402EC1A RID: 191514
			public const string MapDragRight = "MapDragRight";

			// Token: 0x0402EC1B RID: 191515
			public const string DangoLevelUp = "DangoLevelUp";

			// Token: 0x0402EC1C RID: 191516
			public const string DangoShop = "DangoShop";

			// Token: 0x0402EC1D RID: 191517
			public const string PhantomArenaBattleCardTips = "PhantomArenaBattleCardTips";

			// Token: 0x0402EC1E RID: 191518
			public const string PhantomArenaBattleCardCancel = "PhantomArenaBattleCardCancel";

			// Token: 0x0402EC1F RID: 191519
			public const string PhantomArenaBattleCardSelect = "PhantomArenaBattleCardSelect";

			// Token: 0x0402EC20 RID: 191520
			public const string PhantomArenaBattleLayoutHoist = "PhantomArenaBattleLayoutHoist";

			// Token: 0x0402EC21 RID: 191521
			public const string PhantomArenaBattleCardRecycle = "PhantomArenaBattleCardRecycle";

			// Token: 0x0402EC22 RID: 191522
			public const string PhantomArenaCardInfo = "PhantomArenaCardInfo";

			// Token: 0x0402EC23 RID: 191523
			public const string PhantomArenaBattleNavigationNext = "PhantomArenaBattleNavigationNext";

			// Token: 0x0402EC24 RID: 191524
			public const string PhonePetInteract = "PhonePetInteract";

			// Token: 0x0402EC25 RID: 191525
			public const string SeekTraceMoveUp = "SeekTraceMoveUp";

			// Token: 0x0402EC26 RID: 191526
			public const string SeekTraceMoveDown = "SeekTraceMoveDown";

			// Token: 0x0402EC27 RID: 191527
			public const string SeekTraceMoveLeft = "SeekTraceMoveLeft";

			// Token: 0x0402EC28 RID: 191528
			public const string SeekTraceMoveRight = "SeekTraceMoveRight";

			// Token: 0x0402EC29 RID: 191529
			public const string SeekTraceSelectItem = "SeekTraceSelectItem";

			// Token: 0x0402EC2A RID: 191530
			public const string SeekTraceResetItem = "SeekTraceResetItem";

			// Token: 0x0402EC2B RID: 191531
			public const string HonamiStoryMoveLeft = "HonamiStoryMoveLeft";

			// Token: 0x0402EC2C RID: 191532
			public const string HonamiStoryMoveRight = "HonamiStoryMoveRight";

			// Token: 0x0402EC2D RID: 191533
			public const string HonamiStoryPickUpDown = "HonamiStoryPickUpDown";

			// Token: 0x0402EC2E RID: 191534
			public const string HonamiStoryQuickEquip = "HonamiStoryQuickEquip";

			// Token: 0x0402EC2F RID: 191535
			public const string HonamiStoryQuickEquipOff = "HonamiStoryQuickEquipOff";

			// Token: 0x0402EC30 RID: 191536
			public const string HonamiStoryDiscard = "HonamiStoryDiscard";

			// Token: 0x0402EC31 RID: 191537
			public const string HonamiStoryLock = "HonamiStoryLock";

			// Token: 0x0402EC32 RID: 191538
			public const string HonamiStoryCancel = "HonamiStoryCancel";

			// Token: 0x0402EC33 RID: 191539
			public const string HonamiStoryLook = "HonamiStoryLook";

			// Token: 0x0402EC34 RID: 191540
			public const string HonamiStoryCollect = "HonamiStoryCollect";

			// Token: 0x0402EC35 RID: 191541
			public const string HonamiStorySell = "HonamiStorySell";

			// Token: 0x0402EC36 RID: 191542
			public const string HonamiStoryCancelShowOnly = "HonamiStoryCancelShowOnly";

			// Token: 0x0402EC37 RID: 191543
			public const string TeachScrollMove = "TeachScrollMove";

			// Token: 0x0402EC38 RID: 191544
			public const string CloseButton = "CloseButton";

			// Token: 0x0402EC39 RID: 191545
			public const string KujiLongTimeToTrigger = "KujiLongTimeToTrigger";

			// Token: 0x0402EC3A RID: 191546
			public const string AutoPilotRideShareBtn = "AutoPilotRideShareBtn";

			// Token: 0x0402EC3B RID: 191547
			public const string MotorMusicSortDragCancel = "MotorMusicSortDragCancel";

			// Token: 0x0402EC3C RID: 191548
			public const string FormationChoseRole = "FormationChoseRole";

			// Token: 0x0402EC3D RID: 191549
			public const string FormationCancelChoseRole = "FormationCancelChoseRole";

			// Token: 0x0402EC3E RID: 191550
			public const string FormationEditSort = "FormationEditSort";

			// Token: 0x0402EC3F RID: 191551
			public const string FormationEditSortMove = "FormationEditSortMove";

			// Token: 0x0402EC40 RID: 191552
			public const string FormationEditSortConfirm = "FormationEditSortConfirm";

			// Token: 0x0402EC41 RID: 191553
			public const string FormationEditSortCancel = "FormationEditSortCancel";

			// Token: 0x0402EC42 RID: 191554
			public const string ProjectionPhotoItemDragCancel = "ProjectionPhotoItemDragCancel";

			// Token: 0x0402EC43 RID: 191555
			public const string ZitherHighPitch = "ZitherHighPitch";

			// Token: 0x0402EC44 RID: 191556
			public const string ZitherCameraZoom = "ZitherCameraZoom";

			// Token: 0x0402EC45 RID: 191557
			public const string ZitherLowPitch = "ZitherLowPitch";

			// Token: 0x0402EC46 RID: 191558
			public const string MatchThreeSwapPiece = "MatchThreeSwapPiece";

			// Token: 0x0402EC47 RID: 191559
			public const string DangobrawlJumpBackpack = "DangobrawlJumpBackpack";

			// Token: 0x0402EC48 RID: 191560
			public const string DangobrawlJumpShop = "DangobrawlJumpShop";

			// Token: 0x0402EC49 RID: 191561
			public const string DangobrawlJumpBench = "DangobrawlJumpBench";

			// Token: 0x0402EC4A RID: 191562
			public const string DangobrawlJumpQucikCombine = "DangobrawlJumpQucikCombine";

			// Token: 0x0402EC4B RID: 191563
			public const string DangobrawlMoveRotate = "DangobrawlMoveRotate";

			// Token: 0x0402EC4C RID: 191564
			public const string DangobrawlLockShopGoods = "DangobrawlLockShopGoods";

			// Token: 0x0402EC4D RID: 191565
			public const string DangobrawlOpenCombineTips = "DangobrawlOpenCombineTips";

			// Token: 0x0402EC4E RID: 191566
			public const string DangobrawlCancel = "DangobrawlCancel";

			// Token: 0x0402EC4F RID: 191567
			public const string DangobrawlReplace = "DangobrawlReplace";

			// Token: 0x0402EC50 RID: 191568
			public const string DangobrawlStartFight = "DangobrawlStartFight";

			// Token: 0x0402EC51 RID: 191569
			public const string DangobrawlOpenItemTips = "DangobrawlOpenItemTips";

			// Token: 0x0402EC52 RID: 191570
			public const string TetrisRotate = "TetrisRotate";

			// Token: 0x0402EC53 RID: 191571
			public const string TetrisPickShape = "TetrisPickShape";
		}

		// Token: 0x020095AE RID: 38318
		[NullableContext(0)]
		public enum EHotKeyType
		{
			// Token: 0x0402EC55 RID: 191573
			Multiple
		}
	}
}

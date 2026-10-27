using System;
using System.Collections.Generic;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Capability;
using CSharpScript.Game.Input;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.IosAudit;
using CSharpScript.Game.LevelFlow;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.AimLine;
using CSharpScript.Game.LevelGamePlay.AlertArea;
using CSharpScript.Game.LevelGamePlay.BigStuffedDoll;
using CSharpScript.Game.LevelGamePlay.Cipher;
using CSharpScript.Game.LevelGamePlay.DigitalScreen;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine;
using CSharpScript.Game.LevelGamePlay.ElementalCasket;
using CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField;
using CSharpScript.Game.LevelGamePlay.FindSunSprite;
using CSharpScript.Game.LevelGamePlay.FishingQte;
using CSharpScript.Game.LevelGamePlay.FollowShooterHack;
using CSharpScript.Game.LevelGamePlay.GongduolaSummon;
using CSharpScript.Game.LevelGamePlay.GravityFlip;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.LevelGamePlay.ItemInspect;
using CSharpScript.Game.LevelGamePlay.LevelPickControl;
using CSharpScript.Game.LevelGamePlay.LivingCharMeteor;
using CSharpScript.Game.LevelGamePlay.Parkour;
using CSharpScript.Game.LevelGamePlay.ResetPlayer;
using CSharpScript.Game.LevelGamePlay.RollBlock;
using CSharpScript.Game.LevelGamePlay.SeekTrace;
using CSharpScript.Game.LevelGamePlay.SignalDeviceControl;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;
using CSharpScript.Game.LevelGamePlay.SundialControl;
using CSharpScript.Game.LevelGamePlay.SunSpirit;
using CSharpScript.Game.LevelGamePlay.TimeTrackControl;
using CSharpScript.Game.LevelGamePlay.TurntableControl;
using CSharpScript.Game.LevelGamePlay.UnopenedArea;
using CSharpScript.Game.LevelGamePlay.WriteLetter;
using CSharpScript.Game.Module.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.ActivityPOI;
using CSharpScript.Game.Module.Activity.ActivityContent.Anniversary;
using CSharpScript.Game.Module.Activity.ActivityContent.CommonH5;
using CSharpScript.Game.Module.Activity.ActivityContent.Coop;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.Activity.ActivityContent.FeiXue;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge;
using CSharpScript.Game.Module.Activity.ActivityContent.FunPlay;
using CSharpScript.Game.Module.Activity.ActivityContent.LineCross;
using CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn;
using CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop;
using CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage;
using CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink;
using CSharpScript.Game.Module.Activity.ActivityContent.MotorFight;
using CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;
using CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using CSharpScript.Game.Module.Activity.ActivityContent.PreWarm;
using CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Module.Activity.ActivityContent.RoadBook;
using CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.Activity.ActivityContent.Tetris;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity;
using CSharpScript.Game.Module.ActorFxEmote;
using CSharpScript.Game.Module.Application;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI;
using CSharpScript.Game.Module.BattleUiSet;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.BossPiling;
using CSharpScript.Game.Module.CiacconaGal;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Module.ComboTimeline;
using CSharpScript.Game.Module.Comic;
using CSharpScript.Game.Module.Common.Button;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.Cook;
using CSharpScript.Game.Module.Cursor;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.DreamLink;
using CSharpScript.Game.Module.EffectSave;
using CSharpScript.Game.Module.FirstPersonTurret;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Giant;
using CSharpScript.Game.Module.Giant.Activity;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemDeliver;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.JoinTeam;
using CSharpScript.Game.Module.KuroAutoCool;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Language;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.LevelPlay;
using CSharpScript.Game.Module.Login;
using CSharpScript.Game.Module.MailBind;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.Manufacture.Forging;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.MechanismTimeline;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Menu.SubViews.EyeProtect;
using CSharpScript.Game.Module.MingSu;
using CSharpScript.Game.Module.Movement;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Module.MusicalInstrument;
using CSharpScript.Game.Module.PermanentRogue;
using CSharpScript.Game.Module.PhantomArena;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.QuestMultiLine;
using CSharpScript.Game.Module.QuickHack;
using CSharpScript.Game.Module.QuickTimeAction;
using CSharpScript.Game.Module.RecallQuest;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.RoleMorph;
using CSharpScript.Game.Module.Scan;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Module.Season;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Module.Skin.Tab.Weapon;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.SlidingBlocks;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TowerDefenseUi;
using CSharpScript.Game.Module.Transport;
using CSharpScript.Game.Module.TreasureHunt;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using CSharpScript.Game.Module.VehicleStream;
using CSharpScript.Game.Module.VillageInfr;
using CSharpScript.Game.Module.WaterMask;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal;
using CSharpScript.Game.Module.WuwaGo.Controller;
using CSharpScript.Game.NewWorld.Character.Common.Controller;
using CSharpScript.Game.NewWorld.Character.Monster.Controller;
using CSharpScript.Game.NewWorld.Character.Npc.Controller;
using CSharpScript.Game.NewWorld.SceneItem.Controller;
using CSharpScript.Game.NewWorld.SceneItem.StreamingTrigger;
using CSharpScript.Game.Render;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Ui.Common.HudOnlyPopup;
using CSharpScript.Game.Utils;
using CSharpScript.Game.Utils.LevelRangeDebug;
using CSharpScript.Game.World.Controller;
using Kuro.Game.Module.Audio;

// Token: 0x02003562 RID: 13666
public class ControllerRegister
{
	// Token: 0x0601DFD7 RID: 122839 RVA: 0x00875630 File Offset: 0x00873830
	public static bool CreateInstance()
	{
		ControllerRegister.Controllers.Clear();
		ControllerRegister.TickControllers.Clear();
		if (!AiModelController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AiModelController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AiModelController.Instance);
		ControllerRegister.TickControllers.Add(AiModelController.Instance);
		if (!PhotographQuickController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhotographQuickController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhotographQuickController.Instance);
		ControllerRegister.TickControllers.Add(PhotographQuickController.Instance);
		if (!PhonographController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhonographController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhonographController.Instance);
		if (!PhoneMsgController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhoneMsgController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhoneMsgController.Instance);
		if (!PhantomInteractController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhantomInteractController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhantomInteractController.Instance);
		if (!VisionRecommendController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VisionRecommendController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(VisionRecommendController.Instance);
		if (!VisionEquipGroupController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VisionEquipGroupController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(VisionEquipGroupController.Instance);
		if (!PhantomBattleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhantomBattleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhantomBattleController.Instance);
		if (!PhantomArenaGuideController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.PhantomArena.PhantomArenaGuideController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhantomArenaGuideController.Instance);
		if (!PhantomArenaController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.PhantomArena.PhantomArenaController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhantomArenaController.Instance);
		if (!PhantomArenaBattleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.PhantomArena.PhantomArenaBattleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhantomArenaBattleController.Instance);
		if (!PersonalOptionController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PersonalOptionController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PersonalOptionController.Instance);
		if (!PersonalController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PersonalController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PersonalController.Instance);
		if (!ActivityPermanentRogueController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.PermanentRogue.ActivityPermanentRogueController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityPermanentRogueController.Instance);
		if (!WeekCardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeekCardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WeekCardController.Instance);
		if (!PayShopController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PayShopController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PayShopController.Instance);
		if (!PayGiftController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PayGiftController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PayGiftController.Instance);
		if (!MonthCardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MonthCardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MonthCardController.Instance);
		if (!BattlePassController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BattlePassController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BattlePassController.Instance);
		if (!PayItemController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PayItemController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PayItemController.Instance);
		if (!ParallelPackageController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ParallelPackageController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ParallelPackageController.Instance);
		if (!PanoramicUiDeferController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PanoramicUiDeferController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PanoramicUiDeferController.Instance);
		if (!PanoramicController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PanoramicController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PanoramicController.Instance);
		ControllerRegister.TickControllers.Add(PanoramicController.Instance);
		if (!PanelQteController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PanelQteController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PanelQteController.Instance);
		if (!OnlineController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::OnlineController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(OnlineController.Instance);
		ControllerRegister.TickControllers.Add(OnlineController.Instance);
		if (!MusicalInstrumentController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MusicalInstrument.MusicalInstrumentController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MusicalInstrumentController.Instance);
		if (!MovieModeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MovieMode.MovieModeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MovieModeController.Instance);
		ControllerRegister.TickControllers.Add(MovieModeController.Instance);
		if (!MoveTriggerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Movement.MoveTriggerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MoveTriggerController.Instance);
		if (!PhotographController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhotographController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhotographController.Instance);
		ControllerRegister.TickControllers.Add(PhotographController.Instance);
		if (!PhotoSnapshotController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhotoSnapshotController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PhotoSnapshotController.Instance);
		if (!PilotThrowController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PilotThrowController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PilotThrowController.Instance);
		ControllerRegister.TickControllers.Add(PilotThrowController.Instance);
		if (!PlatformController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PlatformController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PlatformController.Instance);
		if (!RoleDevController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleDevController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoleDevController.Instance);
		if (!RoleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoleController.Instance);
		if (!MainRoleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MainRoleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MainRoleController.Instance);
		if (!RoleMorphController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RoleMorph.RoleMorphController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoleMorphController.Instance);
		if (!RoguelikeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Roguelike.RoguelikeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoguelikeController.Instance);
		if (!RogueBattleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RogueBattle.RogueBattleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RogueBattleController.Instance);
		if (!RewardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Reward.RewardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RewardController.Instance);
		if (!ResourceManagerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ResManager.ResourceManagerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ResourceManagerController.Instance);
		ControllerRegister.TickControllers.Add(ResourceManagerController.Instance);
		if (!ReportController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ReportController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ReportController.Instance);
		if (!ReConnectController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ReConnectController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ReConnectController.Instance);
		if (!RecallQuestController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RecallQuest.RecallQuestController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RecallQuestController.Instance);
		if (!RandomPlotController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RandomPlotController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RandomPlotController.Instance);
		if (!RacingBetsController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RacingBetsController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RacingBetsController.Instance);
		if (!MovementLockController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MovementLockController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MovementLockController.Instance);
		if (!QtaController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.QuickTimeAction.QtaController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(QtaController.Instance);
		if (!QuestTreeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::QuestTreeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(QuestTreeController.Instance);
		if (!QuestReviewController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::QuestReviewController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(QuestReviewController.Instance);
		if (!QuestNewController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::QuestNewController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(QuestNewController.Instance);
		ControllerRegister.TickControllers.Add(QuestNewController.Instance);
		if (!QuestMultiLineController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(QuestMultiLineController.Instance);
		if (!CommonQteController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CommonQteController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CommonQteController.Instance);
		if (!BattleQteController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BattleQteController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BattleQteController.Instance);
		if (!PowerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PowerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PowerController.Instance);
		if (!SequenceController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.Sequence.SequenceController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SequenceController.Instance);
		ControllerRegister.TickControllers.Add(SequenceController.Instance);
		if (!PlotController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.PlotController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PlotController.Instance);
		ControllerRegister.TickControllers.Add(PlotController.Instance);
		if (!PlotCaptionImageController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.PlotCaptionImageController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PlotCaptionImageController.Instance);
		if (!PlotBlendController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.PlotBlendController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PlotBlendController.Instance);
		if (!FlowController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.Flow.FlowController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FlowController.Instance);
		ControllerRegister.TickControllers.Add(FlowController.Instance);
		if (!PlayerInfoController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PlayerInfoController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PlayerInfoController.Instance);
		if (!QuickHackController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.QuickHack.QuickHackController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(QuickHackController.Instance);
		if (!MotorcycleMusicPlayerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorcycleMusicPlayerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MotorcycleMusicPlayerController.Instance);
		if (!MotorcycleDiyController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorcycleDiyController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MotorcycleDiyController.Instance);
		if (!MotorcycleDevelopController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorcycleDevelopController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MotorcycleDevelopController.Instance);
		if (!KuroPerformanceController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::KuroPerformanceController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(KuroPerformanceController.Instance);
		ControllerRegister.TickControllers.Add(KuroPerformanceController.Instance);
		if (!KuroFastCollisionController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::KuroFastCollisionController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(KuroFastCollisionController.Instance);
		if (!KuroAutoCoolController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.KuroAutoCool.KuroAutoCoolController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(KuroAutoCoolController.Instance);
		ControllerRegister.TickControllers.Add(KuroAutoCoolController.Instance);
		if (!JoinTeamController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.JoinTeam.JoinTeamController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(JoinTeamController.Instance);
		if (!SpecialItemController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SpecialItemController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SpecialItemController.Instance);
		ControllerRegister.TickControllers.Add(SpecialItemController.Instance);
		if (!ItemController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Item.ItemController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ItemController.Instance);
		if (!ItemRewardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ItemReward.ItemRewardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ItemRewardController.Instance);
		if (!ItemHintController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ItemHintController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ItemHintController.Instance);
		ControllerRegister.TickControllers.Add(ItemHintController.Instance);
		if (!ItemExchangeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ItemExchangeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ItemExchangeController.Instance);
		if (!ItemDeliverController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ItemDeliver.ItemDeliverController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ItemDeliverController.Instance);
		if (!InventoryGiftController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InventoryGiftController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InventoryGiftController.Instance);
		if (!InventoryController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InventoryController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InventoryController.Instance);
		if (!InteractionController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Interaction.InteractionController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InteractionController.Instance);
		if (!KurotatoActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Kurotato.KurotatoActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(KurotatoActivityController.Instance);
		if (!InstanceGameplayModeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InstanceGameplayModeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InstanceGameplayModeController.Instance);
		if (!InstanceDungeonEntranceController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonEntranceController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InstanceDungeonEntranceController.Instance);
		if (!InstanceDungeonController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InstanceDungeonController.Instance);
		if (!ExchangeRewardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.InstanceDungeon.ExchangeReward.ExchangeRewardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ExchangeRewardController.Instance);
		if (!InfrastructureController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Infrastructure.InfrastructureController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InfrastructureController.Instance);
		if (!InfoDisplayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InfoDisplayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InfoDisplayController.Instance);
		if (!InfluenceReputationController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InfluenceReputationController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InfluenceReputationController.Instance);
		if (!IdlePerformController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::IdlePerformController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(IdlePerformController.Instance);
		ControllerRegister.TickControllers.Add(IdlePerformController.Instance);
		if (!HudUnitController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HudUnitController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(HudUnitController.Instance);
		ControllerRegister.TickControllers.Add(HudUnitController.Instance);
		if (!HonamiStoryController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.HonamiStory.HonamiStoryController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(HonamiStoryController.Instance);
		if (!HoldingHandsController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HoldingHandsController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(HoldingHandsController.Instance);
		if (!HideActorController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HideActorController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(HideActorController.Instance);
		ControllerRegister.TickControllers.Add(HideActorController.Instance);
		if (!HelpController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HelpController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(HelpController.Instance);
		if (!HandBookController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HandBookController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(HandBookController.Instance);
		if (!InstanceDungeonGuideController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonGuideController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InstanceDungeonGuideController.Instance);
		if (!RoleLevelUpSuccessController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleLevelUpSuccessController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoleLevelUpSuccessController.Instance);
		if (!KurotatoController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Kurotato.KurotatoController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(KurotatoController.Instance);
		if (!LevelLoadingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.LevelLoading.LevelLoadingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelLoadingController.Instance);
		ControllerRegister.TickControllers.Add(LevelLoadingController.Instance);
		if (!MotionController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotionController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MotionController.Instance);
		if (!MoraleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoraleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MoraleController.Instance);
		if (!PreDownloadController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PreDownloadController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PreDownloadController.Instance);
		if (!MingSuController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MingSu.MingSuController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MingSuController.Instance);
		if (!MeshStreamController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MeshStreamController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MeshStreamController.Instance);
		ControllerRegister.TickControllers.Add(MeshStreamController.Instance);
		if (!EyeProtectController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Menu.SubViews.EyeProtect.EyeProtectController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(EyeProtectController.Instance);
		if (!MenuController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Menu.MenuController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MenuController.Instance);
		if (!FilterSettingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FilterSettingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FilterSettingController.Instance);
		if (!MechanismTimelineController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MechanismTimeline.MechanismTimelineController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MechanismTimelineController.Instance);
		if (!MarqueeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MarqueeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MarqueeController.Instance);
		if (!MapController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Map.Controller.MapController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MapController.Instance);
		if (!MapRogueController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MapRogue.MapRogueController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MapRogueController.Instance);
		if (!MapExploreToolController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MapExploreToolController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MapExploreToolController.Instance);
		if (!LanguageController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Language.LanguageController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LanguageController.Instance);
		if (!ForgingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Manufacture.Forging.ForgingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ForgingController.Instance);
		if (!MailController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MailController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MailController.Instance);
		if (!MailBindController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MailBind.MailBindController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MailBindController.Instance);
		if (!LordGymController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LordGymController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LordGymController.Instance);
		if (!LogReportController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LogReportController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LogReportController.Instance);
		if (!GamepadLogReportController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GamepadLogReportController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GamepadLogReportController.Instance);
		if (!LoginServerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LoginServerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LoginServerController.Instance);
		if (!LoginGatewayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Login.LoginGatewayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LoginGatewayController.Instance);
		if (!LoginController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LoginController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LoginController.Instance);
		if (!LoadingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LoadingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LoadingController.Instance);
		if (!LevelUpController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelUpController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelUpController.Instance);
		if (!LoopTeleportVolumeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.LevelPlay.LoopTeleportVolumeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LoopTeleportVolumeController.Instance);
		ControllerRegister.TickControllers.Add(LoopTeleportVolumeController.Instance);
		if (!LevelPlayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelPlayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelPlayController.Instance);
		ControllerRegister.TickControllers.Add(LevelPlayController.Instance);
		if (!LevelPlayReportController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelPlayReportController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelPlayReportController.Instance);
		if (!ComposeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Manufacture.Compose.ComposeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ComposeController.Instance);
		if (!GuideController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GuideController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GuideController.Instance);
		if (!RouletteController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RouletteController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RouletteController.Instance);
		if (!ScanController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Scan.ScanController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ScanController.Instance);
		ControllerRegister.TickControllers.Add(ScanController.Instance);
		if (!LguiEventSystemController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Ui.LguiEventSystemController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LguiEventSystemController.Instance);
		if (!InputDistributeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Ui.InputDistributeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InputDistributeController.Instance);
		if (!HudOnlyPopupController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Ui.Common.HudOnlyPopup.HudOnlyPopupController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(HudOnlyPopupController.Instance);
		if (!ServerStorageController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.ServerStorage.ServerStorageController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ServerStorageController.Instance);
		if (!RenderModuleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Render.RenderModuleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RenderModuleController.Instance);
		if (!RedDotController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RedDotController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RedDotController.Instance);
		if (!PerfSightController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PerfSightController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PerfSightController.Instance);
		ControllerRegister.TickControllers.Add(PerfSightController.Instance);
		if (!VehiclePathMoveController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VehiclePathMoveController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(VehiclePathMoveController.Instance);
		if (!VehicleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VehicleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(VehicleController.Instance);
		ControllerRegister.TickControllers.Add(VehicleController.Instance);
		if (!SceneItemStreamingTriggerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.StreamingTrigger.SceneItemStreamingTriggerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SceneItemStreamingTriggerController.Instance);
		if (!SlashGameplayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Controller.SlashGameplayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SlashGameplayController.Instance);
		if (!SceneItemMoveController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Controller.SceneItemMoveController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SceneItemMoveController.Instance);
		if (!SceneItemGraphController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Controller.SceneItemGraphController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SceneItemGraphController.Instance);
		if (!SceneItemCaptureController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SceneItemCaptureController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SceneItemCaptureController.Instance);
		if (!SceneItemBuffController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Controller.SceneItemBuffController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SceneItemBuffController.Instance);
		if (!PortalController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Controller.PortalController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PortalController.Instance);
		if (!GravityHookController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Controller.GravityHookController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GravityHookController.Instance);
		if (!FlyingFeatherController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Controller.FlyingFeatherController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FlyingFeatherController.Instance);
		ControllerRegister.TickControllers.Add(FlyingFeatherController.Instance);
		if (!ChargeSlashGameplayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Controller.ChargeSlashGameplayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ChargeSlashGameplayController.Instance);
		ControllerRegister.TickControllers.Add(ChargeSlashGameplayController.Instance);
		if (!SimpleNpcLoadController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SimpleNpcLoadController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SimpleNpcLoadController.Instance);
		if (!SimpleNpcController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SimpleNpcController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SimpleNpcController.Instance);
		if (!RoleTriggerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleTriggerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoleTriggerController.Instance);
		ControllerRegister.TickControllers.Add(RoleTriggerController.Instance);
		if (!RoleAudioController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleAudioController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoleAudioController.Instance);
		ControllerRegister.TickControllers.Add(RoleAudioController.Instance);
		if (!NpcVehicleRiderController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::NpcVehicleRiderController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(NpcVehicleRiderController.Instance);
		if (!NpcTimetableController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.Character.Npc.Controller.NpcTimetableController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(NpcTimetableController.Instance);
		if (!NpcPerformController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::NpcPerformController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(NpcPerformController.Instance);
		if (!CrowdAiController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CrowdAiController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CrowdAiController.Instance);
		ControllerRegister.TickControllers.Add(CrowdAiController.Instance);
		if (!SceneUiController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Ui.SceneUiController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SceneUiController.Instance);
		if (!CombatDebugController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Utils.CombatDebugController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CombatDebugController.Instance);
		if (!CombatDebugDrawController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CombatDebugDrawController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CombatDebugDrawController.Instance);
		if (!LevelRangeDebugDrawController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Utils.LevelRangeDebug.LevelRangeDebugDrawController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelRangeDebugDrawController.Instance);
		if (!WorldController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WorldController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WorldController.Instance);
		if (!UpdateRateOptimizeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.UpdateRateOptimizeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(UpdateRateOptimizeController.Instance);
		ControllerRegister.TickControllers.Add(UpdateRateOptimizeController.Instance);
		if (!TimeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TimeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TimeController.Instance);
		ControllerRegister.TickControllers.Add(TimeController.Instance);
		if (!SyncSplineMoveController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.SyncSplineMoveController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SyncSplineMoveController.Instance);
		if (!SubLevelController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.SubLevelController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SubLevelController.Instance);
		if (!SneakController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.SneakController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SneakController.Instance);
		if (!ServerGmController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.ServerGmController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ServerGmController.Instance);
		if (!SceneOpacityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SceneOpacityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SceneOpacityController.Instance);
		ControllerRegister.TickControllers.Add(SceneOpacityController.Instance);
		if (!ResetTimeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ResetTimeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ResetTimeController.Instance);
		if (!PreloadControllerNew.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PreloadControllerNew 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PreloadControllerNew.Instance);
		if (!PlayerVelocityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.PlayerVelocityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PlayerVelocityController.Instance);
		ControllerRegister.TickControllers.Add(PlayerVelocityController.Instance);
		if (!PlayerSoarMonitorController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.PlayerSoarMonitorController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PlayerSoarMonitorController.Instance);
		ControllerRegister.TickControllers.Add(PlayerSoarMonitorController.Instance);
		if (!MultiInteractionActorController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.MultiInteractionActorController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MultiInteractionActorController.Instance);
		ControllerRegister.TickControllers.Add(MultiInteractionActorController.Instance);
		if (!MonsterGroupPatrolController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MonsterGroupPatrolController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MonsterGroupPatrolController.Instance);
		ControllerRegister.TickControllers.Add(MonsterGroupPatrolController.Instance);
		if (!LowMemoryScalabilityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.LowMemoryScalabilityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LowMemoryScalabilityController.Instance);
		if (!LoadMapController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LoadMapController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LoadMapController.Instance);
		if (!HierarchyLoadingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HierarchyLoadingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(HierarchyLoadingController.Instance);
		if (!GameModeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GameModeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GameModeController.Instance);
		ControllerRegister.TickControllers.Add(GameModeController.Instance);
		if (!CreatureGroupController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CreatureGroupController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CreatureGroupController.Instance);
		if (!CreatureController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CreatureController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CreatureController.Instance);
		if (!ComponentForceTickController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.ComponentForceTickController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ComponentForceTickController.Instance);
		ControllerRegister.TickControllers.Add(ComponentForceTickController.Instance);
		if (!BpActorController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BpActorController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BpActorController.Instance);
		ControllerRegister.TickControllers.Add(BpActorController.Instance);
		if (!BlackboardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BlackboardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BlackboardController.Instance);
		if (!BattleLogicController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BattleLogicController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BattleLogicController.Instance);
		if (!AttachToActorController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AttachToActorController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AttachToActorController.Instance);
		if (!AoiController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AoiController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AoiController.Instance);
		if (!AceAntiCheatController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AceAntiCheatController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AceAntiCheatController.Instance);
		ControllerRegister.TickControllers.Add(AceAntiCheatController.Instance);
		if (!ExpressionTreeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ExpressionTreeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ExpressionTreeController.Instance);
		if (!LogController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LogController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LogController.Instance);
		if (!MonsterGroupEcologyController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.Character.Monster.Controller.MonsterGroupEcologyController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MonsterGroupEcologyController.Instance);
		ControllerRegister.TickControllers.Add(MonsterGroupEcologyController.Instance);
		if (!CharacterRailSlideController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.Character.Common.Controller.CharacterRailSlideController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CharacterRailSlideController.Instance);
		if (!CharacterEmotionBubbleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.Character.Common.Controller.CharacterEmotionBubbleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CharacterEmotionBubbleController.Instance);
		if (!TowerDefenseEventController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.TowerDefenseEvent.TowerDefenseEventController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TowerDefenseEventController.Instance);
		ControllerRegister.TickControllers.Add(TowerDefenseEventController.Instance);
		if (!TowerDefenseController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TowerDefenseController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TowerDefenseController.Instance);
		if (!TimeOfDayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TimeOfDayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TimeOfDayController.Instance);
		ControllerRegister.TickControllers.Add(TimeOfDayController.Instance);
		if (!TermExplanationController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TermExplanationController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TermExplanationController.Instance);
		ControllerRegister.TickControllers.Add(TermExplanationController.Instance);
		if (!TeleportController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Teleport.TeleportController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TeleportController.Instance);
		ControllerRegister.TickControllers.Add(TeleportController.Instance);
		if (!SurvivorsRogueController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SurvivorsRogueController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SurvivorsRogueController.Instance);
		if (!SurvivorsActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SurvivorsActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SurvivorsActivityController.Instance);
		if (!SubPackageController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SubPackageController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SubPackageController.Instance);
		if (!SplashScreenController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SplashScreenController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SplashScreenController.Instance);
		if (!SpecialTransitionController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SpecialTransitionController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SpecialTransitionController.Instance);
		if (!SoundAreaPlayTipsController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SoundAreaPlayTipsController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SoundAreaPlayTipsController.Instance);
		if (!SlidingBlocksController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SlidingBlocks.SlidingBlocksController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SlidingBlocksController.Instance);
		ControllerRegister.TickControllers.Add(SlidingBlocksController.Instance);
		if (!SkipInterfaceController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SkipInterface.SkipInterfaceController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SkipInterfaceController.Instance);
		if (!TowerDefenseUiController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.TowerDefenseUi.TowerDefenseUiController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TowerDefenseUiController.Instance);
		ControllerRegister.TickControllers.Add(TowerDefenseUiController.Instance);
		if (!WeaponSkinController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Skin.Tab.Weapon.WeaponSkinController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WeaponSkinController.Instance);
		if (!CalabashSkinController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CalabashSkinController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CalabashSkinController.Instance);
		if (!SkinController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SkinController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SkinController.Instance);
		if (!SkillButtonUiController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SkillButtonUi.SkillButtonUiController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SkillButtonUiController.Instance);
		if (!SignalDecodeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SignalDecodeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SignalDecodeController.Instance);
		if (!ShopController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ShopController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ShopController.Instance);
		if (!ShipTowerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ShipTowerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ShipTowerController.Instance);
		if (!SheriffController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Sheriff.SheriffController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SheriffController.Instance);
		if (!SeasonController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Season.SeasonController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SeasonController.Instance);
		ControllerRegister.TickControllers.Add(SeasonController.Instance);
		if (!SeamlessTravelController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SeamlessTravel.SeamlessTravelController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SeamlessTravelController.Instance);
		ControllerRegister.TickControllers.Add(SeamlessTravelController.Instance);
		if (!ScrollingTipsController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ScrollingTipsController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ScrollingTipsController.Instance);
		if (!ScreenShotController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ScreenShotController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ScreenShotController.Instance);
		if (!SceneTeamController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SceneTeamController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SceneTeamController.Instance);
		if (!SceneBattleInteractController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SceneBattleInteractController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SceneBattleInteractController.Instance);
		ControllerRegister.TickControllers.Add(SceneBattleInteractController.Instance);
		if (!FlySkinController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FlySkinController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FlySkinController.Instance);
		if (!RouletteExploreSkillController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RouletteExploreSkillController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RouletteExploreSkillController.Instance);
		if (!TowerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TowerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TowerController.Instance);
		if (!TransportNetworkController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Transport.TransportNetworkController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TransportNetworkController.Instance);
		if (!PerformController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PerformController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PerformController.Instance);
		if (!DynamicFlowController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DynamicFlowController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DynamicFlowController.Instance);
		if (!PassiveSkillPlayerQueueController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PassiveSkillPlayerQueueController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PassiveSkillPlayerQueueController.Instance);
		if (!BuffController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BuffController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BuffController.Instance);
		ControllerRegister.TickControllers.Add(BuffController.Instance);
		if (!CharacterShadowController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CharacterShadowController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CharacterShadowController.Instance);
		ControllerRegister.TickControllers.Add(CharacterShadowController.Instance);
		if (!CharacterController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CharacterController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CharacterController.Instance);
		ControllerRegister.TickControllers.Add(CharacterController.Instance);
		if (!BulletController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BulletController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BulletController.Instance);
		ControllerRegister.TickControllers.Add(BulletController.Instance);
		if (!WuWaGoController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WuwaGo.Controller.WuWaGoController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WuWaGoController.Instance);
		ControllerRegister.TickControllers.Add(WuWaGoController.Instance);
		if (!WorldMapController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WorldMap.WorldMapController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WorldMapController.Instance);
		if (!RegionalTerminalController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WorldMap.RegionalTerminal.RegionalTerminalController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RegionalTerminalController.Instance);
		if (!WorldLevelController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WorldLevelController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WorldLevelController.Instance);
		if (!WeeklyRogueController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeeklyRogueController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WeeklyRogueController.Instance);
		if (!WeeklyChallengeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeeklyChallengeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WeeklyChallengeController.Instance);
		if (!TrackController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TrackController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TrackController.Instance);
		if (!WeatherController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Weather.WeatherController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WeatherController.Instance);
		if (WaterMaskView.ShouldRegister())
		{
			if (!WaterMaskView.CreateInstance())
			{
				Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WaterMask.WaterMaskView 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			ControllerRegister.Controllers.Add(WaterMaskView.Instance);
		}
		if (!WaitEntityTaskController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WaitEntityTaskController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WaitEntityTaskController.Instance);
		if (!VillageInfrController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.VillageInfr.VillageInfrController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(VillageInfrController.Instance);
		if (!VideoBpController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VideoBpController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(VideoBpController.Instance);
		if (!VehicleStreamController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.VehicleStream.VehicleStreamController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(VehicleStreamController.Instance);
		ControllerRegister.TickControllers.Add(VehicleStreamController.Instance);
		if (!UiNavigationNewController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::UiNavigationNewController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(UiNavigationNewController.Instance);
		ControllerRegister.TickControllers.Add(UiNavigationNewController.Instance);
		if (!UiModelEffectController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::UiModelEffectController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(UiModelEffectController.Instance);
		if (!HomeBtnController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.UiComponent.UiHomeButton.HomeBtnController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(HomeBtnController.Instance);
		if (!UiCameraController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::UiCameraController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(UiCameraController.Instance);
		if (!UiCameraAnimationController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::UiCameraAnimationController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(UiCameraAnimationController.Instance);
		if (!TutorialController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TutorialController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TutorialController.Instance);
		if (!TreasureHuntController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.TreasureHunt.TreasureHuntController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TreasureHuntController.Instance);
		if (!TrapDefenseController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TrapDefenseController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TrapDefenseController.Instance);
		if (!WeaponController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeaponController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WeaponController.Instance);
		if (!WorldDebugController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Controller.WorldDebugController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WorldDebugController.Instance);
		if (!GreatSwordController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GreatSwordController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GreatSwordController.Instance);
		if (!GiantActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Giant.Activity.GiantActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GiantActivityController.Instance);
		if (!DropCatchActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.DropCatchActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DropCatchActivityController.Instance);
		if (!ActivityDoubleRewardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityDoubleRewardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityDoubleRewardController.Instance);
		if (!DirectTrainActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity.DirectTrainActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DirectTrainActivityController.Instance);
		if (!ActivityDirectTrainController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.ActivityDirectTrainController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityDirectTrainController.Instance);
		if (!ActivityDangoMonopolyController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityDangoMonopolyController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityDangoMonopolyController.Instance);
		if (!ActivityDangoBrawlController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.ActivityDangoBrawlController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityDangoBrawlController.Instance);
		if (!DangoAbyssActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DangoAbyssActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DangoAbyssActivityController.Instance);
		if (!DailyAdventureTaskController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DailyAdventureTaskController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DailyAdventureTaskController.Instance);
		if (!ActivityDailyAdventureController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityDailyAdventureController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityDailyAdventureController.Instance);
		if (!CyberPunkController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk.CyberPunkController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CyberPunkController.Instance);
		if (!AdamSmasherController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk.AdamSmasherController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AdamSmasherController.Instance);
		if (!CumulativeShopController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CumulativeShopController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CumulativeShopController.Instance);
		if (!ActivityCorniceMeetingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityCorniceMeetingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityCorniceMeetingController.Instance);
		if (!CoopActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Coop.CoopActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CoopActivityController.Instance);
		if (!CommonH5Controller.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.CommonH5.CommonH5Controller 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CommonH5Controller.Instance);
		if (!ActivityCollectionController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityCollectionController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityCollectionController.Instance);
		if (!CiacconaActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CiacconaActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CiacconaActivityController.Instance);
		if (!ChessController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ChessController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ChessController.Instance);
		if (!BossRushController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BossRushController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BossRushController.Instance);
		if (!ActivityBlackCoastController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityBlackCoastController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityBlackCoastController.Instance);
		if (!BeginnerCarnivalController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BeginnerCarnivalController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BeginnerCarnivalController.Instance);
		if (!ActivityBeginnerBookController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityBeginnerBookController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityBeginnerBookController.Instance);
		if (!BabelTowerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BabelTowerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BabelTowerController.Instance);
		if (!AvignonController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AvignonController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AvignonController.Instance);
		if (!ArtemisActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ArtemisActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ArtemisActivityController.Instance);
		if (!AnniversaryActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Anniversary.AnniversaryActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AnniversaryActivityController.Instance);
		if (!AdvanceNoticeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AdvanceNoticeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AdvanceNoticeController.Instance);
		if (!DropCatchGameplayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.DropCatchGameplayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DropCatchGameplayController.Instance);
		if (!ActivityEncircleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Encircle.ActivityEncircleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityEncircleController.Instance);
		if (!FarmGoldController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.FarmGold.FarmGoldController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FarmGoldController.Instance);
		if (!ActivityFeiXuePreheatController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.FeiXue.ActivityFeiXuePreheatController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityFeiXuePreheatController.Instance);
		if (!ActivityMowingRiskController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk.ActivityMowingRiskController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMowingRiskController.Instance);
		if (!MotorParkourController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour.MotorParkourController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MotorParkourController.Instance);
		if (!ActivityMotorGiftController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityMotorGiftController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMotorGiftController.Instance);
		if (!MotorFightController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotorFight.MotorFightController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MotorFightController.Instance);
		if (!MotorDecalLinkController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink.MotorDecalLinkController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MotorDecalLinkController.Instance);
		if (!ActivityMotorLinkageController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage.ActivityMotorLinkageController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMotorLinkageController.Instance);
		if (!ActivityMotorDevelopController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop.ActivityMotorDevelopController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMotorDevelopController.Instance);
		if (!ActivityMoraleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityMoraleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMoraleController.Instance);
		if (!MoonSignInController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn.MoonSignInController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MoonSignInController.Instance);
		if (!MoonChasingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonChasingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MoonChasingController.Instance);
		if (!ActivityMoonChasingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityMoonChasingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMoonChasingController.Instance);
		if (!MatchThreeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.MatchThreeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MatchThreeController.Instance);
		if (!ActivityMatchThreeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity.ActivityMatchThreeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMatchThreeController.Instance);
		if (!ActivityPoiController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.ActivityPOI.ActivityPoiController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityPoiController.Instance);
		if (!ActivityMapTravelController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityMapTravelController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMapTravelController.Instance);
		if (!ActivityLordGymController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityLordGymController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityLordGymController.Instance);
		if (!ActivityLoopTowerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityLoopTowerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityLoopTowerController.Instance);
		if (!ActivityLongShanController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityLongShanController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityLongShanController.Instance);
		if (!LinkageRewardActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward.LinkageRewardActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LinkageRewardActivityController.Instance);
		if (!LineCrossActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.LineCross.LineCrossActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LineCrossActivityController.Instance);
		if (!LifePointDrawActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LifePointDrawActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LifePointDrawActivityController.Instance);
		if (!ActivityInviteNewbieController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityInviteNewbieController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityInviteNewbieController.Instance);
		if (!GuQinActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.GuQinActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GuQinActivityController.Instance);
		if (!ActivityFunPlayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.FunPlay.ActivityFunPlayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityFunPlayController.Instance);
		if (!ActivityFlagChallengeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge.ActivityFlagChallengeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityFlagChallengeController.Instance);
		if (!FishingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Fishing.FishingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FishingController.Instance);
		if (!ActivityFishingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Fishing.ActivityFishingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityFishingController.Instance);
		if (!FightPhotoController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FightPhotoController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FightPhotoController.Instance);
		if (!ActivityMapExploreController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityMapExploreController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMapExploreController.Instance);
		if (!ActivityLinkageController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityLinkageController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityLinkageController.Instance);
		if (!ActivityRecommendController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRecommendController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRecommendController.Instance);
		if (!RhythmGameShipController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RhythmGameShipController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RhythmGameShipController.Instance);
		if (!ElementalFieldVolumeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField.ElementalFieldVolumeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ElementalFieldVolumeController.Instance);
		if (!ElementalFieldGraphController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField.ElementalFieldGraphController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ElementalFieldGraphController.Instance);
		if (!ElementalFieldDebugDrawController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField.ElementalFieldDebugDrawController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ElementalFieldDebugDrawController.Instance);
		ControllerRegister.TickControllers.Add(ElementalFieldDebugDrawController.Instance);
		if (!ElementalFieldCameraBlockController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField.ElementalFieldCameraBlockController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ElementalFieldCameraBlockController.Instance);
		ControllerRegister.TickControllers.Add(ElementalFieldCameraBlockController.Instance);
		if (!ElementalCasketController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalCasketController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ElementalCasketController.Instance);
		if (!DollGrabShowcaseController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabShowcaseController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DollGrabShowcaseController.Instance);
		if (!DollGrabMachineController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DollGrabMachineController.Instance);
		ControllerRegister.TickControllers.Add(DollGrabMachineController.Instance);
		if (!DigitalScreenController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.DigitalScreen.DigitalScreenController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DigitalScreenController.Instance);
		if (!CipherController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.Cipher.CipherController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CipherController.Instance);
		if (!BigStuffedDollController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.BigStuffedDoll.BigStuffedDollController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BigStuffedDollController.Instance);
		if (!AlertAreaController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.AlertArea.AlertAreaController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AlertAreaController.Instance);
		if (!LevelAimLineController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.AimLine.LevelAimLineController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelAimLineController.Instance);
		if (!LevelFlowController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelFlow.LevelFlowController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelFlowController.Instance);
		ControllerRegister.TickControllers.Add(LevelFlowController.Instance);
		if (!FindSunSpiritController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.FindSunSprite.FindSunSpiritController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FindSunSpiritController.Instance);
		if (!KuroSimpleCombatController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::KuroSimpleCombatController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(KuroSimpleCombatController.Instance);
		ControllerRegister.TickControllers.Add(KuroSimpleCombatController.Instance);
		if (!KuroSdkController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::KuroSdkController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(KuroSdkController.Instance);
		if (!KuroPushController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::KuroPushController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(KuroPushController.Instance);
		if (!IosAuditController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.IosAudit.IosAuditController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(IosAuditController.Instance);
		if (!InputController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Input.InputController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InputController.Instance);
		if (!TouchUiEditController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.InputSetting.TouchUiEditController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TouchUiEditController.Instance);
		if (!InputSettingsController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.InputSetting.InputSettingsController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(InputSettingsController.Instance);
		if (!PortalRenderController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Controller.PortalRenderController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PortalRenderController.Instance);
		ControllerRegister.TickControllers.Add(PortalRenderController.Instance);
		if (!GameSettingsController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GameSettingsController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GameSettingsController.Instance);
		if (!EffectAudioController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::EffectAudioController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(EffectAudioController.Instance);
		ControllerRegister.TickControllers.Add(EffectAudioController.Instance);
		if (!CrashCollectionController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CrashCollectionController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CrashCollectionController.Instance);
		if (!CapabilityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Capability.CapabilityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CapabilityController.Instance);
		ControllerRegister.TickControllers.Add(CapabilityController.Instance);
		if (!CameraNearClipController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Camera.CameraNearClipController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CameraNearClipController.Instance);
		if (!CameraController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Camera.CameraController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CameraController.Instance);
		ControllerRegister.TickControllers.Add(CameraController.Instance);
		if (!OpenHarmonySdkController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::OpenHarmonySdkController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(OpenHarmonySdkController.Instance);
		if (!MowingTowerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MowingTowerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MowingTowerController.Instance);
		if (!FishingQteController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.FishingQte.FishingQteController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FishingQteController.Instance);
		if (!GongduolaSummonController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.GongduolaSummon.GongduolaSummonController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GongduolaSummonController.Instance);
		if (!RhythmGameController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RhythmGameController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RhythmGameController.Instance);
		if (!GuessJokerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GuessJokerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GuessJokerController.Instance);
		if (!GolemHackingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GolemHackingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GolemHackingController.Instance);
		if (!FurnitureController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FurnitureController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FurnitureController.Instance);
		if (!AchievementController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AchievementController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AchievementController.Instance);
		if (!FormationDataController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FormationDataController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FormationDataController.Instance);
		ControllerRegister.TickControllers.Add(FormationDataController.Instance);
		if (!FormationAttributeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FormationAttributeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FormationAttributeController.Instance);
		ControllerRegister.TickControllers.Add(FormationAttributeController.Instance);
		if (!WriteLetterController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.WriteLetter.WriteLetterController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WriteLetterController.Instance);
		if (!UnopenedAreaController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.UnopenedArea.UnopenedAreaController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(UnopenedAreaController.Instance);
		ControllerRegister.TickControllers.Add(UnopenedAreaController.Instance);
		if (!TurntableControlController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.TurntableControl.TurntableControlController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TurntableControlController.Instance);
		if (!TimeTrackController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.TimeTrackControl.TimeTrackController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TimeTrackController.Instance);
		if (!SunSpiritController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SunSpiritController.Instance);
		ControllerRegister.TickControllers.Add(SunSpiritController.Instance);
		if (!SundialControlController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SundialControl.SundialControlController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SundialControlController.Instance);
		if (!FollowShooterHackController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.FollowShooterHack.FollowShooterHackController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FollowShooterHackController.Instance);
		if (!SplineMoveTaskController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SplineMoveTask.SplineMoveTaskController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SplineMoveTaskController.Instance);
		ControllerRegister.TickControllers.Add(SplineMoveTaskController.Instance);
		if (!SignalDeviceController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SignalDeviceControl.SignalDeviceController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SignalDeviceController.Instance);
		if (!SeekTraceController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SeekTrace.SeekTraceController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SeekTraceController.Instance);
		if (!RollBlockController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.RollBlock.RollBlockController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RollBlockController.Instance);
		if (!ResetPlayerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ResetPlayer.ResetPlayerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ResetPlayerController.Instance);
		if (!ProjectionPhotoController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ProjectionPhotoController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ProjectionPhotoController.Instance);
		if (!ParkourController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.Parkour.ParkourController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ParkourController.Instance);
		if (!LivingCharMeteorController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.LivingCharMeteor.LivingCharMeteorController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LivingCharMeteorController.Instance);
		if (!LevelPickInteractController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.LevelPickControl.LevelPickInteractController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelPickInteractController.Instance);
		ControllerRegister.TickControllers.Add(LevelPickInteractController.Instance);
		if (!LevelGeneralController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.LevelGeneralController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelGeneralController.Instance);
		ControllerRegister.TickControllers.Add(LevelGeneralController.Instance);
		if (!LevelGamePlayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.LevelGamePlayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(LevelGamePlayController.Instance);
		ControllerRegister.TickControllers.Add(LevelGamePlayController.Instance);
		if (!ItemInspectController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ItemInspect.ItemInspectController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ItemInspectController.Instance);
		if (!GuaranteeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GuaranteeController.Instance);
		if (!GravityFlipController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.GravityFlip.GravityFlipController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GravityFlipController.Instance);
		if (!SplineConstrainedDragController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.SplineConstrainedDragController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SplineConstrainedDragController.Instance);
		ControllerRegister.TickControllers.Add(SplineConstrainedDragController.Instance);
		if (!GiantController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Giant.GiantController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GiantController.Instance);
		if (!ActivityMowingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Mowing.ActivityMowingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityMowingController.Instance);
		if (!ActivityNewbieCourseV2Controller.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityNewbieCourseV2Controller 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityNewbieCourseV2Controller.Instance);
		if (!DailyActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DailyActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DailyActivityController.Instance);
		if (!CursorController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Cursor.CursorController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CursorController.Instance);
		if (!CreateCharacterController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CreateCharacterController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CreateCharacterController.Instance);
		if (!CookController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Cook.CookController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CookController.Instance);
		if (!ControlScreenController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ControlScreenController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ControlScreenController.Instance);
		if (!ConfirmBoxController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ConfirmBoxController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ConfirmBoxController.Instance);
		if (!CommonSuccessController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CommonSuccessController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CommonSuccessController.Instance);
		if (!CommonInputViewController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Common.InputView.Controller.CommonInputViewController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CommonInputViewController.Instance);
		if (!FilterSortController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FilterSortController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FilterSortController.Instance);
		if (!ButtonStateController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Common.Button.ButtonStateController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ButtonStateController.Instance);
		if (!ComicController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Comic.ComicController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ComicController.Instance);
		if (!ComboTimelineReplayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ComboTimeline.ComboTimelineReplayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ComboTimelineReplayController.Instance);
		ControllerRegister.TickControllers.Add(ComboTimelineReplayController.Instance);
		if (!ComboTeachingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ComboTeachingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ComboTeachingController.Instance);
		if (!SkillMessageController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.CombatMessage.SkillMessageController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SkillMessageController.Instance);
		if (!RoleSceneInteractController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleSceneInteractController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoleSceneInteractController.Instance);
		if (!CombatMessageController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.CombatMessage.CombatMessageController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CombatMessageController.Instance);
		ControllerRegister.TickControllers.Add(CombatMessageController.Instance);
		if (!CiacconaGalController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.CiacconaGal.CiacconaGalController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CiacconaGalController.Instance);
		ControllerRegister.TickControllers.Add(CiacconaGalController.Instance);
		if (!ChatController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ChatController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ChatController.Instance);
		if (!ChannelController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ChannelController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ChannelController.Instance);
		if (!CdKeyInputController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CdKeyInputController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CdKeyInputController.Instance);
		if (!CalabashController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CalabashController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CalabashController.Instance);
		if (!BuildingGridController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BuildingGridController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BuildingGridController.Instance);
		if (!BuffItemControl.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BuffItemControl 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BuffItemControl.Instance);
		if (!BossPilingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BossPiling.BossPilingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BossPilingController.Instance);
		if (!BlackScreenFadeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BlackScreenFadeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BlackScreenFadeController.Instance);
		if (!BlackScreenController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BlackScreen.BlackScreenController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BlackScreenController.Instance);
		if (!BirthdayController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BirthdayController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BirthdayController.Instance);
		if (!DamageUiController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DamageUiController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DamageUiController.Instance);
		ControllerRegister.TickControllers.Add(DamageUiController.Instance);
		if (!DangoAbyssController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DangoAbyssController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DangoAbyssController.Instance);
		if (!DangoGlobalController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DangoGlobalController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DangoGlobalController.Instance);
		if (!DeadEyeModeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DeadEyeModeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DeadEyeModeController.Instance);
		if (!GenericPromptController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.GenericPrompt.GenericPromptController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GenericPromptController.Instance);
		if (!GeneralLogicTreeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GeneralLogicTreeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GeneralLogicTreeController.Instance);
		if (!GamePingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GamePingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GamePingController.Instance);
		if (!GamepadController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Gamepad.GamepadController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GamepadController.Instance);
		if (!GameBudgetController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GameBudgetController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GameBudgetController.Instance);
		if (!GachaController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GachaController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GachaController.Instance);
		if (!GachaAccumulateController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GachaAccumulateController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GachaAccumulateController.Instance);
		if (!FunctionController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Functional.FunctionController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FunctionController.Instance);
		if (!FullScreenEffectController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FullScreenEffectController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FullScreenEffectController.Instance);
		if (!FriendController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FriendController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FriendController.Instance);
		if (!FreezeOnSightController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FreezeOnSightController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FreezeOnSightController.Instance);
		ControllerRegister.TickControllers.Add(FreezeOnSightController.Instance);
		if (!FragmentMemoryController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FragmentMemoryController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FragmentMemoryController.Instance);
		if (!FragmentMemoryActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FragmentMemoryActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FragmentMemoryActivityController.Instance);
		if (!SkillCdController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.SkillCdController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SkillCdController.Instance);
		ControllerRegister.TickControllers.Add(SkillCdController.Instance);
		if (!FormationViewDragController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FormationViewDragController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FormationViewDragController.Instance);
		if (!FormationController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FormationController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FormationController.Instance);
		if (!FloroRanchController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FloroRanchController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FloroRanchController.Instance);
		if (!FlagChallengeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.FlagChallenge.FlagChallengeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FlagChallengeController.Instance);
		if (!FirstPersonTurretController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.FirstPersonTurret.FirstPersonTurretController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FirstPersonTurretController.Instance);
		if (!FeedbackRewardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FeedbackRewardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FeedbackRewardController.Instance);
		if (!FadeBackgroundController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FadeBackgroundController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FadeBackgroundController.Instance);
		if (!ExploreProgressController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ExploreProgressController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ExploreProgressController.Instance);
		if (!ExploreLevelController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ExploreLevelController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ExploreLevelController.Instance);
		if (!ErrorCodeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ErrorCodeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ErrorCodeController.Instance);
		if (!EffectSaveController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.EffectSave.EffectSaveController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(EffectSaveController.Instance);
		if (!DrinksController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DrinksController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DrinksController.Instance);
		if (!DreamLinkController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.DreamLink.DreamLinkController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DreamLinkController.Instance);
		if (!DeadReviveController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.DeadRevive.DeadReviveController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(DeadReviveController.Instance);
		if (!FormationEditSortController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FormationEditSortController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FormationEditSortController.Instance);
		if (!BattleScoreController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.BattleScoreController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BattleScoreController.Instance);
		if (!MoraleBattleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.MoraleBattleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MoraleBattleController.Instance);
		if (!BattleLinkController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.BattleLinkController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BattleLinkController.Instance);
		if (!ActivitySolarSpeedController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed.ActivitySolarSpeedController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivitySolarSpeedController.Instance);
		if (!ActivitySoarController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivitySoarController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivitySoarController.Instance);
		if (!ActivityShipTowerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityShipTowerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityShipTowerController.Instance);
		if (!ActivitySevenDaySignController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivitySevenDaySignController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivitySevenDaySignController.Instance);
		if (!ActivityScratchTicketController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityScratchTicketController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityScratchTicketController.Instance);
		if (!ActivityRunController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRunController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRunController.Instance);
		if (!RoverlikeController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Roverlike.RoverlikeController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoverlikeController.Instance);
		if (!RoverlikeActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Roverlike.RoverlikeActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoverlikeActivityController.Instance);
		if (!ActivityRogueController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity.ActivityRogueController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRogueController.Instance);
		if (!ActivityRoleTrialController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRoleTrialController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRoleTrialController.Instance);
		if (!RoleSkinTrialController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleSkinTrialController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoleSkinTrialController.Instance);
		if (!ActivityRoleSkinRewardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward.ActivityRoleSkinRewardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRoleSkinRewardController.Instance);
		if (!ActivityRoleGuideController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRoleGuideController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRoleGuideController.Instance);
		if (!ActivitySpring25Controller.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivitySpring25Controller 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivitySpring25Controller.Instance);
		if (!ActivityRoleGiveController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRoleGiveController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRoleGiveController.Instance);
		if (!ActivityRoadBookController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RoadBook.ActivityRoadBookController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRoadBookController.Instance);
		if (!RhythmShipController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.RhythmShipController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RhythmShipController.Instance);
		if (!ActivityRegressController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRegressController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRegressController.Instance);
		if (!ActivityRealmBetweenController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween.ActivityRealmBetweenController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityRealmBetweenController.Instance);
		if (!ActivityPrizeDrawingController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityPrizeDrawingController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityPrizeDrawingController.Instance);
		if (!ActivityPreWarmController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.PreWarm.ActivityPreWarmController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityPreWarmController.Instance);
		if (!PinballController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Pinball.PinballController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(PinballController.Instance);
		if (!ActivityPhantomCollectController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityPhantomCollectController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityPhantomCollectController.Instance);
		if (!ActivityNoviceJourneyController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityNoviceJourneyController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityNoviceJourneyController.Instance);
		if (!ActivityNewPlayerSupportController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityNewPlayerSupportController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityNewPlayerSupportController.Instance);
		if (!ActivityNewPlayerSupportActivityV2Controller.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityNewPlayerSupportActivityV2Controller 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityNewPlayerSupportActivityV2Controller.Instance);
		if (!ActivityNewcomerJourneyController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityNewcomerJourneyController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityNewcomerJourneyController.Instance);
		if (!NewbieMainController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain.NewbieMainController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(NewbieMainController.Instance);
		if (!RoleGiftController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleGiftController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(RoleGiftController.Instance);
		if (!MultiMotorController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor.MultiMotorController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(MultiMotorController.Instance);
		if (!SpringManorController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.SpringManor.SpringManorController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(SpringManorController.Instance);
		if (!TetrisController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Tetris.TetrisController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TetrisController.Instance);
		if (!FlagChallengeBattleController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.FlagChallengeBattleController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(FlagChallengeBattleController.Instance);
		if (!CooperationController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CooperationController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(CooperationController.Instance);
		if (!BattleViewDynamicUIController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI.BattleViewDynamicUIController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BattleViewDynamicUIController.Instance);
		if (!BattleUiDataControl.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BattleUi.BattleUiDataControl 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BattleUiDataControl.Instance);
		if (!BattleUiControl.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BattleUi.BattleUiControl 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BattleUiControl.Instance);
		if (!BattleUiSetController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BattleUiSet.BattleUiSetController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(BattleUiSetController.Instance);
		if (!AutoPilotController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.AutoPilot.AutoPilotController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AutoPilotController.Instance);
		ControllerRegister.TickControllers.Add(AutoPilotController.Instance);
		if (!WeaponEnvInteractionAudioController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::Kuro.Game.Module.Audio.WeaponEnvInteractionAudioController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WeaponEnvInteractionAudioController.Instance);
		if (!GameAudioController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Audio.GameAudioController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(GameAudioController.Instance);
		ControllerRegister.TickControllers.Add(GameAudioController.Instance);
		if (!AreaController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Area.AreaController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AreaController.Instance);
		ControllerRegister.TickControllers.Add(AreaController.Instance);
		if (!AppLinksController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AppLinksController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AppLinksController.Instance);
		if (!ApplicationController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Application.ApplicationController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ApplicationController.Instance);
		if (!AntiCheatController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AntiCheatController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AntiCheatController.Instance);
		if (!ActivityTetrisController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Tetris.ActivityTetrisController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityTetrisController.Instance);
		if (!AnimController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AnimController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AnimController.Instance);
		ControllerRegister.TickControllers.Add(AnimController.Instance);
		if (!AdviceController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AdviceController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AdviceController.Instance);
		if (!AdventureGuideController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AdventureGuideController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AdventureGuideController.Instance);
		if (!ActorFxEmoteController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ActorFxEmote.ActorFxEmoteController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActorFxEmoteController.Instance);
		if (!ActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityController.Instance);
		if (!WuWuLogisticsActivityController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WuWuLogisticsActivityController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WuWuLogisticsActivityController.Instance);
		if (!WheelTowerController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WheelTowerController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(WheelTowerController.Instance);
		if (!ActivityVersionPreheatController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityVersionPreheatController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityVersionPreheatController.Instance);
		if (!ActivityUniversalController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity.ActivityUniversalController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityUniversalController.Instance);
		if (!ActivityTurntableController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityTurntableController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityTurntableController.Instance);
		if (!ActivityTrapDefenseController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityTrapDefenseController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityTrapDefenseController.Instance);
		if (!ActivityTowerGuideController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityTowerGuideController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityTowerGuideController.Instance);
		if (!TotalTopUpController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp.TotalTopUpController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(TotalTopUpController.Instance);
		if (!ActivityTimePointRewardController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityTimePointRewardController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(ActivityTimePointRewardController.Instance);
		if (!AndroidBackController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AndroidBackController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(AndroidBackController.Instance);
		if (!EnvironmentalPerceptionController.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::EnvironmentalPerceptionController 创建控制器单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ControllerRegister.Controllers.Add(EnvironmentalPerceptionController.Instance);
		ControllerRegister.TickControllers.Add(EnvironmentalPerceptionController.Instance);
		return true;
	}

	// Token: 0x0601DFD8 RID: 122840 RVA: 0x0087C280 File Offset: 0x0087A480
	public static bool RegisterTick()
	{
		for (int i = 0; i < ControllerRegister.TickControllers.Count; i++)
		{
			if (ControllerRegister.TickControllers[i] == null)
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.LRX, "TickController 注册控制器Tick失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
		}
		if (!Stat.Enable)
		{
			return true;
		}
		for (int j = 0; j < ControllerRegister.TickControllers.Count; j++)
		{
			ControllerBase controllerBase = ControllerRegister.TickControllers[j];
			controllerBase.SetPerformanceStateObject(controllerBase.GetType().Name, "", "");
		}
		return true;
	}

	// Token: 0x0601DFD9 RID: 122841 RVA: 0x0087C314 File Offset: 0x0087A514
	public static bool Init()
	{
		for (int i = 0; i < ControllerRegister.Controllers.Count; i++)
		{
			ControllerBase controllerBase = ControllerRegister.Controllers[i];
			if (!controllerBase.Init())
			{
				Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, controllerBase.GetType().FullName + " 控制器初始化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601DFDA RID: 122842 RVA: 0x0087C37C File Offset: 0x0087A57C
	public static bool Clear()
	{
		bool result = true;
		for (int i = 0; i < ControllerRegister.Controllers.Count; i++)
		{
			ControllerBase controllerBase = ControllerRegister.Controllers[i];
			try
			{
				if (!controllerBase.Clear())
				{
					Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, controllerBase.GetType().FullName + " 控制器清理失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = false;
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = controllerBase.GetType().FullName + " 控制器清理失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ex:", ex.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0601DFDB RID: 122843 RVA: 0x0087C440 File Offset: 0x0087A640
	public static bool LeaveLevel()
	{
		bool result = true;
		for (int i = 0; i < ControllerRegister.Controllers.Count; i++)
		{
			ControllerBase controllerBase = ControllerRegister.Controllers[i];
			try
			{
				if (!controllerBase.LeaveLevel())
				{
					Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, controllerBase.GetType().FullName + " 控制器退出关卡失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = false;
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = controllerBase.GetType().FullName + " 控制器退出关卡失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ex:", ex.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0601DFDC RID: 122844 RVA: 0x0087C504 File Offset: 0x0087A704
	public static bool ChangeMode()
	{
		bool result = true;
		for (int i = 0; i < ControllerRegister.Controllers.Count; i++)
		{
			ControllerBase controllerBase = ControllerRegister.Controllers[i];
			try
			{
				if (!controllerBase.ChangeMode())
				{
					Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, controllerBase.GetType().FullName + " 控制器退出模式失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = false;
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = controllerBase.GetType().FullName + " 控制器退出模式失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ex:", ex.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0601DFDD RID: 122845 RVA: 0x0087C5C8 File Offset: 0x0087A7C8
	public static List<ValueTuple<string, CustomPromise<bool>>> Preload()
	{
		List<ValueTuple<string, CustomPromise<bool>>> list = new List<ValueTuple<string, CustomPromise<bool>>>();
		ValueTuple<string, CustomPromise<bool>>? valueTuple = null;
		for (int i = 0; i < ControllerRegister.Controllers.Count; i++)
		{
			valueTuple = ControllerRegister.Controllers[i].Preload();
			if (valueTuple != null)
			{
				list.Add(valueTuple.Value);
			}
		}
		return list;
	}

	// Token: 0x0601DFDE RID: 122846 RVA: 0x0087C620 File Offset: 0x0087A820
	public static void Tick(float delta, bool isInFight)
	{
		foreach (ControllerBase controllerBase in ControllerRegister.TickControllers)
		{
			if (controllerBase.CheckTick(isInFight, delta) && (!TickSystem.Instance.IsPaused || controllerBase.IsTickEvenPaused))
			{
				controllerBase.GetPerformanceStateObject();
				controllerBase.Tick(delta);
			}
		}
	}

	// Token: 0x0601DFDF RID: 122847 RVA: 0x0087C698 File Offset: 0x0087A898
	public static void ClearTick()
	{
		ControllerRegister.TickControllers.Clear();
	}

	// Token: 0x0400ECF2 RID: 60658
	private static List<ControllerBase> Controllers = new List<ControllerBase>(507);

	// Token: 0x0400ECF3 RID: 60659
	private static List<ControllerBase> TickControllers = new List<ControllerBase>(88);
}

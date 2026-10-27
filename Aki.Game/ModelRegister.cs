using System;
using System.Collections.Generic;
using CSharpScript.Game.AI.StateMachine;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Capability;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelFlow;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.AlertArea;
using CSharpScript.Game.LevelGamePlay.BigStuffedDoll;
using CSharpScript.Game.LevelGamePlay.Cipher;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.LevelGamePlay.DigitalScreen;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine;
using CSharpScript.Game.LevelGamePlay.ElementalCasket;
using CSharpScript.Game.LevelGamePlay.FindSunSprite;
using CSharpScript.Game.LevelGamePlay.FishingQte;
using CSharpScript.Game.LevelGamePlay.GongduolaSummon;
using CSharpScript.Game.LevelGamePlay.GravityFlip;
using CSharpScript.Game.LevelGamePlay.Hourglass;
using CSharpScript.Game.LevelGamePlay.ItemInspect;
using CSharpScript.Game.LevelGamePlay.LevelEffect;
using CSharpScript.Game.LevelGamePlay.LifePoint;
using CSharpScript.Game.LevelGamePlay.Parkour;
using CSharpScript.Game.LevelGamePlay.ProjectPuzzle;
using CSharpScript.Game.LevelGamePlay.ResetPlayer;
using CSharpScript.Game.LevelGamePlay.SeekTrace;
using CSharpScript.Game.LevelGamePlay.SignalDeviceControl;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using CSharpScript.Game.LevelGamePlay.SundialControl;
using CSharpScript.Game.LevelGamePlay.SunSpirit;
using CSharpScript.Game.LevelGamePlay.TimeTrackControl;
using CSharpScript.Game.LevelGamePlay.TuningStand;
using CSharpScript.Game.LevelGamePlay.TurntableControl;
using CSharpScript.Game.LevelGamePlay.WriteLetter;
using CSharpScript.Game.Module.Activity.ActivityContent.CommonH5;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Activity.ActivityContent.LineCross;
using CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour;
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;
using CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using CSharpScript.Game.Module.Activity.ActivityContent.PreWarm;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.ActorFxEmote;
using CSharpScript.Game.Module.AiInteraction.AiWeapon;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.BattleUiSet;
using CSharpScript.Game.Module.BossPiling;
using CSharpScript.Game.Module.CiacconaGal;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Module.Cook;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.EffectSave;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Giant;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemDeliver;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.JoinTeam;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.MailBind;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup;
using CSharpScript.Game.Module.Manufacture.Forging;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.MechanismTimeline;
using CSharpScript.Game.Module.MingSu;
using CSharpScript.Game.Module.MonsterGroup;
using CSharpScript.Game.Module.Movement.Model;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Module.MusicalInstrument;
using CSharpScript.Game.Module.NetworkDetection;
using CSharpScript.Game.Module.PermanentRogue;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.PhantomArena;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.QuestMultiLine;
using CSharpScript.Game.Module.QuickHack;
using CSharpScript.Game.Module.QuickTimeAction;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.ResManager.Model;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Module.Season;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.SlidingBlocks;
using CSharpScript.Game.Module.SubLevelLoading;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Module.TreasureHunt;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using CSharpScript.Game.Module.VehicleStream;
using CSharpScript.Game.Module.VillageInfr;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuYinArea;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Common.Model;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using CSharpScript.Game.NewWorld.SceneItem.StreamingTrigger;
using CSharpScript.Game.NewWorld.TriggerItems.Model;
using CSharpScript.Game.Render;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils.LevelRangeDebug;
using CSharpScript.Game.World.Model;
using CSharpScript.Module.InstanceDungeon;
using CSharpScript.Utils;

// Token: 0x02003561 RID: 13665
public class ModelRegister
{
	// Token: 0x0601DFD0 RID: 122832 RVA: 0x008709C0 File Offset: 0x0086EBC0
	public static bool CreateInstance()
	{
		ModelRegister.Models.Clear();
		if (!QuestNewModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::QuestNewModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(QuestNewModel.Instance);
		if (!AiModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AiModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AiModel.Instance);
		if (!QuestResourceModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::QuestResourceModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(QuestResourceModel.Instance);
		if (!DailyTaskModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DailyTaskModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DailyTaskModel.Instance);
		if (!QuestMultiLineModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(QuestMultiLineModel.Instance);
		if (!CommonQteModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CommonQteModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CommonQteModel.Instance);
		if (!BattleQteModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BattleQteModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BattleQteModel.Instance);
		if (!PowerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PowerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PowerModel.Instance);
		if (!SequenceModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.Sequence.SequenceModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SequenceModel.Instance);
		if (!QuestReviewModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::QuestReviewModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(QuestReviewModel.Instance);
		if (!PlotModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.PlotModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PlotModel.Instance);
		if (!PlayerInfoModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PlayerInfoModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PlayerInfoModel.Instance);
		if (!PlatformModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PlatformModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PlatformModel.Instance);
		if (!PilotThrowModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PilotThrowModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PilotThrowModel.Instance);
		if (!PhotographModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhotographModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PhotographModel.Instance);
		if (!PhotographQuickModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhotographQuickModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PhotographQuickModel.Instance);
		if (!PhonographModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhonographModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PhonographModel.Instance);
		if (!PhoneMsgModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhoneMsgModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PhoneMsgModel.Instance);
		if (!PhantomInteractModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhantomInteractModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PhantomInteractModel.Instance);
		if (!PlotAudioModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.PlotAudioModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PlotAudioModel.Instance);
		if (!QuestTreeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::QuestTreeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(QuestTreeModel.Instance);
		if (!QuickHackModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.QuickHack.QuickHackModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(QuickHackModel.Instance);
		if (!QtaModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.QuickTimeAction.QtaModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(QtaModel.Instance);
		if (!TrialRoleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TrialRoleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TrialRoleModel.Instance);
		if (!RoleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoleModel.Instance);
		if (!RoleFavorConditionModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleFavorConditionModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoleFavorConditionModel.Instance);
		if (!RoleDevModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleDevModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoleDevModel.Instance);
		if (!RoleDevelopModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RoleUi.RoleDevelop.RoleDevelopModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoleDevelopModel.Instance);
		if (!MainRoleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MainRoleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MainRoleModel.Instance);
		if (!RoleSelectModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleSelectModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoleSelectModel.Instance);
		if (!RoleLangCustomModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RoleLangCustomModel.RoleLangCustomModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoleLangCustomModel.Instance);
		if (!RoguelikeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoguelikeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoguelikeModel.Instance);
		if (!RogueBattleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RogueBattle.RogueBattleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RogueBattleModel.Instance);
		if (!RewardModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Reward.RewardModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RewardModel.Instance);
		if (!ResourceManagerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ResManager.Model.ResourceManagerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ResourceManagerModel.Instance);
		if (!ResDownLoadModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ResDownLoadModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ResDownLoadModel.Instance);
		if (!ReConnectModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ReConnectModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ReConnectModel.Instance);
		if (!RecommendQualityModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RecommendQualityModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RecommendQualityModel.Instance);
		if (!RechargeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RechargeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RechargeModel.Instance);
		if (!RecallQuestModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RecallQuest.Model.RecallQuestModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RecallQuestModel.Instance);
		if (!RandomPlotModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RandomPlotModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RandomPlotModel.Instance);
		if (!RacingBetsModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RacingBets.RacingBetsModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RacingBetsModel.Instance);
		if (!VisionRecommendModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VisionRecommendModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(VisionRecommendModel.Instance);
		if (!RouletteModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RouletteModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RouletteModel.Instance);
		if (!VisionEquipGroupModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VisionEquipGroupModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(VisionEquipGroupModel.Instance);
		if (!PhantomArenaModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.PhantomArena.PhantomArenaModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PhantomArenaModel.Instance);
		if (!MonsterGroupPatrolModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MonsterGroup.MonsterGroupPatrolModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MonsterGroupPatrolModel.Instance);
		if (!MonsterGroupEcologyModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MonsterGroup.MonsterGroupEcologyModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MonsterGroupEcologyModel.Instance);
		if (!PreDownloadModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PreDownloadModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PreDownloadModel.Instance);
		if (!MingSuModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MingSu.MingSuModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MingSuModel.Instance);
		if (!MenuModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MenuModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MenuModel.Instance);
		if (!MechanismTimelineModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MechanismTimeline.MechanismTimelineModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MechanismTimelineModel.Instance);
		if (!MarqueeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MarqueeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MarqueeModel.Instance);
		if (!MapModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Map.MapModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MapModel.Instance);
		if (!MoraleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoraleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MoraleModel.Instance);
		if (!MapRogueModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MapRogue.MapRogueModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MapRogueModel.Instance);
		if (!ForgingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Manufacture.Forging.ForgingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ForgingModel.Instance);
		if (!ComposePopupModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup.ComposePopupModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ComposePopupModel.Instance);
		if (!ComposeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Manufacture.Compose.ComposeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ComposeModel.Instance);
		if (!MailModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MailModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MailModel.Instance);
		if (!MailBindModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MailBind.MailBindModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MailBindModel.Instance);
		if (!LordGymModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LordGymModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LordGymModel.Instance);
		if (!LogReportModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LogReportModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LogReportModel.Instance);
		if (!LoginServerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LoginServerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LoginServerModel.Instance);
		if (!MapExploreToolModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MapExploreToolModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MapExploreToolModel.Instance);
		if (!MotionModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotionModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MotionModel.Instance);
		if (!MotorcycleDevelopModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorcycleDevelopModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MotorcycleDevelopModel.Instance);
		if (!MotorcycleDiyModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorcycleDiyModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MotorcycleDiyModel.Instance);
		if (!PhantomArenaBattleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.PhantomArena.Battle.Model.PhantomArenaBattleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PhantomArenaBattleModel.Instance);
		if (!PersonalModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Personal.PersonalModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PersonalModel.Instance);
		if (!ActivityPermanentRogueModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.PermanentRogue.ActivityPermanentRogueModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivityPermanentRogueModel.Instance);
		if (!WeekCardModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeekCardModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WeekCardModel.Instance);
		if (!PayShopModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PayShopModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PayShopModel.Instance);
		if (!PayGiftModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PayGiftModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PayGiftModel.Instance);
		if (!MonthCardModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MonthCardModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MonthCardModel.Instance);
		if (!BattlePassModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BattlePassModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BattlePassModel.Instance);
		if (!PayItemModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PayItemModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PayItemModel.Instance);
		if (!PanoramicModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PanoramicModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PanoramicModel.Instance);
		if (!PanelQteModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PanelQteModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PanelQteModel.Instance);
		if (!RoleOrnamentModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleOrnamentModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoleOrnamentModel.Instance);
		if (!OnlineModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::OnlineModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(OnlineModel.Instance);
		if (!NewFlagModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::NewFlagModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(NewFlagModel.Instance);
		if (!NetworkDetectionModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.NetworkDetection.NetworkDetectionModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(NetworkDetectionModel.Instance);
		if (!MusicalInstrumentModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MusicalInstrument.MusicalInstrumentModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MusicalInstrumentModel.Instance);
		if (!MovieModeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MovieMode.MovieModeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MovieModeModel.Instance);
		if (!AvoidanceModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Movement.Model.AvoidanceModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AvoidanceModel.Instance);
		if (!MotorcycleMusicPlayerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorcycleMusicPlayerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MotorcycleMusicPlayerModel.Instance);
		if (!PhantomBattleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhantomBattleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PhantomBattleModel.Instance);
		if (!SceneBattleInteractModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SceneBattleInteractModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SceneBattleInteractModel.Instance);
		if (!SceneTeamModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SceneTeamModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SceneTeamModel.Instance);
		if (!ScoreModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ScoreModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ScoreModel.Instance);
		if (!SceneItemBuffModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Model.SceneItemBuffModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SceneItemBuffModel.Instance);
		if (!SceneInteractionModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Model.SceneInteractionModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SceneInteractionModel.Instance);
		if (!RangeItemModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Model.RangeItemModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RangeItemModel.Instance);
		if (!PortalModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Model.PortalModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PortalModel.Instance);
		if (!ConnectGamePlayModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Model.ConnectGamePlayModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ConnectGamePlayModel.Instance);
		if (!GraphModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.Common.Model.GraphModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GraphModel.Instance);
		if (!ClientTagModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.Common.Model.ClientTagModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ClientTagModel.Instance);
		if (!NpcVehicleRiderModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::NpcVehicleRiderModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(NpcVehicleRiderModel.Instance);
		if (!SceneItemConnectorModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Model.SceneItemConnectorModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SceneItemConnectorModel.Instance);
		if (!NpcConfigModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::NpcConfigModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(NpcConfigModel.Instance);
		if (!CharacterExploreModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.Character.Common.Component.Explore.CharacterExploreModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CharacterExploreModel.Instance);
		if (!ManipulaterModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.Character.Common.Component.ManipulaterModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ManipulaterModel.Instance);
		if (!ManipulateInteractModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.Character.Common.Component.ManipulateInteractModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ManipulateInteractModel.Instance);
		if (!BuffModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BuffModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BuffModel.Instance);
		if (!CharacterModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CharacterModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CharacterModel.Instance);
		if (!BulletModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BulletModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BulletModel.Instance);
		if (!WuYinAreaModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WuYinArea.WuYinAreaModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WuYinAreaModel.Instance);
		if (!WuWaGoModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WuwaGo.Model.WuWaGoModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WuWaGoModel.Instance);
		if (!PerformModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PerformModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PerformModel.Instance);
		if (!ShootTargetModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Model.ShootTargetModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ShootTargetModel.Instance);
		if (!VisionCaptureModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Model.VisionCaptureModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(VisionCaptureModel.Instance);
		if (!SceneItemStreamingTriggerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.StreamingTrigger.SceneItemStreamingTriggerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SceneItemStreamingTriggerModel.Instance);
		if (!TraceElementModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TraceElementModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TraceElementModel.Instance);
		if (!SubLevelModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Model.SubLevelModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SubLevelModel.Instance);
		if (!SceneOpacityModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SceneOpacityModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SceneOpacityModel.Instance);
		if (!PreloadModelNew.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PreloadModelNew 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PreloadModelNew.Instance);
		if (!GameModeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GameModeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GameModeModel.Instance);
		if (!DamageModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Model.DamageModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DamageModel.Instance);
		if (!CreatureModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CreatureModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CreatureModel.Instance);
		if (!BlackboardModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BlackboardModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BlackboardModel.Instance);
		if (!AttachToActorModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AttachToActorModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AttachToActorModel.Instance);
		if (!AoiModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AoiModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AoiModel.Instance);
		if (!ExpressionTreeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Utils.ExpressionTreeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ExpressionTreeModel.Instance);
		if (!LevelRangeDebugDrawModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Utils.LevelRangeDebug.LevelRangeDebugDrawModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelRangeDebugDrawModel.Instance);
		if (!InputDistributeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Ui.InputDistributeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InputDistributeModel.Instance);
		if (!ServerStorageModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.ServerStorage.ServerStorageModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ServerStorageModel.Instance);
		if (!RenderModuleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Render.RenderModuleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RenderModuleModel.Instance);
		if (!ScreenEffectModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Render.Effect.ScreenEffectSystem.ScreenEffectModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ScreenEffectModel.Instance);
		if (!RedDotModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RedDotModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RedDotModel.Instance);
		if (!VehicleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VehicleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(VehicleModel.Instance);
		if (!TriggerVolumeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.TriggerItems.Model.TriggerVolumeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TriggerVolumeModel.Instance);
		if (!WorldMapModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WorldMap.WorldMapModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WorldMapModel.Instance);
		if (!RegionalTerminalModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WorldMap.RegionalTerminal.RegionalTerminalModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RegionalTerminalModel.Instance);
		if (!WorldLevelModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WorldLevelModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WorldLevelModel.Instance);
		if (!WeeklyRogueModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeeklyRogueModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WeeklyRogueModel.Instance);
		if (!SubLevelLoadingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SubLevelLoading.SubLevelLoadingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SubLevelLoadingModel.Instance);
		if (!SpecialTransitionModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SpecialTransitionModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SpecialTransitionModel.Instance);
		if (!SoundAreaPlayTipsModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SoundAreaPlayTipsModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SoundAreaPlayTipsModel.Instance);
		if (!SlidingBlocksModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SlidingBlocks.SlidingBlocksModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SlidingBlocksModel.Instance);
		if (!SkipInterfaceModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SkipInterface.SkipInterfaceModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SkipInterfaceModel.Instance);
		if (!WeaponSkinModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeaponSkinModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WeaponSkinModel.Instance);
		if (!FlySkinModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FlySkinModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FlySkinModel.Instance);
		if (!CalabashSkinModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CalabashSkinModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CalabashSkinModel.Instance);
		if (!RoleSkinModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleSkinModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoleSkinModel.Instance);
		if (!SkillButtonUiModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SkillButtonUi.SkillButtonUiModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SkillButtonUiModel.Instance);
		if (!SignalDecodeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SignalDecodeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SignalDecodeModel.Instance);
		if (!ShowerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ShowerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ShowerModel.Instance);
		if (!MoonTogetherModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonTogetherModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MoonTogetherModel.Instance);
		if (!ShopModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ShopModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ShopModel.Instance);
		if (!ShipTogetherModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ShipTogetherModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ShipTogetherModel.Instance);
		if (!ShipTowerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ShipTowerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ShipTowerModel.Instance);
		if (!SheriffModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Sheriff.SheriffModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SheriffModel.Instance);
		if (!SeasonModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Season.SeasonModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SeasonModel.Instance);
		if (!SeamlessTravelModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SeamlessTravel.SeamlessTravelModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SeamlessTravelModel.Instance);
		if (!SubPackageDownLoadModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SubPackageDownLoadModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SubPackageDownLoadModel.Instance);
		if (!LoginModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LoginModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LoginModel.Instance);
		if (!SundryModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SundryModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SundryModel.Instance);
		if (!TeleportModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Teleport.TeleportModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TeleportModel.Instance);
		if (!WeeklyChallengeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeeklyChallengeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WeeklyChallengeModel.Instance);
		if (!WeatherModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Weather.WeatherModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WeatherModel.Instance);
		if (!WeaponModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeaponModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WeaponModel.Instance);
		if (!WaitEntityTaskModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WaitEntityTaskModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WaitEntityTaskModel.Instance);
		if (!VillageInfrModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.VillageInfr.VillageInfrModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(VillageInfrModel.Instance);
		if (!VideoBpModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VideoBpModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(VideoBpModel.Instance);
		if (!VehicleStreamModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.VehicleStream.VehicleStreamModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(VehicleStreamModel.Instance);
		if (!UiNavigationModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::UiNavigationModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(UiNavigationModel.Instance);
		if (!HomeBtnModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.UiComponent.UiHomeButton.HomeBtnModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(HomeBtnModel.Instance);
		if (!TutorialModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TutorialModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TutorialModel.Instance);
		if (!TreasureHuntModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.TreasureHunt.TreasureHuntModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TreasureHuntModel.Instance);
		if (!TrapDefenseModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.TrapDefense.TrapDefenseModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TrapDefenseModel.Instance);
		if (!TrainingDegreeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.TrainingDegree.TrainingDegreeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TrainingDegreeModel.Instance);
		if (!TrackModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TrackModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TrackModel.Instance);
		if (!TowerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TowerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TowerModel.Instance);
		if (!TowerDetailModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TowerDetailModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TowerDetailModel.Instance);
		if (!TowerDefenseEventModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.TowerDefenseEvent.Model.TowerDefenseEventModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TowerDefenseEventModel.Instance);
		if (!TowerDefenseModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TowerDefenseModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TowerDefenseModel.Instance);
		if (!TimeOfDayModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TimeOfDayModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TimeOfDayModel.Instance);
		if (!SurvivorsRogueModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SurvivorsRogueModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SurvivorsRogueModel.Instance);
		if (!LoadingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LoadingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LoadingModel.Instance);
		if (!LevelUpModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelUpModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelUpModel.Instance);
		if (!LevelPlayModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelPlayModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelPlayModel.Instance);
		if (!LineCrossModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.LineCross.LineCrossModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LineCrossModel.Instance);
		if (!LifePointDrawModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LifePointDrawModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LifePointDrawModel.Instance);
		if (!InviteNewbieModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InviteNewbieModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InviteNewbieModel.Instance);
		if (!ActivityFunPlayModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityFunPlayModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivityFunPlayModel.Instance);
		if (!FishingQuestModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Fishing.FishingQuestModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FishingQuestModel.Instance);
		if (!FishingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Fishing.FishingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FishingModel.Instance);
		if (!DockyardModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Fishing.DockyardModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DockyardModel.Instance);
		if (!FightPhotoModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FightPhotoModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FightPhotoModel.Instance);
		if (!MoonChasingBuildingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonChasingBuildingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MoonChasingBuildingModel.Instance);
		if (!DropCatchModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.DropCatchModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DropCatchModel.Instance);
		if (!ActivityDirectTrainModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.ActivityDirectTrainModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivityDirectTrainModel.Instance);
		if (!DangoBrawlModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.DangoBrawlModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DangoBrawlModel.Instance);
		if (!CommonH5Model.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.CommonH5.CommonH5Model 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CommonH5Model.Instance);
		if (!ChessModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ChessModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ChessModel.Instance);
		if (!BossRushModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BossRushModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BossRushModel.Instance);
		if (!BabelTowerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BabelTowerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BabelTowerModel.Instance);
		if (!AvignonModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AvignonModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AvignonModel.Instance);
		if (!AdvanceNoticeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AdvanceNoticeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AdvanceNoticeModel.Instance);
		if (!DirectTrainModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity.DirectTrainModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DirectTrainModel.Instance);
		if (!MoonChasingBusinessModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonChasingBusinessModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MoonChasingBusinessModel.Instance);
		if (!MoonChasingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonChasingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MoonChasingModel.Instance);
		if (!MoonChasingRewardModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonChasingRewardModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MoonChasingRewardModel.Instance);
		if (!WheelTowerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WheelTowerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WheelTowerModel.Instance);
		if (!VersionPreheatModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VersionPreheatModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(VersionPreheatModel.Instance);
		if (!SpringManorModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.SpringManor.SpringManorModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SpringManorModel.Instance);
		if (!Spring25Model.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::Spring25Model 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(Spring25Model.Instance);
		if (!SolarSpeedModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed.SolarSpeedModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SolarSpeedModel.Instance);
		if (!ActivitySevenDaySignModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivitySevenDaySignModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivitySevenDaySignModel.Instance);
		if (!ActivityScratchTicketModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityScratchTicketModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivityScratchTicketModel.Instance);
		if (!ActivityRunModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRunModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivityRunModel.Instance);
		if (!RoverlikeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Roverlike.RoverlikeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RoverlikeModel.Instance);
		if (!RhythmShipModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.RhythmShipModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RhythmShipModel.Instance);
		if (!ActivityRegressModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRegressModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivityRegressModel.Instance);
		if (!ActivityPreWarmModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.PreWarm.ActivityPreWarmModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivityPreWarmModel.Instance);
		if (!PinballModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Pinball.PinballModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(PinballModel.Instance);
		if (!NewbieMainModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain.NewbieMainModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(NewbieMainModel.Instance);
		if (!MultiMotorModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor.MultiMotorModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MultiMotorModel.Instance);
		if (!MowingTowerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MowingTowerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MowingTowerModel.Instance);
		if (!MowingRiskModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MowingRiskModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MowingRiskModel.Instance);
		if (!MotorParkourMapModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour.MotorParkourMapModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MotorParkourMapModel.Instance);
		if (!MoonChasingTaskModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonChasingTaskModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MoonChasingTaskModel.Instance);
		if (!ActivityRecommendModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRecommendModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivityRecommendModel.Instance);
		if (!RhythmGameModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RhythmGameModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(RhythmGameModel.Instance);
		if (!GuessJokerGamePlayModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GuessJokerGamePlayModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GuessJokerGamePlayModel.Instance);
		if (!FurnitureModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FurnitureModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FurnitureModel.Instance);
		if (!GravityFlipModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.GravityFlip.GravityFlipModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GravityFlipModel.Instance);
		if (!GongduolaSummonModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.GongduolaSummon.GongduolaSummonModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GongduolaSummonModel.Instance);
		if (!FishingQteModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.FishingQte.FishingQteModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FishingQteModel.Instance);
		if (!FindSunSpiritModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.FindSunSprite.FindSunSpiritModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FindSunSpiritModel.Instance);
		if (!ElementalCasketModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalCasketModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ElementalCasketModel.Instance);
		if (!DollGrabModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DollGrabModel.Instance);
		if (!DigitalScreenModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.DigitalScreen.DigitalScreenModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DigitalScreenModel.Instance);
		if (!LevelPrefabConfigModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.Common.LevelPrefabConfigModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelPrefabConfigModel.Instance);
		if (!GameSplineModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.Common.GameSplineModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GameSplineModel.Instance);
		if (!CipherModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.Cipher.CipherModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CipherModel.Instance);
		if (!BigStuffedDollModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.BigStuffedDoll.BigStuffedDollModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BigStuffedDollModel.Instance);
		if (!AlertAreaModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.AlertArea.AlertAreaModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AlertAreaModel.Instance);
		if (!LevelFlowModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelFlow.LevelFlowModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelFlowModel.Instance);
		if (!KuroSdkModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::KuroSdkModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(KuroSdkModel.Instance);
		if (!InputModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Input.InputModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InputModel.Instance);
		if (!CapabilityModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Capability.CapabilityModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CapabilityModel.Instance);
		if (!CameraModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Camera.CameraModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CameraModel.Instance);
		if (!AudioModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AudioModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AudioModel.Instance);
		if (!AiStateMachineModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.AI.StateMachine.AiStateMachineModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AiStateMachineModel.Instance);
		if (!QteHourglassModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.Hourglass.QteHourglassModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(QteHourglassModel.Instance);
		if (!ActivityModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActivityModel.Instance);
		if (!ItemInspectModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ItemInspect.ItemInspectModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ItemInspectModel.Instance);
		if (!LevelGamePlayModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.LevelGamePlayModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelGamePlayModel.Instance);
		if (!DrinksModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DrinksModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DrinksModel.Instance);
		if (!AchievementModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AchievementModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AchievementModel.Instance);
		if (!FormationDataModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FormationDataModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FormationDataModel.Instance);
		if (!FormationAttributeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FormationAttributeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FormationAttributeModel.Instance);
		if (!WriteLetterModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.WriteLetter.WriteLetterModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WriteLetterModel.Instance);
		if (!TurntableControlModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.TurntableControl.TurntableControlModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TurntableControlModel.Instance);
		if (!TuningStandModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.TuningStand.TuningStandModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TuningStandModel.Instance);
		if (!TimeTrackControlModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.TimeTrackControl.TimeTrackControlModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(TimeTrackControlModel.Instance);
		if (!SunSpiritModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SunSpiritModel.Instance);
		if (!SundialControlModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SundialControl.SundialControlModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SundialControlModel.Instance);
		if (!StaticSceneModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.StaticScene.StaticSceneModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(StaticSceneModel.Instance);
		if (!SplineConstrainedDragModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.SplineConstrainedDragModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SplineConstrainedDragModel.Instance);
		if (!SignalDeviceModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SignalDeviceControl.SignalDeviceModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SignalDeviceModel.Instance);
		if (!SeekTraceModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.SeekTrace.SeekTraceModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SeekTraceModel.Instance);
		if (!ResetPlayerModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ResetPlayer.ResetPlayerModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ResetPlayerModel.Instance);
		if (!ProjectorModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.ProjectPuzzle.ProjectorModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ProjectorModel.Instance);
		if (!ParkourModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.Parkour.ParkourModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ParkourModel.Instance);
		if (!LifePointModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.LifePoint.LifePointModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LifePointModel.Instance);
		if (!LevelGeneralModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.LevelGeneralModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelGeneralModel.Instance);
		if (!LevelEffectModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.LevelEffect.LevelEffectModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelEffectModel.Instance);
		if (!WorldDebugModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Model.WorldDebugModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WorldDebugModel.Instance);
		if (!ActorFxEmoteModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ActorFxEmote.ActorFxEmoteModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ActorFxEmoteModel.Instance);
		if (!AdviceModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AdviceModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AdviceModel.Instance);
		if (!HoldingHandsModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HoldingHandsModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(HoldingHandsModel.Instance);
		if (!HandBookModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HandBookModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(HandBookModel.Instance);
		if (!GuideModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GuideModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GuideModel.Instance);
		if (!GreatSwordChallengeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GreatSwordChallengeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GreatSwordChallengeModel.Instance);
		if (!GiantModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Giant.GiantModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GiantModel.Instance);
		if (!GenericPromptModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.GenericPrompt.GenericPromptModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GenericPromptModel.Instance);
		if (!GeneralLogicTreeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GeneralLogicTreeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GeneralLogicTreeModel.Instance);
		if (!GamePingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GamePingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GamePingModel.Instance);
		if (!HonamiStoryModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HonamiStoryModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(HonamiStoryModel.Instance);
		if (!GachaModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GachaModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GachaModel.Instance);
		if (!LevelFuncFlagModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelFuncFlagModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelFuncFlagModel.Instance);
		if (!FunctionModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FunctionModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FunctionModel.Instance);
		if (!ExploreSkillFlagModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ExploreSkillFlagModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ExploreSkillFlagModel.Instance);
		if (!FriendModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FriendModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FriendModel.Instance);
		if (!FragmentMemoryModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FragmentMemoryModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FragmentMemoryModel.Instance);
		if (!FormationModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FormationModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FormationModel.Instance);
		if (!BattleTeamModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BattleTeamModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BattleTeamModel.Instance);
		if (!FloroRanchModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FloroRanchModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FloroRanchModel.Instance);
		if (!GachaAccumulateModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GachaAccumulateModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GachaAccumulateModel.Instance);
		if (!IdlePerformModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::IdlePerformModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(IdlePerformModel.Instance);
		if (!InfluenceModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InfluenceModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InfluenceModel.Instance);
		if (!InfluenceReputationModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InfluenceReputationModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InfluenceReputationModel.Instance);
		if (!LevelPlayReportModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelPlayReportModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelPlayReportModel.Instance);
		if (!LevelLoadingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.LevelLoading.LevelLoadingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(LevelLoadingModel.Instance);
		if (!KurotatoModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Kurotato.KurotatoModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(KurotatoModel.Instance);
		if (!JoinTeamModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.JoinTeam.JoinTeamModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(JoinTeamModel.Instance);
		if (!SpecialItemModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SpecialItemModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SpecialItemModel.Instance);
		if (!ItemModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Item.ItemModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ItemModel.Instance);
		if (!ItemRewardModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ItemReward.ItemRewardModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ItemRewardModel.Instance);
		if (!ItemHintModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ItemHintModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ItemHintModel.Instance);
		if (!ItemExchangeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ItemExchangeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ItemExchangeModel.Instance);
		if (!ItemDeliverModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ItemDeliver.ItemDeliverModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ItemDeliverModel.Instance);
		if (!InventoryModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InventoryModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InventoryModel.Instance);
		if (!InteractionModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Interaction.InteractionModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InteractionModel.Instance);
		if (!InstanceGameplayModeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InstanceGameplayModeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InstanceGameplayModeModel.Instance);
		if (!InstanceDungeonModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InstanceDungeonModel.Instance);
		if (!InstanceDungeonGuideModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonGuideModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InstanceDungeonGuideModel.Instance);
		if (!InstanceDungeonEntranceModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Module.InstanceDungeon.InstanceDungeonEntranceModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InstanceDungeonEntranceModel.Instance);
		if (!ExchangeRewardModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.InstanceDungeon.ExchangeReward.ExchangeRewardModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ExchangeRewardModel.Instance);
		if (!InfrastructureModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Infrastructure.InfrastructureModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InfrastructureModel.Instance);
		if (!InfoDisplayModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InfoDisplayModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(InfoDisplayModel.Instance);
		if (!FloroRanchGamePlayModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FloroRanchGamePlayModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FloroRanchGamePlayModel.Instance);
		if (!FlagChallengeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.FlagChallenge.FlagChallengeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FlagChallengeModel.Instance);
		if (!FeedbackRewardModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FeedbackRewardModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FeedbackRewardModel.Instance);
		if (!ExploreProgressModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ExploreProgressModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ExploreProgressModel.Instance);
		if (!BossPilingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BossPiling.BossPilingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BossPilingModel.Instance);
		if (!BirthdayModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BirthdayModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BirthdayModel.Instance);
		if (!SkillCdModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.SkillCdModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SkillCdModel.Instance);
		if (!BattleScoreModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.BattleScoreModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BattleScoreModel.Instance);
		if (!MoraleBattleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.MoraleBattleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MoraleBattleModel.Instance);
		if (!BattleLinkModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.BattleLinkModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BattleLinkModel.Instance);
		if (!BattleInputModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BattleInputModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BattleInputModel.Instance);
		if (!FlagChallengeBattleModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.FlagChallengeBattleModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FlagChallengeBattleModel.Instance);
		if (!CooperationModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CooperationModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CooperationModel.Instance);
		if (!AlertMarkModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BattleUi.Views.AlertMarkModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AlertMarkModel.Instance);
		if (!BattleUiModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BattleUi.BattleUiModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BattleUiModel.Instance);
		if (!BattleUiSetModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BattleUiSet.BattleUiSetModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BattleUiSetModel.Instance);
		if (!AutoRunModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AutoRunModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AutoRunModel.Instance);
		if (!AutoPilotModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.AutoPilot.AutoPilotModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AutoPilotModel.Instance);
		if (!GameAudioModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Audio.GameAudioModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(GameAudioModel.Instance);
		if (!AttributeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AttributeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AttributeModel.Instance);
		if (!AreaModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Area.AreaModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AreaModel.Instance);
		if (!AntiCheatModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AntiCheatModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AntiCheatModel.Instance);
		if (!AiWeaponModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.AiInteraction.AiWeapon.AiWeaponModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AiWeaponModel.Instance);
		if (!BuffItemModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BuffItemModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BuffItemModel.Instance);
		if (!AdventureGuideModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AdventureGuideModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(AdventureGuideModel.Instance);
		if (!BuildingGridModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BuildingGridModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(BuildingGridModel.Instance);
		if (!ChannelModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ChannelModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ChannelModel.Instance);
		if (!ExploreLevelModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ExploreLevelModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ExploreLevelModel.Instance);
		if (!EffectSaveModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.EffectSave.EffectSaveModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(EffectSaveModel.Instance);
		if (!DeadReviveModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.DeadRevive.DeadReviveModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DeadReviveModel.Instance);
		if (!DeadEyeModeModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DeadEyeModeModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DeadEyeModeModel.Instance);
		if (!DangoGlobalModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DangoGlobalModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DangoGlobalModel.Instance);
		if (!DangoAbyssModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DangoAbyssModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DangoAbyssModel.Instance);
		if (!DailyActivityModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DailyActivityModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(DailyActivityModel.Instance);
		if (!CookModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Cook.CookModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CookModel.Instance);
		if (!ControlScreenModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ControlScreenModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ControlScreenModel.Instance);
		if (!ConfirmBoxModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ConfirmBoxModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ConfirmBoxModel.Instance);
		if (!SmallItemGridModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SmallItemGridModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SmallItemGridModel.Instance);
		if (!MediumItemGridModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MediumItemGridModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(MediumItemGridModel.Instance);
		if (!ItemTipsModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ItemTipsModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ItemTipsModel.Instance);
		if (!SortModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SortModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(SortModel.Instance);
		if (!FilterModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FilterModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(FilterModel.Instance);
		if (!ComboTeachingModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ComboTeachingModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ComboTeachingModel.Instance);
		if (!CombatMessageModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.CombatMessage.CombatMessageModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CombatMessageModel.Instance);
		if (!CiacconaGalModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.CiacconaGal.CiacconaGalModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CiacconaGalModel.Instance);
		if (!ChatModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ChatModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(ChatModel.Instance);
		if (!CalabashModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CalabashModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(CalabashModel.Instance);
		if (!WorldModel.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WorldModel 创建模块单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ModelRegister.Models.Add(WorldModel.Instance);
		return true;
	}

	// Token: 0x0601DFD1 RID: 122833 RVA: 0x00875360 File Offset: 0x00873560
	public static bool Init()
	{
		for (int i = 0; i < ModelRegister.Models.Count; i++)
		{
			ModelBase modelBase = ModelRegister.Models[i];
			if (!modelBase.Init())
			{
				Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, modelBase.GetType().FullName + " 模块初始化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601DFD2 RID: 122834 RVA: 0x008753C8 File Offset: 0x008735C8
	public static bool Clear()
	{
		bool result = true;
		for (int i = 0; i < ModelRegister.Models.Count; i++)
		{
			ModelBase modelBase = ModelRegister.Models[i];
			try
			{
				if (!modelBase.Clear())
				{
					Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, modelBase.GetType().FullName + " 模块清理失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = false;
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = modelBase.GetType().FullName + " 模块清理失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ex:", ex.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0601DFD3 RID: 122835 RVA: 0x0087548C File Offset: 0x0087368C
	public static bool LeaveLevel()
	{
		bool result = true;
		for (int i = 0; i < ModelRegister.Models.Count; i++)
		{
			ModelBase modelBase = ModelRegister.Models[i];
			try
			{
				if (!modelBase.LeaveLevel())
				{
					Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, modelBase.GetType().FullName + " 模块系统退出关卡失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = false;
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = modelBase.GetType().FullName + " 模块系统退出关卡失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ex:", ex.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0601DFD4 RID: 122836 RVA: 0x00875550 File Offset: 0x00873750
	public static bool ChangeMode()
	{
		bool result = true;
		for (int i = 0; i < ModelRegister.Models.Count; i++)
		{
			ModelBase modelBase = ModelRegister.Models[i];
			try
			{
				if (!modelBase.ChangeMode())
				{
					Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, modelBase.GetType().FullName + " 模块系统退出模式失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = false;
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = modelBase.GetType().FullName + " 模块系统退出模式失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ex:", ex.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0400ECF1 RID: 60657
	private static List<ModelBase> Models = new List<ModelBase>(362);
}

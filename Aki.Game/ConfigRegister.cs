using System;
using System.Collections.Generic;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.LevelGamePlay.LevelConditions.Config;
using CSharpScript.Game.LevelGamePlay.TuningStand;
using CSharpScript.Game.Module.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.Anniversary;
using CSharpScript.Game.Module.Activity.ActivityContent.Coop;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch;
using CSharpScript.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
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
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;
using CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain;
using CSharpScript.Game.Module.Activity.ActivityContent.PreWarm;
using CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Module.Activity.ActivityContent.RoadBook;
using CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.Activity.ActivityContent.Tetris;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUiSet;
using CSharpScript.Game.Module.BossPiling;
using CSharpScript.Game.Module.Comic;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Cook;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.DreamLink;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Item.Data;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.JoinTeam;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.Manufacture.Forging;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.MingSu;
using CSharpScript.Game.Module.Morale;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.PhantomArena;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.QuestMultiLine;
using CSharpScript.Game.Module.RecallQuest;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.UiCameraAnimation;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Module.VillageInfr;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal;
using CSharpScript.Game.NewWorld.SceneItem.Manipulate;
using CSharpScript.Game.Ui;
using CSharpScript.Game.World.Define;

// Token: 0x02003560 RID: 13664
public class ConfigRegister
{
	// Token: 0x0601DFCB RID: 122827 RVA: 0x0086D120 File Offset: 0x0086B320
	public static bool CreateInstance()
	{
		ConfigRegister.Configs.Clear();
		if (!AiConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AiConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AiConfig.Instance);
		if (!LordGymConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LordGymConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LordGymConfig.Instance);
		if (!MailConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MailConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MailConfig.Instance);
		if (!ComposeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Manufacture.Compose.ComposeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ComposeConfig.Instance);
		if (!ForgingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Manufacture.Forging.ForgingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ForgingConfig.Instance);
		if (!MapRogueConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MapRogue.MapRogueConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MapRogueConfig.Instance);
		if (!MapConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Map.MapConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MapConfig.Instance);
		if (!MenuBaseConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MenuBaseConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MenuBaseConfig.Instance);
		if (!CollectItemConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.MingSu.CollectItemConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CollectItemConfig.Instance);
		if (!MonsterInfoConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MonsterInfoConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MonsterInfoConfig.Instance);
		if (!MoraleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Morale.MoraleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MoraleConfig.Instance);
		if (!MotionConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotionConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MotionConfig.Instance);
		if (!MotorConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MotorConfig.Instance);
		if (!MotorDiyConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorDiyConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MotorDiyConfig.Instance);
		if (!MotorcycleMusicPlayerConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorcycleMusicPlayerConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MotorcycleMusicPlayerConfig.Instance);
		if (!LogReportConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LogReportConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LogReportConfig.Instance);
		if (!NpcIconConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::NpcIconConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(NpcIconConfig.Instance);
		if (!BattlePassConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BattlePassConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BattlePassConfig.Instance);
		if (!MonthCardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MonthCardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MonthCardConfig.Instance);
		if (!PayShopConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PayShopConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PayShopConfig.Instance);
		if (!GiftPackageConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GiftPackageConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GiftPackageConfig.Instance);
		if (!WeekCardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeekCardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WeekCardConfig.Instance);
		if (!PersonalConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Personal.PersonalConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PersonalConfig.Instance);
		if (!PhantomArenaConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.PhantomArena.PhantomArenaConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PhantomArenaConfig.Instance);
		if (!PhantomBattleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhantomBattleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PhantomBattleConfig.Instance);
		if (!VisionRecommendConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VisionRecommendConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(VisionRecommendConfig.Instance);
		if (!PhoneMsgConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.PhoneMessage.PhoneMsgConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PhoneMsgConfig.Instance);
		if (!PhonographConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhonographConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PhonographConfig.Instance);
		if (!PhotographConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PhotographConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PhotographConfig.Instance);
		if (!PlatformConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PlatformConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PlatformConfig.Instance);
		if (!PlayerInfoConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PlayerInfoConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PlayerInfoConfig.Instance);
		if (!PayItemConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PayItemConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PayItemConfig.Instance);
		if (!FlowConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.Flow.FlowConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FlowConfig.Instance);
		if (!LoginConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LoginConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LoginConfig.Instance);
		if (!LevelUpConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelUpConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LevelUpConfig.Instance);
		if (!FragmentMemoryConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FragmentMemoryConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FragmentMemoryConfig.Instance);
		if (!FriendConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FriendConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FriendConfig.Instance);
		if (!FunctionConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FunctionConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FunctionConfig.Instance);
		if (!GachaAccumulateConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GachaAccumulateConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GachaAccumulateConfig.Instance);
		if (!GachaConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GachaConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GachaConfig.Instance);
		if (!GamepadConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GamepadConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GamepadConfig.Instance);
		if (!GenericPromptConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.GenericPrompt.GenericPromptConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GenericPromptConfig.Instance);
		if (!GuideConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GuideConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GuideConfig.Instance);
		if (!HandBookConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HandBookConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(HandBookConfig.Instance);
		if (!HelpConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HelpConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(HelpConfig.Instance);
		if (!HonamiStoryConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::HonamiStoryConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(HonamiStoryConfig.Instance);
		if (!InfluenceConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InfluenceConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(InfluenceConfig.Instance);
		if (!InfoDisplayModuleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InfoDisplayModuleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(InfoDisplayModuleConfig.Instance);
		if (!InfrastructureConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Infrastructure.InfrastructureConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(InfrastructureConfig.Instance);
		if (!LoadingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LoadingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LoadingConfig.Instance);
		if (!InstanceDungeonConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::InstanceDungeonConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(InstanceDungeonConfig.Instance);
		if (!InteractionConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Interaction.InteractionConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(InteractionConfig.Instance);
		if (!InventoryConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Inventory.InventoryConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(InventoryConfig.Instance);
		if (!ItemExchangeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ItemExchangeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ItemExchangeConfig.Instance);
		if (!ItemRewardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.ItemReward.ItemRewardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ItemRewardConfig.Instance);
		if (!GetWayConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GetWayConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GetWayConfig.Instance);
		if (!ItemAccessedFromGiftPathConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Item.Data.ItemAccessedFromGiftPathConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ItemAccessedFromGiftPathConfig.Instance);
		if (!CSharpScript.Game.Module.Item.ItemConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Item.ItemConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CSharpScript.Game.Module.Item.ItemConfig.Instance);
		if (!SpecialItemConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SpecialItemConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SpecialItemConfig.Instance);
		if (!JoinTeamConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.JoinTeam.JoinTeamConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(JoinTeamConfig.Instance);
		if (!KingShipConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::KingShipConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(KingShipConfig.Instance);
		if (!KurotatoConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Kurotato.KurotatoConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(KurotatoConfig.Instance);
		if (!LanguageConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LanguageConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LanguageConfig.Instance);
		if (!LevelPlayReportConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelPlayReportConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LevelPlayReportConfig.Instance);
		if (!LevelPlayConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LevelPlayConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LevelPlayConfig.Instance);
		if (!InstanceDungeonEntranceConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonEntranceConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(InstanceDungeonEntranceConfig.Instance);
		if (!FormationConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FormationConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FormationConfig.Instance);
		if (!MusicSubtitleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.MusicSubtitleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MusicSubtitleConfig.Instance);
		if (!PlotMontageConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.PlotMontageConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PlotMontageConfig.Instance);
		if (!UiCameraAnimationConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.UiCameraAnimation.UiCameraAnimationConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(UiCameraAnimationConfig.Instance);
		if (!UiNavigationConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.UiNavigation.UiNavigationConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(UiNavigationConfig.Instance);
		if (!VideoConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::VideoConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(VideoConfig.Instance);
		if (!VillageInfrConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.VillageInfr.VillageInfrConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(VillageInfrConfig.Instance);
		if (!WeaponConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeaponConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WeaponConfig.Instance);
		if (!WeatherModuleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Weather.WeatherModuleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WeatherModuleConfig.Instance);
		if (!WeeklyChallengeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeeklyChallengeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WeeklyChallengeConfig.Instance);
		if (!WeeklyRogueConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeeklyRogueConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WeeklyRogueConfig.Instance);
		if (!WorldLevelConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WorldLevelConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WorldLevelConfig.Instance);
		if (!RegionalTerminalConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WorldMap.RegionalTerminal.RegionalTerminalConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RegionalTerminalConfig.Instance);
		if (!WorldMapConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.WorldMap.WorldMapConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WorldMapConfig.Instance);
		if (!BulletConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BulletConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BulletConfig.Instance);
		if (!EntityAkComponentConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::EntityAkComponentConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(EntityAkComponentConfig.Instance);
		if (!EntityPhysicsAssetConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::EntityPhysicsAssetConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(EntityPhysicsAssetConfig.Instance);
		if (!TutorialConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TutorialConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TutorialConfig.Instance);
		if (!SwimConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SwimConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SwimConfig.Instance);
		if (!FaceExpressionConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FaceExpressionConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FaceExpressionConfig.Instance);
		if (!ManipulateConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.NewWorld.SceneItem.Manipulate.ManipulateConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ManipulateConfig.Instance);
		if (!WorldConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WorldConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WorldConfig.Instance);
		if (!RedDotConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RedDotConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RedDotConfig.Instance);
		if (!RenderModuleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RenderModuleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RenderModuleConfig.Instance);
		if (!UiCommonConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Ui.UiCommonConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(UiCommonConfig.Instance);
		if (!InputDistributeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Ui.InputDistributeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(InputDistributeConfig.Instance);
		if (!ImmersiveMouseConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Ui.ImmersiveMouseConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ImmersiveMouseConfig.Instance);
		if (!ViewHotKeyConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Ui.ViewHotKeyConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ViewHotKeyConfig.Instance);
		if (!AiBehaviorTreeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AiBehaviorTreeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AiBehaviorTreeConfig.Instance);
		if (!AnimalStandbyMontageConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.World.Define.AnimalStandbyMontageConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AnimalStandbyMontageConfig.Instance);
		if (!AnsPerformConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AnsPerformConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AnsPerformConfig.Instance);
		if (!BubbleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BubbleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BubbleConfig.Instance);
		if (!CommonBtConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CommonBtConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CommonBtConfig.Instance);
		if (!WeaponComponentConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WeaponComponentConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WeaponComponentConfig.Instance);
		if (!PlotCameraTemplateConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.PlotCameraTemplateConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PlotCameraTemplateConfig.Instance);
		if (!TrapDefenseConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TrapDefenseConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TrapDefenseConfig.Instance);
		if (!TowerClimbConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TowerClimbConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TowerClimbConfig.Instance);
		if (!PlotTemplate.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Plot.PlotTemplate 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PlotTemplate.Instance);
		if (!PowerConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PowerConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PowerConfig.Instance);
		if (!QuestMultiLineConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(QuestMultiLineConfig.Instance);
		if (!QuestNewConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::QuestNewConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(QuestNewConfig.Instance);
		if (!QuestTreeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::QuestTreeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(QuestTreeConfig.Instance);
		if (!RacingBetsConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RacingBetsConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RacingBetsConfig.Instance);
		if (!RecallQuestConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RecallQuest.RecallQuestConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RecallQuestConfig.Instance);
		if (!RewardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Reward.RewardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RewardConfig.Instance);
		if (!RogueBattleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RogueBattle.RogueBattleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RogueBattleConfig.Instance);
		if (!RoguelikeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoguelikeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RoguelikeConfig.Instance);
		if (!RoleDevConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleDevConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RoleDevConfig.Instance);
		if (!RoleFavorConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleFavorConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RoleFavorConfig.Instance);
		if (!RoleSkillConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleSkillConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RoleSkillConfig.Instance);
		if (!RoleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RoleUi.RoleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RoleConfig.Instance);
		if (!TowerDayConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TowerDayConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TowerDayConfig.Instance);
		if (!RoleResonanceConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleResonanceConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RoleResonanceConfig.Instance);
		if (!UiRoleCameraConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::UiRoleCameraConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(UiRoleCameraConfig.Instance);
		if (!RouletteConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RouletteConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RouletteConfig.Instance);
		if (!SheriffConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Sheriff.SheriffConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SheriffConfig.Instance);
		if (!ShipTowerConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ShipTowerConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ShipTowerConfig.Instance);
		if (!ShopConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ShopConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ShopConfig.Instance);
		if (!MoonTogetherConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonTogetherConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MoonTogetherConfig.Instance);
		if (!SignalDecodeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SignalDecodeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SignalDecodeConfig.Instance);
		if (!SkeletalObserverConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SkeletalObserverConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SkeletalObserverConfig.Instance);
		if (!SkillButtonConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SkillButtonUi.SkillButtonConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SkillButtonConfig.Instance);
		if (!SkinConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Skin.SkinConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SkinConfig.Instance);
		if (!SkipInterfaceConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.SkipInterface.SkipInterfaceConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SkipInterfaceConfig.Instance);
		if (!SubPackageConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SubPackageConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SubPackageConfig.Instance);
		if (!SurvivorsRogueConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SurvivorsRogueConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SurvivorsRogueConfig.Instance);
		if (!TimeOfDayConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TimeOfDayConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TimeOfDayConfig.Instance);
		if (!TrialRoleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.RoleUi.TrialRoleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TrialRoleConfig.Instance);
		if (!FloroRanchConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FloroRanchConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FloroRanchConfig.Instance);
		if (!FlagChallengeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.FlagChallenge.FlagChallengeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FlagChallengeConfig.Instance);
		if (!FeedbackRewardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FeedbackRewardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FeedbackRewardConfig.Instance);
		if (!ActivityDirectTrainConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.ActivityDirectTrainConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityDirectTrainConfig.Instance);
		if (!DropCatchConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.DropCatchConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(DropCatchConfig.Instance);
		if (!ActivityEncircleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Encircle.ActivityEncircleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityEncircleConfig.Instance);
		if (!FarmGoldConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FarmGoldConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FarmGoldConfig.Instance);
		if (!FishingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Fishing.FishingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FishingConfig.Instance);
		if (!ActivityFunPlayConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.FunPlay.ActivityFunPlayConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityFunPlayConfig.Instance);
		if (!GuQinActivityConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.GuQinActivityConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GuQinActivityConfig.Instance);
		if (!LifePointDrawConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::LifePointDrawConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LifePointDrawConfig.Instance);
		if (!LineCrossConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.LineCross.LineCrossConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LineCrossConfig.Instance);
		if (!LinkageRewardActivityConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward.LinkageRewardActivityConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LinkageRewardActivityConfig.Instance);
		if (!ActivityMapExploreConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityMapExploreConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityMapExploreConfig.Instance);
		if (!ActivityMapTravelConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityMapTravelConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityMapTravelConfig.Instance);
		if (!ActivityMatchThreeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity.ActivityMatchThreeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityMatchThreeConfig.Instance);
		if (!MatchThreeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.MatchThreeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MatchThreeConfig.Instance);
		if (!ActivityDangoMonopolyConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityDangoMonopolyConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityDangoMonopolyConfig.Instance);
		if (!ActivityMoonChasingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityMoonChasingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityMoonChasingConfig.Instance);
		if (!BusinessConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BusinessConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BusinessConfig.Instance);
		if (!MoonChasingHandbookConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonChasingHandbookConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MoonChasingHandbookConfig.Instance);
		if (!MoonChasingMemoryConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonChasingMemoryConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MoonChasingMemoryConfig.Instance);
		if (!MoonChasingRewardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MoonChasingRewardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MoonChasingRewardConfig.Instance);
		if (!TaskConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TaskConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TaskConfig.Instance);
		if (!MoonSignInConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn.MoonSignInConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MoonSignInConfig.Instance);
		if (!ActivityMotorDevelopConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop.ActivityMotorDevelopConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityMotorDevelopConfig.Instance);
		if (!ActivityMotorLinkageConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage.ActivityMotorLinkageConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityMotorLinkageConfig.Instance);
		if (!MotorDecalLinkConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink.MotorDecalLinkConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MotorDecalLinkConfig.Instance);
		if (!MotorFightConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotorFight.MotorFightConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MotorFightConfig.Instance);
		if (!MotorParkourConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour.MotorParkourConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MotorParkourConfig.Instance);
		if (!MowingTowerConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MowingTowerConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MowingTowerConfig.Instance);
		if (!MultiMotorConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor.MultiMotorConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MultiMotorConfig.Instance);
		if (!ActivityNewbieCourseV2Config.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityNewbieCourseV2Config 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityNewbieCourseV2Config.Instance);
		if (!BuildingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BuildingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BuildingConfig.Instance);
		if (!NewbieMainConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain.NewbieMainConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(NewbieMainConfig.Instance);
		if (!DangoBrawlConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.DangoBrawlConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(DangoBrawlConfig.Instance);
		if (!CyberPunkConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk.CyberPunkConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CyberPunkConfig.Instance);
		if (!ConditionConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ConditionConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ConditionConfig.Instance);
		if (!TextConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TextConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TextConfig.Instance);
		if (!GameSettingsConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GameSettingsConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GameSettingsConfig.Instance);
		if (!InputSettingsConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.InputSetting.InputSettingsConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(InputSettingsConfig.Instance);
		if (!CommonTouchUiEditConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.InputSetting.CommonTouchUiEditConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CommonTouchUiEditConfig.Instance);
		if (!MotorcycleArrowConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MotorcycleArrowConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MotorcycleArrowConfig.Instance);
		if (!PinballBattleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PinballBattleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PinballBattleConfig.Instance);
		if (!LevelGamePlayConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.Common.LevelGamePlayConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(LevelGamePlayConfig.Instance);
		if (!MusicBeatTypeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.LevelConditions.Config.MusicBeatTypeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MusicBeatTypeConfig.Instance);
		if (!TuningStandConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.LevelGamePlay.TuningStand.TuningStandConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TuningStandConfig.Instance);
		if (!AchievementConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AchievementConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AchievementConfig.Instance);
		if (!DrinksConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DrinksConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(DrinksConfig.Instance);
		if (!FurnitureConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FurnitureConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FurnitureConfig.Instance);
		if (!GolemHackingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GolemHackingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GolemHackingConfig.Instance);
		if (!ActivityDailyAdventureConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityDailyAdventureConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityDailyAdventureConfig.Instance);
		if (!GuessJokerConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::GuessJokerConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(GuessJokerConfig.Instance);
		if (!ActivityConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityConfig.Instance);
		if (!AdvanceNoticeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AdvanceNoticeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AdvanceNoticeConfig.Instance);
		if (!AnniversaryActivityConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Anniversary.AnniversaryActivityConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AnniversaryActivityConfig.Instance);
		if (!ArtemisActivityConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ArtemisActivityConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ArtemisActivityConfig.Instance);
		if (!AvignonConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AvignonConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AvignonConfig.Instance);
		if (!BabelTowerConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BabelTowerConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BabelTowerConfig.Instance);
		if (!ActivityBeginnerBookConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityBeginnerBookConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityBeginnerBookConfig.Instance);
		if (!BeginnerCarnivalConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BeginnerCarnivalConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BeginnerCarnivalConfig.Instance);
		if (!ActivityBlackCoastConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityBlackCoastConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityBlackCoastConfig.Instance);
		if (!BossRushConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BossRushConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BossRushConfig.Instance);
		if (!ActivityCollectionConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityCollectionConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityCollectionConfig.Instance);
		if (!CoopConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Coop.CoopConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CoopConfig.Instance);
		if (!ActivityCorniceMeetingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityCorniceMeetingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityCorniceMeetingConfig.Instance);
		if (!CumulativeShopConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CumulativeShopConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CumulativeShopConfig.Instance);
		if (!ActivityRecommendConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRecommendConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRecommendConfig.Instance);
		if (!ActivityNewcomerJourneyConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityNewcomerJourneyConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityNewcomerJourneyConfig.Instance);
		if (!ActivitySignGrandRewardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivitySignGrandRewardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivitySignGrandRewardConfig.Instance);
		if (!ActivityNewPlayerSupportConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityNewPlayerSupportConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityNewPlayerSupportConfig.Instance);
		if (!BattleScoreConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.BattleScoreConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BattleScoreConfig.Instance);
		if (!BossPilingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BossPiling.BossPilingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BossPilingConfig.Instance);
		if (!BuffItemConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::BuffItemConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BuffItemConfig.Instance);
		if (!CalabashConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CalabashConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CalabashConfig.Instance);
		if (!ChatConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ChatConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ChatConfig.Instance);
		if (!ComboTeachingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ComboTeachingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ComboTeachingConfig.Instance);
		if (!ComicConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Comic.ComicConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ComicConfig.Instance);
		if (!AudioConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Common.AudioConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AudioConfig.Instance);
		if (!CommonConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CommonConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CommonConfig.Instance);
		if (!ComponentConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ComponentConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ComponentConfig.Instance);
		if (!ElementInfoConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ElementInfoConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ElementInfoConfig.Instance);
		if (!ExchangeRewardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ExchangeRewardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ExchangeRewardConfig.Instance);
		if (!MappingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::MappingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MappingConfig.Instance);
		if (!PropertyIndexConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PropertyIndexConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PropertyIndexConfig.Instance);
		if (!MoraleBattleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.MoraleBattleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(MoraleBattleConfig.Instance);
		if (!UiResourceConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::UiResourceConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(UiResourceConfig.Instance);
		if (!FilterConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::FilterConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(FilterConfig.Instance);
		if (!SortConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::SortConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SortConfig.Instance);
		if (!ConfirmBoxConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ConfirmBoxConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ConfirmBoxConfig.Instance);
		if (!CookConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Cook.CookConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CookConfig.Instance);
		if (!CreateCharacterConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CreateCharacterConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(CreateCharacterConfig.Instance);
		if (!DailyActivityConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DailyActivityConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(DailyActivityConfig.Instance);
		if (!DamageUiConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DamageUiConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(DamageUiConfig.Instance);
		if (!DangoAbyssConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DangoAbyssConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(DangoAbyssConfig.Instance);
		if (!DangoConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Dango.DangoLogic.DangoConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(DangoConfig.Instance);
		if (!DreamLinkConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.DreamLink.DreamLinkConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(DreamLinkConfig.Instance);
		if (!DynamicTabConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::DynamicTabConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(DynamicTabConfig.Instance);
		if (!ErrorCodeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ErrorCodeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ErrorCodeConfig.Instance);
		if (!ExploreLevelConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ExploreLevelConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ExploreLevelConfig.Instance);
		if (!ExploreProgressConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ExploreProgressConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ExploreProgressConfig.Instance);
		if (!UiViewConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::UiViewConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(UiViewConfig.Instance);
		if (!BattleLinkConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Battle.BattleLinkConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BattleLinkConfig.Instance);
		if (!BattleUiConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BattleUi.BattleUiConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BattleUiConfig.Instance);
		if (!BattleUiSetConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.BattleUiSet.BattleUiSetConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(BattleUiSetConfig.Instance);
		if (!ActivityNoviceJourneyConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityNoviceJourneyConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityNoviceJourneyConfig.Instance);
		if (!ActivityPhantomCollectConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityPhantomCollectConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityPhantomCollectConfig.Instance);
		if (!PinballConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::PinballConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(PinballConfig.Instance);
		if (!ActivityPreWarmConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.PreWarm.ActivityPreWarmConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityPreWarmConfig.Instance);
		if (!ActivityPrizeDrawingConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityPrizeDrawingConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityPrizeDrawingConfig.Instance);
		if (!ActivityRealmBetweenConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween.ActivityRealmBetweenConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRealmBetweenConfig.Instance);
		if (!ActivityRegressConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRegressConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRegressConfig.Instance);
		if (!RhythmShipConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.RhythmShipConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RhythmShipConfig.Instance);
		if (!ActivityRoadBookConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RoadBook.ActivityRoadBookConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRoadBookConfig.Instance);
		if (!ActivityRoleGiveConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRoleGiveConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRoleGiveConfig.Instance);
		if (!ActivityRoleGuideConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRoleGuideConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRoleGuideConfig.Instance);
		if (!ActivityRoleSkinRewardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward.ActivityRoleSkinRewardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRoleSkinRewardConfig.Instance);
		if (!RoleSkinTrialConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::RoleSkinTrialConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RoleSkinTrialConfig.Instance);
		if (!ActivityRoleTrialConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRoleTrialConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRoleTrialConfig.Instance);
		if (!ActivityRogueConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity.ActivityRogueConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRogueConfig.Instance);
		if (!RoverlikeConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Roverlike.RoverlikeConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(RoverlikeConfig.Instance);
		if (!ActivityRunConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityRunConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityRunConfig.Instance);
		if (!AreaConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Area.AreaConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AreaConfig.Instance);
		if (!AdviceConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Advice.AdviceConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AdviceConfig.Instance);
		if (!AdventureGuideConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::AdventureGuideConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(AdventureGuideConfig.Instance);
		if (!WuWuLogisticsConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WuWuLogisticsConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WuWuLogisticsConfig.Instance);
		if (!WheelTowerConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::WheelTowerConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(WheelTowerConfig.Instance);
		if (!ActivityUniversalConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity.ActivityUniversalConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityUniversalConfig.Instance);
		if (!EntityOwnerConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::EntityOwnerConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(EntityOwnerConfig.Instance);
		if (!ActivityTurntableConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityTurntableConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityTurntableConfig.Instance);
		if (!TotalTopUpConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp.TotalTopUpConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TotalTopUpConfig.Instance);
		if (!ActivityTimePointRewardConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityTimePointRewardConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityTimePointRewardConfig.Instance);
		if (!ActivityTetrisConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.Tetris.ActivityTetrisConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityTetrisConfig.Instance);
		if (!SpringManorConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::CSharpScript.Game.Module.Activity.ActivityContent.SpringManor.SpringManorConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(SpringManorConfig.Instance);
		if (!ActivitySevenDaySignConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivitySevenDaySignConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivitySevenDaySignConfig.Instance);
		if (!ActivityScratchTicketConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityScratchTicketConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityScratchTicketConfig.Instance);
		if (!ActivityTowerGuideConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::ActivityTowerGuideConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(ActivityTowerGuideConfig.Instance);
		if (!TimeScheduleConfig.CreateInstance())
		{
			Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, "global::TimeScheduleConfig 配置创建单例失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		ConfigRegister.Configs.Add(TimeScheduleConfig.Instance);
		return true;
	}

	// Token: 0x0601DFCC RID: 122828 RVA: 0x00870878 File Offset: 0x0086EA78
	public static bool Init()
	{
		for (int i = 0; i < ConfigRegister.Configs.Count; i++)
		{
			ConfigBase configBase = ConfigRegister.Configs[i];
			if (!configBase.Init())
			{
				Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, configBase.GetType().FullName + " 配置初始化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601DFCD RID: 122829 RVA: 0x008708E0 File Offset: 0x0086EAE0
	public static bool Clear()
	{
		bool result = true;
		for (int i = 0; i < ConfigRegister.Configs.Count; i++)
		{
			ConfigBase configBase = ConfigRegister.Configs[i];
			try
			{
				if (!configBase.Clear())
				{
					Log.Instance.Error(ELogModule.Config, ELogAuthor.LRX, configBase.GetType().FullName + " 配置清理失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = false;
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = configBase.GetType().FullName + " 配置清理失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ex:", ex.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0400ECF0 RID: 60656
	private static List<ConfigBase> Configs = new List<ConfigBase>(272);
}

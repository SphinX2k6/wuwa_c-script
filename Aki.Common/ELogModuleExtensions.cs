using System;

// Token: 0x02000010 RID: 16
public static class ELogModuleExtensions
{
	// Token: 0x0600009D RID: 157 RVA: 0x000046C0 File Offset: 0x000028C0
	public static string ToEnumString(this ELogModule value)
	{
		string result;
		switch (value)
		{
		case ELogModule.Engine:
			result = "Engine";
			break;
		case ELogModule.UiEditor:
			result = "UiEditor";
			break;
		case ELogModule.ResourceCheck:
			result = "ResourceCheck";
			break;
		case ELogModule.IllegalCodeCheck:
			result = "IllegalCodeCheck";
			break;
		case ELogModule.Temp:
			result = "Temp";
			break;
		case ELogModule.HotPatch:
			result = "HotPatch";
			break;
		case ELogModule.Log:
			result = "Log";
			break;
		case ELogModule.ExportProto:
			result = "ExportProto";
			break;
		case ELogModule.Core:
			result = "Core";
			break;
		case ELogModule.Entity:
			result = "Entity";
			break;
		case ELogModule.Event:
			result = "Event";
			break;
		case ELogModule.Json:
			result = "Json";
			break;
		case ELogModule.P4:
			result = "P4";
			break;
		case ELogModule.Config:
			result = "Config";
			break;
		case ELogModule.CommonDbConnect:
			result = "CommonDbConnect";
			break;
		case ELogModule.Pool:
			result = "Pool";
			break;
		case ELogModule.Container:
			result = "Container";
			break;
		case ELogModule.UiCore:
			result = "UiCore";
			break;
		case ELogModule.Net:
			result = "Net";
			break;
		case ELogModule.Object:
			result = "Object";
			break;
		case ELogModule.Resource:
			result = "Resource";
			break;
		case ELogModule.Tick:
			result = "Tick";
			break;
		case ELogModule.Timer:
			result = "Timer";
			break;
		case ELogModule.Game:
			result = "Game";
			break;
		case ELogModule.Render:
			result = "Render";
			break;
		case ELogModule.Preload:
			result = "Preload";
			break;
		case ELogModule.StateMachine:
			result = "StateMachine";
			break;
		case ELogModule.BehaviorTree:
			result = "BehaviorTree";
			break;
		case ELogModule.Camera:
			result = "Camera";
			break;
		case ELogModule.Character:
			result = "Character";
			break;
		case ELogModule.TextUtil:
			result = "TextUtil";
			break;
		case ELogModule.Input:
			result = "Input";
			break;
		case ELogModule.InputSettings:
			result = "InputSettings";
			break;
		case ELogModule.Level:
			result = "Level";
			break;
		case ELogModule.Audio:
			result = "Audio";
			break;
		case ELogModule.Battle:
			result = "Battle";
			break;
		case ELogModule.UiModel:
			result = "UiModel";
			break;
		case ELogModule.UiModelMorph:
			result = "UiModelMorph";
			break;
		case ELogModule.BpBridge:
			result = "BpBridge";
			break;
		case ELogModule.TaskGraph:
			result = "TaskGraph";
			break;
		case ELogModule.UiCommon:
			result = "UiCommon";
			break;
		case ELogModule.ConfirmBox:
			result = "ConfirmBox";
			break;
		case ELogModule.UiTabModule:
			result = "UiTabModule";
			break;
		case ELogModule.SceneTeam:
			result = "SceneTeam";
			break;
		case ELogModule.MultiPlayerTeam:
			result = "MultiPlayerTeam";
			break;
		case ELogModule.Formation:
			result = "Formation";
			break;
		case ELogModule.DarkTide:
			result = "DarkTide";
			break;
		case ELogModule.DarkTideRing:
			result = "DarkTideRing";
			break;
		case ELogModule.ErrorCode:
			result = "ErrorCode";
			break;
		case ELogModule.Functional:
			result = "Functional";
			break;
		case ELogModule.Gm:
			result = "Gm";
			break;
		case ELogModule.Guide:
			result = "Guide";
			break;
		case ELogModule.Inventory:
			result = "Inventory";
			break;
		case ELogModule.Item:
			result = "Item";
			break;
		case ELogModule.ItemHint:
			result = "ItemHint";
			break;
		case ELogModule.LevelUp:
			result = "LevelUp";
			break;
		case ELogModule.Login:
			result = "Login";
			break;
		case ELogModule.Mail:
			result = "Mail";
			break;
		case ELogModule.Map:
			result = "Map";
			break;
		case ELogModule.MingSuTi:
			result = "MingSuTi";
			break;
		case ELogModule.Phantom:
			result = "Phantom";
			break;
		case ELogModule.Reconnect:
			result = "Reconnect";
			break;
		case ELogModule.Reward:
			result = "Reward";
			break;
		case ELogModule.RewardItem:
			result = "RewardItem";
			break;
		case ELogModule.Role:
			result = "Role";
			break;
		case ELogModule.Personal:
			result = "Personal";
			break;
		case ELogModule.Shop:
			result = "Shop";
			break;
		case ELogModule.Tape:
			result = "Tape";
			break;
		case ELogModule.UiCamera:
			result = "UiCamera";
			break;
		case ELogModule.CameraAnimation:
			result = "CameraAnimation";
			break;
		case ELogModule.UiComponent:
			result = "UiComponent";
			break;
		case ELogModule.ModuleUtil:
			result = "ModuleUtil";
			break;
		case ELogModule.Weapon:
			result = "Weapon";
			break;
		case ELogModule.Bullet:
			result = "Bullet";
			break;
		case ELogModule.Pawn:
			result = "Pawn";
			break;
		case ELogModule.SceneItem:
			result = "SceneItem";
			break;
		case ELogModule.RenderCharacter:
			result = "RenderCharacter";
			break;
		case ELogModule.RenderBattle:
			result = "RenderBattle";
			break;
		case ELogModule.RenderEffect:
			result = "RenderEffect";
			break;
		case ELogModule.RenderGI:
			result = "RenderGI";
			break;
		case ELogModule.RenderScene:
			result = "RenderScene";
			break;
		case ELogModule.RenderUtil:
			result = "RenderUtil";
			break;
		case ELogModule.World:
			result = "World";
			break;
		case ELogModule.GameMode:
			result = "GameMode";
			break;
		case ELogModule.Movement:
			result = "Movement";
			break;
		case ELogModule.Test:
			result = "Test";
			break;
		case ELogModule.LevelExperienceComponent:
			result = "LevelExperienceComponent";
			break;
		case ELogModule.LoopScrollView:
			result = "LoopScrollView";
			break;
		case ELogModule.ScrollViewGrid:
			result = "ScrollViewGrid";
			break;
		case ELogModule.LevelSequencePlayer:
			result = "LevelSequencePlayer";
			break;
		case ELogModule.GachaSequencePlayer:
			result = "GachaSequencePlayer";
			break;
		case ELogModule.UiSceneRoleActor:
			result = "UiSceneRoleActor";
			break;
		case ELogModule.CreateCharacter:
			result = "CreateCharacter";
			break;
		case ELogModule.TimeOfDay:
			result = "TimeOfDay";
			break;
		case ELogModule.ModelUtil:
			result = "ModelUtil";
			break;
		case ELogModule.Editor:
			result = "Editor";
			break;
		case ELogModule.AI:
			result = "AI";
			break;
		case ELogModule.LevelAi:
			result = "LevelAi";
			break;
		case ELogModule.PowerModule:
			result = "PowerModule";
			break;
		case ELogModule.WorldLevel:
			result = "WorldLevel";
			break;
		case ELogModule.TriggerVolume:
			result = "TriggerVolume";
			break;
		case ELogModule.GenericPrompt:
			result = "GenericPrompt";
			break;
		case ELogModule.SceneGameplay:
			result = "SceneGameplay";
			break;
		case ELogModule.SceneStep:
			result = "SceneStep";
			break;
		case ELogModule.InstanceDungeon:
			result = "InstanceDungeon";
			break;
		case ELogModule.Quest:
			result = "Quest";
			break;
		case ELogModule.QuestResource:
			result = "QuestResource";
			break;
		case ELogModule.QuestRecall:
			result = "QuestRecall";
			break;
		case ELogModule.LevelPlay:
			result = "LevelPlay";
			break;
		case ELogModule.WuYinModel:
			result = "WuYinModel";
			break;
		case ELogModule.ControlScreen:
			result = "ControlScreen";
			break;
		case ELogModule.BuffItem:
			result = "BuffItem";
			break;
		case ELogModule.Marquee:
			result = "Marquee";
			break;
		case ELogModule.Plot:
			result = "Plot";
			break;
		case ELogModule.KuroSdk:
			result = "KuroSdk";
			break;
		case ELogModule.ResonanceEffect:
			result = "ResonanceEffect";
			break;
		case ELogModule.RoleResonance:
			result = "RoleResonance";
			break;
		case ELogModule.RedDot:
			result = "RedDot";
			break;
		case ELogModule.DebugView:
			result = "DebugView";
			break;
		case ELogModule.ProtocolMonitor:
			result = "ProtocolMonitor";
			break;
		case ELogModule.LevelEvent:
			result = "LevelEvent";
			break;
		case ELogModule.LevelCondition:
			result = "LevelCondition";
			break;
		case ELogModule.LevelConditionRegistry:
			result = "LevelConditionRegistry";
			break;
		case ELogModule.UiSceneManager:
			result = "UiSceneManager";
			break;
		case ELogModule.Loading:
			result = "Loading";
			break;
		case ELogModule.GamePlayTimer:
			result = "GamePlayTimer";
			break;
		case ELogModule.Menu:
			result = "Menu";
			break;
		case ELogModule.InputManager:
			result = "InputManager";
			break;
		case ELogModule.UiTimeDilation:
			result = "UiTimeDilation";
			break;
		case ELogModule.UiAnimation:
			result = "UiAnimation";
			break;
		case ELogModule.Interaction:
			result = "Interaction";
			break;
		case ELogModule.SneakUi:
			result = "SneakUi";
			break;
		case ELogModule.CollectActor:
			result = "CollectActor";
			break;
		case ELogModule.Video:
			result = "Video";
			break;
		case ELogModule.Area:
			result = "Area";
			break;
		case ELogModule.ElementBall:
			result = "ElementBall";
			break;
		case ELogModule.Stat:
			result = "Stat";
			break;
		case ELogModule.LogReport:
			result = "LogReport";
			break;
		case ELogModule.SaveUtil:
			result = "SaveUtil";
			break;
		case ELogModule.Platform:
			result = "Platform";
			break;
		case ELogModule.PlatformSdk:
			result = "PlatformSdk";
			break;
		case ELogModule.PublicUtil:
			result = "PublicUtil";
			break;
		case ELogModule.ShortKeysExitView:
			result = "ShortKeysExitView";
			break;
		case ELogModule.MultiplayerCombat:
			result = "MultiplayerCombat";
			break;
		case ELogModule.CombatInfo:
			result = "CombatInfo";
			break;
		case ELogModule.Controller:
			result = "Controller";
			break;
		case ELogModule.FilterSortView:
			result = "FilterSortView";
			break;
		case ELogModule.Friend:
			result = "Friend";
			break;
		case ELogModule.Cursor:
			result = "Cursor";
			break;
		case ELogModule.UiNavigation:
			result = "UiNavigation";
			break;
		case ELogModule.UiNavigationHotKey:
			result = "UiNavigationHotKey";
			break;
		case ELogModule.Chat:
			result = "Chat";
			break;
		case ELogModule.Track:
			result = "Track";
			break;
		case ELogModule.Performance:
			result = "Performance";
			break;
		case ELogModule.GeneralLogicTree:
			result = "GeneralLogicTree";
			break;
		case ELogModule.Pay:
			result = "Pay";
			break;
		case ELogModule.TimeUtil:
			result = "TimeUtil";
			break;
		case ELogModule.Gacha:
			result = "Gacha";
			break;
		case ELogModule.Calabash:
			result = "Calabash";
			break;
		case ELogModule.ItemExchange:
			result = "ItemExchange";
			break;
		case ELogModule.AdventureGuide:
			result = "AdventureGuide";
			break;
		case ELogModule.Tutorial:
			result = "Tutorial";
			break;
		case ELogModule.Weather:
			result = "Weather";
			break;
		case ELogModule.InfoDisplay:
			result = "InfoDisplay";
			break;
		case ELogModule.Scene3dUi:
			result = "Scene3dUi";
			break;
		case ELogModule.LguiUtil:
			result = "LguiUtil";
			break;
		case ELogModule.Cook:
			result = "Cook";
			break;
		case ELogModule.GenericLayoutNew:
			result = "GenericLayoutNew";
			break;
		case ELogModule.UiFloatContainer:
			result = "UiFloatContainer";
			break;
		case ELogModule.InfluenceReputation:
			result = "InfluenceReputation";
			break;
		case ELogModule.HudUnit:
			result = "HudUnit";
			break;
		case ELogModule.CycleTower:
			result = "CycleTower";
			break;
		case ELogModule.TowerDefense:
			result = "TowerDefense";
			break;
		case ELogModule.Animal:
			result = "Animal";
			break;
		case ELogModule.Recorder:
			result = "Recorder";
			break;
		case ELogModule.ManufactureCommon:
			result = "ManufactureCommon";
			break;
		case ELogModule.Compose:
			result = "Compose";
			break;
		case ELogModule.Forging:
			result = "Forging";
			break;
		case ELogModule.UiLoginSceneManager:
			result = "UiLoginSceneManager";
			break;
		case ELogModule.HotFixSceneManager:
			result = "HotFixSceneManager";
			break;
		case ELogModule.Advice:
			result = "Advice";
			break;
		case ELogModule.LocalStorage:
			result = "LocalStorage";
			break;
		case ELogModule.ServerStorage:
			result = "ServerStorage";
			break;
		case ELogModule.HandBook:
			result = "HandBook";
			break;
		case ELogModule.ActorSystem:
			result = "ActorSystem";
			break;
		case ELogModule.UiModelResourcesManager:
			result = "UiModelResourcesManager";
			break;
		case ELogModule.NPC:
			result = "NPC";
			break;
		case ELogModule.BasePerform:
			result = "BasePerform";
			break;
		case ELogModule.Achievement:
			result = "Achievement";
			break;
		case ELogModule.NewFlag:
			result = "NewFlag";
			break;
		case ELogModule.Heartbeat:
			result = "Heartbeat";
			break;
		case ELogModule.UiManager:
			result = "UiManager";
			break;
		case ELogModule.BattleUiSet:
			result = "BattleUiSet";
			break;
		case ELogModule.StackContainer:
			result = "StackContainer";
			break;
		case ELogModule.PlotContainer:
			result = "PlotContainer";
			break;
		case ELogModule.DataTableUtil:
			result = "DataTableUtil";
			break;
		case ELogModule.PanelQte:
			result = "PanelQte";
			break;
		case ELogModule.CommonQte:
			result = "CommonQte";
			break;
		case ELogModule.ComboTeaching:
			result = "ComboTeaching";
			break;
		case ELogModule.Activity:
			result = "Activity";
			break;
		case ELogModule.Teleport:
			result = "Teleport";
			break;
		case ELogModule.TeleportMisc:
			result = "TeleportMisc";
			break;
		case ELogModule.TextLanguageSearch:
			result = "TextLanguageSearch";
			break;
		case ELogModule.UiViewContainer:
			result = "UiViewContainer";
			break;
		case ELogModule.UiLayer:
			result = "UiLayer";
			break;
		case ELogModule.UiMask:
			result = "UiMask";
			break;
		case ELogModule.UiImageSetting:
			result = "UiImageSetting";
			break;
		case ELogModule.UiPrefabLoad:
			result = "UiPrefabLoad";
			break;
		case ELogModule.PerfHeatmap:
			result = "PerfHeatmap";
			break;
		case ELogModule.SeamlessTravel:
			result = "SeamlessTravel";
			break;
		case ELogModule.Filter:
			result = "Filter";
			break;
		case ELogModule.Sort:
			result = "Sort";
			break;
		case ELogModule.UiTickConditionModule:
			result = "UiTickConditionModule";
			break;
		case ELogModule.TsUiSceneRoleActor:
			result = "TsUiSceneRoleActor";
			break;
		case ELogModule.MultiTextCsvModule:
			result = "MultiTextCsvModule";
			break;
		case ELogModule.BlackScreen:
			result = "BlackScreen";
			break;
		case ELogModule.DynamicMaskButton:
			result = "DynamicMaskButton";
			break;
		case ELogModule.Roguelike:
			result = "Roguelike";
			break;
		case ELogModule.RogueBattle:
			result = "RogueBattle";
			break;
		case ELogModule.SkipInterface:
			result = "SkipInterface";
			break;
		case ELogModule.TickController:
			result = "TickController";
			break;
		case ELogModule.ExploreProgress:
			result = "ExploreProgress";
			break;
		case ELogModule.ExploreLevel:
			result = "ExploreLevel";
			break;
		case ELogModule.Blur:
			result = "Blur";
			break;
		case ELogModule.AndroidBack:
			result = "AndroidBack";
			break;
		case ELogModule.CloudGame:
			result = "CloudGame";
			break;
		case ELogModule.FrequencyMonitor:
			result = "FrequencyMonitor";
			break;
		case ELogModule.Photo:
			result = "Photo";
			break;
		case ELogModule.PhotoCamera:
			result = "PhotoCamera";
			break;
		case ELogModule.FragmentMemory:
			result = "FragmentMemory";
			break;
		case ELogModule.Push:
			result = "Push";
			break;
		case ELogModule.LogUpload:
			result = "LogUpload";
			break;
		case ELogModule.Perception:
			result = "Perception";
			break;
		case ELogModule.MoonChasing:
			result = "MoonChasing";
			break;
		case ELogModule.MowingRisk:
			result = "MowingRisk";
			break;
		case ELogModule.VersionPreheat:
			result = "VersionPreheat";
			break;
		case ELogModule.Spring25:
			result = "Spring25";
			break;
		case ELogModule.SolarSpeed:
			result = "SolarSpeed";
			break;
		case ELogModule.InviteNewbie:
			result = "InviteNewbie";
			break;
		case ELogModule.RacingBets:
			result = "RacingBets";
			break;
		case ELogModule.RacingBetsDungeon:
			result = "RacingBetsDungeon";
			break;
		case ELogModule.PortalGamePlay:
			result = "PortalGamePlay";
			break;
		case ELogModule.ActivityRegress:
			result = "ActivityRegress";
			break;
		case ELogModule.Vehicle:
			result = "Vehicle";
			break;
		case ELogModule.ScratchTicket:
			result = "ScratchTicket";
			break;
		case ELogModule.FloroRanch:
			result = "FloroRanch";
			break;
		case ELogModule.FloroRanchGamePlay:
			result = "FloroRanchGamePlay";
			break;
		case ELogModule.GameSettings:
			result = "GameSettings";
			break;
		case ELogModule.MobileInputSwitch:
			result = "MobileInputSwitch";
			break;
		case ELogModule.DreamLink:
			result = "DreamLink";
			break;
		case ELogModule.RoleSkin:
			result = "RoleSkin";
			break;
		case ELogModule.WeaponSkin:
			result = "WeaponSkin";
			break;
		case ELogModule.FlySkin:
			result = "FlySkin";
			break;
		case ELogModule.Dockyard:
			result = "Dockyard";
			break;
		case ELogModule.FilterWithState:
			result = "FilterWithState";
			break;
		case ELogModule.ResponsibilityChain:
			result = "ResponsibilityChain";
			break;
		case ELogModule.LevelPlayReport:
			result = "LevelPlayReport";
			break;
		case ELogModule.ActivityDirectTrain:
			result = "ActivityDirectTrain";
			break;
		case ELogModule.Optimization:
			result = "Optimization";
			break;
		case ELogModule.Fishing:
			result = "Fishing";
			break;
		case ELogModule.ShipTower:
			result = "ShipTower";
			break;
		case ELogModule.UiAsyncTask:
			result = "UiAsyncTask";
			break;
		case ELogModule.WeeklyRogue:
			result = "WeeklyRogue";
			break;
		case ELogModule.Chess:
			result = "Chess";
			break;
		case ELogModule.SummonGongduola:
			result = "SummonGongduola";
			break;
		case ELogModule.CiacconaGal:
			result = "CiacconaGal";
			break;
		case ELogModule.DangoMonopoly:
			result = "DangoMonopoly";
			break;
		case ELogModule.TermExplanation:
			result = "TermExplanation";
			break;
		case ELogModule.SplashScreenTask:
			result = "SplashScreenTask";
			break;
		case ELogModule.PhantomArena:
			result = "PhantomArena";
			break;
		case ELogModule.Shower:
			result = "Shower";
			break;
		case ELogModule.SceneItemCurveControl:
			result = "SceneItemCurveControl";
			break;
		case ELogModule.TemplateEntitySpawner:
			result = "TemplateEntitySpawner";
			break;
		case ELogModule.ChargeSlash:
			result = "ChargeSlash";
			break;
		case ELogModule.Morale:
			result = "Morale";
			break;
		case ELogModule.LevelFlow:
			result = "LevelFlow";
			break;
		case ELogModule.TimeDilation:
			result = "TimeDilation";
			break;
		case ELogModule.KingShip:
			result = "KingShip";
			break;
		case ELogModule.TuningStand:
			result = "TuningStand";
			break;
		case ELogModule.CommonGameMainView:
			result = "CommonGameMainView";
			break;
		case ELogModule.TowerDefenseEvent:
			result = "TowerDefenseEvent";
			break;
		case ELogModule.TowerDefenseBattle:
			result = "TowerDefenseBattle";
			break;
		case ELogModule.TouchUiEdit:
			result = "TouchUiEdit";
			break;
		case ELogModule.PsGamepadFeedback:
			result = "PsGamepadFeedback";
			break;
		case ELogModule.HonamiStory:
			result = "HonamiStory";
			break;
		case ELogModule.AnimNotify:
			result = "AnimNotify";
			break;
		case ELogModule.ActivityFunPlay:
			result = "ActivityFunPlay";
			break;
		case ELogModule.HomeBtn:
			result = "HomeBtn";
			break;
		case ELogModule.DailyActivity:
			result = "DailyActivity";
			break;
		case ELogModule.RoleDev:
			result = "RoleDev";
			break;
		case ELogModule.SurvivorsRogue:
			result = "SurvivorsRogue";
			break;
		case ELogModule.FightPhotograph:
			result = "FightPhotograph";
			break;
		case ELogModule.Photograph:
			result = "Photograph";
			break;
		case ELogModule.MeshStream:
			result = "MeshStream";
			break;
		case ELogModule.CalabashSkin:
			result = "CalabashSkin";
			break;
		case ELogModule.QuestTree:
			result = "QuestTree";
			break;
		case ELogModule.ActivityPreWarm:
			result = "ActivityPreWarm";
			break;
		case ELogModule.LevelListener:
			result = "LevelListener";
			break;
		case ELogModule.MultiTemplateScrollView:
			result = "MultiTemplateScrollView";
			break;
		case ELogModule.GridDelegate:
			result = "GridDelegate";
			break;
		case ELogModule.MultiTemplateComponent:
			result = "MultiTemplateComponent";
			break;
		case ELogModule.SubPackageDownLoad:
			result = "SubPackageDownLoad";
			break;
		case ELogModule.Infrastructure:
			result = "Infrastructure";
			break;
		case ELogModule.VillageInfr:
			result = "VillageInfr";
			break;
		case ELogModule.RollBlock:
			result = "RollBlock";
			break;
		case ELogModule.AutoPilot:
			result = "AutoPilot";
			break;
		case ELogModule.VehicleStream:
			result = "VehicleStream";
			break;
		case ELogModule.Panoramic:
			result = "Panoramic";
			break;
		case ELogModule.Motor:
			result = "Motor";
			break;
		case ELogModule.PilotThrow:
			result = "PilotThrow";
			break;
		case ELogModule.MovieMode:
			result = "MovieMode";
			break;
		case ELogModule.DeadEye:
			result = "DeadEye";
			break;
		case ELogModule.WheelTower:
			result = "WheelTower";
			break;
		case ELogModule.MotorParkour:
			result = "MotorParkour";
			break;
		case ELogModule.MotorRailMove:
			result = "MotorRailMove";
			break;
		case ELogModule.PhantomInteraction:
			result = "PhantomInteraction";
			break;
		case ELogModule.PhoneSystem:
			result = "PhoneSystem";
			break;
		case ELogModule.SunSpirit:
			result = "SunSpirit";
			break;
		case ELogModule.Encircle:
			result = "Encircle";
			break;
		case ELogModule.MotorFightActivity:
			result = "MotorFightActivity";
			break;
		case ELogModule.ActivityTotalTopUp:
			result = "ActivityTotalTopUp";
			break;
		case ELogModule.SpringManor:
			result = "SpringManor";
			break;
		case ELogModule.GuessJokerCard:
			result = "GuessJokerCard";
			break;
		case ELogModule.Drinks:
			result = "Drinks";
			break;
		case ELogModule.DropCatch:
			result = "DropCatch";
			break;
		case ELogModule.RhythmGame:
			result = "RhythmGame";
			break;
		case ELogModule.SlidingBlocks:
			result = "SlidingBlocks";
			break;
		case ELogModule.Pinball:
			result = "Pinball";
			break;
		case ELogModule.RoleOrnament:
			result = "RoleOrnament";
			break;
		case ELogModule.Decoration:
			result = "Decoration";
			break;
		case ELogModule.FlagChallenge:
			result = "FlagChallenge";
			break;
		case ELogModule.BossPiling:
			result = "BossPiling";
			break;
		case ELogModule.PinballBattle:
			result = "PinballBattle";
			break;
		case ELogModule.GolemHacking:
			result = "GolemHacking";
			break;
		case ELogModule.ProjectorPuzzle:
			result = "ProjectorPuzzle";
			break;
		case ELogModule.WeeklyChallenge:
			result = "WeeklyChallenge";
			break;
		case ELogModule.QuickHack:
			result = "QuickHack";
			break;
		case ELogModule.IosAudit:
			result = "IosAudit";
			break;
		case ELogModule.DollGrabMachine:
			result = "DollGrabMachine";
			break;
		case ELogModule.Roverlike:
			result = "Roverlike";
			break;
		case ELogModule.MusicalInstrument:
			result = "MusicalInstrument";
			break;
		case ELogModule.QuestMultiLine:
			result = "QuestMultiLine";
			break;
		case ELogModule.PathDrivenActor:
			result = "PathDrivenActor";
			break;
		case ELogModule.Capability:
			result = "Capability";
			break;
		case ELogModule.Sheriff:
			result = "Sheriff";
			break;
		case ELogModule.DangoBrawl:
			result = "DangoBrawl";
			break;
		case ELogModule.MatchThree:
			result = "MatchThree";
			break;
		case ELogModule.Giant:
			result = "Giant";
			break;
		case ELogModule.WuWaGo:
			result = "WuWaGo";
			break;
		case ELogModule.Season:
			result = "Season";
			break;
		case ELogModule.Kurotato:
			result = "Kurotato";
			break;
		case ELogModule.ComboTimeline:
			result = "ComboTimeline";
			break;
		default:
			result = value.ToString();
			break;
		}
		return result;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00005B5C File Offset: 0x00003D5C
	public static ELogModule FromString(string name)
	{
		ELogModule result;
		if (!ELogModuleExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 ELogModule 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00005B88 File Offset: 0x00003D88
	public static bool TryFromString(string name, out ELogModule value)
	{
		if (string.IsNullOrEmpty(name))
		{
			value = ELogModule.Engine;
			return false;
		}
		if (name != null)
		{
			switch (name.Length)
			{
			case 2:
			{
				char c = name[0];
				if (c != 'A')
				{
					if (c != 'G')
					{
						if (c == 'P')
						{
							if (name == "P4")
							{
								value = ELogModule.P4;
								return true;
							}
						}
					}
					else if (name == "Gm")
					{
						value = ELogModule.Gm;
						return true;
					}
				}
				else if (name == "AI")
				{
					value = ELogModule.AI;
					return true;
				}
				break;
			}
			case 3:
			{
				char c = name[2];
				if (c <= 'g')
				{
					if (c != 'C')
					{
						if (c == 'g')
						{
							if (name == "Log")
							{
								value = ELogModule.Log;
								return true;
							}
						}
					}
					else if (name == "NPC")
					{
						value = ELogModule.NPC;
						return true;
					}
				}
				else if (c != 'p')
				{
					if (c != 't')
					{
						if (c == 'y')
						{
							if (name == "Pay")
							{
								value = ELogModule.Pay;
								return true;
							}
						}
					}
					else if (name == "Net")
					{
						value = ELogModule.Net;
						return true;
					}
				}
				else if (name == "Map")
				{
					value = ELogModule.Map;
					return true;
				}
				break;
			}
			case 4:
				switch (name[2])
				{
				case 'a':
					if (name == "Stat")
					{
						value = ELogModule.Stat;
						return true;
					}
					if (name == "Chat")
					{
						value = ELogModule.Chat;
						return true;
					}
					break;
				case 'c':
					if (name == "Tick")
					{
						value = ELogModule.Tick;
						return true;
					}
					break;
				case 'e':
					if (name == "Item")
					{
						value = ELogModule.Item;
						return true;
					}
					if (name == "Area")
					{
						value = ELogModule.Area;
						return true;
					}
					break;
				case 'i':
					if (name == "Mail")
					{
						value = ELogModule.Mail;
						return true;
					}
					break;
				case 'l':
					if (name == "Role")
					{
						value = ELogModule.Role;
						return true;
					}
					break;
				case 'm':
					if (name == "Temp")
					{
						value = ELogModule.Temp;
						return true;
					}
					if (name == "Game")
					{
						value = ELogModule.Game;
						return true;
					}
					break;
				case 'n':
					if (name == "Menu")
					{
						value = ELogModule.Menu;
						return true;
					}
					break;
				case 'o':
					if (name == "Json")
					{
						value = ELogModule.Json;
						return true;
					}
					if (name == "Pool")
					{
						value = ELogModule.Pool;
						return true;
					}
					if (name == "Shop")
					{
						value = ELogModule.Shop;
						return true;
					}
					if (name == "Plot")
					{
						value = ELogModule.Plot;
						return true;
					}
					if (name == "Cook")
					{
						value = ELogModule.Cook;
						return true;
					}
					break;
				case 'p':
					if (name == "Tape")
					{
						value = ELogModule.Tape;
						return true;
					}
					break;
				case 'r':
					if (name == "Core")
					{
						value = ELogModule.Core;
						return true;
					}
					if (name == "Sort")
					{
						value = ELogModule.Sort;
						return true;
					}
					break;
				case 's':
					if (name == "Test")
					{
						value = ELogModule.Test;
						return true;
					}
					if (name == "Push")
					{
						value = ELogModule.Push;
						return true;
					}
					break;
				case 'u':
					if (name == "Blur")
					{
						value = ELogModule.Blur;
						return true;
					}
					break;
				case 'w':
					if (name == "Pawn")
					{
						value = ELogModule.Pawn;
						return true;
					}
					break;
				}
				break;
			case 5:
				switch (name[0])
				{
				case 'A':
					if (name == "Audio")
					{
						value = ELogModule.Audio;
						return true;
					}
					break;
				case 'C':
					if (name == "Chess")
					{
						value = ELogModule.Chess;
						return true;
					}
					break;
				case 'E':
					if (name == "Event")
					{
						value = ELogModule.Event;
						return true;
					}
					break;
				case 'G':
					if (name == "Guide")
					{
						value = ELogModule.Guide;
						return true;
					}
					if (name == "Gacha")
					{
						value = ELogModule.Gacha;
						return true;
					}
					if (name == "Giant")
					{
						value = ELogModule.Giant;
						return true;
					}
					break;
				case 'I':
					if (name == "Input")
					{
						value = ELogModule.Input;
						return true;
					}
					break;
				case 'L':
					if (name == "Level")
					{
						value = ELogModule.Level;
						return true;
					}
					if (name == "Login")
					{
						value = ELogModule.Login;
						return true;
					}
					break;
				case 'M':
					if (name == "Motor")
					{
						value = ELogModule.Motor;
						return true;
					}
					break;
				case 'P':
					if (name == "Photo")
					{
						value = ELogModule.Photo;
						return true;
					}
					break;
				case 'Q':
					if (name == "Quest")
					{
						value = ELogModule.Quest;
						return true;
					}
					break;
				case 'T':
					if (name == "Timer")
					{
						value = ELogModule.Timer;
						return true;
					}
					if (name == "Track")
					{
						value = ELogModule.Track;
						return true;
					}
					break;
				case 'V':
					if (name == "Video")
					{
						value = ELogModule.Video;
						return true;
					}
					break;
				case 'W':
					if (name == "World")
					{
						value = ELogModule.World;
						return true;
					}
					break;
				}
				break;
			case 6:
			{
				char c = name[2];
				if (c <= 'M')
				{
					if (c != 'C')
					{
						if (c == 'M')
						{
							if (name == "UiMask")
							{
								value = ELogModule.UiMask;
								return true;
							}
						}
					}
					else if (name == "UiCore")
					{
						value = ELogModule.UiCore;
						return true;
					}
				}
				else if (c != 'W')
				{
					switch (c)
					{
					case 'a':
						if (name == "Weapon")
						{
							value = ELogModule.Weapon;
							return true;
						}
						if (name == "Season")
						{
							value = ELogModule.Season;
							return true;
						}
						break;
					case 'd':
						if (name == "RedDot")
						{
							value = ELogModule.RedDot;
							return true;
						}
						break;
					case 'g':
						if (name == "Engine")
						{
							value = ELogModule.Engine;
							return true;
						}
						break;
					case 'i':
						if (name == "Editor")
						{
							value = ELogModule.Editor;
							return true;
						}
						if (name == "Friend")
						{
							value = ELogModule.Friend;
							return true;
						}
						if (name == "Animal")
						{
							value = ELogModule.Animal;
							return true;
						}
						if (name == "Drinks")
						{
							value = ELogModule.Drinks;
							return true;
						}
						break;
					case 'j':
						if (name == "Object")
						{
							value = ELogModule.Object;
							return true;
						}
						break;
					case 'l':
						if (name == "Bullet")
						{
							value = ELogModule.Bullet;
							return true;
						}
						if (name == "Filter")
						{
							value = ELogModule.Filter;
							return true;
						}
						break;
					case 'm':
						if (name == "Camera")
						{
							value = ELogModule.Camera;
							return true;
						}
						break;
					case 'n':
						if (name == "Config")
						{
							value = ELogModule.Config;
							return true;
						}
						if (name == "Render")
						{
							value = ELogModule.Render;
							return true;
						}
						break;
					case 'o':
						if (name == "Shower")
						{
							value = ELogModule.Shower;
							return true;
						}
						break;
					case 'r':
						if (name == "Cursor")
						{
							value = ELogModule.Cursor;
							return true;
						}
						if (name == "Morale")
						{
							value = ELogModule.Morale;
							return true;
						}
						break;
					case 't':
						if (name == "Entity")
						{
							value = ELogModule.Entity;
							return true;
						}
						if (name == "Battle")
						{
							value = ELogModule.Battle;
							return true;
						}
						break;
					case 'v':
						if (name == "Advice")
						{
							value = ELogModule.Advice;
							return true;
						}
						break;
					case 'w':
						if (name == "Reward")
						{
							value = ELogModule.Reward;
							return true;
						}
						break;
					}
				}
				else if (name == "WuWaGo")
				{
					value = ELogModule.WuWaGo;
					return true;
				}
				break;
			}
			case 7:
			{
				char c = name[3];
				if (c <= 'S')
				{
					if (c != 'F')
					{
						if (c == 'S')
						{
							if (name == "FlySkin")
							{
								value = ELogModule.FlySkin;
								return true;
							}
						}
					}
					else if (name == "NewFlag")
					{
						value = ELogModule.NewFlag;
						return true;
					}
				}
				else if (c != 'U')
				{
					switch (c)
					{
					case 'a':
						if (name == "SneakUi")
						{
							value = ELogModule.SneakUi;
							return true;
						}
						if (name == "UiLayer")
						{
							value = ELogModule.UiLayer;
							return true;
						}
						break;
					case 'b':
						if (name == "Pinball")
						{
							value = ELogModule.Pinball;
							return true;
						}
						break;
					case 'd':
						if (name == "Loading")
						{
							value = ELogModule.Loading;
							return true;
						}
						if (name == "DeadEye")
						{
							value = ELogModule.DeadEye;
							return true;
						}
						break;
					case 'e':
						if (name == "LevelUp")
						{
							value = ELogModule.LevelUp;
							return true;
						}
						if (name == "LevelAi")
						{
							value = ELogModule.LevelAi;
							return true;
						}
						if (name == "HomeBtn")
						{
							value = ELogModule.HomeBtn;
							return true;
						}
						if (name == "RoleDev")
						{
							value = ELogModule.RoleDev;
							return true;
						}
						break;
					case 'g':
						if (name == "Forging")
						{
							value = ELogModule.Forging;
							return true;
						}
						break;
					case 'h':
						if (name == "Fishing")
						{
							value = ELogModule.Fishing;
							return true;
						}
						break;
					case 'i':
						if (name == "Vehicle")
						{
							value = ELogModule.Vehicle;
							return true;
						}
						break;
					case 'l':
						if (name == "Preload")
						{
							value = ELogModule.Preload;
							return true;
						}
						break;
					case 'n':
						if (name == "Phantom")
						{
							value = ELogModule.Phantom;
							return true;
						}
						break;
					case 'o':
						if (name == "UiModel")
						{
							value = ELogModule.UiModel;
							return true;
						}
						if (name == "KuroSdk")
						{
							value = ELogModule.KuroSdk;
							return true;
						}
						break;
					case 'p':
						if (name == "Compose")
						{
							value = ELogModule.Compose;
							return true;
						}
						break;
					case 'q':
						if (name == "Marquee")
						{
							value = ELogModule.Marquee;
							return true;
						}
						break;
					case 'r':
						if (name == "Sheriff")
						{
							value = ELogModule.Sheriff;
							return true;
						}
						break;
					case 't':
						if (name == "Weather")
						{
							value = ELogModule.Weather;
							return true;
						}
						break;
					}
				}
				else if (name == "HudUnit")
				{
					value = ELogModule.HudUnit;
					return true;
				}
				break;
			}
			case 8:
			{
				char c = name[4];
				if (c <= 'I')
				{
					if (c != 'B')
					{
						if (c != 'H')
						{
							if (c == 'I')
							{
								if (name == "BuffItem")
								{
									value = ELogModule.BuffItem;
									return true;
								}
							}
						}
						else if (name == "ItemHint")
						{
							value = ELogModule.ItemHint;
							return true;
						}
					}
					else if (name == "HandBook")
					{
						value = ELogModule.HandBook;
						return true;
					}
				}
				else if (c != 'M')
				{
					switch (c)
					{
					case 'S':
						if (name == "MingSuTi")
						{
							value = ELogModule.MingSuTi;
							return true;
						}
						if (name == "RoleSkin")
						{
							value = ELogModule.RoleSkin;
							return true;
						}
						if (name == "KingShip")
						{
							value = ELogModule.KingShip;
							return true;
						}
						break;
					case 'T':
						if (name == "DarkTide")
						{
							value = ELogModule.DarkTide;
							return true;
						}
						break;
					case 'U':
						if (name == "TextUtil")
						{
							value = ELogModule.TextUtil;
							return true;
						}
						if (name == "SaveUtil")
						{
							value = ELogModule.SaveUtil;
							return true;
						}
						if (name == "TimeUtil")
						{
							value = ELogModule.TimeUtil;
							return true;
						}
						if (name == "LguiUtil")
						{
							value = ELogModule.LguiUtil;
							return true;
						}
						break;
					default:
						switch (c)
						{
						case 'a':
							if (name == "HotPatch")
							{
								value = ELogModule.HotPatch;
								return true;
							}
							break;
						case 'b':
							if (name == "Calabash")
							{
								value = ELogModule.Calabash;
								return true;
							}
							break;
						case 'e':
							if (name == "RenderGI")
							{
								value = ELogModule.RenderGI;
								return true;
							}
							break;
						case 'f':
							if (name == "Platform")
							{
								value = ELogModule.Platform;
								return true;
							}
							break;
						case 'i':
							if (name == "UiEditor")
							{
								value = ELogModule.UiEditor;
								return true;
							}
							if (name == "BpBridge")
							{
								value = ELogModule.BpBridge;
								return true;
							}
							break;
						case 'l':
							if (name == "PanelQte")
							{
								value = ELogModule.PanelQte;
								return true;
							}
							break;
						case 'm':
							if (name == "UiCommon")
							{
								value = ELogModule.UiCommon;
								return true;
							}
							if (name == "UiCamera")
							{
								value = ELogModule.UiCamera;
								return true;
							}
							if (name == "Movement")
							{
								value = ELogModule.Movement;
								return true;
							}
							break;
						case 'n':
							if (name == "Spring25")
							{
								value = ELogModule.Spring25;
								return true;
							}
							break;
						case 'o':
							if (name == "Personal")
							{
								value = ELogModule.Personal;
								return true;
							}
							break;
						case 'p':
							if (name == "Teleport")
							{
								value = ELogModule.Teleport;
								return true;
							}
							break;
						case 'r':
							if (name == "Tutorial")
							{
								value = ELogModule.Tutorial;
								return true;
							}
							if (name == "Recorder")
							{
								value = ELogModule.Recorder;
								return true;
							}
							if (name == "Encircle")
							{
								value = ELogModule.Encircle;
								return true;
							}
							break;
						case 't':
							if (name == "Kurotato")
							{
								value = ELogModule.Kurotato;
								return true;
							}
							break;
						case 'u':
							if (name == "Resource")
							{
								value = ELogModule.Resource;
								return true;
							}
							if (name == "IosAudit")
							{
								value = ELogModule.IosAudit;
								return true;
							}
							break;
						case 'v':
							if (name == "Activity")
							{
								value = ELogModule.Activity;
								return true;
							}
							break;
						case 'y':
							if (name == "Dockyard")
							{
								value = ELogModule.Dockyard;
								return true;
							}
							break;
						}
						break;
					}
				}
				else if (name == "GameMode")
				{
					value = ELogModule.GameMode;
					return true;
				}
				break;
			}
			case 9:
			{
				char c = name[5];
				if (c != '3')
				{
					switch (c)
					{
					case 'C':
						if (name == "ErrorCode")
						{
							value = ELogModule.ErrorCode;
							return true;
						}
						break;
					case 'D':
					case 'E':
					case 'J':
					case 'K':
					case 'N':
					case 'O':
					case 'Q':
					case 'R':
						break;
					case 'F':
						if (name == "LevelFlow")
						{
							value = ELogModule.LevelFlow;
							return true;
						}
						break;
					case 'G':
						if (name == "CloudGame")
						{
							value = ELogModule.CloudGame;
							return true;
						}
						break;
					case 'H':
						if (name == "QuickHack")
						{
							value = ELogModule.QuickHack;
							return true;
						}
						break;
					case 'I':
						if (name == "SceneItem")
						{
							value = ELogModule.SceneItem;
							return true;
						}
						break;
					case 'L':
						if (name == "DreamLink")
						{
							value = ELogModule.DreamLink;
							return true;
						}
						break;
					case 'M':
						if (name == "MovieMode")
						{
							value = ELogModule.MovieMode;
							return true;
						}
						break;
					case 'P':
						if (name == "LevelPlay")
						{
							value = ELogModule.LevelPlay;
							return true;
						}
						break;
					case 'S':
						if (name == "SceneStep")
						{
							value = ELogModule.SceneStep;
							return true;
						}
						break;
					case 'T':
						if (name == "SceneTeam")
						{
							value = ELogModule.SceneTeam;
							return true;
						}
						if (name == "QuestTree")
						{
							value = ELogModule.QuestTree;
							return true;
						}
						break;
					case 'U':
						if (name == "ModelUtil")
						{
							value = ELogModule.ModelUtil;
							return true;
						}
						break;
					case 'V':
						if (name == "DebugView")
						{
							value = ELogModule.DebugView;
							return true;
						}
						break;
					default:
						switch (c)
						{
						case 'a':
							if (name == "UiManager")
							{
								value = ELogModule.UiManager;
								return true;
							}
							if (name == "Panoramic")
							{
								value = ELogModule.Panoramic;
								return true;
							}
							if (name == "DropCatch")
							{
								value = ELogModule.DropCatch;
								return true;
							}
							break;
						case 'b':
							if (name == "Heartbeat")
							{
								value = ELogModule.Heartbeat;
								return true;
							}
							break;
						case 'c':
							if (name == "Character")
							{
								value = ELogModule.Character;
								return true;
							}
							break;
						case 'f':
							if (name == "TimeOfDay")
							{
								value = ELogModule.TimeOfDay;
								return true;
							}
							break;
						case 'i':
							if (name == "Container")
							{
								value = ELogModule.Container;
								return true;
							}
							if (name == "AutoPilot")
							{
								value = ELogModule.AutoPilot;
								return true;
							}
							if (name == "SunSpirit")
							{
								value = ELogModule.SunSpirit;
								return true;
							}
							break;
						case 'l':
							if (name == "Roguelike")
							{
								value = ELogModule.Roguelike;
								return true;
							}
							if (name == "LogUpload")
							{
								value = ELogModule.LogUpload;
								return true;
							}
							if (name == "RollBlock")
							{
								value = ELogModule.RollBlock;
								return true;
							}
							if (name == "Roverlike")
							{
								value = ELogModule.Roverlike;
								return true;
							}
							break;
						case 'n':
							if (name == "Reconnect")
							{
								value = ELogModule.Reconnect;
								return true;
							}
							if (name == "CommonQte")
							{
								value = ELogModule.CommonQte;
								return true;
							}
							break;
						case 'o':
							if (name == "ShipTower")
							{
								value = ELogModule.ShipTower;
								return true;
							}
							break;
						case 'p':
							if (name == "LogReport")
							{
								value = ELogModule.LogReport;
								return true;
							}
							break;
						case 'r':
							if (name == "TaskGraph")
							{
								value = ELogModule.TaskGraph;
								return true;
							}
							break;
						case 't':
							if (name == "Formation")
							{
								value = ELogModule.Formation;
								return true;
							}
							if (name == "Inventory")
							{
								value = ELogModule.Inventory;
								return true;
							}
							break;
						}
						break;
					}
				}
				else if (name == "Scene3dUi")
				{
					value = ELogModule.Scene3dUi;
					return true;
				}
				break;
			}
			case 10:
			{
				char c = name[5];
				if (c <= 'E')
				{
					if (c != 'B')
					{
						if (c == 'E')
						{
							if (name == "LevelEvent")
							{
								value = ELogModule.LevelEvent;
								return true;
							}
						}
					}
					else if (name == "DangoBrawl")
					{
						value = ELogModule.DangoBrawl;
						return true;
					}
				}
				else
				{
					switch (c)
					{
					case 'L':
						if (name == "WorldLevel")
						{
							value = ELogModule.WorldLevel;
							return true;
						}
						break;
					case 'M':
						if (name == "WuYinModel")
						{
							value = ELogModule.WuYinModel;
							return true;
						}
						break;
					case 'N':
					case 'O':
					case 'P':
					case 'Q':
						break;
					case 'R':
						if (name == "FloroRanch")
						{
							value = ELogModule.FloroRanch;
							return true;
						}
						break;
					case 'S':
						if (name == "SolarSpeed")
						{
							value = ELogModule.SolarSpeed;
							return true;
						}
						break;
					case 'T':
						if (name == "CycleTower")
						{
							value = ELogModule.CycleTower;
							return true;
						}
						if (name == "PilotThrow")
						{
							value = ELogModule.PilotThrow;
							return true;
						}
						if (name == "WheelTower")
						{
							value = ELogModule.WheelTower;
							return true;
						}
						if (name == "MatchThree")
						{
							value = ELogModule.MatchThree;
							return true;
						}
						break;
					default:
						switch (c)
						{
						case 'a':
							if (name == "Decoration")
							{
								value = ELogModule.Decoration;
								return true;
							}
							break;
						case 'c':
							if (name == "PublicUtil")
							{
								value = ELogModule.PublicUtil;
								return true;
							}
							break;
						case 'd':
							if (name == "RewardItem")
							{
								value = ELogModule.RewardItem;
								return true;
							}
							break;
						case 'e':
							if (name == "ModuleUtil")
							{
								value = ELogModule.ModuleUtil;
								return true;
							}
							break;
						case 'g':
							if (name == "MowingRisk")
							{
								value = ELogModule.MowingRisk;
								return true;
							}
							if (name == "RacingBets")
							{
								value = ELogModule.RacingBets;
								return true;
							}
							if (name == "Photograph")
							{
								value = ELogModule.Photograph;
								return true;
							}
							break;
						case 'i':
							if (name == "Functional")
							{
								value = ELogModule.Functional;
								return true;
							}
							if (name == "BossPiling")
							{
								value = ELogModule.BossPiling;
								return true;
							}
							if (name == "Capability")
							{
								value = ELogModule.Capability;
								return true;
							}
							break;
						case 'm':
							if (name == "RhythmGame")
							{
								value = ELogModule.RhythmGame;
								return true;
							}
							break;
						case 'n':
							if (name == "WeaponSkin")
							{
								value = ELogModule.WeaponSkin;
								return true;
							}
							break;
						case 'o':
							if (name == "Controller")
							{
								value = ELogModule.Controller;
								return true;
							}
							if (name == "AnimNotify")
							{
								value = ELogModule.AnimNotify;
								return true;
							}
							break;
						case 'p':
							if (name == "Perception")
							{
								value = ELogModule.Perception;
								return true;
							}
							break;
						case 'r':
							if (name == "ConfirmBox")
							{
								value = ELogModule.ConfirmBox;
								return true;
							}
							if (name == "RenderUtil")
							{
								value = ELogModule.RenderUtil;
								return true;
							}
							break;
						case 't':
							if (name == "CombatInfo")
							{
								value = ELogModule.CombatInfo;
								return true;
							}
							if (name == "MeshStream")
							{
								value = ELogModule.MeshStream;
								return true;
							}
							break;
						}
						break;
					}
				}
				break;
			}
			case 11:
			{
				char c = name[4];
				if (c <= 'D')
				{
					if (c != 'C')
					{
						if (c == 'D')
						{
							if (name == "InfoDisplay")
							{
								value = ELogModule.InfoDisplay;
								return true;
							}
						}
					}
					else if (name == "MoonChasing")
					{
						value = ELogModule.MoonChasing;
						return true;
					}
				}
				else if (c != 'H')
				{
					if (c != 'P')
					{
						switch (c)
						{
						case 'a':
							if (name == "VillageInfr")
							{
								value = ELogModule.VillageInfr;
								return true;
							}
							break;
						case 'b':
							if (name == "UiTabModule")
							{
								value = ELogModule.UiTabModule;
								return true;
							}
							break;
						case 'c':
							if (name == "CiacconaGal")
							{
								value = ELogModule.CiacconaGal;
								return true;
							}
							break;
						case 'e':
							if (name == "RenderScene")
							{
								value = ELogModule.RenderScene;
								return true;
							}
							if (name == "ElementBall")
							{
								value = ELogModule.ElementBall;
								return true;
							}
							if (name == "Achievement")
							{
								value = ELogModule.Achievement;
								return true;
							}
							if (name == "RogueBattle")
							{
								value = ELogModule.RogueBattle;
								return true;
							}
							if (name == "PhoneSystem")
							{
								value = ELogModule.PhoneSystem;
								return true;
							}
							break;
						case 'f':
							if (name == "PlatformSdk")
							{
								value = ELogModule.PlatformSdk;
								return true;
							}
							break;
						case 'g':
							if (name == "ChargeSlash")
							{
								value = ELogModule.ChargeSlash;
								return true;
							}
							break;
						case 'h':
							if (name == "TouchUiEdit")
							{
								value = ELogModule.TouchUiEdit;
								return true;
							}
							break;
						case 'i':
							if (name == "UiAnimation")
							{
								value = ELogModule.UiAnimation;
								return true;
							}
							break;
						case 'k':
							if (name == "BlackScreen")
							{
								value = ELogModule.BlackScreen;
								return true;
							}
							break;
						case 'l':
							if (name == "BattleUiSet")
							{
								value = ELogModule.BattleUiSet;
								return true;
							}
							if (name == "WeeklyRogue")
							{
								value = ELogModule.WeeklyRogue;
								return true;
							}
							break;
						case 'm':
							if (name == "UiComponent")
							{
								value = ELogModule.UiComponent;
								return true;
							}
							if (name == "HonamiStory")
							{
								value = ELogModule.HonamiStory;
								return true;
							}
							break;
						case 'n':
							if (name == "TuningStand")
							{
								value = ELogModule.TuningStand;
								return true;
							}
							if (name == "SpringManor")
							{
								value = ELogModule.SpringManor;
								return true;
							}
							break;
						case 'o':
							if (name == "Performance")
							{
								value = ELogModule.Performance;
								return true;
							}
							if (name == "AndroidBack")
							{
								value = ELogModule.AndroidBack;
								return true;
							}
							if (name == "PhotoCamera")
							{
								value = ELogModule.PhotoCamera;
								return true;
							}
							break;
						case 'r':
							if (name == "ExportProto")
							{
								value = ELogModule.ExportProto;
								return true;
							}
							if (name == "PowerModule")
							{
								value = ELogModule.PowerModule;
								return true;
							}
							if (name == "Interaction")
							{
								value = ELogModule.Interaction;
								return true;
							}
							if (name == "ActorSystem")
							{
								value = ELogModule.ActorSystem;
								return true;
							}
							break;
						case 't':
							if (name == "QuestRecall")
							{
								value = ELogModule.QuestRecall;
								return true;
							}
							break;
						case 'y':
							if (name == "UiAsyncTask")
							{
								value = ELogModule.UiAsyncTask;
								return true;
							}
							break;
						}
					}
					else if (name == "BasePerform")
					{
						value = ELogModule.BasePerform;
						return true;
					}
				}
				else if (name == "PerfHeatmap")
				{
					value = ELogModule.PerfHeatmap;
					return true;
				}
				break;
			}
			case 12:
			{
				char c = name[8];
				switch (c)
				{
				case 'L':
					if (name == "UiPrefabLoad")
					{
						value = ELogModule.UiPrefabLoad;
						return true;
					}
					break;
				case 'M':
					if (name == "TeleportMisc")
					{
						value = ELogModule.TeleportMisc;
						return true;
					}
					break;
				case 'N':
				case 'O':
				case 'P':
				case 'Q':
					break;
				case 'R':
					if (name == "DarkTideRing")
					{
						value = ELogModule.DarkTideRing;
						return true;
					}
					break;
				case 'S':
					if (name == "CalabashSkin")
					{
						value = ELogModule.CalabashSkin;
						return true;
					}
					break;
				case 'T':
					if (name == "BehaviorTree")
					{
						value = ELogModule.BehaviorTree;
						return true;
					}
					break;
				default:
					switch (c)
					{
					case 'a':
						if (name == "InputManager")
						{
							value = ELogModule.InputManager;
							return true;
						}
						if (name == "ItemExchange")
						{
							value = ELogModule.ItemExchange;
							return true;
						}
						break;
					case 'c':
						if (name == "CollectActor")
						{
							value = ELogModule.CollectActor;
							return true;
						}
						break;
					case 'e':
						if (name == "TowerDefense")
						{
							value = ELogModule.TowerDefense;
							return true;
						}
						if (name == "ExploreLevel")
						{
							value = ELogModule.ExploreLevel;
							return true;
						}
						break;
					case 'f':
						if (name == "RenderEffect")
						{
							value = ELogModule.RenderEffect;
							return true;
						}
						break;
					case 'g':
						if (name == "GridDelegate")
						{
							value = ELogModule.GridDelegate;
							return true;
						}
						break;
					case 'h':
						if (name == "StateMachine")
						{
							value = ELogModule.StateMachine;
							return true;
						}
						break;
					case 'i':
						if (name == "GameSettings")
						{
							value = ELogModule.GameSettings;
							return true;
						}
						break;
					case 'k':
						if (name == "MotorParkour")
						{
							value = ELogModule.MotorParkour;
							return true;
						}
						if (name == "GolemHacking")
						{
							value = ELogModule.GolemHacking;
							return true;
						}
						break;
					case 'm':
						if (name == "RoleOrnament")
						{
							value = ELogModule.RoleOrnament;
							return true;
						}
						break;
					case 'o':
						if (name == "UiModelMorph")
						{
							value = ELogModule.UiModelMorph;
							return true;
						}
						break;
					case 'r':
						if (name == "LocalStorage")
						{
							value = ELogModule.LocalStorage;
							return true;
						}
						if (name == "PhantomArena")
						{
							value = ELogModule.PhantomArena;
							return true;
						}
						break;
					case 't':
						if (name == "RenderBattle")
						{
							value = ELogModule.RenderBattle;
							return true;
						}
						if (name == "UiNavigation")
						{
							value = ELogModule.UiNavigation;
							return true;
						}
						if (name == "Optimization")
						{
							value = ELogModule.Optimization;
							return true;
						}
						if (name == "TimeDilation")
						{
							value = ELogModule.TimeDilation;
							return true;
						}
						break;
					case 'w':
						if (name == "InviteNewbie")
						{
							value = ELogModule.InviteNewbie;
							return true;
						}
						break;
					}
					break;
				}
				break;
			}
			case 13:
			{
				char c = name[4];
				if (c <= 'T')
				{
					if (c != 'C')
					{
						if (c != 'I')
						{
							switch (c)
							{
							case 'P':
								if (name == "GamePlayTimer")
								{
									value = ELogModule.GamePlayTimer;
									return true;
								}
								break;
							case 'R':
								if (name == "RoleResonance")
								{
									value = ELogModule.RoleResonance;
									return true;
								}
								break;
							case 'T':
								if (name == "DataTableUtil")
								{
									value = ELogModule.DataTableUtil;
									return true;
								}
								break;
							}
						}
						else if (name == "SkipInterface")
						{
							value = ELogModule.SkipInterface;
							return true;
						}
					}
					else
					{
						if (name == "PlotContainer")
						{
							value = ELogModule.PlotContainer;
							return true;
						}
						if (name == "FlagChallenge")
						{
							value = ELogModule.FlagChallenge;
							return true;
						}
					}
				}
				else if (c <= 'l')
				{
					switch (c)
					{
					case 'a':
						if (name == "PinballBattle")
						{
							value = ELogModule.PinballBattle;
							return true;
						}
						break;
					case 'b':
					case 'd':
					case 'f':
					case 'h':
						break;
					case 'c':
						if (name == "VehicleStream")
						{
							value = ELogModule.VehicleStream;
							return true;
						}
						break;
					case 'e':
						if (name == "SceneGameplay")
						{
							value = ELogModule.SceneGameplay;
							return true;
						}
						if (name == "ServerStorage")
						{
							value = ELogModule.ServerStorage;
							return true;
						}
						break;
					case 'g':
						if (name == "TriggerVolume")
						{
							value = ELogModule.TriggerVolume;
							return true;
						}
						break;
					case 'i':
						if (name == "SlidingBlocks")
						{
							value = ELogModule.SlidingBlocks;
							return true;
						}
						break;
					default:
						if (c == 'l')
						{
							if (name == "LevelListener")
							{
								value = ELogModule.LevelListener;
								return true;
							}
						}
						break;
					}
				}
				else
				{
					switch (c)
					{
					case 'o':
						if (name == "ComboTeaching")
						{
							value = ELogModule.ComboTeaching;
							return true;
						}
						if (name == "DangoMonopoly")
						{
							value = ELogModule.DangoMonopoly;
							return true;
						}
						if (name == "ComboTimeline")
						{
							value = ELogModule.ComboTimeline;
							return true;
						}
						break;
					case 'p':
					case 'q':
					case 's':
						break;
					case 'r':
						if (name == "GenericPrompt")
						{
							value = ELogModule.GenericPrompt;
							return true;
						}
						if (name == "ControlScreen")
						{
							value = ELogModule.ControlScreen;
							return true;
						}
						if (name == "MotorRailMove")
						{
							value = ELogModule.MotorRailMove;
							return true;
						}
						break;
					case 't':
						if (name == "InputSettings")
						{
							value = ELogModule.InputSettings;
							return true;
						}
						if (name == "QuestResource")
						{
							value = ELogModule.QuestResource;
							return true;
						}
						if (name == "ScratchTicket")
						{
							value = ELogModule.ScratchTicket;
							return true;
						}
						break;
					case 'u':
						if (name == "ResourceCheck")
						{
							value = ELogModule.ResourceCheck;
							return true;
						}
						break;
					default:
						if (c == 'y')
						{
							if (name == "DailyActivity")
							{
								value = ELogModule.DailyActivity;
								return true;
							}
						}
						break;
					}
				}
				break;
			}
			case 14:
			{
				char c = name[10];
				if (c <= 'P')
				{
					if (c <= 'G')
					{
						if (c != 'C')
						{
							if (c == 'G')
							{
								if (name == "ScrollViewGrid")
								{
									value = ELogModule.ScrollViewGrid;
									return true;
								}
							}
						}
						else if (name == "GuessJokerCard")
						{
							value = ELogModule.GuessJokerCard;
							return true;
						}
					}
					else if (c != 'L')
					{
						if (c == 'P')
						{
							if (name == "PortalGamePlay")
							{
								value = ELogModule.PortalGamePlay;
								return true;
							}
						}
					}
					else if (name == "QuestMultiLine")
					{
						value = ELogModule.QuestMultiLine;
						return true;
					}
				}
				else if (c <= 'a')
				{
					if (c != 'V')
					{
						if (c == 'a')
						{
							if (name == "UiSceneManager")
							{
								value = ELogModule.UiSceneManager;
								return true;
							}
							if (name == "SeamlessTravel")
							{
								value = ELogModule.SeamlessTravel;
								return true;
							}
						}
					}
					else
					{
						if (name == "LoopScrollView")
						{
							value = ELogModule.LoopScrollView;
							return true;
						}
						if (name == "FilterSortView")
						{
							value = ELogModule.FilterSortView;
							return true;
						}
					}
				}
				else
				{
					switch (c)
					{
					case 'h':
						if (name == "VersionPreheat")
						{
							value = ELogModule.VersionPreheat;
							return true;
						}
						break;
					case 'i':
						if (name == "StackContainer")
						{
							value = ELogModule.StackContainer;
							return true;
						}
						break;
					case 'j':
					case 'k':
					case 'n':
						break;
					case 'l':
						if (name == "TickController")
						{
							value = ELogModule.TickController;
							return true;
						}
						break;
					case 'm':
						if (name == "FragmentMemory")
						{
							value = ELogModule.FragmentMemory;
							return true;
						}
						break;
					case 'o':
						if (name == "SurvivorsRogue")
						{
							value = ELogModule.SurvivorsRogue;
							return true;
						}
						break;
					default:
						if (c != 't')
						{
							if (c == 'u')
							{
								if (name == "AdventureGuide")
								{
									value = ELogModule.AdventureGuide;
									return true;
								}
							}
						}
						else
						{
							if (name == "LevelCondition")
							{
								value = ELogModule.LevelCondition;
								return true;
							}
							if (name == "UiTimeDilation")
							{
								value = ELogModule.UiTimeDilation;
								return true;
							}
							if (name == "UiImageSetting")
							{
								value = ELogModule.UiImageSetting;
								return true;
							}
							if (name == "Infrastructure")
							{
								value = ELogModule.Infrastructure;
								return true;
							}
						}
						break;
					}
				}
				break;
			}
			case 15:
			{
				char c = name[6];
				if (c <= 'W')
				{
					switch (c)
					{
					case 'A':
						if (name == "CameraAnimation")
						{
							value = ELogModule.CameraAnimation;
							return true;
						}
						break;
					case 'B':
					case 'E':
					case 'F':
						break;
					case 'C':
						if (name == "RenderCharacter")
						{
							value = ELogModule.RenderCharacter;
							return true;
						}
						if (name == "CreateCharacter")
						{
							value = ELogModule.CreateCharacter;
							return true;
						}
						if (name == "UiViewContainer")
						{
							value = ELogModule.UiViewContainer;
							return true;
						}
						if (name == "WeeklyChallenge")
						{
							value = ELogModule.WeeklyChallenge;
							return true;
						}
						break;
					case 'D':
						if (name == "CommonDbConnect")
						{
							value = ELogModule.CommonDbConnect;
							return true;
						}
						break;
					case 'G':
						if (name == "SummonGongduola")
						{
							value = ELogModule.SummonGongduola;
							return true;
						}
						break;
					default:
						if (c == 'W')
						{
							if (name == "FilterWithState")
							{
								value = ELogModule.FilterWithState;
								return true;
							}
						}
						break;
					}
				}
				else
				{
					switch (c)
					{
					case 'a':
						if (name == "DollGrabMachine")
						{
							value = ELogModule.DollGrabMachine;
							return true;
						}
						break;
					case 'b':
					case 'd':
					case 'f':
					case 'g':
					case 'j':
					case 'k':
					case 'm':
						break;
					case 'c':
						if (name == "InstanceDungeon")
						{
							value = ELogModule.InstanceDungeon;
							return true;
						}
						break;
					case 'e':
						if (name == "ExploreProgress")
						{
							value = ELogModule.ExploreProgress;
							return true;
						}
						break;
					case 'h':
						if (name == "FightPhotograph")
						{
							value = ELogModule.FightPhotograph;
							return true;
						}
						break;
					case 'i':
						if (name == "PathDrivenActor")
						{
							value = ELogModule.PathDrivenActor;
							return true;
						}
						break;
					case 'l':
						if (name == "MultiPlayerTeam")
						{
							value = ELogModule.MultiPlayerTeam;
							return true;
						}
						if (name == "LevelPlayReport")
						{
							value = ELogModule.LevelPlayReport;
							return true;
						}
						break;
					case 'n':
						if (name == "ResonanceEffect")
						{
							value = ELogModule.ResonanceEffect;
							return true;
						}
						break;
					case 'o':
						if (name == "ProtocolMonitor")
						{
							value = ELogModule.ProtocolMonitor;
							return true;
						}
						break;
					case 'p':
						if (name == "TermExplanation")
						{
							value = ELogModule.TermExplanation;
							return true;
						}
						break;
					default:
						if (c == 't')
						{
							if (name == "ActivityRegress")
							{
								value = ELogModule.ActivityRegress;
								return true;
							}
							if (name == "ActivityFunPlay")
							{
								value = ELogModule.ActivityFunPlay;
								return true;
							}
							if (name == "ActivityPreWarm")
							{
								value = ELogModule.ActivityPreWarm;
								return true;
							}
							if (name == "ProjectorPuzzle")
							{
								value = ELogModule.ProjectorPuzzle;
								return true;
							}
						}
						break;
					}
				}
				break;
			}
			case 16:
			{
				char c = name[9];
				if (c <= 'g')
				{
					if (c != 'M')
					{
						switch (c)
						{
						case 'd':
							if (name == "IllegalCodeCheck")
							{
								value = ELogModule.IllegalCodeCheck;
								return true;
							}
							break;
						case 'e':
							if (name == "SplashScreenTask")
							{
								value = ELogModule.SplashScreenTask;
								return true;
							}
							break;
						case 'g':
							if (name == "GeneralLogicTree")
							{
								value = ELogModule.GeneralLogicTree;
								return true;
							}
							break;
						}
					}
					else if (name == "FrequencyMonitor")
					{
						value = ELogModule.FrequencyMonitor;
						return true;
					}
				}
				else if (c != 'l')
				{
					if (c != 'n')
					{
						if (c == 'y')
						{
							if (name == "GenericLayoutNew")
							{
								value = ELogModule.GenericLayoutNew;
								return true;
							}
						}
					}
					else if (name == "UiFloatContainer")
					{
						value = ELogModule.UiFloatContainer;
						return true;
					}
				}
				else if (name == "UiSceneRoleActor")
				{
					value = ELogModule.UiSceneRoleActor;
					return true;
				}
				break;
			}
			case 17:
			{
				char c = name[8];
				switch (c)
				{
				case 'a':
					if (name == "DynamicMaskButton")
					{
						value = ELogModule.DynamicMaskButton;
						return true;
					}
					break;
				case 'b':
				case 'c':
					break;
				case 'd':
					if (name == "PsGamepadFeedback")
					{
						value = ELogModule.PsGamepadFeedback;
						return true;
					}
					break;
				case 'e':
					if (name == "TowerDefenseEvent")
					{
						value = ELogModule.TowerDefenseEvent;
						return true;
					}
					break;
				default:
					switch (c)
					{
					case 'n':
						if (name == "MusicalInstrument")
						{
							value = ELogModule.MusicalInstrument;
							return true;
						}
						break;
					case 'o':
					case 'q':
					case 'r':
						break;
					case 'p':
						if (name == "MobileInputSwitch")
						{
							value = ELogModule.MobileInputSwitch;
							return true;
						}
						break;
					case 's':
						if (name == "ShortKeysExitView")
						{
							value = ELogModule.ShortKeysExitView;
							return true;
						}
						break;
					case 't':
						if (name == "RacingBetsDungeon")
						{
							value = ELogModule.RacingBetsDungeon;
							return true;
						}
						break;
					case 'u':
						if (name == "ManufactureCommon")
						{
							value = ELogModule.ManufactureCommon;
							return true;
						}
						break;
					default:
						if (c == 'y')
						{
							if (name == "MultiplayerCombat")
							{
								value = ELogModule.MultiplayerCombat;
								return true;
							}
						}
						break;
					}
					break;
				}
				break;
			}
			case 18:
			{
				char c = name[12];
				if (c <= 'S')
				{
					if (c <= 'H')
					{
						if (c != 'B')
						{
							if (c == 'H')
							{
								if (name == "UiNavigationHotKey")
								{
									value = ELogModule.UiNavigationHotKey;
									return true;
								}
							}
						}
						else if (name == "TowerDefenseBattle")
						{
							value = ELogModule.TowerDefenseBattle;
							return true;
						}
					}
					else if (c != 'M')
					{
						if (c == 'S')
						{
							if (name == "TextLanguageSearch")
							{
								value = ELogModule.TextLanguageSearch;
								return true;
							}
						}
					}
					else if (name == "MultiTextCsvModule")
					{
						value = ELogModule.MultiTextCsvModule;
						return true;
					}
				}
				else if (c <= 'e')
				{
					if (c != 'a')
					{
						if (c == 'e')
						{
							if (name == "TsUiSceneRoleActor")
							{
								value = ELogModule.TsUiSceneRoleActor;
								return true;
							}
						}
					}
					else
					{
						if (name == "HotFixSceneManager")
						{
							value = ELogModule.HotFixSceneManager;
							return true;
						}
						if (name == "PhantomInteraction")
						{
							value = ELogModule.PhantomInteraction;
							return true;
						}
					}
				}
				else
				{
					switch (c)
					{
					case 'i':
						if (name == "CommonGameMainView")
						{
							value = ELogModule.CommonGameMainView;
							return true;
						}
						break;
					case 'j':
					case 'k':
						break;
					case 'l':
						if (name == "ActivityTotalTopUp")
						{
							value = ELogModule.ActivityTotalTopUp;
							return true;
						}
						break;
					case 'm':
						if (name == "FloroRanchGamePlay")
						{
							value = ELogModule.FloroRanchGamePlay;
							return true;
						}
						break;
					default:
						if (c != 't')
						{
							if (c == 'w')
							{
								if (name == "SubPackageDownLoad")
								{
									value = ELogModule.SubPackageDownLoad;
									return true;
								}
							}
						}
						else if (name == "MotorFightActivity")
						{
							value = ELogModule.MotorFightActivity;
							return true;
						}
						break;
					}
				}
				break;
			}
			case 19:
			{
				char c = name[0];
				if (c <= 'I')
				{
					if (c != 'A')
					{
						if (c != 'G')
						{
							if (c == 'I')
							{
								if (name == "InfluenceReputation")
								{
									value = ELogModule.InfluenceReputation;
									return true;
								}
							}
						}
						else if (name == "GachaSequencePlayer")
						{
							value = ELogModule.GachaSequencePlayer;
							return true;
						}
					}
					else if (name == "ActivityDirectTrain")
					{
						value = ELogModule.ActivityDirectTrain;
						return true;
					}
				}
				else if (c != 'L')
				{
					if (c != 'R')
					{
						if (c == 'U')
						{
							if (name == "UiLoginSceneManager")
							{
								value = ELogModule.UiLoginSceneManager;
								return true;
							}
						}
					}
					else if (name == "ResponsibilityChain")
					{
						value = ELogModule.ResponsibilityChain;
						return true;
					}
				}
				else if (name == "LevelSequencePlayer")
				{
					value = ELogModule.LevelSequencePlayer;
					return true;
				}
				break;
			}
			case 21:
				switch (name[0])
				{
				case 'S':
					if (name == "SceneItemCurveControl")
					{
						value = ELogModule.SceneItemCurveControl;
						return true;
					}
					break;
				case 'T':
					if (name == "TemplateEntitySpawner")
					{
						value = ELogModule.TemplateEntitySpawner;
						return true;
					}
					break;
				case 'U':
					if (name == "UiTickConditionModule")
					{
						value = ELogModule.UiTickConditionModule;
						return true;
					}
					break;
				}
				break;
			case 22:
			{
				char c = name[0];
				if (c != 'L')
				{
					if (c == 'M')
					{
						if (name == "MultiTemplateComponent")
						{
							value = ELogModule.MultiTemplateComponent;
							return true;
						}
					}
				}
				else if (name == "LevelConditionRegistry")
				{
					value = ELogModule.LevelConditionRegistry;
					return true;
				}
				break;
			}
			case 23:
			{
				char c = name[0];
				if (c != 'M')
				{
					if (c == 'U')
					{
						if (name == "UiModelResourcesManager")
						{
							value = ELogModule.UiModelResourcesManager;
							return true;
						}
					}
				}
				else if (name == "MultiTemplateScrollView")
				{
					value = ELogModule.MultiTemplateScrollView;
					return true;
				}
				break;
			}
			case 24:
				if (name == "LevelExperienceComponent")
				{
					value = ELogModule.LevelExperienceComponent;
					return true;
				}
				break;
			}
		}
		value = ELogModule.Engine;
		return false;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00008B70 File Offset: 0x00006D70
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"Engine",
			"UiEditor",
			"ResourceCheck",
			"IllegalCodeCheck",
			"Temp",
			"HotPatch",
			"Log",
			"ExportProto",
			"Core",
			"Entity",
			"Event",
			"Json",
			"P4",
			"Config",
			"CommonDbConnect",
			"Pool",
			"Container",
			"UiCore",
			"Net",
			"Object",
			"Resource",
			"Tick",
			"Timer",
			"Game",
			"Render",
			"Preload",
			"StateMachine",
			"BehaviorTree",
			"Camera",
			"Character",
			"TextUtil",
			"Input",
			"InputSettings",
			"Level",
			"Audio",
			"Battle",
			"UiModel",
			"UiModelMorph",
			"BpBridge",
			"TaskGraph",
			"UiCommon",
			"ConfirmBox",
			"UiTabModule",
			"SceneTeam",
			"MultiPlayerTeam",
			"Formation",
			"DarkTide",
			"DarkTideRing",
			"ErrorCode",
			"Functional",
			"Gm",
			"Guide",
			"Inventory",
			"Item",
			"ItemHint",
			"LevelUp",
			"Login",
			"Mail",
			"Map",
			"MingSuTi",
			"Phantom",
			"Reconnect",
			"Reward",
			"RewardItem",
			"Role",
			"Personal",
			"Shop",
			"Tape",
			"UiCamera",
			"CameraAnimation",
			"UiComponent",
			"ModuleUtil",
			"Weapon",
			"Bullet",
			"Pawn",
			"SceneItem",
			"RenderCharacter",
			"RenderBattle",
			"RenderEffect",
			"RenderGI",
			"RenderScene",
			"RenderUtil",
			"World",
			"GameMode",
			"Movement",
			"Test",
			"LevelExperienceComponent",
			"LoopScrollView",
			"ScrollViewGrid",
			"LevelSequencePlayer",
			"GachaSequencePlayer",
			"UiSceneRoleActor",
			"CreateCharacter",
			"TimeOfDay",
			"ModelUtil",
			"Editor",
			"AI",
			"LevelAi",
			"PowerModule",
			"WorldLevel",
			"TriggerVolume",
			"GenericPrompt",
			"SceneGameplay",
			"SceneStep",
			"InstanceDungeon",
			"Quest",
			"QuestResource",
			"QuestRecall",
			"LevelPlay",
			"WuYinModel",
			"ControlScreen",
			"BuffItem",
			"Marquee",
			"Plot",
			"KuroSdk",
			"ResonanceEffect",
			"RoleResonance",
			"RedDot",
			"DebugView",
			"ProtocolMonitor",
			"LevelEvent",
			"LevelCondition",
			"LevelConditionRegistry",
			"UiSceneManager",
			"Loading",
			"GamePlayTimer",
			"Menu",
			"InputManager",
			"UiTimeDilation",
			"UiAnimation",
			"Interaction",
			"SneakUi",
			"CollectActor",
			"Video",
			"Area",
			"ElementBall",
			"Stat",
			"LogReport",
			"SaveUtil",
			"Platform",
			"PlatformSdk",
			"PublicUtil",
			"ShortKeysExitView",
			"MultiplayerCombat",
			"CombatInfo",
			"Controller",
			"FilterSortView",
			"Friend",
			"Cursor",
			"UiNavigation",
			"UiNavigationHotKey",
			"Chat",
			"Track",
			"Performance",
			"GeneralLogicTree",
			"Pay",
			"TimeUtil",
			"Gacha",
			"Calabash",
			"ItemExchange",
			"AdventureGuide",
			"Tutorial",
			"Weather",
			"InfoDisplay",
			"Scene3dUi",
			"LguiUtil",
			"Cook",
			"GenericLayoutNew",
			"UiFloatContainer",
			"InfluenceReputation",
			"HudUnit",
			"CycleTower",
			"TowerDefense",
			"Animal",
			"Recorder",
			"ManufactureCommon",
			"Compose",
			"Forging",
			"UiLoginSceneManager",
			"HotFixSceneManager",
			"Advice",
			"LocalStorage",
			"ServerStorage",
			"HandBook",
			"ActorSystem",
			"UiModelResourcesManager",
			"NPC",
			"BasePerform",
			"Achievement",
			"NewFlag",
			"Heartbeat",
			"UiManager",
			"BattleUiSet",
			"StackContainer",
			"PlotContainer",
			"DataTableUtil",
			"PanelQte",
			"CommonQte",
			"ComboTeaching",
			"Activity",
			"Teleport",
			"TeleportMisc",
			"TextLanguageSearch",
			"UiViewContainer",
			"UiLayer",
			"UiMask",
			"UiImageSetting",
			"UiPrefabLoad",
			"PerfHeatmap",
			"SeamlessTravel",
			"Filter",
			"Sort",
			"UiTickConditionModule",
			"TsUiSceneRoleActor",
			"MultiTextCsvModule",
			"BlackScreen",
			"DynamicMaskButton",
			"Roguelike",
			"RogueBattle",
			"SkipInterface",
			"TickController",
			"ExploreProgress",
			"ExploreLevel",
			"Blur",
			"AndroidBack",
			"CloudGame",
			"FrequencyMonitor",
			"Photo",
			"PhotoCamera",
			"FragmentMemory",
			"Push",
			"LogUpload",
			"Perception",
			"MoonChasing",
			"MowingRisk",
			"VersionPreheat",
			"Spring25",
			"SolarSpeed",
			"InviteNewbie",
			"RacingBets",
			"RacingBetsDungeon",
			"PortalGamePlay",
			"ActivityRegress",
			"Vehicle",
			"ScratchTicket",
			"FloroRanch",
			"FloroRanchGamePlay",
			"GameSettings",
			"MobileInputSwitch",
			"DreamLink",
			"RoleSkin",
			"WeaponSkin",
			"FlySkin",
			"Dockyard",
			"FilterWithState",
			"ResponsibilityChain",
			"LevelPlayReport",
			"ActivityDirectTrain",
			"Optimization",
			"Fishing",
			"ShipTower",
			"UiAsyncTask",
			"WeeklyRogue",
			"Chess",
			"SummonGongduola",
			"CiacconaGal",
			"DangoMonopoly",
			"TermExplanation",
			"SplashScreenTask",
			"PhantomArena",
			"Shower",
			"SceneItemCurveControl",
			"TemplateEntitySpawner",
			"ChargeSlash",
			"Morale",
			"LevelFlow",
			"TimeDilation",
			"KingShip",
			"TuningStand",
			"CommonGameMainView",
			"TowerDefenseEvent",
			"TowerDefenseBattle",
			"TouchUiEdit",
			"PsGamepadFeedback",
			"HonamiStory",
			"AnimNotify",
			"ActivityFunPlay",
			"HomeBtn",
			"DailyActivity",
			"RoleDev",
			"SurvivorsRogue",
			"FightPhotograph",
			"Photograph",
			"MeshStream",
			"CalabashSkin",
			"QuestTree",
			"ActivityPreWarm",
			"LevelListener",
			"MultiTemplateScrollView",
			"GridDelegate",
			"MultiTemplateComponent",
			"SubPackageDownLoad",
			"Infrastructure",
			"VillageInfr",
			"RollBlock",
			"AutoPilot",
			"VehicleStream",
			"Panoramic",
			"Motor",
			"PilotThrow",
			"MovieMode",
			"DeadEye",
			"WheelTower",
			"MotorParkour",
			"MotorRailMove",
			"PhantomInteraction",
			"PhoneSystem",
			"SunSpirit",
			"Encircle",
			"MotorFightActivity",
			"ActivityTotalTopUp",
			"SpringManor",
			"GuessJokerCard",
			"Drinks",
			"DropCatch",
			"RhythmGame",
			"SlidingBlocks",
			"Pinball",
			"RoleOrnament",
			"Decoration",
			"FlagChallenge",
			"BossPiling",
			"PinballBattle",
			"GolemHacking",
			"ProjectorPuzzle",
			"WeeklyChallenge",
			"QuickHack",
			"IosAudit",
			"DollGrabMachine",
			"Roverlike",
			"MusicalInstrument",
			"QuestMultiLine",
			"PathDrivenActor",
			"Capability",
			"Sheriff",
			"DangoBrawl",
			"MatchThree",
			"Giant",
			"WuWaGo",
			"Season",
			"Kurotato",
			"ComboTimeline"
		};
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00009A7E File Offset: 0x00007C7E
	public static ELogModule[] GetValues()
	{
		return new ELogModule[]
		{
			ELogModule.Engine,
			ELogModule.UiEditor,
			ELogModule.ResourceCheck,
			ELogModule.IllegalCodeCheck,
			ELogModule.Temp,
			ELogModule.HotPatch,
			ELogModule.Log,
			ELogModule.ExportProto,
			ELogModule.Core,
			ELogModule.Entity,
			ELogModule.Event,
			ELogModule.Json,
			ELogModule.P4,
			ELogModule.Config,
			ELogModule.CommonDbConnect,
			ELogModule.Pool,
			ELogModule.Container,
			ELogModule.UiCore,
			ELogModule.Net,
			ELogModule.Object,
			ELogModule.Resource,
			ELogModule.Tick,
			ELogModule.Timer,
			ELogModule.Game,
			ELogModule.Render,
			ELogModule.Preload,
			ELogModule.StateMachine,
			ELogModule.BehaviorTree,
			ELogModule.Camera,
			ELogModule.Character,
			ELogModule.TextUtil,
			ELogModule.Input,
			ELogModule.InputSettings,
			ELogModule.Level,
			ELogModule.Audio,
			ELogModule.Battle,
			ELogModule.UiModel,
			ELogModule.UiModelMorph,
			ELogModule.BpBridge,
			ELogModule.TaskGraph,
			ELogModule.UiCommon,
			ELogModule.ConfirmBox,
			ELogModule.UiTabModule,
			ELogModule.SceneTeam,
			ELogModule.MultiPlayerTeam,
			ELogModule.Formation,
			ELogModule.DarkTide,
			ELogModule.DarkTideRing,
			ELogModule.ErrorCode,
			ELogModule.Functional,
			ELogModule.Gm,
			ELogModule.Guide,
			ELogModule.Inventory,
			ELogModule.Item,
			ELogModule.ItemHint,
			ELogModule.LevelUp,
			ELogModule.Login,
			ELogModule.Mail,
			ELogModule.Map,
			ELogModule.MingSuTi,
			ELogModule.Phantom,
			ELogModule.Reconnect,
			ELogModule.Reward,
			ELogModule.RewardItem,
			ELogModule.Role,
			ELogModule.Personal,
			ELogModule.Shop,
			ELogModule.Tape,
			ELogModule.UiCamera,
			ELogModule.CameraAnimation,
			ELogModule.UiComponent,
			ELogModule.ModuleUtil,
			ELogModule.Weapon,
			ELogModule.Bullet,
			ELogModule.Pawn,
			ELogModule.SceneItem,
			ELogModule.RenderCharacter,
			ELogModule.RenderBattle,
			ELogModule.RenderEffect,
			ELogModule.RenderGI,
			ELogModule.RenderScene,
			ELogModule.RenderUtil,
			ELogModule.World,
			ELogModule.GameMode,
			ELogModule.Movement,
			ELogModule.Test,
			ELogModule.LevelExperienceComponent,
			ELogModule.LoopScrollView,
			ELogModule.ScrollViewGrid,
			ELogModule.LevelSequencePlayer,
			ELogModule.GachaSequencePlayer,
			ELogModule.UiSceneRoleActor,
			ELogModule.CreateCharacter,
			ELogModule.TimeOfDay,
			ELogModule.ModelUtil,
			ELogModule.Editor,
			ELogModule.AI,
			ELogModule.LevelAi,
			ELogModule.PowerModule,
			ELogModule.WorldLevel,
			ELogModule.TriggerVolume,
			ELogModule.GenericPrompt,
			ELogModule.SceneGameplay,
			ELogModule.SceneStep,
			ELogModule.InstanceDungeon,
			ELogModule.Quest,
			ELogModule.QuestResource,
			ELogModule.QuestRecall,
			ELogModule.LevelPlay,
			ELogModule.WuYinModel,
			ELogModule.ControlScreen,
			ELogModule.BuffItem,
			ELogModule.Marquee,
			ELogModule.Plot,
			ELogModule.KuroSdk,
			ELogModule.ResonanceEffect,
			ELogModule.RoleResonance,
			ELogModule.RedDot,
			ELogModule.DebugView,
			ELogModule.ProtocolMonitor,
			ELogModule.LevelEvent,
			ELogModule.LevelCondition,
			ELogModule.LevelConditionRegistry,
			ELogModule.UiSceneManager,
			ELogModule.Loading,
			ELogModule.GamePlayTimer,
			ELogModule.Menu,
			ELogModule.InputManager,
			ELogModule.UiTimeDilation,
			ELogModule.UiAnimation,
			ELogModule.Interaction,
			ELogModule.SneakUi,
			ELogModule.CollectActor,
			ELogModule.Video,
			ELogModule.Area,
			ELogModule.ElementBall,
			ELogModule.Stat,
			ELogModule.LogReport,
			ELogModule.SaveUtil,
			ELogModule.Platform,
			ELogModule.PlatformSdk,
			ELogModule.PublicUtil,
			ELogModule.ShortKeysExitView,
			ELogModule.MultiplayerCombat,
			ELogModule.CombatInfo,
			ELogModule.Controller,
			ELogModule.FilterSortView,
			ELogModule.Friend,
			ELogModule.Cursor,
			ELogModule.UiNavigation,
			ELogModule.UiNavigationHotKey,
			ELogModule.Chat,
			ELogModule.Track,
			ELogModule.Performance,
			ELogModule.GeneralLogicTree,
			ELogModule.Pay,
			ELogModule.TimeUtil,
			ELogModule.Gacha,
			ELogModule.Calabash,
			ELogModule.ItemExchange,
			ELogModule.AdventureGuide,
			ELogModule.Tutorial,
			ELogModule.Weather,
			ELogModule.InfoDisplay,
			ELogModule.Scene3dUi,
			ELogModule.LguiUtil,
			ELogModule.Cook,
			ELogModule.GenericLayoutNew,
			ELogModule.UiFloatContainer,
			ELogModule.InfluenceReputation,
			ELogModule.HudUnit,
			ELogModule.CycleTower,
			ELogModule.TowerDefense,
			ELogModule.Animal,
			ELogModule.Recorder,
			ELogModule.ManufactureCommon,
			ELogModule.Compose,
			ELogModule.Forging,
			ELogModule.UiLoginSceneManager,
			ELogModule.HotFixSceneManager,
			ELogModule.Advice,
			ELogModule.LocalStorage,
			ELogModule.ServerStorage,
			ELogModule.HandBook,
			ELogModule.ActorSystem,
			ELogModule.UiModelResourcesManager,
			ELogModule.NPC,
			ELogModule.BasePerform,
			ELogModule.Achievement,
			ELogModule.NewFlag,
			ELogModule.Heartbeat,
			ELogModule.UiManager,
			ELogModule.BattleUiSet,
			ELogModule.StackContainer,
			ELogModule.PlotContainer,
			ELogModule.DataTableUtil,
			ELogModule.PanelQte,
			ELogModule.CommonQte,
			ELogModule.ComboTeaching,
			ELogModule.Activity,
			ELogModule.Teleport,
			ELogModule.TeleportMisc,
			ELogModule.TextLanguageSearch,
			ELogModule.UiViewContainer,
			ELogModule.UiLayer,
			ELogModule.UiMask,
			ELogModule.UiImageSetting,
			ELogModule.UiPrefabLoad,
			ELogModule.PerfHeatmap,
			ELogModule.SeamlessTravel,
			ELogModule.Filter,
			ELogModule.Sort,
			ELogModule.UiTickConditionModule,
			ELogModule.TsUiSceneRoleActor,
			ELogModule.MultiTextCsvModule,
			ELogModule.BlackScreen,
			ELogModule.DynamicMaskButton,
			ELogModule.Roguelike,
			ELogModule.RogueBattle,
			ELogModule.SkipInterface,
			ELogModule.TickController,
			ELogModule.ExploreProgress,
			ELogModule.ExploreLevel,
			ELogModule.Blur,
			ELogModule.AndroidBack,
			ELogModule.CloudGame,
			ELogModule.FrequencyMonitor,
			ELogModule.Photo,
			ELogModule.PhotoCamera,
			ELogModule.FragmentMemory,
			ELogModule.Push,
			ELogModule.LogUpload,
			ELogModule.Perception,
			ELogModule.MoonChasing,
			ELogModule.MowingRisk,
			ELogModule.VersionPreheat,
			ELogModule.Spring25,
			ELogModule.SolarSpeed,
			ELogModule.InviteNewbie,
			ELogModule.RacingBets,
			ELogModule.RacingBetsDungeon,
			ELogModule.PortalGamePlay,
			ELogModule.ActivityRegress,
			ELogModule.Vehicle,
			ELogModule.ScratchTicket,
			ELogModule.FloroRanch,
			ELogModule.FloroRanchGamePlay,
			ELogModule.GameSettings,
			ELogModule.MobileInputSwitch,
			ELogModule.DreamLink,
			ELogModule.RoleSkin,
			ELogModule.WeaponSkin,
			ELogModule.FlySkin,
			ELogModule.Dockyard,
			ELogModule.FilterWithState,
			ELogModule.ResponsibilityChain,
			ELogModule.LevelPlayReport,
			ELogModule.ActivityDirectTrain,
			ELogModule.Optimization,
			ELogModule.Fishing,
			ELogModule.ShipTower,
			ELogModule.UiAsyncTask,
			ELogModule.WeeklyRogue,
			ELogModule.Chess,
			ELogModule.SummonGongduola,
			ELogModule.CiacconaGal,
			ELogModule.DangoMonopoly,
			ELogModule.TermExplanation,
			ELogModule.SplashScreenTask,
			ELogModule.PhantomArena,
			ELogModule.Shower,
			ELogModule.SceneItemCurveControl,
			ELogModule.TemplateEntitySpawner,
			ELogModule.ChargeSlash,
			ELogModule.Morale,
			ELogModule.LevelFlow,
			ELogModule.TimeDilation,
			ELogModule.KingShip,
			ELogModule.TuningStand,
			ELogModule.CommonGameMainView,
			ELogModule.TowerDefenseEvent,
			ELogModule.TowerDefenseBattle,
			ELogModule.TouchUiEdit,
			ELogModule.PsGamepadFeedback,
			ELogModule.HonamiStory,
			ELogModule.AnimNotify,
			ELogModule.ActivityFunPlay,
			ELogModule.HomeBtn,
			ELogModule.DailyActivity,
			ELogModule.RoleDev,
			ELogModule.SurvivorsRogue,
			ELogModule.FightPhotograph,
			ELogModule.Photograph,
			ELogModule.MeshStream,
			ELogModule.CalabashSkin,
			ELogModule.QuestTree,
			ELogModule.ActivityPreWarm,
			ELogModule.LevelListener,
			ELogModule.MultiTemplateScrollView,
			ELogModule.GridDelegate,
			ELogModule.MultiTemplateComponent,
			ELogModule.SubPackageDownLoad,
			ELogModule.Infrastructure,
			ELogModule.VillageInfr,
			ELogModule.RollBlock,
			ELogModule.AutoPilot,
			ELogModule.VehicleStream,
			ELogModule.Panoramic,
			ELogModule.Motor,
			ELogModule.PilotThrow,
			ELogModule.MovieMode,
			ELogModule.DeadEye,
			ELogModule.WheelTower,
			ELogModule.MotorParkour,
			ELogModule.MotorRailMove,
			ELogModule.PhantomInteraction,
			ELogModule.PhoneSystem,
			ELogModule.SunSpirit,
			ELogModule.Encircle,
			ELogModule.MotorFightActivity,
			ELogModule.ActivityTotalTopUp,
			ELogModule.SpringManor,
			ELogModule.GuessJokerCard,
			ELogModule.Drinks,
			ELogModule.DropCatch,
			ELogModule.RhythmGame,
			ELogModule.SlidingBlocks,
			ELogModule.Pinball,
			ELogModule.RoleOrnament,
			ELogModule.Decoration,
			ELogModule.FlagChallenge,
			ELogModule.BossPiling,
			ELogModule.PinballBattle,
			ELogModule.GolemHacking,
			ELogModule.ProjectorPuzzle,
			ELogModule.WeeklyChallenge,
			ELogModule.QuickHack,
			ELogModule.IosAudit,
			ELogModule.DollGrabMachine,
			ELogModule.Roverlike,
			ELogModule.MusicalInstrument,
			ELogModule.QuestMultiLine,
			ELogModule.PathDrivenActor,
			ELogModule.Capability,
			ELogModule.Sheriff,
			ELogModule.DangoBrawl,
			ELogModule.MatchThree,
			ELogModule.Giant,
			ELogModule.WuWaGo,
			ELogModule.Season,
			ELogModule.Kurotato,
			ELogModule.ComboTimeline
		};
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00009A98 File Offset: 0x00007C98
	public static string[] GetNames()
	{
		return new string[]
		{
			"Engine",
			"UiEditor",
			"ResourceCheck",
			"IllegalCodeCheck",
			"Temp",
			"HotPatch",
			"Log",
			"ExportProto",
			"Core",
			"Entity",
			"Event",
			"Json",
			"P4",
			"Config",
			"CommonDbConnect",
			"Pool",
			"Container",
			"UiCore",
			"Net",
			"Object",
			"Resource",
			"Tick",
			"Timer",
			"Game",
			"Render",
			"Preload",
			"StateMachine",
			"BehaviorTree",
			"Camera",
			"Character",
			"TextUtil",
			"Input",
			"InputSettings",
			"Level",
			"Audio",
			"Battle",
			"UiModel",
			"UiModelMorph",
			"BpBridge",
			"TaskGraph",
			"UiCommon",
			"ConfirmBox",
			"UiTabModule",
			"SceneTeam",
			"MultiPlayerTeam",
			"Formation",
			"DarkTide",
			"DarkTideRing",
			"ErrorCode",
			"Functional",
			"Gm",
			"Guide",
			"Inventory",
			"Item",
			"ItemHint",
			"LevelUp",
			"Login",
			"Mail",
			"Map",
			"MingSuTi",
			"Phantom",
			"Reconnect",
			"Reward",
			"RewardItem",
			"Role",
			"Personal",
			"Shop",
			"Tape",
			"UiCamera",
			"CameraAnimation",
			"UiComponent",
			"ModuleUtil",
			"Weapon",
			"Bullet",
			"Pawn",
			"SceneItem",
			"RenderCharacter",
			"RenderBattle",
			"RenderEffect",
			"RenderGI",
			"RenderScene",
			"RenderUtil",
			"World",
			"GameMode",
			"Movement",
			"Test",
			"LevelExperienceComponent",
			"LoopScrollView",
			"ScrollViewGrid",
			"LevelSequencePlayer",
			"GachaSequencePlayer",
			"UiSceneRoleActor",
			"CreateCharacter",
			"TimeOfDay",
			"ModelUtil",
			"Editor",
			"AI",
			"LevelAi",
			"PowerModule",
			"WorldLevel",
			"TriggerVolume",
			"GenericPrompt",
			"SceneGameplay",
			"SceneStep",
			"InstanceDungeon",
			"Quest",
			"QuestResource",
			"QuestRecall",
			"LevelPlay",
			"WuYinModel",
			"ControlScreen",
			"BuffItem",
			"Marquee",
			"Plot",
			"KuroSdk",
			"ResonanceEffect",
			"RoleResonance",
			"RedDot",
			"DebugView",
			"ProtocolMonitor",
			"LevelEvent",
			"LevelCondition",
			"LevelConditionRegistry",
			"UiSceneManager",
			"Loading",
			"GamePlayTimer",
			"Menu",
			"InputManager",
			"UiTimeDilation",
			"UiAnimation",
			"Interaction",
			"SneakUi",
			"CollectActor",
			"Video",
			"Area",
			"ElementBall",
			"Stat",
			"LogReport",
			"SaveUtil",
			"Platform",
			"PlatformSdk",
			"PublicUtil",
			"ShortKeysExitView",
			"MultiplayerCombat",
			"CombatInfo",
			"Controller",
			"FilterSortView",
			"Friend",
			"Cursor",
			"UiNavigation",
			"UiNavigationHotKey",
			"Chat",
			"Track",
			"Performance",
			"GeneralLogicTree",
			"Pay",
			"TimeUtil",
			"Gacha",
			"Calabash",
			"ItemExchange",
			"AdventureGuide",
			"Tutorial",
			"Weather",
			"InfoDisplay",
			"Scene3dUi",
			"LguiUtil",
			"Cook",
			"GenericLayoutNew",
			"UiFloatContainer",
			"InfluenceReputation",
			"HudUnit",
			"CycleTower",
			"TowerDefense",
			"Animal",
			"Recorder",
			"ManufactureCommon",
			"Compose",
			"Forging",
			"UiLoginSceneManager",
			"HotFixSceneManager",
			"Advice",
			"LocalStorage",
			"ServerStorage",
			"HandBook",
			"ActorSystem",
			"UiModelResourcesManager",
			"NPC",
			"BasePerform",
			"Achievement",
			"NewFlag",
			"Heartbeat",
			"UiManager",
			"BattleUiSet",
			"StackContainer",
			"PlotContainer",
			"DataTableUtil",
			"PanelQte",
			"CommonQte",
			"ComboTeaching",
			"Activity",
			"Teleport",
			"TeleportMisc",
			"TextLanguageSearch",
			"UiViewContainer",
			"UiLayer",
			"UiMask",
			"UiImageSetting",
			"UiPrefabLoad",
			"PerfHeatmap",
			"SeamlessTravel",
			"Filter",
			"Sort",
			"UiTickConditionModule",
			"TsUiSceneRoleActor",
			"MultiTextCsvModule",
			"BlackScreen",
			"DynamicMaskButton",
			"Roguelike",
			"RogueBattle",
			"SkipInterface",
			"TickController",
			"ExploreProgress",
			"ExploreLevel",
			"Blur",
			"AndroidBack",
			"CloudGame",
			"FrequencyMonitor",
			"Photo",
			"PhotoCamera",
			"FragmentMemory",
			"Push",
			"LogUpload",
			"Perception",
			"MoonChasing",
			"MowingRisk",
			"VersionPreheat",
			"Spring25",
			"SolarSpeed",
			"InviteNewbie",
			"RacingBets",
			"RacingBetsDungeon",
			"PortalGamePlay",
			"ActivityRegress",
			"Vehicle",
			"ScratchTicket",
			"FloroRanch",
			"FloroRanchGamePlay",
			"GameSettings",
			"MobileInputSwitch",
			"DreamLink",
			"RoleSkin",
			"WeaponSkin",
			"FlySkin",
			"Dockyard",
			"FilterWithState",
			"ResponsibilityChain",
			"LevelPlayReport",
			"ActivityDirectTrain",
			"Optimization",
			"Fishing",
			"ShipTower",
			"UiAsyncTask",
			"WeeklyRogue",
			"Chess",
			"SummonGongduola",
			"CiacconaGal",
			"DangoMonopoly",
			"TermExplanation",
			"SplashScreenTask",
			"PhantomArena",
			"Shower",
			"SceneItemCurveControl",
			"TemplateEntitySpawner",
			"ChargeSlash",
			"Morale",
			"LevelFlow",
			"TimeDilation",
			"KingShip",
			"TuningStand",
			"CommonGameMainView",
			"TowerDefenseEvent",
			"TowerDefenseBattle",
			"TouchUiEdit",
			"PsGamepadFeedback",
			"HonamiStory",
			"AnimNotify",
			"ActivityFunPlay",
			"HomeBtn",
			"DailyActivity",
			"RoleDev",
			"SurvivorsRogue",
			"FightPhotograph",
			"Photograph",
			"MeshStream",
			"CalabashSkin",
			"QuestTree",
			"ActivityPreWarm",
			"LevelListener",
			"MultiTemplateScrollView",
			"GridDelegate",
			"MultiTemplateComponent",
			"SubPackageDownLoad",
			"Infrastructure",
			"VillageInfr",
			"RollBlock",
			"AutoPilot",
			"VehicleStream",
			"Panoramic",
			"Motor",
			"PilotThrow",
			"MovieMode",
			"DeadEye",
			"WheelTower",
			"MotorParkour",
			"MotorRailMove",
			"PhantomInteraction",
			"PhoneSystem",
			"SunSpirit",
			"Encircle",
			"MotorFightActivity",
			"ActivityTotalTopUp",
			"SpringManor",
			"GuessJokerCard",
			"Drinks",
			"DropCatch",
			"RhythmGame",
			"SlidingBlocks",
			"Pinball",
			"RoleOrnament",
			"Decoration",
			"FlagChallenge",
			"BossPiling",
			"PinballBattle",
			"GolemHacking",
			"ProjectorPuzzle",
			"WeeklyChallenge",
			"QuickHack",
			"IosAudit",
			"DollGrabMachine",
			"Roverlike",
			"MusicalInstrument",
			"QuestMultiLine",
			"PathDrivenActor",
			"Capability",
			"Sheriff",
			"DangoBrawl",
			"MatchThree",
			"Giant",
			"WuWaGo",
			"Season",
			"Kurotato",
			"ComboTimeline"
		};
	}
}

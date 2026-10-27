using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058EF RID: 22767
	public static class DungeonExitHandlerDefine
	{
		// Token: 0x06039D16 RID: 236822 RVA: 0x00DBB9B8 File Offset: 0x00DB9BB8
		// Note: this type is marked as 'beforefieldinit'.
		static DungeonExitHandlerDefine()
		{
			Dictionary<EDungeonSubType, InstanceDungeonExitHandlerBase> dictionary = new Dictionary<EDungeonSubType, InstanceDungeonExitHandlerBase>();
			dictionary[EDungeonSubType.TowerDefense] = new TowerDefenseExitHandler();
			dictionary[EDungeonSubType.BabelTower] = new BattleBabelTowerExitHandler();
			dictionary[EDungeonSubType.ShipTower] = new BattleShipTowerExitHandler();
			dictionary[EDungeonSubType.RogueRes] = new MapRogueExitHandler();
			dictionary[EDungeonSubType.Roguelike] = new RoguelikeExitHandler();
			dictionary[EDungeonSubType.WeeklyRogue] = new RoguelikeExitHandler();
			dictionary[EDungeonSubType.NewSingleTower] = new TowerExitHandler();
			dictionary[EDungeonSubType.NewLoopTower] = new TowerExitHandler();
			dictionary[EDungeonSubType.FightPhoto] = new FightPhotoExitHandler();
			dictionary[EDungeonSubType.RoleTrial] = new RoleTrialExitHandler();
			dictionary[EDungeonSubType.LordInInstance] = new LordInInstanceExitHandler();
			dictionary[EDungeonSubType.HonamiStory] = new HonamiStoryExitHandler();
			dictionary[EDungeonSubType.Boss] = new LordInInstanceExitHandler();
			dictionary[EDungeonSubType.LordGym] = new LordGymExitHandler();
			dictionary[EDungeonSubType.NewTowerClimbing] = new WheelTowerExitHandler();
			dictionary[EDungeonSubType.MotorcycleArrow] = new MotorFightExitHandler();
			dictionary[EDungeonSubType.RhythmShip] = new RhythmShipExitHandler();
			dictionary[EDungeonSubType.FlagChallenge] = new FlagChallengeExitHandler();
			dictionary[EDungeonSubType.BossPiling] = new BossPilingExitHandler();
			dictionary[EDungeonSubType.AdamSmasher] = new AdamSmasherExitHandler();
			dictionary[EDungeonSubType.MultiMotor] = new MultiMotorExitHandler();
			dictionary[EDungeonSubType.Kurotato] = new KurotatoExitHandler();
			dictionary[EDungeonSubType.PlayInstShare] = new LordInInstanceExitHandler();
			dictionary[EDungeonSubType.MonsterSettlementInstShare] = new LordInInstanceExitHandler();
			dictionary[EDungeonSubType.NightmareLordInstShare] = new LordInInstanceExitHandler();
			dictionary[EDungeonSubType.LordInstShare] = new LordInInstanceExitHandler();
			dictionary[EDungeonSubType.SilentAreaInstShare] = new LordInInstanceExitHandler();
			dictionary[EDungeonSubType.DangoBrawl] = new DangoBrawlExitHandler();
			dictionary[EDungeonSubType.RoverRogue] = new RoverlikeExitHandler();
			DungeonExitHandlerDefine.DungeonExitHandlerMap = dictionary;
		}

		// Token: 0x0401E2D6 RID: 123606
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EDungeonSubType, InstanceDungeonExitHandlerBase> DungeonExitHandlerMap;
	}
}

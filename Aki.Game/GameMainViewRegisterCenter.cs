using System;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GameMainView.DangoBrawl;
using CSharpScript.Game.Module.GameMainView.PinballBattle;

// Token: 0x02001CB1 RID: 7345
public class GameMainViewRegisterCenter
{
	// Token: 0x0600DDF9 RID: 56825 RVA: 0x0033E284 File Offset: 0x0033C484
	public static void Init()
	{
		GameMainViewStorage.RegisterMainViewInfo(EDungeonSubType.TowerDefenseEvent, typeof(TrapDefenseMainViewProxy));
		GameMainViewStorage.RegisterMainViewInfo(EDungeonSubType.Survivors, typeof(SurvivorsRogueMainViewProxy));
		GameMainViewStorage.RegisterMainViewInfo(EDungeonSubType.DangoBrawl, typeof(DangoBrawlMainViewProxy));
		GameMainViewStorage.RegisterMainViewInfo(EDungeonSubType.MotorcycleArrow, typeof(MotorcycleArrowMainViewProxy));
		GameMainViewStorage.RegisterMainViewInfo(EDungeonSubType.Kurotato, typeof(KurotatoMainViewProxy));
		GameMainViewStorage.RegisterMainViewInfo(EDungeonSubType.PinballBattle, typeof(PinballBattleMainViewProxy));
		GameMainViewStorage.RegisterMainViewInfoWorldInstance(EWorldDungeonSubType.SpringManorWorld, typeof(SpringManorMainViewProxy));
	}
}

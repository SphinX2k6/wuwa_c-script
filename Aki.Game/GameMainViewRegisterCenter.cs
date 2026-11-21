using System;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GameMainView.DangoBrawl;
using CSharpScript.Game.Module.GameMainView.PinballBattle;

// Token: 0x02001173 RID: 4467
public class GameMainViewRegisterCenter
{
	// Token: 0x0600B216 RID: 45590 RVA: 0x00349CC0 File Offset: 0x00347EC0
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

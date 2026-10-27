using System;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x02001D28 RID: 7464
public class TrapDefenseBattleSkillExploreItem : BattleSkillExploreItem
{
	// Token: 0x0600E219 RID: 57881 RVA: 0x00351BDC File Offset: 0x0034FDDC
	protected override void OpenRouletteMainView(int touchId)
	{
		TrapDefenseRouletteMainViewProxy trapDefenseRouletteMainViewProxy = new TrapDefenseRouletteMainViewProxy();
		trapDefenseRouletteMainViewProxy.TouchId = new int?(touchId);
		RouletteController.Instance.OpenRouletteMainView(trapDefenseRouletteMainViewProxy);
	}
}

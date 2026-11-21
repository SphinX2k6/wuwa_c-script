using System;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x020011EA RID: 4586
public class TrapDefenseBattleSkillExploreItem : BattleSkillExploreItem
{
	// Token: 0x0600B636 RID: 46646 RVA: 0x0035D60C File Offset: 0x0035B80C
	protected override void OpenRouletteMainView(int touchId)
	{
		TrapDefenseRouletteMainViewProxy trapDefenseRouletteMainViewProxy = new TrapDefenseRouletteMainViewProxy();
		trapDefenseRouletteMainViewProxy.TouchId = new int?(touchId);
		RouletteController.Instance.OpenRouletteMainView(trapDefenseRouletteMainViewProxy);
	}
}

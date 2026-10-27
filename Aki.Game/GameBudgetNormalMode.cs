using System;
using CSharpScript.Game;

// Token: 0x02001CAB RID: 7339
public class GameBudgetNormalMode : GameBudgetMode
{
	// Token: 0x0600DD9A RID: 56730 RVA: 0x0033D47A File Offset: 0x0033B67A
	public GameBudgetNormalMode() : base("EGameBudgetMode.Normal", EGameBudgetMode.Normal)
	{
	}

	// Token: 0x0600DD9B RID: 56731 RVA: 0x0033D488 File Offset: 0x0033B688
	public override void OnEnterMode()
	{
		GameBudgetInterfaceController.Instance.SetCenterRole(Global.BaseCharacter);
	}
}

using System;
using CSharpScript.Game;

// Token: 0x0200116D RID: 4461
public class GameBudgetNormalMode : GameBudgetMode
{
	// Token: 0x0600B1BF RID: 45503 RVA: 0x00348DE8 File Offset: 0x00346FE8
	public GameBudgetNormalMode() : base("EGameBudgetMode.Normal", EGameBudgetMode.Normal)
	{
		base.Active("centerRole", delegate
		{
			GameBudgetController.Instance.ApplyCenterRole(Global.BaseCharacter);
		}, delegate
		{
		});
	}
}

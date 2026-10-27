using System;
using System.Runtime.CompilerServices;

// Token: 0x02001CAA RID: 7338
public class GameBudgetMode : GameBudgetModeBase
{
	// Token: 0x0600DD95 RID: 56725 RVA: 0x0033D464 File Offset: 0x0033B664
	[NullableContext(1)]
	public GameBudgetMode(string modeName, EGameBudgetMode gameBudgetMode) : base(modeName, gameBudgetMode)
	{
	}

	// Token: 0x0600DD96 RID: 56726 RVA: 0x0033D46E File Offset: 0x0033B66E
	public virtual bool AllowSwitchMode()
	{
		return true;
	}

	// Token: 0x0600DD97 RID: 56727 RVA: 0x0033D471 File Offset: 0x0033B671
	public virtual bool AllowSetCenterActor()
	{
		return true;
	}

	// Token: 0x0600DD98 RID: 56728 RVA: 0x0033D474 File Offset: 0x0033B674
	public virtual bool AllowSetCenterOffset()
	{
		return true;
	}

	// Token: 0x0600DD99 RID: 56729 RVA: 0x0033D477 File Offset: 0x0033B677
	public virtual bool AllowAddAssistantActor()
	{
		return true;
	}
}

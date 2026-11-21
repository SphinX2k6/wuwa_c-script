using System;
using System.Runtime.CompilerServices;

// Token: 0x020000AE RID: 174
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetModeBase
{
	// Token: 0x0600057A RID: 1402 RVA: 0x0001C4D7 File Offset: 0x0001A6D7
	public GameBudgetModeBase(string ModeName, EGameBudgetMode GameBudgetMode)
	{
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0001C4ED File Offset: 0x0001A6ED
	public virtual void OnEnterMode()
	{
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x0001C4EF File Offset: 0x0001A6EF
	public virtual void OnExitMode()
	{
	}

	// Token: 0x04000461 RID: 1121
	public string GameBudgetModeName = ModeName;

	// Token: 0x04000462 RID: 1122
	public EGameBudgetMode Mode = GameBudgetMode;
}

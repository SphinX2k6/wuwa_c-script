using System;
using System.Runtime.CompilerServices;

// Token: 0x020000AC RID: 172
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetModeBase
{
	// Token: 0x06000539 RID: 1337 RVA: 0x0001BDEF File Offset: 0x00019FEF
	public GameBudgetModeBase(string ModeName, EGameBudgetMode GameBudgetMode)
	{
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0001BE05 File Offset: 0x0001A005
	public virtual void OnEnterMode()
	{
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0001BE07 File Offset: 0x0001A007
	public virtual void OnExitMode()
	{
	}

	// Token: 0x04000453 RID: 1107
	public string GameBudgetModeName = ModeName;

	// Token: 0x04000454 RID: 1108
	public EGameBudgetMode Mode = GameBudgetMode;
}

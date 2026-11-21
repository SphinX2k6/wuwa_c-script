using System;

// Token: 0x0200116B RID: 4459
public readonly struct GameBudgetModeToken
{
	// Token: 0x0600B1AF RID: 45487 RVA: 0x00348C7D File Offset: 0x00346E7D
	public GameBudgetModeToken(EGameBudgetMode mode, long id)
	{
		this.Mode = mode;
		this.Id = id;
	}

	// Token: 0x17001226 RID: 4646
	// (get) Token: 0x0600B1B0 RID: 45488 RVA: 0x00348C8D File Offset: 0x00346E8D
	public bool IsValid
	{
		get
		{
			return this.Id != 0L;
		}
	}

	// Token: 0x0400669A RID: 26266
	public readonly EGameBudgetMode Mode;

	// Token: 0x0400669B RID: 26267
	public readonly long Id;
}

using System;

// Token: 0x020000A5 RID: 165
public interface IGameBudgetTimeEstimation
{
	// Token: 0x06000526 RID: 1318
	void Initialize();

	// Token: 0x06000527 RID: 1319
	void SetMaximumFrameRate(int fps);

	// Token: 0x06000528 RID: 1320
	void UpdateBudgetTime(float delta);
}

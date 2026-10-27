using System;

// Token: 0x020000A3 RID: 163
public interface IGameBudgetTimeEstimation
{
	// Token: 0x060004E5 RID: 1253
	void Initialize();

	// Token: 0x060004E6 RID: 1254
	void SetMaximumFrameRate(int fps);

	// Token: 0x060004E7 RID: 1255
	void UpdateBudgetTime(float delta);
}

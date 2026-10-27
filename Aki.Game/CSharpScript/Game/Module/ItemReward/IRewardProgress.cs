using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057C4 RID: 22468
	public interface IRewardProgress
	{
		// Token: 0x17008994 RID: 35220
		// (get) Token: 0x0603922E RID: 234030
		// (set) Token: 0x0603922F RID: 234031
		int FromProgress { get; set; }

		// Token: 0x17008995 RID: 35221
		// (get) Token: 0x06039230 RID: 234032
		// (set) Token: 0x06039231 RID: 234033
		int ToProgress { get; set; }

		// Token: 0x17008996 RID: 35222
		// (get) Token: 0x06039232 RID: 234034
		// (set) Token: 0x06039233 RID: 234035
		int MaxProgress { get; set; }
	}
}

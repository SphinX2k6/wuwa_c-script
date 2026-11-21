using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Reward
{
	// Token: 0x02003ED4 RID: 16084
	[NullableContext(1)]
	public interface IRewardEventType
	{
		// Token: 0x170052E5 RID: 21221
		// (get) Token: 0x06028C9D RID: 167069
		Action HandleItemReward { get; }

		// Token: 0x170052E6 RID: 21222
		// (get) Token: 0x06028C9E RID: 167070
		Action HandleAddFightDropInfo { get; }

		// Token: 0x170052E7 RID: 21223
		// (get) Token: 0x06028C9F RID: 167071
		Action HandleDeleteFightDropInfo { get; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Reward
{
	// Token: 0x02004F0B RID: 20235
	[NullableContext(1)]
	public interface IRewardEventType
	{
		// Token: 0x17007F35 RID: 32565
		// (get) Token: 0x06033E32 RID: 212530
		Action HandleItemReward { get; }

		// Token: 0x17007F36 RID: 32566
		// (get) Token: 0x06033E33 RID: 212531
		Action HandleAddFightDropInfo { get; }

		// Token: 0x17007F37 RID: 32567
		// (get) Token: 0x06033E34 RID: 212532
		Action HandleDeleteFightDropInfo { get; }
	}
}

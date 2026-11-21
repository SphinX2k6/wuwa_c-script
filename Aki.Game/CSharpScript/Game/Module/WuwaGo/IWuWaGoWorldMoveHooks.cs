using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200363A RID: 13882
	[NullableContext(2)]
	public interface IWuWaGoWorldMoveHooks
	{
		// Token: 0x1700497D RID: 18813
		// (get) Token: 0x0602404D RID: 147533
		// (set) Token: 0x0602404E RID: 147534
		Action OnStart { get; set; }

		// Token: 0x1700497E RID: 18814
		// (get) Token: 0x0602404F RID: 147535
		// (set) Token: 0x06024050 RID: 147536
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<Vector> OnRunning { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700497F RID: 18815
		// (get) Token: 0x06024051 RID: 147537
		// (set) Token: 0x06024052 RID: 147538
		Action OnEnterSettle { get; set; }

		// Token: 0x17004980 RID: 18816
		// (get) Token: 0x06024053 RID: 147539
		// (set) Token: 0x06024054 RID: 147540
		Action OnFinish { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200470A RID: 18186
	[NullableContext(2)]
	public interface IWuWaGoWorldMoveHooks
	{
		// Token: 0x170076C1 RID: 30401
		// (get) Token: 0x0602F887 RID: 194695
		// (set) Token: 0x0602F888 RID: 194696
		Action OnStart { get; set; }

		// Token: 0x170076C2 RID: 30402
		// (get) Token: 0x0602F889 RID: 194697
		// (set) Token: 0x0602F88A RID: 194698
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

		// Token: 0x170076C3 RID: 30403
		// (get) Token: 0x0602F88B RID: 194699
		// (set) Token: 0x0602F88C RID: 194700
		Action OnEnterSettle { get; set; }

		// Token: 0x170076C4 RID: 30404
		// (get) Token: 0x0602F88D RID: 194701
		// (set) Token: 0x0602F88E RID: 194702
		Action OnFinish { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x0200349B RID: 13467
	[NullableContext(1)]
	public interface IReceiver<[Nullable(0)] T> where T : ICommandType
	{
		// Token: 0x1700483E RID: 18494
		// (get) Token: 0x06022535 RID: 140597
		// (set) Token: 0x06022536 RID: 140598
		Action<TCommandHandleParams<T>> ReceiveExecute { get; set; }

		// Token: 0x1700483F RID: 18495
		// (get) Token: 0x06022537 RID: 140599
		// (set) Token: 0x06022538 RID: 140600
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		Action<TCommandHandleParams<T>> ReceiveUndo { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }
	}
}

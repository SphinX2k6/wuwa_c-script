using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x020034A6 RID: 13478
	public class CommandSwallowInvoker : CommandInvoker
	{
		// Token: 0x06022560 RID: 140640 RVA: 0x009B9488 File Offset: 0x009B7688
		[NullableContext(1)]
		public new void SubmitCommand<[Nullable(0)] T>(IGameCommand<T> command, bool immediatelyExecuteCommands) where T : ICommandType
		{
		}

		// Token: 0x06022561 RID: 140641 RVA: 0x009B948A File Offset: 0x009B768A
		public new void ExecuteAllCommand()
		{
		}

		// Token: 0x06022562 RID: 140642 RVA: 0x009B948C File Offset: 0x009B768C
		public new void Undo()
		{
		}
	}
}

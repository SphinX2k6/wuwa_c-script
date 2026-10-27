using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x0200457E RID: 17790
	public class CommandSwallowInvoker : CommandInvoker
	{
		// Token: 0x0602DE7E RID: 188030 RVA: 0x00A8DD70 File Offset: 0x00A8BF70
		[NullableContext(1)]
		public new void SubmitCommand<[Nullable(0)] T>(IGameCommand<T> command, bool immediatelyExecuteCommands) where T : ICommandType
		{
		}

		// Token: 0x0602DE7F RID: 188031 RVA: 0x00A8DD72 File Offset: 0x00A8BF72
		public new void ExecuteAllCommand()
		{
		}

		// Token: 0x0602DE80 RID: 188032 RVA: 0x00A8DD74 File Offset: 0x00A8BF74
		public new void Undo()
		{
		}
	}
}

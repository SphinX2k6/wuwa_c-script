using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x0200457D RID: 17789
	[NullableContext(1)]
	[Nullable(0)]
	public class CommandInvoker
	{
		// Token: 0x0602DE78 RID: 188024 RVA: 0x00A8DB69 File Offset: 0x00A8BD69
		public void SubmitCommand<[Nullable(0)] T>(IGameCommand<T> command, bool immediatelyExecuteCommands) where T : ICommandType
		{
			this.CommandQueue.Push(command);
			if (immediatelyExecuteCommands)
			{
				this.ExecuteAllCommand();
			}
		}

		// Token: 0x0602DE79 RID: 188025 RVA: 0x00A8DB80 File Offset: 0x00A8BD80
		public void ExecuteAllCommand()
		{
			CommandInvoker.<>c__DisplayClass2_0 CS$<>8__locals1;
			CS$<>8__locals1.notValidCommands = new List<IGameCommandBase>();
			for (int i = 0; i < this.CommandQueue.Size; i++)
			{
				IGameCommandBase gameCommandBase = this.CommandQueue.Get(i);
				if (gameCommandBase != null)
				{
					IGameCommand<ICommandTypeAddFollower> gameCommand = gameCommandBase as IGameCommand<ICommandTypeAddFollower>;
					if (gameCommand == null)
					{
						IGameCommand<ICommandTypeRemoveFollower> gameCommand2 = gameCommandBase as IGameCommand<ICommandTypeRemoveFollower>;
						if (gameCommand2 == null)
						{
							IGameCommand<ICommandTypeFlushFollower> gameCommand3 = gameCommandBase as IGameCommand<ICommandTypeFlushFollower>;
							if (gameCommand3 != null)
							{
								CommandInvoker.<ExecuteAllCommand>g__SingleCommandTask|2_0<ICommandTypeFlushFollower>(gameCommand3, ref CS$<>8__locals1);
							}
						}
						else
						{
							CommandInvoker.<ExecuteAllCommand>g__SingleCommandTask|2_0<ICommandTypeRemoveFollower>(gameCommand2, ref CS$<>8__locals1);
						}
					}
					else
					{
						CommandInvoker.<ExecuteAllCommand>g__SingleCommandTask|2_0<ICommandTypeAddFollower>(gameCommand, ref CS$<>8__locals1);
					}
				}
			}
			this.CommandQueue.Clear();
			foreach (IGameCommandBase element in CS$<>8__locals1.notValidCommands)
			{
				this.CommandQueue.Push(element);
			}
		}

		// Token: 0x0602DE7A RID: 188026 RVA: 0x00A8DC5C File Offset: 0x00A8BE5C
		public void ClearAllCommand()
		{
			this.CommandQueue.Clear();
		}

		// Token: 0x0602DE7B RID: 188027 RVA: 0x00A8DC69 File Offset: 0x00A8BE69
		public void Undo()
		{
		}

		// Token: 0x0602DE7D RID: 188029 RVA: 0x00A8DC80 File Offset: 0x00A8BE80
		[CompilerGenerated]
		internal static void <ExecuteAllCommand>g__SingleCommandTask|2_0<T>(IGameCommand<T> command, ref CommandInvoker.<>c__DisplayClass2_0 A_1) where T : ICommandType
		{
			bool flag = true;
			GameCommandWithValidators<T> gameCommandWithValidators = command as GameCommandWithValidators<T>;
			if (gameCommandWithValidators != null)
			{
				using (HashSet<IValidator>.Enumerator enumerator = gameCommandWithValidators.Validators.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.Validate())
						{
							A_1.notValidCommands.Add(command);
							flag = false;
							break;
						}
					}
				}
			}
			if (!flag)
			{
				return;
			}
			if (command != null && command.Params != null)
			{
				if (command.Execute != null)
				{
					command.Execute(command.Params);
				}
				IGameCommandWithReceivers<T> gameCommandWithReceivers = command as IGameCommandWithReceivers<T>;
				if (gameCommandWithReceivers != null)
				{
					foreach (IReceiver<T> receiver in gameCommandWithReceivers.Receivers)
					{
						receiver.ReceiveExecute(command.Params);
					}
				}
			}
		}

		// Token: 0x0401883D RID: 100413
		private readonly Queue<IGameCommandBase> CommandQueue = new Queue<IGameCommandBase>(4);
	}
}
